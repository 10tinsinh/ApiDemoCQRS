using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagerment.ConnectionDB;
using UserManagerment.Model;

namespace UserManagerment.Repositories
{
    public class UserData : IUserData
    {
        private readonly IMongoCollection<UserModel> _userCollection;
        public UserData(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _userCollection = database.GetCollection<UserModel>(mongoDBSettings.Value.CollectionName = "Users_CQRS");
        }

        public UserModel Create(UserModel user)
        {
            _userCollection.InsertOne(user);
            return user;
        }
           

        public List<UserModel> GetData() =>
            _userCollection.Find(_ => true).ToList();

        public UserModel GetOne(string id) =>
            _userCollection.Find(e => e.Id == id).FirstOrDefault();


        public void RemoveAsync(string id) =>
           _userCollection.DeleteOne(e => e.Id == id);
    }
}
