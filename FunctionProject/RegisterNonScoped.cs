using Microsoft.Extensions.DependencyInjection;

using FuncServiceLocator;
using Library;

namespace FunctionProject
{
    public class RegisterNonScoped : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddGreeterTransient();
            services.AddGreeterConsumer();
        }
    }
}
