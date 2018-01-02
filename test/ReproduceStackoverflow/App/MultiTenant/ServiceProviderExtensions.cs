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

            scopeContext.SetTenant(tenant);

            return scope;
        }

        private static readonly string Tenant = nameof(Tenant);
        private static IScopeContext SetTenant(this IScopeContext context, ITenant tenant)
        {
            context.Items[Tenant] = tenant;

            return context;
        }


        private static ITenant GetTenant(this IScopeContext context)
        {
            if (context.Items.TryGetValue(Tenant, out var tenantObj))
            {
                return tenantObj as ITenant;
            }

            return null;
        }

        public static IServiceCollection AddMultiTenancy(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<IScopeContext, ScopeContext>();

            services.AddScoped<ITenant>(ioc => ioc.GetRequiredService<IScopeContext>().GetTenant());

            return services;
        }
    }
}
