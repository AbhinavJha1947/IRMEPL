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
    public class PRDInvoiceHDRTRNDao : IPRDInvoiceHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDInvoiceHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public PRDInvoiceHDRTRN_Detail_Recalculate GetPRDInvoiceHDRTRN_Detail_Recalculate(int CenCode, int INVHDR_InvoiceNo, int INVHDR_ApplicationID, int INVHDR_JobSheetID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_Detail_Recalculate] ");
            sql.Append(CenCode);
            sql.Append("," + INVHDR_InvoiceNo);
            sql.Append("," + INVHDR_ApplicationID);
            sql.Append("," + INVHDR_JobSheetID);

            DataRow dr = _dbManager.GetDataRow(sql.ToString());
            PRDInvoiceHDRTRN_Detail_Recalculate Recalc = new PRDInvoiceHDRTRN_Detail_Recalculate(dr["ApplicationNo"].ToString(), dr["CustomerID"].ToString(), dr["CustomerName"].ToString(), dr["Address"].ToString(), dr["INVHDR_InvoiceRefNo"].ToString(), dr["INVHDR_InvoiceDate"].ToString(), int.Parse(dr["INVHDR_InvoiceType"].ToString()), dr["INVHDR_Remarks"].ToString(), dr["ContractorName"].ToString(), decimal.Parse(dr["JOBHDR_ActualAmt"].ToString()), dr["JOBHDR_Remarks"].ToString(), dr["JOBHDR_DateofInst"].ToString(), dr["PlanName"].ToString(), dr["CustomerType"].ToString(), dr["WorkOrderType"].ToString(), dr["WORTRN_WorkOrdDate"].ToString());
            if (
                Recalc.ApplicationNo == null ||
                Recalc.CustomerID == null ||
                Recalc.CustomerName == null ||
                Recalc.Address == null ||
                Recalc.INVHDR_InvoiceRefNo == null ||
                Recalc.INVHDR_InvoiceDate == null ||
                Recalc.INVHDR_InvoiceType == null ||
                Recalc.INVHDR_Remarks == null ||
                Recalc.ContractorName == null ||
                Recalc.JOBHDR_ActualAmt == null ||
                Recalc.JOBHDR_Remarks == null ||
                Recalc.JOBHDR_DateofInst == null ||
                Recalc.PlanName == null ||
                Recalc.CustomerType == null ||
                Recalc.WorkOrderType == null ||
                Recalc.WORTRN_WorkOrdDate == null
                )
            {
                return null;
            }
            return Recalc;
        }

        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<PRDInvoiceHDRTRN_Detail> GetPRDInvoiceHDRTRN_Detail(int APPMST_CenCode, int APPMST_CustType, int WORTRN_WorkOrderTYpe, int @APPMST_Area, string APPMST_AppNo, string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_Detail] ");
            sql.Append(APPMST_CenCode);
            sql.Append("," + APPMST_CustType);
            sql.Append("," + WORTRN_WorkOrderTYpe);
            sql.Append("," + APPMST_Area);
            sql.Append(",'" + APPMST_AppNo + "'");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append(",'JobSheetNo'");
            }
            else
            {
                sql.Append(",'" + sortExpression + "'");
            }
            //String Building for Sorintg Type
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append(",'ASC'");
            }
            else
            {
                sql.Append(",'" + sortType + "'");
            }
            //String Building for Page Index
            sql.Append("," + pageIndex);
            sql.Append("," + pageSize);
            sql.Append(",'" + criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDInvoiceHDRTRN_Detail> list = new List<PRDInvoiceHDRTRN_Detail>();
            foreach (DataRow row in dtList.Rows)
            {
                string KeyField = row["KeyField"].ToString();
                string JobSheetNo = row["JobSheetNo"].ToString();
                string JOBHDR_DateofInst = row["JOBHDR_DateofInst"].ToString();
                string APPMST_AppNo1 = row["APPMST_AppNo"].ToString();
                string APPMST_AppDate = row["APPMST_AppDate"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string CustomerType = row["CustomerType"].ToString();
                string WorkOrderType = row["WorkOrderType"].ToString();
                string OMStatus = row["OMStatus"].ToString();
                string PlanName = row["PlanName"].ToString();
                list.Add(new PRDInvoiceHDRTRN_Detail(KeyField, JobSheetNo, JOBHDR_DateofInst, APPMST_AppDate, APPMST_AppNo1, APPMST_CustomerID, CustomerName, WorkOrderType, OMStatus, CustomerType, PlanName, Count));
            }
            return list;
        }

        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<PRDInvoiceHDRTRN_MeterNo> GetPRDInvoiceHDRTRN_MeterNo(int ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_MeterNo] " + ApplicationID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<PRDInvoiceHDRTRN_MeterNo> list = new List<PRDInvoiceHDRTRN_MeterNo>();
            foreach (DataRow row in dtList.Rows)
            {
                long MeterNo = long.Parse(row["CMRMST_MeterNo"].ToString());
                list.Add(new PRDInvoiceHDRTRN_MeterNo(MeterNo));
            }
            return list;
        }
        public IList<PRDInvoiceHDRTRN_AppID> GetPRDInvoiceHDRTRN_Flag(int ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CORApplicationMaster_CheckDependency] " + ApplicationID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<PRDInvoiceHDRTRN_AppID> list = new List<PRDInvoiceHDRTRN_AppID>();
            foreach (DataRow row in dtList.Rows)
            {
                int APPID = int.Parse(row["JOBHDR_ApplicationId"].ToString());
                list.Add(new PRDInvoiceHDRTRN_AppID(APPID));
            }
            return list;
        }

        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<PRDInvoiceHDRTRN_MaterialDetail> GetPRDInvoiceHDRTRN_MaterialDetail(int JobSheetID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_MaterialDetail] " + JobSheetID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<PRDInvoiceHDRTRN_MaterialDetail> list = new List<PRDInvoiceHDRTRN_MaterialDetail>();
            foreach (DataRow row in dtList.Rows)
            {
                int JOBDTL_ID = int.Parse(row["JOBDTL_ID"].ToString());
                int JOBDTL_ConnType = int.Parse(row["JOBDTL_ConnType"].ToString());
                string ConnType = row["ConnType"].ToString();
                int JOBDTL_MaterialID = int.Parse(row["JOBDTL_MaterialID"].ToString());
                string MaterialName = row["MaterialName"].ToString();
                decimal JOBDTL_PipeLength = decimal.Parse(row["JOBDTL_PipeLength"].ToString());

                int JOBDTL_ExtraConnType = int.Parse(row["JOBDTL_ExtraConnType"].ToString());
                string ExtraConnType = row["ExtraConnType"].ToString();
                int JOBDTL_NoOfExtConn = int.Parse(row["JOBDTL_NoOfExtConn"].ToString());
                list.Add(new PRDInvoiceHDRTRN_MaterialDetail(JOBDTL_ID, JOBDTL_ConnType, ConnType, JOBDTL_MaterialID, MaterialName, JOBDTL_PipeLength, JOBDTL_ExtraConnType, ExtraConnType, JOBDTL_NoOfExtConn));
            }
            return list;
        }

        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<PRDInvoiceHDRTRN_MaterialDetail> GetPRDInvoiceHDRTRN_ConnectionDetail(string CustomerID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_ConDetail] N'" + CustomerID + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<PRDInvoiceHDRTRN_MaterialDetail> list = new List<PRDInvoiceHDRTRN_MaterialDetail>();
            foreach (DataRow row in dtList.Rows)
            {
                int JOBDTL_ID = int.Parse(row["JOBDTL_ID"].ToString());
                int JOBDTL_ConnType = int.Parse(row["JOBDTL_ConnType"].ToString());
                string ConnType = row["ConnType"].ToString();
                int JOBDTL_MaterialID = int.Parse(row["JOBDTL_MaterialID"].ToString());
                string MaterialName = row["MaterialName"].ToString();
                decimal JOBDTL_PipeLength = decimal.Parse(row["JOBDTL_PipeLength"].ToString());

                int JOBDTL_ExtraConnType = int.Parse(row["JOBDTL_ExtraConnType"].ToString());
                string ExtraConnType = row["ExtraConnType"].ToString();
                int JOBDTL_NoOfExtConn = int.Parse(row["JOBDTL_NoOfExtConn"].ToString());
                list.Add(new PRDInvoiceHDRTRN_MaterialDetail(JOBDTL_ID, JOBDTL_ConnType, ConnType, JOBDTL_MaterialID, MaterialName, JOBDTL_PipeLength, JOBDTL_ExtraConnType, ExtraConnType, JOBDTL_NoOfExtConn));
            }
            return list;
        }

        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<PRDInvoiceHDRTRN_ExtraConnectionDetail> GetPRDInvoiceHDRTRN_ExtraConnectionDetail(int JobSheetID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_ExtraConnectionDetail] " + JobSheetID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<PRDInvoiceHDRTRN_ExtraConnectionDetail> list = new List<PRDInvoiceHDRTRN_ExtraConnectionDetail>();
            foreach (DataRow row in dtList.Rows)
            {
                int JOBDTL_ID = int.Parse(row["JOBDTL_ID"].ToString());
                int JOBDTL_ExtraConnType = int.Parse(row["JOBDTL_ExtraConnType"].ToString());
                string ExtraConnType = row["ExtraConnType"].ToString();
                int JOBDTL_NoOfExtConn = int.Parse(row["JOBDTL_NoOfExtConn"].ToString());
                list.Add(new PRDInvoiceHDRTRN_ExtraConnectionDetail(JOBDTL_ID, JOBDTL_ExtraConnType, ExtraConnType, JOBDTL_NoOfExtConn));
            }
            return list;
        }

        public IList<PRDInvoiceHDRTRNList> GetPRDInvoiceHDRTRNs()
        {
            string sortExpression = "INVHDR_InvoiceNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDInvoiceHDRTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }
        public IList<PRDInvoiceHDRTRNList> GetPRDInvoiceHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_SelectAll] ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'INVHDR_InvoiceNo',");
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
            IList<PRDInvoiceHDRTRNList> list = new List<PRDInvoiceHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                string KeyField = row["KeyField"].ToString();
                int INVHDR_InvoiceNo = int.Parse(row["INVHDR_InvoiceNo"].ToString());
                string INVHDR_InvoiceRefNo = row["INVHDR_InvoiceRefNo"].ToString();
                string INVHDR_InvoiceDate = row["INVHDR_InvoiceDate"].ToString();
                string ApplicationNo = row["ApplicationNo"].ToString();
                string CustomerID = row["CustomerID"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string Area = row["Area"].ToString();
                string CustomerType = row["CustomerType"].ToString();
                string WorkType = row["WorkType"].ToString();
                string PlanName = row["PlanName"].ToString();
                string DNAdvanceReceiptDate = row["DN Advance Receipt Date"].ToString();
                decimal DNAdvanceAmount = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["DN Advance Amount"])))
                    DNAdvanceAmount = Convert.ToDecimal(row["DN Advance Amount"]);
                decimal TaxonDNAdvanceAmount = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["Tax on DN Advance Amount"])))
                    TaxonDNAdvanceAmount = Convert.ToDecimal(row["Tax on DN Advance Amount"].ToString());
                decimal TotalDNAdvanceReceived = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["Total DN Advance Received"])))
                    TotalDNAdvanceReceived = Convert.ToDecimal(row["Total DN Advance Received"].ToString());
                decimal DebitNoteAmount = 0;
                //if (row["Debit Note Amount"] != null)
                //    DebitNoteAmount = Convert.ToDecimal(row["Debit Note Amount"].ToString());
                decimal ActualDNAmount = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["Actual DN Amount"])))
                    ActualDNAmount = Convert.ToDecimal(row["Actual DN Amount"].ToString());
                decimal TaxonActualDNAmount = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["Tax on Actual DN Amount"])))
                    TaxonActualDNAmount = Convert.ToDecimal(row["Tax on Actual DN Amount"].ToString());
                decimal DNAmount = 0;
                //if (row["DN Amount"] != null)
                //    DNAmount = Convert.ToDecimal(row["DN Amount"].ToString());
                decimal TotalDebitNoteAmount = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["Total Debit Note Amount"])))
                    TotalDebitNoteAmount = Convert.ToDecimal(row["Total Debit Note Amount"].ToString());

                string DNAmountPaymentDate = row["DN Amount Payment Date"].ToString();
                decimal DNAmountPaymentreceived = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["DN Advance Amount"])))
                    DNAmountPaymentreceived = Convert.ToDecimal(row["DN Amount Payment received"].ToString());
                //decimal INVHDR_Amt = decimal.Parse(row["INVHDR_Amt"].ToString());
                //decimal INVHDR_TotalReceived = decimal.Parse(row["INVHDR_TotalReceived"].ToString());
                //decimal ActualDNAmt = decimal.Parse(row["ActualDNAmt"].ToString());
                //decimal tax = decimal.Parse(row["tax"].ToString());
                list.Add(new PRDInvoiceHDRTRNList(KeyField, INVHDR_InvoiceNo, INVHDR_InvoiceRefNo, INVHDR_InvoiceDate, ApplicationNo, CustomerID, CustomerName, Area, CustomerType, WorkType, PlanName, DNAdvanceReceiptDate, DNAdvanceAmount,

            TaxonDNAdvanceAmount, TotalDNAdvanceReceived, DebitNoteAmount, ActualDNAmount, TaxonActualDNAmount, DNAmount, TotalDebitNoteAmount, DNAmountPaymentDate, DNAmountPaymentreceived, Count));
            }
            return list;
        }

        public PRDInvoiceHDRTRN GetPRDInvoiceHDRTRN(int PRDInvoiceHDRTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDInvoiceHDRTRN_Select " + PRDInvoiceHDRTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            decimal INVHDR_InvoiceNo = Convert.ToDecimal(row["INVHDR_InvoiceNo"]);
            string INVHDR_InvoiceRefNo = Convert.ToString(row["INVHDR_InvoiceRefNo"]);
            string INVHDR_InvoiceDate = Convert.ToString(row["INVHDR_InvoiceDate"]);
            decimal INVHDR_ApplicationID = Convert.ToDecimal(row["INVHDR_ApplicationID"]);
            int INVHDR_JobSheetID = Convert.ToInt32(row["INVHDR_JobSheetID"]);
            int INVHDR_PlanId = Convert.ToInt32(row["INVHDR_PlanId"]);
            decimal INVHDR_TotalPlanAmount = Convert.ToDecimal(row["INVHDR_TotalPlanAmount"]);
            decimal INVHDR_TotalReceived = Convert.ToDecimal(row["INVHDR_TotalReceived"]);
            int INVHDR_InvoiceType = Convert.ToInt32(row["INVHDR_InvoiceType"]);
            int INVHDR_MeterNo = Convert.ToInt32(row["INVHDR_MeterNo"]);
            string INVHDR_Remarks = row["INVHDR_Remarks"].ToString();
            int INVHDR_CreatedByUserID = Convert.ToInt32(row["INVHDR_CreatedByUserID"]);
            string INVHDR_CreatedDateTime = Convert.ToString(row["INVHDR_CreatedDateTime"]);
            int INVHDR_UpdatedByUserID = Convert.ToInt32(row["INVHDR_UpdatedByUserID"]);
            string INVHDR_UpdatedDateTime = Convert.ToString(row["INVHDR_UpdatedDateTime"]);
            int INVHDR_RowStatus = Convert.ToInt32(row["INVHDR_RowStatus"]);
            long INVHDR_RowVersion = (long)row["INVHDR_RowVersion"];

            #endregion

            return new
            PRDInvoiceHDRTRN(INVHDR_InvoiceNo, INVHDR_InvoiceRefNo, INVHDR_InvoiceDate, INVHDR_ApplicationID, INVHDR_JobSheetID, INVHDR_PlanId, INVHDR_TotalPlanAmount, INVHDR_TotalReceived, INVHDR_InvoiceType, INVHDR_MeterNo, INVHDR_CreatedByUserID, INVHDR_CreatedDateTime, INVHDR_UpdatedByUserID, INVHDR_UpdatedDateTime, INVHDR_RowStatus, INVHDR_RowVersion);
        }

        public PRDInvoiceHDRTRNMsg PRDInvoiceHDRTRN_ReceiptExists(Int64 INVHDR_InvoiceNo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_ReceiptExists] " + INVHDR_InvoiceNo);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDInvoiceHDRTRNMsg InsertPRDInvoiceHDRTRN(PRDInvoiceHDRTRN_HdrDtlInsert PRDInvoiceHDRTRN_HdrDtlInsert, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN,PRDInvoiceDTLTRN_Insert] ");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.CenCode + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.INVHDR_InvoiceNo + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN_HdrDtlInsert.INVHDR_InvoiceDate + "',");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.INVHDR_ApplicationID + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.JOBHDR_JobSheetID + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.INVHDR_InvoiceType + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN_HdrDtlInsert.INVHDR_Remarks.Replace("'", "''") + "',");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.JOBHDR_ActualAmt + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.blnCalcReCalc + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert.INVHDR_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDInvoiceHDRTRNMsg InsertPRDInvoiceHDRTRN_Recalculate(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN,PRDInvoiceDTLTRN_Insert_Recalculate] ");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.CenCode + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.INVHDR_InvoiceNo + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.INVHDR_InvoiceDate + "',");
            sql.Append("N'" + PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.INVHDR_Remarks.Replace("'", "''") + "',");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.INVHDR_ApplicationID + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.JOBHDR_JobSheetID + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.MCDtl + "',");
            sql.Append("N'" + PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.ECDtl + "',");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.JOBHDR_ActualAmt + ",");
            sql.Append(PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate.INVHDR_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDInvoiceHDRTRNMsg UpdatePRDInvoiceHDRTRN(PRDInvoiceHDRTRN PRDInvoiceHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_PRDInvoiceHDRTRN_Update ");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_InvoiceNo + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN.INVHDR_InvoiceRefNo + "',");
            sql.Append("N'" + PRDInvoiceHDRTRN.INVHDR_InvoiceDate + "',");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_ApplicationID + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_PlanId + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_TotalPlanAmount + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_TotalReceived + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_InvoiceType + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_MeterNo + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_CreatedByUserID + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN.INVHDR_CreatedDateTime + "',");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_UpdatedByUserID + ",");
            sql.Append("N'" + PRDInvoiceHDRTRN.INVHDR_UpdatedDateTime + "',");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_RowStatus + ",");
            sql.Append(PRDInvoiceHDRTRN.INVHDR_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDInvoiceHDRTRNMsg DeletePRDInvoiceHDRTRN(int INVHDR_InvoiceNo, string INVHDR_Remarks, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDInvoiceHDRTRN_Delete] " + INVHDR_InvoiceNo + ",'" + INVHDR_Remarks.Replace("'", "''") + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDInvoiceHDRTRNMsg(_RetVal, _RetStr);
        }

        public IList<PRDInvoiceAdvanceHistoryList> GetPRDInvoiceAdvanceHistory(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, string DNtype)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDInvoiceHDRTRN_log_History_SelectAll ");
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
            sql.Append(DNtype + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDInvoiceAdvanceHistoryList> list = new List<PRDInvoiceAdvanceHistoryList>();
            foreach (DataRow row in dtList.Rows)
            {
                int Row = int.Parse(row["srno"].ToString());
                string type = Convert.ToString(row["DNType"]);
                int OriginalLogID = Convert.ToInt32(row["OriginalLogID"]);
                int RevisedLogID = Convert.ToInt32(row["RevisedLogID"].ToString());
                int OriginalInvoiceID = Convert.ToInt32(row["OriginalInvoiceID"]);
                int RevisedInvoiceID = Convert.ToInt32(row["RevisedInvoiceID"]);
                string OriginalINVfrom = row["OriginalINVfrom"].ToString();
                string RevisedInvFrom = row["RevisedInvFrom"].ToString();
                string INVHDR_DeleteDateTime = row["INVDeletedDate"].ToString();
                string CreatedDateTime = row["INVCreatedDate"].ToString();
                string CustomerID = row["CustomerID"].ToString();
                string AppNo = row["AppNo"].ToString();
                string OriginalInvNo = row["OriginalInvNo"].ToString();
                string revisedInvNo = row["revisedInvNo"].ToString();
                string OriginalInvDate = row["OriginalInvDate"].ToString();
                string revisedInvDate = row["revisedInvDate"].ToString();
                string worktype = row["WorkType"].ToString();
                string ReasonforRevisionOfDN = Convert.ToString(row["reason"]);
                string OrgExtraConAmt = Convert.ToString(row["OrgExtraConAmt"]);
                string RevisedExtraConAmt = Convert.ToString(row["RevisedExtraConAmt"]);
                string DiffExtraConAmt = Convert.ToString(row["DiffExtraConAmt"]);
                string OrgExtraMatrialAmt = Convert.ToString(row["OrgExtraMatrialAmt"]);
                string RevisedExtraMatrialAmt = Convert.ToString(row["RevisedExtraMatrialAmt"]);
                string DiffExtraMatrialAmt = Convert.ToString(row["DiffExtraMatrialAmt"]);
                string OrgDNAmount = Convert.ToString(row["OrgDNAmount"]);
                string RevisedDNAmount = Convert.ToString(row["RevisedDNAmount"]);
                string DiffDNAmount = Convert.ToString(row["DiffDNAmount"]);
                string OrgConnDepositeAmount = Convert.ToString(row["OrgConnDepositeAmount"]);
                string RevisedConnDepositeAmount = Convert.ToString(row["RevisedConnDepositeAmount"]);
                string DiffConnDepositeAmount = Convert.ToString(row["DiffConnDepositeAmount"]);
                string OrgGasDepositeAmount = Convert.ToString(row["OrgGasDepositeAmount"]);
                string RevisedGasDepositeAmount = Convert.ToString(row["RevisedGasDepositeAmount"]);
                string DiffGasDepositeAmount = Convert.ToString(row["DiffGasDepositeAmount"]);
                string OriginalCBC = Convert.ToString(row["OriginalCBC"]);
                string RevisedCBC = Convert.ToString(row["RevisedCBC"]);
                string DiffCBC = Convert.ToString(row["DiffCBC"]);
                string OriginalAppFees = Convert.ToString(row["OriginlAppFees"]);
                string RevisedAppFees = Convert.ToString(row["RevisedAppFees"]);
                string DiffAppFees = Convert.ToString(row["DiffAppfees"]);

                list.Add(new PRDInvoiceAdvanceHistoryList(Row, type, OriginalLogID, RevisedLogID, OriginalInvoiceID, RevisedInvoiceID, OriginalINVfrom, RevisedInvFrom, INVHDR_DeleteDateTime, CreatedDateTime, CustomerID, AppNo, OriginalInvNo, revisedInvNo, OriginalInvDate, revisedInvDate, worktype,
                ReasonforRevisionOfDN, OrgExtraConAmt, RevisedExtraConAmt, DiffExtraConAmt, OrgExtraMatrialAmt, RevisedExtraMatrialAmt, DiffExtraMatrialAmt,
                OrgDNAmount, RevisedDNAmount, DiffDNAmount, OrgConnDepositeAmount, RevisedConnDepositeAmount, DiffConnDepositeAmount, OrgGasDepositeAmount, RevisedGasDepositeAmount,
                DiffGasDepositeAmount, OriginalCBC, RevisedCBC, DiffCBC, OriginalAppFees, RevisedAppFees, DiffAppFees, Count));
            }
            return list;
        }

    }
}
