using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.WebAPI.Controllers
{
    public class PlaylistController : CRUDController<Model.Playlist, PlaylistSearchRequest, PlaylistUpsertRequest, PlaylistUpsertRequest>
    {
        private readonly IPlaylistService _service;
        public PlaylistController(IPlaylistService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("{id}/Tracks")]
        public async Task<List<Track>> GetTracks(int ID)
        {
            return await _service.GetTracks(ID);
        }
    }
}