namespace App
{

public interface IContentDao {}

public class ContentDao : IContentDao
{
	public ContentDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
