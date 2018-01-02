namespace App
{

public interface IAsyncActionRepository {}

public class AsyncActionRepository : IAsyncActionRepository
{
	public AsyncActionRepository
	(
		IAsyncActionDao asyncActionDao,
		IAsyncActionFactory asyncActionFactory
	)
	{
	}
}

}
