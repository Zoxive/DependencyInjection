namespace App
{

public interface IUserRepository {}

public class UserRepository : IUserRepository
{
	public UserRepository
	(
		IUserDao userDao,
		IUserFactory userFactory
	)
	{
	}
}

}
