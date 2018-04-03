using Microsoft.Extensions.DependencyInjection;

namespace FuncServiceLocator
{
    public class ServiceLocator
    {
        private readonly ServiceProvider provider;
        internal ServiceLocator(IServiceRegistration serviceRegistration)
        {
            var serviceCollection = new ServiceCollection();
            serviceRegistration.RegisterServices(serviceCollection);
            provider = serviceCollection.BuildServiceProvider();
        }

        public T Get<T>()
        {
            return provider.GetRequiredService<T>();
        }
    }
}
