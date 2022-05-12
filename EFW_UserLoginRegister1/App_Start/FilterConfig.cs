using System.Web;
using System.Web.Mvc;

namespace EFW_UserLoginRegister1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
