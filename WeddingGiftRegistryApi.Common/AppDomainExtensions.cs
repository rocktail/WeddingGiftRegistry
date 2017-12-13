using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WeddingGiftRegistryApi.Common
{
    public static class AppDomainExtensions
    {
	    public static Assembly[] GetAppAssemblies(this AppDomain @this)
	    {
		    return @this.GetAssemblies()
			    .Where(x => x.FullName.StartsWith("WeddingGiftRegistryApi."))
			    .ToArray();
	    }

	    public static IEnumerable<Type> GetAppTypes(this AppDomain @this)
	    {
		    return @this.GetAssemblies()
			    .Where(x => x.FullName.StartsWith("WeddingGiftRegistryApi."))
			    .SelectMany(x => x.GetTypes());
	    }
	}
}
