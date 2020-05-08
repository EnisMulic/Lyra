using AutoMapper;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class AlbumService : CRUDService<Model.Album, AlbumSearchRequest, Database.Album, AlbumUpsertRequest, AlbumUpsertRequest>, IAlbumService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public AlbumService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Album>> Get(AlbumSearchRequest request)
        {
            var query = _context.Albums.AsQueryable();

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

            return _mapper.Map<List<Model.Album>>(list);
        }

        public override async Task<Model.Album> GetById(int id)
        {
            var entity = await _context.Albums
                .Include(i => i.AlbumTracks)
                .Where(i => i.ID == id)
                .SingleOrDefaultAsync();

            return _mapper.Map<Model.Album>(entity);
        }

        public async Task<List<Model.Track>> GetTracks(int ID)
        {
            var list = await _context.AlbumTracks
                .Include(i => i.Track)
                .Where(i => i.AlbumID == ID)
                .Select(i => i.Track)
                .ToListAsync();

            return _mapper.Map<List<Model.Track>>(list);
        }

        public override async Task<Model.Album> Insert(AlbumUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Album>(request);

            await _context.Albums.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var trackID in request.Tracks)
            {
                var albumTrack = new Database.AlbumTrack()
                {
                    AlbumID = entity.ID,
                    TrackID = trackID
                };
                _context.AlbumTracks.Add(albumTrack);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Album>(entity);
        }

        public override async Task<Model.Album> Update(int id, AlbumUpsertRequest request)
        {
            var entity = _context.Albums.Find(id);
            _context.Albums.Attach(entity);
            _context.Albums.Update(entity);


            foreach (var TrackID in request.Tracks)
            {
                var albumTrack = await _context.AlbumTracks
                    .Where(i => i.TrackID == TrackID && i.AlbumID == id)
                    .SingleOrDefaultAsync();

                if (albumTrack == null)
                {
                    var newAlbumTrack = new Database.AlbumTrack()
                    {
                        AlbumID = id,
                        TrackID = TrackID
                    };
                    await _context.Set<Database.AlbumTrack>().AddAsync(newAlbumTrack);
                }
            }


            foreach (var TrackID in request.TracksToDelete)
            {
                var albumTrack = await _context.AlbumTracks
                    .Where(i => i.TrackID == TrackID && i.AlbumID == id)
                    .SingleOrDefaultAsync();

                if (albumTrack != null)
                {
                    _context.Set<Database.AlbumTrack>().Remove(albumTrack);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Album>(entity);
        }
    }
}
