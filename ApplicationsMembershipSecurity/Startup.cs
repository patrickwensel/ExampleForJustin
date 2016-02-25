using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationsMembershipSecurity.Startup))]
namespace ApplicationsMembershipSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
