using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICT4RealsWebForms.Startup))]
namespace ICT4RealsWebForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
