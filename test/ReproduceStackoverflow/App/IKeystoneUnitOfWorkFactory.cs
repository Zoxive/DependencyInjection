namespace App
{

public interface IKeystoneUnitOfWorkFactory {}

public class KeystoneUnitOfWorkFactory : IKeystoneUnitOfWorkFactory
{
	public KeystoneUnitOfWorkFactory
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
