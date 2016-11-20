using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(consultants.Startup))]
namespace consultants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
