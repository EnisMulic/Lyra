using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IAlbumService : ICRUDService<Model.Album, AlbumSearchRequest, AlbumUpsertRequest, AlbumUpsertRequest>
    {
        Task<List<Model.Track>> GetTracks(int ID, TrackSearchRequest request);
    }
}
