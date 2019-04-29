using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cause_fights.Startup))]
namespace cause_fights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
