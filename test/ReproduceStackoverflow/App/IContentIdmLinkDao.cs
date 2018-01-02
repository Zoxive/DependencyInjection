namespace App
{

public interface IContentIdmLinkDao {}

public class ContentIdmLinkDao : IContentIdmLinkDao
{
	public ContentIdmLinkDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
