﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restoran.Database;
using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.Services
{
    public class StavkeNarudzbeService : BaseCRUDService<Model.StavkaNarudzbe, StavkeNarudzbeSearchRequest, Database.StavkaNarudzbe, StavkeNarudzbeUpsertRequest, StavkeNarudzbeUpsertRequest>
    {
        public StavkeNarudzbeService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.StavkaNarudzbe> Get(StavkeNarudzbeSearchRequest search)
        {
            var lista = _context.StavkaNarudzbes.Where(x => x.NarudzbaId == search.NaruszbaId).Include(x=>x.StavkeMenia.Artikal).Include(x=>x.Kombinacija).ToList();
            return _mapper.Map<List<Model.StavkaNarudzbe>>(lista);
        }
    }
}
