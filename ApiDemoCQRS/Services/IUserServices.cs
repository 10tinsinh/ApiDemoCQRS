using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagerment.Model;

namespace ApiDemoCQRS.Services
{
    public interface IUserServices
    {
        public Task<List<UserModel>> GetData();
        public Task<UserModel> GetDataById(string Id);
        public Task<UserModel> CreateUser(UserModel user);
    }
}
