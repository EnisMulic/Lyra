using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Lyra.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class GenreService : CRUDService<Model.Genre, GenreSearchRequest, Database.Genre, GenreUpsertRequest, GenreUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public GenreService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Genre>> Get(GenreSearchRequest request)
        {
            var query = _context.Genres.AsQueryable();

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

            return _mapper.Map<List<Model.Genre>>(list);
        }

        public override async Task<Model.Genre> Insert(GenreUpsertRequest request)
        {
            if(await _context.Genres.AnyAsync(i => i.Name == request.Name))
            {
                throw new UserException("Genre already exists!");
            }
            var entity = _mapper.Map<Database.Genre>(request);

            _context.Set<Database.Genre>().Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Genre>(entity);
        }

        public override async Task<Model.Genre> Update(int id, GenreUpsertRequest request)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (await _context.Genres.AnyAsync(i => i.Name == request.Name) && request.Name != genre.Name)
            {
                throw new UserException("Genre already exists!");
            }

            var entity = _context.Set<Genre>().Find(id);
            _context.Set<Genre>().Attach(entity);
            _context.Set<Genre>().Update(entity);

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Genre>(entity);
        }
    }
}
