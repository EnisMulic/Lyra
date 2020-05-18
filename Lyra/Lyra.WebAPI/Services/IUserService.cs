using Lyra.Model.Requests;
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
        Task<List<Model.UserFavouriteTrack>> GetFavouriteTracks(int id);
        Task<List<Model.UserFavouriteAlbum>> GetFavouriteAlbums(int id);
        Task<List<Model.UserFavouriteArtist>> GetFavouriteArtists(int id);
    }
}
