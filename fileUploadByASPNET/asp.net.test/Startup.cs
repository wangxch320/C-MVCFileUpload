using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net.test.Startup))]
namespace asp.net.test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
