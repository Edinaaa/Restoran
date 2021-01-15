using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
  public  interface IKupacService
    {
        Korisnik GetById(int id);
        Korisnik Insert(KorisniciUpsertReqests reqests);
        List<Korisnik> Get(KorisniciSeachRequest request);


        Korisnik Update(int id, KorisniciUpsertReqests reqests);
        Korisnik Autenticiraj(string username, string password);
    }
}
