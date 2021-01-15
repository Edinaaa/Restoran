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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ZahtjevController : BaseCRUDController<Zahtjev, object, ZahtjevUpsertRequest, ZahtjevUpsertRequest>
    {
        public ZahtjevController(ICRUDService<Zahtjev, object, ZahtjevUpsertRequest, ZahtjevUpsertRequest> service) : base(service)
        {
        }
       
    }
}
