namespace App
{

public interface IRulesetExecutionContextFactory {}

public class RulesetExecutionContextFactory : IRulesetExecutionContextFactory
{
	public RulesetExecutionContextFactory
	(
		IUserService userService,
		IClientDataFactory clientDataFactory,
		IEntityDefinitionRepository entityDefinitionRepository,
		ICurrentUser currentUser
	)
	{
	}
}

}
