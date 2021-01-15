using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Model;
using Restoran.Services;

namespace Restoran.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : BaseCRUDController<Restoran.Model.Uloge, object, object, object>
    {
        public UlogeController(ICRUDService<Uloge, object, object, object> service) : base(service)
        {
        }
    }
}
