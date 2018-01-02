namespace App
{

public interface IEntityActionStepProcessor {}

public class EntityActionStepProcessor : IEntityActionStepProcessor
{
	public EntityActionStepProcessor
	(
		IEntityActionResultFactory entityActionResultFactory
	)
	{
	}
}

}
