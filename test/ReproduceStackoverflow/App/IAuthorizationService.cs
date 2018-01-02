namespace App
{

public interface IAuthorizationService {}

public class AuthorizationService : IAuthorizationService
{
	public AuthorizationService
	(
		KeystoneApplication keystoneApplication,
		ICurrentUser currentUser
	)
	{
	}
}

}
