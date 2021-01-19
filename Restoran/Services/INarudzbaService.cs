using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
  public  interface INarudzbaService
    {
        Narudzba GetById(int id);
        Narudzba Insert(NarudzbaUpsertRequest reqests);
        List<Narudzba> Get(NarudzbaSearchRequest request);


        Narudzba Update(int id, NarudzbaUpsertRequest reqests);
    }
}
