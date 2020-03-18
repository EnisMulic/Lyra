using AutoMapper;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class PlaylistService : CRUDService<Model.Playlist, object, Database.Playlist, object, object>
    {
        public PlaylistService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
