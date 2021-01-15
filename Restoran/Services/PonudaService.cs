using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class PonudaService : BaseCRUDService<Model.Ponuda, PonudaSearchRequest, Database.Ponuda, PonudaUpsertRequest, PonudaUpsertRequest>
    {
        KombinacijaService kombinacijaService;
        public PonudaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
            kombinacijaService = new KombinacijaService(context, mapper);
        }

        public override List<Model.Ponuda> Get(PonudaSearchRequest search)
        {

            var p = _context.Ponudas.Include(x=>x.Korisnik).AsQueryable();
            if (search.KorisnikId!=null)
            {
                p = p.Where(x=>x.KorisnikId==search.KorisnikId);
            }
           if (!string.IsNullOrWhiteSpace(search?.DatumPocetka))
            {
                DateTime d = DateTime.Parse(search.DatumPocetka);
                p = p.Where(x => x.DatumPocetka.Date.CompareTo(d.Date)==0 );
            }
            if (!string.IsNullOrWhiteSpace(search?.DatumZavrsetka))
            {
                DateTime d = DateTime.Parse(search.DatumZavrsetka);
                p = p.Where(x => x.DatumZavrsetka.Date.CompareTo(d.Date) == 0);
            }
            var list = p.ToList();

            return _mapper.Map<List<Model.Ponuda>>(list);
        }
        private void Validiraj(PonudaUpsertRequest request, bool update=false) {
            if (request.KorisnikId<1 )
            {
                throw new UserException("Sva polja su obavezna.");

            }
            else if (request.DatumPocetka.Date<DateTime.Now.Date)
            {
                throw new UserException("Datum pocetka ne moze biti manji od trenutnog.");

            }
            else if (request.DatumPocetka.Date > request.DatumZavrsetka)
            {
                throw new UserException("Datum zavrsetka ne moze biti manji od datuma pocetka.");

            }
            else if (update && request.Kombinacije==null || request.Kombinacije.Count<1)
            {
                throw new UserException("Sva polja su obavezna.");

            }

        }
        public override Model.Ponuda Update(int id, PonudaUpsertRequest update)
        {
            Validiraj(update, true);
            var p = _context.Ponudas.Where(x => x.PonudaId == id).FirstOrDefault();
            p.DatumPocetka = update.DatumPocetka;
            p.DatumZavrsetka = update.DatumZavrsetka;
            var stavke = _context.Kombinacijas.Where(x => x.PonudaId == id).ToList();
            bool pronadjen = false;
            foreach (var item in stavke)
            {
                pronadjen = false;
                foreach (var x in update.Kombinacije)
                {
                    if (item.KombinacijaId == x)
                    {
                        pronadjen = true;
                       //update kombinacije se poziva na formi novakombinacija
                    }
                }
                if (!pronadjen)
                {
                 kombinacijaService.RemoveKombinacije(item);

                }

            }

            _context.Ponudas.Update(p);
            _context.SaveChanges();
            return _mapper.Map<Model.Ponuda>(p);
        }
        public override Model.Ponuda Insert(PonudaUpsertRequest insert)
        {
            var p = new Ponuda();
            p.DatumPocetka = insert.DatumPocetka;
            p.DatumZavrsetka = insert.DatumZavrsetka;
            p.KorisnikId = insert.KorisnikId;
            _context.Ponudas.Add(p);
            _context.SaveChanges();


            return _mapper.Map<Model.Ponuda>(p);
        }
    }
}
