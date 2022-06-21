using Palavras.Models;

namespace Palavras.Repository
{
    public interface IPalavraRepository
    {
        Task<PalavraModel> GetPalavra();
    }
}
