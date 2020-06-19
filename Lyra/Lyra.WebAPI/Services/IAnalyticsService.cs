using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IAnalyticsService
    {
        Task<List<UserActivityTrack>> GetActivityTracks(PageRequest request);
        Task<List<UserActivityAlbum>> GetActivityAlbums(PageRequest request);
        Task<List<UserActivityArtist>> GetActivityArtists(PageRequest request);
        Task<List<UserActivityPlaylist>> GetActivityPlaylists(PageRequest request);
    }
}
