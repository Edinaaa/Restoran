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
    
    [Route("api/[controller]")]
    [ApiController]
    public class PonudaController : BaseCRUDController<Ponuda, PonudaSearchRequest, PonudaUpsertRequest, PonudaUpsertRequest>
    {
        public PonudaController(ICRUDService<Ponuda, PonudaSearchRequest, PonudaUpsertRequest, PonudaUpsertRequest> service) : base(service)
        {
        }
    }
}
