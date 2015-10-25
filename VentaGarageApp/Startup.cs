using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentaGarageApp.Startup))]
namespace VentaGarageApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
