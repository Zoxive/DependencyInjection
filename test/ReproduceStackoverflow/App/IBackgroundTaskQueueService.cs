namespace App
{

public interface IBackgroundTaskQueueService {}

public class BackgroundTaskQueueService : IBackgroundTaskQueueService
{
	public BackgroundTaskQueueService
	(
		IBackgroundTaskQueueParamsDtoFactory backgroundTaskQueueParamsDtoFactory
	)
	{
	}
}

}
