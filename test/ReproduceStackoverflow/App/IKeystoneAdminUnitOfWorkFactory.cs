namespace App
{

public interface IKeystoneAdminUnitOfWorkFactory {}

public class KeystoneAdminUnitOfWorkFactory : IKeystoneAdminUnitOfWorkFactory
{
	public KeystoneAdminUnitOfWorkFactory
	(
		IKeystoneAdminDatabase database
	)
	{
	}
}

}
