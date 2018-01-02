namespace App
{

public interface IAuthorizedEntityRecordService {}

public class AuthorizedEntityRecordService : IAuthorizedEntityRecordService
{
	public AuthorizedEntityRecordService
	(
		EntityRecordService entityRecordService,
		IAuthorizationService authorizationService
	)
	{
	}
}

}
