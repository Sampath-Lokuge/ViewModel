using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPViewModel.Startup))]
namespace ASPViewModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
