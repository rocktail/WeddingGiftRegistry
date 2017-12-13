using System.Threading.Tasks;

namespace WeddingGiftRegistryApi.Domain.Core.MessageInterfaces
{
	// ReSharper disable once InconsistentNaming
    public interface Handles<T> where T : IMessage
    {
	    Task Handle(T messsage);
    }
}
