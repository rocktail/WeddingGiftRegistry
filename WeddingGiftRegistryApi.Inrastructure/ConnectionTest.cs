using System;
using System.Collections.Generic;
using System.Text;

namespace WeddingGiftRegistryApi.Infrastructure
{
	class ConnectionTest
	{
		public void Test()
		{
			string connectionString =
	  @"mongodb://pmisztalwedding:DWynPZBkGFnMjDtW7il2KXWtA6QunA7xpnWplCEV1THAdNOTt6uR3Yy2hLuojd0ppvbGwh3QoSbF6FdpQI5Ebw==@pmisztalwedding.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
			var settings = MongoDB.Driver.MongoClientSettings.FromUrl(
			  new MongoDB.Driver.MongoUrl(connectionString)
			);
			settings.SslSettings =
	  new MongoDB.Driver.SslSettings() { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
			var mongoClient = new MongoDB.Driver.MongoClient(settings);

			var client = new MongoDB.Driver.MongoClient();
		}
	}
}
