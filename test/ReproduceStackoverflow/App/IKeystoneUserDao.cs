namespace App
{

public interface IKeystoneUserDao {}

public class KeystoneUserDao : IKeystoneUserDao
{
	public KeystoneUserDao
	(
		IKeystoneAdminDatabase database
	)
	{
	}
}

}
