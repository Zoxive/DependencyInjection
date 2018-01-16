namespace App
{

public interface IEntityRecordActionExecutionServiceFactory {}

public class EntityRecordActionExecutionServiceFactory : IEntityRecordActionExecutionServiceFactory
{
	public EntityRecordActionExecutionServiceFactory
	(
		IEntityDefinitionRepository entityDefinitionRepository,
		IEntityActionRepository entityActionRepository,
		IEntityActionResultBuilder entityActionResultBuilder,
		IEntityRecordRepository entityRecordRepository,
		IKeystoneSectionVersionRepository keystoneSectionVersionRepository,
        IEntityActionsFactory entityActionsFactory
	)
	{
	}
}
}
