using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCRouting.Infrastructure.Urls
{
    public class OneKeyUrl
    {
        protected UrlHelper Url { get; set; }

        protected string Section { get; set; }

        protected string Controller { get; set; }

        protected string Action { get; set; }

        private string[] _uriSegments;  

        public OneKeyUrl(UrlHelper url,string controller, string action)
        {
            Url = url;
            Controller = controller;
            Action = action;
            if (Url.RequestContext.HttpContext.Request.Url == null) return;
            var currentUri = new Uri(Url.RequestContext.HttpContext.Request.Url.AbsoluteUri);
            _uriSegments = currentUri.Segments;
        }

        public string GetUrl()
        {
            var availableSegments = new List<string>()
            {
                "/",
                "en/",
                "fr/",
                "mx/",
                "es/"
            };

            var returnUrl = Controller ;
            
            if (availableSegments.Contains(_uriSegments[1]))
            {
                returnUrl = _uriSegments[1].Replace("/", "") + "_"  + Controller;
            }
            
            if (!string.IsNullOrEmpty(Action))
            {
                returnUrl += "_" + Action;
            }

            var val = Url.RouteUrl(returnUrl);
            return val;
        }
    }
}