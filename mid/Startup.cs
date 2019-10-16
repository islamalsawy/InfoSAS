using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mid.Startup))]
namespace mid
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
