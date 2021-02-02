using AutoMapper;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Helper;
using Restoran.Model.Request;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Services
{

    public class KupacService : IKupacService
    {
        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        Database.Uloge uloga =null;

        public KupacService(eRestoranContext context, IMapper mapper) { _context = context; _mapper = mapper;
            uloga = _context.Uloges.Where(x => x.Naziv == "Kupac").FirstOrDefault();
        }
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
        private static Random random = new Random();
      
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public List<Model.Korisnik> Get(KorisniciSeachRequest search)
        {
            List<Database.Korisnik> list=new List<Database.Korisnik>();

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                list = _context.Korisniks.Where(x => x.KorisnickoIme.Equals(search.KorisnickoIme) && x.KorisnickoIme.Equals(Helper.Helper.KorisnickoImeLogirani)).ToList();
            }
            else
            {
             
                    throw new UserException("Nemate pravo pristupa.");
            }
            
            return _mapper.Map<List<Model.Korisnik>>(list);
        }
        private void Validiraj(KorisniciUpsertReqests reqests, bool insert = false)
        {
            var korisnici = _context.Korisniks.Where(x => x.KorisnickoIme == reqests.KorisnickoIme).ToList();
            if (insert && string.IsNullOrWhiteSpace(reqests.Password) ||
                string.IsNullOrWhiteSpace(reqests.PasswordPotvrda))
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
            else if (korisnici.Count() > 0)
            {
                throw new UserException("Daberite neko drugo korisnicko ime.");
            }
            else if (string.IsNullOrWhiteSpace(reqests.Ime) ||
                string.IsNullOrWhiteSpace(reqests.Prezime) ||
                string.IsNullOrWhiteSpace(reqests.KorisnickoIme) ||
                string.IsNullOrWhiteSpace(reqests.Spol) )
            {
                throw new UserException("Sva polja su obavezna.");

            }
            else if (reqests.Ime.Length > 30 || reqests.Prezime.Length > 30 ||
                reqests.KorisnickoIme.Length > 30)
            {
                throw new UserException("Ime, prezime ili korisnicko ime mogu sadrzavati po najvise 30 karaktera.");

            }
            else if (reqests.Password.Length > 50 || reqests.PasswordPotvrda.Length > 50)
            {
                throw new UserException("Lozinka moze sadrzavati najvise 50 karaktera.");

            }
            else if (reqests.Spol.Length > 1 || !reqests.Spol.Equals("M") || !reqests.Spol.Equals("Z"))
            {
                throw new UserException("Spol moze sadrzavati najvise jedna karakter (M ili Z).");

            }
            else if (DateTime.Now.Year - reqests.DatumRodenja.Year < 7)
            {
                throw new UserException("Kupac ne moze biti mladji od 7g.");

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

          
              Database.KorisnikUloga korisniciUloge = new Database.KorisnikUloga();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogeId = uloga.UlogeId;

            _context.KorisnikUlogas.Add(korisniciUloge);
           
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }


        public Model.Korisnik Update(int id, KorisniciUpsertReqests reqests)
        {

            Validiraj(reqests);
            var entity = _context.Korisniks.Find(id);

            if (entity == null)
            {
                throw new UserException("Kupac nije pronadjen.");
            }
            if (!entity.KorisnickoIme.Equals(Helper.Helper.KorisnickoImeLogirani))
            {
                throw new UserException("Nemate pravo pristupa.");
            }
            _mapper.Map(reqests, entity);

            _context.Korisniks.Update(entity);
            _context.SaveChanges();
        


            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik GetById(int id)
        {
            var entity = _context.Korisniks.Where(x => x.KorisnikId == id).FirstOrDefault();
            if (!entity.KorisnickoIme.Equals(Helper.Helper.KorisnickoImeLogirani))
            {
                throw new UserException("Nemate pravo pristupa.");
            }
            return _mapper.Map<Model.Korisnik>(entity);
        }


    }
}
