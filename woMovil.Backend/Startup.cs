using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(woMovil.Backend.Startup))]
namespace woMovil.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
