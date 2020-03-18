using AutoMapper;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class GenreService : BaseService<Model.Genre, object, Database.Genre>
    {
        public GenreService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
