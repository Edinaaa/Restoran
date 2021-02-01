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
    [Authorize(Roles = "Konobar,Kupac")]
    [Route("api/[controller]")]
    [ApiController]
    public class ZahtjevController
    {
      private readonly  IZahtjevService service;
        public ZahtjevController(IZahtjevService service) { this.service = service; }

        [HttpGet]
        public List<Model.Zahtjev> Get([FromQuery] object request)
        {

            return service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Zahtjev GetById(int id)
        {

            return service.GetById(id);
        }
      
        [HttpPost]
        public Model.Zahtjev Insert(ZahtjevUpsertRequest reqests)
        {
            return service.Insert(reqests);


        }
        [Authorize(Roles = "Konobar")]
        [HttpPut("{id}")]
        public Model.Zahtjev Update(int id, [FromBody] ZahtjevUpsertRequest request)
        {

            return service.Update(id, request);
        }

    }
}
