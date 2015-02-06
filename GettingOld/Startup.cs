using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GettingOld.Startup))]
namespace GettingOld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
