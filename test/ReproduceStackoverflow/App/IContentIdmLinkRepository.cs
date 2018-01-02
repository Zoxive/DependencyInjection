namespace App
{

public interface IContentIdmLinkRepository {}

public class ContentIdmLinkRepository : IContentIdmLinkRepository
{
	public ContentIdmLinkRepository
	(
		IContentIdmLinkDao contentIdmLinkDao,
		IContentIdmLinkFactory contentIdmLinkFactory
	)
	{
	}
}

}
