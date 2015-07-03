using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SH.Web.UI.Startup))]
namespace SH.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
