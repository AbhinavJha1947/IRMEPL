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
    public class BILRebateTRNDao : IBILRebateTRNDao
    {
        private readonly DbManager _dbManager;

        public BILRebateTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILRebateTRNList> GetBILRebateTRNs()
        {
            string sortExpression = "REBTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILRebateTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILRebateTRNList> GetBILRebateTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILRebateTRN_SelectAll] ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'REBTRN_ID',");
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
            IList<BILRebateTRNList> list = new List<BILRebateTRNList>();

            foreach (DataRow row in dtList.Rows)
            {
                string KeyField = row["KeyField"].ToString();
                int REBTRN_ID = int.Parse(row["REBTRN_ID"].ToString());
                string REBTRN_RebateDate = row["REBTRN_RebateDate"].ToString();
                string ApplicationNo = row["ApplicationNo"].ToString();
                string CustomerID = row["CustomerID"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string CustomerType = row["CustomerType"].ToString();
                string BillingCycle = row["BillingCycle"].ToString();
                string Area = row["Area"].ToString();
                decimal REBTRN_RebateAmount = decimal.Parse(row["REBTRN_RebateAmount"].ToString());
                string RebateType = row["RebateType"].ToString();
                string REBTRN_Reason = row["REBTRN_Reason"].ToString();
                string AuthorizedBy = row["AuthorizedBy"].ToString();
                list.Add(new BILRebateTRNList(REBTRN_ID, KeyField, REBTRN_RebateDate, CustomerID, ApplicationNo, CustomerName, Area, CustomerType, BillingCycle, REBTRN_RebateAmount, RebateType, REBTRN_Reason, AuthorizedBy, Count));
            }
            return list;
        }

        public BILRebateTRN GetBILRebateTRN(int BILRebateTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILRebateTRN_Select " + BILRebateTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            if (row != null)

            #region"Variables Declaration"
            {
                int REBTRN_ID = Convert.ToInt32(row["REBTRN_ID"]);
                decimal REBTRN_ApplicationId = Convert.ToDecimal(row["REBTRN_ApplicationId"]);
                string REBTRN_RebateDate = Convert.ToString(row["REBTRN_RebateDate"]);
                decimal REBTRN_Rent = Convert.ToDecimal(row["REBTRN_Rent"]);
                decimal REBTRN_MinCharge = Convert.ToDecimal(row["REBTRN_MinCharge"]);
                decimal REBTRN_AMC = Convert.ToDecimal(row["REBTRN_AMC"]);
                decimal REBTRN_LatePayment = Convert.ToDecimal(row["REBTRN_LatePayment"]);
                decimal REBTRN_RebateAmount = Convert.ToDecimal(row["REBTRN_RebateAmount"]);
                decimal REBTRN_Quantity = Convert.ToDecimal(row["REBTRN_Quantity"]);
                int REBTRN_RebateType = Convert.ToInt32(row["REBTRN_RebateType"]);
                string REBTRN_Reason = Convert.ToString(row["REBTRN_Reason"]);
                int REBTRN_AuthorizedBy = Convert.ToInt32(row["REBTRN_AuthorizedBy"]);
                int REBTRN_BillingId = Convert.ToInt32(row["REBTRN_BillingId"]);
                decimal REBTRN_InvoiceID = Convert.ToDecimal(row["REBTRN_InvoiceID"]);
                int REBTRN_CreatedByUserID = Convert.ToInt32(row["REBTRN_CreatedByUserID"]);
                string REBTRN_CreatedDateTime = Convert.ToString(row["REBTRN_CreatedDateTime"]);
                int REBTRN_UpdatedByUserID = Convert.ToInt32(row["REBTRN_UpdatedByUserID"]);
                string REBTRN_UpdatedDateTime = Convert.ToString(row["REBTRN_UpdatedDateTime"]);
                int REBTRN_RowStatus = Convert.ToInt32(row["REBTRN_RowStatus"]);
                long REBTRN_RowVersion = (long)row["REBTRN_RowVersion"];
                decimal INVHDR_RecieptAmount = decimal.Parse(row["INVHDR_RecieptAmount"].ToString());
                int INVHDR_SMSFlag = int.Parse(row["INVHDR_SMSFlag"].ToString());

                #endregion

                return new
                BILRebateTRN(REBTRN_ID, REBTRN_ApplicationId, REBTRN_RebateDate, REBTRN_Rent, REBTRN_MinCharge, REBTRN_AMC, REBTRN_LatePayment, REBTRN_RebateAmount, REBTRN_Quantity, REBTRN_RebateType, REBTRN_Reason, REBTRN_AuthorizedBy, REBTRN_BillingId, REBTRN_InvoiceID, REBTRN_CreatedByUserID, REBTRN_CreatedDateTime, REBTRN_UpdatedByUserID, REBTRN_UpdatedDateTime, REBTRN_RowStatus, REBTRN_RowVersion, INVHDR_RecieptAmount, INVHDR_SMSFlag);
            }
            return null;
        }

        public BILRebateTRNMsg InsertBILRebateTRN(BILRebateTRN BILRebateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILRebateTRN_Insert ");
            sql.Append(BILRebateTRN.REBTRN_ApplicationId + ",");
            sql.Append("N'" + BILRebateTRN.REBTRN_RebateDate + "',");
            sql.Append(BILRebateTRN.REBTRN_Rent + ",");
            sql.Append(BILRebateTRN.REBTRN_MinCharge + ",");
            sql.Append(BILRebateTRN.REBTRN_AMC + ",");
            sql.Append(BILRebateTRN.REBTRN_LatePayment + ",");
            sql.Append(BILRebateTRN.REBTRN_RebateAmount + ",");
            sql.Append(BILRebateTRN.REBTRN_Quantity + ",");
            sql.Append(BILRebateTRN.REBTRN_RebateType + ",");
            sql.Append("N'" + BILRebateTRN.REBTRN_Reason.Replace("'", "''") + "',");
            sql.Append(BILRebateTRN.REBTRN_AuthorizedBy + ",");
            sql.Append(BILRebateTRN.REBTRN_BillingId + ",");
            sql.Append(BILRebateTRN.REBTRN_InvoiceID + ",");
            sql.Append(BILRebateTRN.REBTRN_CreatedByUserID + ",");
            sql.Append(BILRebateTRN.REBTRN_RowStatus + ",");
            sql.Append(BILRebateTRN.INVHDR_SMSFlag);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILRebateTRNMsg(_RetVal, _RetStr);
        }

        public BILRebateTRNMsg UpdateBILRebateTRN(BILRebateTRN BILRebateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILRebateTRN_Update ");
            sql.Append(BILRebateTRN.REBTRN_ID + ",");
            sql.Append(BILRebateTRN.REBTRN_ApplicationId + ",");
            sql.Append("N'" + BILRebateTRN.REBTRN_RebateDate + "',");
            sql.Append(BILRebateTRN.REBTRN_Rent + ",");
            sql.Append(BILRebateTRN.REBTRN_MinCharge + ",");
            sql.Append(BILRebateTRN.REBTRN_AMC + ",");
            sql.Append(BILRebateTRN.REBTRN_LatePayment + ",");
            sql.Append(BILRebateTRN.REBTRN_RebateAmount + ",");
            sql.Append(BILRebateTRN.REBTRN_Quantity + ",");
            sql.Append(BILRebateTRN.REBTRN_RebateType + ",");
            sql.Append("N'" + BILRebateTRN.REBTRN_Reason.Replace("'", "''") + "',");
            sql.Append(BILRebateTRN.REBTRN_AuthorizedBy + ",");
            sql.Append(BILRebateTRN.REBTRN_BillingId + ",");
            sql.Append(BILRebateTRN.REBTRN_InvoiceID + ",");
            sql.Append(BILRebateTRN.REBTRN_UpdatedByUserID + ",");
            sql.Append(BILRebateTRN.REBTRN_RowStatus + ",");
            sql.Append(BILRebateTRN.REBTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILRebateTRNMsg(_RetVal, _RetStr);
        }

        public BILRebateTRNMsg DeleteBILRebateTRN(int BILRebateTRNID, int UserId, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILRebateTRN_Delete " + BILRebateTRNID + "," + UserId);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILRebateTRNMsg(_RetVal, _RetStr);
        }

        public BILRebateTRNMsg UpdateBILRebateTRN_REBTRN_InvoiceID(int REBTRN_ID, int REBTRN_InvoiceID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILRebateTRN_Update_REBTRN_InvoiceID ");
            sql.Append(REBTRN_ID + ",");
            sql.Append(REBTRN_InvoiceID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILRebateTRNMsg(_RetVal, _RetStr);
        }

        //---------------------------------------------------------------------------------------------------
        public IList<BILLeakageRebateTRN> GetBILLeakageCycles(int AppId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReading_ForLeakageRebate_select " + AppId);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            int Count = dtList.Rows.Count;
            IList<BILLeakageRebateTRN> list = new List<BILLeakageRebateTRN>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                int rowno = Convert.ToInt32(row["rowno"]);
                int BillingCycleID = Convert.ToInt32(row["BillingCycleID"]);
                string BillingCyclename = Convert.ToString(row["BillingCyclename"]);
                decimal ConsumUnit = Convert.ToDecimal(row["ConsumUnit"]);
                decimal CumulativeReading = Convert.ToDecimal(row["CumulativeReading"]);
                string ReadingDate = Convert.ToString(row["ReadingDate"]);
                int NoofDays = Convert.ToInt32(row["NoofDays"]);
                string Remarks = Convert.ToString(row["Remarks"]);
                int ExtraId = Convert.ToInt32(row["ExtraID"]);
                string PreReadingDate = Convert.ToString(row["PreReadingDate"]);

                list.Add(new BILLeakageRebateTRN(rowno, BillingCycleID, BillingCyclename, ConsumUnit, CumulativeReading, PreReadingDate, ReadingDate, NoofDays, Remarks, Count, ExtraId));

                #endregion
            }
            return list;
        }

        public BILLeakageRebateHDRMsg InsertBILLeakageRebateHDR(BILLeakageRebateHDR BILRebateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILLeakageRebateHDR_Insert ");
            sql.Append(BILRebateTRN.LRH_AppID + ",");
            sql.Append("N'" + BILRebateTRN.LRH_CustomerID + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ComplainNo + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ComplainDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ComplaintResolvedDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_CommisionDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ProjectContractor + "',");
            sql.Append(BILRebateTRN.LRH_DLPPeriodApplicable + ",");
            sql.Append(BILRebateTRN.LRH_TerrifID + ",");
            sql.Append("N'" + BILRebateTRN.LRH_UnitRate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_RebeatUnit + "',");
            sql.Append("N'" + BILRebateTRN.LRH_RebeatAmount + "',");
            sql.Append("N'" + BILRebateTRN.LRH_Reason + "',");

            sql.Append("N'" + BILRebateTRN.LRH_StartDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_EndDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_AvgPerDayCURegularP + "',");
            sql.Append("N'" + BILRebateTRN.LRH_AvgPerDayCULeakageP + "',");
            sql.Append("N'" + BILRebateTRN.LRH_LeakagePeriodCU + "',");
            sql.Append(BILRebateTRN.LRH_LeakagePeriodDays + ",");
            sql.Append("N'" + BILRebateTRN.LRH_LeakageAmount + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ActualConUnit + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ActualAmount + "',");
            sql.Append("N'" + BILRebateTRN.LRH_RegularPeriodCU + "',");
            sql.Append(BILRebateTRN.LRH_RegularPeriodDays + ",");

            sql.Append(BILRebateTRN.LRH_CreatedByID + ",");
            sql.Append(BILRebateTRN.LRH_RowStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILLeakageRebateHDRMsg(_RetVal, _RetStr);
        }

        public BILLeakageRebateDTLMsg InsertBILLeakageRebateDTL(BILLeakageRebateDTL BILRebateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILLeakageRebateDTL_Insert ");
            sql.Append(BILRebateTRN.LRD_LRHID + ",");
            sql.Append(BILRebateTRN.LRD_BillingCycleID + ",");
            sql.Append("N'" + BILRebateTRN.LRD_BillingCycleName.Replace("'", "''") + "',");
            sql.Append("N'" + BILRebateTRN.LRD_ConsumedUnit + "',");
            sql.Append("N'" + BILRebateTRN.LRD_CumulativeReading + "',");
            sql.Append("N'" + BILRebateTRN.LRD_ReadingDate + "',");
            sql.Append(BILRebateTRN.LRD_NoOfDays + ",");
            sql.Append("'" + BILRebateTRN.LRD_Remarks + "',");
            sql.Append(BILRebateTRN.LRD_CreatedByUserID + ",");
            sql.Append(BILRebateTRN.LRD_ExtraID);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILLeakageRebateDTLMsg(_RetVal, _RetStr);
        }

        public BillLeakageRebateUnit GetBillLeakageRebateUnit(int AppID, string startdate, string EndDate)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_LeakageRebate_GetRateUnit " + AppID + ",'" + startdate + "','" + EndDate + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            if (row != null)

            #region"Variables Declaration"
            {
                int TariffID = Convert.ToInt32(row["TariffID"]);
                decimal RateUnit = Convert.ToDecimal(row["RateUnit"]);


                #endregion

                return new
                BillLeakageRebateUnit(TariffID, RateUnit);
            }
            return null;
        }

        public IList<BILLeakageRebateHDR> GetBILLeakageRebateHDRList()
        {
            string sortExpression = "LRH_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILLeakageRebateHDRList(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILLeakageRebateHDR> GetBILLeakageRebateHDRList(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_BILLeakageRebateHDR_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'LRH_ID',");
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
            IList<BILLeakageRebateHDR> list = new List<BILLeakageRebateHDR>();
            foreach (DataRow row in dtList.Rows)
            {
                int LRH_ID = int.Parse(row["LRH_ID"].ToString());
                int LRH_AppID = int.Parse(row["LRH_AppID"].ToString());
                string LRH_CustomerID = row["LRH_CustomerID"].ToString();
                string LRH_ComplainNo = row["LRH_ComplainNo"].ToString();
                string LRH_ComplainDate = row["LRH_ComplainDate"].ToString();
                string LRH_ComplaintResolvedDate = row["LRH_ComplaintResolvedDate"].ToString();
                string LRH_CustomerName = row["LRH_CustomerName"].ToString();
                string LRH_CustomerAddress = row["LRH_CustomerAddress"].ToString();
                string LRH_CommisionDate = row["LRH_CommisionDate"].ToString();
                int LRH_ProjectContractor = int.Parse(row["LRH_ProjectContractor"].ToString());
                int LRH_DLPPeriodApplicable = int.Parse(row["LRH_DLPPeriodApplicable"].ToString());
                int LRH_TerrifID = int.Parse(row["LRH_TerrifID"].ToString());
                decimal LRH_UnitRate = decimal.Parse(row["LRH_UnitRate"].ToString());
                decimal LRH_RebeatUnit = decimal.Parse(row["LRH_RebeatUnit"].ToString());
                decimal LRH_RebeatAmount = decimal.Parse(row["LRH_RebeatAmount"].ToString());
                string LRH_Reason = row["LRH_Reason"].ToString();
                int LRH_CreatedByID = int.Parse(row["LRH_CreatedByID"].ToString());
                int LRH_UpdatedById = int.Parse(row["LRH_UpdatedById"].ToString());
                int LRH_RowStatus = int.Parse(row["LRH_RowStatus"].ToString());

                string LRH_StartDate = row["LRH_StartDate"].ToString();
                string LRH_EndDate = row["LRH_EndDate"].ToString();
                decimal LRH_AvgPerDayCURegularP = decimal.Parse(row["LRH_AvgPerDayCURegularP"].ToString());
                decimal LRH_AvgPerDayCULeakageP = decimal.Parse(row["LRH_AvgPerDayCULeakageP"].ToString());
                decimal LRH_LeakagePeriodCU = decimal.Parse(row["LRH_LeakagePeriodCU"].ToString());
                int LRH_LeakagePeriodDays = int.Parse(row["LRH_LeakagePeriodDays"].ToString());
                decimal LRH_LeakageAmount = decimal.Parse(row["LRH_LeakageAmount"].ToString());
                decimal LRH_ActualConUnit = decimal.Parse(row["LRH_ActualConUnit"].ToString());
                decimal LRH_ActualAmount = decimal.Parse(row["LRH_ActualAmount"].ToString());
                decimal LRH_RegularPeriodCU = decimal.Parse(row["LRH_RegularPeriodCU"].ToString());
                int LRH_RegularPeriodDays = int.Parse(row["LRH_RegularPeriodDays"].ToString());

                list.Add(new BILLeakageRebateHDR(LRH_ID, LRH_AppID, LRH_CustomerID, LRH_CustomerName, LRH_CustomerAddress, LRH_ComplainNo, LRH_ComplainDate, LRH_ComplaintResolvedDate, LRH_CommisionDate, LRH_ProjectContractor, LRH_DLPPeriodApplicable, LRH_TerrifID, LRH_UnitRate, LRH_RebeatUnit, LRH_RebeatAmount, LRH_Reason, LRH_StartDate, LRH_EndDate, LRH_AvgPerDayCURegularP, LRH_AvgPerDayCULeakageP, LRH_LeakagePeriodCU, LRH_LeakagePeriodDays, LRH_LeakageAmount, LRH_ActualConUnit, LRH_ActualAmount, LRH_RegularPeriodCU, LRH_RegularPeriodDays, LRH_CreatedByID, LRH_UpdatedById, LRH_RowStatus, Count));
            }
            return list;
        }

        public BILLeakageRebateHDR GetBILLeakageRebateHDR(int LRH_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_BILLeakageRebateHDR_Select " + LRH_ID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            int Count = dtList.Rows.Count;
            BILLeakageRebateHDR list = new BILLeakageRebateHDR();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"
                list.LRH_ID = int.Parse(row["LRH_ID"].ToString());
                list.LRH_AppID = int.Parse(row["LRH_AppID"].ToString());
                list.LRH_CustomerID = row["LRH_CustomerID"].ToString();
                list.LRH_ComplainNo = row["LRH_ComplainNo"].ToString();
                list.LRH_ComplainDate = row["LRH_ComplainDate"].ToString();
                list.LRH_ComplaintResolvedDate = row["LRH_ComplaintResolvedDate"].ToString();
                list.LRH_CustomerName = row["LRH_CustomerName"].ToString();
                list.LRH_CustomerAddress = row["LRH_CustomerAddress"].ToString();
                list.LRH_CommisionDate = row["LRH_CommisionDate"].ToString();
                list.LRH_ProjectContractor = int.Parse(row["LRH_ProjectContractor"].ToString());
                list.LRH_DLPPeriodApplicable = int.Parse(row["LRH_DLPPeriodApplicable"].ToString());
                list.LRH_TerrifID = int.Parse(row["LRH_TerrifID"].ToString());
                list.LRH_UnitRate = decimal.Parse(row["LRH_UnitRate"].ToString());
                list.LRH_RebeatUnit = decimal.Parse(row["LRH_RebeatUnit"].ToString());
                list.LRH_RebeatAmount = decimal.Parse(row["LRH_RebeatAmount"].ToString());
                list.LRH_Reason = row["LRH_Reason"].ToString();
                list.LRH_CreatedByID = int.Parse(row["LRH_CreatedByID"].ToString());
                list.LRH_UpdatedById = int.Parse(row["LRH_UpdatedById"].ToString());
                list.LRH_RowStatus = int.Parse(row["LRH_RowStatus"].ToString());

                //list.Add(new BILLeakageRebateHDR(LRH_ID1, LRH_AppID, LRH_CustomerID, LRH_CustomerName, LRH_CustomerAddress, LRH_ComplainNo, LRH_ComplainDate, LRH_ComplaintResolvedDate, LRH_CommisionDate, LRH_ProjectContractor, LRH_DLPPeriodApplicable, LRH_TerrifID, LRH_UnitRate, LRH_RebeatUnit, LRH_RebeatAmount, LRH_Reason, LRH_CreatedByID, LRH_UpdatedById, LRH_RowStatus, Count));
                #endregion
            }
            return list;
        }
        public IList<BILLeakageRebateDTL> GetBILLeakageRebateDTL(int LRH_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_BILLeakageRebateDTL_Select " + LRH_ID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            int Count = dtList.Rows.Count;
            IList<BILLeakageRebateDTL> list = new List<BILLeakageRebateDTL>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                int LRD_ID = Convert.ToInt32(row["LRD_ID"]);
                int LRD_LRHID = Convert.ToInt32(row["LRD_LRHID"]);
                int LRD_BillingCycleID = Convert.ToInt32(row["LRD_BillingCycleID"]);
                string LRD_BillingCycleName = Convert.ToString(row["LRD_BillingCycleName"]);
                decimal LRD_ConsumedUnit = Convert.ToDecimal(row["LRD_ConsumedUnit"]);
                decimal LRD_CumulativeReading = Convert.ToDecimal(row["LRD_CumulativeReading"]);
                string LRD_ReadingDate = Convert.ToString(row["LRD_ReadingDate"]);
                int LRD_NoOfDays = Convert.ToInt32(row["LRD_NoOfDays"]);
                string LRD_Remarks = Convert.ToString(row["LRD_Remarks"]);
                //string LRD_CreatedDatetime = Convert.ToString(row["LRD_CreatedDatetime"]);
                int LRD_CreatedByUserID = Convert.ToInt32(row["LRD_CreatedByUserID"]);
                // string LRD_UpdatedDatetime = Convert.ToString(row["LRD_UpdatedDatetime"]);
                int LRD_UpdatedByID = Convert.ToInt32(row["LRD_UpdatedByID"]);
                int LRD_RowStatus = Convert.ToInt32(row["LRD_RowStatus"]);
                int LRD_ExtraID = Convert.ToInt32(row["LRD_ExtraID"]);
                string PreReadingDate = Convert.ToString(row["PreReadingDate"]);
                list.Add(new BILLeakageRebateDTL(LRD_ID, LRD_LRHID, LRD_BillingCycleID, LRD_BillingCycleName, LRD_ConsumedUnit, LRD_CumulativeReading, LRD_ReadingDate, PreReadingDate, LRD_NoOfDays, LRD_Remarks, LRD_CreatedByUserID, LRD_UpdatedByID, LRD_RowStatus, LRD_ExtraID, Count));

                #endregion
            }
            return list;
        }

        public BILLeakageRebateHDRMsg DeleteBILLeakageRebateHDR(int LRH_ID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILLeakageRebateHDR_Delete " + LRH_ID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILLeakageRebateHDRMsg(_RetVal, _RetStr);
        }
        public BILLeakageRebateDTLMsg DeleteBILLeakageRebateDTL(int LRH_ID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILLeakageRebateDTL_Delete " + LRH_ID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILLeakageRebateDTLMsg(_RetVal, _RetStr);
        }
        public BILLeakageRebateHDRMsg UpdateBILLeakageRebateHDR(BILLeakageRebateHDR BILRebateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILLeakageRebateDTL_Update ");
            sql.Append(BILRebateTRN.LRH_ID + ",");
            sql.Append("N'" + BILRebateTRN.LRH_ComplainDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ComplaintResolvedDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_CommisionDate + "',");
            sql.Append(BILRebateTRN.LRH_ProjectContractor + ",");
            sql.Append(BILRebateTRN.LRH_DLPPeriodApplicable + ",");
            sql.Append(BILRebateTRN.LRH_TerrifID + ",");
            sql.Append("N'" + BILRebateTRN.LRH_UnitRate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_RebeatUnit + "',");
            sql.Append("N'" + BILRebateTRN.LRH_RebeatAmount + "',");
            sql.Append("N'" + BILRebateTRN.LRH_Reason.Replace("'", "''") + "',");
            sql.Append(BILRebateTRN.LRH_UpdatedById + ",");
            sql.Append(BILRebateTRN.LRH_RowStatus + ",");
            sql.Append("N'" + BILRebateTRN.LRH_StartDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_EndDate + "',");
            sql.Append("N'" + BILRebateTRN.LRH_AvgPerDayCURegularP + "',");
            sql.Append("N'" + BILRebateTRN.LRH_AvgPerDayCULeakageP + "',");
            sql.Append("N'" + BILRebateTRN.LRH_LeakagePeriodCU + "',");
            sql.Append(BILRebateTRN.LRH_LeakagePeriodDays + ",");
            sql.Append("N'" + BILRebateTRN.LRH_LeakageAmount + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ActualConUnit + "',");
            sql.Append("N'" + BILRebateTRN.LRH_ActualAmount + "',");
            sql.Append("N'" + BILRebateTRN.LRH_RegularPeriodCU + "',");
            sql.Append(BILRebateTRN.LRH_RegularPeriodDays);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILLeakageRebateHDRMsg(_RetVal, _RetStr);
        }
        //---------------------------------------------------------------------------------------------------

    }
}
