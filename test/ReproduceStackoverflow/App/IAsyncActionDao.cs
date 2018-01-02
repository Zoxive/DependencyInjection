namespace App
{

public interface IAsyncActionDao {}

public class AsyncActionDao : IAsyncActionDao
{
	public AsyncActionDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
