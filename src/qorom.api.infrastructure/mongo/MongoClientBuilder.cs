using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace qorom.api.infrastructure.mongo
{
    public class MongoClientBuilder
    {
        private string? connectionString { get; set; }

        public MongoClientBuilder(IConfiguration configuration)
        {
            connectionString = configuration?.GetConnectionString("DefaultConnection");
        }

        public IMongoClient SetupMongoDb()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("qorom");

            var collections = database.ListCollectionNames().ToList();

            if(!collections.Contains("Forums"))
            {
                database.CreateCollection("Forums");
            }
            if (!collections.Contains("Posts"))
            {
                database.CreateCollection("Posts");
            }
            if (!collections.Contains("PostCommentsChronological"))
            {
                database.CreateCollection("PostCommentsChronological");
            }

            return client;
        }
    }
}
