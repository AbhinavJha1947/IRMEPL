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
    public class BILCustDisconnMeterReadingTRNDao : IBILCustDisconnMeterReadingTRNDao
    {
        private readonly DbManager _dbManager;

        public BILCustDisconnMeterReadingTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILCustDisconnMeterReadingTRNList> GetBILCustDisconnMeterReadingTRNs()
        {
            string sortExpression = "CDMTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILCustDisconnMeterReadingTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILCustDisconnMeterReadingTRNList> GetBILCustDisconnMeterReadingTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILCustDisconnMeterReadingTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CDMTRN_ID',");
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
            IList<BILCustDisconnMeterReadingTRNList> list = new List<BILCustDisconnMeterReadingTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public BILCustDisconnMeterReadingTRN GetBILCustDisconnMeterReadingTRN(int BILCustDisconnMeterReadingTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILCustDisconnMeterReadingTRN_Select " + BILCustDisconnMeterReadingTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int CDMTRN_ID = Convert.ToInt32(row["CDMTRN_ID"]);
            int CDMTRN_RequestCode = Convert.ToInt32(row["CDMTRN_RequestCode"]);
            long CDMTRN_MeterNo = long.Parse(row["CDMTRN_MeterNo"].ToString());
            decimal CDMTRN_ReqMeterReading = Convert.ToDecimal(row["CDMTRN_ReqMeterReading"]);
            decimal CDMTRN_DisMeterReading = Convert.ToDecimal(row["CDMTRN_DisMeterReading"]);
            decimal CDMTRN_PrevMeterReading = Convert.ToDecimal(row["CDMTRN_PrevMeterReading"]);
            int CDMTRN_CreatedByUserID = Convert.ToInt32(row["CDMTRN_CreatedByUserID"]);
            string CDMTRN_CreatedDateTime = Convert.ToString(row["CDMTRN_CreatedDateTime"]);
            int CDMTRN_UpdatedByUserID = Convert.ToInt32(row["CDMTRN_UpdatedByUserID"]);
            string CDMTRN_UpdatedDateTime = Convert.ToString(row["CDMTRN_UpdatedDateTime"]);
            int CDMTRN_RowStatus = Convert.ToInt32(row["CDMTRN_RowStatus"]);
            long CDMTRN_RowVersion = long.Parse(row["CDMTRN_RowVersion"].ToString());
            #endregion

            return new
            BILCustDisconnMeterReadingTRN(CDMTRN_ID, CDMTRN_RequestCode, CDMTRN_MeterNo, CDMTRN_ReqMeterReading, CDMTRN_DisMeterReading, CDMTRN_PrevMeterReading, CDMTRN_CreatedByUserID, CDMTRN_CreatedDateTime, CDMTRN_UpdatedByUserID, CDMTRN_UpdatedDateTime, CDMTRN_RowStatus, CDMTRN_RowVersion);
        }

        public BILCustDisconnMeterReadingTRNMsg InsertBILCustDisconnMeterReadingTRN(BILCustDisconnMeterReadingTRN BILCustDisconnMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILCustDisconnMeterReadingTRN_Insert ");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_RequestCode + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_MeterNo + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_ReqMeterReading + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_DisMeterReading + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_PrevMeterReading + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_CreatedByUserID + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILCustDisconnMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public BILCustDisconnMeterReadingTRNMsg UpdateBILCustDisconnMeterReadingTRN(BILCustDisconnMeterReadingTRN BILCustDisconnMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILCustDisconnMeterReadingTRN_Update ");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_ID + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_RequestCode + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_MeterNo + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_ReqMeterReading + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_DisMeterReading + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_PrevMeterReading + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_UpdatedByUserID + ",");
            sql.Append("N'" + BILCustDisconnMeterReadingTRN.CDMTRN_UpdatedDateTime + "',");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_RowStatus + ",");
            sql.Append(BILCustDisconnMeterReadingTRN.CDMTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILCustDisconnMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public BILCustDisconnMeterReadingTRNMsg DeleteBILCustDisconnMeterReadingTRN(int BILCustDisconnMeterReadingTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_BILCustDisconnMeterReadingTRN_Delete " + BILCustDisconnMeterReadingTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new BILCustDisconnMeterReadingTRNMsg(_RetVal, _RetStr);
        }

    }
}
