using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniTutor.Startup))]
namespace UniTutor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
