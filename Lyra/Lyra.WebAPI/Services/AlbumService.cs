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
    public class AlbumService : CRUDService<Model.Album, AlbumSearchRequest, Database.Album, AlbumUpsertRequest, AlbumUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public AlbumService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.Album> Get(AlbumSearchRequest request)
        {
            var query = _context.Albums.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }



            var list = query.ToList();

            return _mapper.Map<List<Model.Album>>(list);
        }

        
    }
}
