namespace App
{

public interface IEntityActionResultFactory {}

public class EntityActionResultFactory : IEntityActionResultFactory
{
	public EntityActionResultFactory
	(
		IAggregateRootModifiedRepository aggregateRootModifiedRepository
	)
	{
	}
}

}
