using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dashboard.UI.Startup))]
namespace Dashboard.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
