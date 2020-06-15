using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Lyra.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : CRUDController<Model.UserTrackReview, UserTrackReviewSearchRequest, UserTrackReviewUpsertRequest, UserTrackReviewUpsertRequest>
    {
        public ReviewController(ICRUDService<Model.UserTrackReview, UserTrackReviewSearchRequest, UserTrackReviewUpsertRequest, UserTrackReviewUpsertRequest> service) : base(service)
        {
        }
    }
}