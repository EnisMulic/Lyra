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
    public class UserController : CRUDController<User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        public UserController(ICRUDService<User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest> service) : base(service)
        {
        }
    }
}