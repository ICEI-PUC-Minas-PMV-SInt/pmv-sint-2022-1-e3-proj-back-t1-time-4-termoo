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
                await db.
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Task<PalavraModel> GetPalavra()
        {
            throw new NotImplementedException();
        }
    }
}
