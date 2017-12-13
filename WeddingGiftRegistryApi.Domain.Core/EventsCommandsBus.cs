using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeddingGiftRegistryApi.Domain.Core.MessageInterfaces;
using WeddingGiftRegistryApi.Infrastructure.IoC;

namespace WeddingGiftRegistryApi.Domain.Core
{
    public class EventsCommandsBus : ICommandSender, IEventPublisher
    {
	    public void Send<T>(T command) where T : ICommand
	    {
		    throw new NotImplementedException();
	    }

	    public void Publish<T>(T @event) where T : IEvent
	    {
		    //var handlers = IoC.Container.Resolve<IEnumerable<Handles<T>>>()
			//    .ToList();

		    //Parallel.ForEach(handlers, h => h.Handle(@event));
		}
    }
}
