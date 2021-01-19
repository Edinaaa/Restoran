using AutoMapper;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class MeniService : BaseCRUDService<Model.Meni, MeniSearchRequest, Database.Meni, MeniUpsertRequest, MeniUpsertRequest>
    {
        public MeniService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        private void Validiraj(MeniUpsertRequest request) {

            if (string.IsNullOrWhiteSpace(request.Naziv) || request.KorisnikId<1  )
            {
                throw new UserException("Sva polja su obavezna.");

            }
            else if(request.Naziv.Length>30)
            {
                throw new UserException("Naziv moze da sadrzava najvise 30 karaktera.");

            }
        }
        public override Model.Meni Insert(MeniUpsertRequest insert)
        {
            Validiraj(insert);
            Meni m = new Meni()
            {
                DatumObjave = DateTime.Now,
                KorisnikId = insert.KorisnikId,
                Naziv = insert.Naziv,
                Vazeci = insert.Vazeci,

            };
           

            _context.Menis.Add(m);
            _context.SaveChanges();
             if (insert.Vazeci)
                {
                    UpdateVazeci(m.MeniId);
                }
          foreach (var item in insert.Stavke)
            {
               
                StavkeMenija sm = new StavkeMenija() { 
                MeniId=m.MeniId,
                ArtikalId=item.ArtikalId,
                Cijena=item.Cijena,
                CijenaSaPDV=item.CijenaSaPDV,
                KategorijaId=item.KategorijaId,
                Popust=item.Popust
                };
                _context.StavkeMenias.Add(sm);
            }
            _context.SaveChanges();
          return  _mapper.Map<Model.Meni>(m);
        }
        public override List<Model.Meni> Get(MeniSearchRequest search)
        {
            var query = _context.Menis.AsQueryable();
            if (search.NeVazeci)
            {
                query = query.Where(x=>x.Vazeci==false);
            }
            if (search.Vazeci)
            {
                query = query.Where(x => x.Vazeci==true);
            }
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x=>x.Naziv.StartsWith(search.Naziv));
            }
            var list= query.ToList();
            return _mapper.Map<List<Model.Meni>>(list);
        }
       
        private void UpdateStavke( int id, List<Model.StavkeMenija> Ustavke)
        {
            var stavke = _context.StavkeMenias.Where(x => x.MeniId == id).ToList();
            bool pronadjen = false;

            foreach (var item in stavke)//deaktivira koje nedostaju u update.stavkama
            {
                pronadjen = false;
                foreach (var x in Ustavke)
                {
                    if (x.ArtikalId == item.ArtikalId)
                    {

                        item.Cijena = x.Cijena;
                        item.Popust = x.Popust;
                        item.PDV = x.PDV;
                        item.CijenaSaPDV = x.CijenaSaPDV;
                        
                       
                        pronadjen = true;
                    }
                }
                if (pronadjen == false)
                {
                    item.Aktivan = false;
                }
                _context.StavkeMenias.Update(item);
            }
            _context.SaveChanges();
            foreach (var item in Ustavke)//dodaje koje nedostaju u tabeli stavke 
            {
                pronadjen = false;
                foreach (var x in stavke)
                {
                    if (x.ArtikalId == item.ArtikalId)
                    {

                        pronadjen = true;
                    }
                }
                if (pronadjen == false)
                {
                    StavkeMenija sm = new StavkeMenija()
                    {
                        MeniId = id,
                        ArtikalId = item.ArtikalId,
                        Cijena = item.Cijena,
                        CijenaSaPDV = item.CijenaSaPDV,
                        KategorijaId = item.KategorijaId,
                        Popust = item.Popust,
                        Aktivan=item.Aktivan
                    };
                    _context.StavkeMenias.Add(sm);
                }
            }
            _context.SaveChanges();
        }
        private void UpdateVazeci(int id)
        {
           
                var meni = _context.Menis.Where(x => x.Vazeci == true && x.MeniId == id).ToList();
                foreach (var item in meni)
                {
                    item.Vazeci = false;
                    _context.Menis.Update(item);
                    var stavke = _context.StavkeMenias.Where(x => x.MeniId == item.MeniId).ToList();
                    foreach (var x in stavke)
                    {
                        x.Aktivan = false;
                        _context.StavkeMenias.Update(x);
                    }
                }
            var stavkeAktivne = _context.StavkeMenias.Where(x => x.MeniId == id).ToList();
            foreach (var x in stavkeAktivne)
            {
                x.Aktivan = true;
                _context.StavkeMenias.Update(x);
            }

            _context.SaveChanges();
        }

        public override Model.Meni Update(int id, MeniUpsertRequest update)
        {
            Validiraj(update);
            var entity = _context.Menis.Find(id);
            if (entity==null)
            {
                throw new UserException("Meni nije pronadjen.");
            }
            UpdateStavke(id, update.Stavke);
            entity.Naziv = update.Naziv;
            entity.Vazeci = update.Vazeci;
            if (update.Vazeci)
            {
                UpdateVazeci(entity.MeniId);
            }
            _context.Menis.Update(entity);
      
            _context.SaveChanges();
            return _mapper.Map<Model.Meni>(entity);
        }
    }
}
