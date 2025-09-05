using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces.User
{
    public interface IMenuDao
    {
        public IList<MenuList> GetMenus();
        public IList<MenuList> GetMenus(int userid);
    }
}
