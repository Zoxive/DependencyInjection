using System;
using System.Diagnostics;
using App;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ReproduceStackoverflow.App.MultiTenant;
using IHttpContextAccessor = Microsoft.AspNetCore.Http.IHttpContextAccessor;

namespace ReproduceStackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .Register()
                .AddMultiTenancy()
                .AddScoped<IHttpContextAccessor, NullHttpContextAccessor>()
                .AddScoped(typeof(Lazy<>), typeof(LazyImpl<>))
                .BuildServiceProvider(new ServiceProviderOptions
                {
                    ValidateScopes = true,
                    Mode = ServiceProviderMode.Dynamic
                });
                

            var current = Process.GetCurrentProcess();

            while (true)
            {
                Console.WriteLine($"PRE {current.MegaBytes()}");

                using (var scope = serviceProvider.CreateTenantScope(new Tenant("CPQ_DEV")))
                {
                    Console.WriteLine($"InsideScope {current.MegaBytes()}");

                    var tenant = scope.ServiceProvider.GetRequiredService<ITenant>();
                    Console.WriteLine($@"Tenant: {tenant.Id}");

                    var controller = scope.ServiceProvider.GetRequiredService<EntityRecordsController>();

                    Console.WriteLine($"AfterFactory {current.MegaBytes()}");
                }

                Console.WriteLine($"Done {current.MegaBytes()}");

                var r = Console.ReadLine();
                if (r == "q")
                    break;
            }

            current.Dispose();
        }
    }

     public class LazyImpl<T> : Lazy<T> where T: class
    {
        public LazyImpl(IServiceProvider ioc) : base(Resolve(ioc))
        {
        }

        private static T Resolve(IServiceProvider ioc)
        {
            return ioc.GetService<T>();
        }
    }

    internal class NullHttpContextAccessor : IHttpContextAccessor
    {
        public HttpContext HttpContext { get; set; }
    }

    public static class ProcessExtensiosn
    {
        public static string MegaBytes(this Process process)
        {
            process.Refresh();

            var bytes = process.PrivateMemorySize64;
            var megaBytes = (double)bytes / 1000000;
            return megaBytes.ToString("F");
        }
    }
}
