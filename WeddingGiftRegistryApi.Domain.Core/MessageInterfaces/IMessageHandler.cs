namespace WeddingGiftRegistryApi.Domain.Core.MessageInterfaces
{
	// ReSharper disable once InconsistentNaming
    public interface Handles<T> where T : IMessage
    {
	    void Handle(T messsage);
    }
}
