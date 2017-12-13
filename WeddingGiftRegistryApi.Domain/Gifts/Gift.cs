using System;

namespace WeddingGiftRegistryApi.Domain.Gifts
{
    public class Gift
    {
	    private string name;

		protected Gift() { }

	    public Gift(string name)
	    {
		    this.name = name;
	    }
    }
}
