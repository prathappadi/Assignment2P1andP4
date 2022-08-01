using MongoDB.Driver;
using MongoDB.Bson;
using Assigment.Controllers;

namespace Assigment
{
    public class MongoDatabase
    {

        public MongoDatabase()
        {

        }
        public List<BsonDocument> ShowAllDataBase()
        {
            var dbClient = new MongoClient("mongodb://127.0.0.1:27017");
            var dbList = dbClient.ListDatabases().ToList();

            //Console.WriteLine("The list of databases are:");

            //foreach (var item in dbList)
            //{
            //    Console.WriteLine(item);
            //}
            return dbList;
        }
    }
}
