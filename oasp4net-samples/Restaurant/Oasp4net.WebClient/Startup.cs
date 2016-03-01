using Microsoft.Owin;
using Oasp4net.WebClient;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Oasp4net.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
