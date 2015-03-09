using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelectedIndexNormal.Startup))]
namespace SelectedIndexNormal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
