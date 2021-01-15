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
    public class StavkeKombinacijeService : BaseCRUDService<Model.StavkeKombinacije, StavkeKombinacijeSearchRequest, Database.StavkeKombinacije, StavkeKombinacijeUpsertRequest, StavkeKombinacijeUpsertRequest>
    {
        public StavkeKombinacijeService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.StavkeKombinacije> Get(StavkeKombinacijeSearchRequest search)
        {
            var list = _context.StavkeKombinacijes.Where(x=>x.KombinacijaId==search.KombinacijaId).Include(x=>x.Artikal).ToList();

            return _mapper.Map<List<Model.StavkeKombinacije>>(list);
        }
        private void Validiraj(StavkeKombinacijeUpsertRequest request) {

            if (request.Kolicina<0 || request.KombinacijaId<0 || request.ArtikalId<0)
            {
                throw new UserException("Sva polja su obavezna.");

            }
        }
        public override Model.StavkeKombinacije Insert(StavkeKombinacijeUpsertRequest insert)
        {
            Validiraj(insert);
            return base.Insert(insert);
        }
        public override Model.StavkeKombinacije Update(int id, StavkeKombinacijeUpsertRequest update)
        {
            Validiraj(update);
            return base.Update(id, update);
        }
    }
}
