using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageGallery.Web.Startup))]
namespace ImageGallery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperBootstrapper.Init();
            ConfigureAuth(app);
        }
    }
}
