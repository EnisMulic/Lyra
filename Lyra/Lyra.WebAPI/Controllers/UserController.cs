using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CRUDController<User, UserSearchRequest, UserInsertRequest, UserUpdateRequest>
    {
        private readonly IUserService _service;

        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost("Auth")]
        public async Task<Model.User> Authenticate(UserAuthenticationRequest request)
        {
            return await _service.Authenticate(request);
        }

        [AllowAnonymous]
        [HttpPost("SignUp")]
        public async Task<User> SignUp(UserInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [Authorize]
        [HttpGet("{id}/FavouriteTracks")]
        public async Task<List<Track>> GetFavouriteTracks(int id)
        {
            return await _service.GetFavouriteTracks(id);
        }

        [Authorize]
        [HttpGet("{id}/FavouriteAlbums")]
        public async Task<List<Album>> GetFavouriteAlbums(int id)
        {
            return await _service.GetFavouriteAlbums(id);
        }

        [Authorize]
        [HttpGet("{id}/FavouriteArtists")]
        public async Task<List<Artist>> GetFavouriteArtists(int id)
        {
            return await _service.GetFavouriteArtists(id);
        }

        [Authorize]
        [HttpGet("{id}/ActivityArtists")]
        public async Task<List<UserActivityArtist>> GetActivityArtists(int id)
        {
            return await _service.GetActivityArtists(id);
        }

        [Authorize]
        [HttpGet("{id}/ActivityAlbums")]
        public async Task<List<UserActivityAlbum>> GetActivityAlbums(int id)
        {
            return await _service.GetActivityAlbums(id);
        }

        [Authorize]
        [HttpGet("{id}/ActivityTracks")]
        public async Task<List<UserActivityTrack>> GetActivityTracks(int id)
        {
            return await _service.GetActivityTracks(id);
        }

        [Authorize]
        [HttpGet("{id}/ActivityPlaylists")]
        public async Task<List<UserActivityPlaylist>> GetActivityPlaylists(int id)
        {
            return await _service.GetActivityPlaylists(id);
        }

    }
}