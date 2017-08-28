using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace GRM.Consle.Configuration
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //This registers 'A'
            builder.RegisterAssemblyModules(typeof(ContainerConfig).Assembly);

            //    GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return builder.Build();
        }
    }
}
