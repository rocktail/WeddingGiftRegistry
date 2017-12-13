using System.Threading.Tasks;
using MongoDB.Bson;
using WeddingGiftRegistryApi.Domain.Gifts;

namespace WeddingGiftRegistryApi.Infrastructure.Db
{
    public class DatabaseAccessService : IGiftRepository
    {
	    private const string ConnectionString = @"mongodb://pmisztalwedding:DWynPZBkGFnMjDtW7il2KXWtA6QunA7xpnWplCEV1THAdNOTt6uR3Yy2hLuojd0ppvbGwh3QoSbF6FdpQI5Ebw==@pmisztalwedding.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
	    private const string CollectionName = "gifts";
	    private const string DatabaseName = "pmisztalwedding";

	    public async Task<int> SaveGift(Gift gift)
	    {
		    var giftDocument = new BsonDocument
		    {
				{"name", BsonValue.Create(gift.Name)}
		    };

		    var settings = MongoDB.Driver.MongoClientSettings.FromUrl(
			    new MongoDB.Driver.MongoUrl(ConnectionString)
		    );
		    settings.SslSettings =
			    new MongoDB.Driver.SslSettings() { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
		    var mongoClient = new MongoDB.Driver.MongoClient(settings);

		    var mongoDb = mongoClient.GetDatabase(DatabaseName);

			var collection = mongoDb.GetCollection<BsonDocument>(CollectionName);

			return await Task.Run(() =>
				{
					var result = collection.InsertOneAsync(giftDocument);

					return result.Id;
				}
			);
	    }
	}
}
