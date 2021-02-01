using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class KorisnikService: IKorisniciService
    {
        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        public KorisnikService(eRestoranContext context, IMapper mapper) { _context = context; _mapper = mapper; }
        public Model.Korisnik Autenticiraj(string username, string password)
        {

            var user = _context.Korisniks.FirstOrDefault(x => x.KorisnickoIme == username);
            if (user != null)
            {
                var newhash = GenerateHash(user.LozinkaSalt, password);
                if (newhash == user.LozinkaHesh)
                {
                    return _mapper.Map<Model.Korisnik>(user);
                }
            }
            return null;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            //RNGCryptoServiceProvider generise random broj
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);

        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, 0, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
        private List<Model.Korisnik> GetNajcesciKupci()
        {
            var svi = _context.Korisniks.ToList();
            var narudzbas = _context.Narudzbas.ToList();
            List<int> broj = new List<int>();
            List<Korisnik> kupci = new List<Korisnik>();

            int najveci = -1;
            foreach (var item in svi)
            {
                int novi = narudzbas.Where(x => x.KorisnikId == item.KorisnikId).Count();
                if (najveci < novi)
                {
                    najveci = novi;

                }
                broj.Add(novi);
            }
            do
            {
                for (int i = 0; i < svi.Count; i++)
                {
                    if (najveci == broj[i])
                    {
                        kupci.Add(svi[i]);
                    }
                }
                najveci--;
            } while (kupci.Count < 5);



            return _mapper.Map<List<Model.Korisnik>>(kupci) ;
        }
        public  List<Model.Korisnik> Get(KorisniciSeachRequest search)
        {
            if (search.NajCasci)
            {
                return GetNajcesciKupci();
            }
            var query = _context.Korisniks.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Equals(search.KorisnickoIme));
            }
            if (!string.IsNullOrWhiteSpace(search?.Uloga))
            {
                var ku = _context.KorisnikUlogas.Where(u => u.Uloge.Naziv == search.Uloga).Include(x=>x.Korisnik).ToList();
                List<Korisnik> k = new List<Korisnik>();
                foreach (var item in ku)
                {
                    k.Add(item.Korisnik);
                }
                return _mapper.Map<List<Model.Korisnik>>(k);

            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
        }
        private void Validiraj(KorisniciUpsertReqests reqests, bool insert=false) {

            var korisnici = _context.Korisniks.Where(x => x.KorisnickoIme == reqests.KorisnickoIme).ToList();
            if (insert && (string.IsNullOrWhiteSpace(reqests.Password) ||
                string.IsNullOrWhiteSpace(reqests.PasswordPotvrda)  ||
                reqests.Uloge == null || reqests.Uloge.Count == 0))
            {
                throw new UserException("Sva polja su obavezna.");

            }
            if (!string.IsNullOrWhiteSpace(reqests.Password) &&
                !string.IsNullOrWhiteSpace(reqests.PasswordPotvrda))
            {
                if (reqests.Password != reqests.PasswordPotvrda)
                {
                    throw new UserException("Ne slazu se lozinka i lozinka potvrda.");

                }
            }
            else if (string.IsNullOrWhiteSpace(reqests.Ime) ||
                string.IsNullOrWhiteSpace(reqests.Prezime) ||
                string.IsNullOrWhiteSpace(reqests.KorisnickoIme) ||
               reqests.DatumZaposljavanja==null ||
               reqests.Slika==null ||
                string.IsNullOrWhiteSpace(reqests.Spol))
            {
                throw new UserException("Sva polja su obavezna.");

            }
            else if (reqests.Ime.Length > 30 || reqests.Prezime.Length > 30 ||
                reqests.KorisnickoIme.Length > 30)
            {
                throw new UserException("Ime, prezime ili korisnicko ime mogu sadrzavati po najvise 30 karaktera.");

            }
            else if (korisnici.Count()>0)
            {
                throw new UserException("Daberite neko drugo korisnicko ime.");
            }
            else if (reqests.Spol.Length > 1 || !(reqests.Spol.Equals("M") || reqests.Spol.Equals("Z")))
            {
                throw new UserException("Spol moze sadrzavati najvise jedna karakter (M ili Z).");

            }
            else if (DateTime.Now.Year - reqests.DatumRodenja.Year < 15)
            {
                throw new UserException("Zaposlenik ne moze biti mladji od 15g.");

            }
            else if (DateTime.Now.Date < reqests.DatumZaposljavanja.GetValueOrDefault().Date)
            {
                throw new UserException("Datum zeposljavanja ne moze biti veci od trenutnog.");

            }
        }
        public Model.Korisnik Insert(KorisniciUpsertReqests reqests)
        {
            Validiraj(reqests, true);
            var entity = _mapper.Map<Database.Korisnik>(reqests);

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHesh = GenerateHash(entity.LozinkaSalt, reqests.Password);

            _context.Korisniks.Add(entity);
            _context.SaveChanges();
            foreach (var uloga in reqests.Uloge)
            {
                Database.KorisnikUloga korisniciUloge = new Database.KorisnikUloga();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogeId = uloga;
               
                _context.KorisnikUlogas.Add(korisniciUloge);
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }
        private void Uloge(int id, List<int> uloge) {

            var ku = _context.KorisnikUlogas.Where(x => x.KorisnikId == id).ToList();


            bool pronadjen = false;
            foreach (var item in ku)
            {
                pronadjen = false;
                foreach (var x in uloge)
                {
                    if (item.UlogeId == x)
                    {
                        pronadjen = true;
                    }
                }
                if (!pronadjen)
                {
                    
                    _context.KorisnikUlogas.Remove(item);

                }
            }
            foreach (var item in uloge)
            {
                pronadjen = false;
                foreach (var x in ku)
                {
                    
                    if (item == x.UlogeId)
                    {
                        pronadjen = true;
                        
                    }
                }
                if (!pronadjen)
                {
                    _context.KorisnikUlogas.Add(new KorisnikUloga() { 
                    KorisnikId=id,
                    UlogeId=item
                    });
                }
            }
            _context.SaveChanges();
        }
        
        public Model.Korisnik Update(int id, KorisniciUpsertReqests reqests)
        {
            Validiraj(reqests);

            var entity = _context.Korisniks.Find(id);
            reqests.IznosKredita += entity.IznosKredita;
            if (!string.IsNullOrWhiteSpace(reqests.Password) &&
                 !string.IsNullOrWhiteSpace(reqests.PasswordPotvrda))
            {
                
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHesh = GenerateHash(entity.LozinkaSalt, reqests.Password);
            }
            _mapper.Map(reqests, entity);
            
    
           
            _context.Korisniks.Update(entity);
            _context.SaveChanges();
            if (reqests.Uloge!=null)
            {
                Uloge(entity.KorisnikId,reqests.Uloge);
            }
           

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik GetById(int id)
        {
            var entity = _context.Korisniks.Where(x => x.KorisnikId == id).FirstOrDefault();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public List<Model.KorisnikUloga> GetUloge(int korisnikId)
        {
            List<Database.KorisnikUloga> uloge = _context.KorisnikUlogas.Where(x => x.KorisnikId == korisnikId).Include(u=>u.Uloge).ToList();
            return _mapper.Map<List<Model.KorisnikUloga>>(uloge);
        }
    }
}

