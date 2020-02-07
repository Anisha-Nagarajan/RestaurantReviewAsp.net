using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantReviewWeb.Startup))]
namespace RestaurantReviewWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
