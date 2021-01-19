using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
   public interface IZahtjevService
    {
        Zahtjev GetById(int id);
        Zahtjev Insert(ZahtjevUpsertRequest reqests);
        List<Zahtjev> Get(object o);


        Zahtjev Update(int id, ZahtjevUpsertRequest reqests);
    }
}
