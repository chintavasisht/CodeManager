using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeManager.Startup))]
namespace CodeManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
