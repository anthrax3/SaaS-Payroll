﻿using System.Web;
using System.Web.Mvc;

namespace OpenQbit.PayrollSystem.Service.WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
