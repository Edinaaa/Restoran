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
    public class KombinacijaController : BaseCRUDController<Kombinacija, KombinacijaSearchRequest, KombinacijaUpsertRequest, KombinacijaUpsertRequest>
    {
        public KombinacijaController(ICRUDService<Kombinacija, KombinacijaSearchRequest, KombinacijaUpsertRequest, KombinacijaUpsertRequest> service) : base(service)
        {
        }
      
      
    }
}
