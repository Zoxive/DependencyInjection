namespace App
{

public interface IConnectionFactory {}

public class AuthorizedConnectionFactory : IConnectionFactory
{
	public AuthorizedConnectionFactory
	(
		ICurrentUser currentUser
	)
	{
	}
}

}
