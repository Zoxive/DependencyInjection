namespace App
{

public interface IDocumentManagementService {}

public class DocumentManagementService : IDocumentManagementService
{
	public DocumentManagementService
	(
		IDocumentManagementApi documentManagementApi
	)
	{
	}
}

}
