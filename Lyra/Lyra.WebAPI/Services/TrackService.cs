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

        public IList<Model.Track> Get()
        {
            var list = _context.Track.ToList();
            return _mapper.Map<List<Model.Track>>(list);
        }

        public Model.Track GetById(int id)
        {
            var item = _context.Track.Find(id);
            return _mapper.Map<Model.Track>(item);
        }

        public Model.Track Insert(TrackInsertRequest request)
        {
            var entity = _mapper.Map<Database.Track>(request);
            _context.Track.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Track>(entity);
        }
    }
}
