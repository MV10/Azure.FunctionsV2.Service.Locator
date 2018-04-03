using Microsoft.Extensions.DependencyInjection;

using FuncServiceLocator;
using Library;

namespace FunctionProject
{
    public class RegisterTransient : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddGreeterTransient();
        }
    }
}
