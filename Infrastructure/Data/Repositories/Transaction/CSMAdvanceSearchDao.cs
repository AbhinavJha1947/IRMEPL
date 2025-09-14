using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class CSMAdvanceSearchDao : ICSMAdvanceSearchDao
    {
        private readonly DbManager _dbManager;

        public CSMAdvanceSearchDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMAdvanceSearchList> GetCSMAdvanceSearchs()
        {
            string sortExpression = "APPMST_AppID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMAdvanceSearchs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CSMAdvanceSearchList> GetCSMAdvanceSearchs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAdvanceSearch_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_AppID',");
            }
            else
            {
                sql.Append("'" + sortExpression + "',");
            }
            //String Building for Sorintg Type
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append("'ASC',");
            }
            else
            {
                sql.Append("'" + sortType + "',");
            }
            //String Building for Page Index
            sql.Append(pageIndex + ",");
            sql.Append(pageSize + ",'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CSMAdvanceSearchList> list = new List<CSMAdvanceSearchList>();
            foreach (DataRow row in dtList.Rows)
            {
                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string ApplicationDate = row["ApplicationDate"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string Address1 = row["Address1"].ToString();
                string APPMST_Mobile = row["APPMST_Mobile"].ToString();
                string APPMST_Phone = row["APPMST_Phone"].ToString();
                string OMStatus = row["OMStatus"].ToString();
                string Area = row["Area"].ToString();

                list.Add(new CSMAdvanceSearchList(APPMST_AppID, APPMST_AppNo, ApplicationDate, CustomerName, "", "", "", Address1, APPMST_Phone, APPMST_Mobile, "", OMStatus, Area, APPMST_CustomerID, Count));
            }
            return list;
        }

    }
}
