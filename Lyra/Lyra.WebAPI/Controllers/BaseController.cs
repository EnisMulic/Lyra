﻿using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IBaseService<T, TSearch> _service;
        public BaseController(IBaseService<T, TSearch> service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<List<T>> Get([FromQuery]TSearch search)
        {
            return await _service.Get(search);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await _service.GetById(id);
        }
    }
}