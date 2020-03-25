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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.User> Get([FromQuery]UserSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.User GetById(int id)
        {
            return _service.GetById(id);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.User Insert(UserUpsertRequest request)
        {
            return _service.Insert(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.User Update(int id, [FromBody]UserUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        
    }
}