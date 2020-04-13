using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using net.Interface;
using net.Middleware;
using net.Models;
using net.ViewModel;

namespace net.Controllers
{
    [MiddlewareFilter(typeof(CultureMiddleware))]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;
        public UserController(IUserManager userManager){
            _userManager = userManager;
        }
        public IActionResult UserIndex()
        {
             //查詢使用者資料
             var model = new UserViewModel();
             model.UserList = _userManager.GetUserInfo();
            return View(model);
        }
        

        //新建使用者資料
        [HttpPost]
        public IActionResult CreateUser(User user){
            _userManager.CreateUser(user);
            return RedirectToAction("UserIndex");
        }
       
    }
}