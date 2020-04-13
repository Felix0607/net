using System.Collections.Generic;
using System.Linq;
using net.Interface;
using net.Models;

namespace net.Manager
{
  
    public class UserManager : IUserManager
    {
        private readonly netCoreContext _db;
        public UserManager(netCoreContext db)
        {
            _db = db;
        }

        //新建使用者資料
        public void CreateUser(User user)
        {
            _db.User.Add(user);
            _db.SaveChanges();
        }

        //查詢使用者資料
        public List<User> GetUserInfo()
        {
            return _db.User.Select(row => row).ToList();
        }
    }
}