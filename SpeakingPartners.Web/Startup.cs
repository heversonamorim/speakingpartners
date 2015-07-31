using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpeakingPartners.Web.Startup))]
namespace SpeakingPartners.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
