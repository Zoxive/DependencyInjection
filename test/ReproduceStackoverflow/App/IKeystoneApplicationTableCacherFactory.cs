namespace App
{

public interface IKeystoneApplicationTableCacherFactory {}

public class KeystoneApplicationTableCacherFactory : IKeystoneApplicationTableCacherFactory
{
	public KeystoneApplicationTableCacherFactory
	(
		IPerKeystoneApplicationCacheManager cacheManager,
		IKeystoneApplicationDatabase database,
		IKeystoneUnitOfWorkFactory unitOfWorkFactory
	)
	{
	}
}

}
