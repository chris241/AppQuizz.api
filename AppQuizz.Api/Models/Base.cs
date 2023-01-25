using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AppQuizz.Api.Models
{
    public abstract class Base
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
