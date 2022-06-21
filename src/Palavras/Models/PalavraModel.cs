using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Palavras.Models
{
    public class PalavraModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Palavra { get; set; }
    }
}
