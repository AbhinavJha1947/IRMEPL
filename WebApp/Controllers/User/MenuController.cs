using Application.Interfaces.User;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers.User
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public IActionResult Index(int userId)
        {
            var menus = _menuService.GetMenus(userId);
            return View(menus); 
        }
    }
}
