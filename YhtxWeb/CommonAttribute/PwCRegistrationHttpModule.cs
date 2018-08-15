using ApplicationCenter.ClientClass;
using System;
using System.Configuration;
using System.Web;
using System.Text.RegularExpressions;

namespace YhtxWeb.CommonAttribute
{
    public class PwCRegistrationHttpModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.EndRequest += OnApplicationEndRequest;
            context.AuthorizeRequest += OnAuthorizeRequest;
            context.AuthenticateRequest += OnAuthenticateRequest;
        }

        private static void OnAuthenticateRequest(object sender, EventArgs e)
        {
            if (Regex.IsMatch(HttpContext.Current.Request.RawUrl, @"(/[^/#?]+)*\.(?:svc)[\w?]*$"))
            {
                return;
            }
            HttpRequestAuthenticate hra = new HttpRequestAuthenticate(HttpContext.Current);
            hra.Authenticate();

        }


        private static void OnAuthorizeRequest(object sender, EventArgs e)
        {
            if (Regex.IsMatch(HttpContext.Current.Request.RawUrl, @"(/[^/#?]+)*\.(?:svc)[\w?]*$"))
            {
                return;
            }

            if (HttpContext.Current.User == null || !HttpContext.Current.User.Identity.IsAuthenticated)
            {
                UnAuthorized();
            }
        }


        public static void UnAuthorized()
        {
            string pageUrl = ConfigurationManager.AppSettings["UnAuthorizedPageUrl"] as string;
            if (string.IsNullOrEmpty(pageUrl)) HttpContext.Current.ApplicationInstance.Response.Redirect(pageUrl);

        }


        // If the request was unauthorized, add the WWW-Authenticate header 
        // to the response.
        private static void OnApplicationEndRequest(object sender, EventArgs e)
        {


        }

        public void Dispose()
        {
        }
    }
}
