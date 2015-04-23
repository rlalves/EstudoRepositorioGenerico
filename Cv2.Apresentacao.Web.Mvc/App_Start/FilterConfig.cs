using System.Web;
using System.Web.Mvc;

namespace Cv2.Apresentacao.Web.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}