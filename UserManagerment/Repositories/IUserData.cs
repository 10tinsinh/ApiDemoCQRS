using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagerment.Model;
using UserManagerment;

namespace UserManagerment.Repositories
{
    public interface IUserData
    {
        public List<UserModel> GetData();
        public UserModel Create(UserModel characterModel);
        public UserModel GetOne(string sysCode);
        public void RemoveAsync(string sysCode);
    }
}
