﻿using System;
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
        public async Task<List<Track>> GetFavouriteTracks(int id, [FromQuery] TrackSearchRequest request)
        {
            return await _service.GetFavouriteTracks(id, request);
        }

        [Authorize]
        [HttpPost("{id}/FavouriteTrack/{trackId}")]
        public async Task<Track> InsertFavouriteTrack(int id, int trackId)
        {
            return await _service.InsertFavouriteTrack(id, trackId);
        }


        [Authorize]
        [HttpGet("{id}/FavouriteAlbums")]
        public async Task<List<Album>> GetFavouriteAlbums(int id, [FromQuery] AlbumSearchRequest request)
        {
            return await _service.GetFavouriteAlbums(id, request);
        }

        [Authorize]
        [HttpPost("{id}/FavouriteAlbum/{albumId}")]
        public async Task<Album> InsertFavouriteAlbum(int id, int albumId)
        {
            return await _service.InsertFavouriteAlbum(id, albumId);
        }

        [Authorize]
        [HttpGet("{id}/FavouriteArtists")]
        public async Task<List<Artist>> GetFavouriteArtists(int id, [FromQuery] ArtistSearchRequest request)
        {
            return await _service.GetFavouriteArtists(id, request);
        }

        [Authorize]
        [HttpPost("{id}/FavouriteArtist/{artistId}")]
        public async Task<Artist> InsertFavouriteArtist(int id, int artistId)
        {
            return await _service.InsertFavouriteArtist(id, artistId);
        }

        [Authorize]
        [HttpGet("{id}/ActivityArtists")]
        public async Task<List<UserActivityArtist>> GetActivityArtists(int id, [FromQuery] ArtistSearchRequest request)
        {
            return await _service.GetActivityArtists(id, request);
        }

        [Authorize]
        [HttpGet("{id}/ActivityAlbums")]
        public async Task<List<UserActivityAlbum>> GetActivityAlbums(int id, [FromQuery] AlbumSearchRequest request)
        {
            return await _service.GetActivityAlbums(id, request);
        }

        [Authorize]
        [HttpGet("{id}/ActivityTracks")]
        public async Task<List<UserActivityTrack>> GetActivityTracks(int id, [FromQuery] TrackSearchRequest request)
        {
            return await _service.GetActivityTracks(id, request);
        }

        [Authorize]
        [HttpGet("{id}/ActivityPlaylists")]
        public async Task<List<UserActivityPlaylist>> GetActivityPlaylists(int id, [FromQuery] PlaylistSearchRequest request)
        {
            return await _service.GetActivityPlaylists(id, request);
        }

        [Authorize]
        [HttpDelete("{id}/FavouriteTrack/{trackId}")]
        public async Task<bool> DeleteFavouriteTrack(int id, int trackId)
        {
            return await _service.DeleteFavouriteTrack(id, trackId);
        }

        [Authorize]
        [HttpDelete("{id}/FavouriteAlbum/{albumId}")]
        public async Task<bool> DeleteFavouriteAlbum(int id, int albumId)
        {
            return await _service.DeleteFavouriteAlbum(id, albumId);
        }

        [Authorize]
        [HttpDelete("{id}/FavouriteArtist/{artistId}")]
        public async Task<bool> DeleteFavouriteArtist(int id, int artistId)
        {
            return await _service.DeleteFavouriteArtist(id, artistId);
        }
    }
}