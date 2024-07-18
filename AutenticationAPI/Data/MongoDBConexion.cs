
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AutenticationAPI.Data
{
    public class MongoDBConexion
    {
        private static readonly string connectionUri;

        static MongoDBConexion()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            connectionUri = configuration["MongoDB:ConnectionString"];
        }

        public static void Conectar()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);

            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}


