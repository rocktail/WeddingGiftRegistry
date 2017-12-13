using WeddingGiftRegistryApi.Domain.Core.MessageInterfaces;

namespace WeddingGiftRegistryApi.Domain.Core.Events.Gifts
{
    public class GiftWasAdded : IEvent
    {
	    public readonly int Id;
	    public readonly string Name;

	    public GiftWasAdded(int id, string name)
	    {
		    this.Id = id;
		    this.Name = name;
	    }
    }
}
