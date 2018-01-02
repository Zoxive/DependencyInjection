namespace App
{

public interface ILinkFactory {}

public class LinkFactory : ILinkFactory
{
	public LinkFactory
	(
		IEntityUrlHelper entityUrlHelper,
		IAuthorizationService authorizationService,
		IEntityDefinitionRepository entityDefinitionRepository,
		ILinkRelationActionService linkRelationActionService
	)
	{
	}
}

}
