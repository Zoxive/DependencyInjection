namespace App
{

public interface IManyToManySelectBuilder {}

public class ManyToManySelectBuilder : IManyToManySelectBuilder
{
	public ManyToManySelectBuilder
	(
		IKeystoneApplicationDatabase database,
		IODataQueryBuilder oDataQueryBuilder
	)
	{
	}
}

}
