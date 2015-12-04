using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcpro.Startup))]
namespace mvcpro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
