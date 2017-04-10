using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fileUploadByMVC.Startup))]
namespace fileUploadByMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
