using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCA_AD.Startup))]
namespace MCA_AD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
