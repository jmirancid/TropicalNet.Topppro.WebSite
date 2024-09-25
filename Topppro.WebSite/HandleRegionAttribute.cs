using System;
using System.Linq;
using System.Web.Mvc;
using xFNet.Common.Extensions;

namespace Topppro.WebSite
{
    public class HandleRegionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            string regionName;

            if (filterContext.RouteData.Values.ContainsKey("region"))
                regionName = filterContext.RouteData.Values["region"].ToString().ToLower();
            else
                regionName = Enum.GetName(typeof(Topppro.Entities.Region_Enum), Topppro.Context.Current.Region);

            if (IsRegionAvailable(regionName) == false)
                regionName = Enum.GetName(typeof(Topppro.Entities.Region_Enum), Topppro.Entities.Region_Enum.am);
            
            if (IsRegionDistinct(regionName))
                Topppro.Context.Current.Region = Enum.Parse(typeof(Topppro.Entities.Region_Enum), regionName, true).As<Topppro.Entities.Region_Enum>();

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