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
    public class KombinacijaService: BaseCRUDService<Model.Kombinacija, KombinacijaSearchRequest,Database.Kombinacija, KombinacijaUpsertRequest, KombinacijaUpsertRequest>
    {
        public KombinacijaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Kombinacija> Get(KombinacijaSearchRequest search)
        {

            var list = _context.Kombinacijas.Where(x => x.PonudaId == search.PonudaId).ToList();

            return _mapper.Map<List<Model.Kombinacija>>(list);
        }
        private void Validiraj(KombinacijaUpsertRequest request) {

            if (string.IsNullOrWhiteSpace(request.Naziv) ||
                request.PonudaId < 1 ||
                request.PDV < 0 ||
                request.Cijena <= 0 ||
                request.CijenaSaPdv <= 0||
                request.Slika==null ||
                request.Stavke==null ||
                request.Stavke.Count==0)
            {
                throw new UserException("Sva polja su obavezna.");

            }
            else if (request.Naziv.Length > 30)
            {
                throw new UserException("Naziv moze da sadrzava najvise 30 karaktera.");

            }
        }
        public override Model.Kombinacija Insert(KombinacijaUpsertRequest insert)
        {
          
            Validiraj(insert);
            var k=_mapper.Map<Database.Kombinacija>(insert);
            _context.Kombinacijas.Add(k);
            _context.SaveChanges();
            if (insert.Stavke.Count>0)
            {
                foreach (var item in insert.Stavke)
                {
                    StavkeKombinacije sk = new StavkeKombinacije() {
                        ArtikalId = item.ArtikalId,
                        KombinacijaId = k.KombinacijaId,
                        Kolicina=item.Kolicina};
                    _context.StavkeKombinacijes.Add(sk);
                  
                }
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Kombinacija>(k);
        }
        public void RemoveKombinacije(Kombinacija k)
        {
            var stavke = _context.StavkeKombinacijes.Where(x => x.KombinacijaId == k.KombinacijaId).ToList();
            foreach (var item in stavke)
            {
                _context.StavkeKombinacijes.Remove(item);
            }

            _context.Kombinacijas.Remove(k);
            _context.SaveChanges();
        }
        private void UpdateStavkeKombinacije(int id, List<Model.StavkeKombinacije> NoveStavke) {
            var stavke = _context.StavkeKombinacijes.Where(x => x.KombinacijaId == id).Include(x => x.Artikal).ToList();
            bool pronadjen = false;
            foreach (var item in stavke)
            {
                pronadjen = false;
                foreach (var x in NoveStavke)
                {
                    if (item.ArtikalId == x.ArtikalId)
                    {
                        item.Kolicina = x.Kolicina;
                        pronadjen = true;

                        _context.StavkeKombinacijes.Update(item);
                    }
                }
                if (!pronadjen)
                {
                    _context.StavkeKombinacijes.Remove(item);

                }

            }

            foreach (var item in NoveStavke)
            {
                pronadjen = false;
                foreach (var x in stavke)
                {
                    if (item.ArtikalId == x.ArtikalId)
                    {

                        pronadjen = true;

                    }
                }
                if (!pronadjen)
                {
                    _context.StavkeKombinacijes.Add(_mapper.Map<Database.StavkeKombinacije>(item));

                }

            }
            _context.SaveChanges();

        }
        public override Model.Kombinacija Update(int id, KombinacijaUpsertRequest update)
        {
            Validiraj(update);
           var entity = _mapper.Map<Database.Kombinacija>(update);

            UpdateStavkeKombinacije(id, update.Stavke);
            _context.Kombinacijas.Update(entity);
            _context.SaveChanges();
           
            return _mapper.Map<Restoran.Model.Kombinacija>(entity);
        }
    }
}
