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
    public class CORScreenMasterDao : ICORScreenMasterDao
    {

        public IList<CORScreenMasterList> GetCORScreenMasters()
        {
            int USERID = 0;
            string criteria = "";
            return GetCORScreenMasters(USERID, criteria);
        }

        /// <summary>
        /// Gets a sorted list of all branches.
        /// </summary>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of Branches.</returns>
        public IList<CORScreenMasterList> GetCORScreenMasters(int USERID, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("USP_USRScreenMaster_SelectAll ");

            //String Building for Order by Column.
            sql.Append(USERID + ",");
            sql.Append("'" + criteria + "'");

            DataSet ds = Infrastructure.Data.DbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];

            IList<CORScreenMasterList> list = new List<CORScreenMasterList>();
            foreach (DataRow row in dtList.Rows)
            {

                int ScreenId = int.Parse(row["ScreenId"].ToString());
                string ModuleName = row["ModuleName"].ToString();
                int ScreenModuleID = int.Parse(row["ScreenModuleID"].ToString());
                string FormName = row["FormName"].ToString();
                int ScreenParentID = int.Parse(row["ScreenParentID"].ToString());
                string SubModule = row["SubModule"].ToString();
                string FormTitle = row["FormTitle"].ToString();


                list.Add(new CORScreenMasterList(ScreenId, ModuleName, ScreenModuleID, FormName, ScreenParentID, SubModule, FormTitle));
            }

            return list;
        }

    }
}
