namespace App
{

public interface IEntityRecordDefaultValuesGenerator {}

public class EntityRecordDefaultValuesGenerator : IEntityRecordDefaultValuesGenerator
{
	public EntityRecordDefaultValuesGenerator
	(
		IAuthorizedEntityRecordService entityRecordService,
		IODataSearchParametersFactory searchParametersFactory
	)
	{
	}
}

}
