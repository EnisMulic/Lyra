using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.WebAPI.Services;
using Lyra.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lyra.Model.Requests;

namespace Lyra.WebAPI.Controllers
{
    
    public class ArtistController : CRUDController<Artist, ArtistSearchRequest, ArtistUpsertRequest, ArtistUpsertRequest>
    {
        private readonly IArtistService _service;
        public ArtistController(IArtistService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("{id}/Albums")]
        public async Task<List<Album>> GetAlbums(int id)
        {
            return await _service.GetAlbums(id);
        }

        [HttpGet("{id}/Tracks")]
        public async Task<List<Track>> GetTracks(int id)
        {
            return await _service.GetTracks(id);
        }
    }
}