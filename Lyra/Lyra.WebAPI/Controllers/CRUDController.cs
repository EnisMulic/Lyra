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
    
    public class CRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public CRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<T> Insert(TInsert request)
        {
            return await _service.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<T> Update(int id, [FromBody]TUpdate request)
        {
            return await _service.Update(id, request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}