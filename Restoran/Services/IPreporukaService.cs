using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
  public  interface IPreporukaService
    {
        List<Model.Preporuka> Get(PreporukaSerachRequest request);
    }
}
