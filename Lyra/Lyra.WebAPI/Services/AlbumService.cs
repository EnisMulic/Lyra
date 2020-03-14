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
    public class AlbumService : IAlbumService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public AlbumService(LyraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Album> Get(AlbumSearchRequest request)
        {
            var query = _context.Albums.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }

            

            var list = query.ToList();

            return _mapper.Map<List<Model.Album>>(list);
        }

        public Model.Album GetById(int id)
        {
            var item = _context.Albums.Find(id);
            return _mapper.Map<Model.Album>(item);
        }

        public Model.Album Insert(AlbumInsertRequest request)
        {
            var entity = _mapper.Map<Database.Album>(request);
            _context.Albums.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Album>(entity);
        }
    }
}
