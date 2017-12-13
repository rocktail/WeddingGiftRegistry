using WeddingGiftRegistryApi.Domain.Core.MessageInterfaces;

namespace WeddingGiftRegistryApi.Domain.Core.Commands.Gifts
{
    public class AddGiftCommand : ICommand
    {
	    public readonly string Name;

	    public AddGiftCommand(string name)
	    {
		    this.Name = name;
	    }
    }
}
