using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KompetanseApplikasjon.Startup))]
namespace KompetanseApplikasjon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
