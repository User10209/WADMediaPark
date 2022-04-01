using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaPark.Startup))]
namespace MediaPark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
