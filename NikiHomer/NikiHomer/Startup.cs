using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NikiHomer.Startup))]
namespace NikiHomer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
