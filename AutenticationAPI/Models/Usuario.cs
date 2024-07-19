using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Usuario
{
    [BsonId]
    public ObjectId Id { get; set; }
    // Otros campos...
    [BsonElement("nombre")]
    public string? Name { get; set; }
    
}
