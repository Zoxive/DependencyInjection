namespace App
{

public interface IPublishedEntityDefinitionDao {}

public class PublishedEntityDefinitionDao : IPublishedEntityDefinitionDao
{
	public PublishedEntityDefinitionDao
	(
		IKeystoneApplicationDatabase database,
		IEntityDefinitionXmlSerializer serializer,
		IKeystoneApplicationTableCacherFactory cacherFactory
	)
	{
	}
}

}
