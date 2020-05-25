using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace XJob
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			var settigs = config.Formatters.JsonFormatter.SerializerSettings;
			settigs.ContractResolver = new CamelCasePropertyNamesContractResolver();
			settigs.Formatting = Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
