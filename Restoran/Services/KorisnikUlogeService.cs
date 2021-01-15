using AutoMapper;
using Restoran.Database;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class KorisnikUlogeService : BaseCRUDService<Model.KorisnikUloga, KorisnikUlogeSerachRequest, Database.KorisnikUloga, object, object>
    {
        public KorisnikUlogeService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.KorisnikUloga> Get(KorisnikUlogeSerachRequest search)
        {
            var list = _context.KorisnikUlogas.Where(x => x.KorisnikId == search.KorisnikId).ToList();


            return _mapper.Map<List<Model.KorisnikUloga>>(list);
        }
   
    }
}
