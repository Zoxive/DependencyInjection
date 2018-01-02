namespace App
{

public interface IEntityActionRepository {}

public class EntityActionRepository : IEntityActionRepository
{
	public EntityActionRepository
	(
		ICurrentEntityActions currentEntityActions,
		IAuthorizationService authorizationService
	)
	{
	}
}

}
