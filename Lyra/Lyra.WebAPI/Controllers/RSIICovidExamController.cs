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
    public class RSIICovidExamController : CRUDController<RSIICovidExam, RSIICovidExamSearchRequest, RSIICovidExamUpsertRequest, RSIICovidExamUpsertRequest>
    {
        public RSIICovidExamController(ICRUDService<RSIICovidExam, RSIICovidExamSearchRequest, RSIICovidExamUpsertRequest, RSIICovidExamUpsertRequest> service) : base(service)
        {
        }
    }
}
