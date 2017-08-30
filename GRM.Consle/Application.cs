using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using GRM.UI_Inter.Managers;

namespace GRM.Consle
{
    public class Application : IApplication
    {
        private readonly IDisplayManager _displayManager;

        public Application(IDisplayManager displayManager)
        {
            _displayManager = displayManager;
        }

        public void Run()
        {
            _displayManager.Home();
            
            //var builder = new ContainerBuilder();
//
//            builder.RegisterType<BatchService.BatchService>().As<IBatchService>();
//            Container = builder.Build();
//
//            using (var scope = Container.BeginLifetimeScope())
//            {
//                var batchService = scope.Resolve<IBatchService>();
//
//                batchService.WriteInformation("Injected!");
//            }
//
//            uiManager.DisplayWelcome();
//
//            //login
//            uiManager.DisplayLogin();
        }
    }
}
