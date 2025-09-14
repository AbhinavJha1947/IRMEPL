using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class ACCReceiptHDRTRNDao : IACCReceiptHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCReceiptHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCReceiptHDRTRNList> GetACCReceiptHDRTRNs()
        {
            string sortExpression = "RECHDR_ReceiptNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCReceiptHDRTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCReceiptHDRTRNList> GetACCReceiptHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCReceiptHDRTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'RECHDR_ReceiptNo',");
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
            IList<ACCReceiptHDRTRNList> list = new List<ACCReceiptHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                decimal RECHDR_ReceiptNo = decimal.Parse(row["RECHDR_ReceiptNo"].ToString());
                string RECHDR_ReceiptRefNo = row["RECHDR_ReceiptRefNo"].ToString();
                string RECHDR_Date = row["RECHDR_Date"].ToString();
                string RECHDR_ReceiptType = row["RECHDR_ReceiptType"].ToString();
                string RECHDR_PayMode = row["RECHDR_PayMode"].ToString();
                decimal RECHDR_ChequeAmount = decimal.Parse(row["RECHDR_ChequeAmount"].ToString());
                string Appno = row["Appno"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string Name = row["Name"].ToString();
                string Area = row["area"].ToString();
                string RECHDR_ChequeNo = row["RECHDR_ChequeNo"].ToString();
                decimal Balance = decimal.Parse(row["Balance"].ToString());
                string RECHDR_ChequeStatus = row["RECHDR_ChequeStatus"].ToString();
                string RECHDR_RowStatus = row["RECHDR_RowStatus"].ToString();
                int RECHDR_ReceiptId = int.Parse(row["RECHDR_ReceiptId"].ToString());
                list.Add(new ACCReceiptHDRTRNList(RECHDR_ReceiptNo, RECHDR_ReceiptRefNo, RECHDR_Date, RECHDR_ReceiptType, RECHDR_PayMode, RECHDR_ChequeAmount, Appno, APPMST_CustomerID, Name, Area, RECHDR_ChequeNo, Balance, RECHDR_ChequeStatus, RECHDR_RowStatus, RECHDR_ReceiptId, Count));
            }
            return list;
        }
        public IList<ACCReceiptHDRTRNList> GetChecqueStatus(string RECHDR_ApplicationID, string RECHDR_ReceiptType)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCReceiptHDRTRN_Select_ChecqueStatus ");
            sql.Append(RECHDR_ApplicationID + ",");
            sql.Append(RECHDR_ReceiptType);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<ACCReceiptHDRTRNList> list = new List<ACCReceiptHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int ChecqueStatus = Convert.ToInt32(row["RECHDR_PayStatus"].ToString());
                list.Add(new ACCReceiptHDRTRNList(ChecqueStatus));
            }
            return list;
        }

        public ACCReceiptHDRTRN GetACCReceiptHDRTRN(decimal ACCReceiptHDRTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCReceiptHDRTRN_Select " + ACCReceiptHDRTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal RECHDR_ReceiptNo = Convert.ToDecimal(row["RECHDR_ReceiptNo"]);
            string RECHDR_ReceiptRefNo = Convert.ToString(row["RECHDR_ReceiptRefNo"]);
            string RECHDR_Date = Convert.ToString(row["RECHDR_Date"]);
            int RECHDR_CorporateID = Convert.ToInt32(row["RECHDR_CorporateID"]);
            decimal RECHDR_ApplicationID = Convert.ToDecimal(row["RECHDR_ApplicationID"]);
            int RECHDR_ReceiptType = Convert.ToInt32(row["RECHDR_ReceiptType"]);
            Int32 RECHDR_PayMode = Convert.ToInt32(row["RECHDR_PayMode"]);
            string RECHDR_ChequeNo = Convert.ToString(row["RECHDR_ChequeNo"]);
            string RECHDR_ChequeDate = Convert.ToString(row["RECHDR_ChequeDate"]);
            decimal RECHDR_ChequeAmount = Convert.ToDecimal(row["RECHDR_ChequeAmount"]);
            int RECHDR_CreatedByUserID = Convert.ToInt32(row["RECHDR_CreatedByUserID"]);
            string RECHDR_CreatedDateTime = Convert.ToString(row["RECHDR_CreatedDateTime"]);
            int RECHDR_UpdatedByUserID = Convert.ToInt32(row["RECHDR_UpdatedByUserID"]);
            string RECHDR_UpdatedDateTime = Convert.ToString(row["RECHDR_UpdatedDateTime"]);
            int RECHDR_RowStatus = Convert.ToInt32(row["RECHDR_RowStatus"]);
            long RECHDR_RowVersion = (long)row["RECHDR_RowVersion"];
            int bankid = 0;
            int centercode = 0;
            Int64 CHQDTL_MicrNo = Convert.ToInt64(row["CHQDTL_MicrNo"]);
            int RECHDR_SMSFlag = 0;
            string RECHDR_Remark = row["RECHDR_Remark"].ToString();
            int RECHDR_PayStatus = Convert.ToInt32(row["RECHDR_PayStatus"]);
            int Editable = Convert.ToInt32(row["Editable"]);
            #endregion

            return new
            ACCReceiptHDRTRN(RECHDR_ReceiptNo, RECHDR_ReceiptRefNo, RECHDR_Date, RECHDR_CorporateID, RECHDR_ApplicationID, RECHDR_ReceiptType, RECHDR_PayMode, RECHDR_ChequeNo, RECHDR_ChequeDate, RECHDR_ChequeAmount, RECHDR_CreatedByUserID, RECHDR_CreatedDateTime, RECHDR_UpdatedByUserID, RECHDR_UpdatedDateTime, RECHDR_RowStatus, RECHDR_RowVersion, bankid, centercode, CHQDTL_MicrNo, RECHDR_SMSFlag, RECHDR_Remark, RECHDR_PayStatus, Editable);
        }

        public ACCReceiptHDRTRNMsg InsertACCReceiptHDRTRN(ACCReceiptHDRTRN ACCReceiptHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCReceiptHDRTRN_Insert ");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_Date + "',");
            sql.Append(ACCReceiptHDRTRN.RECHDR_CorporateID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ApplicationID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ReceiptType + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_PayMode + ",");
            if (string.IsNullOrEmpty(ACCReceiptHDRTRN.RECHDR_ChequeNo))
                ACCReceiptHDRTRN.RECHDR_ChequeNo = "0";
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeNo + "',");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeDate + "',");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ChequeAmount + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_CreatedByUserID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_RowStatus + ",");
            sql.Append(ACCReceiptHDRTRN.Bankid + ",");
            sql.Append(ACCReceiptHDRTRN.centercode + ",");
            sql.Append(ACCReceiptHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_SMSFlag + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_Remark + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }
        public ACCReceiptHDRTRNMsg InsertACCReceiptHDRTRN_ForCSVUpload(ACCReceiptHDRTRN ACCReceiptHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCReceiptHDRTRN_ACCReceiptDTLTRN_InsertForCSVUpload] ");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_Date + "',");
            sql.Append(ACCReceiptHDRTRN.RECHDR_CorporateID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ApplicationID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ReceiptType + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_PayMode + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeNo + "',");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeDate + "',");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ChequeAmount + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_CreatedByUserID + ",");
            //sql.Append(ACCReceiptHDRTRN.RECHDR_RowStatus + ",");
            sql.Append(ACCReceiptHDRTRN.centercode + ",");
            sql.Append(ACCReceiptHDRTRN.Bankid + ",");
            sql.Append(ACCReceiptHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_SMSFlag + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_Remark.Replace("'", "''") + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }


        public ACCReceiptHDRTRNMsg UpdateACCReceiptHDRTRN(ACCReceiptHDRTRN ACCReceiptHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCReceiptHDRTRN_Update ");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ReceiptNo + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeNo + "',");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeDate + "',");
            sql.Append(ACCReceiptHDRTRN.Bankid + ",");
            sql.Append(ACCReceiptHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_Remark.Replace("'", "''") + "',");
            sql.Append(ACCReceiptHDRTRN.RECHDR_UpdatedByUserID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_RowStatus + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }

        public ACCReceiptHDRTRNMsg UpdateACCReceiptHDRTRNActive(ACCReceiptHDRTRN ACCReceiptHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCReceiptHDRTRN_Active_Update ");
            sql.Append(ACCReceiptHDRTRN.RECHDR_ReceiptNo + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeNo + "',");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_ChequeDate + "',");
            sql.Append(ACCReceiptHDRTRN.Bankid + ",");
            sql.Append(ACCReceiptHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append("'" + ACCReceiptHDRTRN.RECHDR_Remark.Replace("'", "''") + "',");
            sql.Append(ACCReceiptHDRTRN.RECHDR_UpdatedByUserID + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_RowStatus + ",");
            sql.Append(ACCReceiptHDRTRN.RECHDR_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }

        public ACCReceiptHDRTRNMsg DeleteACCReceiptHDRTRN(int ACCReceiptHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_ACCReceiptHDRTRN_Delete " + ACCReceiptHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }

    }
   
}
   