namespace App
{

public interface IEntityActionResultBuilder {}

public class EntityActionResultBuilder : IEntityActionResultBuilder
{
	public EntityActionResultBuilder
	(
		IEntityActionEventListenerFactory entityActionEventListenerFactory,
		IAsyncActionsService asyncActionsService,
		IEntityRecordMetadataEventsFactory entityMetadataEventsFactory
	)
	{
	}
}

}
