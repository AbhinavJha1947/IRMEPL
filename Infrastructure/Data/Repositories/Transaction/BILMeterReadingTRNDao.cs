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
    
    public class BILMeterReadingTRNDao : IBILMeterReadingTRNDao
    {
        private readonly DbManager _dbManager;

        public BILMeterReadingTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILMeterReadingTRNList> GetBILMeterReadingTRNs()
        {
            string sortExpression = "METTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILMeterReadingTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILMeterReadingTRNList> GetBILMeterReadingTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReading_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'METTRN_ID',");
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
            IList<BILMeterReadingTRNList> list = new List<BILMeterReadingTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int METTRN_ID = int.Parse(row["METTRN_ID"].ToString());
                string APPMST_CustomerID = "-";

                // string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                if (row["APPMST_CustomerID"].ToString() != "")
                    APPMST_CustomerID = row["APPMST_CustomerID"].ToString();

                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string CustomerName = row["CustomerName"].ToString();
                string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
                Int64 CMRMST_MeterNo = Int64.Parse(row["CMRMST_MeterNo"].ToString());
                decimal METTRN_CurrentReading = decimal.Parse(row["METTRN_CurrentReading"].ToString());
                decimal METTRN_PrevReading = decimal.Parse(row["METTRN_PrevReading"].ToString());
                decimal ConsumedUnit = decimal.Parse(row["ConsumedUnit"].ToString());
                string METTRN_ReadingDate = row["METTRN_ReadingDate"].ToString();

                string METTRN_ISHouseLock = row["METTRN_ISHouseLock"].ToString();
                string METTRN_BillGenerated = row["METTRN_BillGenerated"].ToString();
                Int64 INVHDR_InvoiceID = Int64.Parse(row["INVHDR_InvoiceID"].ToString());
                string METTRN_ImageName = row["METTRN_ImageName"].ToString();
                string METTRN_Latitude = row["METTRN_Latitude"].ToString();
                string METTRN_Longitude = row["METTRN_Longitude"].ToString();
                string METTRN_isMismatch = row["METTRN_isMismatch"].ToString();
                string METTRN_PhysicalMeterNo = row["METTRN_PhysicalMeterNo"].ToString();
                string METTRN_Remarks = row["METTRN_Remarks"].ToString();
                string METTRN_isFromApp = row["METTRN_isFromApp"].ToString();

                list.Add(new BILMeterReadingTRNList(METTRN_ID, APPMST_CustomerID, APPMST_AppID, CustomerName, BCCMST_ShortName, CMRMST_MeterNo, METTRN_CurrentReading, METTRN_PrevReading, ConsumedUnit, METTRN_ReadingDate, METTRN_ISHouseLock, METTRN_BillGenerated, INVHDR_InvoiceID, METTRN_ImageName, METTRN_Latitude, METTRN_Longitude, METTRN_isMismatch, METTRN_PhysicalMeterNo, METTRN_Remarks, METTRN_isFromApp, Count));
            }
            return list;
        }

        public BILMeterReadingTRN GetBILMeterReadingTRN(int BILMeterReadingTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingTRN_Select " + BILMeterReadingTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int METTRN_ID = Convert.ToInt32(row["METTRN_ID"]);
            int METTRN_ApplicationId = Convert.ToInt32(row["METTRN_ApplicationId"]);
            string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
            int METTRN_BillingId = Convert.ToInt32(row["METTRN_BillingId"]);
            long METTRN_MeterNo = Convert.ToInt64(row["METTRN_MeterNo"]);
            string METTRN_ReadingDate = Convert.ToString(row["METTRN_ReadingDate"]);
            decimal METTRN_CurrentReading = Convert.ToDecimal(row["METTRN_CurrentReading"]);
            decimal METTRN_PrevReading = Convert.ToDecimal(row["METTRN_PrevReading"]);
            string METTRN_CollectionDate = Convert.ToString(row["METTRN_CollectionDate"]);
            int METTRN_CreatedByUserID = Convert.ToInt32(row["METTRN_CreatedByUserID"]);
            string METTRN_CreatedDateTime = Convert.ToString(row["METTRN_CreatedDateTime"]);
            int METTRN_UpdatedByUserID = Convert.ToInt32(row["METTRN_UpdatedByUserID"]);
            string METTRN_UpdatedDateTime = Convert.ToString(row["METTRN_UpdatedDateTime"]);
            int METTRN_RowStatus = Convert.ToInt32(row["METTRN_RowStatus"]);
            long METTRN_RowVersion = (long)row["METTRN_RowVersion"];
            string METTRN_Remarks = Convert.ToString(row["METTRN_Remarks"]);
            int METTRN_ISHouseLock = Convert.ToInt16(row["METTRN_ISHouseLock"]);
            #endregion

            return new
            BILMeterReadingTRN(METTRN_ID, METTRN_ApplicationId, APPMST_CustomerID, METTRN_BillingId, METTRN_MeterNo, METTRN_ReadingDate, METTRN_CurrentReading, METTRN_PrevReading, METTRN_CollectionDate, METTRN_CreatedByUserID, METTRN_CreatedDateTime, METTRN_UpdatedByUserID, METTRN_UpdatedDateTime, METTRN_RowStatus, METTRN_RowVersion, METTRN_Remarks, METTRN_ISHouseLock);
        }

        public BILMeterReadingForReadOnlyInfo GetBILMeterReadingForReadOnlyInfo(int METTRN_Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingForReadOnlyInfo " + METTRN_Id);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int METTRN_ID = Convert.ToInt32(row["METTRN_ID"]);
            int BCCMST_BillingID = Convert.ToInt32(row["BCCMST_BillingID"]);
            string BCCMST_StartDate = row["BCCMST_StartDate"].ToString();
            string BCCMST_EndDate = row["BCCMST_EndDate"].ToString();
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            string CustomerName = row["CustomerName"].ToString();
            string CustomerAddress = row["CustomerAddress"].ToString();
            int CD_ControlID = int.Parse(row["CD_ControlID"].ToString());
            string CD_ControlType = row["CD_ControlType"].ToString();
            int PLAMST_Code = int.Parse(row["PLAMST_Code"].ToString());
            string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
            #endregion

            return new
            BILMeterReadingForReadOnlyInfo(METTRN_ID, BCCMST_BillingID, BCCMST_StartDate, BCCMST_EndDate, APPMST_AppNo, CustomerName, CustomerAddress, CD_ControlID, CD_ControlType, PLAMST_Code, PLAMST_PlanName);
        }

        public IList<BillingCycleCustomerWise> GetBillCycleCustomerWise(string billIDs)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC billcycle '" + billIDs.Replace("'", "''") + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];

            IList<BillingCycleCustomerWise> list = new List<BillingCycleCustomerWise>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                string billId = Convert.ToString(row["yearCycle"]);
                list.Add(new BillingCycleCustomerWise(billId));

                #endregion
            }
            return list;
        }

        public PRDExConnReqFormHDRTRNForReadOnlyInfo GetPRDExConnReqFormHDRTRNForReadOnlyInfo(int EXCHDR_ConnID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRNForReadOnlyInfo " + EXCHDR_ConnID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int EXCHDR_EConnID = int.Parse(row["EXCHDR_EConnID"].ToString());
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            string CustomerName = row["CustomerName"].ToString();
            string CustomerAddress = row["CustomerAddress"].ToString();
            int CD_ControlID = int.Parse(row["CD_ControlID"].ToString());
            string CD_ControlType = row["CD_ControlType"].ToString();
            int PLAMST_Code = int.Parse(row["PLAMST_Code"].ToString());
            string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
            #endregion

            return new
            PRDExConnReqFormHDRTRNForReadOnlyInfo(EXCHDR_ConnID, APPMST_AppNo, CustomerName, CustomerAddress, CD_ControlID, CD_ControlType, PLAMST_Code, PLAMST_PlanName);
        }
        public BILMeterReadingForReadOnlyInfoForCustomerId GetBILMeterReadingForReadOnlyInfoForCustomerId(string Customer_Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingForReadOnlyInfo_ForCustomerId " + Customer_Id);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            if (row != null)
            {
                #region"Variables Declaration"

                int METTRN_ID = Convert.ToInt32(row["METTRN_ID"]);
                int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"].ToString());
                string APPMST_CustomerId = row["APPMST_CustomerId"].ToString();
                string BCCMST_StartDate = row["BCCMST_StartDate"].ToString();
                string BCCMST_EndDate = row["BCCMST_EndDate"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string CustomerAddress = row["CustomerAddress"].ToString();
                int CD_ControlID = int.Parse(row["CD_ControlID"].ToString());
                string CD_ControlType = row["CD_ControlType"].ToString();
                int PLAMST_Code = int.Parse(row["PLAMST_Code"].ToString());
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();

                #endregion

                return new
                BILMeterReadingForReadOnlyInfoForCustomerId(METTRN_ID, APPMST_AppID, APPMST_CustomerId, BCCMST_StartDate, BCCMST_EndDate, APPMST_AppNo, CustomerName, CustomerAddress, CD_ControlID, CD_ControlType, PLAMST_Code, PLAMST_PlanName);
            }
            else
            {
                return null;
            }
        }

        public BILMeterReadingTRNMsg GetBILMeterReadingTRN_CheckForEdit(int METTRN_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingTRN_CheckForEdit " + METTRN_ID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public IList<BILMeterReadingTRN_SelectAll_DetailGrid> GetBILMeterReadingTRN_SelectAll_DetailGrid(string Customer_ID, int Billing_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReading_SelectAll_DetailGrid " + Customer_ID + "," + Billing_ID);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILMeterReadingTRN_SelectAll_DetailGrid> list = new List<BILMeterReadingTRN_SelectAll_DetailGrid>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                long METTRN_ID = Convert.ToInt64(row["METTRN_ID"]);
                int CMRMST_ApplicationID = Convert.ToInt32(row["CMRMST_ApplicationID"].ToString());
                long CMRMST_MeterNo = Convert.ToInt64(row["CMRMST_MeterNo"].ToString());
                decimal METTRN_PreviousReading = Convert.ToDecimal(row["METTRN_PreviousReading"].ToString());
                decimal METTRN_CurrentReading = Convert.ToDecimal(row["METTRN_CurrentReading"].ToString());
                list.Add(new BILMeterReadingTRN_SelectAll_DetailGrid(METTRN_ID, CMRMST_ApplicationID, CMRMST_MeterNo, METTRN_PreviousReading, METTRN_CurrentReading));
            }
            #endregion
            return list;
        }

        public IList<BILMeterReadingTRN_PrvReading> GetBILMeterReadingTRN_PrvReading(Decimal AppId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_MeterReadingDetail " + AppId);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILMeterReadingTRN_PrvReading> list = new List<BILMeterReadingTRN_PrvReading>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                int METTRN_BillingId = Convert.ToInt32(row["METTRN_BillingId"]);
                decimal METTRN_MeterNo = Convert.ToDecimal(row["METTRN_MeterNo"].ToString());
                decimal METTRN_CurrentReading = Convert.ToDecimal(row["METTRN_CurrentReading"].ToString());
                string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
                decimal PreviouReading = Convert.ToDecimal(row["PreviouReading"].ToString());

                list.Add(new BILMeterReadingTRN_PrvReading(METTRN_BillingId, METTRN_MeterNo, METTRN_CurrentReading, BCCMST_ShortName, PreviouReading));
            }
            #endregion
            return list;
        }
        public IList<BILMeterReadingTRN_SelectAll_DetailGrid> GetBILMeterReadingTRN_SelectAll_DetailGridEditTime(int METTRN_Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReading_SelectAll_DetailGridEditTime " + METTRN_Id);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILMeterReadingTRN_SelectAll_DetailGrid> list = new List<BILMeterReadingTRN_SelectAll_DetailGrid>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                int METTRN_ID = Convert.ToInt32(row["METTRN_ID"]);
                int METTRN_ApplicationId = Convert.ToInt32(row["METTRN_ApplicationId"].ToString());
                long METTRN_MeterNo = Convert.ToInt64(row["METTRN_MeterNo"].ToString());
                decimal METTRN_PreviousReading = Convert.ToDecimal(row["METTRN_PreviousReading"].ToString());
                decimal METTRN_CurrentReading = Convert.ToDecimal(row["METTRN_CurrentReading"].ToString());
                list.Add(new BILMeterReadingTRN_SelectAll_DetailGrid(METTRN_ID, METTRN_ApplicationId, METTRN_MeterNo, METTRN_PreviousReading, METTRN_CurrentReading));
            }
            #endregion
            return list;
        }
        public IList<BILMeterReadingForBillingCycle> GetBILMeterReadingForBillingCycle(string Crieteria, int option)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReading_ForBillingCycle '" + Crieteria + "'," + option);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILMeterReadingForBillingCycle> list = new List<BILMeterReadingForBillingCycle>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                int BCCMST_BillingID = Convert.ToInt32(row["BCCMST_BillingID"]);
                string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
                //string BCCMST_StartDate = row["string BCCMST_StartDate"].ToString();
                //string BCCMST_EndDate = row["string BCCMST_EndDate"].ToString();
                list.Add(new BILMeterReadingForBillingCycle(BCCMST_BillingID, BCCMST_ShortName));//, BCCMST_StartDate, BCCMST_EndDate));

                #endregion
            }

            return list;
        }

        //public IList<BILMeterReadingForBillingCycleEdit> GetBILMeterReadingForBillingCycleEdit(string Crieteria, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_BILMeterReading_ForBillingCycleEdit '" + Crieteria + "'");
        //    //DataRow row = _dbManager.GetDataRow(sql.ToString());

        //    DataSet ds = _dbManager.GetDataSet(sql.ToString());
        //    DataTable dtList = ds.Tables[0];
        //    //DataTable dtRowCount = ds.Tables[1];
        //    //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
        //    IList<BILMeterReadingForBillingCycleEdit> list = new List<BILMeterReadingForBillingCycleEdit>();
        //    foreach (DataRow row in dtList.Rows)
        //    {
        //        #region"Variables Declaration"

        //        int BCCMST_BillingID = Convert.ToInt32(row["BCCMST_BillingID"]);
        //        string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
        //        //string BCCMST_StartDate = row["string BCCMST_StartDate"].ToString();
        //        //string BCCMST_EndDate = row["string BCCMST_EndDate"].ToString();
        //        list.Add(new BILMeterReadingForBillingCycleEdit(BCCMST_BillingID, BCCMST_ShortName));//, BCCMST_StartDate, BCCMST_EndDate));

        //        #endregion
        //    }

        //    return list;
        //}

        public BILMeterReadingDateForBillingCycle GetBILMeterReadingDateForBillingCycle(string Crieteria, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReading_ForBillingCycle '" + Crieteria + "',0");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int BCCMST_BillingID = Convert.ToInt32(row["BCCMST_BillingID"]);
            string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
            string BCCMST_StartDate = row["BCCMST_StartDate"].ToString();
            string BCCMST_EndDate = row["BCCMST_EndDate"].ToString();


            #endregion
            return new BILMeterReadingDateForBillingCycle(BCCMST_BillingID, BCCMST_ShortName, BCCMST_StartDate, BCCMST_EndDate);
        }

        public BILMeterReadingTRNMsg InsertBILMeterReadingTRN(BILMeterReadingTRN BILMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingTRN_Insert ");
            sql.Append(BILMeterReadingTRN.METTRN_ApplicationId + ",");
            sql.Append(BILMeterReadingTRN.METTRN_BillingId + ",");
            sql.Append(BILMeterReadingTRN.METTRN_MeterNo + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_ReadingDate + "',");
            sql.Append(BILMeterReadingTRN.METTRN_CurrentReading + ",");
            sql.Append(BILMeterReadingTRN.METTRN_PrevReading + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_CollectionDate + "',");
            sql.Append(BILMeterReadingTRN.METTRN_CreatedByUserID + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_CreatedDateTime + "',");
            sql.Append(BILMeterReadingTRN.METTRN_UpdatedByUserID + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_UpdatedDateTime + "',");
            sql.Append(BILMeterReadingTRN.METTRN_RowStatus + ",");
            sql.Append(BILMeterReadingTRN.METTRN_ISHouseLock);
            // sql.Append(BILMeterReadingTRN.METTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public BILMeterReadingTRNMsg UpdateBILMeterReadingTRN(BILMeterReadingTRN BILMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingTRN_Update ");
            sql.Append(BILMeterReadingTRN.METTRN_ID + ",");
            sql.Append(BILMeterReadingTRN.METTRN_ApplicationId + ",");
            sql.Append(BILMeterReadingTRN.METTRN_BillingId + ",");
            sql.Append(BILMeterReadingTRN.METTRN_MeterNo + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_ReadingDate + "',");
            sql.Append(BILMeterReadingTRN.METTRN_CurrentReading + ",");
            sql.Append(BILMeterReadingTRN.METTRN_PrevReading + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_CollectionDate + "',");
            sql.Append(BILMeterReadingTRN.METTRN_CreatedByUserID + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_CreatedDateTime + "',");
            sql.Append(BILMeterReadingTRN.METTRN_UpdatedByUserID + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_UpdatedDateTime + "',");
            sql.Append(BILMeterReadingTRN.METTRN_RowStatus + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_Remarks.Replace("'", "''") + "',");
            sql.Append(BILMeterReadingTRN.METTRN_ISHouseLock + ",");
            sql.Append(BILMeterReadingTRN.METTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public BILMeterReadingTRNMsg DeleteBILMeterReadingTRN(int BILMeterReadingTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILMeterReadingTRN_Delete " + BILMeterReadingTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILMeterReadingTRNMsg(_RetVal, _RetStr);
        }

        public BILMeterReadingTRNMsg InsertBILMeterReadingTRN_ForCSVUpload(BILMeterReadingTRN BILMeterReadingTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_BILMeterReadingTRN_Insert_ForCSVUpload] ");
            sql.Append(BILMeterReadingTRN.METTRN_ApplicationId + ",");
            sql.Append(BILMeterReadingTRN.METTRN_BillingId + ",");
            sql.Append(BILMeterReadingTRN.METTRN_MeterNo + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_ReadingDate + "',");
            sql.Append(BILMeterReadingTRN.METTRN_CurrentReading + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_CollectionDate + "',");
            sql.Append(BILMeterReadingTRN.METTRN_CreatedByUserID + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_CreatedDateTime + "',");
            sql.Append(BILMeterReadingTRN.METTRN_UpdatedByUserID + ",");
            sql.Append("N'" + BILMeterReadingTRN.METTRN_UpdatedDateTime + "',");
            sql.Append(BILMeterReadingTRN.METTRN_RowStatus + ",");
            sql.Append(BILMeterReadingTRN.METTRN_ISHouseLock + ",");
            sql.Append(BILMeterReadingTRN.METTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILMeterReadingTRNMsg(_RetVal, _RetStr);
        }

    }
}
