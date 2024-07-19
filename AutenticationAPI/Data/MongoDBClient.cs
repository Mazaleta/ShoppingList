using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Diagnostics;

namespace AutenticationAPI.Data
{
    public class MongoDBClient : IMongoDBClient
    {
        private readonly IMongoClient _client;

        public MongoDBClient(IConfiguration configuration)
        {
            var connectionUri = configuration["MongoDB:ConnectionString"];
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            try{
                _client = new MongoClient(settings);   
            }catch (Exception e){
                Debugger.Log(1, "High", e.Message);
            }
        }

        public IMongoClient Client => _client;

        public IMongoDatabase GetDatabase(string listaCompra)
        {
            return _client.GetDatabase(listaCompra);
        }
    }
}