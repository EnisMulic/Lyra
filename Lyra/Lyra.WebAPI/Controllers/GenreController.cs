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

    public class GenreController : BaseController<Model.Genre, object>
    {
        public GenreController(IBaseService<Genre, object> service) : base(service)
        {
        }
    }
}