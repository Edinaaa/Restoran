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
    public class StavkeMeniaService : BaseCRUDService<Model.StavkeMenia, StavkeMeniaSearchRequest, Database.StavkeMenia, StavkeMeniaUpsertRequest, StavkeMeniaUpsertRequest>
    {
        public StavkeMeniaService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.StavkeMenia> Get(StavkeMeniaSearchRequest search)
        {
            var stavke = _context.StavkeMenias.Where(x=>x.MeniId==search.MeniId).Include(x=>x.Artikal).Include(x=>x.Kategorija).ToList();
           return _mapper.Map<List<Model.StavkeMenia>>(stavke);
        }
     
        public override Model.StavkeMenia GetById(int id)
        {
            var entity = _context.StavkeMenias.Include(x => x.Artikal).Include(x => x.Kategorija).Where(x => x.StavkeMeniaId == id).FirstOrDefault();
            return _mapper.Map<Model.StavkeMenia>(entity);
        }
      
    }
}
