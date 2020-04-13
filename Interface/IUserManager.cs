using System.Collections.Generic;
using net.Models;

namespace net.Interface
{
    public interface IUserManager
    {
        void CreateUser(User user);
        List<User> GetUserInfo();
    }
}