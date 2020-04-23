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



            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.Album>>(list);
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
                var albumTrack = new Database.AlbumTracks()
                {
                    AlbumID = entity.ID,
                    TrackID = trackID
                };
                _context.AlbumTracks.Add(albumTrack);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Album>(entity);
        }
    }
}
