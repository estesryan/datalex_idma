using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Datalex.IDMA.Services.Common;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Reflection;

namespace Datalex.IDMA.Web
{
    public class Global : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoMapperConfig.Register();

            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.Register(c => c.Resolve<HttpContextBase>().Request)
                 .As<HttpRequestBase>()
                 .InstancePerLifetimeScope();
            builder.Register(c => c.Resolve<HttpContextBase>().Response)
                 .As<HttpResponseBase>()
                 .InstancePerLifetimeScope();
            builder.Register(c => c.Resolve<HttpContextBase>().Server)
                 .As<HttpServerUtilityBase>()
                 .InstancePerLifetimeScope();
            builder.Register(c => c.Resolve<HttpContextBase>().Session)
                 .As<HttpSessionStateBase>()
                 .InstancePerLifetimeScope();

            builder.RegisterType<CommonService>().As<ICommonService>().InstancePerLifetimeScope();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}