using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORAppPlanHistoryMasterDao : ICORAppPlanHistoryMasterDao
    {
        private readonly DbManager _dbManager;

        public CORAppPlanHistoryMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORAppPlanHistoryMasterList> GetCORAppPlanHistoryMasters()
        {
            string sortExpression = "PLAHST_Id";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORAppPlanHistoryMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORAppPlanHistoryMasterList> GetCORAppPlanHistoryMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppPlanHistoryMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'PLAHST_Id',");
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
            IList<CORAppPlanHistoryMasterList> list = new List<CORAppPlanHistoryMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                string ApplicationNo = row["ApplicationNo"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string OldPlanName = row["OldPlanName"].ToString();
                string NewPlanName = row["NewPlanName"].ToString();
                string PLAHST_Remarks = row["PLAHST_Remarks"].ToString();
                string PLAHST_Date = row["PLAHST_Date"].ToString();
                list.Add(new CORAppPlanHistoryMasterList(ApplicationNo, CustomerName, OldPlanName, NewPlanName, PLAHST_Date, PLAHST_Remarks, Count));
            }
            return list;
        }

        public CORAppPlanHistoryMaster GetCORAppPlanHistoryMaster(int CORAppPlanHistoryMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppPlanHistoryMaster_Select " + CORAppPlanHistoryMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int PLAHST_Id = Convert.ToInt32(row["PLAHST_Id"]);
            decimal PLAHST_ApplicationId = Convert.ToDecimal(row["PLAHST_ApplicationId"]);
            int PLAHST_OldPlanId = Convert.ToInt32(row["PLAHST_OldPlanId"]);
            int PLAHST_NewPlanId = Convert.ToInt32(row["PLAHST_NewPlanId"]);
            string PLAHST_Date = Convert.ToString(row["PLAHST_Date"]);
            string PLAHST_Remarks = Convert.ToString(row["PLAHST_Remarks"]);
            int PLAHST_CreatedByUserID = Convert.ToInt32(row["PLAHST_CreatedByUserID"]);
            string PLAHST_CreatedDateTime = Convert.ToString(row["PLAHST_CreatedDateTime"]);

            #endregion

            return new
            CORAppPlanHistoryMaster(PLAHST_Id, PLAHST_ApplicationId, PLAHST_OldPlanId, PLAHST_NewPlanId, PLAHST_Date, PLAHST_Remarks, PLAHST_CreatedByUserID, PLAHST_CreatedDateTime);
        }

        public CORAppPlanHistoryMasterMsg InsertCORAppPlanHistoryMaster(CORAppPlanHistoryMaster CORAppPlanHistoryMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORAppPlanHistoryMaster_Insert ");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_ApplicationId + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_OldPlanId + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_NewPlanId + ",");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_Date + "',");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_Remarks.Replace("'", "''") + "',");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORAppPlanHistoryMasterMsg(_RetVal, _RetStr);
        }

        public CORAppPlanHistoryMasterMsg UpdateCORAppPlanHistoryMaster(CORAppPlanHistoryMaster CORAppPlanHistoryMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORAppPlanHistoryMaster_Update ");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_Id + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_ApplicationId + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_OldPlanId + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_NewPlanId + ",");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_Date + "',");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_Remarks + "',");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_CreatedByUserID + ",");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_CreatedDateTime + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORAppPlanHistoryMasterMsg(_RetVal, _RetStr);
        }

        public CORAppPlanHistoryMasterMsg DeleteCORAppPlanHistoryMaster(int CORAppPlanHistoryMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORAppPlanHistoryMaster_Delete " + CORAppPlanHistoryMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORAppPlanHistoryMasterMsg(_RetVal, _RetStr);
        }

        public CORAppPlanHistoryMasterMsg InsertCORAppPlanHistoryMaster_ForCSVUpload(CORAppPlanHistoryMaster CORAppPlanHistoryMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CORAppPlanHistoryMaster_Insert_ForCSVUpload] ");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_ApplicationId + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_OldPlanId + ",");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_NewPlanId + ",");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_Date + "',");
            sql.Append("N'" + CORAppPlanHistoryMaster.PLAHST_Remarks.Replace("'", "''") + "',");
            sql.Append(CORAppPlanHistoryMaster.PLAHST_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORAppPlanHistoryMasterMsg(_RetVal, _RetStr);
        }

        public CORAppPlanHistoryMasterMsg UpdateUSP_CORAppMasterPlanUpdate(int appID, int planID, int CreatedUserID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CORAppMasterPlanUpdate] ");
            sql.Append(appID + ",");
            sql.Append(planID + ",");
            sql.Append(CreatedUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORAppPlanHistoryMasterMsg(_RetVal, _RetStr);
        }

        public string GetPlanChangeAmount(CORAppPlanHistoryMaster CORAppPlanHistoryMaster)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppPlanHistoryMaster_GetAmountToPaid " + CORAppPlanHistoryMaster.PLAHST_ApplicationId);
            sql.Append("," + CORAppPlanHistoryMaster.PLAHST_OldPlanId);
            sql.Append("," + CORAppPlanHistoryMaster.PLAHST_NewPlanId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            string amt = Convert.ToString(row["AmtTobePaid"]);
            return amt;
        }

    }
}
