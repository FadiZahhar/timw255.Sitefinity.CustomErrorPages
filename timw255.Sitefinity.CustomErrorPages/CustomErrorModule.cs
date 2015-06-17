using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Web;

namespace timw255.Sitefinity.CustomErrorPages
{
    public class CustomErrorModule : IHttpModule
    {
        private PageManager _pageManager;
        internal PageManager PageManager
        {
            get
            {
                if (_pageManager == null)
                {
                    _pageManager = PageManager.GetManager();
                }
                return _pageManager;
            }
        }

        private CustomErrorPagesManager _customErrorPagesManager;
        internal CustomErrorPagesManager ErrorPagesManager
        {
            get
            {
                if (_customErrorPagesManager == null)
                {
                    _customErrorPagesManager = CustomErrorPagesManager.GetManager();
                }
                return _customErrorPagesManager;
            }
        }

        public void Init(HttpApplication application)
        {
            application.Error += new EventHandler(Application_Error);
        }  

        public void Application_Error(Object sender, EventArgs e)
        {
            // check to see if something horrible is going on...
            if (HttpContext.Current.Request.Headers["Custom-Error-Request"] != null)
            {
                // looks like a request to grab an error page ended up here. let's bail.
                return;
            }

            // get the last error
            HttpException err = HttpContext.Current.Server.GetLastError() as HttpException;

            HttpContext.Current.Server.ClearError();

            // try to skip using any other custom error settings
            HttpContext.Current.Response.TrySkipIisCustomErrors = true;

            // check to see if we need to send back something pretty
            var acceptsHtml = HttpContext.Current.Request.Headers["Accept"].Contains("text/html");

            // we're on!
            if (err != null && acceptsHtml)
            {
                // get the language from the visitor's browser settings
                string lang = (HttpContext.Current.Request.UserLanguages ?? Enumerable.Empty<string>()).FirstOrDefault();
                var culture = CultureInfo.GetCultureInfo(lang);

                // set the culture to match the browser language. (this makes it incredibly easy
                // to return the correct language version, if applicable.)
                Thread.CurrentThread.CurrentUICulture = culture;

                // get the page node associated with the current error
                PageNode pNode = GetPageAssociatedWithHttpCode(err.GetHttpCode());

                // set the worst case response to visitor
                string html = err.GetHttpCode().ToString();

                if (pNode != null)
                {
                    // grab the URL of the error page we're going to display to the visitor
                    string url = pNode.GetFullUrl(culture, true);
                    url = UrlPath.ResolveUrl(url, true, true);

                    // grab the entire HTML of the page
                    WebClient client = new WebClient { Encoding = Encoding.UTF8 };
                    client.Headers.Add("Custom-Error-Request", "");

                    try
                    {
                        html = client.DownloadString(url);
                    }
                    catch (WebException ex)
                    {
                        // the error page is probably blowing up. maybe do some logging...or send an email? ¯\_(ツ)_/¯
                    }
                }

                // send back the the best response we got for the error and a status code
                HttpContext.Current.Response.Write(html);
                HttpContext.Current.Response.StatusCode = err.GetHttpCode();
                HttpContext.Current.Response.End();
                
            }
            else if (err != null)
            {
                // just fire back a basic message and the status 
                HttpContext.Current.Response.Write(err.GetHttpCode().ToString());
                HttpContext.Current.Response.StatusCode = err.GetHttpCode();
            }
        }

        private PageNode GetPageAssociatedWithHttpCode(int httpCode)
        {
            PageNode pNode = null;

            string httpCodeString = httpCode.ToString();

            var item = ErrorPagesManager.GetCustomErrorPageItems().Where(i => i.StatusCode == httpCodeString).FirstOrDefault();

            if (item != null)
            {
                // This should exist!
                pNode = PageManager.GetPageNodes().Where(pN => pN.Id == item.PageId).FirstOrDefault();
            }

            return pNode;
        }

        public void Dispose()
        {
        }
    }
}
