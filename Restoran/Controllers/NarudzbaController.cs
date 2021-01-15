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
 
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : BaseCRUDController<Model.Narudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest>
    {
        public NarudzbaController(ICRUDService<Model.Narudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest> service) : base(service)
        {
        }
        
    }
}
