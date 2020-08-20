using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemsServidor.Startup))]
namespace RemsServidor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
