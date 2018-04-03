using Microsoft.Extensions.DependencyInjection;

using FuncServiceLocator;
using Library;

namespace FunctionProject
{
    public class RegisterScoped : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddGreeterScoped();
            services.AddGreeterConsumer();
        }
    }
}
