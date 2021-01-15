using Microsoft.AspNetCore.Mvc;
using Restoran.Model.Request;
using Restoran.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukaController : Controller
    {
        private readonly IPreporukaService _service;
      public  PreporukaController(IPreporukaService service) {
            _service = service;
        }
        [HttpGet]
        public List<Model.Preporuka> Get([FromQuery] PreporukaSerachRequest request)
        {
            return _service.Get(request);
        }
    }
}
