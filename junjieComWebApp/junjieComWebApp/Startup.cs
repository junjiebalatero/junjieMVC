using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(junjieComWebApp.Startup))]
namespace junjieComWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
