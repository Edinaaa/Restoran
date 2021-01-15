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
    public class StavkeKombinacijeController : BaseCRUDController<Model.StavkeKombinacije, StavkeKombinacijeSearchRequest, StavkeKombinacijeUpsertRequest, StavkeKombinacijeUpsertRequest>
    {
        public StavkeKombinacijeController(ICRUDService<StavkeKombinacije, StavkeKombinacijeSearchRequest, StavkeKombinacijeUpsertRequest, StavkeKombinacijeUpsertRequest> service) : base(service)
        {
        }
    }
}
