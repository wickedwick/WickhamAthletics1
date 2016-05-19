using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WickhamAthletics.Startup))]
namespace WickhamAthletics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
