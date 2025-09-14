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
    public class ACCRefundTRNDao : IACCRefundTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCRefundTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCRefundTRNList> GetACCRefundTRNs()
        {
            string sortExpression = "REFTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCRefundTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCRefundTRNList> GetACCRefundTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundTRN_SelectAll");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'REFTRN_ID',");
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
            IList<ACCRefundTRNList> list = new List<ACCRefundTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int REFTRN_ID = int.Parse(row["REFTRN_ID"].ToString());
                string Appmst_AppNo = row["Appmst_AppNo"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string REFTRN_RefundDate = row["REFTRN_RefundDate"].ToString();
                string REFTRN_RefundType = row["REFTRN_RefundType"].ToString();
                string REFTRN_Remarks = row["REFTRN_Remarks"].ToString();
                decimal REFTRN_ChequeAmount = decimal.Parse(row["REFTRN_ChequeAmount"].ToString());
                decimal REFTRN_FinalRefund = decimal.Parse(row["REFTRN_FinalRefund"].ToString());
                string REFTRN_PayMode = row["REFTRN_PayMode"].ToString();
                string REFTRN_ChequeNo = row["REFTRN_ChequeNo"].ToString();
                string REFTRN_ChequeDate = row["REFTRN_ChequeDate"].ToString();
                string BANMST_BankName = row["BANMST_BankName"].ToString();
                list.Add(new ACCRefundTRNList(REFTRN_ID, Appmst_AppNo, APPMST_CustomerID, REFTRN_RefundDate, REFTRN_RefundType, REFTRN_Remarks, REFTRN_ChequeAmount, REFTRN_FinalRefund, REFTRN_PayMode, REFTRN_ChequeNo, REFTRN_ChequeDate, BANMST_BankName, Count));
            }
            return list;
        }

        public ACCRefundTRN GetACCRefundTRN(int ACCRefundTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundTRN_Select " + ACCRefundTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int REFTRN_ID = Convert.ToInt32(row["REFTRN_ID"]);
            decimal REFTRN_ApplicationId = Convert.ToDecimal(row["REFTRN_ApplicationId"]);
            string REFTRN_RefundDate = Convert.ToString(row["REFTRN_RefundDate"]);
            decimal REFTRN_PlanAmount = Convert.ToDecimal(row["REFTRN_PlanAmount"]);
            decimal REFTRN_Deposit = Convert.ToDecimal(row["REFTRN_Deposit"]);
            decimal REFTRN_AmountReceived = Convert.ToDecimal(row["REFTRN_AmountReceived"]);
            decimal REFTRN_Credit = Convert.ToDecimal(row["REFTRN_Credit"]);
            decimal REFTRN_FinalRefund = Convert.ToDecimal(row["REFTRN_FinalRefund"]);
            string REFTRN_Remarks = Convert.ToString(row["REFTRN_Remarks"]);
            int REFTRN_RefundType = Convert.ToInt32(row["REFTRN_RefundType"]);
            decimal REFTRN_BillAccess = Convert.ToDecimal(row["REFTRN_BillAccess"]);
            int REFTRN_PayMode = Convert.ToInt32(row["REFTRN_PayMode"]);
            string REFTRN_ChequeNo = Convert.ToString(row["REFTRN_ChequeNo"]);
            string REFTRN_ChequeDate = Convert.ToString(row["REFTRN_ChequeDate"]);
            decimal REFTRN_ChequeAmount = Convert.ToDecimal(row["REFTRN_ChequeAmount"]);
            int REFTRN_BankId = 0;
            if (row["REFTRN_BankId"] != null)
            {
                REFTRN_BankId = Convert.ToInt32(row["REFTRN_BankId"]);
            }


            decimal REFTRN_ForfeitedAmount = Convert.ToDecimal(row["REFTRN_ForfeitedAmount"]);
            int REFTRN_CreatedByUserID = Convert.ToInt32(row["REFTRN_CreatedByUserID"]);
            string REFTRN_CreatedDateTime = Convert.ToString(row["REFTRN_CreatedDateTime"]);
            int REFTRN_UpdatedByUserID = Convert.ToInt32(row["REFTRN_UpdatedByUserID"]);
            string REFTRN_UpdatedDateTime = Convert.ToString(row["REFTRN_UpdatedDateTime"]);
            int REFTRN_RowStatus = Convert.ToInt32(row["REFTRN_RowStatus"]);
            long REFTRN_RowVersion = (long)row["REFTRN_RowVersion"];

            #endregion

            return new
            ACCRefundTRN(REFTRN_ID, REFTRN_ApplicationId, REFTRN_RefundDate, REFTRN_PlanAmount, REFTRN_Deposit, REFTRN_AmountReceived, REFTRN_Credit, REFTRN_FinalRefund, REFTRN_Remarks, REFTRN_RefundType, REFTRN_BillAccess, REFTRN_PayMode, REFTRN_ChequeNo, REFTRN_ChequeDate, REFTRN_ChequeAmount, REFTRN_BankId, REFTRN_ForfeitedAmount, REFTRN_CreatedByUserID, REFTRN_CreatedDateTime, REFTRN_UpdatedByUserID, REFTRN_UpdatedDateTime, REFTRN_RowStatus, REFTRN_RowVersion);
        }

        public ACCRefundTRNMsg InsertACCRefundTRN(ACCRefundTRN ACCRefundTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundTRN_Insert ");
            sql.Append(ACCRefundTRN.REFTRN_ApplicationId + ",");
            sql.Append("'" + ACCRefundTRN.REFTRN_RefundDate + "',");
            sql.Append(ACCRefundTRN.REFTRN_PlanAmount + ",");
            sql.Append(ACCRefundTRN.REFTRN_Deposit + ",");
            sql.Append(ACCRefundTRN.REFTRN_AmountReceived + ",");
            sql.Append(ACCRefundTRN.REFTRN_Credit + ",");
            sql.Append(ACCRefundTRN.REFTRN_FinalRefund + ",");
            sql.Append("'" + ACCRefundTRN.REFTRN_Remarks + "',");
            sql.Append(ACCRefundTRN.REFTRN_RefundType + ",");
            sql.Append(ACCRefundTRN.REFTRN_BillAccess + ",");
            sql.Append(ACCRefundTRN.REFTRN_PayMode + ",");
            sql.Append("'" + ACCRefundTRN.REFTRN_ChequeNo + "',");
            sql.Append("'" + ACCRefundTRN.REFTRN_ChequeDate + "',");
            sql.Append(ACCRefundTRN.REFTRN_ChequeAmount + ",");
            sql.Append(ACCRefundTRN.REFTRN_BankId + ",");
            sql.Append(ACCRefundTRN.REFTRN_ForfeitedAmount + ",");
            sql.Append(ACCRefundTRN.REFTRN_CreatedByUserID + ",");
            sql.Append(ACCRefundTRN.REFTRN_RowStatus + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCRefundTRNMsg(_RetVal, _RetStr);
        }

        public ACCRefundTRNMsg UpdateACCRefundTRN(ACCRefundTRN ACCRefundTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundTRN_Update ");
            sql.Append(ACCRefundTRN.REFTRN_ID + ",");
            sql.Append(ACCRefundTRN.REFTRN_ApplicationId + ",");
            sql.Append("'" + ACCRefundTRN.REFTRN_RefundDate + "',");
            sql.Append(ACCRefundTRN.REFTRN_PlanAmount + ",");
            sql.Append(ACCRefundTRN.REFTRN_Deposit + ",");
            sql.Append(ACCRefundTRN.REFTRN_AmountReceived + ",");
            sql.Append(ACCRefundTRN.REFTRN_Credit + ",");
            sql.Append(ACCRefundTRN.REFTRN_FinalRefund + ",");
            sql.Append("'" + ACCRefundTRN.REFTRN_Remarks + "',");
            sql.Append(ACCRefundTRN.REFTRN_RefundType + ",");
            sql.Append(ACCRefundTRN.REFTRN_BillAccess + ",");
            sql.Append(ACCRefundTRN.REFTRN_PayMode + ",");
            sql.Append("'" + ACCRefundTRN.REFTRN_ChequeNo + "',");
            sql.Append("'" + ACCRefundTRN.REFTRN_ChequeDate + "',");
            sql.Append(ACCRefundTRN.REFTRN_ChequeAmount + ",");
            sql.Append(ACCRefundTRN.REFTRN_BankId + ",");
            sql.Append(ACCRefundTRN.REFTRN_ForfeitedAmount + ",");
            sql.Append(ACCRefundTRN.REFTRN_UpdatedByUserID + ",");
            sql.Append(ACCRefundTRN.REFTRN_RowStatus + ",");
            sql.Append(ACCRefundTRN.REFTRN_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCRefundTRNMsg(_RetVal, _RetStr);
        }

        public ACCRefundTRNMsg DeleteACCRefundTRN(int ACCRefundTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundTRN_Delete " + ACCRefundTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCRefundTRNMsg(_RetVal, _RetStr);
        }
    }
   
}

