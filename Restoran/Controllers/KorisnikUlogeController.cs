using Microsoft.AspNetCore.Mvc;
using Restoran.Model;
using Restoran.Model.Request;
using Restoran.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Controllers
{
    public class KorisnikUlogeController : BaseCRUDController<Restoran.Model.KorisnikUloga, KorisnikUlogeSerachRequest, object, object>
    {
        public KorisnikUlogeController(ICRUDService<KorisnikUloga, KorisnikUlogeSerachRequest, object, object> service) : base(service)
        {
        }

      
    }
}
