namespace App
{

public interface IEntityActionEventListener {}

public class EntityActionEventListener : IEntityActionEventListener
{
	public EntityActionEventListener
	(
		IEntityActionEventAggregator entityActionEventAggregator,
		IAsyncActionRecordListener asyncActionListener,
		IAggregateRootModifiedEventListener aggregateRootModifiedEventListener,
		IContentFieldModifiedEventListener contentFieldModifiedEventListener,
		IEntityRecordEventsNormalizer entityRecordEventsNormalizer
	)
	{
	}
}

}
