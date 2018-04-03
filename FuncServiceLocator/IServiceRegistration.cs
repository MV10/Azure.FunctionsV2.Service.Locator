using Microsoft.Extensions.DependencyInjection;

namespace FuncServiceLocator
{
    public interface IServiceRegistration
    {
        void RegisterServices(IServiceCollection services);
    }
}
