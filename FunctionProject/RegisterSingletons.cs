using Microsoft.Extensions.DependencyInjection;

using FuncServiceLocator;
using Library;

namespace FunctionProject
{
    public class RegisterSingletons : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddGreeterSingleton();
        }
    }
}
