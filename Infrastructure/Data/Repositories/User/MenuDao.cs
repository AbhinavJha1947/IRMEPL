using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.User
{
    public class MenuDao : IMenuDao
    {
        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<MenuList> GetMenus()
        {

            int userid = 0;
            return GetMenus(userid);

        }

        public IList<MenuList> GetMenus(int userid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_Menu_SelectAll  ");


            sql.Append(userid);

            //String Building for For Criteria.


            DataSet ds = Infrastructure.Data.DbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<MenuList> list = new List<MenuList>();
            foreach (DataRow row in dtList.Rows)
            {
                int _MenuID = int.Parse(row["MenuID"].ToString());
                string _Menutext = row["Menutext"].ToString();
                string _ImageURL = row["ImageURL"].ToString();
                string _MenuDiscription = row["MenuDiscription"].ToString();
                int _ParentID = int.Parse(row["ParentID"].ToString());
                string _NavigateURL = row["NavigateURL"].ToString();
                list.Add(new MenuList(_MenuID, _Menutext, _ImageURL, _MenuDiscription, _ParentID, _NavigateURL));
            }
            return list;
        }
    }
}

