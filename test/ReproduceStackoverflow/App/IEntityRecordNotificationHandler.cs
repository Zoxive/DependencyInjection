namespace App
{

public interface IEntityRecordNotificationHandler {}

public class EntityRecordNotificationHandler : IEntityRecordNotificationHandler
{
	public EntityRecordNotificationHandler
	(
		IEntityActionEventAggregator eventAggregator
	)
	{
	}
}

}
