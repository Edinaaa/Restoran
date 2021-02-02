using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class NarudzbaService :INarudzbaService
    {
        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        public NarudzbaService(eRestoranContext context, IMapper mapper) {
            _context = context; _mapper = mapper;
        }
        public  List<Model.Narudzba> Get(NarudzbaSearchRequest search)
        {
            var narudzbe = _context.Narudzbas.AsQueryable();
            if (search.PretragaPoDatumu)
            {
                narudzbe= narudzbe.Where(x => x.DatumNarudzbe.Date == search.DatumNarudzbe.Date);
            }
            var uloge = _context.KorisnikUlogas.Include(x=>x.Uloge).Where(x => x.Korisnik.KorisnickoIme == Helper.Helper.KorisnickoImeLogirani).ToList();
            bool kupac = false;
            foreach (var item in uloge)//ako korisnik ima ulogu kupac, dobiti ce samo svoje narudzbe
            {
                if (item.Uloge.Naziv=="Kupac")
                {
                    kupac = true;
                }
            }
            if (search.KorisnikId!=0 && kupac && search.KorisnikId==uloge[0].KorisnikId)
            {
                narudzbe = narudzbe.Where(x => x.KorisnikId == search.KorisnikId);
            }


            narudzbe.ToList();

                return _mapper.Map<List<Model.Narudzba>>(narudzbe);
            
        }
        private void Validiraj(NarudzbaUpsertRequest request) {

            if (request.BrojStola<1 || request.KorisnikId < 1) {
                throw new UserException("Sva polja su obavezna.");

            }
            var uloge = _context.KorisnikUlogas.Include(x => x.Uloge).Where(x => x.Korisnik.KorisnickoIme == Helper.Helper.KorisnickoImeLogirani).ToList();
            bool kupac = false;
            foreach (var item in uloge)//ako korisnik ima ulogu kupac ima pravo samo na svoje narudzbe
            {
                if (item.Uloge.Naziv == "Kupac")
                {
                    kupac = true;
                }
            }
            if (request.KorisnikId!=uloge[0].KorisnikId && kupac)//ako je konobar moci ce mjenjati narudzbu
            {                                                   //ali ne ako ima ulugu kupac
                throw new UserException("Nemate pravo pristupa.");

            }
        }
        public  Model.Narudzba Insert(NarudzbaUpsertRequest insert)
        {
            Validiraj(insert);
            
            Database.Narudzba narudzba = new Database.Narudzba() {
            KorisnikId=insert.KorisnikId,
            BrojStola=insert.BrojStola,
            DatumNarudzbe=DateTime.Now,
            Naplaceno=false,
            PlacanjeKreditima=insert.PlacanjeKreditima,
            Cijena=0,
            CijenaSaPdv=0,
            Pdv=0,
            Odbijena=false,
            Naplati=false,
            Odobrena=false
           
            };
            _context.Narudzbas.Add(narudzba);
            _context.SaveChanges();
            foreach (var item in insert.Stavke)
            {
                Database.StavkaNarudzbe sn = new Database.StavkaNarudzbe() {
                   StavkeMenijaId = item.StavkeMenijaId == 0?null:item.StavkeMenijaId,
                    KombinacijaId = item.KombinacijaId==0? null:item.KombinacijaId,
                    Cijena = item.Cijena,// cijena je pomnozena za kolicinom na frontend dijelu
                    CijenaSaPdv = item.CijenaSaPdv,
                    Pdv=item.Pdv,
                    Kolicina=item.Kolicina,
                    NarudzbaId=narudzba.NarudzbaId

                };
                _context.StavkaNarudzbes.Add(sn);
                _context.SaveChanges();
              
                narudzba.Cijena += sn.Cijena;
                narudzba.CijenaSaPdv += sn.CijenaSaPdv;
                narudzba.Pdv += sn.Pdv;

            }

            _context.Narudzbas.Update(narudzba);
            _context.SaveChanges();

            return _mapper.Map<Model.Narudzba>(narudzba);
        }
        public Model.Narudzba Update(int id, NarudzbaUpsertRequest update)
        {

            Database.Narudzba entity = _context.Narudzbas.Where(x => x.NarudzbaId == id).FirstOrDefault();
           
            if (entity == null)
            {
                throw new UserException("Narudzba nije pronadjena.");

            }
            Validiraj(update);
            //narudzba se ne moze mjenjati ako je naplacena
            if (update.Naplati && (!entity.Naplaceno && !entity.Odbijena && entity.Odobrena))
            {
                entity.Naplati = update.Naplati;
            }
            else if (update.Odobrena && (!entity.Naplaceno))
            {
                entity.Odobrena = update.Odobrena;
                entity.Odbijena = false;
            }
            else if (update.Odbijena && (!entity.Naplaceno))
            {
                entity.Odobrena = false;
                entity.Odbijena = update.Odbijena;
            }
            else if (update.Naplaceno)
            {   //Ako je kupac odabrao naplatu kreditima, 
                //iznos narudzbe se oduzima prije ovog poziva unutar win.frome
                entity.Naplaceno = update.Naplaceno;
            }

            _context.Narudzbas.Update(entity);
            _context.SaveChanges();
           return  _mapper.Map<Model.Narudzba>(entity);
           
        }

        public Model.Narudzba GetById(int id)
        {
            var narudzbe = _context.Narudzbas.Find(id);
            return _mapper.Map<Model.Narudzba>(narudzbe);
        }
    }
}

