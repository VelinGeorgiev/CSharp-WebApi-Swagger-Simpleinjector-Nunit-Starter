using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using ApiReference.Interfaces;
using ApiReference.Services;

namespace ApiReference
{
    /// <summary>
    /// Simpleinjector webapi integration
    /// https://simpleinjector.readthedocs.io/en/latest/webapiintegration.html
    /// </summary>
    public static class SimpleInjectorConfig
    {
        public static Container Container { get; private set; }

        public static void Initialize()
        {
            // Create the container as usual.
            Container = new Container();
            Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance:
            RegisterTypes(Container);

            // This is an extension method from the integration package.
            Container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            Container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Container);
        }

        private static void RegisterTypes(Container container)
        {
            // Register your types, for instance using the scoped lifestyle:
            container.Register<IBillService, PayPalBillService>(Lifestyle.Scoped);
        }
    }
}