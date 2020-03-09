using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.Model;
using Lyra.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _trackService;
        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Track>> Get()
        {
            return Ok(_trackService.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Track> GetById(int id)
        {
            return _trackService.GetById(id);
        }

        [HttpPost]
        public Track Insert(Track track)
        {
            return null;
        }

        [HttpPut("{id}")]
        public Track Update(int id, Track track)
        {
            return null;
        }

        [HttpDelete("{id}")]
        public Track Delete(int id)
        {
            return null;
        }
    }
}