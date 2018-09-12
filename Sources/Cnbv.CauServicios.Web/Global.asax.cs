using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Cnbv.CauServicios.Data;
using System.Data.Entity;
using System.Web.Security;
using System.Security.Principal;

namespace Cnbv.CauServicios.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer<CauServiciosContext>(null);
            ///////ApplicationDBContext db = new ApplicationDbContext();
            ///// db.Database.Initialize(true);

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Autofac and Automapper configurations
            Bootstrapper.Run();
        }

        public override void Init()
        {
            base.PostAuthenticateRequest += OnAuthenticateRequest;
        }

        private void OnAuthenticateRequest(object sender, EventArgs eventArgs)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                var cookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                var decodedTicket = FormsAuthentication.Decrypt(cookie.Value);
                var roles = decodedTicket.UserData.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                var principal = new GenericPrincipal(HttpContext.Current.User.Identity, roles);
                HttpContext.Current.User = principal;
            }
        }

    }
}