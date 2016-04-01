using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaDemo.Startup))]
namespace SpaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
