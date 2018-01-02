using Microsoft.Extensions.DependencyInjection;

namespace ReproduceStackoverflow.App.EntityRecords
{
    public static class IOC
    {
        public static IServiceCollection AddEntity(this IServiceCollection services)
        {
            services.AddScoped<IDataSource, DataSource>();
            services.AddScoped<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IKeystoneApplicationDatabase, KeystoneApplicationDatabase>();
            services.AddScoped<IPublishedEntityDefinitionDao, PublishedEntityDefinitionDao>();
            services.AddScoped<IEntityDefinitionRepository, EntityDefinitionRepository>();
            services.AddScoped<IKeystoneEntityNameResolver, KeystoneEntityNameResolver>();

            services.AddScoped<IEntityRecordActionExecutionServiceFactory, EntityRecordActionExecutionServiceFactory>();


            services.AddScoped<IEntityActionRepository, EntityActionRepository>();
            services.AddScoped<IAuthorizedService, AuthorizedService>();

            AddActions(services);

            return services;
        }

        private static void AddActions(IServiceCollection services)
        {
            unity.AddScoped<IEntityAction, Copy>();
            unity.AddScoped<IEntityAction, Create>();
            unity.AddScoped<IEntityAction, Delete>();
            unity.AddScoped<IEntityAction, Read>();
            unity.AddScoped<IEntityAction, ReadAll>();
            unity.AddScoped<IEntityAction, ReadAncestors>();
            unity.AddScoped<IEntityAction, Update>();
            unity.AddScoped<UpdateResource>();
            unity.AddScoped<IEntityAction, RulesetEntityAction>();
        }
    }
}
