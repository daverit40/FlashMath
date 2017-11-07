using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashMath.Startup))]
namespace FlashMath
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
