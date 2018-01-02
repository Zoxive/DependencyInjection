namespace App
{

public interface IKeystoneUserRepository {}

public class KeystoneUserRepository : IKeystoneUserRepository
{
	public KeystoneUserRepository
	(
		IKeystoneUserDao userDao,
		IKeystoneUserDtoFactory userDtoFactory
	)
	{
	}
}

}
