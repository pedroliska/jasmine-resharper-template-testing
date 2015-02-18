using System.Web;
using System.Web.Mvc;

namespace jasmine_resharper_template_testing
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
