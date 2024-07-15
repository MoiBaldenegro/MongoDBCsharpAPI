using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb+srv://tomateDataBase:tomatemasqueunataqueria@cluster0.ficwm8y.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("users");

            // Consultar todos los documentos en la colección "users"
            var documents = collection.Find(new BsonDocument()).ToList();

            // Mostrar los documentos por consola
            Console.WriteLine("Documentos en la colección 'users':");
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.ToJson());
            }
        }
    }
}
