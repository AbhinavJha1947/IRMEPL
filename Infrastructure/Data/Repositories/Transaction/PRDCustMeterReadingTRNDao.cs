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
    public class PRDCustMeterReadingTRNDao : IPRDCustMeterReadingTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDCustMeterReadingTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDCustMeterReadingTRNList> GetPRDCustMeterReadingTRNs()
        {
            string sortExpression = "CMRMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDCustMeterReadingTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDCustMeterReadingTRNList> GetPRDCustMeterReadingTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCustMeterReadingTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CMRMST_ID',");
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
            IList<PRDCustMeterReadingTRNList> list = new List<PRDCustMeterReadingTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CMRMST_ID = Convert.ToInt32(row["CMRMST_ID"]);
                int CMRMST_ApplicationID = Convert.ToInt32(row["CMRMST_ApplicationID"].ToString());
                string APPMST_AppNo = (row["APPMST_AppNo"].ToString());
                string CMRMST_MeterNo = (row["CMRMST_MeterNo"].ToString());
                string CMRMST_InitialReading = (row["CMRMST_InitialReading"].ToString());
                string CMRMST_StartDate = (row["CMRMST_StartDate"].ToString());
                string CMRMST_ReplaceDate = (row["CMRMST_ReplaceDate"].ToString());
                string CMRMST_PreviousReading = (row["CMRMST_PreviousReading"].ToString());
                list.Add(new PRDCustMeterReadingTRNList(CMRMST_ID, CMRMST_ApplicationID, APPMST_AppNo, CMRMST_MeterNo, CMRMST_InitialReading, CMRMST_StartDate, CMRMST_ReplaceDate, CMRMST_PreviousReading));
            }
            return list;
        }
        public IList<PRDCustomerreadingNOlist> GetPRDCustomerreadingNOlist(int CMRMST_ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCustMeterReadingTRN_Select " + CMRMST_ApplicationID);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            IList<PRDCustomerreadingNOlist> list = new List<PRDCustomerreadingNOlist>();

            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];
                foreach (DataRow row in dtList.Rows)
                {

                    int CMRMST_ID = Convert.ToInt32(row["CMRMST_ID"]);
                    Int64 CMRMST_MeterNo = Convert.ToInt64(row["CMRMST_MeterNo"].ToString());
                    decimal CMRMST_InitialReading = decimal.Parse(row["CMRMST_InitialReading"].ToString());
                    list.Add(new PRDCustomerreadingNOlist(CMRMST_ID, CMRMST_MeterNo, CMRMST_InitialReading));

                }
            }
            return list;
        }
        //public PRDCustomerreadingNOlist GetPRDCustomerreadingNOlist(int CMRMST_ApplicationID)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC Usp_TRNPRDCustMeterReadingTRN_SelectAll " + CMRMST_ApplicationID);
        //    DataRow row = _dbManager.GetDataRow(sql.ToString());
        //    #region"Variables Declaration"

        //    int CMRMST_ID = Convert.ToInt32(row["CMRMST_ID"]);   
        //    int CMRMST_MeterNo = Convert.ToInt32(row["CMRMST_MeterNo"]);
        //    decimal CMRMST_InitialReading = Convert.ToDecimal(row["CMRMST_InitialReading"]); 

        //    //int WORTRN_ContractorID = Convert.ToInt32(row["WORTRN_ContractorID"]);           
        //    #endregion

        //    return new
        //    PRDCustomerreadingNOlist(CMRMST_ID,CMRMST_MeterNo, CMRMST_InitialReading);
        //}
        public PRDCustMeterReadingTRN GetPRDCustMeterReadingTRN(int PRDCustMeterReadingTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_PRDCustMeterReadingTRN_Select " + PRDCustMeterReadingTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CMRMST_ID = Convert.ToInt32(row["CMRMST_ID"]);
            long CMRMST_ApplicationID = Convert.ToInt64(row["CMRMST_ApplicationID"]);
            long CMRMST_MeterNo = Convert.ToInt64(row["CMRMST_MeterNo"]);
            decimal CMRMST_InitialReading = Convert.ToDecimal(row["CMRMST_InitialReading"]);
            string CMRMST_StartDate = Convert.ToString(row["CMRMST_StartDate"]);
            string CMRMST_ReplaceDate = Convert.ToString(row["CMRMST_ReplaceDate"]);
            decimal CMRMST_PreviousReading = Convert.ToDecimal(row["CMRMST_PreviousReading"]);
            int CMRMST_CreatedByUserID = Convert.ToInt32(row["CMRMST_CreatedByUserID"]);
            string CMRMST_CreatedDateTime = Convert.ToString(row["CMRMST_CreatedDateTime"]);
            int CMRMST_UpdatedByUserID = Convert.ToInt32(row["CMRMST_UpdatedByUserID"]);
            string CMRMST_UpdatedDateTime = Convert.ToString(row["CMRMST_UpdatedDateTime"]);
            int CMRMST_RowStatus = Convert.ToInt32(row["CMRMST_RowStatus"]);
            long CMRMST_RowVersion = (long)row["CMRMST_RowVersion"];

            #endregion

            return new
            PRDCustMeterReadingTRN(CMRMST_ID, CMRMST_ApplicationID, CMRMST_MeterNo, CMRMST_InitialReading, CMRMST_StartDate, CMRMST_ReplaceDate, CMRMST_PreviousReading, CMRMST_CreatedByUserID, CMRMST_CreatedDateTime, CMRMST_UpdatedByUserID, CMRMST_UpdatedDateTime, CMRMST_RowStatus, CMRMST_RowVersion);
        }

        public PRDCustMeterReadingTRNMsg InsertPRDCustMeterReadingTRN(PRDCustMeterReadingTRN PRDCustMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDCustMeterReadingTRN_Insert] ");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_ApplicationID + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_MeterNo + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_InitialReading + ",");
            sql.Append("N'" + PRDCustMeterReadingTRN.CMRMST_StartDate + "',");
            sql.Append("N'" + PRDCustMeterReadingTRN.CMRMST_ReplaceDate + "',");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_PreviousReading + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_CreatedByUserID + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDCustMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public PRDCustMeterReadingTRNMsg UpdatePRDCustMeterReadingTRN(PRDCustMeterReadingTRN PRDCustMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCustMeterReadingTRN_Update ");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_ID + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_ApplicationID + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_MeterNo + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_InitialReading + ",");
            sql.Append("N'" + PRDCustMeterReadingTRN.CMRMST_StartDate + "',");
            sql.Append("N'" + PRDCustMeterReadingTRN.CMRMST_ReplaceDate + "',");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_PreviousReading + ",");
            sql.Append(PRDCustMeterReadingTRN.CMRMST_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDCustMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public PRDCustMeterReadingTRNMsg DeletePRDCustMeterReadingTRN(int PRDCustMeterReadingTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_PRDCustMeterReadingTRN_Delete " + PRDCustMeterReadingTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDCustMeterReadingTRNMsg(_RetVal, _RetStr);
        }
        public PRDCustMeterReadingTRNMsg1 DeletePRDCustMeterReadingTRNs(int CMRMST_ApplicationID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_PRDCustMeterReadingTRN_Delete " + CMRMST_ApplicationID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDCustMeterReadingTRNMsg1(_RetVal, _RetStr);
        }

    }
}
