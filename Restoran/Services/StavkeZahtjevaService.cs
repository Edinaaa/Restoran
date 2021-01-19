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
    public class StavkeZahtjevaService: IStavkeZahtjevaService
    {

        public readonly eRestoranContext _context;
        public readonly IMapper _mapper;
        public StavkeZahtjevaService(eRestoranContext context, IMapper mapper)
        {
            _context = context; _mapper = mapper;
        }
       
        public  List<Model.StavkeZahtjeva> Get(StavkeZahtjevaSerachRequest search)
        {
            var list = _context.StavkeZahtjevas.Where(x => x.ZahtjevObradjen == search.Obradjeni).Include(x => x.Zahtjev).ToList();


            return _mapper.Map<List<Model.StavkeZahtjeva>>(list);
        }
        private void Validiraj(StavkeZahtjevaUpsertRequest request)
        {

            if (request.KorisnikId < 0 || request.ZahtjevId<0)
            {
                throw new UserException("Sva polja su obavezna.");

            }
        }
        public Model.StavkeZahtjeva Update(int id, StavkeZahtjevaUpsertRequest update)
        {
            Validiraj(update);
            var entity = _context.StavkeZahtjevas.Find(id);

            _context.StavkeZahtjevas.Attach(entity);
            _context.StavkeZahtjevas.Update(entity);
            _mapper.Map(update, entity);

            _context.SaveChanges();
            return _mapper.Map<Model.StavkeZahtjeva>(entity);
        }
        public  Model.StavkeZahtjeva Insert(StavkeZahtjevaUpsertRequest insert)
        {
            Validiraj(insert);
            var entity = _mapper.Map<Database.StavkeZahtjeva>(insert);

            _context.StavkeZahtjevas.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.StavkeZahtjeva>(entity);
        }

        public Model.StavkeZahtjeva GetById(int id)
        {
            var entity = _context.StavkeZahtjevas.Find(id);
            return _mapper.Map<Model.StavkeZahtjeva>(entity);
        }
    }
}
