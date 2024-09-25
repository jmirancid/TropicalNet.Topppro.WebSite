using System;
using System.Web.Mvc;
using Topppro.Interfaces.Business;
using xFNet.Common.Extensions;
using Topppro.WebSite.Extensions;
using System.Linq;
using Microsoft.Ajax.Utilities;

namespace Topppro.WebSite.Controllers
{
    public abstract class LayoutController : Controller
    {
        protected IAssnCategorySerieProductBusiness BizCategorySerieProduct { get; private set; }

        protected IAssnCategorySerieBusiness BizCategorySerie { get; private set; }

        public LayoutController() { }

        public LayoutController(IAssnCategorySerieProductBusiness bizCategorySerieProduct, IAssnCategorySerieBusiness bizCategorySerie)
        {
            this.BizCategorySerieProduct = bizCategorySerieProduct;
            this.BizCategorySerie = bizCategorySerie;
        }

        [OutputCache(CacheProfile = "Medium")]
        public virtual ActionResult Index(string controller)
        {
            var regionId =
                Topppro.Context.Current.Region.As<int>();

            var categoryId =
                (int)Enum.Parse(typeof(Topppro.Entities.Category_Enum), controller);

            // Filter categories-series that contains products in region. WARN: All products are included.
            var entities =
                this.BizCategorySerie.AllBy(x =>
                    x.CategoryId == categoryId &&
                    x.Enabled &&
                    // HERE! region filter
                    x.Assn_CategorySerieProduct.Any(z => z.Product.Assn_ProductRegion.Any(y => y.RegionId == regionId)));

            // Filter only products inside categorie-series by region
            entities.ForEach(x => {
                x.Assn_CategorySerieProduct = x.Assn_CategorySerieProduct.Where(y => y.Product.Assn_ProductRegion.Any(z => z.RegionId == regionId)).ToList();
            });

            ViewBag.Title =
                string.Format(":: Topp Pro Professional Audio {0} ::", controller);

            return View(entities);
        }

        [OutputCache(CacheProfile = "Long")]
        public virtual ActionResult Detail(string controller, int id, string name)
        {
            var entity = this.BizCategorySerieProduct.GetForDetail(id);

            ViewBag.Title =
                string.Format(":: Topp Pro {0} ::", entity.Product.Name.ToUpper());

            return View(entity);
        }

        [OutputCache(CacheProfile = "Long")]
        public virtual ActionResult HiRes(string controller, int id, string name)
        {
            var entity = this.BizCategorySerieProduct.GetForHiRes(id);

            ViewBag.Title =
                string.Format(":: Topp Pro {0} HiRes ::", entity.Product.Name.ToUpper());

            return View(entity);
        }

        [OutputCache(CacheProfile = "Long")]
        public virtual ActionResult Software(string controller, int id, string name)
        {
            var entity = 
                this.BizCategorySerieProduct.GetForSoftware(id);

            ViewBag.Title =
                string.Format(":: Topp Pro {0} Software ::", entity.Product.Name.ToUpper());

            return View(entity);
        }
    }
}
