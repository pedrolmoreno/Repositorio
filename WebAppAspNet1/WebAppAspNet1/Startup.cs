using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAspNet1.Startup))]
namespace WebAppAspNet1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
