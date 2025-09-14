using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class ACCChequeDTLTRNDao : IACCChequeDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCChequeDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCChequeDTLTRNList> GetACCChequeDTLTRNs()
        {
            string sortExpression = "CHQDTL_ChequeId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCChequeDTLTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCChequeDTLTRNList> GetACCChequeDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CHQDTL_ChequeId',");
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
            IList<ACCChequeDTLTRNList> list = new List<ACCChequeDTLTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CHQDTL_ChequeId = int.Parse(row["CHQDTL_ChequeId"].ToString());
                int CHQDTL_ApplicationId = int.Parse(row["CHQDTL_ApplicationId"].ToString());
                string Application_No = row["Application_No"].ToString();
                string Customer_ID = row["Customer_ID"].ToString();
                string Customer_Name = row["Customer_Name"].ToString();
                string Customer_Address = row["Customer_Address"].ToString();
                string Area = row["Area"].ToString();
                int CHQDTL_Receiptno = int.Parse(row["CHQDTL_Receiptno"].ToString());
                string Recipt_Date = row["Recipt_Date"].ToString();
                string Recipt_No = row["Recipt_No"].ToString();
                int CHQDTL_BankId = int.Parse(row["CHQDTL_BankId"].ToString());
                string BankName = row["BankName"].ToString();
                string CHQDTL_Remarks = row["CHQDTL_Remarks"].ToString();
                string CHQDTL_ChequeNo = row["CHQDTL_ChequeNo"].ToString();
                string CHQDTL_ChequeDate = row["CHQDTL_ChequeDate"].ToString();
                decimal Amount = Convert.ToDecimal(row["Amount"].ToString());
                string CHQDTL_RealizedDate = row["CHQDTL_RealizedDate"].ToString();
                string CHQDTL_DishonourDate = row["CHQDTL_DishonourDate"].ToString();
                string CHQDTL_LotID = row["CHQDTL_LotID"].ToString();
                string Status = row["Status"].ToString();
                string CHQDTL_CENCode = row["CHQDTL_CENCode"].ToString();
                string CHQDTL_MicrNo = row["CHQDTL_MicrNo"].ToString();
                string BCLTRN_DepositDate = row["BCLTRN_DepositDate"].ToString();

                list.Add(new ACCChequeDTLTRNList(CHQDTL_ChequeId, CHQDTL_ApplicationId, Application_No, Customer_ID, Customer_Name, Customer_Address, Area, CHQDTL_Receiptno, Recipt_Date, Recipt_No, CHQDTL_BankId, BankName, CHQDTL_Remarks, CHQDTL_ChequeNo, CHQDTL_ChequeDate, Amount, CHQDTL_RealizedDate, CHQDTL_DishonourDate, CHQDTL_LotID, Status, CHQDTL_CENCode, CHQDTL_MicrNo, BCLTRN_DepositDate, Count));
            }
            return list;
        }

        public IList<ACCChequeDTLTRNList> GetACCChequeDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CHQDTL_ChequeId',");
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
            DataSet ds = _dbManager.GetDataSet(sql.ToString(), ref objCon, ref trn);
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<ACCChequeDTLTRNList> list = new List<ACCChequeDTLTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CHQDTL_ChequeId = int.Parse(row["CHQDTL_ChequeId"].ToString());
                int CHQDTL_ApplicationId = 0;
                if (row["CHQDTL_ApplicationId"].ToString() != "")
                    CHQDTL_ApplicationId = int.Parse(row["CHQDTL_ApplicationId"].ToString());
                string Application_No = row["Application_No"].ToString();
                string Customer_ID = row["Customer_ID"].ToString();
                string Customer_Name = row["Customer_Name"].ToString();
                string Customer_Address = row["Customer_Address"].ToString();
                string Area = row["Area"].ToString();
                int CHQDTL_Receiptno = int.Parse(row["CHQDTL_Receiptno"].ToString());
                string Recipt_Date = row["Recipt_Date"].ToString();
                string Recipt_No = row["Recipt_No"].ToString();
                int CHQDTL_BankId = int.Parse(row["CHQDTL_BankId"].ToString());
                string BankName = row["BankName"].ToString();
                string CHQDTL_Remarks = row["CHQDTL_Remarks"].ToString();
                string CHQDTL_ChequeNo = row["CHQDTL_ChequeNo"].ToString();
                string CHQDTL_ChequeDate = row["CHQDTL_ChequeDate"].ToString();
                decimal Amount = Convert.ToDecimal(row["Amount"].ToString());
                string CHQDTL_RealizedDate = row["CHQDTL_RealizedDate"].ToString();
                string CHQDTL_DishonourDate = row["CHQDTL_DishonourDate"].ToString();
                string CHQDTL_LotID = row["CHQDTL_LotID"].ToString();
                string Status = row["Status"].ToString();
                string CHQDTL_CENCode = row["CHQDTL_CENCode"].ToString();
                string CHQDTL_MicrNo = row["CHQDTL_MicrNo"].ToString();
                string BCLTRN_DepositDate = row["BCLTRN_DepositDate"].ToString();
                list.Add(new ACCChequeDTLTRNList(CHQDTL_ChequeId, CHQDTL_ApplicationId, Application_No, Customer_ID, Customer_Name, Customer_Address, Area, CHQDTL_Receiptno, Recipt_Date, Recipt_No, CHQDTL_BankId, BankName, CHQDTL_Remarks, CHQDTL_ChequeNo, CHQDTL_ChequeDate, Amount, CHQDTL_RealizedDate, CHQDTL_DishonourDate, CHQDTL_LotID, Status, CHQDTL_CENCode, CHQDTL_MicrNo, BCLTRN_DepositDate, Count));
            }
            return list;
        }

        public IList<ACCChequeDTLTRNDepositList> GetACCChequeDTLTRNDeposits()
        {
            string sortExpression = "CHQDTL_ChequeId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            int ExportXcl = 0;
            string Type = "ChqDepDtl";
            return GetACCChequeDTLTRNDeposits(sortExpression, sortType, pageIndex, pageSize, criteria, ExportXcl, Type);
        }

        public IList<ACCChequeDTLTRNDepositList> GetACCChequeDTLTRNDeposits(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, int ExportXcl, string Type)
        {
            StringBuilder sql = new StringBuilder();
            if (ExportXcl == 2)
            {
                sql.Append("EXEC USP_ACCChequeDTLTRN_SelectForCashDeposit ");
                ExportXcl = 0;
            }
            else
            {
                sql.Append("EXEC USP_ACCChequeDTLTRN_SelectForDeposit ");
            }
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'Application_No',");
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
            sql.Append(criteria + "',");
            sql.Append(ExportXcl + ",0,'");
            sql.Append(Type + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<ACCChequeDTLTRNDepositList> list = new List<ACCChequeDTLTRNDepositList>();
            foreach (DataRow row in dtList.Rows)
            {
                int ID = int.Parse(row["ID"].ToString());
                string ChequeID = row["ChequeID"].ToString();

                int AppliID = int.Parse(row["AppliID"].ToString());
                int RECHDR_ReceiptType = int.Parse(row["RECHDR_ReceiptType"].ToString());
                string ReceiptType = row["ReceiptType"].ToString();
                Int64 CHQDTL_ReceiptNo = Int64.Parse(row["CHQDTL_ReceiptNo"].ToString());
                string ReciptNo = row["ReciptNo"].ToString();
                string Recipt_Date = row["Recipt_Date"].ToString();
                string Customer_ID = row["Customer_ID"].ToString();
                string Customer_Name = row["Customer_Name"].ToString();
                string Customer_Address = row["Customer_Address"].ToString();

                string Application_No = row["Application_No"].ToString();
                string Name = row["Name"].ToString();
                string BankID = row["BankID"].ToString();
                string BankName = row["BankName"].ToString();
                string ChequeNo = row["ChequeNo"].ToString();
                string ChequeDate = row["ChequeDate"].ToString();
                string Amount = row["Amount"].ToString();
                string RealizedDate = row["RealizedDate"].ToString();
                string LOTID = row["LOTID"].ToString();
                string CHQSTATUS = row["CHQSTATUS"].ToString();
                string Status = row["Status"].ToString();
                string MICR_No = row["MICR_No"].ToString();
                string BCLTRN_DepositDate = row["BCLTRN_DepositDate"].ToString();
                string CHQDTL_DishonourDate = row["CHQDTL_DishonourDate"].ToString();
                string CHQDTL_DisReason = row["CHQDTL_DisReason"].ToString();
                string BCHDTL_IsBounceChargeIncluded = row["BCHDTL_IsBounceChargeIncluded"].ToString();
                decimal BCHDTL_BounceCharges = decimal.Parse(row["BCHDTL_BounceCharges"].ToString());
                string BCHDTL_ChequeNo = Convert.ToString(row["BCHDTL_ChequeNo"].ToString());
                string BCHDTL_ChequeDate = row["BCHDTL_ChequeDate"].ToString();
                decimal BCHDTL_ChequeAmount = decimal.Parse(row["BCHDTL_ChequeAmount"].ToString());
                string CorporateCode = row["CorporateCode"].ToString();
                string receiptStatus = row["RECHDR_RowStatus"].ToString();
                list.Add(new ACCChequeDTLTRNDepositList(ID, ChequeID, AppliID, RECHDR_ReceiptType, ReceiptType, CHQDTL_ReceiptNo, ReciptNo, Recipt_Date, Customer_ID, Customer_Name, Customer_Address, Application_No, Name, BankID, BankName, ChequeNo, ChequeDate, Amount, RealizedDate, LOTID, CHQSTATUS, Status, MICR_No, BCLTRN_DepositDate, CHQDTL_DishonourDate, CHQDTL_DisReason, BCHDTL_IsBounceChargeIncluded, BCHDTL_BounceCharges, BCHDTL_ChequeNo, BCHDTL_ChequeDate, BCHDTL_ChequeAmount, receiptStatus, Count, CorporateCode));
            }
            return list;
        }

        public Int16 GetACCChequeDTLTRN_GetNewReceiptEntryForDishonoredCheque(Int64 ReceiptNo, int ReceiptType, Int64 ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_GetNewReceiptEntryForDishonoredCheque " + ReceiptNo + "," + ReceiptType + "," + ApplicationID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"
            Int16 CHQDTL_ChequeId = Convert.ToInt16(row[0]);
            #endregion

            return CHQDTL_ChequeId;
        }

        public ACCChequeDTLTRN GetACCChequeDTLTRN(int ACCChequeDTLTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_Select " + ACCChequeDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CHQDTL_ChequeId = Convert.ToInt32(row["CHQDTL_ChequeId"]);
            int CHQDTL_ApplicationId = Convert.ToInt32(row["CHQDTL_ApplicationId"]);
            int CHQDTL_CorporateId = Convert.ToInt32(row["CHQDTL_CorporateId"]);
            int CHQDTL_Receiptno = Convert.ToInt32(row["CHQDTL_Receiptno"]);
            int CHQDTL_BankId = Convert.ToInt32(row["CHQDTL_BankId"]);
            string CHQDTL_Remarks = Convert.ToString(row["CHQDTL_Remarks"]);
            string CHQDTL_ChequeNo = Convert.ToString(row["CHQDTL_ChequeNo"]);
            string CHQDTL_ChequeDate = Convert.ToString(row["CHQDTL_ChequeDate"]);
            decimal CHQDTL_ChequeAmount = Convert.ToDecimal(row["CHQDTL_ChequeAmount"]);
            string CHQDTL_RealizedDate = Convert.ToString(row["CHQDTL_RealizedDate"]);
            int CHQDTL_LotID = Convert.ToInt32(row["CHQDTL_LotID"]);
            int CHQDTL_Status = Convert.ToInt32(row["CHQDTL_Status"]);
            int CHQDTL_CENCode = Convert.ToInt32(row["CHQDTL_CENCode"]);
            string CHQDTL_DishonourDate = Convert.ToString(row["CHQDTL_DishonourDate"]);
            string CHQDTL_DisReason = Convert.ToString(row["CHQDTL_DisReason"]);
            decimal CHQDTL_BounceCharges = Convert.ToDecimal(row["CHQDTL_BounceCharges"]);
            int CHQDTL_CreatedByUserID = Convert.ToInt32(row["CHQDTL_CreatedByUserID"]);
            string CHQDTL_CreatedDateTime = Convert.ToString(row["CHQDTL_CreatedDateTime"]);
            int CHQDTL_UpdatedByUserID = Convert.ToInt32(row["CHQDTL_UpdatedByUserID"]);
            string CHQDTL_UpdatedDateTime = Convert.ToString(row["CHQDTL_UpdatedDateTime"]);
            int CHQDTL_RowStatus = Convert.ToInt32(row["CHQDTL_RowStatus"]);
            long CHQDTL_RowVersion = (long)row["CHQDTL_RowVersion"];
            long CHQDTL_MicrNo = Convert.ToInt64(row["CHQDTL_MicrNo"]);
            int CHQDTL_SMSFlag = int.Parse(row["CHQDTL_SMSFlag"].ToString());
            #endregion

            return new
            ACCChequeDTLTRN(CHQDTL_ChequeId, CHQDTL_ApplicationId, CHQDTL_CorporateId, CHQDTL_Receiptno, CHQDTL_BankId, CHQDTL_Remarks, CHQDTL_ChequeNo, CHQDTL_ChequeDate, CHQDTL_ChequeAmount, CHQDTL_RealizedDate, CHQDTL_LotID, CHQDTL_Status, CHQDTL_CENCode, CHQDTL_DishonourDate, CHQDTL_DisReason, CHQDTL_BounceCharges, CHQDTL_CreatedByUserID, CHQDTL_CreatedDateTime, CHQDTL_UpdatedByUserID, CHQDTL_UpdatedDateTime, CHQDTL_RowStatus, CHQDTL_RowVersion, CHQDTL_MicrNo, CHQDTL_SMSFlag);
        }

        public ACCChequeDTLTRN GetACCChequeDTLTRN(int ACCChequeDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_Select " + ACCChequeDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int CHQDTL_ChequeId = Convert.ToInt32(row["CHQDTL_ChequeId"]);
            int CHQDTL_ApplicationId = Convert.ToInt32(row["CHQDTL_ApplicationId"]);
            int CHQDTL_CorporateId = Convert.ToInt32(row["CHQDTL_CorporateId"]);
            int CHQDTL_Receiptno = Convert.ToInt32(row["CHQDTL_Receiptno"]);
            int CHQDTL_BankId = Convert.ToInt32(row["CHQDTL_BankId"]);
            string CHQDTL_Remarks = Convert.ToString(row["CHQDTL_Remarks"]);
            string CHQDTL_ChequeNo = Convert.ToString(row["CHQDTL_ChequeNo"]);
            string CHQDTL_ChequeDate = Convert.ToString(row["CHQDTL_ChequeDate"]);
            decimal CHQDTL_ChequeAmount = Convert.ToDecimal(row["CHQDTL_ChequeAmount"]);
            string CHQDTL_RealizedDate = Convert.ToString(row["CHQDTL_RealizedDate"]);
            int CHQDTL_LotID = Convert.ToInt32(row["CHQDTL_LotID"]);
            int CHQDTL_Status = Convert.ToInt32(row["CHQDTL_Status"]);
            int CHQDTL_CENCode = Convert.ToInt32(row["CHQDTL_CENCode"]);
            string CHQDTL_DishonourDate = Convert.ToString(row["CHQDTL_DishonourDate"]);
            string CHQDTL_DisReason = Convert.ToString(row["CHQDTL_DisReason"]);
            decimal CHQDTL_BounceCharges = Convert.ToDecimal(row["CHQDTL_BounceCharges"]);
            int CHQDTL_CreatedByUserID = Convert.ToInt32(row["CHQDTL_CreatedByUserID"]);
            string CHQDTL_CreatedDateTime = Convert.ToString(row["CHQDTL_CreatedDateTime"]);
            int CHQDTL_UpdatedByUserID = Convert.ToInt32(row["CHQDTL_UpdatedByUserID"]);
            string CHQDTL_UpdatedDateTime = Convert.ToString(row["CHQDTL_UpdatedDateTime"]);
            int CHQDTL_RowStatus = Convert.ToInt32(row["CHQDTL_RowStatus"]);
            long CHQDTL_RowVersion = (long)row["CHQDTL_RowVersion"];
            long CHQDTL_MicrNo = Convert.ToInt64(row["CHQDTL_MicrNo"]);
            int CHQDTL_SMSFlag = int.Parse(row["CHQDTL_SMSFlag"].ToString());
            #endregion

            return new
            ACCChequeDTLTRN(CHQDTL_ChequeId, CHQDTL_ApplicationId, CHQDTL_CorporateId, CHQDTL_Receiptno, CHQDTL_BankId, CHQDTL_Remarks, CHQDTL_ChequeNo, CHQDTL_ChequeDate, CHQDTL_ChequeAmount, CHQDTL_RealizedDate, CHQDTL_LotID, CHQDTL_Status, CHQDTL_CENCode, CHQDTL_DishonourDate, CHQDTL_DisReason, CHQDTL_BounceCharges, CHQDTL_CreatedByUserID, CHQDTL_CreatedDateTime, CHQDTL_UpdatedByUserID, CHQDTL_UpdatedDateTime, CHQDTL_RowStatus, CHQDTL_RowVersion, CHQDTL_MicrNo, CHQDTL_SMSFlag);
        }

        //public ACCChequeDTLTRNMsg InsertACCChequeDTLTRN(ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //StringBuilder sql = new StringBuilder();
        //sql.Append("EXEC Transaction_ACCChequeDTLTRN_Insert ");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_ApplicationId+",");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_Receiptno+",");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_BankId+",");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_Remarks+"',");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeNo+",");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_ChequeDate+"',");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeAmount+",");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_RealizedDate+"',");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_LotID+",");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_Status+",");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_CENCode+",");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_DishonourDate+"',");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_DisReason+"',");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_CreatedByUserID+",");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_CreatedDateTime+"',");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID+",");
        //sql.Append("N'"+ACCChequeDTLTRN.CHQDTL_UpdatedDateTime+"',");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_RowStatus+",");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_RowVersion+",");
        //sql.Append(ACCChequeDTLTRN.CHQDTL_MicrNo+",");
        //DataRow row = _dbManager.GetDataRow(sql.ToString());
        //#region"Variables Declaration"

        //int _RetVal = Convert.ToInt32(row["RetVal"]);
        //string _RetStr = Convert.ToString(row["RetVal"]);
        //#endregion

        //return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        //}

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRN(int CHKCounter, int CHQDTL_ChequeId, int CHQDTL_LotID, int CHQDTL_Status, int CHQDTL_UpdatedByUserID, ref SqlConnection cn, ref SqlTransaction trn)
        //public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRN(ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_Update " + CHKCounter + " ," + CHQDTL_ChequeId + "," + CHQDTL_LotID + "," + CHQDTL_Status + "," + CHQDTL_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);

            //sql.Append("EXEC Transaction_ACCChequeDTLTRN_Update ");
            //sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId+",");
            //sql.Append(ACCChequeDTLTRN.CHQDTL_LotID+",");

            //sql.Append(ACCChequeDTLTRN.CHQDTL_Status+",");
            //sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID);

            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            //#region"Variables Declaration"
            //int _RetVal = Convert.ToInt32(row["RetVal"]);
            //string _RetStr = Convert.ToString(row["RetVal"]);

            //#endregion

            //return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNCash(int CHKCounter, int CHQDTL_ChequeId, int CHQDTL_LotID, string CHQDTL_RealizedDate, int CHQDTL_Status, int CHQDTL_UpdatedByUserID, ref SqlConnection cn, ref SqlTransaction trn)
        //public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRN(ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_UpdateCashDeposit " + CHKCounter + " ," + CHQDTL_ChequeId + " ," + CHQDTL_LotID + ", '" + CHQDTL_RealizedDate + "'," + CHQDTL_Status + "," + CHQDTL_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChequeRealize(int ChqType, ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_UpdateChequeRealize ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ", ");
            sql.Append("'" + ACCChequeDTLTRN.CHQDTL_RealizedDate + "',");
            sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_RowVersion + ",");
            sql.Append(ChqType);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChequeDeposit(int ChqType, ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_UpdateChequeDeposit ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ", ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_RowVersion + ",");
            sql.Append(ChqType);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNCSV(string ApplicationNo, string CorporateCode, string CHQDTL_ChequeId, string CHQDTL_RealizedDate, int CHQDTL_Status, int CHQDTL_UpdatedByUserID, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCChequeDTLTRN_UpdateChequeRealize_ForCSVUpload] '" + ApplicationNo + "','" + CorporateCode + "','" + CHQDTL_ChequeId + "','" + CHQDTL_RealizedDate + "'," + CHQDTL_Status + "," + CHQDTL_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }
        //public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNCash(ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC TRN_ACCChequeDTLTRN_UpdateCashDeposit ");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ", '");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_RealizedDate + "',");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID);

        //    DataRow row = _dbManager.GetDataRow(sql.ToString());

        //    #region"Variables Declaration"
        //    int _RetVal = Convert.ToInt32(row["RetVal"]);
        //    string _RetStr = Convert.ToString(row["RetVal"]);

        //    #endregion

        //    return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        //}

        //public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChequeRealize(ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC TRN_ACCChequeDTLTRN_UpdateChequeRealize ");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ", '");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_RealizedDate + "',");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID);

        //    DataRow row = _dbManager.GetDataRow(sql.ToString());

        //    #region"Variables Declaration"
        //    int _RetVal = Convert.ToInt32(row["RetVal"]);
        //    string _RetStr = Convert.ToString(row["RetVal"]);

        //    #endregion

        //    return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        //}

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChequeDishonour(int ChqType, ACCChequeDTLTRN ACCChequeDTLTRN, string isedit, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_UpdateChequeDishonour ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ", ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_ApplicationId + ", '");
            sql.Append(ACCChequeDTLTRN.CHQDTL_DisReason + "','");
            sql.Append(ACCChequeDTLTRN.CHQDTL_DishonourDate + "',");
            sql.Append(ACCChequeDTLTRN.CHQDTL_BounceCharges + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_RowVersion + ",");
            sql.Append(ChqType + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_SMSFlag + ",");
            sql.Append(isedit);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChequeReplacement(string NewChequeNo, string NewChequeDate, decimal NewChequeAmount, int IsBounceChargesIncluded, decimal BounceCharges, int ChqType, int TariffID, ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_UpdateChequeReplacement ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ", ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_ApplicationId + ", ");
            sql.Append(ACCChequeDTLTRN.CHQDTL_CorporateId + ", ");
            sql.Append("'" + NewChequeNo + "','");
            sql.Append(NewChequeDate + "',");
            sql.Append(NewChequeAmount + ",");
            sql.Append(IsBounceChargesIncluded + ",");
            sql.Append(BounceCharges + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_CENCode + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_RowVersion + ",");
            sql.Append(ACCChequeDTLTRN.CHQDTL_BankId + ",");
            sql.Append(ChqType + ",");
            sql.Append(TariffID);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChangeStatus(int CHKCounter, int CHQDTL_ChequeId, int CHQDTL_Status, int CHQDTL_UpdatedByUserID, int CHQStatus, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCChequeDTLTRN_UpdateChangeStatus " + CHKCounter + " ," + CHQDTL_ChequeId + "," + CHQDTL_Status + "," + CHQDTL_UpdatedByUserID + "," + CHQStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        }
        //public ACCChequeDTLTRNMsg UpdateACCChequeDTLTRNChangeStatus(ACCChequeDTLTRN ACCChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC TRN_ACCChequeDTLTRN_UpdateChangeStatus ");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_ChequeId + ",");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_Status + ",");
        //    sql.Append(ACCChequeDTLTRN.CHQDTL_UpdatedByUserID);

        //    DataRow row = _dbManager.GetDataRow(sql.ToString());

        //    #region"Variables Declaration"
        //    int _RetVal = Convert.ToInt32(row["RetVal"]);
        //    string _RetStr = Convert.ToString(row["RetVal"]);

        //    #endregion

        //    return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        //}

        //public ACCChequeDTLTRNMsg DeleteACCChequeDTLTRN(int ACCChequeDTLTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //StringBuilder sql = new StringBuilder();
        //sql.Append("EXEC Transaction_ACCChequeDTLTRN_Delete "+ACCChequeDTLTRNID);
        //DataRow row = _dbManager.GetDataRow(sql.ToString());

        //#region"Variables Declaration"

        //int _RetVal = Convert.ToInt32(row["RetVal"]);
        //string _RetStr = Convert.ToString(row["RetVal"]);

        //#endregion

        //return new ACCChequeDTLTRNMsg(_RetVal, _RetStr);
        //}

    }
}
