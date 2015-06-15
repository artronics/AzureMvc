using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMvc.Startup))]
namespace AzureMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
