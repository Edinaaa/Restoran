using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Restoran.Database;
using Restoran.Exceptions;
using Restoran.Model;
using Restoran.Model.Request;
namespace Restoran.Services
{
    public class ZahtjevService : IZahtjevService
    {
        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        public ZahtjevService(eRestoranContext context, IMapper mapper)
        {
            _context = context; _mapper = mapper;
        }


        List<Model.Zahtjev> IZahtjevService.Get(object o)
        {
            var list = _context.Zahtjevs.ToList();
            return _mapper.Map<List<Model.Zahtjev>>(list);
        }

        Model.Zahtjev IZahtjevService.GetById(int id)
        {
            var entity = _context.Zahtjevs.Find(id);
            return _mapper.Map<Model.Zahtjev>(entity);
        }

        Model.Zahtjev IZahtjevService.Insert(ZahtjevUpsertRequest reqests)
        {
            var zahtjevi = _context.Zahtjevs.Where(z=>z.Naziv==reqests.Naziv).ToList();
                if (zahtjevi.Count() > 0)
            {
                throw new UserException("Zahtjev koji pokusavate dodati vec postoji.");
            }
            var entity = _mapper.Map<Database.Zahtjev>(reqests);

            _context.Zahtjevs.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Zahtjev>(entity);
        }

        Model.Zahtjev IZahtjevService.Update(int id, ZahtjevUpsertRequest reqests)
        {
            var entity = _context.Zahtjevs.Find(id);

            _context.Zahtjevs.Attach(entity);
            _context.Zahtjevs.Update(entity);
            _mapper.Map(reqests, entity);

            _context.SaveChanges();
            return _mapper.Map<Model.Zahtjev>(entity);
        }
    }
}
