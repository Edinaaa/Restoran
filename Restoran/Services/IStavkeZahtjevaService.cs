using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
  public  interface IStavkeZahtjevaService
    {
        StavkeZahtjeva GetById(int id);
        StavkeZahtjeva Insert(StavkeZahtjevaUpsertRequest reqests);
        List<StavkeZahtjeva> Get(StavkeZahtjevaSerachRequest request);


        StavkeZahtjeva Update(int id, StavkeZahtjevaUpsertRequest reqests);
    }
}
