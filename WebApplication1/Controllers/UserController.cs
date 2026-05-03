using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    public IActionResult SignIn()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }
}