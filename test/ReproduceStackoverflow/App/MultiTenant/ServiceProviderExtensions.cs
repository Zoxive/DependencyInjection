using System;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace ReproduceStackoverflow.App.MultiTenant
{
    public static class ServiceProviderExtensions
    {
        public static IServiceScope CreateTenantScope(this IServiceProvider serviceProvider, ITenant tenant)
        {
            var scope = serviceProvider.CreateScope();

            var scopeContext = scope.ServiceProvider.GetRequiredService<IScopeContext>();

            return scope;
        }

        public static IServiceCollection AddMultiTenancy(this IServiceCollection services)
        {
            services.AddScoped<IScopeContext, ScopeContext>();

            return services;
        }
    }
}
