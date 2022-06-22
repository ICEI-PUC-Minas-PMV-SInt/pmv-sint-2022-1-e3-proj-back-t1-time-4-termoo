using MongoDB.Driver;
using Palavras.Models;

namespace Palavras.AppDbContext
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://palavrasadmin:<password>@cluster0.11m3df2.mongodb.net/?retryWrites=true&w=majority");
            _mongoDb = client.GetDatabase("Cluster0");
        }
        public IMongoCollection<PalavraModel> Palavra
        {
            get
            {
                return _mongoDb.GetCollection<PalavraModel>("PalavraModel");
            }
        }
    }
}
