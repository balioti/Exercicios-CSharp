using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}