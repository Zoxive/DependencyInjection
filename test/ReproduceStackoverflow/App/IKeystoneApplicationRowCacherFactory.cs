namespace App
{

public interface IKeystoneApplicationRowCacherFactory {}

public class KeystoneApplicationRowCacherFactory : IKeystoneApplicationRowCacherFactory
{
	public KeystoneApplicationRowCacherFactory
	(
		IKeystoneApplicationDatabase database,
		IPerKeystoneApplicationCacheManager cacheManager,
		IKeystoneUnitOfWorkFactory unitOfWorkFactory
	)
	{
	}
}

}
