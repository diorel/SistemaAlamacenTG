using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemAlmacenTEC.Startup))]
namespace SistemAlmacenTEC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
