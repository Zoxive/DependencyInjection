namespace App
{

public interface IContentRepository {}

public class ContentRepository : IContentRepository
{
	public ContentRepository
	(
		IContentDao contentDao,
		IContentFactory contentFactory,
		IContentHeaderFactory contentHeaderFactory,
		IContentEntityLinkFactory contentEntityLinkFactory
	)
	{
	}
}

}
