namespace App
{

public interface ILocaleDao {}

public class LocaleDao : ILocaleDao
{
	public LocaleDao
	(
		IKeystoneApplicationDatabase database,
		IKeystoneApplicationTableCacherFactory cacherFactory
	)
	{
	}
}

}
