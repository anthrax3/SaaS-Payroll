using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayrollTest.Presentation.Web.Startup))]
namespace PayrollTest.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
