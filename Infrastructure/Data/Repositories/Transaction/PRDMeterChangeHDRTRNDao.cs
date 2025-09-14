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
    public class PRDMeterChangeHDRTRNDao : IPRDMeterChangeHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDMeterChangeHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDMeterChangeHDRTRNList> GetPRDMeterChangeHDRTRNs()
        {
            string sortExpression = "METCHG_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDMeterChangeHDRTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDMeterChangeHDRTRNList> GetPRDMeterChangeHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeHDRTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'METCHG_ID',");
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
            IList<PRDMeterChangeHDRTRNList> list = new List<PRDMeterChangeHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int METCHG_ID = int.Parse(row["METCHG_ID"].ToString());
                string CustomerID = row["CustomerID"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string APPMST_Address = row["APPMST_Address"].ToString();
                string APPMST_Landmark = row["APPMST_Landmark"].ToString();
                string AREMST_Name = row["AREMST_Name"].ToString();
                string CustomerType = row["CustomerType"].ToString();
                string PlanName = row["PlanName"].ToString();
                Int64 METCHG_NewMeterNo = Convert.ToInt64(row["METCHG_NewMeterNo"].ToString());
                decimal METCHG_InitialReading = decimal.Parse(row["METCHG_InitialReading"].ToString());
                string METCHG_ReplaceDate = row["METCHG_ReplaceDate"].ToString();
                string METCHG_RequestNo = row["METCHG_RequestNo"].ToString();
                Int64 METCHD_OldMeterNo = Convert.ToInt64(row["METCHD_OldMeterNo"].ToString());
                decimal METCHD_OldMeterReading = decimal.Parse(row["METCHD_OldMeterReading"].ToString());
                string METCHG_UpdatedByUserID = row["METCHG_UpdatedByUserID"].ToString();
                list.Add(new PRDMeterChangeHDRTRNList(METCHG_ID, CustomerID, CustomerName, APPMST_Address, APPMST_Landmark, AREMST_Name, CustomerType, PlanName, METCHG_NewMeterNo, METCHG_InitialReading, METCHG_ReplaceDate, METCHG_RequestNo, METCHD_OldMeterNo, METCHD_OldMeterReading, METCHG_UpdatedByUserID, Count));
            }
            return list;
        }

        public PRDMeterChangeHDRTRN GetPRDMeterChangeHDRTRN(int PRDMeterChangeHDRTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeHDRTRN_Select " + PRDMeterChangeHDRTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int METCHG_ID = Convert.ToInt32(row["METCHG_ID"]);
            int METCHG_ApplicationId = Convert.ToInt32(row["METCHG_ApplicationId"]);
            string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
            Int64 METCHG_NewMeterNo = Convert.ToInt64(row["METCHG_NewMeterNo"]);
            decimal METCHG_InitialReading = Convert.ToDecimal(row["METCHG_InitialReading"]);
            string METCHG_ReplaceDate = Convert.ToString(row["METCHG_ReplaceDate"]);
            int METCHG_CreatedByUserID = Convert.ToInt32(row["METCHG_CreatedByUserID"]);
            string METCHG_CreatedDateTime = Convert.ToString(row["METCHG_CreatedDateTime"]);
            int METCHG_UpdatedByUserID = Convert.ToInt32(row["METCHG_UpdatedByUserID"]);
            string METCHG_UpdatedDateTime = Convert.ToString(row["METCHG_UpdatedDateTime"]);
            string METCHG_RequestNo = Convert.ToString(row["METCHG_RequestNo"]);
            long METCHG_RowVersion = (long)row["METCHG_RowVersion"];

            #endregion

            return new
            PRDMeterChangeHDRTRN(METCHG_ID, METCHG_ApplicationId, APPMST_CustomerID, METCHG_NewMeterNo, METCHG_InitialReading, METCHG_ReplaceDate, METCHG_CreatedByUserID, METCHG_CreatedDateTime, METCHG_UpdatedByUserID, METCHG_UpdatedDateTime, METCHG_RequestNo, METCHG_RowVersion);
        }

        public PRDMeterChangeHDRTRNMsg InsertPRDMeterChangeHDRTRN(PRDMeterChangeHDRTRN PRDMeterChangeHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeHDRTRN_Insert ");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_ApplicationId + ",");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_NewMeterNo + ",");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_InitialReading + ",");
            sql.Append("N'" + PRDMeterChangeHDRTRN.METCHG_ReplaceDate + "',");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDMeterChangeHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDMeterChangeHDRTRNMsg UpdatePRDMeterChangeHDRTRN(PRDMeterChangeHDRTRN PRDMeterChangeHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeHDRTRN_Update ");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_ID + ",");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_ApplicationId + ",");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_NewMeterNo + ",");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_InitialReading + ",");
            sql.Append("N'" + PRDMeterChangeHDRTRN.METCHG_ReplaceDate + "',");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_UpdatedByUserID + ",");
            sql.Append(PRDMeterChangeHDRTRN.METCHG_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDMeterChangeHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDMeterChangeHDRTRNMsg DeletePRDMeterChangeHDRTRN(int PRDMeterChangeHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeHDRTRN_Delete " + PRDMeterChangeHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDMeterChangeHDRTRNMsg(_RetVal, _RetStr);
        }
    }
}
