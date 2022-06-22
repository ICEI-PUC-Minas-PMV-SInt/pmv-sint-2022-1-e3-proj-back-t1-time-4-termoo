using Palavras.Models;

namespace Palavras.Repository
{
    public interface IPalavraRepository
    {
        Task<PalavraModel> GetPalavra();
        Task PostPalavra(string palavra);
    }
}
