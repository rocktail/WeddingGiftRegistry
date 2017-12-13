using System;
using Autofac;

namespace WeddingGiftRegistryApi.Infrastructure.IoC
{
    public class IoC
    {
	    private static ILifetimeScope container;

	    private static Func<ILifetimeScope> externalScopeDiscovery;

	    /// <summary>
	    /// Returns <see cref="ILifetimeScope"/> applicable to current context.
	    /// </summary>
	    public static ILifetimeScope Container
	    {
		    get
		    {
			    ILifetimeScope externalScope = null;

			    if (externalScopeDiscovery != null)
			    {
				    externalScope = externalScopeDiscovery();
			    }

			    return externalScope ?? container;
		    }
	    }
	}
}
