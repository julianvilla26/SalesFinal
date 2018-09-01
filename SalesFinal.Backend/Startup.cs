using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesFinal.Backend.Startup))]
namespace SalesFinal.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
