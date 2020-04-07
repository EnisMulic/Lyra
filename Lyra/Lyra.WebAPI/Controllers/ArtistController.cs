using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.WebAPI.Services;
using Lyra.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lyra.Model.Requests;

namespace Lyra.WebAPI.Controllers
{
    
    public class ArtistController : CRUDController<Artist, ArtistSearchRequest, ArtistUpsertRequest, ArtistUpsertRequest>
    {
        public ArtistController(ICRUDService<Artist, ArtistSearchRequest, ArtistUpsertRequest, ArtistUpsertRequest> service) : base(service)
        {
        }
    }
}