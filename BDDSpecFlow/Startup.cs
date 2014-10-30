using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BDDSpecFlow.Startup))]
namespace BDDSpecFlow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
