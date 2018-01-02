namespace App
{

public interface IEntityUrlHelper {}

public class EntityUrlHelper : IEntityUrlHelper
{
	public EntityUrlHelper
	(
		IKeystoneApplicationNameResolver applicationNameResolver,
		IHttpContextAccessor httpContextAccessor
	)
	{
	}
}

}
