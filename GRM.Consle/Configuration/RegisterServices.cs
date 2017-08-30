using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GRM.FileTxt.Service;
using GRM.UI_Inter.About;
using GRM.UI_Inter.Managers;
using GRM.UI_Inter.MusicContracts;
using GRM.UI_Inter.PartnerContracts;
using GRM.UI_Inter.WelcomeMessage;

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
            builder.RegisterType<DisplayManager>().As<IDisplayManager>();


            //Services
            builder.RegisterType<FileService>().As<IFileService>();
            

            //Views
            builder.RegisterType<AboutPage>().As<IAboutPage>();
            builder.RegisterType<MusicContractPage>().As<IMusicContractPage>();
            builder.RegisterType<PartnerContractPage>().As<IPartnerContractPage>();
            builder.RegisterType<WelcomeInformation>().As<IWelcomeInformation>();

            


            //Repositories


            base.Load(builder);
        }
    }
}

