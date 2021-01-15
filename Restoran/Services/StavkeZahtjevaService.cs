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
    public class StavkeZahtjevaService: BaseCRUDService<Model.StavkeZahtjeva, StavkeZahtjevaSerachRequest,Database.StavkeZahtjeva, StavkeZahtjevaUpsertRequest,StavkeZahtjevaUpsertRequest>
    {
        public StavkeZahtjevaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.StavkeZahtjeva> Get(StavkeZahtjevaSerachRequest search)
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
        public override Model.StavkeZahtjeva Update(int id, StavkeZahtjevaUpsertRequest update)
        {
            Validiraj(update);
            return base.Update(id, update);
        }
        public override Model.StavkeZahtjeva Insert(StavkeZahtjevaUpsertRequest insert)
        {
            Validiraj(insert);
            return base.Insert(insert);
        }
    }
}
