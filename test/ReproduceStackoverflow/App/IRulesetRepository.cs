namespace App
{

public interface IRulesetRepository {}

public class CachedRulesetRepository : IRulesetRepository
{
	public CachedRulesetRepository
	(
		IRulesetRepository rulesetRepository,
		IKeystoneApplicationRowCacherFactory cacheFactory
	)
	{
	}
}

}
