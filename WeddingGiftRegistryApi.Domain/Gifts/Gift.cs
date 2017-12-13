using System;

namespace WeddingGiftRegistryApi.Domain.Gifts
{
    public class Gift
    {
	    public string Name { get; }

	    protected Gift() { }

	    public Gift(string name)
	    {
		    this.Name = name;
	    }
    }
}
