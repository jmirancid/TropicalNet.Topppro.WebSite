﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Topppro.Entities;
using Topppro.Interfaces.Repositories;

namespace Topppro.Repositories.Definitions
{
    public class AssnCategorySerieRepository :
         Repository<Assn_CategorySerie>, IAssnCategorySerieRepository
    {
        public override IQueryable<Assn_CategorySerie> All()
        {
            return Context.Assn_CategorySerie
                        .Include(e => e.Category)
                        .Include(e => e.Serie);
        }

        public override Assn_CategorySerie Get(int id)
        {
            return Context.Assn_CategorySerie
                        .Include(e => e.Category)
                        .Include(e => e.Serie)
                        .SingleOrDefault(e => e.AssnCategorySerieId == id);
        }

        public IQueryable<Assn_CategorySerie> AllByWithRefs(Expression<Func<Assn_CategorySerie, bool>> predicate)
        {
            var dbquery = Context.Assn_CategorySerie
                            .Include(a => a.Category)
                            .Include(a => a.Serie)
                            .Include(a => a.Assn_CategorySerieProduct.Select(b => b.Product))
                            .Where(predicate)
                            .Select(a => new
                            {
                                a,
                                Category = a.Category,
                                Serie = a.Serie,
                                Assn_Products = a.Assn_CategorySerieProduct.Where(b => b.Enabled).OrderBy(b => b.Priority),
                                Products = a.Assn_CategorySerieProduct.Select(b => b.Product)
                            });

            return dbquery.AsEnumerable().Select(n => n.a).AsQueryable();
        }
    }
}
