using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin_Equipos.Startup))]
namespace Admin_Equipos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
