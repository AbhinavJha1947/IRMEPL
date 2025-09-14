using Application.Interfaces.User;
using Core.Entities.User;
using Microsoft.Extensions.Logging;
using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Infrastructure.Data.Interfaces.User;
using System.Collections.Generic;

namespace Application.Services.User
{
    public class MenuService : IMenuService
    {
        private readonly IMenuDao _menuDao;

        public MenuService(IMenuDao menuDao)
        {
            _menuDao = menuDao;
        }

        public IList<MenuList> GetMenus(int userId)
        {
            // Business rules can be added here in future
            return _menuDao.GetMenus(userId);
        }
        public IList<MenuList> GetMenus()
        {
            // Business rules can be added here in future
            return _menuDao.GetMenus();
        }

    }
}






