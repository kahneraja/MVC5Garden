using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Garden.Startup))]
namespace MVC5Garden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
