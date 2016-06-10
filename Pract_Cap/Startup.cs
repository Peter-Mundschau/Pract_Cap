using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pract_Cap.Startup))]
namespace Pract_Cap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
