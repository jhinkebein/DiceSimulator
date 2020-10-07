using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDiceSimulator.Startup))]
namespace WebDiceSimulator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
