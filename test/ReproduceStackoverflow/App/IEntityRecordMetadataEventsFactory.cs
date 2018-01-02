namespace App
{

public interface IEntityRecordMetadataEventsFactory {}

public class EntityRecordMetadataEventsFactory : IEntityRecordMetadataEventsFactory
{
	public EntityRecordMetadataEventsFactory
	(
		IEntityDefinitionRepository entityDefinitionRepository,
		IEntityRecordMetadataFactoryFactory entityRecordMetadataFactoryFactory,
		IAuthorizationService authorizationService
	)
	{
	}
}

}
