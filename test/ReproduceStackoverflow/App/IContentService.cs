namespace App
{

public interface IContentService {}

public class ContentService : IContentService
{
	public ContentService
	(
		IContentRepository contentRepository
	)
	{
	}
}

}
