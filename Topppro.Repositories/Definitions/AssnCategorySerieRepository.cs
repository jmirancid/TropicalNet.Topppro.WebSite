using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using Topppro.Entities;
using Topppro.Interfaces.Repositories;

namespace Topppro.Repositories.Definitions
{
    public class AssnCategorySerieRepository :
         Repository<Topppro.Entities.Assn_CategorySerie>, IAssnCategorySerieRepository
    {
        public AssnCategorySerieRepository() { }

        public AssnCategorySerieRepository(ToppproEntities context) :
            base(context)
        {

        }

        #region WebSite

        //TODO: Used in Index
        public override IQueryable<Assn_CategorySerie> AllBy(Expression<Func<Assn_CategorySerie, bool>> predicate)
        {
            var dbquery = 
                
                Context.Assn_CategorySerie
                    .Include(e => e.Category)
                    .Include(e => e.Serie)
                    .Include(e => e.Assn_CategorySerieProduct)
                    .Include(e => e.Assn_CategorySerieProduct.Select(b => b.Product))
                    .Include(e => e.Assn_CategorySerieProduct.Select(b => b.Product.Assn_ProductRegion))
                .Where(predicate)
                .OrderBy(e => e.Priority)
                .Select(e => new
                {
                    e,
                    Serie = e.Serie,
                    Assn_CategorySerieProduct = e.Assn_CategorySerieProduct.Where(b => b.Enabled).OrderBy(b => b.Priority),
                    Products = e.Assn_CategorySerieProduct.Select(b => b.Product),
                    Assn_ProductRegion = e.Assn_CategorySerieProduct.Select(b => b.Product.Assn_ProductRegion)
                });

            return dbquery.AsEnumerable().Select(n => n.e).AsQueryable(); ;
        }

        #endregion

        #region SecureSite

        public int Insert(int categoryId, int serieId, int priority)
        {
            var output =
                new ObjectParameter("Id", typeof(int));

            Context.Assn_CategorySerie_Insert(categoryId, serieId, priority, output);

            return (int)output.Value;
        }

        public void Reorder(int assnCategorySerieId, int priority)
        {
            Context.Assn_CategorySerie_Reorder(assnCategorySerieId, priority);
        }

        #endregion
    }
}