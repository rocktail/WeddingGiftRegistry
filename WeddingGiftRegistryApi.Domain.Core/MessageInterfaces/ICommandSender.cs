﻿namespace WeddingGiftRegistryApi.Domain.Core.MessageInterfaces
{
	public interface ICommandSender
	{
		void Send<T>(T command) where T : ICommand;
	}
}
