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
    public class TrackService : CRUDService<Model.Track, TrackSearchRequest, Database.Track, TrackUpsertRequest, TrackUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public TrackService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Track>> Get(TrackSearchRequest request)
        {
            var query = _context.Tracks.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.Track>>(list);
        }
    }

}
