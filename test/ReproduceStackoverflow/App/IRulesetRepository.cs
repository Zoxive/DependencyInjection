namespace App
{

public interface IRulesetRepository {}

public class CachedRulesetRepository : IRulesetRepository
{
	public CachedRulesetRepository
	(
        IRulesetDao rulesetDao
	)
	{
	}
}

    public interface IRulesetDao
    {
    }

    public class RulesetDao : IRulesetDao
    {
    }
}
