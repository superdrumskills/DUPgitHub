using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DUPgitHub.Startup))]
namespace DUPgitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
