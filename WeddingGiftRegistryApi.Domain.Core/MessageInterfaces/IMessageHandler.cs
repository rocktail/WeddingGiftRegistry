namespace WeddingGiftRegistryApi.Domain.Core.MessageInterfaces
{
    public interface IHandles<T> where T : IMessage
    {
	    void Handle(T messsage);
    }
}
