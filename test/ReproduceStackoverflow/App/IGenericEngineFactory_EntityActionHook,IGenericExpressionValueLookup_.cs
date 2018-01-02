using System;

namespace App
{

public interface IGenericEngineFactory<THook,TValueLookup> {}

public class AuthenticatedEngineFactory<TSpec, T> : IGenericEngineFactory<TSpec, T>
{
	public AuthenticatedEngineFactory
	(
		ICurrentUser currentUser,
		IServiceProvider serviceProvider
	)
	{
	}
}

}
