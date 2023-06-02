using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qorom.api.infrastructure.mongo
{
    public class MongoDbRepositorySetup
    {
        private string? connectionString { get; set; }

        public MongoDbRepositorySetup(IConfiguration configuration)
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
