using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GRM.UI_Inter.About;

namespace GRM.Consle.Configuration
{
    public class RegisterServices : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //DataContext
            //   builder.RegisterType<DataContext>().As<IDataContext>().InstancePerLifetimeScope();
            //builder.RegisterType<DbContextFactory>().As<IDbContextFactory>().InstancePerHttpRequest();
            //Applicaion
            builder.RegisterType<Application>().As<IApplication>();

            //Validation


            //Managers


            //Services

            //Views
            builder.RegisterType<AboutPage>().As<IAboutPage>();


            //Repositories


            base.Load(builder);
        }
    }
}
