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
            services.AddScoped<IEntityAction, Copy>();
            services.AddScoped<IEntityAction, Create>();
            services.AddScoped<IEntityAction, Delete>();
            services.AddScoped<IEntityAction, Read>();
            services.AddScoped<IEntityAction, ReadAll>();
            services.AddScoped<IEntityAction, ReadAncestors>();
            services.AddScoped<IEntityAction, Update>();
            services.AddScoped<UpdateResource>();
            services.AddScoped<IEntityAction, RulesetEntityAction>();
        }
    }
}
