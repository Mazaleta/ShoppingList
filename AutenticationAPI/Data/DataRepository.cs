using MongoDB.Driver;
using MongoDB.Bson;
using System.Diagnostics;

namespace AutenticationAPI.Data
{
    public class DataRepository
    {
        private readonly IMongoDBClient _clientMongoDB;

        public DataRepository(IMongoDBClient clientMongoDB)
        {
            _clientMongoDB = clientMongoDB;
        }

        //Ejemplos de métodos que funcionan para tenerlos en cuenta.
        // public void GetAllUsers()
        // {
        //     var database = _clientMongoDB.GetDatabase("Lista_Compra");
        //     var userDB = database.GetCollection<Usuario>("Usuario");

        //     //var filter = Builders<Usuario>.Filter.Eq(u => u.User_Id, 1);

        //     var projection = Builders<Usuario>.Projection
        //         .Include(u => u.Id)
        //         .Include(u => u.Name);

        //     Console.WriteLine(userDB.CountDocuments(t => true));

        //     var usuarios = userDB.Find(d => true).Project<Usuario>(projection).ToList();

        //     // Realiza operaciones con la colección
        //     foreach (var usuario in usuarios)
        //     {
        //         Console.WriteLine(usuario.ToJson());
        //     }        
        // }

        // public void InsertUser(){
        //     try{
        //         var database = _clientMongoDB.GetDatabase("Lista_Compra");
        //         var userDB = database.GetCollection<Usuario>("Usuario");
        //         Console.WriteLine(userDB.CountDocuments(t => true));
        //         var usuario = new Usuario() {Name = "Maria"};
        //         userDB.InsertOne(usuario);
        //     }catch(Exception e){
        //         Debugger.Log(1, "HIGH", e.Message);
        //     }
        // }
    }
}
