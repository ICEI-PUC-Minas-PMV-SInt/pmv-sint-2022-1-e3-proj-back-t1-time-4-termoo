using MongoDB.Driver;
using Palavras.Models;
using Microsoft.Extensions.Options;

namespace Palavras.AppDbContext
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://palavrasadmin:BFpqYTZ9cTZDC6bZ@cluster0.11m3df2.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            _mongoDb = client.GetDatabase("Palavras");
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
