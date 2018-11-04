using System.Web;
using System.Web.Mvc;

// Disable all XML Comment warnings in this file //
#pragma warning disable 1591

namespace Triangles
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
