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
    public class AlbumController : BaseController<Album, AlbumSearchRequest>
    {
        public AlbumController(IBaseService<Album, AlbumSearchRequest> service) : base(service)
        {
        }
    }
}