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
    public class CORCSVMasterDao : ICORCSVMasterDao
    {
        private readonly DbManager _dbManager;

        public CORCSVMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORCSVMasterList> GetCORCSVMasters()
        {
            string sortExpression = "CSVMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORCSVMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORCSVMasterList> GetCORCSVMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORCSVMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CSVMST_ID',");
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
            IList<CORCSVMasterList> list = new List<CORCSVMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public CORCSVMaster GetCORCSVMaster(int CORCSVMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORCSVMaster_Select " + CORCSVMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CSVMST_ID = Convert.ToInt32(row["CSVMST_ID"]);
            string CSVMST_Date = Convert.ToString(row["CSVMST_Date"]);
            string CSVMST_RelatedTo = Convert.ToString(row["CSVMST_RelatedTo"]);
            int CSVMST_TotalRecords = Convert.ToInt32(row["CSVMST_TotalRecords"]);
            int CSVMST_NoofInserted = Convert.ToInt32(row["CSVMST_NoofInserted"]);
            string CSVMST_CSVLog = Convert.ToString(row["CSVMST_CSVLog"]);
            int CSVMST_UploadedByUserID = Convert.ToInt32(row["CSVMST_UploadedByUserID"]);

            #endregion

            return new
            CORCSVMaster(CSVMST_ID, CSVMST_Date, CSVMST_RelatedTo, CSVMST_TotalRecords, CSVMST_NoofInserted, CSVMST_CSVLog, CSVMST_UploadedByUserID);
        }

        public CORCSVMasterMsg InsertCORCSVMaster(CORCSVMaster CORCSVMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CORCSVMaster_Insert] ");
            sql.Append("N'" + CORCSVMaster.CSVMST_Date + "',");
            sql.Append("N'" + CORCSVMaster.CSVMST_RelatedTo.Replace("'", "''") + "',");
            sql.Append(CORCSVMaster.CSVMST_TotalRecords + ",");
            sql.Append(CORCSVMaster.CSVMST_NoofInserted + ",");
            sql.Append("N'" + CORCSVMaster.CSVMST_CSVLog.Replace("'", "''") + "',");
            sql.Append(CORCSVMaster.CSVMST_UploadedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORCSVMasterMsg(_RetVal, _RetStr);
        }

        public SMSSendEmail InsertSendEmail(SendEmail objData, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_SendEmail_Insert] ");
            sql.Append("N'" + objData.CustomerId + "',");
            sql.Append("N'" + objData.ToEmailAddress.Replace("'", "''") + "',");
            sql.Append("N'" + objData.CCEmailAddress.Replace("'", "''") + "',");
            sql.Append("N'" + objData.EmailSubject.Replace("'", "''") + "',");
            sql.Append("N'" + objData.EmailBody.Replace("'", "''") + "',");
            sql.Append("N'" + objData.NoOfAttachment + "',");
            sql.Append("N'" + objData.SendStatus + "',");
            sql.Append(objData.UserId);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new SMSSendEmail(_RetVal, _RetStr);
        }

        public SMSSendEmail InsertSendEmail_Customized(string CenCode, string OMStatus, string NoOfPending, decimal FromOutStandAmt, decimal ToOutStandAmt, string Message, int UserId, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_SendEmail_Insert_Customized] ");
            sql.Append("N'" + CenCode + "',");
            sql.Append("N'" + OMStatus + "',");
            sql.Append("N'" + NoOfPending + "',");
            sql.Append("N'" + FromOutStandAmt + "',");
            sql.Append("N'" + ToOutStandAmt + "',");
            sql.Append("N'" + Message.Replace("'", "''") + "',");
            sql.Append(UserId);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new SMSSendEmail(_RetVal, _RetStr);
        }

        public SMSMsg InsertSMS(SMS SMS, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_SMS_Insert] ");
            sql.Append("N'" + SMS.MobileNo + "',");
            sql.Append("N'" + SMS.Message.Replace("'", "''") + "',");

            sql.Append(SMS.UserId);
            sql.Append(",@blnGetOutput=1,");
            sql.Append("@language='" + SMS.language + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new SMSMsg(_RetVal, _RetStr);
        }

        public SMSMsg InsertSMS_Customized(string CenCode, string OMStatus, string NoOfPending, decimal FromOutStandAmt, decimal ToOutStandAmt, string Message, int UserId, string sms_language, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_SMS_Insert_Customized] ");
            sql.Append("N'" + CenCode + "',");
            sql.Append("N'" + OMStatus + "',");
            sql.Append("N'" + NoOfPending + "',");
            sql.Append("N'" + FromOutStandAmt + "',");
            sql.Append("N'" + ToOutStandAmt + "',");
            sql.Append("N'" + Message.Replace("'", "''''") + "',");
            sql.Append(UserId);
            sql.Append(",'" + sms_language + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new SMSMsg(_RetVal, _RetStr);
        }

        public CORCSVMasterMsg UpdateCORCSVMaster(CORCSVMaster CORCSVMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORCSVMaster_Update ");
            sql.Append(CORCSVMaster.CSVMST_ID + ",");
            sql.Append("N'" + CORCSVMaster.CSVMST_Date + "',");
            sql.Append("N'" + CORCSVMaster.CSVMST_RelatedTo + "',");
            sql.Append(CORCSVMaster.CSVMST_TotalRecords + ",");
            sql.Append(CORCSVMaster.CSVMST_NoofInserted + ",");
            sql.Append("N'" + CORCSVMaster.CSVMST_CSVLog + "',");
            sql.Append(CORCSVMaster.CSVMST_UploadedByUserID + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORCSVMasterMsg(_RetVal, _RetStr);
        }

        public CORCSVMasterMsg DeleteCORCSVMaster(int CORCSVMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORCSVMaster_Delete " + CORCSVMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORCSVMasterMsg(_RetVal, _RetStr);
        }

        public CSVUpload_Insert_Msg Insert_CSVUploadTables(CSVUpload_Insert CSVUpload_Insert, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();

            if (CSVUpload_Insert.CSVFor == "PU")
            {
                sql.Append("EXEC [USP_CORAppPlanHistoryMaster_Insert_ForCSVUpload_FromCSV] ");
                sql.Append("N'" + CSVUpload_Insert.DirPath + "',");
                sql.Append("N'" + CSVUpload_Insert.FileName + "',");
                sql.Append(CSVUpload_Insert.CreatedByUserID);
            }

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            string _Log = Convert.ToString(row["LogFileContent"]);
            int _TotalRecords = Convert.ToInt32(row["TotalRecords"]);
            int _RecordsNotInserted = Convert.ToInt32(row["RecordsNotInserted"]);
            #endregion

            return new CSVUpload_Insert_Msg(_RetVal, _RetStr, _Log, _TotalRecords, _RecordsNotInserted);
        }

        public string ConvertDataViewToString(DataView srcDataView, string Delimiter, string Separator, string PrnCol)
        {
            StringBuilder ResultBuilder;
            ResultBuilder = new StringBuilder();
            ResultBuilder.Length = 0;

            //DataColumn aCol;
            if (PrnCol != "N")
            {
                foreach (DataColumn aCol in srcDataView.Table.Columns)
                {
                    if ((Delimiter != null) && (Delimiter.ToString().Trim().Length > 0))
                    {
                        ResultBuilder.Append(Delimiter);
                    }
                    ResultBuilder.Append(aCol.ColumnName);
                    if ((Delimiter != null) && (Delimiter.ToString().Trim().Length > 0))
                    {
                        ResultBuilder.Append(Delimiter);
                    }
                    ResultBuilder.Append(Separator);
                }
                if (ResultBuilder.Length > Separator.ToString().Trim().Length)
                {
                    ResultBuilder.Length = ResultBuilder.ToString().Trim().Length - Separator.ToString().Trim().Length;
                }
                ResultBuilder.Append(Environment.NewLine);
            }

            //DataRowView aRow;
            foreach (DataRowView aRow in srcDataView)
            {
                foreach (DataColumn aCol in srcDataView.Table.Columns)
                {
                    if ((Delimiter != null) && (Delimiter.ToString().Trim().Length > 0))
                    {
                        ResultBuilder.Append(Delimiter);
                    }

                    ResultBuilder.Append(aRow[aCol.ColumnName].ToString().Replace("\n", ""));

                    if ((Delimiter != null) && (Delimiter.ToString().Trim().Length > 0))
                    {
                        ResultBuilder.Append(Delimiter);
                    }
                    ResultBuilder.Append(Separator);
                }
                ResultBuilder.Length = ResultBuilder.Length - 1;
                ResultBuilder.Append(Environment.NewLine);
            }
            if ((ResultBuilder != null))
            {
                return ResultBuilder.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public DataTable ExportData(String ExportDataFor, string sortExpression, string sortType, string criteria)
        {
            StringBuilder sql = new StringBuilder();

            if (ExportDataFor == "AGM")
            {
                sql.Append("EXEC [USP_CSMAlertGroupMaster_SelectAll] ");
            }
            else if (ExportDataFor == "CCR")
            {
                sql.Append("EXEC [USP_Call_Escalation_Report] ");
            }
            else if (ExportDataFor == "BM")
            {
                sql.Append("EXEC [USP_CORBankMaster_SelectAll] ");
            }
            else if (ExportDataFor == "UM")
            {
                sql.Append("EXEC [User_USRUserMaster_SelectAll] ");
            }
            else if (ExportDataFor == "LPF")
            {
                sql.Append("EXEC [Usp_CORLatePaymentFineMaster_SelectAll] ");
            }
            else if (ExportDataFor == "CONTR")
            {
                sql.Append("EXEC [usp_CORContractorMaster_SelectAll] ");
            }
            else if (ExportDataFor == "MNOU")
            {
                sql.Append("EXEC [USP_PRDMeterUpdateTRN_SelectAll] ");
            }
            else if (ExportDataFor == "MCHG")
            {
                sql.Append("EXEC [USP_PRDMeterChangeHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "DN")
            {
                sql.Append("EXEC [USP_PRDInvoiceHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "PU")
            {
                sql.Append("EXEC [USP_CORAppPlanHistoryMaster_SelectAll] ");
            }
            else if (ExportDataFor == "REB")
            {
                sql.Append("EXEC [USP_BILRebateTRN_SelectAll] ");
            }
            else if (ExportDataFor == "OS")
            {
                sql.Append("EXEC [USP_OutStanding_Rpt] ");
            }
            else if (ExportDataFor == "DNReg")
            {
                sql.Append("EXEC [USP_DebitNoteRegister_Rpt] ");
            }
            else if (ExportDataFor == "DColl")
            {
                sql.Append("EXEC [USP_DailyCollection_Rpt] ");
            }
            else if (ExportDataFor == "PendBill")
            {
                sql.Append("EXEC [USP_PendingBillSummary_Rpt] ");
            }
            else if (ExportDataFor == "DatewiseRec")
            {
                sql.Append("EXEC [USP_DatewiseReceipt_Rpt] ");
            }
            else if (ExportDataFor == "DebitNoteDispatch")
            {
                sql.Append("EXEC [USP_GetDebitNotDispatchedList_Rpt] ");
            }
            else if (ExportDataFor == "AMC")
            {
                sql.Append("EXEC [USP_AMC_Rpt] ");
            }
            else if (ExportDataFor == "BG")
            {
                sql.Append("EXEC [USP_BILInvoiceHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "VBill")
            {
                sql.Append("EXEC [USP_ValidateBill_SelectAll] ");
            }
            else if (ExportDataFor == "DO")
            {
                // sql.Append("EXEC [USP_BILInvoiceHDRTRN_SelectAll] ");
                sql.Append("EXEC [USP_BILInvoiceHDRTRN_SelectAll_ForDebtorReport] ");
            }
            else if (ExportDataFor == "CBG")
            {
                sql.Append("EXEC [USP_BILInvoiceHDRTRN_Summary_SelectAll] ");
            }
            else if (ExportDataFor == "MR")
            {
                sql.Append("EXEC [USP_BILMeterReading_SelectAll] ");
            }
            else if (ExportDataFor == "REF")
            {
                sql.Append("EXEC [USP_ACCRefundTRN_SelectAll] ");
            }
            else if (ExportDataFor == "OM")
            {
                sql.Append("EXEC  [USP_OAndMStatus_SelectAll] ");
            }
            else if (ExportDataFor == "NG")
            {
                sql.Append("EXEC [USP_BILNoticeHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "NGO")
            {
                sql.Append("EXEC [USP_BILNoticeHDRTRN_NoticeoutStandingSelectLatest1] ");
            }
            else if (ExportDataFor == "BR")
            {
                sql.Append("EXEC [USP_BillingRpt_SelectAll] ");
            }
            else if (ExportDataFor == "GCFR")
            {
                sql.Append("EXEC [USP_GasConsumptionFactor_Rpt] ");
            }
            else if (ExportDataFor == "MM")
            {
                sql.Append("EXEC [Usp_CORMeterMaster_SelectAll] ");
            }
            else if (ExportDataFor == "WO")
            {
                sql.Append("EXEC [usp_PRDWorkOrderTRN_SelectAll_ForJobsheet] ");
            }
            else if (ExportDataFor == "DC")
            {
                sql.Append("EXEC [USP_DashboardForColl_SelectAll] ");
            }
            else if (ExportDataFor == "CS")
            {
                sql.Append("EXEC [usp_ChequeDetail_Search] ");
            }
            else if (ExportDataFor == "XCR")
            {
                sql.Append("EXEC [USP_PRDExConnReqFormHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "TD")
            {
                sql.Append("EXEC [Usp_BILDisConnReqFormTRN_SelectAll] ");
            }
            else if (ExportDataFor == "PD")
            {
                sql.Append("EXEC [Usp_BILDisConnReqFormTRN_SelectAll] ");
            }
            else if (ExportDataFor == "SR")
            {
                sql.Append("EXEC [Usp_BILDisConnReqFormTRN_SelectAll] ");
            }
            else if (ExportDataFor == "CL")
            {
                sql.Append("EXEC [usp_Bill_CustomerList_Print] ");
            }
            else if (ExportDataFor == "CSum")
            {
                sql.Append("EXEC [USP_CSMCallSummary_Rpt] ");
            }
            else if (ExportDataFor == "CAD")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForDeposit] ");
            }
            else if (ExportDataFor == "CAS")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForCashDeposit] ");
            }
            else if (ExportDataFor == "CCS")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForDeposit] ");
            }
            else if (ExportDataFor == "CD")
            {
                sql.Append("EXEC [USP_ACCBankClearanceTRN_SelectAll] ");
            }
            else if (ExportDataFor == "CDD")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForDeposit] ");
            }
            else if (ExportDataFor == "CDO")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForDeposit] ");
            }
            else if (ExportDataFor == "CRZ")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForDeposit] ");
            }
            else if (ExportDataFor == "CRP")
            {
                sql.Append("EXEC [USP_ACCChequeDTLTRN_SelectForDeposit] ");
            }
            else if (ExportDataFor == "CP")
            {
                sql.Append("EXEC [USP_PRDCommissioningTRN_SelectAll] ");
            }
            else if (ExportDataFor == "OMN")
            {
                sql.Append("EXEC [USP_PRDOMNoticeGeneration_SelectAll] ");
            }
            else if (ExportDataFor == "NR")
            {
                sql.Append("EXEC [USP_CorApplicationMaster_SelectAll] ");
            }
            else if (ExportDataFor == "BIS")
            {
                sql.Append("EXEC [USP_CorApplicationMaster_SelectAll] ");
            }
            else if (ExportDataFor == "RM")
            {
                sql.Append("EXEC [USP_ACCReceiptHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "RF")
            {
                sql.Append("EXEC [USP_ACCRefundHDRTRN_SelectAll] ");
            }
            else if (ExportDataFor == "NT")
            {
                sql.Append("EXEC [usp_CORNameTransferMaster_SelectAll] ");
            }
            else if (ExportDataFor == "AC")
            {
                sql.Append("EXEC [usp_CORApplicationCancelMaster_SelectAll] ");
            }
            else if (ExportDataFor == "JSG")
            {
                sql.Append("EXEC [usp_PRDWorkOrderTRN_SelectAll_ForJobsheet] ");
            }
            else if (ExportDataFor == "SC")
            {
                sql.Append("EXEC [USP_CORSetupConfigMaster_SelectAll] ");
            }
            else if (ExportDataFor == "FCR")
            {
                sql.Append("EXEC [USP_CSMFCR_SelectAll] ");
            }
            else if (ExportDataFor == "CNR")
            {
                sql.Append("EXEC [usp_CenterwiseStatus_Report] ");
            }
            else if (ExportDataFor == "CNRCHQ")
            {
                sql.Append("EXEC [usp_CenterwiseChequeStatus_Report] ");
            }
            else if (ExportDataFor == "HDRec")
            {
                sql.Append("EXEC [usp_HeadwiseReceipt_Report] ");
            }
            else if (ExportDataFor == "PendBillCustList")
            {
                sql.Append("EXEC [USP_GetPendingBillCustomers] ");
            }
            else if (ExportDataFor == "CallStatus")
            {
                sql.Append("EXEC [USP_CSMCallAllocationDetail_SelectAll] ");
            }
            else if (ExportDataFor == "JSDReport")
            {
                sql.Append("EXEC [USP_PRDJobSheetHDRTRN_rptDetail] ");
            }
            else if (ExportDataFor == "SMSHistory")
            {
                sql.Append("EXEC [USP_CORSendSMSHistory_SelectAll] ");
            }
            else if (ExportDataFor == "EH")
            {
                sql.Append("EXEC [USP_CORSendEmailHistory_SelectAll] ");
            }
            else if (ExportDataFor == "CallReg")
            {
                sql.Append("EXEC [USP_CSMCallLogDetail_SelectAll] ");
            }
            else if (ExportDataFor == "CSMAdvanceSearch")
            {
                sql.Append("EXEC [USP_CSMAdvanceSearch_SelectAll] ");
            }
            else if (ExportDataFor == "CusSur")
            {
                sql.Append("EXEC [USP_CORCustomerSurvey_SelectAll] ");
            }
            else if (ExportDataFor == "EME")
            {
                sql.Append("EXEC [USP_ExtraMaterialEstimation_Rpt] ");
            }
            else if (ExportDataFor == "EscalationMatrix")
            {
                sql.Append("EXEC [USP_CSMEscalationMatrixMaster_SelectAll] ");
            }
            else if (ExportDataFor == "CR")
            {
                sql.Append("EXEC [USP_ACCCreditNoteTRN_SelectAll] ");
            }


            //String Building for Order by Column.
            sql.Append("'" + sortExpression + "',");

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
            sql.Append(0 + ",");
            sql.Append(-1 + ",'");
            if (ExportDataFor == "CR")
            {

                sql.Append(criteria + "'");
            }
            else
            {
                sql.Append(criteria + "',");
            }


            if (ExportDataFor == "WO")
            {
                sql.Append("1,");
            }
            else if (ExportDataFor == "JSG")
            {
                sql.Append("0,");
            }

            if (ExportDataFor != "CR")
            {
                sql.Append(1);
            }



            if (ExportDataFor == "BIS")
            {
                sql.Append(", 'BIS'");
            }

            if (ExportDataFor == "FCR")
            {
                sql.Remove(sql.ToString().Length - 2, 2);
            }
            //if (ExportDataFor == "FCR")
            //{
            //    sql.Remove(sql.ToString().Length - 2, 2);
            //}

            if (ExportDataFor == "CDD")
            {
                sql.Append(",0");
            }
            else if (ExportDataFor == "CDO")
            {
                sql.Append(",1");
            }
            else if (ExportDataFor == "CRZ")
            {
                sql.Append(",2");
            }
            else if (ExportDataFor == "CCS")
            {
                sql.Append(",3");
            }

            DataSet TmpDS = (DataSet)_dbManager.GetDataSet(sql.ToString());

            string exportContent = "";

            if (TmpDS.Tables.Count > 0)
            {
                DataView dv = TmpDS.Tables[0].DefaultView;
                exportContent = ConvertDataViewToString(dv, "", "\t", "Y");
                dv.Dispose();
            }
            TmpDS.Dispose();
            return TmpDS.Tables[0];
            //return exportContent;
        }
        public string ExportData_List(String ExportDataFor, string criteria, string criteria1, string criteria2)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("EXEC usp_Bill_CustomerList_Print ");
            sql.Append(criteria + ",");
            sql.Append(criteria1 + ",");
            sql.Append(criteria2 + ",");
            sql.Append(1 + "");

            DataSet TmpDS = (DataSet)_dbManager.GetDataSet(sql.ToString());

            string exportContent = "";

            if (TmpDS.Tables.Count > 0)
            {
                DataView dv = TmpDS.Tables[0].DefaultView;
                exportContent = ConvertDataViewToString(dv, "", "\t", "Y");
                dv.Dispose();
            }
            TmpDS.Dispose();

            return exportContent;
        }

    }
}
