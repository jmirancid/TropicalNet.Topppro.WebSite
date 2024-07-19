using System;
using System.Web.Mvc;
using Topppro.Interfaces.Business;

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
            var categoryId =
                (int)Enum.Parse(typeof(Topppro.Entities.Category_Enum), controller);

            //get region

            var entities =
                this.BizCategorySerie.AllBy(x => x.CategoryId == categoryId && x.Enabled);

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
