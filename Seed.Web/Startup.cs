using System.Web.Http;
using System.Web.Routing;
using Microsoft.Owin;
using Owin;
using Seed.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace Seed.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
#if DEBUG
            app.UseForcedHttps(44300);  // IIS Express
#else
            app.UseForcedHttps(443);
#endif

            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
