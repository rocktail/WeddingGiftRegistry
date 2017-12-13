using System.Threading.Tasks;
using WeddingGiftRegistryApi.Domain.Core.Commands.Gifts;
using WeddingGiftRegistryApi.Domain.Core.Events.Gifts;
using WeddingGiftRegistryApi.Domain.Core.MessageInterfaces;

namespace WeddingGiftRegistryApi.Domain.Gifts
{
    public class AddGiftHandler : Handles<AddGiftCommand>
    {
	    private readonly IEventPublisher eventPublisher;
	    private readonly IGiftRepository giftRepository;

	    public AddGiftHandler(IEventPublisher eventPublisher,
			IGiftRepository giftRepository)
	    {
		    this.eventPublisher = eventPublisher;
		    this.giftRepository = giftRepository;
	    }

	    public async Task Handle(AddGiftCommand messsage)
	    {
		    var gift = new Gift(messsage.Name);
		    var newGiftId = await this.giftRepository.SaveGift(gift);

			this.eventPublisher.Publish(new GiftWasAdded(newGiftId, gift.Name));
	    }
    }
}
