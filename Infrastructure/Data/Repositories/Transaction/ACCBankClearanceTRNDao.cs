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
    public class ACCBankClearanceTRNDao : IACCBankClearanceTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCBankClearanceTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCBankClearanceTRNList> GetACCBankClearanceTRNs()
        {
            string sortExpression = "BCLTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCBankClearanceTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCBankClearanceTRNList> GetACCBankClearanceTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBankClearanceTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'BCLTRN_ID',");
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
            IList<ACCBankClearanceTRNList> list = new List<ACCBankClearanceTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int BCLTRN_ID = int.Parse(row["BCLTRN_ID"].ToString());
                string BCLTRN_LotNo = row["BCLTRN_LotNo"].ToString();
                string BCLTRN_DepositDate = row["BCLTRN_DepositDate"].ToString();
                string BANMST_BankName = row["BANMST_BankName"].ToString();
                string BCLTRN_CMSCode = row["BCLTRN_CMSCode"].ToString();
                int BCLTRN_LotQty = Int32.Parse(row["BCLTRN_LotQty"].ToString());
                decimal BCLTRN_LotAmt = decimal.Parse(row["BCLTRN_LotAmt"].ToString());

                list.Add(new ACCBankClearanceTRNList(BCLTRN_ID, BCLTRN_LotNo, BCLTRN_DepositDate, BANMST_BankName, BCLTRN_CMSCode, BCLTRN_LotQty, BCLTRN_LotAmt, Count));
            }
            return list;
        }

        public ACCBankClearanceTRN GetACCBankClearanceTRN(int ACCBankClearanceTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBankClearanceTRN_Select " + ACCBankClearanceTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int BCLTRN_ID = Convert.ToInt32(row["BCLTRN_ID"]);
            string BCLTRN_LotNo = Convert.ToString(row["BCLTRN_LotNo"]);
            string BCLTRN_DepositDate = Convert.ToString(row["BCLTRN_DepositDate"]);
            int BCLTRN_BankID = Convert.ToInt32(row["BCLTRN_BankID"]);
            int BCLTRN_CENCode = Convert.ToInt32(row["BCLTRN_CENCode"]);
            int BCLTRN_CreatedByUserID = Convert.ToInt32(row["BCLTRN_CreatedByUserID"]);
            string BCLTRN_CreatedDateTime = Convert.ToString(row["BCLTRN_CreatedDateTime"]);
            int BCLTRN_UpdatedByUserID = Convert.ToInt32(row["BCLTRN_UpdatedByUserID"]);
            string BCLTRN_UpdatedDateTime = Convert.ToString(row["BCLTRN_UpdatedDateTime"]);
            int BCLTRN_RowStatus = Convert.ToInt32(row["BCLTRN_RowStatus"]);
            string BCLTRN_CMSCode = Convert.ToString(row["BCLTRN_CMSCode"]);
            int BCLTRN_LotQty = Convert.ToInt32(row["BCLTRN_LotQty"]);
            decimal BCLTRN_LotAmt = Convert.ToDecimal(row["BCLTRN_LotAmt"]);
            int BCLTRN_PayMode = Convert.ToInt32(row["BCLTRN_PayMode"]);
            long BCLTRN_RowVersion = (long)row["BCLTRN_RowVersion"];
            string ChequeIDs = "";
            string BounceChequeIDs = "";
            #endregion

            return new
            ACCBankClearanceTRN(BCLTRN_ID, BCLTRN_LotNo, BCLTRN_DepositDate, BCLTRN_BankID, BCLTRN_CENCode, BCLTRN_CreatedByUserID, BCLTRN_CreatedDateTime, BCLTRN_UpdatedByUserID, BCLTRN_UpdatedDateTime, BCLTRN_RowStatus, BCLTRN_CMSCode, BCLTRN_LotQty, BCLTRN_LotAmt, BCLTRN_RowVersion, ChequeIDs, BounceChequeIDs, BCLTRN_PayMode);
        }

        public ACCBankClearanceTRNMsg InsertACCBankClearanceTRN(ACCBankClearanceTRN ACCBankClearanceTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCBankClearanceTRN_Insert 0," + "' ");
            //sql.Append(ACCBankClearanceTRN.BCLTRN_LotNo+"',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_DepositDate + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_BankID + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CENCode + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CreatedByUserID + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_RowStatus + ",'");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CMSCode + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_LotQty + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_LotAmt + ",");
            sql.Append("'" + ACCBankClearanceTRN.ChequeIDs + "',");
            sql.Append("'" + ACCBankClearanceTRN.BounceChequeIDs + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_PayMode);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCBankClearanceTRNMsg(_RetVal, _RetStr);
        }

        public ACCBankClearanceTRNMsg UpdateACCBankClearanceTRN(ACCBankClearanceTRN ACCBankClearanceTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCBankClearanceTRN_Update] ");
            sql.Append(ACCBankClearanceTRN.BCLTRN_ID + ",");
            sql.Append("N'" + ACCBankClearanceTRN.BCLTRN_DepositDate + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_BankID + ",");
            sql.Append("'" + ACCBankClearanceTRN.BCLTRN_CMSCode + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_LotQty + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_LotAmt + ",");
            sql.Append("'" + ACCBankClearanceTRN.ChequeIDs + "',");
            sql.Append("'" + ACCBankClearanceTRN.BounceChequeIDs + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_PayMode + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CENCode + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_UpdatedByUserID + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCBankClearanceTRNMsg(_RetVal, _RetStr);
        }

        public ACCBankClearanceTRNMsg DeleteACCBankClearanceTRN(string ACCBankClearanceTRNIDs, int ChqType, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCBankClearanceTRN_Delete] '" + ACCBankClearanceTRNIDs + "'," + ChqType);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCBankClearanceTRNMsg(_RetVal, _RetStr);
        }

        public ACCBankClearanceTRNMsg InsertACCBankClearanceTRNForCSVUpload(ACCBankClearanceTRN ACCBankClearanceTRN, string ChequeNos, string AppNos, string CorpCodes, string Amounts, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCBankClearanceTRN_Insert_ForCSVUpload] 0,'");
            sql.Append(ACCBankClearanceTRN.BCLTRN_DepositDate + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_BankID + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CENCode + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CreatedByUserID + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_RowStatus + ",'");
            sql.Append(ACCBankClearanceTRN.BCLTRN_CMSCode + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_LotQty + ",");
            sql.Append(ACCBankClearanceTRN.BCLTRN_LotAmt + ",");
            sql.Append("'" + ChequeNos + "',");
            sql.Append("'" + AppNos + "',");
            sql.Append("'" + CorpCodes + "',");
            sql.Append("'" + Amounts + "',");
            sql.Append(ACCBankClearanceTRN.BCLTRN_PayMode);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCBankClearanceTRNMsg(_RetVal, _RetStr);
        }

        //public ACCBankClearanceTRNMsg InsertACCBankClearanceTRNForCSVUpload_old(int BCLTRN_ID, string ChequeNo, string DepositDate, string ApplicationNo, string CorporateCode, decimal Amount, int BankCode, int BCLTRN_LotQty, decimal BCLTRN_LotAmt,int UserId,int CenterId, ref SqlConnection cn, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_ACCBankClearanceTRN_Insert_ForCSVUpload " + BCLTRN_ID + ",'" + ChequeNo + "','" + 
        //        DepositDate + "' ,'" + ApplicationNo + "','" + CorporateCode + "'," + Amount + "," + BankCode + ",''," + 
        //        BCLTRN_LotQty + "," + BCLTRN_LotAmt + "," + UserId + "," + CenterId + ",0");
        //    DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
        //    #region "Variables Declaration"
        //    int _RetVal = int.Parse(row["RetVal"].ToString());
        //    string _RetStr = row["RetStr"].ToString();
        //    #endregion
        //    return new ACCBankClearanceTRNMsg(_RetVal, _RetStr);
        //}


    }
}
