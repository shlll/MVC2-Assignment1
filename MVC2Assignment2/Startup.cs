using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC2Assignment2.Startup))]
namespace MVC2Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
