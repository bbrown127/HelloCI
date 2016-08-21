using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloCI.web.Startup))]
namespace HelloCI.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
