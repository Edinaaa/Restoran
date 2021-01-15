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
    public class KategorijaController : BaseCRUDController<Model.Kategorija, object, object, object>
    {
        public KategorijaController(ICRUDService<Kategorija, object, object, object> service) : base(service)
        {
        }
    }
}
