using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppArch.Startup))]
namespace WebAppArch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
