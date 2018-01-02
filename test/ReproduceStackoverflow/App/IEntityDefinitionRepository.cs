namespace App
{

public interface IEntityDefinitionRepository {}

public class EntityDefinitionRepository : IEntityDefinitionRepository
{
	public EntityDefinitionRepository
	(
		IPublishedEntityDefinitionDao publishedEntityDefinitionDao
	)
	{
	}
}

}
