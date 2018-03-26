using System;
using System.Collections.Generic;
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

                    // Force ILEmit or Expressions to get stackoverflow right away
                    Mode = ServiceProviderMode.ILEmit
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
                    //var overflow = scope.ServiceProvider.GetRequiredService<IEntityRecordActionExecutionServiceFactory>();

                    // I Think ICurrentEntityActions is the problem child. If we go straght to that instead of IEntityRecordActionExecutionServiceFactory we get a different error
                    // System.InvalidProgramException: 'Common Language Runtime detected an invalid program.'

                    //var more = scope.ServiceProvider.GetRequiredService<ICurrentEntityActions>();
                    //var t = scope.ServiceProvider.GetRequiredService<IEnumerable<IEntityAction>>();

                    //var tt = scope.ServiceProvider.GetRequiredService<Copy>();
                    //var tt = scope.ServiceProvider.GetRequiredService<IReadStep>();

                    // new flow
                    //var t = scope.ServiceProvider.GetRequiredService<ValidateStep>();
                    var t = scope.ServiceProvider.GetRequiredService<IEntityRecordValidator>();

                    // Works
                    //var t = scope.ServiceProvider.GetRequiredService<IEntityFieldValidationService>();

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
