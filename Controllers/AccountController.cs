using Login_App.Models;
using LoginApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login_App.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user == null)
            {
                ViewBag.Message = "User data is missing.";
                return View();
            }

            var users = new List<User>
            {
                new User { Username = "aadarsh", Password = "aadarsh12" },
                new User { Username = "bibhav", Password = "bibhavdubey12" },
                new User { Username = "aaditya", Password = "aaditya12" }
            };

            var matchedUser = users.FirstOrDefault(u =>
                u.Username == user.Username && u.Password == user.Password);

            if (matchedUser != null)
            {
                ViewBag.Username = matchedUser.Username;
                return View("Welcome");
            }

            ViewBag.Message = "Invalid Username or Password";
            return View();
        }
    }
}
