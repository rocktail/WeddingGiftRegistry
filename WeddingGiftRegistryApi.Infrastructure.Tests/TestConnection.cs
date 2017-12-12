using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;

namespace WeddingGiftRegistryApi.Infrastructure.Tests
{
    [TestClass]
    public class TestConnection
    {
        [TestMethod]
        public void ConnectionToAzureCosmosDbWorks()
        {
	        const string connectionString = @"mongodb://pmisztalwedding:DWynPZBkGFnMjDtW7il2KXWtA6QunA7xpnWplCEV1THAdNOTt6uR3Yy2hLuojd0ppvbGwh3QoSbF6FdpQI5Ebw==@pmisztalwedding.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
	        var settings = MongoClientSettings.FromUrl(
		        new MongoUrl(connectionString)
	        );
	        settings.SslSettings =
		        new SslSettings() { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
	        var client = new MongoClient(settings);

			var db = client.GetDatabase("test");

			Assert.IsNotNull(db);
		}
    }
}
