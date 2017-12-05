using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITsearch.Startup))]
namespace ITsearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
