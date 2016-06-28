using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fosfato.WebUI.Startup))]
namespace Fosfato.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
