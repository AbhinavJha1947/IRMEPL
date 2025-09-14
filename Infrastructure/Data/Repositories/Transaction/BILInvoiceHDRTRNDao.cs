using Application.RepositoryInterfaces.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Core.Entities.Transaction;
using System.Data;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class BILInvoiceHDRTRNDao : IBILInvoiceHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public BILInvoiceHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILInvoiceHDRTRNList> GetBILInvoiceHDRTRNs()
        {
            string sortExpression = "INVHDR_InvoiceID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILInvoiceHDRTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }
        public IList<BILInvoiceHDRTRNList> GetValidateBills()
        {
            string sortExpression = "INVHDR_InvoiceID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetValidateBills(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<OnlinePaymentDetailsList> GetOnlineTransactions(string fromdate, string toDate, string sortExpression, string sortType, int pageIndex, int pageSize, string btnexport)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_OnlinePaymentDetails ");
            //String Building for Order by Column.
            sql.Append("'" + fromdate + "',");
            sql.Append("'" + toDate + "',");
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'OnlinePay_TransactionDate',");
            }
            else
            {
                sql.Append("'" + sortExpression + "',");
            }
            //String Building for Sorintg Type
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append("'desc',");
            }
            else
            {
                sql.Append("'" + sortType + "',");
            }
            //String Building for Page Index
            sql.Append(pageIndex + ",");
            sql.Append(pageSize + ",");
            sql.Append(btnexport);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = new DataTable();
            int Count = 0;
            if (ds.Tables.Count > 1)
            {

                dtRowCount = ds.Tables[1];
                Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            }
            IList<OnlinePaymentDetailsList> list = new List<OnlinePaymentDetailsList>();
            foreach (DataRow row in dtList.Rows)
            {
                string OnlinePay_ResponseRecieptNo = row["OnlinePay_ResponseRecieptNo"].ToString();
                string OnlinePay_TransRefNo = row["OnlinePay_TransRefNo"].ToString();
                string OnlinePay_BankRefNo = row["OnlinePay_BankRefNo"].ToString();
                string OnlinePay_TransactionAmt = row["OnlinePay_TransactionAmt"].ToString();
                string OnlinePay_BankID = row["OnlinePay_BankID"].ToString();
                string OnlinePay_BankMarchantID = row["OnlinePay_BankMarchantID"].ToString();
                string OnlinePay_AddInfo1RecieptNo = row["OnlinePay_AddInfo1RecieptNo"].ToString();
                string OnlinePay_AddInfo2CustName = row["OnlinePay_AddInfo2CustName"].ToString();
                string OnlinePay_AddInfo3AppNo = row["OnlinePay_AddInfo3AppNo"].ToString();
                string OnlinePay_AddInfo4CenterName = row["OnlinePay_AddInfo4CenterName"].ToString();
                string OnlinePay_AddInfo5RecType = row["OnlinePay_AddInfo5RecType"].ToString();
                string OnlinePay_AddInfo6RecNo = row["OnlinePay_AddInfo6RecNo"].ToString();
                string OnlinePay_AddInfo7InvNo = row["OnlinePay_AddInfo7InvNo"].ToString();
                string OnlinePay_ErrorDescription = row["OnlinePay_ErrorDescription"].ToString();
                string OnlinePay_AuthStatusText = row["OnlinePay_AuthStatusText"].ToString();
                string OnlinePay_TransactionDate = row["OnlinePay_TransactionDate"].ToString();

                //int count = int.Parse(row["Count"].ToString());

                list.Add(new OnlinePaymentDetailsList(OnlinePay_ResponseRecieptNo, OnlinePay_TransRefNo, OnlinePay_BankRefNo,
            OnlinePay_TransactionAmt, OnlinePay_BankID, OnlinePay_BankMarchantID, OnlinePay_AddInfo1RecieptNo,
            OnlinePay_AddInfo2CustName, OnlinePay_AddInfo3AppNo, OnlinePay_AddInfo4CenterName, OnlinePay_AddInfo5RecType,
            OnlinePay_AddInfo6RecNo, OnlinePay_AddInfo7InvNo, OnlinePay_ErrorDescription, OnlinePay_AuthStatusText, OnlinePay_TransactionDate, Count));
            }
            return list;

        }
        public IList<BILInvoiceHDRTRNList> GetBILInvoiceHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'INVHDR_InvoiceID',");
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
            IList<BILInvoiceHDRTRNList> list = new List<BILInvoiceHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int INVHDR_InvoiceID = int.Parse(row["INVHDR_InvoiceID"].ToString());
                string INVHDR_InvNo = row["INVHDR_InvNo"].ToString();
                string BillingCycle = row["BillingCycle"].ToString();
                string Customer_Id = row["Customer_Id"].ToString();
                string Name = row["Name"].ToString();
                decimal INVHDR_ConsumedUnit = decimal.Parse(row["INVHDR_ConsumedUnit"].ToString());
                decimal INVHDR_GasPrice = decimal.Parse(row["INVHDR_GasPrice"].ToString());
                decimal INVHDR_GasAmount = decimal.Parse(row["INVHDR_GasAmount"].ToString());
                decimal INVHDR_MinUnit = decimal.Parse(row["INVHDR_MinUnit"].ToString());
                decimal INVHDR_Mincharges = decimal.Parse(row["INVHDR_Mincharges"].ToString());
                decimal INVHDR_Rent = decimal.Parse(row["INVHDR_Rent"].ToString());
                decimal INVHDR_AMC = decimal.Parse(row["INVHDR_AMC"].ToString());
                decimal RebateAmount = decimal.Parse(row["RebateAmount"].ToString());
                decimal NetTotal = decimal.Parse(row["NetTotal"].ToString());
                decimal RoundOff = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["RoundOff"])))
                    RoundOff = decimal.Parse(row["RoundOff"].ToString());
                decimal Previousbalance = decimal.Parse(row["Previousbalance"].ToString());
                decimal PLatePayment = decimal.Parse(row["PlatePayment"].ToString());
                decimal INVHDR_InstallmentAmount = decimal.Parse(row["INVHDR_InstallmentAmount"].ToString());
                decimal INVHDR_SecurityDeposit = decimal.Parse(row["INVHDR_SecurityDeposit"].ToString());
                decimal INVHDR_DebitNoteAmount = decimal.Parse(row["INVHDR_DebitNoteAmount"].ToString());
                decimal INVHDR_ChequeBounceCharges = decimal.Parse(row["INVHDR_ChequeBounceCharges"].ToString());

                decimal Total_Amt_Due = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["RoundOff"])))
                    Total_Amt_Due = decimal.Parse(row["Total_Amt_Due"].ToString());

                decimal INVHDR_LatePayment1 = decimal.Parse(row["INVHDR_LatePayment1"].ToString());
                decimal INVHDR_LatePayment = decimal.Parse(row["INVHDR_LatePayment"].ToString());
                decimal Total_Amt_Due_Date = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["RoundOff"])))
                    Total_Amt_Due_Date = decimal.Parse(row["Total_Amt_Due_Date"].ToString());
                //decimal Total_Amt_Due_Date = decimal.Parse(row["Total_Amt_Due_Date"].ToString());
                string INVHDR_DueDate = row["INVHDR_DueDate"].ToString();
                decimal INVHDR_RecieptAmount = decimal.Parse(row["INVHDR_RecieptAmount"].ToString());
                decimal INVHDR_ClosingBalance = decimal.Parse(row["INVHDR_ClosingBalance"].ToString());

                DateTime INVHDR_InvDate1 = DateTime.Parse(row["INVHDR_InvDate1"].ToString());
                decimal INVHDR_ApplicationId = decimal.Parse(row["INVHDR_ApplicationId"].ToString());
                decimal INVHDR_CurrentReading = decimal.Parse(row["INVHDR_CurrentReading"].ToString());
                int INVHDR_BillingId = int.Parse(row["INVHDR_BillingId"].ToString());
                decimal INVHDR_RebateQty = decimal.Parse(row["INVHDR_RebateQty"].ToString());
                //int INVHDR_CorporateId = int.Parse(row["INVHDR_CorporateId"].ToString());
                decimal INVHDR_CreditNoteAmount = decimal.Parse(row["INVHDR_CreditNoteAmount"].ToString());
                decimal INVHDR_ReceivedDebitNoteAmount = decimal.Parse(row["INVHDR_ReceivedDebitNoteAmount"].ToString());
                string CenterName = row["CenterName"].ToString();
                int CenterCode = int.Parse(row["CenterCode"].ToString());
                string AppNo = row["AppNo"].ToString();
                string totalreceived = row["totalreceived"].ToString();
                string receiptType = row["receiptType"].ToString();
                string receiptDate = Convert.ToString(row["receiptDate"]);
                int INVHDR_CorporateId = 0;
                decimal INVHDR_RegChargesAmount = decimal.Parse(row["INVHDR_RegChargesAmount"].ToString());
                decimal INVHDR_ReceivedRegChargesAmount = decimal.Parse(row["INVHDR_ReceivedRegChargesAmount"].ToString());
                int INVHDR_GeneratedFrom = int.Parse(row["INVHDR_GeneratedFrom"].ToString());
                string INVHDR_GeneratedFromText = row["INVHDR_GeneratedFromText"].ToString();

                list.Add(new BILInvoiceHDRTRNList(INVHDR_InvoiceID, INVHDR_InvNo, BillingCycle,
                Customer_Id, Name, INVHDR_ConsumedUnit, INVHDR_GasPrice,
                INVHDR_GasAmount, INVHDR_MinUnit, INVHDR_Mincharges, INVHDR_Rent,
                INVHDR_AMC, RebateAmount, NetTotal, RoundOff, Previousbalance,
                PLatePayment, INVHDR_InstallmentAmount, INVHDR_SecurityDeposit,
                INVHDR_DebitNoteAmount, INVHDR_ChequeBounceCharges, Total_Amt_Due, INVHDR_LatePayment1, INVHDR_LatePayment,
                Total_Amt_Due_Date, INVHDR_DueDate, INVHDR_RecieptAmount,
                INVHDR_ClosingBalance, INVHDR_InvDate1, INVHDR_ApplicationId,
                INVHDR_CurrentReading, INVHDR_BillingId, INVHDR_RebateQty, INVHDR_CorporateId, INVHDR_CreditNoteAmount, INVHDR_ReceivedDebitNoteAmount,
                CenterName, CenterCode, AppNo, Count, totalreceived, receiptType, receiptDate, INVHDR_RegChargesAmount, INVHDR_ReceivedRegChargesAmount, INVHDR_GeneratedFrom, INVHDR_GeneratedFromText));
            }
            return list;
        }
        public IList<BILInvoiceHDRTRNListHistory> GetBILInvoiceHDRTRNsForHistory(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_SelectAll_ForLog ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'INVHDR_InvoiceID',");
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
            IList<BILInvoiceHDRTRNListHistory> list = new List<BILInvoiceHDRTRNListHistory>();
            foreach (DataRow row in dtList.Rows)
            {
                int INVHDR_InvoiceID = int.Parse(row["INVHDR_InvoiceID"].ToString());
                string INVHDR_InvNo = row["INVHDR_InvNo"].ToString();
                string BillingCycle = row["BillingCycle"].ToString();
                string Customer_Id = row["Customer_Id"].ToString();
                string Name = row["Name"].ToString();
                decimal INVHDR_ConsumedUnit = decimal.Parse(row["INVHDR_ConsumedUnit"].ToString());
                decimal INVHDR_GasPrice = decimal.Parse(row["INVHDR_GasPrice"].ToString());
                decimal INVHDR_GasAmount = decimal.Parse(row["INVHDR_GasAmount"].ToString());
                decimal INVHDR_MinUnit = decimal.Parse(row["INVHDR_MinUnit"].ToString());
                decimal INVHDR_Mincharges = decimal.Parse(row["INVHDR_Mincharges"].ToString());
                decimal INVHDR_Rent = decimal.Parse(row["INVHDR_Rent"].ToString());
                decimal INVHDR_AMC = decimal.Parse(row["INVHDR_AMC"].ToString());
                decimal RebateAmount = decimal.Parse(row["RebateAmount"].ToString());
                decimal NetTotal = decimal.Parse(row["NetTotal"].ToString());
                decimal RoundOff = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["RoundOff"])))
                    RoundOff = decimal.Parse(row["RoundOff"].ToString());
                decimal Previousbalance = decimal.Parse(row["Previousbalance"].ToString());
                decimal PLatePayment = decimal.Parse(row["PlatePayment"].ToString());
                decimal INVHDR_InstallmentAmount = decimal.Parse(row["INVHDR_InstallmentAmount"].ToString());
                decimal INVHDR_SecurityDeposit = decimal.Parse(row["INVHDR_SecurityDeposit"].ToString());
                decimal INVHDR_DebitNoteAmount = decimal.Parse(row["INVHDR_DebitNoteAmount"].ToString());
                decimal INVHDR_ChequeBounceCharges = decimal.Parse(row["INVHDR_ChequeBounceCharges"].ToString());

                decimal Total_Amt_Due = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["RoundOff"])))
                    Total_Amt_Due = decimal.Parse(row["Total_Amt_Due"].ToString());

                decimal INVHDR_LatePayment1 = decimal.Parse(row["INVHDR_LatePayment1"].ToString());
                decimal INVHDR_LatePayment = decimal.Parse(row["INVHDR_LatePayment"].ToString());
                decimal Total_Amt_Due_Date = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["RoundOff"])))
                    Total_Amt_Due_Date = decimal.Parse(row["Total_Amt_Due_Date"].ToString());
                //decimal Total_Amt_Due_Date = decimal.Parse(row["Total_Amt_Due_Date"].ToString());
                string INVHDR_DueDate = row["INVHDR_DueDate"].ToString();
                decimal INVHDR_RecieptAmount = decimal.Parse(row["INVHDR_RecieptAmount"].ToString());
                decimal INVHDR_ClosingBalance = decimal.Parse(row["INVHDR_ClosingBalance"].ToString());

                DateTime INVHDR_InvDate1 = DateTime.Parse(row["INVHDR_InvDate1"].ToString());
                decimal INVHDR_ApplicationId = decimal.Parse(row["INVHDR_ApplicationId"].ToString());
                decimal INVHDR_CurrentReading = decimal.Parse(row["INVHDR_CurrentReading"].ToString());
                int INVHDR_BillingId = int.Parse(row["INVHDR_BillingId"].ToString());
                decimal INVHDR_RebateQty = decimal.Parse(row["INVHDR_RebateQty"].ToString());
                //int INVHDR_CorporateId = int.Parse(row["INVHDR_CorporateId"].ToString());
                decimal INVHDR_CreditNoteAmount = decimal.Parse(row["INVHDR_CreditNoteAmount"].ToString());
                decimal INVHDR_ReceivedDebitNoteAmount = decimal.Parse(row["INVHDR_ReceivedDebitNoteAmount"].ToString());
                string CenterName = row["CenterName"].ToString();
                int CenterCode = int.Parse(row["CenterCode"].ToString());
                string AppNo = row["AppNo"].ToString();
                string totalreceived = row["totalreceived"].ToString();
                string receiptType = row["receiptType"].ToString();
                string receiptDate = Convert.ToString(row["receiptDate"]);
                int INVHDR_CorporateId = 0;
                decimal INVHDR_RegChargesAmount = decimal.Parse(row["INVHDR_RegChargesAmount"].ToString());
                decimal INVHDR_ReceivedRegChargesAmount = decimal.Parse(row["INVHDR_ReceivedRegChargesAmount"].ToString());
                string INVHDR_CreatedDateTime = row["INVHDR_CreatedDateTime"].ToString();
                string INVHDR_DeleteDateTime = row["INVHDR_DeleteDateTime"].ToString();
                int INVHDR_LogID = int.Parse(row["INVHDR_LogID"].ToString());

                list.Add(new BILInvoiceHDRTRNListHistory(INVHDR_InvoiceID, INVHDR_InvNo, BillingCycle,
                Customer_Id, Name, INVHDR_ConsumedUnit, INVHDR_GasPrice,
                INVHDR_GasAmount, INVHDR_MinUnit, INVHDR_Mincharges, INVHDR_Rent,
                INVHDR_AMC, RebateAmount, NetTotal, RoundOff, Previousbalance,
                PLatePayment, INVHDR_InstallmentAmount, INVHDR_SecurityDeposit,
                INVHDR_DebitNoteAmount, INVHDR_ChequeBounceCharges, Total_Amt_Due, INVHDR_LatePayment1, INVHDR_LatePayment,
                Total_Amt_Due_Date, INVHDR_DueDate, INVHDR_RecieptAmount,
                INVHDR_ClosingBalance, INVHDR_InvDate1, INVHDR_ApplicationId,
                INVHDR_CurrentReading, INVHDR_BillingId, INVHDR_RebateQty, INVHDR_CorporateId, INVHDR_CreditNoteAmount, INVHDR_ReceivedDebitNoteAmount,
                CenterName, CenterCode, AppNo, Count, totalreceived, receiptType, receiptDate, INVHDR_RegChargesAmount, INVHDR_ReceivedRegChargesAmount,
                INVHDR_CreatedDateTime, INVHDR_DeleteDateTime, INVHDR_LogID));
            }
            return list;
        }
        public IList<BILInvoiceAdvanceHistoryList> GetBILInvoiceAdvanceHistory(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, string Billtype)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_log_History_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'[CustomerID]',");
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
            sql.Append(criteria + "','");
            sql.Append(Billtype + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILInvoiceAdvanceHistoryList> list = new List<BILInvoiceAdvanceHistoryList>();
            foreach (DataRow row in dtList.Rows)
            {
                int Row = int.Parse(row["srno"].ToString());
                int INVHDR_LogID = 0;//int.Parse(row["INVHDR_LogID"].ToString());
                string type = Convert.ToString(row["BillType"]);
                int OriginalLogID = Convert.ToInt32(row["OriginalLogID"]);
                int RevisedLogID = Convert.ToInt32(row["RevisedLogID"].ToString());
                int OriginalInvoiceID = Convert.ToInt32(row["OriginalInvoiceID"]);
                int RevisedInvoiceID = Convert.ToInt32(row["RevisedInvoiceID"]);
                string OriginalINVfrom = row["OriginalINVfrom"].ToString();
                string RevisedInvFrom = row["RevisedInvFrom"].ToString();
                string INVHDR_DeleteDateTime = row["LogDeletedDate"].ToString();
                string CreatedDateTime = row["INVCreatedDate"].ToString();
                string CustomerID = row["CustomerID"].ToString();
                string AppNo = row["AppNo"].ToString();
                string OriginalInvNo = row["OriginalInvNo"].ToString();
                string revisedInvNo = row["revisedInvNo"].ToString();
                string OriginalInvDate = row["OriginalInvDate"].ToString();
                string revisedInvDate = row["revisedInvDate"].ToString();
                string BillingCycle = row["BillingCycle"].ToString();
                string ReasonforRevisionOfInvoice = Convert.ToString(row["reason"]);
                string CUoriginalInvoice = Convert.ToString(row["CUofOriginalINV"]);
                string CUrevisedinvoice = Convert.ToString(row["CUofRevisedINV"]);
                string DifferentialUnit = Convert.ToString(row["CUdiff"]);
                string PNGSalesAMTperOriginalInvoice = Convert.ToString(row["PNGSalesAmtofOrignal"]);
                string PNGSalesAMTperrevisedInvoice = Convert.ToString(row["PNGSalesAmtofrevised"]);
                string DifferentialPNGSalesAMT = Convert.ToString(row["PNGsalesAmtDiff"]);
                string ChangeinInstallmentAmount = Convert.ToString(row["InsatllmentDiff"]);
                string ChangeinLPC = Convert.ToString(row["LPDiff"]);
                string ChangeinAMC = Convert.ToString(row["AMCDiff"]);
                string ChangeinCBC = Convert.ToString(row["CBCDiff"]);
                string TotalChangeinInvoice = Convert.ToString(row["CurrentCharges"]);
                string RentDiff = Convert.ToString(row["RentDiff"]);
                string MinChargesDiff = Convert.ToString(row["MinChargesDiff"]);
                string DebitNoteDiff = Convert.ToString(row["DebitNoteDiff"]);
                string VATDiff = Convert.ToString(row["VATDiff"]);
                string GSTDiff = Convert.ToString(row["GSTDiff"]);

                list.Add(new BILInvoiceAdvanceHistoryList(Row, INVHDR_LogID, type, OriginalLogID, RevisedLogID, OriginalInvoiceID, RevisedInvoiceID, OriginalINVfrom, RevisedInvFrom, INVHDR_DeleteDateTime, CreatedDateTime, CustomerID, AppNo, OriginalInvNo, revisedInvNo, OriginalInvDate, revisedInvDate, BillingCycle,
                ReasonforRevisionOfInvoice, CUoriginalInvoice, CUrevisedinvoice, DifferentialUnit, PNGSalesAMTperOriginalInvoice, PNGSalesAMTperrevisedInvoice, DifferentialPNGSalesAMT,
                ChangeinInstallmentAmount, ChangeinLPC, ChangeinAMC, ChangeinCBC, TotalChangeinInvoice, RentDiff, MinChargesDiff, DebitNoteDiff, VATDiff, GSTDiff, Count));
            }
            return list;
        }
        public IList<BILInvoiceHDRTRNList> GetValidateBills(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ValidateBill_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'INVHDR_InvoiceID',");
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
            IList<BILInvoiceHDRTRNList> list = new List<BILInvoiceHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int INVHDR_InvoiceID = int.Parse(row["INVHDR_InvoiceID"].ToString());
                string INVHDR_InvNo = row["INVHDR_InvNo"].ToString();
                string BillingCycle = row["BillingCycle"].ToString();
                string Customer_Id = row["Customer_Id"].ToString();
                string Name = row["Name"].ToString();
                decimal INVHDR_ConsumedUnit = decimal.Parse(row["INVHDR_ConsumedUnit"].ToString());
                decimal INVHDR_GasPrice = decimal.Parse(row["INVHDR_GasPrice"].ToString());
                decimal INVHDR_GasAmount = decimal.Parse(row["INVHDR_GasAmount"].ToString());
                decimal INVHDR_MinUnit = decimal.Parse(row["INVHDR_MinUnit"].ToString());
                decimal INVHDR_Mincharges = decimal.Parse(row["INVHDR_Mincharges"].ToString());
                decimal INVHDR_Rent = decimal.Parse(row["INVHDR_Rent"].ToString());
                decimal INVHDR_AMC = decimal.Parse(row["INVHDR_AMC"].ToString());
                decimal RebateAmount = decimal.Parse(row["RebateAmount"].ToString());
                decimal NetTotal = decimal.Parse(row["NetTotal"].ToString());
                decimal RoundOff = decimal.Parse(row["RoundOff"].ToString());
                decimal Previousbalance = decimal.Parse(row["Previousbalance"].ToString());
                decimal PLatePayment = decimal.Parse(row["PlatePayment"].ToString());
                decimal INVHDR_InstallmentAmount = decimal.Parse(row["INVHDR_InstallmentAmount"].ToString());
                decimal INVHDR_SecurityDeposit = decimal.Parse(row["INVHDR_SecurityDeposit"].ToString());
                decimal INVHDR_DebitNoteAmount = decimal.Parse(row["INVHDR_DebitNoteAmount"].ToString());
                decimal INVHDR_ChequeBounceCharges = decimal.Parse(row["INVHDR_ChequeBounceCharges"].ToString());
                decimal Total_Amt_Due = decimal.Parse(row["Total_Amt_Due"].ToString());
                decimal INVHDR_LatePayment1 = decimal.Parse(row["INVHDR_LatePayment1"].ToString());
                decimal INVHDR_LatePayment = decimal.Parse(row["INVHDR_LatePayment"].ToString());
                decimal Total_Amt_Due_Date = decimal.Parse(row["Total_Amt_Due_Date"].ToString());
                string INVHDR_DueDate = row["INVHDR_DueDate"].ToString();
                decimal INVHDR_RecieptAmount = decimal.Parse(row["INVHDR_RecieptAmount"].ToString());
                decimal INVHDR_ClosingBalance = decimal.Parse(row["INVHDR_ClosingBalance"].ToString());

                DateTime INVHDR_InvDate1 = DateTime.Parse(row["INVHDR_InvDate1"].ToString());
                decimal INVHDR_ApplicationId = decimal.Parse(row["INVHDR_ApplicationId"].ToString());
                decimal INVHDR_CurrentReading = decimal.Parse(row["INVHDR_CurrentReading"].ToString());
                int INVHDR_BillingId = int.Parse(row["INVHDR_BillingId"].ToString());
                decimal INVHDR_RebateQty = decimal.Parse(row["INVHDR_RebateQty"].ToString());
                //int INVHDR_CorporateId = int.Parse(row["INVHDR_CorporateId"].ToString());
                decimal INVHDR_CreditNoteAmount = decimal.Parse(row["INVHDR_CreditNoteAmount"].ToString());
                decimal INVHDR_ReceivedDebitNoteAmount = decimal.Parse(row["INVHDR_ReceivedDebitNoteAmount"].ToString());
                string CenterName = row["CenterName"].ToString();
                int CenterCode = int.Parse(row["CenterCode"].ToString());
                string AppNo = row["AppNo"].ToString();
                string totalreceived = row["totalreceived"].ToString();
                string receiptType = row["receiptType"].ToString();
                int INVHDR_CorporateId = 0;
                int INVHDR_GeneratedFrom = 0; // change SP and get value
                string INVHDR_GeneratedFromText = "";

                decimal INVHDR_RegChargesAmount = decimal.Parse(row["INVHDR_RegChargesAmount"].ToString());
                decimal INVHDR_ReceivedRegChargesAmount = decimal.Parse(row["INVHDR_ReceivedRegChargesAmount"].ToString());

                list.Add(new BILInvoiceHDRTRNList(INVHDR_InvoiceID, INVHDR_InvNo, BillingCycle,
                Customer_Id, Name, INVHDR_ConsumedUnit, INVHDR_GasPrice,
                INVHDR_GasAmount, INVHDR_MinUnit, INVHDR_Mincharges, INVHDR_Rent,
                INVHDR_AMC, RebateAmount, NetTotal, RoundOff, Previousbalance,
                PLatePayment, INVHDR_InstallmentAmount, INVHDR_SecurityDeposit,
                INVHDR_DebitNoteAmount, INVHDR_ChequeBounceCharges, Total_Amt_Due, INVHDR_LatePayment1, INVHDR_LatePayment,
                Total_Amt_Due_Date, INVHDR_DueDate, INVHDR_RecieptAmount,
                INVHDR_ClosingBalance, INVHDR_InvDate1, INVHDR_ApplicationId,
                INVHDR_CurrentReading, INVHDR_BillingId, INVHDR_RebateQty, INVHDR_CorporateId, INVHDR_CreditNoteAmount, INVHDR_ReceivedDebitNoteAmount,
                CenterName, CenterCode, AppNo, Count, totalreceived, receiptType, "", INVHDR_RegChargesAmount, INVHDR_ReceivedRegChargesAmount, INVHDR_GeneratedFrom, INVHDR_GeneratedFromText));
            }
            return list;
        }

        public BILInvoiceHDRTRN GetBILInvoiceHDRTRN(int BILInvoiceHDRTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Select " + BILInvoiceHDRTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int INVHDR_InvoiceID = Convert.ToInt32(row["INVHDR_InvoiceID"]);
            string INVHDR_InvNo = row["INVHDR_InvNo"].ToString();
            string INVHDR_InvDate = Convert.ToString(row["INVHDR_InvDate"]);
            int INVHDR_ApplicationId = Convert.ToInt32(row["INVHDR_ApplicationId"]);
            int INVHDR_BillingId = Convert.ToInt32(row["INVHDR_BillingId"]);
            int INVHDR_PlanId = Convert.ToInt32(row["INVHDR_PlanId"]);
            long INVHDR_MeterNo = Convert.ToInt64(row["INVHDR_MeterNo"]);
            decimal INVHDR_CurrentReading = Convert.ToDecimal(row["INVHDR_CurrentReading"]);
            decimal INVHDR_PreviousReading = Convert.ToDecimal(row["INVHDR_PreviousReading"]);
            decimal INVHDR_RebateQty = Convert.ToDecimal(row["INVHDR_RebateQty"]);
            decimal INVHDR_ConsumedUnit = Convert.ToDecimal(row["INVHDR_ConsumedUnit"]);
            decimal INVHDR_GasAmount = Convert.ToDecimal(row["INVHDR_GasAmount"]);
            decimal INVHDR_MinUnit = Convert.ToDecimal(row["INVHDR_MinUnit"]);
            decimal INVHDR_Mincharges = Convert.ToDecimal(row["INVHDR_Mincharges"]);
            decimal INVHDR_Rent = Convert.ToDecimal(row["INVHDR_Rent"]);
            decimal INVHDR_AMC = Convert.ToDecimal(row["INVHDR_AMC"]);
            decimal INVHDR_RebateAmount = Convert.ToDecimal(row["INVHDR_RebateAmount"]);
            decimal INVHDR_NetTotal = Convert.ToDecimal(row["INVHDR_NetTotal"]);
            decimal INVHDR_PreviousBalance = Convert.ToDecimal(row["INVHDR_PreviousBalance"]);
            decimal INVHDR_PLatePayment = Convert.ToDecimal(row["INVHDR_PLatePayment"]);
            decimal INVHDR_LatePayment = Convert.ToDecimal(row["INVHDR_LatePayment"]);
            decimal INVHDR_RecieptAmount = Convert.ToDecimal(row["INVHDR_RecieptAmount"]);
            decimal INVHDR_ClosingBalance = Convert.ToDecimal(row["INVHDR_ClosingBalance"]);
            decimal INVHDR_InstallmentAmount = Convert.ToDecimal(row["INVHDR_InstallmentAmount"]);
            decimal INVHDR_DebitNoteAmount = Convert.ToDecimal(row["INVHDR_DebitNoteAmount"]);
            decimal INVHDR_SecurityDeposit = Convert.ToDecimal(row["INVHDR_SecurityDeposit"]);
            decimal INVHDR_ChequeBounceCharges = Convert.ToDecimal(row["INVHDR_ChequeBounceCharges"]);
            string INVHDR_AmountinWords = Convert.ToString(row["INVHDR_AmountinWords"]);
            int INVHDR_CustomerType = Convert.ToInt32(row["INVHDR_CustomerType"]);
            int INVHDR_CreatedByUserID = Convert.ToInt32(row["INVHDR_CreatedByUserID"]);
            string INVHDR_CreatedDateTime = Convert.ToString(row["INVHDR_CreatedDateTime"]);
            int INVHDR_UpdatedByUserID = Convert.ToInt32(row["INVHDR_UpdatedByUserID"]);
            string INVHDR_UpdatedDateTime = Convert.ToString(row["INVHDR_UpdatedDateTime"]);
            int INVHDR_RowStatus = Convert.ToInt32(row["INVHDR_RowStatus"]);
            long INVHDR_RowVersion = (long)row["INVHDR_RowVersion"];

            #endregion

            return new
            BILInvoiceHDRTRN(INVHDR_InvoiceID, INVHDR_InvNo, INVHDR_InvDate, INVHDR_ApplicationId, INVHDR_BillingId, INVHDR_PlanId, INVHDR_MeterNo, INVHDR_CurrentReading, INVHDR_PreviousReading, INVHDR_RebateQty, INVHDR_ConsumedUnit, INVHDR_GasAmount, INVHDR_MinUnit, INVHDR_Mincharges, INVHDR_Rent, INVHDR_AMC, INVHDR_RebateAmount, INVHDR_NetTotal, INVHDR_PreviousBalance, INVHDR_PLatePayment, INVHDR_LatePayment, INVHDR_RecieptAmount, INVHDR_ClosingBalance, INVHDR_InstallmentAmount, INVHDR_DebitNoteAmount, INVHDR_SecurityDeposit, INVHDR_ChequeBounceCharges, INVHDR_AmountinWords, INVHDR_CustomerType, INVHDR_CreatedByUserID, INVHDR_CreatedDateTime, INVHDR_UpdatedByUserID, INVHDR_UpdatedDateTime, INVHDR_RowStatus, INVHDR_RowVersion);
        }

        public BILInvoiceHDRTRNMsg InsertBILInvoiceHDRTRN(BILInvoiceHDRTRN_Insert BILInvoiceHDRTRN_Insert, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Insert ");
            sql.Append(BILInvoiceHDRTRN_Insert.INVHDR_BillingId + ",");
            sql.Append("N'" + BILInvoiceHDRTRN_Insert.INVHDR_CustomerId + "',");
            sql.Append(BILInvoiceHDRTRN_Insert.INVHDR_AreaCode + ",");
            sql.Append("N'" + BILInvoiceHDRTRN_Insert.INVHDR_InvDate + "',");
            sql.Append(BILInvoiceHDRTRN_Insert.INVHDR_CreatedByUserID + ",");
            sql.Append("N'" + BILInvoiceHDRTRN_Insert.INVHDR_CreatedDateTime + "',");
            sql.Append(BILInvoiceHDRTRN_Insert.INVHDR_SMSFlag + ",");
            sql.Append("0,0," + BILInvoiceHDRTRN_Insert.blnGetOutput + ",");
            sql.Append(BILInvoiceHDRTRN_Insert.INVHDR_GeneratedFrom);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public bool checkShouldRegenerate(int binvoiceid, int userID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ValidateBILInvoiceHDRTRN_Insert_Regenerate_WithSameGasPrice ");
            sql.Append(binvoiceid + ",");
            sql.Append(userID);

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            if (dtList.Rows.Count > 1)
                return true;
            else
                return false;
        }

        public OnlinePaymentDetailsMsg InsertOnlinePaymentDetails(OnlinePaymentDetails objOnlinePaymentDetails, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_OnlinePaymentDetails_Insert ");
            // sql.Append(objOnlinePaymentDetails.OnlinePay_ID + ",");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_ResponseRecieptNo + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_TransRefNo + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_BankRefNo + "',");
            sql.Append(objOnlinePaymentDetails.OnlinePay_TransactionAmt + ",");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_BankID + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_BankMarchantID + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_TrnxType + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_CurName + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_ItemCode + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_SecurityType + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_SecurityID + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_Password + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_TransactionDate + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AuthStatus + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_SettlementType + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo1RecieptNo + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo2CustName + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo3AppNo + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo4CenterName + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo5RecType + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo6RecNo + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AddInfo7InvNo + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_ErrorStatus + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_ErrorDescription + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_Response + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_Request + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_FromWhichPage + "',");
            sql.Append("N'" + objOnlinePaymentDetails.OnlinePay_AuthStatusText + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new OnlinePaymentDetailsMsg(_RetVal, _RetStr);
        }

        public OnlineRequestResponseLogMsg InsertOnlineRequestResponseLog(OnlineRequestResponseLog objOnlineRequestResponseLog)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_OnlineRequestResponseLog_Insert ");
            // sql.Append(objOnlinePaymentDetails.OnlinePay_ID + ",");
            sql.Append("N'" + objOnlineRequestResponseLog.RR_CUSTID + "',");
            sql.Append("N'" + objOnlineRequestResponseLog.RR_ReceiptNo + "',");
            sql.Append(objOnlineRequestResponseLog.RR_TransactionAmt + ",");
            //sql.Append("N'" + objOnlineRequestResponseLog.RR_REQ_Date + "',");
            sql.Append("N'" + objOnlineRequestResponseLog.RR_REQ_string + "'");


            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion
            return new OnlineRequestResponseLogMsg(_RetVal, _RetStr);
        }

        public OnlineRequestResponseLogMsg UpdateOnlineRequestResponseLog(OnlineRequestResponseLog objOnlineRequestResponseLog)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_OnlineRequestResponseLog_Update ");
            sql.Append("N'" + objOnlineRequestResponseLog.RR_REQ_string + "',");
            sql.Append("N'" + objOnlineRequestResponseLog.RR_RES_String + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion
            return new OnlineRequestResponseLogMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg InsertBILInvoiceHDRTRN_Regenerate(int INVHDR_InvoiceID, int INVHDR_CreatedByUserID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Insert_Regenerate ");
            sql.Append(INVHDR_InvoiceID + ",");
            sql.Append(INVHDR_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg USP_GenerateReceiptNo(int centerCode, string RECHDR_Date, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_GenerateReceiptNo ");
            sql.Append(centerCode + ",'");
            sql.Append(RECHDR_Date + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg USP_GenerateReceiptNo_forBilldesk()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BilldeskReceiptNOGenerate ");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = 0;
            string _RetStr = Convert.ToString(row["BildeskReceiptNo"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg GetTariffMessageForBill(int INVHDR_BillingId, string INVHDR_CustomerId, int INVHDR_AreaCode, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_GetTariffMessageForBill ");
            sql.Append(INVHDR_BillingId + ",");
            sql.Append("'" + INVHDR_CustomerId + "',");
            sql.Append(INVHDR_AreaCode);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg InsertBILInvoiceHDRTRN_Regenerate_WithSameGasPrice(int INVHDR_InvoiceID, int INVHDR_CreatedByUserID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Insert_Regenerate_WithSameGasPrice ");
            sql.Append(INVHDR_InvoiceID + ",");
            sql.Append(INVHDR_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg InsertBILInvoiceHDRTRN_Old(BILInvoiceHDRTRN BILInvoiceHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Insert ");
            sql.Append(BILInvoiceHDRTRN.INVHDR_InvNo + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_InvDate + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ApplicationId + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_BillingId + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PlanId + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_MeterNo + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_CurrentReading + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PreviousReading + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RebateQty + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ConsumedUnit + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_GasAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_MinUnit + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_Mincharges + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_Rent + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_AMC + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RebateAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_NetTotal + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PreviousBalance + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PLatePayment + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_LatePayment + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RecieptAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ClosingBalance + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_InstallmentAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_DebitNoteAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_SecurityDeposit + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ChequeBounceCharges + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_AmountinWords + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_CustomerType + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_CreatedByUserID + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_CreatedDateTime + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_UpdatedByUserID + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_UpdatedDateTime + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RowStatus + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg UpdateBILInvoiceHDRTRN(BILInvoiceHDRTRN BILInvoiceHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Update ");
            sql.Append(BILInvoiceHDRTRN.INVHDR_InvoiceID + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_InvNo + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_InvDate + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ApplicationId + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_BillingId + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PlanId + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_MeterNo + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_CurrentReading + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PreviousReading + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RebateQty + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ConsumedUnit + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_GasAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_MinUnit + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_Mincharges + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_Rent + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_AMC + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RebateAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_NetTotal + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PreviousBalance + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_PLatePayment + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_LatePayment + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RecieptAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ClosingBalance + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_InstallmentAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_DebitNoteAmount + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_SecurityDeposit + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ChequeBounceCharges + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_AmountinWords + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_CustomerType + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_CreatedByUserID + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_CreatedDateTime + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_UpdatedByUserID + ",");
            sql.Append("N'" + BILInvoiceHDRTRN.INVHDR_UpdatedDateTime + "',");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RowStatus + ",");
            sql.Append(BILInvoiceHDRTRN.INVHDR_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg DeleteBILInvoiceHDRTRN(int BILInvoiceHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Delete " + BILInvoiceHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg BILInvoiceHDRTRN_GetPerUnitCharge(BILInvoiceHDRTRN_GetPerUnitCharge BILInvoiceHDRTRN_GetPerUnitCharge)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_GetPerUnitCharge] ");
            sql.Append(BILInvoiceHDRTRN_GetPerUnitCharge.CenCode + ",");
            sql.Append(BILInvoiceHDRTRN_GetPerUnitCharge.APPMST_AppID + ",");
            sql.Append(BILInvoiceHDRTRN_GetPerUnitCharge.BCCMST_BillingID);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg BILInvoiceHDRTRN_ReceiptExists(int INVHDR_InvoiceID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_ReceiptExists] ");
            sql.Append(INVHDR_InvoiceID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg BILInvoiceHDRTRN_FirstReceiptDate(int INVHDR_InvoiceID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_FirstReceiptDate] ");
            sql.Append(INVHDR_InvoiceID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public BILInvoiceHDRTRNMsg BILInvoiceHDRTRN_GetCount(int BillingId, int Areacode, string UserID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_GetBillCount] ");
            sql.Append("'" + BillingId + "','");
            sql.Append(Areacode + "','");
            sql.Append(UserID + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public decimal BILInvoiceHDRTRN_GetLatePayment(Int64 INVHDR_InvoiceID, string BillDate, string RecDate)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_GetLatePayment] ");
            sql.Append(INVHDR_InvoiceID + ",'");
            sql.Append(BillDate + "','");
            sql.Append(RecDate + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            return Convert.ToDecimal(row["LatePayment"]);
        }

        public decimal BILInvoiceHDRTRN_GetLateDebitNote(Int64 INVHDR_ApplicationId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_GetLateDebitNote] ");
            sql.Append(INVHDR_ApplicationId + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            return Convert.ToDecimal(row["INVHDR_DebitNoteAmount"]);
        }

        public BILInvoiceHDRTRNMsg BILInvoiceHDRTRN_ByReceiptNo(int ReceiptNo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_ByReceiptNo] ");
            sql.Append(ReceiptNo);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            string _DtRowVal1 = Convert.ToString(row["INVHDR_InvoiceID"]);
            string _DtRowVal2 = Convert.ToString(row["INVHDR_InvNo"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr, _DtRowVal1, _DtRowVal2);
        }
        public BILInvoiceHDRTRNMsg InsertBILInvoiceHDRTRN_Corp(BILInvoiceHDRTRN BILInvoiceHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_Corporate_Insert] ");
            sql.Append(BILInvoiceHDRTRN.INVHDR_ApplicationId + ",");

            sql.Append(BILInvoiceHDRTRN.INVHDR_BillingId);

            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public IList<BILInvoiceHDRTRNList> GetBILInvoiceHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, int IScorp)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILInvoiceHDRTRN_Summary_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'INVHDR_InvoiceID',");
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
            IList<BILInvoiceHDRTRNList> list = new List<BILInvoiceHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int INVHDR_InvoiceID = int.Parse(row["INVHDR_InvoiceID"].ToString());
                string INVHDR_InvNo = row["INVHDR_InvNo"].ToString();
                string BillingCycle = row["BillingCycle"].ToString();
                string Customer_Id = row["Customer_Id"].ToString();
                string Name = row["Name"].ToString();
                decimal INVHDR_ConsumedUnit = decimal.Parse(row["INVHDR_ConsumedUnit"].ToString());
                decimal INVHDR_GasPrice = decimal.Parse(row["INVHDR_GasPrice"].ToString());
                decimal INVHDR_GasAmount = decimal.Parse(row["INVHDR_GasAmount"].ToString());
                decimal INVHDR_MinUnit = decimal.Parse(row["INVHDR_MinUnit"].ToString());
                decimal INVHDR_Mincharges = decimal.Parse(row["INVHDR_Mincharges"].ToString());
                decimal INVHDR_Rent = decimal.Parse(row["INVHDR_Rent"].ToString());
                decimal INVHDR_AMC = decimal.Parse(row["INVHDR_AMC"].ToString());
                decimal RebateAmount = decimal.Parse(row["RebateAmount"].ToString());
                decimal NetTotal = decimal.Parse(row["NetTotal"].ToString());
                decimal RoundOff = decimal.Parse(row["RoundOff"].ToString());
                decimal Previousbalance = decimal.Parse(row["Previousbalance"].ToString());
                decimal PLatePayment = decimal.Parse(row["PlatePayment"].ToString());
                decimal INVHDR_InstallmentAmount = decimal.Parse(row["INVHDR_InstallmentAmount"].ToString());
                decimal INVHDR_SecurityDeposit = decimal.Parse(row["INVHDR_SecurityDeposit"].ToString());
                decimal INVHDR_DebitNoteAmount = decimal.Parse(row["INVHDR_DebitNoteAmount"].ToString());
                decimal INVHDR_ChequeBounceCharges = decimal.Parse(row["INVHDR_ChequeBounceCharges"].ToString());
                decimal Total_Amt_Due = decimal.Parse(row["Total_Amt_Due"].ToString());
                decimal INVHDR_LatePayment1 = decimal.Parse(row["INVHDR_LatePayment1"].ToString());
                decimal INVHDR_LatePayment = decimal.Parse(row["INVHDR_LatePayment"].ToString());
                decimal Total_Amt_Due_Date = decimal.Parse(row["Total_Amt_Due_Date"].ToString());
                string INVHDR_DueDate = row["INVHDR_DueDate"].ToString();
                decimal INVHDR_RecieptAmount = decimal.Parse(row["INVHDR_RecieptAmount"].ToString());
                decimal INVHDR_ClosingBalance = decimal.Parse(row["INVHDR_ClosingBalance"].ToString());

                DateTime INVHDR_InvDate1 = DateTime.Parse(row["INVHDR_InvDate1"].ToString());
                decimal INVHDR_ApplicationId = decimal.Parse(row["INVHDR_ApplicationId"].ToString());
                decimal INVHDR_CurrentReading = decimal.Parse(row["INVHDR_CurrentReading"].ToString());
                int INVHDR_BillingId = int.Parse(row["INVHDR_BillingId"].ToString());
                decimal INVHDR_RebateQty = decimal.Parse(row["INVHDR_RebateQty"].ToString());
                int INVHDR_CorporateId = int.Parse(row["INVHDR_CorporateId"].ToString());
                decimal INVHDR_CreditNoteAmount = decimal.Parse(row["INVHDR_CreditNoteAmount"].ToString());
                decimal INVHDR_ReceivedDebitNoteAmount = decimal.Parse(row["INVHDR_ReceivedDebitNoteAmount"].ToString());
                string CenterName = row["CenterName"].ToString();
                int CenterCode = int.Parse(row["CenterCode"].ToString());
                string AppNo = row["AppNo"].ToString();
                string totalreceived = row["totalreceived"].ToString();
                string receiptType = row["receiptType"].ToString();

                decimal INVHDR_RegChargesAmount = decimal.Parse(row["INVHDR_RegChargesAmount"].ToString());
                decimal INVHDR_ReceivedRegChargesAmount = decimal.Parse(row["INVHDR_ReceivedRegChargesAmount"].ToString());

                int INVHDR_GeneratedFrom = 0;
                string INVHDR_GeneratedFromText = "";

                list.Add(new BILInvoiceHDRTRNList(INVHDR_InvoiceID, INVHDR_InvNo, BillingCycle,
                Customer_Id, Name, INVHDR_ConsumedUnit, INVHDR_GasPrice,
                INVHDR_GasAmount, INVHDR_MinUnit, INVHDR_Mincharges, INVHDR_Rent,
                INVHDR_AMC, RebateAmount, NetTotal, RoundOff, Previousbalance,
                PLatePayment, INVHDR_InstallmentAmount, INVHDR_SecurityDeposit,
                INVHDR_DebitNoteAmount, INVHDR_ChequeBounceCharges, Total_Amt_Due, INVHDR_LatePayment1, INVHDR_LatePayment,
                Total_Amt_Due_Date, INVHDR_DueDate, INVHDR_RecieptAmount,
                INVHDR_ClosingBalance, INVHDR_InvDate1, INVHDR_ApplicationId,
                INVHDR_CurrentReading, INVHDR_BillingId, INVHDR_RebateQty, INVHDR_CorporateId, INVHDR_CreditNoteAmount, INVHDR_ReceivedDebitNoteAmount, CenterName,
                CenterCode, AppNo, Count, totalreceived, receiptType, "", INVHDR_RegChargesAmount, INVHDR_ReceivedRegChargesAmount, INVHDR_GeneratedFrom, INVHDR_GeneratedFromText));
            }
            return list;
        }

        public BILInvoiceHDRTRNMsg DeleteBILInvoiceHDRTRN_Corp(int BILInvoiceHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILInvoiceHDRTRN_Corporate_Delete] " + BILInvoiceHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public IList<BILAMCTRN> GetBILAMCTRN(string SortColumn, string SortType, int PageIndex, int PageSize, string Criteria, int blnExport)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_BILAMCTRN_Select ");
            sql.Append("'" + SortColumn + "',");
            sql.Append("'" + SortType + "',");
            sql.Append("" + PageIndex + ",");
            sql.Append("" + PageSize + ",");
            sql.Append("'" + Criteria + "',");
            sql.Append("" + blnExport + "");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int _Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILAMCTRN> list = new List<BILAMCTRN>();
            foreach (DataRow row in dtList.Rows)
            {
                int _AMCTRN_AMCAmount = int.Parse(row["AMCTRN_AMCAmount"].ToString());
                string _BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
                list.Add(new BILAMCTRN(_AMCTRN_AMCAmount, _BCCMST_ShortName, _Count));
            }
            return list;
        }



        public IList<BILInvoiceList> GetBILInvoice()
        {
            int INVHDR_BillingId = 0;
            string INVHDR_CustomerId = "";
            int INVHDR_AreaCode = 0;
            string INVHDR_InvDate = "";
            int INVHDR_CreatedByUserID = 0;


            return GetBILInvoice(INVHDR_BillingId, INVHDR_CustomerId, INVHDR_AreaCode, INVHDR_InvDate, INVHDR_CreatedByUserID);
        }
        public IList<BILInvoiceList> GetBILInvoice(int INVHDR_BillingId, string INVHDR_CustomerId, int INVHDR_AreaCode, string INVHDR_InvDate, int INVHDR_CreatedByUserID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC GET_PhonePe_API_Parameter ");
            sql.Append(INVHDR_BillingId + ",");
            sql.Append("'" + INVHDR_CustomerId + "',");
            sql.Append(INVHDR_AreaCode + ",");
            sql.Append("'" + INVHDR_InvDate + "',");
            sql.Append(INVHDR_CreatedByUserID);


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[0];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILInvoiceList> list = new List<BILInvoiceList>();
            foreach (DataRow row in dtList.Rows)
            {
                //string AreaName = row["AREMST_Name"].ToString();
                //int CD_ControlID = int.Parse(row["AREMST_AreaCode"].ToString());


                //list.Add(new BILInvoiceList(AreaName, CD_ControlID));
                string MerchantOrderId = row["MerchantOrderId"].ToString();
                int TransactionId = int.Parse(row["TransactionId"].ToString());
                int Amount = int.Parse(row["Amount"].ToString());
                int StoreId = int.Parse(row["StoreId"].ToString());
                int TerminalId = int.Parse(row["TerminalId"].ToString());
                int ExpiresIn = int.Parse(row["ExpiresIn"].ToString());
                string FileName = row["FileName"].ToString();


                list.Add(new BILInvoiceList(MerchantOrderId, TransactionId, Amount,
                 StoreId, TerminalId, ExpiresIn, FileName));
            }
            return list;

        }


        public IList<BILInvoiceList_WA> GetBILInvoiceList_WA()
        {
            int INVHDR_BillingId = 0;
            string INVHDR_CustomerId = "";
            int INVHDR_AreaCode = 0;
            string INVHDR_InvDate = "";
            int INVHDR_CreatedByUserID = 0;


            return GetBILInvoiceList_WA(INVHDR_BillingId, INVHDR_CustomerId, INVHDR_AreaCode, INVHDR_InvDate, INVHDR_CreatedByUserID);
        }
        public IList<BILInvoiceList_WA> GetBILInvoiceList_WA(int INVHDR_BillingId, string INVHDR_CustomerId, int INVHDR_AreaCode, string INVHDR_InvDate, int INVHDR_CreatedByUserID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC GET_WhatsApp_Message_Parameter ");
            sql.Append(INVHDR_BillingId + ",");
            sql.Append("'" + INVHDR_CustomerId + "',");
            sql.Append(INVHDR_AreaCode + ",");
            sql.Append("'" + INVHDR_InvDate + "',");
            sql.Append(INVHDR_CreatedByUserID);


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[0];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILInvoiceList_WA> list = new List<BILInvoiceList_WA>();
            foreach (DataRow row in dtList.Rows)
            {
                //string AreaName = row["AREMST_Name"].ToString();
                //int CD_ControlID = int.Parse(row["AREMST_AreaCode"].ToString());


                //list.Add(new BILInvoiceList(AreaName, CD_ControlID));
                string bc1 = row["BCCMST_ShortName"].ToString();
                string bc2 = row["BCCMST_EndDate"].ToString();
                string billerBillID = row["INVHDR_InvoiceID"].ToString();
                string customer_id = row["APPMST_CustomerID"].ToString();
                string destination = row["APPMST_Mobile"].ToString();
                string due_date = row["INVHDR_DueDate"].ToString();
                string overdue_amount = row["Due_Amount"].ToString();
                string value = row["Value"].ToString();


                list.Add(new BILInvoiceList_WA(bc1, bc2, billerBillID,
                 customer_id, destination, due_date, overdue_amount, value));
            }
            return list;

        }



        public IList<BILInvoiceNumList> GetInvoiceNumberbyID()
        {
            int InvoiceID = 0;


            return GetInvoiceNumberbyID(InvoiceID);
        }
        public IList<BILInvoiceNumList> GetInvoiceNumberbyID(int InvoiceID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC GET_InvNo_ByID ");
            sql.Append(InvoiceID);


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[0];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILInvoiceNumList> list = new List<BILInvoiceNumList>();
            foreach (DataRow row in dtList.Rows)
            {
                //string AreaName = row["AREMST_Name"].ToString();
                //int CD_ControlID = int.Parse(row["AREMST_AreaCode"].ToString());


                //list.Add(new BILInvoiceList(AreaName, CD_ControlID));
                int INVHDR_InvoiceID = int.Parse(row["INVHDR_InvoiceID"].ToString());
                string INVHDR_InvNo = row["INVHDR_InvNo"].ToString();
                string INVHDR_InvDate = row["INVHDR_InvDate"].ToString();
                int INVHDR_ApplicationId = int.Parse(row["INVHDR_ApplicationId"].ToString());
                int INVHDR_BillingId = int.Parse(row["INVHDR_BillingId"].ToString());
                int INVHDR_CreatedByUserID = int.Parse(row["INVHDR_CreatedByUserID"].ToString());
                string INVHDR_CustomerID = row["INVHDR_CustomerID"].ToString();


                list.Add(new BILInvoiceNumList(INVHDR_InvoiceID, INVHDR_InvNo, INVHDR_InvDate, INVHDR_ApplicationId, INVHDR_BillingId, INVHDR_CreatedByUserID, INVHDR_CustomerID));
            }
            return list;

        }


    }
}
