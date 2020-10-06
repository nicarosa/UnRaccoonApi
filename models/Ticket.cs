using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UnRaccoonApi.Models
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("User")]
        public string UserName { get; set; }

        public string Section { get; set; }

        public string Issue { get; set; }

        public string Response { get; set; }
    }
}