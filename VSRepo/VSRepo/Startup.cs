using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSRepo.Startup))]
namespace VSRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
