namespace App
{

public interface IIdmContentService {}

public class IdmContentService : IIdmContentService
{
	public IdmContentService
	(
		IDocumentManagementService documentManagementService,
		IContentIdmLinkRepository contentIdmLinkRepository,
		IContentValidationService contentValidationService,
		IExceptionDetailRepository exceptionDetailRepository
	)
	{
	}
}

}
