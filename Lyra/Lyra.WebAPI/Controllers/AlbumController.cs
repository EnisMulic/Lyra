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
    public class AlbumController : CRUDController<Album, AlbumSearchRequest, AlbumUpsertRequest, AlbumUpsertRequest>
    {
        private readonly IAlbumService _service;
        public AlbumController(IAlbumService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("{id}/Tracks")]
        public async Task<List<Track>> GetTracks(int ID, [FromQuery]TrackSearchRequest request)
        {
            return await _service.GetTracks(ID, request);
        }
    }
}