using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolunteeringGUI.Startup))]
namespace VolunteeringGUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
