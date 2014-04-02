using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPractice.Startup))]
namespace WebPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
