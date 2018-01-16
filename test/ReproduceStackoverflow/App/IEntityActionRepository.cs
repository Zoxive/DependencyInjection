namespace App
{

public interface IEntityActionRepository {}

public class EntityActionRepository : IEntityActionRepository
{
	public EntityActionRepository
	(
		IAuthorizationService authorizationService,
        IEntityActionsFactory entityActionsFactory
	)
	{
	}
}

}
