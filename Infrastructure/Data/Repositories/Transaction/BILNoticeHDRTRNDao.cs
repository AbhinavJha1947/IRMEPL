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
    public class BILNoticeHDRTRNDao : IBILNoticeHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public BILNoticeHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILLNoticeOutstandingHDRList> GetBILLNoticeOutstandingHDRs()
        {
            string sortExpression = "ApplicationId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILLNoticeOutstandingHDRs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILLNoticeOutstandingHDRList> GetBILLNoticeOutstandingHDRs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILNoticeHDRTRN_NoticeoutStandingSelectLatest1 ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CustomerID',");
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

            IList<BILLNoticeOutstandingHDRList> list = new List<BILLNoticeOutstandingHDRList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***

                decimal KeyField = decimal.Parse(row["KeyField"].ToString());
                string CustomerID = row["CustomerID"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string Address = row["Address"].ToString();
                string Area = row["Area"].ToString();
                string PlanName = row["PlanName"].ToString();
                string InvoiceNo = row["InvoiceNo"].ToString();
                string InvoiceDate = row["InvoiceDate"].ToString();
                decimal TotalOutStandingAmount = decimal.Parse(row["TotalOutStandingAmount"].ToString());
                string NoticeIssued = row["NoticeIssued"].ToString();
                decimal billAmt = 0;
                decimal.TryParse(row["BillAmt"].ToString(), out billAmt);
                decimal DebitNoteAmount = 0;
                decimal.TryParse(row["DebitNoteAmount"].ToString(), out DebitNoteAmount);
                decimal LatePayment = 0;
                decimal.TryParse(row["LatePayment"].ToString(), out LatePayment);
                list.Add(new BILLNoticeOutstandingHDRList(LatePayment, DebitNoteAmount, billAmt, KeyField, CustomerID, CustomerName, Address, Area, PlanName, TotalOutStandingAmount, NoticeIssued, InvoiceNo, InvoiceDate, Count));
            }
            return list;
        }

        public BILLNoticeOutstandingHDR GetBILLNoticeOutstandingHDR(int BILLNoticeOutstandingHDRid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_BILLNoticeOutstandingHDR_Select " + BILLNoticeOutstandingHDRid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal ApplicationId = Convert.ToDecimal(row["ApplicationId"]);
            string CustomerID = Convert.ToString(row["CustomerID"]);
            string CustomerName = Convert.ToString(row["CustomerName"]);
            string Address = Convert.ToString(row["Address"]);
            string Area = Convert.ToString(row["Area"]);
            string PlanName = Convert.ToString(row["PlanName"]);
            string DebiteNoteNo = Convert.ToString(row["DebiteNoteNo"]);
            string DebiteNoteDate = Convert.ToString(row["DebiteNoteDate"]);
            decimal TotalDue = Convert.ToDecimal(row["TotalDue"]);
            decimal TotalReceived = Convert.ToDecimal(row["TotalReceived"]);
            decimal DebitNoteOutstandingAmount = Convert.ToDecimal(row["DebitNoteOutstandingAmount"]);
            decimal TotalDuaAmount = Convert.ToDecimal(row["TotalDuaAmount"]);
            decimal TotalLatePayment = Convert.ToDecimal(row["TotalLatePayment"]);
            decimal TotalBillDueAmount = Convert.ToDecimal(row["TotalBillDueAmount"]);
            decimal TotalNetBillAmount = Convert.ToDecimal(row["TotalNetBillAmount"]);
            decimal TotalOutStandingAmount = Convert.ToDecimal(row["TotalOutStandingAmount"]);
            string NoticeIssued = Convert.ToString(row["NoticeIssued"]);

            #endregion

            return new
            BILLNoticeOutstandingHDR(ApplicationId, CustomerID, CustomerName, Address, Area, PlanName, DebiteNoteNo, DebiteNoteDate, TotalDue, TotalReceived, DebitNoteOutstandingAmount, TotalDuaAmount, TotalLatePayment, TotalBillDueAmount, TotalNetBillAmount, TotalOutStandingAmount, NoticeIssued);
        }

        public BILLNoticeOutstandingHDRMsg InsertBILLNoticeOutstandingHDR(BILLNoticeOutstandingHDR BILLNoticeOutstandingHDR, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_BILLNoticeOutstandingHDR_Insert ");
            sql.Append("N'" + BILLNoticeOutstandingHDR.CustomerID + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.CustomerName + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.Address + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.Area + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.PlanName + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.DebiteNoteNo + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.DebiteNoteDate + "',");
            sql.Append(BILLNoticeOutstandingHDR.TotalDue + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalReceived + ",");
            sql.Append(BILLNoticeOutstandingHDR.DebitNoteOutstandingAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalDuaAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalLatePayment + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalBillDueAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalNetBillAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalOutStandingAmount + ",");
            sql.Append("N'" + BILLNoticeOutstandingHDR.NoticeIssued + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new BILLNoticeOutstandingHDRMsg(_RetVal, _RetStr);
        }

        public BILLNoticeOutstandingHDRMsg UpdateBILLNoticeOutstandingHDR(BILLNoticeOutstandingHDR BILLNoticeOutstandingHDR, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_BILLNoticeOutstandingHDR_Update ");
            sql.Append(BILLNoticeOutstandingHDR.ApplicationId + ",");
            sql.Append("N'" + BILLNoticeOutstandingHDR.CustomerID + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.CustomerName + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.Address + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.Area + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.PlanName + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.DebiteNoteNo + "',");
            sql.Append("N'" + BILLNoticeOutstandingHDR.DebiteNoteDate + "',");
            sql.Append(BILLNoticeOutstandingHDR.TotalDue + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalReceived + ",");
            sql.Append(BILLNoticeOutstandingHDR.DebitNoteOutstandingAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalDuaAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalLatePayment + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalBillDueAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalNetBillAmount + ",");
            sql.Append(BILLNoticeOutstandingHDR.TotalOutStandingAmount + ",");
            sql.Append("N'" + BILLNoticeOutstandingHDR.NoticeIssued + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new BILLNoticeOutstandingHDRMsg(_RetVal, _RetStr);
        }

        public BILLNoticeOutstandingHDRMsg DeleteBILLNoticeOutstandingHDR(int BILLNoticeOutstandingHDRID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_BILLNoticeOutstandingHDR_Delete " + BILLNoticeOutstandingHDRID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new BILLNoticeOutstandingHDRMsg(_RetVal, _RetStr);
        }

    }
}
