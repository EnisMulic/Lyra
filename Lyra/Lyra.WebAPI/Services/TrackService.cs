using AutoMapper;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class TrackService : ITrackService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public TrackService(LyraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Track> Get(TrackSearchRequest request)
        {
            var query = _context.Tracks.AsQueryable();

            if(!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Track>>(list);
        }

        public Model.Track GetById(int id)
        {
            var item = _context.Tracks.Find(id);
            return _mapper.Map<Model.Track>(item);
        }

        public Model.Track Insert(TrackInsertRequest request)
        {
            var entity = _mapper.Map<Database.Track>(request);
            _context.Tracks.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Track>(entity);
        }
    }
}
