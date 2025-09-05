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
    public class CORFunctionalityHDRMSTDao : ICORFunctionalityHDRMSTDao
    {
        public IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs()
        {

            string criteria = "";
            return GetCORFunctionalityHDRMSTs(criteria);
        }

        /// <summary>
        /// Gets a sorted list of all branches.
        /// </summary>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of Branches.</returns>
        public IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs(string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("usp_CORFunctionalityHDRMST_SelectAll ");

            //String Building for Order by Column.
            sql.Append("'" + criteria + "'");

            DataSet ds = Infrastructure.Data.DbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];

            IList<CORFunctionalityHDRMSTList> list = new List<CORFunctionalityHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {

                int FunctionID = int.Parse(row["FunctionID"].ToString());
                string FunctionName = row["FunctionName"].ToString();
                string Status = row["Status"].ToString();

                list.Add(new CORFunctionalityHDRMSTList(FunctionID, FunctionName, Status));
            }

            return list;
        }

    }
}

