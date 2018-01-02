using System;

namespace App
{

public interface IEntityRecordResourceService {}

public class EntityRecordResourceService : IEntityRecordResourceService
{
	public EntityRecordResourceService
	(
		Lazy<UpdateResource> updateResource,
		IEntityRecordResourceRepository entityRecordResourceRepository
	)
	{
	}
}

}
