using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restoran.Model;
using Restoran.Model.Request;
using Restoran.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace Restoran.Controllers
{
   [Authorize(Roles = "Administrator,Konobar")]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {

        private readonly IKorisniciService service;
        public KorisnikController(IKorisniciService service) { this.service = service; }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery] KorisniciSeachRequest request)
        {

            return service.Get(request);
        }
       
        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {

            return service.GetById(id);
        }
       
        [HttpPost]
        public  Model.Korisnik Insert(KorisniciUpsertReqests reqests)
        {
           return service.Insert(reqests);


        }
        [HttpPut("{id}")]
        public Model.Korisnik Update(int id,[FromBody] KorisniciUpsertReqests request) {

            return service.Update(id, request);
        }
      
    }
}
