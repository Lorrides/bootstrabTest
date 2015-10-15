using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bootstrabTest.Startup))]
namespace bootstrabTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
