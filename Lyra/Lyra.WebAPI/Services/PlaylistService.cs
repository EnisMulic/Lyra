using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class PlaylistService : CRUDService<Model.Playlist, PlaylistSearchRequest, Database.Playlist, PlaylistUpsertRequest, PlaylistUpsertRequest>, IPlaylistService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public PlaylistService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Playlist>> Get(PlaylistSearchRequest request)
        {
            var query = _context.Playlists.AsQueryable();

            if(request.UserID != 0)
            {
                query = query.Where(i => i.UserID == request.UserID);
            }


            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.Playlist>>(list);
        }

        public override async Task<Model.Playlist> GetById(int id)
        {
            var entity = await _context.Playlists
                .Include(i => i.PlaylistTracks)
                .Include(i => i.User)
                .Where(i => i.ID == id)
                .SingleOrDefaultAsync();

            return _mapper.Map<Model.Playlist>(entity);
        }

        public async Task<List<Model.Track>> GetTracks(int ID)
        {
            var list = await _context.PlaylistTracks
                .Include(i => i.Track)
                .Where(i => i.PlaylistID == ID)
                .Select(i => i.Track)
                .ToListAsync();

            return _mapper.Map<List<Model.Track>>(list);
        }

        public override async Task<Model.Playlist> Insert(PlaylistUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Playlist>(request);

            await _context.Playlists.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var trackID in request.Tracks)
            {
                var playlistTrack = new Database.PlaylistTrack()
                {
                    PlaylistID = entity.ID,
                    TrackID = trackID
                };
                await _context.PlaylistTracks.AddAsync(playlistTrack);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Playlist>(entity);
        }

        public override async Task<Model.Playlist> Update(int id, PlaylistUpsertRequest request)
        {
            var entity = _context.Playlists.Find(id);
            _context.Playlists.Attach(entity);
            _context.Playlists.Update(entity);


            foreach (var TrackID in request.Tracks)
            {
                var playlistTrack = await _context.PlaylistTracks
                    .Where(i => i.TrackID == TrackID && i.PlaylistID == id)
                    .SingleOrDefaultAsync();

                if (playlistTrack == null)
                {
                    var newPlaylistTrack = new PlaylistTrack()
                    {
                        PlaylistID = id,
                        TrackID = TrackID
                    };
                    await _context.Set<PlaylistTrack>().AddAsync(newPlaylistTrack);
                }
            }


            foreach (var TrackID in request.TracksToDelete)
            {
                var playlistTrack = await _context.PlaylistTracks
                    .Where(i => i.TrackID == TrackID && i.PlaylistID == id)
                    .SingleOrDefaultAsync();

                if (playlistTrack != null)
                {
                    _context.Set<PlaylistTrack>().Remove(playlistTrack);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Playlist>(entity);
        }
    }
}
