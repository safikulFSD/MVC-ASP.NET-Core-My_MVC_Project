using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_Project_MVC.Startup))]
namespace My_Project_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
