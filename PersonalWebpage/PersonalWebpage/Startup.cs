using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalWebpage.Startup))]
namespace PersonalWebpage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
