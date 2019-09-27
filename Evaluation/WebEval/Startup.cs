using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebEval.Startup))]
namespace WebEval
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
