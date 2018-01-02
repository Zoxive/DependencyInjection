namespace App
{

public interface IEntityActionEventListenerFactory {}

public class EntityActionEventListenerFactory : IEntityActionEventListenerFactory
{
	public EntityActionEventListenerFactory
	(
		IEntityActionEventAggregator entityActionEventAggregator,
		IAsyncActionRecordListener asyncActionRecordListener,
		IAggregateRootModifiedEventListener aggregateRootModifiedEventListener,
		IContentFieldModifiedEventListener contentFieldModifiedEventListener,
		IEntityRecordEventsNormalizer entityRecordEventsNormalizer
	)
	{
	}
}

}
