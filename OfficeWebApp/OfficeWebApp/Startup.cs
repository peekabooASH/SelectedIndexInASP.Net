using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficeWebApp.Startup))]
namespace OfficeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
