using System;
using System.Diagnostics;
using App;
using Microsoft.Extensions.DependencyInjection;
using ReproduceStackoverflow.App.MultiTenant;

namespace ReproduceStackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .Register()
                .AddMultiTenancy()
                .AddScoped(typeof(Lazy<>), typeof(LazyImpl<>))
                .BuildServiceProvider(new ServiceProviderOptions
                {
                    ValidateScopes = true,
                    //Mode = ServiceProviderMode.Dynamic

                    // Force compiled to get stackoverflow right away
                    Mode = ServiceProviderMode.Compiled
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

                    // StackOverflow
                    var overflow = scope.ServiceProvider.GetRequiredService<IEntityRecordActionExecutionServiceFactory>();

                    // Going straight to what I think the problem child is
                    // System.InvalidProgramException: 'Common Language Runtime detected an invalid program.'
                    //var more = scope.ServiceProvider.GetRequiredService<ICurrentEntityActions>();

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

        private static Func<T> Resolve(IServiceProvider ioc)
        {
            return ioc.GetService<T>;
        }
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
