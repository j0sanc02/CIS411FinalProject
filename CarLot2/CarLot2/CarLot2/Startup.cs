using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarLot2.Startup))]
namespace CarLot2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
