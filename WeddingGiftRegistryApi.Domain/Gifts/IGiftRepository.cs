using System.Threading.Tasks;

namespace WeddingGiftRegistryApi.Domain.Gifts
{
    public interface IGiftRepository
    {
	    Task<int> SaveGift(Gift gift);

    }
}
