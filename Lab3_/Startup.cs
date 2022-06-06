using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_.Startup))]
namespace Lab3_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
