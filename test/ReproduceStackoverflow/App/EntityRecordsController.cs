using Microsoft.Extensions.DependencyInjection;

namespace ReproduceStackoverflow.App
{
    public class EntityRecordsController
    {
        private readonly IETagCache _eTagCache;
        private readonly IEntityRecordActionExecutionServiceFactory _entityRecordActionExecutionServiceFactory;
        private readonly IKeystoneEntityNameResolver _entityNameResolver;

        public EntityRecordsController
        (
            IETagCache eTagCache, 
            IEntityRecordActionExecutionServiceFactory entityRecordActionExecutionServiceFactory,
            IKeystoneEntityNameResolver entityNameResolver
        )
        {
            _eTagCache = eTagCache;
            _entityRecordActionExecutionServiceFactory = entityRecordActionExecutionServiceFactory;
            _entityNameResolver = entityNameResolver;
        }
    }

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services.AddScoped<EntityRecordsController>();
            services.AddSingleton<IETagCache, ETagCache>();

            return services;
        }
    }

    public interface IETagCache
    {
    }

    public class ETagCache : IETagCache
    {
    }
}
