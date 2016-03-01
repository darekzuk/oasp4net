using System;
using System.Reflection;
using Microsoft.Practices.Unity;
using Oasp4net.BusinessLogicLayer.OfferManagement.Implementation;
using Oasp4net.DataAccessLayer.Transaction;
using Oasp4net.DataAccessLayer;
using Oasp4net.DataAccessLayer.Offermanagement;

namespace Oasp4net.ServiceLayer.App_Start
{
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {

            //Register Business Logic
            container.RegisterTypes(
                    AllClasses.FromAssemblies(Assembly.GetAssembly(typeof(OfferManagement))),
                    WithMappings.FromMatchingInterface,
                    WithName.Default,
                    WithLifetime.Custom<HierarchicalLifetimeManager>);

            //Register Repository
            container.RegisterTypes(
                    AllClasses.FromAssemblies(Assembly.GetAssembly(typeof(OfferManagementRepository))),
                    WithMappings.FromMatchingInterface,
                    WithName.Default,
                    WithLifetime.Custom<HierarchicalLifetimeManager>);
            container.RegisterInstance(new RestaurantContext(), new HierarchicalLifetimeManager());            
            container.RegisterType<ITransactionScope, TransactionScope>(new HierarchicalLifetimeManager());
        }

    }
}
