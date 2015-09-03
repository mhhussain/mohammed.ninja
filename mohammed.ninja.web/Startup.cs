using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mohammed.ninja.web.Startup))]
namespace mohammed.ninja.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
