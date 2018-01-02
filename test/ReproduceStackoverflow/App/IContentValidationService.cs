namespace App
{

public interface IContentValidationService {}

public class ContentValidationService : IContentValidationService
{
	public ContentValidationService
	(
		IContentRepository contentRepository,
		IContentIdmLinkRepository contentIdmLinkRepository
	)
	{
	}
}

}
