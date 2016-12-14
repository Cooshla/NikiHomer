using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BelaRose.Startup))]
namespace BelaRose
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
