namespace App
{

public interface IBackgroundTaskQueueParamsDtoFactory {}

public class BackgroundTaskQueueParamsDtoFactory : IBackgroundTaskQueueParamsDtoFactory
{
	public BackgroundTaskQueueParamsDtoFactory
	(
		KeystoneApplication keystoneApplication,
		IConfigurationManagerAppSettingsRepository configurationManagerAppSettingsRepository,
		IBackgroundTaskCurrentUserProxyFactory backgroundTaskCurrentUserProxyFactory
	)
	{
	}
}

}
