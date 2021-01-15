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
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class StavkeZahtjevaController : BaseCRUDController<StavkeZahtjeva, StavkeZahtjevaSerachRequest, StavkeZahtjevaUpsertRequest, StavkeZahtjevaUpsertRequest>
    {
        public StavkeZahtjevaController(ICRUDService<StavkeZahtjeva, StavkeZahtjevaSerachRequest, StavkeZahtjevaUpsertRequest, StavkeZahtjevaUpsertRequest> service) : base(service)
        {
        }
    }
}
