using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerce_Web01.Startup))]
namespace ECommerce_Web01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
