namespace App
{

public interface IAsyncActionEventsFactory {}

public class AsyncActionEventsFactory : IAsyncActionEventsFactory
{
	public AsyncActionEventsFactory
	(
		IAsyncActionRecordChangeEventFactory asyncActionRecordChangeEventFactory,
		IAsyncActionMessagePublishEventFactory asyncActionMessagePublishEventFactory
	)
	{
	}
}

}
