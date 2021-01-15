using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restoran.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Restoran.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel, TSearch> : ControllerBase
    {

        private readonly IService<TModel, TSearch> service;
        public BaseController(IService<TModel, TSearch> service) { this.service = service; }

        [HttpGet]
        public ActionResult<List<TModel>> Get([FromQuery] TSearch search)
        {
            
            return service.Get(search);
        }
        [HttpGet("{id}")]

        public TModel GetById(int id)
        {
            return service.GetById(id);

        }
    }
}
