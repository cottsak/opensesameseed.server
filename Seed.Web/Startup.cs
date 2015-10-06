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
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
