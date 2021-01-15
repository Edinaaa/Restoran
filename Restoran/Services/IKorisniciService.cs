using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restoran.Model;
using Restoran.Model.Request;

namespace Restoran.Services
{
   public interface IKorisniciService
    {
         List<Korisnik>  Get(KorisniciSeachRequest request);
        Korisnik GetById(int id);
        Korisnik Insert(KorisniciUpsertReqests reqests);
       

        Korisnik Update(int id, KorisniciUpsertReqests reqests);
        Korisnik Autenticiraj(string username, string password);
        List<KorisnikUloga> GetUloge(int korisnikId);
    }
}
