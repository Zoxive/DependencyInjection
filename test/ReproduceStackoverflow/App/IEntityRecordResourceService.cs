using System;

namespace App
{

public interface IEntityRecordResourceService {}

public class EntityRecordResourceService : IEntityRecordResourceService
{
	public EntityRecordResourceService
	(
        // This is a circular dependency so its lazy, but even with it commented out the stackoverflow happens, i think its somewhere else
		Lazy<UpdateResource> updateResource,
		IEntityRecordResourceRepository entityRecordResourceRepository
	)
	{
	}
}

}
