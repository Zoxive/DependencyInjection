namespace App
{

public interface IEntityRecordServiceImplFactory {}

public class EntityRecordServiceImplFactory : IEntityRecordServiceImplFactory
{
	public EntityRecordServiceImplFactory
	(
		IEntityRecordServiceImpl entityRecordServiceImpl,
		IManyToManyEntityRecordServiceImpl manyEntityRecordServiceImpl,
		ICompositeEntityRecordServiceImpl compositeEntityRecordServiceImpl,
		IUnionEntityRecordServiceImpl unionEntityRecordServiceImpl
	)
	{
	}
}

}
