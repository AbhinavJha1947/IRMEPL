using Core.Entities.User;

namespace Application.Interfaces.User
{
    public interface IMenuService
    {
            IList<MenuList> GetMenus();

            IList<MenuList> GetMenus(int Userid);

    }
}


