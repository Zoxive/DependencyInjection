namespace App
{

public interface IEntityRecordMetadataFactoryFactory {}

public class EntityRecordMetadataFactoryFactory : IEntityRecordMetadataFactoryFactory
{
	public EntityRecordMetadataFactoryFactory
	(
		IEntityRecordMetadataFactory<IEntityDefinition> defaultFactory,
		IEntityRecordMetadataFactory<IManyToManyEntityDefinition> manyEntityRecordMetadataFactory,
		IEntityRecordMetadataFactory<IUnionEntityDefinition> unionEntityRecordMetadataFactory
	)
	{
	}
}

}
