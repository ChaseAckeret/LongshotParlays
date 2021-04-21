using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LongshotParlays.Web.Startup))]
namespace LongshotParlays.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
