using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Model.Request;
using Restoran.Services;

namespace Restoran.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class StavkeMeniaController : BaseCRUDController<Model.StavkeMenia, StavkeMeniaSearchRequest, StavkeMeniaUpsertRequest, StavkeMeniaUpsertRequest>
    {
        public StavkeMeniaController(ICRUDService<Model.StavkeMenia, StavkeMeniaSearchRequest, StavkeMeniaUpsertRequest, StavkeMeniaUpsertRequest> service) : base(service)
        {
        }
    }
}
