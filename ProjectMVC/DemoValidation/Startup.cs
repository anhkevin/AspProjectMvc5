using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoValidation.Startup))]
namespace DemoValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
