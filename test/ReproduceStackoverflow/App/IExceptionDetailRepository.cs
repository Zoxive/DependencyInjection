namespace App
{

public interface IExceptionDetailRepository {}

public class ExceptionDetailRepository : IExceptionDetailRepository
{
	public ExceptionDetailRepository
	(
		IExceptionDetailDao exceptionDetailDao,
		IExceptionDetailMapper exceptionDetailMapper
	)
	{
	}
}

}
