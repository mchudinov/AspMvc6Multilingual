using System.Globalization;
using System.Threading;
using Microsoft.AspNet.Mvc;

namespace AspMvcMultilingual.Controllers
{
    public abstract class BaseController : Controller
    {
        public string CurrentLanguageCode { get; protected set; }

        protected BaseController()
        {
            if (ActionContext.RouteData?.Values["lang"] != null && ActionContext.RouteData.Values["lang"] as string != "null")
            {
                CurrentLanguageCode = ActionContext.RouteData.Values["lang"] as string;
                if (CurrentLanguageCode != null)
                {
                    var ci = new CultureInfo(CurrentLanguageCode);
                    //Thread.CurrentThread.CurrentUICulture = ci;
                    //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);

                    //CultureInfo.CurrentCulture = new CultureInfo(CurrentLanguageCode);
                }
            }
        }
    }
}
