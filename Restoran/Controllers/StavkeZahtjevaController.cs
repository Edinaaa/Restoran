using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using Restoran.Model;
using Restoran.Model.Request;
using Restoran.Services;

namespace Restoran.Controllers
{
    [Authorize(Roles = "Konobar,Kupac,Gost")]
    [Route("api/[controller]")]
    [ApiController]
    public class StavkeZahtjevaController 
    {
        private readonly IStavkeZahtjevaService service;
        public StavkeZahtjevaController(IStavkeZahtjevaService service) { this.service = service; }

        [HttpGet]
        public List<Model.StavkeZahtjeva> Get([FromQuery] StavkeZahtjevaSerachRequest request)
        {

            return service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.StavkeZahtjeva GetById(int id)
        {

            return service.GetById(id);
        }
    
        [HttpPost]
        public Model.StavkeZahtjeva Insert(StavkeZahtjevaUpsertRequest reqests)
        {
            return service.Insert(reqests);


        }
        [Authorize(Roles = "Konobar")]
        [HttpPut("{id}")]
        public Model.StavkeZahtjeva Update(int id, [FromBody] StavkeZahtjevaUpsertRequest request)
        {

            return service.Update(id, request);
        }

    }
}
