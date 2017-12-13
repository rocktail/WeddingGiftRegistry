using System;
using System.Collections.Generic;
using System.Text;
using WeddingGiftRegistryApi.Domain.Core.Commands.Gifts;
using WeddingGiftRegistryApi.Domain.Core.MessageInterfaces;

namespace WeddingGiftRegistryApi.Domain.Gifts
{
    public class AddGiftHandler : Handles<AddGiftCommand>
    {
	    private readonly IEventPublisher eventPublisher;

	    public AddGiftHandler(IEventPublisher eventPublisher)
	    {
		    this.eventPublisher = eventPublisher;
	    }

	    public void Handle(AddGiftCommand messsage)
	    {
		    var gift = new Gift(messsage.Name);
			//var newGiftId = 
	    }
    }
}
