using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IUserService : ICRUDService<Model.User, UserSearchRequest, UserInsertRequest, UserUpdateRequest>
    {
        Task<Model.User> Authenticate(UserAuthenticationRequest request);
        Task<Model.User> SignUp(UserInsertRequest request);
        Task<List<Model.Track>> GetFavouriteTracks(int id, TrackSearchRequest request);
        Task<Model.Track> InsertFavouriteTrack(int id, int TrackID);
        Task<bool> DeleteFavouriteTrack(int id, int TrackID);
        Task<List<Model.Album>> GetFavouriteAlbums(int id, AlbumSearchRequest request);
        Task<Model.Album> InsertFavouriteAlbum(int id, int AlbumID);
        Task<bool> DeleteFavouriteAlbum(int id, int AlbumID);
        Task<List<Model.Artist>> GetFavouriteArtists(int id, ArtistSearchRequest request);
        Task<bool> DeleteFavouriteArtist(int id, int ArtistID);
        Task<Model.Artist> InsertFavouriteArtist(int id, int ArtistID);
        Task<List<Model.UserActivityTrack>> GetActivityTracks(int id, TrackSearchRequest request);
        Task<Model.UserActivityTrack> InsertActivityTrack(int id, UserActivityTrackInsertRequest request);
        Task<List<Model.UserActivityAlbum>> GetActivityAlbums(int id, AlbumSearchRequest request);
        Task<Model.UserActivityAlbum> InsertActivityAlbum(int id, UserActivityAlbumInsertRequest request);
        Task<List<Model.UserActivityArtist>> GetActivityArtists(int id, ArtistSearchRequest request);
        Task<Model.UserActivityArtist> InsertActivityArtist(int id, UserActivityArtistInsertRequest request);
        Task<List<Model.UserActivityPlaylist>> GetActivityPlaylists(int id, PlaylistSearchRequest request);
        Task<Model.UserActivityPlaylist> InsertActivityPlaylist(int id, UserActivityPlaylistInsertRequest request);
    }
}
