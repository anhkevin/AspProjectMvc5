using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Localization.Infrastructure;

namespace Localization.App_Start
{
    public class FilterConfig
    {
        public static void Configure(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LocalizationAttribute("vi"), 0);
        }
    }
}