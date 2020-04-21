using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IPlaylistService : ICRUDService<Model.Playlist, PlaylistSearchRequest, PlaylistUpsertRequest, PlaylistUpsertRequest>
    {
        Task<List<Model.Track>> GetTracks(int ID);
    }
}
