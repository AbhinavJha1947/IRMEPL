using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class MasterPagesController : Controller
    {
        public IActionResult MainPage()
        {
            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Default()
        {
            return RedirectToAction("Index", "Dashboard");
        }
    }
}