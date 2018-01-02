namespace App
{

public interface IContentFieldModifiedEventListener {}

public class ContentFieldModifiedEventListener : IContentFieldModifiedEventListener
{
	public ContentFieldModifiedEventListener
	(
		IContentRepository contentRepository
	)
	{
	}
}

}
