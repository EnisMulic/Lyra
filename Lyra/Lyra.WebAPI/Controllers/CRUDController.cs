using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.WebAPI.Controllers
{
    [Authorize]
    public class CRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public CRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public T Update(int id, [FromBody]TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}