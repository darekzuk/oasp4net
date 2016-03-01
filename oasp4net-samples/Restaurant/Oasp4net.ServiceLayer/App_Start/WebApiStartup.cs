using Microsoft.Practices.EnterpriseLibrary.Logging;
using Oasp4net.DataAccessLayer;
using Oasp4net.Infrastructure.Logging;
using Oasp4net.ServiceLayer.Api.Mapper;
using Owin;
using Swashbuckle.Application;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Oasp4net.ServiceLayer.App_Start
{
    public class WebApiStartup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            //Configure Data directory to place local DB
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            // Initialize Logging
            Logger.SetLogWriter(new LogWriter(LoggingConfigurator.ConfigureLogging()));

            // Configure the context
            RestaurantContext.Configure();

            // Initialize AutoMapper
            MapperIntializer.ConfigureMapper();

            // Configure Web API for self-host.
            HttpConfiguration config = new HttpConfiguration
            {
                DependencyResolver = new UnityResolver(UnityConfig.GetConfiguredContainer())
            };

            // Attribute routing.
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "oasp4j-sample-server/services/rest/{controller}",
                defaults: new { }
            );

            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Restaurant Service API");
                c.IncludeXmlComments(System.String.Format(@"{0}\WebApiSwagger.XML", System.AppDomain.CurrentDomain.BaseDirectory));
            }).EnableSwaggerUi();

            //Enable simple command line logging for every request
            //appBuilder.UseCors(CorsOptions.AllowAll);
            appBuilder.Use<LoggingMiddleware>();
            appBuilder.UseWebApi(config);
        }
    }
}