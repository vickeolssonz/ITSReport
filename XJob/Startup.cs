using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XJob.Startup))]
namespace XJob
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
