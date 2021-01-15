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
   
    [Route("api/[controller]")]
    [ApiController]
    public class JediniceMjereController : BaseCRUDController<Model.JedinicaMjere, object, object, object>
    {
        public JediniceMjereController(ICRUDService<JedinicaMjere, object, object, object> service) : base(service)
        {
        }
    }
}
