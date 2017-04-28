using Owin;
using System.Web.Http;

namespace PropertyManagement.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
            var config = new HttpConfiguration();
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}