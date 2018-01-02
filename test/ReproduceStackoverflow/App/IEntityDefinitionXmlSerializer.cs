namespace App
{

public interface IEntityDefinitionXmlSerializer {}

public class EntityDefinitionXmlSerializer : IEntityDefinitionXmlSerializer
{
	public EntityDefinitionXmlSerializer
	(
		IEntityFieldXmlSerializer entityFieldXmlSerializer
	)
	{
	}
}

}
