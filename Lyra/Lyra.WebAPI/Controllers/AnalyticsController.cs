using System;
using System.Collections.Generic;
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
    [Authorize(Roles = "Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        private readonly IAnalyticsService _service;
        public AnalyticsController(IAnalyticsService service)
        {
            _service = service;
        }

        [HttpGet("Track")]
        public async Task<List<UserActivityTrack>> GetActivityTracks([FromQuery]PageRequest request)
        {
            return await _service.GetActivityTracks(request);
        }

        [HttpGet("Album")]
        public async Task<List<UserActivityAlbum>> GetActivityAlbums([FromQuery]PageRequest request)
        {
            return await _service.GetActivityAlbums(request);
        }

        [HttpGet("Artist")]
        public async Task<List<UserActivityArtist>> GetActivityArtists([FromQuery]PageRequest request)
        {
            return await _service.GetActivityArtists(request);
        }

        [HttpGet("Playlist")]
        public async Task<List<UserActivityPlaylist>> GetActivityPlaylists([FromQuery]PageRequest request)
        {
            return await _service.GetActivityPlaylists(request);
        }
    }
}