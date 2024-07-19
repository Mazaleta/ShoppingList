using MongoDB.Driver;

namespace AutenticationAPI.Data
{
    public interface IMongoDBClient
    {
        IMongoClient Client { get; }
        IMongoDatabase GetDatabase(string listaCompra);
    }
}
