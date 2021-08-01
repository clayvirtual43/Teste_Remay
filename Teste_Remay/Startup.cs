using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teste_Remay.Startup))]
namespace Teste_Remay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
