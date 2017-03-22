using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaoinwestAPI.Startup))]
namespace PaoinwestAPI
{

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}