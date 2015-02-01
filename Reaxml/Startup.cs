using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reaxml.Startup))]
namespace Reaxml
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
