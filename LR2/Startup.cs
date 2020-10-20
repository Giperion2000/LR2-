using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LR2.Startup))]
namespace LR2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
