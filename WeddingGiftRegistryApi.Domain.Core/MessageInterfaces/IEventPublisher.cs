namespace WeddingGiftRegistryApi.Domain.Core.MessageInterfaces
{
    public interface IEventPublisher
    {
	    void Publish<T>(T @event) where T : IEvent;
    }
}
