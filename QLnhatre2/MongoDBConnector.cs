using MongoDB.Driver;
using System;

namespace YourNamespace
{
    public class MongoDBConnector
    {
        private IMongoDatabase database;

        public MongoDBConnector(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return database.GetCollection<T>(collectionName);
        }
    }
}