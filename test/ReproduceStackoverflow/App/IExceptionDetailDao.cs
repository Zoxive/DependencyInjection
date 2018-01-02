namespace App
{

public interface IExceptionDetailDao {}

public class ExceptionDetailDao : IExceptionDetailDao
{
	public ExceptionDetailDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
