using System;
using System.IO;
using System.Linq;
using Autofac;
using Autofac.Core;
using WeddingGiftRegistryApi.Common;

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

	    public static void Configure(string binDirectory,
		    Action<ContainerBuilder> additionalConfig = null,
		    Func<ILifetimeScope> externalScopeDiscoveryParam = null
	    )
	    {
		    if (container != null)
		    {
			    throw new InvalidOperationException("IoC already configured");
		    }

		    foreach (var filePath in Directory.GetFiles(binDirectory, "*.dll"))
		    {
			    AppDomain.CurrentDomain.Load(Path.GetFileNameWithoutExtension(filePath));
		    }

		    var builder = new ContainerBuilder();
		    builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAppAssemblies())
			    .AsImplementedInterfaces()
			    .AsSelf();

		    foreach (var moduleType in AppDomain.CurrentDomain.GetAppTypes()
			    .Where(x => x.AssignableTo<IModule>() && x.CanBeInstantiated())
		    )
		    {
			    var instance = Activator.CreateInstance(moduleType) as IModule;
			    builder.RegisterModule(instance);
		    }

		    additionalConfig?.Invoke(builder);

		    externalScopeDiscovery = externalScopeDiscoveryParam;

		    container = builder.Build();
	    }
	}
}
