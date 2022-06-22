using MongoDB.Driver;
using Palavras.AppDbContext;
using Palavras.Models;

namespace Palavras.Repository
{
    public class PalavraRepository : IPalavraRepository
    {

        MongoDbContext db = new MongoDbContext();

        public async Task Add(PalavraModel palavraModel)
        {
            try
            {
                await db.Palavra.InsertOneAsync(palavraModel);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task<PalavraModel> GetPalavraById(string id)
        {
            try
            {
                FilterDefinition<PalavraModel> filter = Builders<PalavraModel>.Filter.Eq("Id", id);
                return await db.Palavra.Find(filter).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<PalavraModel> GetPalavra()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            try
            {
                FilterDefinition<PalavraModel> filter = Builders<PalavraModel>.Filter.Eq("Id", num);
                return await db.Palavra.Find(filter).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<PalavraModel>> GetPalavras()
        {
            try
            {
                return await db.Palavra.Find(_ => true).ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task PostPalavra(string palavra)
        {
            var palavraModel = new PalavraModel();
            palavraModel.Palavra = palavra;

            try
            {
                await db.Palavra.InsertOneAsync(palavraModel);
            }
            catch
            {
                throw;
            }
        }
    }
}
