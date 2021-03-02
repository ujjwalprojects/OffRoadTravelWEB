using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourTravel_Web.Startup))]
namespace TourTravel_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
