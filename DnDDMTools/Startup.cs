using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnDDMTools.Startup))]
namespace DnDDMTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
