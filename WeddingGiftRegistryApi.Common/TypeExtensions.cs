using System;
using System.Collections.Generic;
using System.Text;

namespace WeddingGiftRegistryApi.Common
{
    public static class TypeExtensions
    {
	    public static bool AssignableTo(this Type @this, Type other)
	    {
		    return other.IsAssignableFrom(@this);
	    }

		public static bool AssignableTo<T>(this Type @this)
	    {
		    return @this.AssignableTo(typeof(T));
	    }

	    public static bool CanBeInstantiated(this Type @this)
	    {
		    return @this.IsClass && !@this.IsAbstract;
	    }
	}
}
