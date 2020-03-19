using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class PlaylistService : CRUDService<Model.Playlist, PlaylistSearchRequest, Playlist, PlaylistUpsertRequest, PlaylistUpsertRequest>
    {
        public PlaylistService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
