using System;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using ReproduceStackoverflow.App;
using ReproduceStackoverflow.App.MultiTenant;

namespace ReproduceStackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddMultiTenancy()
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
