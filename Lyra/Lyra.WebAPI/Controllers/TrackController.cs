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
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _service;
        public TrackController(ITrackService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Track>> Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Track> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Track Insert(TrackInsertRequest request)
        {
            return _service.Insert(request);
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