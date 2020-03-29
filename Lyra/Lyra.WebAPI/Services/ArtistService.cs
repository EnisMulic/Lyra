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
    public class ArtistService : CRUDService<Model.Artist, ArtistSearchRequest, Artist, ArtistUpsertRequest, ArtistUpsertRequest>
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
            var query = _context.Tracks.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.Artist>>(list);
        }
    }
}
