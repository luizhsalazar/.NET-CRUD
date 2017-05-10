using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD.UI.Site.Startup))]
namespace CRUD.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
