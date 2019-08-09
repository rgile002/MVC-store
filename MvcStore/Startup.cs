using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcStore.Startup))]
namespace MvcStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
