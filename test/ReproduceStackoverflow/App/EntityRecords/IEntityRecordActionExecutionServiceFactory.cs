namespace ReproduceStackoverflow.App
{
    public interface IEntityRecordActionExecutionServiceFactory
    {
    }

    public class EntityRecordActionExecutionServiceFactory : IEntityRecordActionExecutionServiceFactory
    {
        private readonly IEntityDefinitionRepository _entityDefinitionRepository;
        private readonly IEntityActionRepository _entityActionRepository;
        /*
        private readonly IEntityActionResultBuilder _entityActionResultBuilder;
        private readonly IEntityRecordRepository _entityRecordRepository;
        private readonly IKeystoneSectionVersionRepository _keystoneSectionVersionRepository;
        private readonly ICurrentEntityActions _currentEntityActions;
        */

        public EntityRecordActionExecutionServiceFactory
        (
            IEntityDefinitionRepository entityDefinitionRepository,
            //
            IEntityActionRepository entityActionRepository
            /*
            IEntityActionResultBuilder entityActionResultBuilder,
            IEntityRecordRepository entityRecordRepository,
            IKeystoneSectionVersionRepository keystoneSectionVersionRepository,
            ICurrentEntityActions currentEntityActions
            */
        )

        {
            _entityDefinitionRepository = entityDefinitionRepository;
            _entityActionRepository = entityActionRepository;
            /*
            _entityActionResultBuilder = entityActionResultBuilder;
            _entityRecordRepository = entityRecordRepository;
            _keystoneSectionVersionRepository = keystoneSectionVersionRepository;
            _currentEntityActions = currentEntityActions;
            */
        }
    }
}