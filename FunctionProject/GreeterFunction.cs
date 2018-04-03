using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

using static FuncServiceLocator.ServiceLocatorFactory;
using Library;

namespace FunctionProject
{
    public static class GreeterFunction
    {
        [FunctionName("GreeterSingleton1")]
        public static async Task<IActionResult> Run1([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var services = GetServiceLocator<RegisterSingletons>();
            var greeter = services.Get<IGreeter>();

            return new OkObjectResult(greeter.Greet());
        }

        [FunctionName("GreeterSingleton2")]
        public static async Task<IActionResult> Run2([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var services = GetServiceLocator<RegisterSingletons>();
            var greeter = services.Get<IGreeter>();

            return new OkObjectResult(greeter.Greet());
        }

        [FunctionName("GreeterScoped")]
        public static async Task<IActionResult> Run3([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var services = GetServiceLocator<RegisterScoped>();
            var greeter = services.Get<IGreeter>();
            var scoped = services.Get<IGreeterConsumer>();

            return new OkObjectResult($"greetersvc {greeter.Greet()} --- scopedsvc {scoped.Greeting()}");
        }

        [FunctionName("GreeterNonScoped")]
        public static async Task<IActionResult> Run4([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var services = GetServiceLocator<RegisterNonScoped>();
            var greeter = services.Get<IGreeter>();
            var scoped = services.Get<IGreeterConsumer>();

            return new OkObjectResult($"greetersvc {greeter.Greet()} --- scopedsvc {scoped.Greeting()}");
        }

        [FunctionName("GreeterTransient")]
        public static async Task<IActionResult> Run5([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var services = GetServiceLocator<RegisterTransient>();
            var greeter = services.Get<IGreeter>();

            return new OkObjectResult(greeter.Greet());
        }

    }
}
