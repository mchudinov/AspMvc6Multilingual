using System.Globalization;
using System.Threading;
using Microsoft.AspNet.Mvc;

namespace AspMvcMultilingual.Controllers
{
    public abstract class BaseController : Controller
    {
        //public string CurrentLangCode { get; protected set; }

        //public Language CurrentLang { get; protected set; }

        protected BaseController()
        {
            /*if (requestContext.HttpContext.Request.Url != null)
            {
                HostName = requestContext.HttpContext.Request.Url.Authority;
            }*/

            var h = Request.

            if (RequestContext.RouteData.Values["lang"] != null && requestContext.RouteData.Values["lang"] as string != "null")
            {
                CurrentLangCode = requestContext.RouteData.Values["lang"] as string;
                CurrentLang = Repository.Languages.FirstOrDefault(p => p.Code == CurrentLangCode);

                var ci = new CultureInfo(CurrentLangCode);
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);
            }
            //base.Initialize(requestContext);
        }
    }
}
