using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoWeb.Startup))]
namespace proyectoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
