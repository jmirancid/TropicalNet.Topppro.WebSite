using System;
using System.Linq;
using System.Web.Mvc;

namespace Topppro.WebSite
{
    public class HandleRegionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            //string regionName = "am";
            string regionName =
                Enum.GetName(typeof(Topppro.Entities.Region_Enum), Context.Current.Region);

            if (filterContext.RouteData.Values.ContainsKey("region"))
                regionName = filterContext.RouteData.Values["region"].ToString().ToLower();

            if (IsRegionAvailable(regionName) && IsRegionDistinct(regionName))
            {
                Topppro.Entities.Region_Enum region;

                var result =
                    Enum.TryParse<Topppro.Entities.Region_Enum>(regionName, true, out region);

                if (result)
                    Context.Current.Region = region;
            }

            filterContext.RouteData.Values["region"] = regionName;

            base.OnActionExecuting(filterContext);
        }

        private bool IsRegionAvailable(string regionName)
        {
            return Enum.GetNames(typeof(Topppro.Entities.Region_Enum)).Any(r => r == regionName);
        }

        private bool IsRegionDistinct(string regionName)
        {
            return Enum.GetName(typeof(Topppro.Entities.Region_Enum), Context.Current.Region) != regionName;
        }
    }
}