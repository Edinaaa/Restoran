using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restoran.Model;
using Restoran.Model.Request;
using Restoran.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Database;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using SQLitePCL;

namespace Restoran.Controllers
{
    [Authorize(Roles = "Konobar,Kupac,Gost")]
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : ControllerBase
    {
        private readonly INarudzbaService service;
        public NarudzbaController(INarudzbaService service) 
        {
            this.service = service;
        }
        [HttpGet]
        public List<Model.Narudzba> Get([FromQuery] NarudzbaSearchRequest request)
        {

            return service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Narudzba GetById(int id)
        {

            return service.GetById(id);
        }
      
        [HttpPost]
        public Model.Narudzba Insert(NarudzbaUpsertRequest reqests)
        {
            return service.Insert(reqests);


        }
        [HttpPut("{id}")]
        public Model.Narudzba Update(int id, [FromBody] NarudzbaUpsertRequest request)
        {

            return service.Update(id, request);
        }

    }
}
