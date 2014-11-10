using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wix.Startup))]
namespace Wix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
