using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shamazon.Startup))]
namespace Shamazon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
