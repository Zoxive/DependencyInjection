namespace App
{

public interface ICurrentEntityDefinitionAccessor {}

public class CurrentEntityDefinitionAccessor : ICurrentEntityDefinitionAccessor
{
	public CurrentEntityDefinitionAccessor
	(
		IKeystoneEntityNameResolver keystoneEntityNameResolver,
		IEntityDefinitionRepository entityDefinitionRepository
	)
	{
	}
}

}
