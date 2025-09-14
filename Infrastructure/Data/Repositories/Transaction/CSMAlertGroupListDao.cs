using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class CSMAlertGroupListDao : ICSMAlertGroupListDao
    {
        private readonly DbManager _dbManager;

        public CSMAlertGroupListDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMAlertGroupListList> GetCSMAlertGroupLists()
        {
            string sortExpression = "AGLDTL_AlertListId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMAlertGroupLists(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CSMAlertGroupListList> GetCSMAlertGroupLists(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupList_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'AGLDTL_AlertListId',");
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
            IList<CSMAlertGroupListList> list = new List<CSMAlertGroupListList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int AGMMST_AlertGroupId = int.Parse(row["AGLDTL_AlertListId"].ToString());
                int AGMMST_AlertNameId = int.Parse(row["AGLDTL_AlertGroupId"].ToString());
                int AGLDTL_AlertUserId = int.Parse(row["AGLDTL_AlertUserId"].ToString());
                list.Add(new CSMAlertGroupListList(AGMMST_AlertGroupId, AGMMST_AlertNameId, AGLDTL_AlertUserId, Count));
            }
            return list;
        }

        public CSMAlertGroupList GetCSMAlertGroupList(int CSMAlertGroupListid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_CSMAlertGroupList_Select " + CSMAlertGroupListid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal AGLDTL_AlertListId = Convert.ToDecimal(row["AGLDTL_AlertListId"]);
            int AGLDTL_AlertGroupId = Convert.ToInt32(row["AGLDTL_AlertGroupId"]);
            int AGLDTL_AlertUserId = Convert.ToInt32(row["AGLDTL_AlertUserId"]);

            #endregion

            return new
            CSMAlertGroupList(AGLDTL_AlertListId, AGLDTL_AlertGroupId, AGLDTL_AlertUserId);
        }

        public CSMAlertGroupListMsg InsertCSMAlertGroupList(CSMAlertGroupList CSMAlertGroupList, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupList_Insert ");
            sql.Append(CSMAlertGroupList.AGLDTL_AlertGroupId + ",");
            sql.Append(CSMAlertGroupList.AGLDTL_AlertUserId + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CSMAlertGroupListMsg(_RetVal, _RetStr);
        }

        public CSMAlertGroupListMsg UpdateCSMAlertGroupList(CSMAlertGroupList CSMAlertGroupList, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Update_CSMAlertGroupList_Update ");
            sql.Append(CSMAlertGroupList.AGLDTL_AlertListId + ",");
            sql.Append(CSMAlertGroupList.AGLDTL_AlertGroupId + ",");
            sql.Append(CSMAlertGroupList.AGLDTL_AlertUserId + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMAlertGroupListMsg(_RetVal, _RetStr);
        }

        public CSMAlertGroupListMsg DeleteCSMAlertGroupList(int CSMAlertGroupListID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupList_Delete " + CSMAlertGroupListID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMAlertGroupListMsg(_RetVal, _RetStr);
        }

    }
}
