using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myfirstproject.Startup))]
namespace myfirstproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
