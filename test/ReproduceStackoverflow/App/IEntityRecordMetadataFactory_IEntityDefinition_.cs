namespace App
{

    public interface IEntityRecordMetadataFactory<TEntity> {}

    public class ManyToManyMetadataFactory : IEntityRecordMetadataFactory<IManyToManyEntityDefinition>
    {
    }

    public interface IManyToManyEntityDefinition
    {
    }

    public class ManyToManyEntityDefinition : IManyToManyEntityDefinition
    {
    }

    public class UnionMetadataFactory : IEntityRecordMetadataFactory<IUnionEntityDefinition>
    {
    }

    public interface IUnionEntityDefinition
    {
    }

    public class UnionEntityDefinition : IUnionEntityDefinition
    {
    }

    public class EntityRecordMetadataFactory : IEntityRecordMetadataFactory<IEntityDefinition>
    {
        public EntityRecordMetadataFactory
        (
            ILinkFactory linkFactory,
            IAuthorizationService authorizationService,
            IEntityDefinitionRepository entityDefinitionRepository
        )
        {
        }
    }

    public interface IEntityDefinition
    {
    }

    public class EntityDefinition : IEntityDefinition {}
}
