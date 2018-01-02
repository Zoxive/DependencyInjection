namespace App
{

public interface IContentFacade {}

public class ContentFacade : IContentFacade
{
	public ContentFacade
	(
		IContentService contentService,
		IIdmContentService idmContentService,
		IIdmDocumentFactory idmDocumentFactory
	)
	{
	}
}

}
