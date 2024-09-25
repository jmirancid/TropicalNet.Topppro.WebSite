using System.Web.Mvc;
using System.Linq;
using Topppro.Interfaces.Business;
using System;
using xFNet.Common.Extensions;

namespace Topppro.WebSite.Controllers
{
    public class MenuController : Controller
    {
        protected IAssnCategorySerieProductBusiness BizCategorySerieProduct { get; private set; }

        public MenuController() { }

        public MenuController(IAssnCategorySerieProductBusiness bizCategorySerieProduct)
        {
            this.BizCategorySerieProduct = bizCategorySerieProduct;
        }

        // GET: Menu
        [ChildActionOnly]
        public virtual PartialViewResult Render(string region, string controller)
        {
            var regionId =
                Topppro.Context.Current.Region.As<int>();

            var entities = 
                this.BizCategorySerieProduct.AllForMenu(x =>
                    x.Enabled &&
                    x.Product.Assn_ProductRegion.Any(y => y.RegionId == regionId));

            return PartialView("_Menu", entities);
        }
    }
}