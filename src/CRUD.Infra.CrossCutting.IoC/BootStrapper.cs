using CRUD.Application;
using CRUD.Application.Interfaces;
using System.ComponentModel;
using SimpleInjector;
using CRUD.Domain.Interfaces.Services;
using CRUD.Domain.Interfaces.Repository;
using CRUD.Infra.Data.Repository;
using CRUD.Domain.Services;

namespace CRUD.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(SimpleInjector.Container container)
        {
            // App
            container.Register<IClientAppService, ClientAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IClientService, ClientService>(Lifestyle.Scoped);

            // Data
            container.Register<IClientRepository, ClientRepository>(Lifestyle.Scoped);
        }
    }
}
