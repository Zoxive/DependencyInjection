namespace App
{

public interface IAsyncActionsService {}

public class AsyncActionsService : IAsyncActionsService
{
	public AsyncActionsService
	(
		IAsyncActionRepository repository
	)
	{
	}
}

}
