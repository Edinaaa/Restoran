using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Model;
using Restoran.Model.Request;
using Restoran.Services;

namespace Restoran.Controllers
{
   [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class KupacController :ControllerBase
    {
        private readonly IKupacService _service ;
        public KupacController(IKupacService service)
        {
            _service = service;
        }
    
        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery] KorisniciSeachRequest request)
        {
            return _service.Get(request);
        }
        [Authorize]
        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }
        
        [HttpPost]
        public Model.Korisnik Insert(KorisniciUpsertReqests reqests)
        {
            return _service.Insert(reqests);


        }
        [Authorize]
        [HttpPut("{id}")]
        public Model.Korisnik Update(int id, [FromBody] KorisniciUpsertReqests request)
        {

            return _service.Update(id, request);
        }

    }
}
