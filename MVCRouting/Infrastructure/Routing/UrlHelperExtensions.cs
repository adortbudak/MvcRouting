using System.Web.Mvc;
using MVCRouting.Infrastructure.Urls;

namespace MVCRouting.Infrastructure.Routing
{
    public static class UrlHelperExtensions
    {
        

        public static string GetUrl(this UrlHelper urlHelper, string controller, string action)
        {
            return new OneKeyUrl(urlHelper,controller,action).GetUrl();
        }
    }
}