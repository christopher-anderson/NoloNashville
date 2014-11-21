using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nolo_Nashville.Startup))]
namespace Nolo_Nashville
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
