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
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Album>> Get([FromQuery]AlbumSearchRequest request)
        {
            return Ok(_service.Get(request));
        }

        [HttpGet("{id}")]
        public ActionResult<Album> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Album Insert(AlbumInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Album Update(int id, Album Album)
        {
            return null;
        }

        [HttpDelete("{id}")]
        public Album Delete(int id)
        {
            return null;
        }
    }
}