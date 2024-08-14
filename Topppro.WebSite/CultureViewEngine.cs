using System.Web.Mvc;

namespace Topppro.WebSite
{
    public class CultureViewEngine : RazorViewEngine
    {
        public CultureViewEngine() :
            base()
        { }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            var controllerName = (string)controllerContext.RouteData.Values["controller"];
            var culture = Topppro.Context.Current.Culture.TwoLetterISOLanguageName;

            var viewResult = base.FindView(controllerContext, viewName + "." + culture, masterName, false);

            if (viewResult.View == null)
                viewResult = base.FindView(controllerContext, viewName, masterName, false);

            return viewResult;
        }

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            var controllerName = (string)controllerContext.RouteData.Values["controller"];
            var culture = Topppro.Context.Current.Culture.TwoLetterISOLanguageName;

            var viewResult = base.FindPartialView(controllerContext, partialViewName + "." + culture, false);

            if (viewResult.View == null)
                viewResult = base.FindPartialView(controllerContext, partialViewName, false);

            return viewResult;
        }
    }
}