namespace ReproduceStackoverflow.App
{
    public interface IEntityDefinitionRepository
    {
    }

    public class EntityDefinitionRepository : IEntityDefinitionRepository
    {
        private readonly IPublishedEntityDefinitionDao _publishedEntityDefinitionDao;

        public EntityDefinitionRepository(IPublishedEntityDefinitionDao publishedEntityDefinitionDao)
        {
            _publishedEntityDefinitionDao = publishedEntityDefinitionDao;
        }
    }

    public interface IPublishedEntityDefinitionDao
    {
    }

    public class PublishedEntityDefinitionDao : IPublishedEntityDefinitionDao
    {
        private readonly IKeystoneApplicationDatabase _database;

        public PublishedEntityDefinitionDao(IKeystoneApplicationDatabase database)
        {
            _database = database;
        }
    }
}