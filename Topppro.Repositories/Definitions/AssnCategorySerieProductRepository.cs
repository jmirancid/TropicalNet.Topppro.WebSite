using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using Topppro.Entities;
using Topppro.Interfaces.Repositories;

namespace Topppro.Repositories.Definitions
{
    public class AssnCategorySerieProductRepository
        : Repository<Topppro.Entities.Assn_CategorySerieProduct>, IAssnCategorySerieProductRepository
    {
        public AssnCategorySerieProductRepository() { }

        public AssnCategorySerieProductRepository(ToppproEntities context) :
            base(context)
        {

        }

        #region WebSite

        public override IQueryable<Assn_CategorySerieProduct> AllBy(Expression<Func<Assn_CategorySerieProduct, bool>> predicate)
        {
            var dbQuery =

                Context.Assn_CategorySerieProduct
                    .Include(e => e.Assn_CategorySerie)
                    .Include(e => e.Product)
                    .Where(predicate);

            return dbQuery;
        }

        //TODO: Include as a paramenter the posibility to add an include list and not have to oaverride allby
        // Used in Menu
        public IQueryable<Assn_CategorySerieProduct> AllForMenu(Expression<Func<Assn_CategorySerieProduct, bool>> predicate)
        {
            var dbQuery =

                Context.Assn_CategorySerieProduct
                    .Include(e => e.Assn_CategorySerie)
                    .Include(e => e.Assn_CategorySerie.Serie)
                    .Include(e => e.Product)
                    .Include(e => e.Product.Model)
                    .Where(predicate);

            return dbQuery;
        }

        public Topppro.Entities.Assn_CategorySerieProduct GetForDetail(object id)
        {
            var dbQuery =

                Context.Assn_CategorySerieProduct
                    .Include(e => e.Assn_CategorySerie)
                    .Include(e => e.Assn_CategorySerie.Serie)
                    .Include(e => e.Assn_CategorySerie.Category)
                    .Include(e => e.Product)
                    .Include(e => e.Product.Bullets)
                    .Include(e => e.Product.Attributes)
                    .Include(e => e.Product.Childs)
                    .Include(e => e.Product.Childs.Select(x => x.ChildProduct))
                    .Include(e => e.Product.Childs.Select(x => x.ChildProduct.Bullets))
                    .Include(e => e.Product.Childs.Select(x => x.ChildProduct.Attributes))
                    .Include(a => a.Product.Downloads)
                    .Where(e => e.AssnCategorySerieProductId == (int)id && e.Enabled && e.Product.Draft == false)
                    .Select(e => new
                    {
                        e,
                        Assn_CategorySerie = e.Assn_CategorySerie,
                        Serie = e.Assn_CategorySerie.Serie,
                        Category = e.Assn_CategorySerie.Category,
                        Product = e.Product,
                        Bullets = e.Product.Bullets.Where(x => x.Culture.Code == Topppro.Context.Current.Culture.TwoLetterISOLanguageName && x.Enabled).OrderBy(x => x.Priority),
                        Attributes = e.Product.Attributes.Where(x => x.Culture.Code == Topppro.Context.Current.Culture.TwoLetterISOLanguageName && x.Enabled).OrderBy(x => x.Priority),
                        Childs = e.Product.Childs,
                        Childs_Products = e.Product.Childs.Select(c => c.ChildProduct),
                        Childs_Bullets = e.Product.Childs.Select(c => c.ChildProduct.Bullets.Where(x => x.Culture.Code == Topppro.Context.Current.Culture.TwoLetterISOLanguageName && x.Enabled).OrderBy(x => x.Priority)),
                        Childs_Attributes = e.Product.Childs.Select(c => c.ChildProduct.Attributes.Where(x => x.Culture.Code == Topppro.Context.Current.Culture.TwoLetterISOLanguageName && x.Enabled).OrderBy(x => x.Priority)),
                        Downloads = e.Product.Downloads.Where(x => x.Enabled).OrderBy(x => x.Priority)
                    });

            return dbQuery.AsEnumerable().Select(n => n.e).SingleOrDefault();
        }

        public Topppro.Entities.Assn_CategorySerieProduct GetForSoftware(object id)
        {
            var dbQuery =

               Context.Assn_CategorySerieProduct
                   .Include(e => e.Assn_CategorySerie)
                   .Include(e => e.Assn_CategorySerie.Serie)
                   .Include(e => e.Assn_CategorySerie.Category)
                   .Include(e => e.Product)
                   .Include(e => e.Product.Downloads)
                   .Include(e => e.Product.Downloads.Select(x => x.Platform))
                   .Where(e => e.AssnCategorySerieProductId == (int)id && e.Enabled && e.Product.Draft == false)
                   .Select(e => new
                   {
                       e,
                       Assn_CategorySerie = e.Assn_CategorySerie,
                       Serie = e.Assn_CategorySerie.Serie,
                       Category = e.Assn_CategorySerie.Category,
                       Product = e.Product,
                       Platform = e.Product.Downloads.Select(x => x.Platform),
                       Downloads = e.Product.Downloads.Where(x => x.Enabled).OrderBy(x => x.Platform.Priority).ThenBy(x => x.Priority)
                   });

            return dbQuery.AsEnumerable().Select(n => n.e).SingleOrDefault();
        }

        public Topppro.Entities.Assn_CategorySerieProduct GetForHiRes(object id)
        {
            var dbQuery =

               Context.Assn_CategorySerieProduct
                   .Include(e => e.Assn_CategorySerie)
                   .Include(e => e.Assn_CategorySerie.Serie)
                   .Include(e => e.Assn_CategorySerie.Category)
                   .Include(e => e.Product)
                   .Include(e => e.Product.Childs)
                   .Include(e => e.Product.Childs.Select(x => x.ChildProduct))
                   .Where(e => e.AssnCategorySerieProductId == (int)id && e.Enabled && e.Product.Draft == false);

            return dbQuery.SingleOrDefault();
        }

        #endregion

        #region SecureSite

        public int Insert(int assnCategorySerieId, int productId, int priority)
        {
            var output =
                new ObjectParameter("Id", typeof(int));

            Context.Assn_CategorySerieProduct_Insert(assnCategorySerieId, productId, priority, output);

            return (int)output.Value;
        }

        public void Reorder(int assnCategorySerieProductId, int priority)
        {
            Context.Assn_CategorySerieProduct_Reorder(assnCategorySerieProductId, priority);
        }

        #endregion
    }
}