using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jasmine_resharper_template_testing.Startup))]
namespace jasmine_resharper_template_testing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
