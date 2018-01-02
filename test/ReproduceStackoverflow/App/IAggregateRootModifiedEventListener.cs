namespace App
{

public interface IAggregateRootModifiedEventListener {}

public class AggregateRootModifiedEventListener : IAggregateRootModifiedEventListener
{
	public AggregateRootModifiedEventListener
	(
		IEntityRecordService entityRecordService,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository
	)
	{
	}
}

}
