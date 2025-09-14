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
    public class BILDisConnReqFormTRNDao : IBILDisConnReqFormTRNDao
    {
        private readonly DbManager _dbManager;

        public BILDisConnReqFormTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILDisConnReqFormTRNList> GetBILDisConnReqFormTRNs()
        {
            string sortExpression = "DSCTRN_RequestID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILDisConnReqFormTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILDisConnReqFormTRNList> GetBILDisConnReqFormTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            //sql.Append("EXEC Usp_BILDisConnReqFormTRN_SelectAll ");
            sql.Append("EXEC [Usp_BILDisConnReqFormTRN_SelectAll_WithReconnection] ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'DSCTRN_RequestID',");
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
            int BillReqcount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILDisConnReqFormTRNList> list = new List<BILDisConnReqFormTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int DSCTRN_RequestID = int.Parse(row["DSCTRN_RequestID"].ToString());
                int DSCTRN_ApplicationId = int.Parse(row["DSCTRN_ApplicationId"].ToString());
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string App_Name = row["App_Name"].ToString();
                string Address = row["Address"].ToString();
                string AREMST_Name = row["AREMST_Name"].ToString();
                string DSCTRN_DisconnReqDate = row["DSCTRN_DisconnReqDate"].ToString();
                string CD_ControlType = row["CD_ControlType"].ToString();
                string DSCTRN_DisconnReqReason = row["DSCTRN_DisconnReqReason"].ToString();
                int DSCTRN_RowStatus = int.Parse(row["DSCTRN_RowStatus"].ToString());
                //int DSCTRN_RowStatus = Convert.ToInt32(row["DSCTRN_RowStatus"].ToString());
                string DSCTRN_ReconnDate = row["DSCTRN_ReconnDate"].ToString();
                string DSCTRN_ReconnOrderBy = row["DSCTRN_ReconnOrderBy"].ToString();
                string DSCTRN_ExpReconDate = row["DSCTRN_ExpReconDate"].ToString();
                int DSCTRN_Flag = int.Parse(row["DSCTRN_Flag"].ToString());
                string strDSCTRN_Flag = row["strDSCTRN_Flag"].ToString();
                int DSCTRN_DisconnReqOrderBy = int.Parse(row["DSCTRN_DisconnReqOrderBy"].ToString());
                string DSCTRN_RequestNo = row["DSCTRN_RequestNo"].ToString();
                decimal DSCTRN_DueAmount = decimal.Parse(row["DSCTRN_DueAmount"].ToString());
                decimal DSCTRN_ReceivedAmount = decimal.Parse(row["DSCTRN_ReceivedAmount"].ToString());
                string ActionDate = row["ActionDate"].ToString();
                string AppNo = row["APPMST_AppNo"].ToString();
                string AppStatus = row["ApplicationStatus"].ToString();
                string PayStatus = row["PayStatus"].ToString();
                string DSCTRN_CreditNoteStatus = row["DSCTRN_CreditNoteStatus"].ToString();
                string DSCTRN_ONMReason = row["DSCTRN_ONMReason"].ToString();
                string DSCTRN_CNMReason = row["DSCTRN_CNMReason"].ToString();


                list.Add(new BILDisConnReqFormTRNList(DSCTRN_RequestID, DSCTRN_ApplicationId, APPMST_CustomerID, App_Name, Address, AREMST_Name, DSCTRN_DisconnReqDate, CD_ControlType, DSCTRN_DisconnReqReason, DSCTRN_RowStatus, DSCTRN_ReconnDate, DSCTRN_ReconnOrderBy, DSCTRN_ExpReconDate, DSCTRN_Flag, strDSCTRN_Flag, DSCTRN_DisconnReqOrderBy, DSCTRN_RequestNo, DSCTRN_DueAmount, DSCTRN_ReceivedAmount, BillReqcount, ActionDate, AppNo, AppStatus, PayStatus, DSCTRN_CreditNoteStatus, DSCTRN_ONMReason, DSCTRN_CNMReason));
            }
            return list;
        }


        //public IList<BillReqDetailList> GetBillReqDetailListDTLTRNs()
        //{
        //    string sortExpression = "METTRN_ID";
        //    string sortType = "ASC";
        //    int pageIndex = 0;
        //    int pageSize = -1;
        //    string criteria = "";
        //    return GetBillReqDetailListDTLTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        //}

        //public IList<BillReqDetailList> GetBillReqDetailListDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_BILMeterReadingForREquest_SelectAll ");
        //    //String Building for Order by Column.
        //    if (String.IsNullOrEmpty(sortExpression) == true)
        //    {
        //        sql.Append("'METTRN_ID',");
        //    }
        //    else
        //    {
        //        sql.Append("'" + sortExpression + "',");
        //    }
        //    //String Building for Sorintg Type
        //    if (String.IsNullOrEmpty(sortType) == true)
        //    {
        //        sql.Append("'ASC',");
        //    }
        //    else
        //    {
        //        sql.Append("'" + sortType + "',");
        //    }
        //    //String Building for Page Index
        //    sql.Append(pageIndex + ",");
        //    sql.Append(pageSize + ",'");
        //    sql.Append(criteria + "'");
        //    DataSet ds = _dbManager.GetDataSet(sql.ToString());
        //    DataTable dtList = ds.Tables[0];
        //    DataTable dtRowCount = ds.Tables[1];
        //    int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
        //    IList<BillReqDetailList> list = new List<BillReqDetailList>();
        //    foreach (DataRow row in dtList.Rows)
        //    {
        //        //***Please write field names which you wants to display in grid.***
        //        int METTRN_ID = int.Parse(row["METTRN_ID"].ToString());
        //        //int METTRN_BillingId = int.Parse(row["METTRN_BillingId"].ToString());
        //        //int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
        //        //long METTRN_MeterNo = (long)row["METTRN_MeterNo"];
        //        long METTRN_MeterNo = long.Parse(row["METTRN_MeterNo"].ToString());
        //        decimal METTRN_CurrentReading = decimal.Parse(row["METTRN_CurrentReading"].ToString());

        //    }
        //    return list;
        //}
        //public IList<BillReqDetailList> GetBillReqDetailListDTLTRNs(string APPMST_CustomerID)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_BILMeterReadingForREquest_SelectAll " + APPMST_CustomerID);
        //    //DataRow row = _dbManager.GetDataRow(sql.ToString());

        //    DataSet ds = _dbManager.GetDataSet(sql.ToString());
        //    DataTable dtList = ds.Tables[0];
        //    //DataTable dtRowCount = ds.Tables[1];
        //    //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
        //    IList<BillReqDetailList> list = new List<BillReqDetailList>();
        //    foreach (DataRow row in dtList.Rows)
        //    {
        //        #region"Variables Declaration"

        //        //string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
        //        long METTRN_MeterNo = Convert.ToInt64(row["METTRN_MeterNo"].ToString());
        //        //decimal METTRN_PreviousReading = Convert.ToDecimal(row["METTRN_PreviousReading"].ToString());
        //        decimal METTRN_CurrentReading = Convert.ToDecimal(row["METTRN_CurrentReading"].ToString());
        //        list.Add(new BillReqDetailList(APPMST_CustomerID, METTRN_MeterNo, METTRN_CurrentReading));
        //    }
        //        #endregion
        //    return list;
        //}
        public IList<BillReqDetailListForEdit> GetBillReqDetailEditListDTLTRNs(int DSCTRN_RequestID, int DSCTRN_ApplicationId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingForREquestForEdit_SelectAll " + DSCTRN_RequestID + "," + DSCTRN_ApplicationId);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BillReqDetailListForEdit> list = new List<BillReqDetailListForEdit>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                //string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
                int METTRN_ID = Convert.ToInt32(row["METTRN_ID"].ToString());
                long METTRN_MeterNo = Convert.ToInt64(row["METTRN_MeterNo"].ToString());
                //decimal METTRN_PreviousReading = Convert.ToDecimal(row["METTRN_PreviousReading"].ToString());
                decimal METTRN_CurrentReading = Convert.ToDecimal(row["METTRN_CurrentReading"].ToString());
                decimal DSCTRN_ReqMeterReading = Convert.ToDecimal(row["DSCTRN_ReqMeterReading"].ToString());
                list.Add(new BillReqDetailListForEdit(METTRN_ID, METTRN_MeterNo, METTRN_CurrentReading, DSCTRN_ReqMeterReading));
            }
            #endregion
            return list;
        }


        public IList<BillActionList> GetBillActionListDTLTRNs(int CDMTRN_RequestCode)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingForAction_SelectAll " + CDMTRN_RequestCode);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BillActionList> list = new List<BillActionList>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                Int64 CDMTRN_MeterNo = Convert.ToInt64(row["CDMTRN_MeterNo"].ToString());
                decimal CDMTRN_PrevMeterReading = Convert.ToDecimal(row["CDMTRN_PrevMeterReading"].ToString());
                decimal CDMTRN_DisMeterReading = Convert.ToDecimal(row["CDMTRN_DisMeterReading"].ToString());
                list.Add(new BillActionList(CDMTRN_MeterNo, CDMTRN_PrevMeterReading, CDMTRN_DisMeterReading));
            }
            #endregion
            return list;
        }


        public BILDisConnReqForCustomer GetBILDisConnReqForCustomer(string APPMST_CustomerID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILDisConnReqFormTRN_CustomerForAdd] '" + APPMST_CustomerID + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            if (row != null)
            {
                #region"Variables Declaration"


                int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
                string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
                string CustomerName = Convert.ToString(row["CustomerName"]);
                string customerAddress = Convert.ToString(row["customerAddress"]);
                string CD_ControlType = Convert.ToString(row["CD_ControlType"]);
                string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
                string MaxinvoiceNo = Convert.ToString(row["MaxinvoiceNo"]);
                decimal outstandingAmount = Convert.ToDecimal(row["outstandingAmount"]);
                #endregion

                return new

                BILDisConnReqForCustomer(APPMST_AppID, APPMST_AppNo, CustomerName, customerAddress, CD_ControlType, PLAMST_PlanName, MaxinvoiceNo, outstandingAmount);
            }
            else
            {

                return null;
            }
        }

        public BILDisConnReqForCustomer GetBILDisConnReqForCustomer_WithReconnection(string APPMST_CustomerID, string RequestType)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILDisConnReqFormTRN_CustomerForAdd_WithReconnection] '" + APPMST_CustomerID + "','" + RequestType + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            if (row != null)
            {
                #region"Variables Declaration"


                int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
                string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
                string CustomerName = Convert.ToString(row["CustomerName"]);
                string customerAddress = Convert.ToString(row["customerAddress"]);
                string CD_ControlType = Convert.ToString(row["CD_ControlType"]);
                string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
                string MaxinvoiceNo = Convert.ToString(row["MaxinvoiceNo"]);
                decimal outstandingAmount = Convert.ToDecimal(row["outstandingAmount"]);
                #endregion

                return new

                BILDisConnReqForCustomer(APPMST_AppID, APPMST_AppNo, CustomerName, customerAddress, CD_ControlType, PLAMST_PlanName, MaxinvoiceNo, outstandingAmount);
            }
            else
            {
                return null;
            }
        }

        public BILSurrenderReqForCustomer GetBILSurrenderReqForCustomer(string APPMST_CustomerID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_SurrenderRequest_Select '" + APPMST_CustomerID + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            if (row != null)
            {
                #region"Variables Declaration"


                int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
                string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
                string CustomerName = Convert.ToString(row["CustomerName"]);
                string customerAddress = Convert.ToString(row["customerAddress"]);
                string CD_ControlType = Convert.ToString(row["CD_ControlType"]);
                string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
                string MaxinvoiceNo = Convert.ToString(row["MaxinvoiceNo"]);
                decimal outstandingAmount = Convert.ToDecimal(row["outstandingAmount"]);
                #endregion

                return new

                BILSurrenderReqForCustomer(APPMST_AppID, APPMST_AppNo, CustomerName, customerAddress, CD_ControlType, PLAMST_PlanName, MaxinvoiceNo, outstandingAmount);
            }
            else
            {

                return null;
            }
        }
        public BILDisConnReqFormTRNListForEdit GetBILDisConnReqFormTRNListForEdit(int DSCTRN_RequestID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILDisConnReqFormTRN_CustomerForEdit] " + DSCTRN_RequestID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal dueAmt = 0;
            decimal.TryParse(Convert.ToString(row["DSCTRN_DueAmount"]), out dueAmt);
            int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
            string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
            string CustomerName = Convert.ToString(row["CustomerName"]);
            string customerAddress = Convert.ToString(row["customerAddress"]);
            string CD_ControlType = Convert.ToString(row["CD_ControlType"]);
            string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
            string MaxinvoiceNo = Convert.ToString(row["MaxinvoiceNo"]);
            decimal outstandingAmount = Convert.ToDecimal(row["outstandingAmount"]);
            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            string DSCTRN_DisconnReqDate = Convert.ToString(row["DSCTRN_DisconnReqDate"]);
            string DSCTRN_RequestDate = Convert.ToString(row["DSCTRN_RequestDate"]);
            string DSCTRN_DisconnReqOrderBy = Convert.ToString(row["DSCTRN_DisconnReqOrderBy"]);
            string DSCTRN_ExpReconDate = Convert.ToString(row["DSCTRN_ExpReconDate"]);
            decimal DSCTRN_DueAmount = dueAmt;// Convert.ToDecimal(row["DSCTRN_DueAmount"]); 
            string DSCTRN_DisconnReqReason = Convert.ToString(row["DSCTRN_DisconnReqReason"]);
            string DSCTRN_DisconnDate = Convert.ToString(row["DSCTRN_DisconnDate"]);
            string DSCTRN_DisconnDoneby = Convert.ToString(row["DSCTRN_DisconnDoneby"]);
            string DSCTRN_ReconnDate = Convert.ToString(row["DSCTRN_ReconnDate"]);
            string DSCTRN_RequestNo = Convert.ToString(row["DSCTRN_RequestNo"]);
            string DSCTRN_CreditNoteStatus = Convert.ToString(row["DSCTRN_CreditNoteStatus"]);
            string DSCTRN_ONMReason = Convert.ToString(row["DSCTRN_ONMReason"]);
            string DSCTRN_CNMReason = Convert.ToString(row["DSCTRN_CNMReason"]);

            #endregion

            return new
            BILDisConnReqFormTRNListForEdit(APPMST_AppID, APPMST_AppNo, CustomerName, customerAddress, CD_ControlType, PLAMST_PlanName, MaxinvoiceNo, outstandingAmount, APPMST_CustomerID, DSCTRN_RequestDate, DSCTRN_DisconnReqDate, DSCTRN_DisconnReqOrderBy, DSCTRN_ExpReconDate, DSCTRN_DueAmount, DSCTRN_DisconnReqReason, DSCTRN_DisconnDate, DSCTRN_DisconnDoneby, DSCTRN_ReconnDate, DSCTRN_RequestNo, DSCTRN_CreditNoteStatus, DSCTRN_ONMReason, DSCTRN_CNMReason);
        }
        public BILDisConnReqFormTRN GetBILDisConnReqFormTRN(int BILDisConnReqFormTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILDisConnReqFormTRN_Select " + BILDisConnReqFormTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int DSCTRN_RequestID = Convert.ToInt32(row["DSCTRN_RequestID"]);
            int DSCTRN_ApplicationId = Convert.ToInt32(row["DSCTRN_ApplicationId"]);
            string DSCTRN_RequestDate = Convert.ToString(row["DSCTRN_RequestDate"]);
            int DSCTRN_BInvoiceId = Convert.ToInt32(row["DSCTRN_BInvoiceId"]);
            int DSCTRN_DisconnType = Convert.ToInt32(row["DSCTRN_DisconnType"]);
            string DSCTRN_DisconnReqDate = Convert.ToString(row["DSCTRN_DisconnReqDate"]);
            int DSCTRN_DisconnReqOrderBy = Convert.ToInt32(row["DSCTRN_DisconnReqOrderBy"]);
            string DSCTRN_DisconnReqReason = Convert.ToString(row["DSCTRN_DisconnReqReason"]);
            decimal DSCTRN_ReqMeterReading = Convert.ToDecimal(row["DSCTRN_ReqMeterReading"]);
            decimal DSCTRN_DisconnMeterReading = Convert.ToDecimal(row["DSCTRN_DisconnMeterReading"]);
            string DSCTRN_ExpReconDate = Convert.ToString(row["DSCTRN_ExpReconDate"]);
            string DSCTRN_ReconnDate = Convert.ToString(row["DSCTRN_ReconnDate"]);
            int DSCTRN_ReconnOrderBy = Convert.ToInt32(row["DSCTRN_ReconnOrderBy"]);
            int DSCTRN_Flag = Convert.ToInt32(row["DSCTRN_Flag"]);
            int DSCTRN_DisconnDoneby = Convert.ToInt32(row["DSCTRN_DisconnDoneby"]);
            string DSCTRN_DisconnDate = Convert.ToString(row["DSCTRN_DisconnDate"]);
            string DSCTRN_DisconnRemark = Convert.ToString(row["DSCTRN_DisconnRemark"]);
            int DSCTRN_CreatedByUserID = Convert.ToInt32(row["DSCTRN_CreatedByUserID"]);
            string DSCTRN_CreatedDateTime = Convert.ToString(row["DSCTRN_CreatedDateTime"]);
            int DSCTRN_UpdatedByUserID = Convert.ToInt32(row["DSCTRN_UpdatedByUserID"]);
            string DSCTRN_UpdatedDateTime = Convert.ToString(row["DSCTRN_UpdatedDateTime"]);
            int DSCTRN_RowStatus = Convert.ToInt32(row["DSCTRN_RowStatus"]);
            int DSCTRN_DueAmount = Convert.ToInt32(row["DSCTRN_DueAmount"]);
            int DSCTRN_TariffID = Convert.ToInt32(row["DSCTRN_TariffID"]);
            string DSCTRN_CreditNoteStatus = Convert.ToString(row["DSCTRN_CreditNoteStatus"]);
            string DSCTRN_ONMReason = Convert.ToString(row["DSCTRN_ONMReason"]);
            string DSCTRN_CNMReason = Convert.ToString(row["DSCTRN_CNMReason"]);
            //string SType = Convert.ToString(row["SType"]);
            long DSCTRN_RowVersion = long.Parse(row["DSCTRN_RowVersion"].ToString());
            #endregion

            return new
            BILDisConnReqFormTRN(DSCTRN_RequestID, DSCTRN_ApplicationId, DSCTRN_RequestDate, DSCTRN_BInvoiceId, DSCTRN_DisconnType, DSCTRN_DisconnReqDate, DSCTRN_DisconnReqOrderBy, DSCTRN_DisconnReqReason, DSCTRN_ReqMeterReading, DSCTRN_DisconnMeterReading, DSCTRN_ExpReconDate, DSCTRN_ReconnDate, DSCTRN_ReconnOrderBy, DSCTRN_Flag, DSCTRN_DisconnDoneby, DSCTRN_DisconnDate, DSCTRN_DisconnRemark, DSCTRN_CreatedByUserID, DSCTRN_CreatedDateTime, DSCTRN_UpdatedByUserID, DSCTRN_UpdatedDateTime, DSCTRN_RowStatus, DSCTRN_DueAmount, DSCTRN_TariffID, DSCTRN_CreditNoteStatus, DSCTRN_ONMReason, DSCTRN_CNMReason, DSCTRN_RowVersion);
        }

        public BILDisConnReqFormTRNMsg InsertBILDisConnReqFormTRN(BILDisConnReqFormTRN BILDisConnReqFormTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILDisConnReqFormTRN_Insert ");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ApplicationId + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_RequestDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_BInvoiceId + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnType + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnReqDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnReqOrderBy + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnReqReason + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ReqMeterReading + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnMeterReading + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_ExpReconDate + "',");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_ReconnDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ReconnOrderBy + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_Flag + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnDoneby + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnDate + "',");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnRemark.Replace("'", "''") + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_CreatedByUserID + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RowStatus + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DueAmount + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_TariffID);

            //sql.Append("N'" + BILDisConnReqFormTRN.SType);       
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }

        public BILDisConnReqFormTRNMsg UpdateBILDisConnReqFormTRN(BILDisConnReqFormTRN BILDisConnReqFormTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILDisConnReqFormTRN_Update ");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RequestID + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ApplicationId + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_RequestDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_BInvoiceId + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnType + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnReqDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnReqOrderBy + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnReqReason.Replace("'", "''") + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ReqMeterReading + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnMeterReading + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_ExpReconDate + "',");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_ReconnDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ReconnOrderBy + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_Flag + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_DisconnDoneby + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnDate + "',");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_DisconnRemark.Replace("'", "''") + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_UpdatedByUserID + ",");
            sql.Append("N'" + BILDisConnReqFormTRN.DSCTRN_UpdatedDateTime + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RowStatus + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }
        public BILDisConnReqFormTRNMsg UpdateBILDisConnReqFormTRNForReconnection(BILDisConnReqFormTRN BILDisConnReqFormTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_BILDisConnReqFormTRN_UpdateForReconnection ");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RequestID + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ApplicationId + ",");

            sql.Append("'" + BILDisConnReqFormTRN.DSCTRN_ReconnDate + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ReconnOrderBy + ",");

            sql.Append(BILDisConnReqFormTRN.DSCTRN_UpdatedByUserID + ",");


            sql.Append(BILDisConnReqFormTRN.DSCTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }
        public BILDisConnReqFormTRNMsg DeleteBILDisConnReqFormTRN(int BILDisConnReqFormTRNID, int UserID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usptrn_BILDisConnReqFormTRN_Delete " + BILDisConnReqFormTRNID + "," + UserID);
            //sql.Append(UserID );
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }
        public BILDisConnReqFormTRNMsg DeleteBILDisConnReqFormTRNFOR(int BILDisConnReqFormTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILDisConnReqFormTRN_Delete " + BILDisConnReqFormTRNID);
            //sql.Append(UserID );
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }

        public BILDisConnReqFormTRNMsg CancelBILDisConnReqFormTRNFOR(BILDisConnReqFormTRN BILDisConnReqFormTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILDisConnReqFormTRN_ReqCancel ");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RequestID + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_Flag + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ONMReason + ",'");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_CNMReason.Replace("'", "''") + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_UpdatedByUserID);
            //sql.Append(UserID );
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }

        public BILDisConnReqFormTRNMsg RecordupdateBILDisConnReqFormTRNFOR(BILDisConnReqFormTRN BILDisConnReqFormTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILDisConnReqFormTRN_Recupdate ");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_RequestID + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_CreditNoteStatus + ",");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_ONMReason + ",'");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_CNMReason.Replace("'", "''") + "',");
            sql.Append(BILDisConnReqFormTRN.DSCTRN_UpdatedByUserID);
            //sql.Append(UserID );
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILDisConnReqFormTRNMsg(_RetVal, _RetStr);
        }

    }
}
