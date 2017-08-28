using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core;

namespace GRM.Consle
{
    public class Application
    {
        private readonly ICustomerManager _customerManager;

        private readonly ITransactionManager _transactionManager;

        private readonly IAccountManager _accountManager;

        public Application(ICustomerManager customerManager, ITransactionManager transactionManager, IAccountManager accountManager)
        {
            _customerManager = customerManager;
            _transactionManager = transactionManager;
            _accountManager = accountManager;
        }

        public void Run()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BatchService.BatchService>().As<IBatchService>();
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var batchService = scope.Resolve<IBatchService>();

                batchService.WriteInformation("Injected!");
            }

            uiManager.DisplayWelcome();

            //login
            uiManager.DisplayLogin();
        }
    }
}
