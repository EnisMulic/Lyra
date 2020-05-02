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

        [HttpGet("Authenticate")]
        public async Task<Model.User> Authenticate(string username, string password)
        {
            return await _service.Authenticate(username, password);
        }
    }
}