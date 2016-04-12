using Autofac;
using Autofac.Core;
using Autofac.Integration.Web;
using Kaia.DrivingSchool.Common;
using Kaia.DrivingSchool.Data.Repositories;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Kaia.DrivingSchool
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        private static IContainerProvider _containerProvider;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        void Application_Start(object sender, EventArgs e)
        {
            _logger.Trace("Starting application");

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureContainer();
        }

        void Application_End(object sender, EventArgs e)
        {
            _logger.Trace("Shutting down application");
        }

        void Application_Error(object sender, EventArgs e)
        {
            var lastError = Server.GetLastError();
            if (!(lastError is ThreadAbortException))
            {
                _logger.Error(lastError, "Uncaught exception");
            }
        }

        private void ConfigureContainer()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"];
            var builder = new ContainerBuilder();
            builder.RegisterType<SystemClock>().As<IClock>();
            // TODO Move into Autofac module as number of repositories increases
            builder
                .RegisterType<DbDriverRepository>()
                .WithParameters(new List<Parameter>
                {
                    new NamedParameter("providerName", connectionString.ProviderName),
                    new NamedParameter("connectionString", connectionString.ConnectionString)
                })
                .As<IDriverRepository>();
            _containerProvider = new ContainerProvider(builder.Build());
        }
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

    }
}