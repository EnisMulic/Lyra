using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IArtistService : ICRUDService<Model.Artist, ArtistSearchRequest, ArtistUpsertRequest, ArtistUpsertRequest>
    {
        Task<List<Model.Album>> GetAlbums(int ID, AlbumSearchRequest request);
        Task<List<Model.Track>> GetTracks(int ID, TrackSearchRequest request);
    }
}
