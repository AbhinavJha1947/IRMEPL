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
    public class ACCRefundHDRTRNDao : IACCRefundHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCRefundHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCRefundHDRTRNList> GetACCRefundHDRTRNs()
        {
            string sortExpression = "REFHDR_RefundNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCRefundHDRTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCRefundHDRTRNList> GetACCRefundHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundHDRTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'REFHDR_RefundNo',");
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
            IList<ACCRefundHDRTRNList> list = new List<ACCRefundHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                decimal REFHDR_RefundNo = decimal.Parse(row["REFHDR_RefundNo"].ToString());
                string REFHDR_RefundRefNo = row["REFHDR_RefundRefNo"].ToString();
                string REFHDR_Date = row["REFHDR_Date"].ToString();
                string REFHDR_RefundType = row["REFHDR_RefundType"].ToString();
                string REFHDR_PayMode = row["REFHDR_PayMode"].ToString();
                decimal REFHDR_ChequeAmount = decimal.Parse(row["REFHDR_ChequeAmount"].ToString());
                string Appno = row["Appno"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string Name = row["Name"].ToString();
                string Area = row["area"].ToString();
                string REFHDR_ChequeNo = Convert.ToString(row["REFHDR_ChequeNo"].ToString());
                decimal Balance = decimal.Parse(row["Balance"].ToString());
                string REFHDR_ChequeStatus = row["REFHDR_ChequeStatus"].ToString();
                string REFHDR_RowStatus = row["REFHDR_RowStatus"].ToString();
                int REFHDR_RefundId = int.Parse(row["REFHDR_RefundId"].ToString());
                list.Add(new ACCRefundHDRTRNList(REFHDR_RefundNo, REFHDR_RefundRefNo, REFHDR_Date, REFHDR_RefundType, REFHDR_PayMode, REFHDR_ChequeAmount, Appno, APPMST_CustomerID, Name, Area, REFHDR_ChequeNo, Balance, REFHDR_ChequeStatus, REFHDR_RowStatus, REFHDR_RefundId, Count));
            }
            return list;
        }

        public ACCRefundHDRTRN GetACCRefundHDRTRN(decimal ACCRefundHDRTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCRefundHDRTRN_Select " + ACCRefundHDRTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal REFHDR_RefundNo = Convert.ToDecimal(row["REFHDR_RefundNo"]);
            string REFHDR_RefundRefNo = Convert.ToString(row["REFHDR_RefundRefNo"]);
            string REFHDR_Date = Convert.ToString(row["REFHDR_Date"]);
            int REFHDR_CorporateID = Convert.ToInt32(row["REFHDR_CorporateID"]);
            decimal REFHDR_ApplicationID = Convert.ToDecimal(row["REFHDR_ApplicationID"]);
            int REFHDR_RefundType = Convert.ToInt32(row["REFHDR_RefundType"]);
            Int32 REFHDR_PayMode = Convert.ToInt32(row["REFHDR_PayMode"]);
            string REFHDR_ChequeNo = Convert.ToString(row["REFHDR_ChequeNo"]);
            string REFHDR_ChequeDate = Convert.ToString(row["REFHDR_ChequeDate"]);
            decimal REFHDR_ChequeAmount = Convert.ToDecimal(row["REFHDR_ChequeAmount"]);
            int REFHDR_CreatedByUserID = Convert.ToInt32(row["REFHDR_CreatedByUserID"]);
            string REFHDR_CreatedDateTime = Convert.ToString(row["REFHDR_CreatedDateTime"]);
            int REFHDR_UpdatedByUserID = Convert.ToInt32(row["REFHDR_UpdatedByUserID"]);
            string REFHDR_UpdatedDateTime = Convert.ToString(row["REFHDR_UpdatedDateTime"]);
            int REFHDR_RowStatus = Convert.ToInt32(row["REFHDR_RowStatus"]);
            long REFHDR_RowVersion = (long)row["REFHDR_RowVersion"];
            int bankid = 0;
            int centercode = 0;
            Int64 CHQDTL_MicrNo = Convert.ToInt64(row["CHQDTL_MicrNo"]);
            int REFHDR_SMSFlag = 0;
            string REFHDR_Remark = row["REFHDR_Remark"].ToString();
            int REFHDR_PayStatus = Convert.ToInt32(row["REFHDR_PayStatus"]);
            #endregion

            return new
            ACCRefundHDRTRN(REFHDR_RefundNo, REFHDR_RefundRefNo, REFHDR_Date, REFHDR_CorporateID, REFHDR_ApplicationID, REFHDR_RefundType, REFHDR_PayMode, REFHDR_ChequeNo, REFHDR_ChequeDate, REFHDR_ChequeAmount, REFHDR_CreatedByUserID, REFHDR_CreatedDateTime, REFHDR_UpdatedByUserID, REFHDR_UpdatedDateTime, REFHDR_RowStatus, REFHDR_RowVersion, bankid, centercode, CHQDTL_MicrNo, REFHDR_SMSFlag, REFHDR_Remark, REFHDR_PayStatus);
        }

        public ACCRefundHDRTRNMsg InsertACCRefundHDRTRN(ACCRefundHDRTRN ACCRefundHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundHDRTRN_Insert ");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_Date + "',");
            sql.Append(ACCRefundHDRTRN.REFHDR_CorporateID + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_ApplicationID + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_RefundType + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_PayMode + ",");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_ChequeNo + "',");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_ChequeDate + "',");
            sql.Append(ACCRefundHDRTRN.REFHDR_ChequeAmount + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_CreatedByUserID + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_RowStatus + ",");
            sql.Append(ACCRefundHDRTRN.Bankid + ",");
            sql.Append(ACCRefundHDRTRN.centercode + ",");
            sql.Append(ACCRefundHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_SMSFlag + ",");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_Remark + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCRefundHDRTRNMsg(_RetVal, _RetStr);
        }
        public ACCRefundHDRTRNMsg InsertACCRefundHDRTRN_ForCSVUpload(ACCRefundHDRTRN ACCRefundHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCRefundHDRTRN_ACCRefundDTLTRN_InsertForCSVUpload] ");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_Date + "',");
            sql.Append(ACCRefundHDRTRN.REFHDR_CorporateID + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_ApplicationID + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_RefundType + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_PayMode + ",");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_ChequeNo + "',");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_ChequeDate + "',");
            sql.Append(ACCRefundHDRTRN.REFHDR_ChequeAmount + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_CreatedByUserID + ",");
            //sql.Append(ACCRefundHDRTRN.REFHDR_RowStatus + ",");
            sql.Append(ACCRefundHDRTRN.centercode + ",");
            sql.Append(ACCRefundHDRTRN.Bankid + ",");
            sql.Append(ACCRefundHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_SMSFlag + ",");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_Remark.Replace("'", "''") + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCRefundHDRTRNMsg(_RetVal, _RetStr);
        }


        public ACCRefundHDRTRNMsg UpdateACCRefundHDRTRN(ACCRefundHDRTRN ACCRefundHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ACCRefundHDRTRN_Update ");
            sql.Append(ACCRefundHDRTRN.REFHDR_RefundNo + ",");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_ChequeNo + "',");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_ChequeDate + "',");
            sql.Append(ACCRefundHDRTRN.Bankid + ",");
            sql.Append(ACCRefundHDRTRN.CHQDTL_MicrNo + ",");
            sql.Append("'" + ACCRefundHDRTRN.REFHDR_Remark.Replace("'", "''") + "',");
            sql.Append(ACCRefundHDRTRN.REFHDR_UpdatedByUserID + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_RowStatus + ",");
            sql.Append(ACCRefundHDRTRN.REFHDR_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCRefundHDRTRNMsg(_RetVal, _RetStr);
        }

        public ACCRefundHDRTRNMsg DeleteACCRefundHDRTRN(int ACCRefundHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_ACCRefundHDRTRN_Delete " + ACCRefundHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCRefundHDRTRNMsg(_RetVal, _RetStr);
        }


    }
   
}
