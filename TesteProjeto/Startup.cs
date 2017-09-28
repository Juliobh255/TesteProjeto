using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteProjeto.Startup))]
namespace TesteProjeto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
