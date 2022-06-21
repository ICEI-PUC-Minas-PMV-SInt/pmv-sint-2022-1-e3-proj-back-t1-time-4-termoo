using MongoDB.Driver;
using Palavras.Models;

namespace Palavras.AppDbContext
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://sarathlal:<password>@sarathlal-6k9bj.azure.mongodb.net?retryWrites=true");
            _mongoDb = client.GetDatabase("SarathDB");
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
