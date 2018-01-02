namespace App
{

public interface IBackgroundTaskCurrentUserProxyFactory {}

public class BackgroundTaskCurrentUserProxyFactory : IBackgroundTaskCurrentUserProxyFactory
{
	public BackgroundTaskCurrentUserProxyFactory
	(
		ICurrentUser currentUser
	)
	{
	}
}

}
