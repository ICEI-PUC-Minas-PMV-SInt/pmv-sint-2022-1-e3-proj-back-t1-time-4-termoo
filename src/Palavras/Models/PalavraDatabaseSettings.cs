namespace Palavras.Models
{
    public class PalavraDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string PalavrasCollectionName { get; set; } = null!;
    }
}
