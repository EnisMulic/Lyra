using AutoMapper;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class ArtistService : CRUDService<Model.Artist, object, Database.Artist, object, object>
    {
        public ArtistService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
