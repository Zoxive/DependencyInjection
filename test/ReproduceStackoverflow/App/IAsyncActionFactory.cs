namespace App
{

public interface IAsyncActionFactory {}

public class AsyncActionFactory : IAsyncActionFactory
{
	public AsyncActionFactory
	(
		IAsyncActionEventsFactory asyncActionEventsFactory
	)
	{
	}
}

}
