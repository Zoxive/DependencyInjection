namespace App
{

public interface IKeystoneUserService {}

public class KeystoneUserService : IKeystoneUserService
{
	public KeystoneUserService
	(
		IKeystoneUserRepository keystoneUserRepository,
		IKeystoneAdminUnitOfWorkFactory keystoneAdminUnitOfWorkFactory,
		ICurrentUser currentUser,
		KeystoneApplication application
	)
	{
	}
}

}
