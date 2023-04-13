using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrialIntex.Startup))]
namespace TrialIntex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
