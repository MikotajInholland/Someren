using Microsoft.AspNetCore.Mvc;

namespace Someren.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Students()
        {
            return View();
        }

        public IActionResult Lecturers()
        {
            return View();
        }   
    }
}
