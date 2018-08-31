using System.Web.Http;

namespace WebApiSlash
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi","api/{controller}/");
        }
    }
}
