﻿using System.Web;
using System.Web.Mvc;

namespace Topppro.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleCultureAttribute());
            filters.Add(new HandleRegionAttribute());
        }
    }
}
