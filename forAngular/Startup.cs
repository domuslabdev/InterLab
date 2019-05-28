using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(forAngular.Startup))]
namespace forAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
