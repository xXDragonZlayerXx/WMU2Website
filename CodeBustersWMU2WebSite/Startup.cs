using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeBustersWMU2WebSite.Startup))]
namespace CodeBustersWMU2WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
