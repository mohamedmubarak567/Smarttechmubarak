using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mubaraktask.Startup))]
namespace mubaraktask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
