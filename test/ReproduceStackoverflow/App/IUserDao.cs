namespace App
{

public interface IUserDao {}

public class UserDao : IUserDao
{
	public UserDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
