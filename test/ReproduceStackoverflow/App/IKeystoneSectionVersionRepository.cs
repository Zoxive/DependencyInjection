namespace App
{

public interface IKeystoneSectionVersionRepository {}

public class KeystoneSectionVersionRepository : IKeystoneSectionVersionRepository
{
	public KeystoneSectionVersionRepository
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
