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
    public class ACCBounceChequeDTLTRNDao : IACCBounceChequeDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCBounceChequeDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCBounceChequeDTLTRNList> GetACCBounceChequeDTLTRNs()
        {
            string sortExpression = "BCHDTL_ChequeID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCBounceChequeDTLTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCBounceChequeDTLTRNList> GetACCBounceChequeDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'BCHDTL_ChequeID',");
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
            IList<ACCBounceChequeDTLTRNList> list = new List<ACCBounceChequeDTLTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int BCHDTL_ChequeID = int.Parse(row["BCHDTL_ChequeID"].ToString());
                string CHQDTL_Receiptno = row["CHQDTL_Receiptno"].ToString();
                string Recipt_No = row["Recipt_No"].ToString();
                string Recipt_Date = row["Recipt_Date"].ToString();
                string BCHDTL_ChequeNo = row["BCHDTL_ChequeNo"].ToString();
                string BCHDTL_ChequeDate = row["BCHDTL_ChequeDate"].ToString();
                string Amount = row["Amount"].ToString();
                string Application_No = row["Application_No"].ToString();
                string Customer_ID = row["Customer_ID"].ToString();
                string Customer_Name = row["Customer_Name"].ToString();
                string Customer_Address = row["Customer_Address"].ToString();
                string Area = row["Area"].ToString();
                string Status = row["Status"].ToString();
                int BCHDTL_BankID = Convert.ToInt32(row["BCHDTL_BankID"]);
                string BankName = row["BankName"].ToString();
                string MicrNo = row["MicrNo"].ToString();
                int BCHDTL_IsBounceChargeIncluded = int.Parse(row["BCHDTL_IsBounceChargeIncluded"].ToString());
                decimal BCHDTL_BounceCharges = decimal.Parse(row["BCHDTL_BounceCharges"].ToString());

                list.Add(new ACCBounceChequeDTLTRNList(BCHDTL_ChequeID, CHQDTL_Receiptno, Recipt_No, Recipt_Date, BCHDTL_ChequeNo, BCHDTL_ChequeDate, Amount, Application_No, Customer_ID, Customer_Name, Customer_Address, Area, Status, BCHDTL_BankID, BankName, MicrNo, BCHDTL_IsBounceChargeIncluded, BCHDTL_BounceCharges, Count));
            }
            return list;
        }

        public IList<ACCBounceChequeDTLTRNList> GetACCBounceChequeDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'BCHDTL_ChequeID',");
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
            IList<ACCBounceChequeDTLTRNList> list = new List<ACCBounceChequeDTLTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int BCHDTL_ChequeID = int.Parse(row["BCHDTL_ChequeID"].ToString());
                string CHQDTL_Receiptno = row["CHQDTL_Receiptno"].ToString();
                string Recipt_No = row["Recipt_No"].ToString();
                string Recipt_Date = row["Recipt_Date"].ToString();
                string BCHDTL_ChequeNo = row["BCHDTL_ChequeNo"].ToString();
                string BCHDTL_ChequeDate = row["BCHDTL_ChequeDate"].ToString();
                string Amount = row["Amount"].ToString();
                string Application_No = row["Application_No"].ToString();
                string Customer_ID = row["Customer_ID"].ToString();
                string Customer_Name = row["Customer_Name"].ToString();
                string Customer_Address = row["Customer_Address"].ToString();
                string Area = row["Area"].ToString();
                int BankID = Convert.ToInt32(row["BCHDTL_BankID"]);
                string Status = row["Status"].ToString();
                string BankName = row["BankName"].ToString();
                string MicrNo = row["MicrNo"].ToString();
                int BCHDTL_IsBounceChargeIncluded = int.Parse(row["BCHDTL_IsBounceChargeIncluded"].ToString());
                decimal BCHDTL_BounceCharges = decimal.Parse(row["BCHDTL_BounceCharges"].ToString());

                list.Add(new ACCBounceChequeDTLTRNList(BCHDTL_ChequeID, CHQDTL_Receiptno, Recipt_No, Recipt_Date, BCHDTL_ChequeNo, BCHDTL_ChequeDate, Amount, Application_No, Customer_ID, Customer_Name, Customer_Address, Area, Status, BankID, BankName, MicrNo, BCHDTL_IsBounceChargeIncluded, BCHDTL_BounceCharges, Count));
            }
            return list;
        }

        public ACCBounceChequeDTLTRN GetACCBounceChequeDTLTRN(int ACCBounceChequeDTLTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_Select " + ACCBounceChequeDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int BCHDTL_ChequeID = Convert.ToInt32(row["BCHDTL_ChequeID"]);
            int BCHDTL_ApplicationId = Convert.ToInt32(row["BCHDTL_ApplicationId"]);
            int BCHDTL_CorporateId = Convert.ToInt32(row["BCHDTL_CorporateId"]);
            int BCHDTL_OldChequeID = Convert.ToInt32(row["BCHDTL_OldChequeID"]);
            int BCHDTL_BankId = Convert.ToInt32(row["BCHDTL_BankId"]);
            string BCHDTL_Remarks = Convert.ToString(row["BCHDTL_Remarks"]);
            string BCHDTL_ChequeNo = Convert.ToString(row["BCHDTL_ChequeNo"]);
            string BCHDTL_ChequeDate = Convert.ToString(row["BCHDTL_ChequeDate"]);
            int BCHDTL_ChequeAmount = Convert.ToInt32(row["BCHDTL_ChequeAmount"]);
            int BCHDTL_LotID = Convert.ToInt32(row["BCHDTL_LotID"]);
            string BCHDTL_RealizedDate = Convert.ToString(row["BCHDTL_RealizedDate"]);
            int BCHDTL_Status = Convert.ToInt32(row["BCHDTL_Status"]);
            int BCHDTL_CENcode = Convert.ToInt32(row["BCHDTL_CENcode"]);
            string BCHDTL_DishonourDate = Convert.ToString(row["BCHDTL_DishonourDate"]);
            string BCHDTL_DisReason = Convert.ToString(row["BCHDTL_DisReason"]);
            int BCHDTL_IsBounceChargeIncluded = Convert.ToInt32(row["BCHDTL_IsBounceChargeIncluded"]);
            decimal BCHDTL_BounceCharges = Convert.ToDecimal(row["BCHDTL_BounceCharges"]);
            int BCHDTL_CreatedByUserID = Convert.ToInt32(row["BCHDTL_CreatedByUserID"]);
            string BCHDTL_CreatedDateTime = Convert.ToString(row["BCHDTL_CreatedDateTime"]);
            int BCHDTL_UpdatedByUserID = Convert.ToInt32(row["BCHDTL_UpdatedByUserID"]);
            string BCHDTL_UpdatedDateTime = Convert.ToString(row["BCHDTL_UpdatedDateTime"]);
            int BCHDTL_RowStatus = Convert.ToInt32(row["BCHDTL_RowStatus"]);
            long BCHDTL_RowVersion = (long)row["BCHDTL_RowVersion"];

            #endregion

            return new
            ACCBounceChequeDTLTRN(BCHDTL_ChequeID, BCHDTL_ApplicationId, BCHDTL_CorporateId, BCHDTL_OldChequeID, BCHDTL_BankId, BCHDTL_Remarks, BCHDTL_ChequeNo, BCHDTL_ChequeDate, BCHDTL_ChequeAmount, BCHDTL_LotID, BCHDTL_RealizedDate, BCHDTL_Status, BCHDTL_CENcode, BCHDTL_DishonourDate, BCHDTL_DisReason, BCHDTL_IsBounceChargeIncluded, BCHDTL_BounceCharges, BCHDTL_CreatedByUserID, BCHDTL_CreatedDateTime, BCHDTL_UpdatedByUserID, BCHDTL_UpdatedDateTime, BCHDTL_RowStatus, BCHDTL_RowVersion);
        }

        public ACCBounceChequeDTLTRN GetACCBounceChequeDTLTRN(int ACCBounceChequeDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_Select " + ACCBounceChequeDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int BCHDTL_ChequeID = Convert.ToInt32(row["BCHDTL_ChequeID"]);
            int BCHDTL_ApplicationId = Convert.ToInt32(row["BCHDTL_ApplicationId"]);
            int BCHDTL_CorporateId = Convert.ToInt32(row["BCHDTL_CorporateId"]);
            int BCHDTL_OldChequeID = Convert.ToInt32(row["BCHDTL_OldChequeID"]);
            int BCHDTL_BankId = Convert.ToInt32(row["BCHDTL_BankId"]);
            string BCHDTL_Remarks = Convert.ToString(row["BCHDTL_Remarks"]);
            string BCHDTL_ChequeNo = Convert.ToString(row["BCHDTL_ChequeNo"]);
            string BCHDTL_ChequeDate = Convert.ToString(row["BCHDTL_ChequeDate"]);
            int BCHDTL_ChequeAmount = Convert.ToInt32(row["BCHDTL_ChequeAmount"]);
            int BCHDTL_LotID = Convert.ToInt32(row["BCHDTL_LotID"]);
            string BCHDTL_RealizedDate = Convert.ToString(row["BCHDTL_RealizedDate"]);
            int BCHDTL_Status = Convert.ToInt32(row["BCHDTL_Status"]);
            int BCHDTL_CENcode = Convert.ToInt32(row["BCHDTL_CENcode"]);
            string BCHDTL_DishonourDate = Convert.ToString(row["BCHDTL_DishonourDate"]);
            string BCHDTL_DisReason = Convert.ToString(row["BCHDTL_DisReason"]);
            int BCHDTL_IsBounceChargeIncluded = Convert.ToInt32(row["BCHDTL_IsBounceChargeIncluded"]);
            decimal BCHDTL_BounceCharges = Convert.ToDecimal(row["BCHDTL_BounceCharges"]);
            int BCHDTL_CreatedByUserID = Convert.ToInt32(row["BCHDTL_CreatedByUserID"]);
            string BCHDTL_CreatedDateTime = Convert.ToString(row["BCHDTL_CreatedDateTime"]);
            int BCHDTL_UpdatedByUserID = Convert.ToInt32(row["BCHDTL_UpdatedByUserID"]);
            string BCHDTL_UpdatedDateTime = Convert.ToString(row["BCHDTL_UpdatedDateTime"]);
            int BCHDTL_RowStatus = Convert.ToInt32(row["BCHDTL_RowStatus"]);
            long BCHDTL_RowVersion = (long)row["BCHDTL_RowVersion"];

            #endregion

            return new
            ACCBounceChequeDTLTRN(BCHDTL_ChequeID, BCHDTL_ApplicationId, BCHDTL_CorporateId, BCHDTL_OldChequeID, BCHDTL_BankId, BCHDTL_Remarks, BCHDTL_ChequeNo, BCHDTL_ChequeDate, BCHDTL_ChequeAmount, BCHDTL_LotID, BCHDTL_RealizedDate, BCHDTL_Status, BCHDTL_CENcode, BCHDTL_DishonourDate, BCHDTL_DisReason, BCHDTL_IsBounceChargeIncluded, BCHDTL_BounceCharges, BCHDTL_CreatedByUserID, BCHDTL_CreatedDateTime, BCHDTL_UpdatedByUserID, BCHDTL_UpdatedDateTime, BCHDTL_RowStatus, BCHDTL_RowVersion);
        }

        public ACCBounceChequeDTLTRNMsg InsertACCBounceChequeDTLTRN(ACCBounceChequeDTLTRN ACCBounceChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_Insert ");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ChequeID + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ApplicationId + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_OldChequeID + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_BankId + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ChequeNo + ",' ");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ChequeDate + "',");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ChequeAmount + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_Status + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_CENcode + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_IsBounceChargeIncluded + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_BounceCharges + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_CreatedByUserID + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_RowStatus + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new ACCBounceChequeDTLTRNMsg(_RetVal, _RetStr);
        }

        public ACCBounceChequeDTLTRNMsg UpdateACCBounceChequeDTLTRN(ACCBounceChequeDTLTRN ACCBounceChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_Update ");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ChequeID + ",'");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_ChequeDate + "',");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_Status + ",");
            sql.Append(ACCBounceChequeDTLTRN.BCHDTL_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCBounceChequeDTLTRNMsg(_RetVal, _RetStr);
        }
        //public ACCBounceChequeDTLTRNMsg UpdateACCBounceChequeDTLTRNForChangeStatus(ACCBounceChequeDTLTRN ACCBounceChequeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC TRN_ACCBounceChequeDTLTRN_UpdateForChangeStatus ");
        //    sql.Append(ACCBounceChequeDTLTRN.BCHDTL_OldChequeID + ",");
        //    sql.Append(ACCBounceChequeDTLTRN.BCHDTL_Status + ",");
        //    sql.Append(ACCBounceChequeDTLTRN.BCHDTL_UpdatedByUserID);
        //    DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
        //    #region"Variables Declaration"

        //    int _RetVal = Convert.ToInt32(row["RetVal"]);
        //    string _RetStr = Convert.ToString(row["RetVal"]);

        //    #endregion

        //    return new ACCBounceChequeDTLTRNMsg(_RetVal, _RetStr);
        //}
        public ACCBounceChequeDTLTRNMsg UpdateACCBounceChequeDTLTRNForChangeStatus(int CHKCounter, int BCHDTL_OldChequeID, int BCHDTL_Status, int BCHDTL_UpdatedByUserID, int CHQStatus, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_UpdateForChangeStatus " + CHKCounter + " ," + BCHDTL_OldChequeID + "," + BCHDTL_Status + "," + BCHDTL_UpdatedByUserID + "," + CHQStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCBounceChequeDTLTRNMsg(_RetVal, _RetStr);
        }


        public ACCBounceChequeDTLTRNMsg UpdateACCBounceChequeDTLTRNForChequeRepresentation(int CHKCounter, int BCHDTL_ChequeID, string BCHDTL_ChequeDate, int BCHDTL_Status, int BCHDTL_UpdatedByUserID, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_UpdateChequeRepresentation " + CHKCounter + " ," + BCHDTL_ChequeID + ",'" + BCHDTL_ChequeDate + "'," + BCHDTL_Status + "," + BCHDTL_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ACCBounceChequeDTLTRNMsg(_RetVal, _RetStr);
        }


        public ACCBounceChequeDTLTRNMsg DeleteACCBounceChequeDTLTRN(int BCHDTL_OldChequeID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBounceChequeDTLTRN_Delete " + BCHDTL_OldChequeID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCBounceChequeDTLTRNMsg(_RetVal, _RetStr);
        }

    }
}
