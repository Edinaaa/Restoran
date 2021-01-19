using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model.Request;
namespace Restoran.Services
{
    public class ArtikalService : BaseCRUDService<Model.Artikal, ArtikalSearchRequest, Database.Artikal, ArtikalUpsertRequest, ArtikalUpsertRequest>
    {
        public ArtikalService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        private List<Artikal> GetNajprodavanije() {
            var svi = _context.Artikli.ToList();
            var narudzbas = _context.StavkaNarudzbes.Where(x => x.StavkeMenijaId != null).Include(x=>x.StavkeMenia.Artikal).ToList();
            List<int> broj = new List<int>();
            List<Artikal> artikli = new List<Artikal>();

            int najveci = -1;
            foreach (var item in svi)
            {
                int novi = narudzbas.Where(x => x.StavkeMenia.ArtikalId == item.ArtikalId).Count();
                if (najveci<novi)
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
                        artikli.Add(svi[i]);
                    }
                }
                najveci--;
            } while (artikli.Count < 5);
                
         
            
            return artikli;
        }
        public override List<Model.Artikal> Get(ArtikalSearchRequest search)
        {
            List<Database.Artikal> artikli = new List<Artikal>();
            if (search.NajProdavaniji)
            {
                artikli = GetNajprodavanije();
                return _mapper.Map<List<Model.Artikal>>(artikli);
            }
            var query = _context.Artikli.Include(x => x.Kategorija).AsQueryable();

            if (search.id_artikals != null )
            {
                foreach (var item in search.id_artikals)
                {
                    artikli.Add(query.Where(x => x.ArtikalId == item).FirstOrDefault());
                }
            }

            else if (search.KategorijaId!=0 && search.KategorijaId!=7)//ako u kategoriji nije odabrano sve=7
            {
                query = query.Where(x => x.KategorijaId == search.KategorijaId);
            }
            else if (!String.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }
          
            artikli = query.ToList();
            
            
            return _mapper.Map<List<Model.Artikal>>(artikli);
        }
        public override Model.Artikal GetById(int id)
        {
            var artikal = _context.Artikli.Include(x => x.Kategorija).Include(x=>x.JedinicaMjere).Where(x=>x.ArtikalId==id).FirstOrDefault();

            return _mapper.Map<Model.Artikal>(artikal);
        }
        private void Validiraj(ArtikalUpsertRequest request) {

            if (string.IsNullOrWhiteSpace(request.Naziv) ||
                string.IsNullOrWhiteSpace(request.Sastav) ||
                request.Slika==null ||
                request.JedinicaMjereId<1 ||
                request.KategorijaId < 1 ||
                request.Kolicina < 1 ||
                request.PDV < 0 ||
                request.Popust < 0 ||
                request.Cijena <= 0 ||
                request.CijenaSaPdv <= 0 
                 )
            {
                throw new UserException("Sva polja su obavezna.");
            }
            else if (request.Naziv.Length>30)
            {
                throw new UserException("Naziv moze da sadrzava najvise 30 karaktera.");

            }
            else if (request.Sastav.Length > 300)
            {
                throw new UserException("Sastav moze da sadrzava najvise 300 karaktera.");

            }
            else if (request.Kolicina> 1000)
            {
                throw new UserException("Kolicina ne moze biti veca od 1000.");

            }
        }
        public override Model.Artikal Insert(ArtikalUpsertRequest insert)
        {
            Validiraj(insert);
            return base.Insert(insert);
        }
        public override Model.Artikal Update(int id, ArtikalUpsertRequest update)
        {
            Validiraj(update);
            var entity= base.Update(id, update);
            if (entity==null)
            {
                throw new UserException("Artikal nije pronadjen.");

            }
            return entity;
        }
    }
}
