using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.Controllers
{
    public class AccountController : Controller
    {
      

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(IFormCollection form)
        {
            string name = form["Name"];
            string email = form["Email"];
            string password = form["Password"];
            string confirmPassword = form["ConfirmPassword"];

            if (password != confirmPassword)
            {
                ViewBag.Error = "Password and Confirm Password do not match";
                return View();
            }

            TempData["Name"] = name;
            TempData["Email"] = email;
            TempData["Password"] = password;

            return RedirectToAction("Login");
        }

       
        public IActionResult Login()
        {
            ViewBag.RegisteredEmail = TempData["Email"];
            ViewBag.RegisteredPassword = TempData["Password"];

            TempData.Keep();

            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            string email = form["Email"];
            string password = form["Password"];

            string registeredEmail = TempData["Email"]?.ToString();
            string registeredPassword = TempData["Password"]?.ToString();

            TempData.Keep();
            if (email == registeredEmail &&
                password == registeredPassword)
            {
                TempData["Username"] = TempData["Name"];

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Email or Password";

            return View();
        }
    }
}