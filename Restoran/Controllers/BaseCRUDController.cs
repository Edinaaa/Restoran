using Restoran.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Restoran.Controllers
{
 
    public class BaseCRUDController<TModel, TSerach, TInsert, TUpdate> : BaseController<TModel, TSerach>
    {
        private readonly ICRUDService<TModel, TSerach, TInsert, TUpdate> _service = null;
        public BaseCRUDController(ICRUDService<TModel, TSerach, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }
        [Authorize(Roles = "Konobar")]
        [HttpPost]
        public TModel Insert(TInsert insert)
        {


            return _service.Insert(insert);
        }
        [Authorize(Roles = "Konobar")]
        [HttpPut("{id}")]
        public TModel Update(int id, [FromBody] TUpdate update)
        {


            return _service.Update(id, update);
        }
    }
}
