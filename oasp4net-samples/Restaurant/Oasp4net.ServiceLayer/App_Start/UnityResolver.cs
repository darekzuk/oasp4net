
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace Oasp4net.ServiceLayer.App_Start
{
    /// <summary>
    /// Wraps the unity container
    /// </summary>
    public class UnityResolver : IDependencyResolver
    {
        /// <summary>
        /// A unity container
        /// </summary>
        protected IUnityContainer _container;

        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="container">The injected uity container</param>
        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            _container = container;
        }

        /// <summary>
        /// Resolves a type
        /// </summary>
        /// <param name="serviceType">Type to be resolved</param>
        /// <returns>The concrete object</returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        /// Resolves a type
        /// </summary>
        /// <param name="serviceType">Type to be resolved</param>
        /// <returns>A <c>Enumerable</c> of concrete objects</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        /// <summary>
        /// Starts a resolution scope.
        /// </summary>
        /// <returns>The dependency scope.</returns>
        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityResolver(child);
        }

        /// <summary>
        /// Free resources
        /// </summary>
        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
