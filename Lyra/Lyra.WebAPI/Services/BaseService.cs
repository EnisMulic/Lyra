using AutoMapper;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class BaseSevice<TModel, TSearch, TDatabase> : IBaseService<TModel, TSearch> where TDatabase: class
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public BaseSevice(LyraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        List<TModel> IBaseService<TModel, TSearch>.Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        TModel IBaseService<TModel, TSearch>.GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
