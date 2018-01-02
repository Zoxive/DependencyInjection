namespace App
{

public interface IAsyncActionRecordListener {}

public class AsyncActionRecordListener : IAsyncActionRecordListener
{
	public AsyncActionRecordListener
	(
		IAsyncActionsService asyncActionsService
	)
	{
	}
}

}
