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
    public class PlaylistController : CRUDController<Model.Playlist, object, object, object>
    {
        public PlaylistController(ICRUDService<Playlist, object, object, object> service) : base(service)
        {
        }
    }
}