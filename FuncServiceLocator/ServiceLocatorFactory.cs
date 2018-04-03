using System;
using System.Collections.Concurrent;

namespace FuncServiceLocator
{
    public static class ServiceLocatorFactory
    {
        private static ConcurrentDictionary<Type, Lazy<ServiceLocator>> ServiceCollections = new ConcurrentDictionary<Type, Lazy<ServiceLocator>>();
        public static ServiceLocator GetServiceLocator<T>() where T : IServiceRegistration, new()
        {
            return ServiceCollections.GetOrAdd(typeof(T), 
                f => new Lazy<ServiceLocator>(() => 
                {
                    return new ServiceLocator(new T() as IServiceRegistration);
                })).Value;
        }
    }
}
