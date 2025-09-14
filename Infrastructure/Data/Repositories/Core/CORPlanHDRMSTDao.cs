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
    public class CORPlanHDRMSTDao : ICORPlanHDRMSTDao
    {
        private readonly DbManager _dbManager;

        public CORPlanHDRMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORPlanHDRMSTList> GetCORPlanHDRMSTs()
        {
            string sortExpression = "PLAMST_Code";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORPlanHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORPlanHDRMSTList> GetCORPlanHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'PLAMST_Code',");
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
            IList<CORPlanHDRMSTList> list = new List<CORPlanHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                //***Please write field names which you wants to display in grid.***
                int PLAMST_Code = int.Parse(row["PLAMST_Code"].ToString());
                string PLAMST_StartDate = row["PLAMST_StartDate"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string PlanType = row["PlanType"].ToString();
                string PropertyType = row["PropertyType"].ToString();
                decimal PLAMST_WOAmt = decimal.Parse(row["PLAMST_WOAmt"].ToString());
                decimal PLAMST_CommClearAmt = decimal.Parse(row["PLAMST_CommClearAmt"].ToString());
                decimal PLAMST_PlanAmt = decimal.Parse(row["PLAMST_PlanAmt"].ToString());
                string PLAMST_RowStatus = row["PLAMST_RowStatus"].ToString();
                string PLAMST_MobileAppStatus = row["PLAMST_MobileAppStatus"].ToString();

                list.Add(new CORPlanHDRMSTList(PLAMST_Code, PLAMST_StartDate, PLAMST_PlanName, PlanType, PropertyType, PLAMST_WOAmt, PLAMST_CommClearAmt, PLAMST_PlanAmt, PLAMST_RowStatus, Count, PLAMST_MobileAppStatus));
                //  list.Add(new CORPlanHDRMSTList(PLAMST_Code, PLAMST_StartDate, PLAMST_PlanName, PlanType, PropertyType, PLAMST_WOAmt, PLAMST_CommClearAmt, PLAMST_PlanAmt, PLAMST_RowStatus, Count));

            }
            return list;
        }

        public IList<CORPlanHDRMSTList> GetCORPlanHDRMSTsForMobileApp(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_SelectAll_ForMobileApp ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'PLAMST_Code',");
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
            IList<CORPlanHDRMSTList> list = new List<CORPlanHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                //***Please write field names which you wants to display in grid.***
                int PLAMST_Code = int.Parse(row["PLAMST_Code"].ToString());
                string PLAMST_StartDate = row["PLAMST_StartDate"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string PlanType = row["PlanType"].ToString();
                string PropertyType = row["PropertyType"].ToString();
                decimal PLAMST_WOAmt = decimal.Parse(row["PLAMST_WOAmt"].ToString());
                decimal PLAMST_CommClearAmt = decimal.Parse(row["PLAMST_CommClearAmt"].ToString());
                decimal PLAMST_PlanAmt = decimal.Parse(row["PLAMST_PlanAmt"].ToString());
                string PLAMST_RowStatus = row["PLAMST_RowStatus"].ToString();
                string PLAMST_MobileAppStatus = row["PLAMST_MobileAppStatus"].ToString();

                list.Add(new CORPlanHDRMSTList(PLAMST_Code, PLAMST_StartDate, PLAMST_PlanName, PlanType, PropertyType, PLAMST_WOAmt, PLAMST_CommClearAmt, PLAMST_PlanAmt, PLAMST_RowStatus, Count, PLAMST_MobileAppStatus));
                //  list.Add(new CORPlanHDRMSTList(PLAMST_Code, PLAMST_StartDate, PLAMST_PlanName, PlanType, PropertyType, PLAMST_WOAmt, PLAMST_CommClearAmt, PLAMST_PlanAmt, PLAMST_RowStatus, Count));

            }
            return list;
        }

        public CORPlanHDRMST GetCORPlanHDRMST(int CORPlanHDRMSTid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_Select " + CORPlanHDRMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int PLAMST_Code = Convert.ToInt32(row["PLAMST_Code"]);
            string PLAMST_StartDate = Convert.ToString(row["PLAMST_StartDate"]);
            string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
            int PLAMST_PlanType = Convert.ToInt32(row["PLAMST_PlanType"]);
            int PLAMST_PropertyTypeID = Convert.ToInt32(row["PLAMST_PropertyTypeID"]);
            decimal PLAMST_PlanAmt = Convert.ToDecimal(row["PLAMST_PlanAmt"]);
            decimal PLAMST_WOAmt = Convert.ToDecimal(row["PLAMST_WOAmt"]);
            decimal PLAMST_CommClearAmt = Convert.ToDecimal(row["PLAMST_CommClearAmt"]);
            int PLAMST_CreatedByUserID = Convert.ToInt32(row["PLAMST_CreatedByUserID"]);
            int PLAMST_UpdatedByUserID = Convert.ToInt32(row["PLAMST_UpdatedByUserID"]);
            int PLAMST_RowStatus = Convert.ToInt32(row["PLAMST_RowStatus"]);
            long PLAMST_RowVersion = (long)row["PLAMST_RowVersion"];
            int PLAMST_MobileAppStatus = int.Parse(row["PLAMST_MobileAppStatus"].ToString());

            #endregion

            return new
            CORPlanHDRMST(PLAMST_Code, PLAMST_StartDate, PLAMST_PlanName, PLAMST_PlanType, PLAMST_PropertyTypeID, PLAMST_PlanAmt, PLAMST_WOAmt, PLAMST_CommClearAmt, PLAMST_CreatedByUserID, PLAMST_UpdatedByUserID, PLAMST_RowStatus, PLAMST_RowVersion, PLAMST_MobileAppStatus);
        }

        public CORPlanHDRMSTMsg InsertCORPlanHDRMST(CORPlanHDRMST CORPlanHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_Insert ");
            sql.Append("N'" + CORPlanHDRMST.PLAMST_StartDate + "',");
            sql.Append("N'" + CORPlanHDRMST.PLAMST_PlanName + "',");
            sql.Append(CORPlanHDRMST.PLAMST_PlanType + ",");
            sql.Append(CORPlanHDRMST.PLAMST_PropertyTypeID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_PlanAmt + ",");
            sql.Append(CORPlanHDRMST.PLAMST_WOAmt + ",");
            sql.Append(CORPlanHDRMST.PLAMST_CommClearAmt + ",");
            sql.Append(CORPlanHDRMST.PLAMST_CreatedByUserID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_UpdatedByUserID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_RowStatus + ",");
            sql.Append(CORPlanHDRMST.PLAMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORPlanHDRMSTMsg UpdateCORPlanHDRMST(CORPlanHDRMST CORPlanHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_Update ");
            sql.Append(CORPlanHDRMST.PLAMST_Code + ",");
            sql.Append("N'" + CORPlanHDRMST.PLAMST_StartDate + "',");
            sql.Append("N'" + CORPlanHDRMST.PLAMST_PlanName + "',");
            sql.Append(CORPlanHDRMST.PLAMST_PlanType + ",");
            sql.Append(CORPlanHDRMST.PLAMST_PropertyTypeID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_PlanAmt + ",");
            sql.Append(CORPlanHDRMST.PLAMST_WOAmt + ",");
            sql.Append(CORPlanHDRMST.PLAMST_CommClearAmt + ",");
            sql.Append(CORPlanHDRMST.PLAMST_CreatedByUserID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_UpdatedByUserID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_RowStatus + ",");
            sql.Append(CORPlanHDRMST.PLAMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORPlanHDRMSTMsg DeleteCORPlanHDRMST(int CORPlanHDRMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_Delete " + CORPlanHDRMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORPlanHDRMSTMsg UpdateCORPlanHDRMST_ForMobileApp(CORPlanHDRMST CORPlanHDRMST)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanHDRMST_Update_IsUseInApp ");
            sql.Append(CORPlanHDRMST.PLAMST_Code + ",");
            sql.Append(CORPlanHDRMST.PLAMST_UpdatedByUserID + ",");
            sql.Append(CORPlanHDRMST.PLAMST_MobileAppStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }
    }
}
