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
    public class ACCCreditNoteTRNDao : IACCCreditNoteTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCCreditNoteTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCCreditNoteTRNList> GetACCCreditNoteTRNs()
        {
            string sortExpression = "CRNT_CreditNoteNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCCreditNoteTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCCreditNoteTRNList> GetACCCreditNoteTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCCreditNoteTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CRNT_CreditNoteNo',");
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
            IList<ACCCreditNoteTRNList> list = new List<ACCCreditNoteTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                decimal CRNT_CreditNoteNo = decimal.Parse(row["CRNT_CreditNoteNo"].ToString());
                string CRNT_CreditNoteRefNo = row["CRNT_CreditNoteRefNo"].ToString();
                string CRNT_Date = row["CRNT_Date"].ToString();
                string CRNT_CreditNoteType = row["CRNT_CreditNoteType"].ToString();
                decimal CRNT_ChequeAmount = decimal.Parse(row["CRNT_ChequeAmount"].ToString());
                decimal CRNT_Chequebalance = decimal.Parse(row["CRNT_Chequebalance"].ToString());
                string Appno = row["Appno"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string Name = row["Name"].ToString();
                string Area = row["area"].ToString();
                string CRNT_RowStatus = row["CRNT_RowStatus"].ToString();
                list.Add(new ACCCreditNoteTRNList(CRNT_CreditNoteNo, CRNT_CreditNoteRefNo, CRNT_Date, CRNT_CreditNoteType, CRNT_ChequeAmount, CRNT_Chequebalance, Appno, APPMST_CustomerID, Name, Area, CRNT_RowStatus, Count));

            }
            return list;
        }

        public ACCCreditNoteTRN GetACCCreditNoteTRN(decimal ACCCreditNoteTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCCreditNoteTRN_Select " + ACCCreditNoteTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal CRNT_CreditNoteNo = Convert.ToDecimal(row["CRNT_CreditNoteNo"]);
            string CRNT_CreditNoteRefNo = Convert.ToString(row["CRNT_CreditNoteRefNo"]);
            string CRNT_Date = Convert.ToString(row["CRNT_Date"]);
            int CRNT_CorporateID = Convert.ToInt32(row["CRNT_CorporateID"]);
            decimal CRNT_ApplicationID = Convert.ToDecimal(row["CRNT_ApplicationID"]);
            int CRNT_CreditNoteType = Convert.ToInt32(row["CRNT_CreditNoteType"]);
            decimal CRNT_ChequeAmount = Convert.ToDecimal(row["CRNT_ChequeAmount"]);
            int CRNT_CreatedByUserID = Convert.ToInt32(row["CRNT_CreatedByUserID"]);
            string CRNT_CreatedDateTime = Convert.ToString(row["CRNT_CreatedDateTime"]);
            int CRNT_UpdatedByUserID = Convert.ToInt32(row["CRNT_UpdatedByUserID"]);
            string CRNT_UpdatedDateTime = Convert.ToString(row["CRNT_UpdatedDateTime"]);
            int CRNT_RowStatus = Convert.ToInt32(row["CRNT_RowStatus"]);
            long CRNT_RowVersion = (long)row["CRNT_RowVersion"];
            int centercode = 0;
            int CRNT_SMSFlag = 0;
            string CRNT_Remark = row["CRNT_Remark"].ToString();
            #endregion

            return new
            ACCCreditNoteTRN(CRNT_CreditNoteNo, CRNT_CreditNoteRefNo, CRNT_Date, CRNT_CorporateID, CRNT_ApplicationID, CRNT_CreditNoteType, CRNT_ChequeAmount, CRNT_CreatedByUserID, CRNT_CreatedDateTime, CRNT_UpdatedByUserID, CRNT_UpdatedDateTime, CRNT_RowStatus, CRNT_RowVersion, centercode, CRNT_SMSFlag, CRNT_Remark);
        }

        public ACCCreditNoteTRNMsg InsertACCCreditNoteTRN(ACCCreditNoteTRN ACCCreditNoteTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCCreditNoteTRN_Insert ");
            sql.Append("'" + ACCCreditNoteTRN.CRNT_Date + "',");
            sql.Append(ACCCreditNoteTRN.CRNT_CorporateID + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_ApplicationID + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_CreditNoteType + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_ChequeAmount + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_CreatedByUserID + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_RowStatus + ",");
            sql.Append(ACCCreditNoteTRN.centercode + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_SMSFlag + ",");
            sql.Append("'" + ACCCreditNoteTRN.CRNT_Remark + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCCreditNoteTRNMsg(_RetVal, _RetStr);
        }

        public ACCCreditNoteTRNMsg UpdateACCCreditNoteTRN(ACCCreditNoteTRN ACCCreditNoteTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCCreditNoteTRN_Update ");
            sql.Append(ACCCreditNoteTRN.CRNT_CreditNoteNo + ",");
            sql.Append("'" + ACCCreditNoteTRN.CRNT_Date + "',");
            sql.Append("'" + ACCCreditNoteTRN.CRNT_Remark.Replace("'", "''") + "',");
            sql.Append(ACCCreditNoteTRN.CRNT_UpdatedByUserID + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_RowStatus + ",");
            sql.Append(ACCCreditNoteTRN.CRNT_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCCreditNoteTRNMsg(_RetVal, _RetStr);
        }

        public ACCCreditNoteTRNMsg DeleteACCCreditNoteTRN(int ACCCreditNoteTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_ACCCreditNoteTRN_Delete " + ACCCreditNoteTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCCreditNoteTRNMsg(_RetVal, _RetStr);
        }

    }
}
