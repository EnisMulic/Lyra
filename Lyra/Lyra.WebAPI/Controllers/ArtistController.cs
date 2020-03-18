using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.WebAPI.Services;
using Lyra.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.WebAPI.Controllers
{
    
    public class ArtistController : CRUDController<Artist, object, object, object>
    {
        public ArtistController(ICRUDService<Artist, object, object, object> service) : base(service)
        {
        }
    }
}