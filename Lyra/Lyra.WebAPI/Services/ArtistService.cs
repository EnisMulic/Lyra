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
    public class ArtistService : CRUDService<Model.Artist, ArtistSearchRequest, Database.Artist, ArtistUpsertRequest, ArtistUpsertRequest>, IArtistService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public ArtistService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Artist>> Get(ArtistSearchRequest request)
        {
            var query = _context.Artists.AsQueryable();

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

            return _mapper.Map<List<Model.Artist>>(list);
        }

        public async Task<List<Model.Album>> GetAlbums(int ID)
        {
            var list = await _context.Albums
                .Where(i => i.ArtistID == ID)
                .ToListAsync();

            return _mapper.Map<List<Model.Album>>(list);
        }

        public async Task<List<Model.Track>> GetTracks(int ID)
        {
            var list = await _context.TrackArtists
                .Include(i => i.Track)
                .Where(i => i.ArtistID == ID)
                .Select(i => i.Track)
                .ToListAsync();
            

            return _mapper.Map<List<Model.Track>>(list);
        }
    }
}
