using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSportOnline.Startup))]
namespace WebSportOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
