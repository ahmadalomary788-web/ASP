using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OYIL.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            var usersList = new List<string[]>
            {
                new string[] { "1", "Ahmad", "ahmad@email.com", "Active" },
                new string[] { "2", "Omar", "omar@email.com", "Pending" },
                new string[] { "3", "Ali", "ali@email.com", "Active" }
            };

            ViewBag.Users = usersList;

            return View();
        }
    }
}