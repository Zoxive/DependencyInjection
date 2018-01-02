namespace App
{

public interface IUserService {}

public class UserService : IUserService
{
	public UserService
	(
		ICurrentUser currentUser,
		IUserRepository userRepository
	)
	{
	}
}

}
