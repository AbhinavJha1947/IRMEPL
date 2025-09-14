using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces.Core;
using Application.RepositoryInterfaces.Transaction;


namespace Infrastructure.Data.Repositories.Transaction
{
    public class ACCReceiptDTLTRNDao : IACCReceiptDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCReceiptDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCReceiptDTLTRNList> GetACCReceiptDTLTRNs(decimal RECDTL_ReceiptNo, int receipttype, decimal Applicationid, int corporate)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCReceiptDTLTRN_SelectAll " + RECDTL_ReceiptNo + ",");
            sql.Append(receipttype + ",");
            sql.Append(Applicationid + ",");
            sql.Append(corporate);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());


            IList<ACCReceiptDTLTRNList> list = new List<ACCReceiptDTLTRNList>();
            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];
                foreach (DataRow row in dtList.Rows)
                {
                    string RefNo = string.Empty;
                    if (!string.IsNullOrEmpty(Convert.ToString(row["INVHDR_InvoiceRefNo"])))
                        RefNo = row["INVHDR_InvoiceRefNo"].ToString();
                    int RECDTL_RefID = int.Parse(row["RECDTL_RefID"].ToString());
                    int RECDTL_RefType = int.Parse(row["RECDTL_RefType"].ToString());
                    int RECDTL_HeadId = int.Parse(row["RECDTL_HeadId"].ToString());
                    string HeadName = row["HeadName"].ToString();
                    decimal RECDTL_Amount = decimal.Parse(row["RECDTL_Amount"].ToString());
                    Int64 RECDTL_TransactionID = 0;
                    if (!string.IsNullOrEmpty(Convert.ToString(row["RECDTL_TransactionID"])))
                        RECDTL_TransactionID = Int64.Parse(row["RECDTL_TransactionID"].ToString());
                    list.Add(new ACCReceiptDTLTRNList(RefNo, RECDTL_RefID, RECDTL_RefType, RECDTL_HeadId, HeadName, RECDTL_Amount, RECDTL_TransactionID));
                }
            }
            return list;
        }

        public ACCReceiptDTLTRN GetACCReceiptDTLTRN(decimal ACCReceiptDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_ACCReceiptDTLTRN_Select " + ACCReceiptDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int RECDTL_ID = 0;
            decimal RECDTL_ReceiptNo = Convert.ToDecimal(row["RECDTL_ReceiptNo"]);
            int RECDTL_RefId = Convert.ToInt32(row["RECDTL_RefID"]);
            int RECDTL_RefType = Convert.ToInt32(row["RECDTL_RefType"]);
            int RECDTL_HeadId = Convert.ToInt32(row["RECDTL_HeadId"]);
            decimal RECDTL_Amount = Convert.ToDecimal(row["RECDTL_Amount"]);
            decimal RECDTL_Balance = Convert.ToDecimal(row["RECDTL_Balance"]);
            Int64 RECDTL_TransactionID = Int64.Parse(row["RECDTL_TransactionID"].ToString());
            #endregion

            return new
            ACCReceiptDTLTRN(RECDTL_ID, RECDTL_ReceiptNo, RECDTL_RefId, RECDTL_RefType, RECDTL_HeadId, RECDTL_Amount, RECDTL_Balance, RECDTL_TransactionID);
        }

        public ACCReceiptHDRTRNMsg InsertACCReceiptDTLTRN(ACCReceiptDTLTRN ACCReceiptDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCReceiptDTLTRN_Insert ");
            sql.Append(ACCReceiptDTLTRN.RECDTL_ReceiptNo + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_RefId + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_RefType + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_HeadId + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_Amount + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_TransactionID);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }

        public ACCReceiptHDRTRNMsg InsertACCReceiptDTLTRN_ForCSVUpload(ACCReceiptDTLTRN ACCReceiptDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCReceiptDTLTRN_Insert_ForCSVUpload ");
            sql.Append(ACCReceiptDTLTRN.RECDTL_ReceiptNo + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_HeadId + ",");
            sql.Append(ACCReceiptDTLTRN.RECDTL_Amount + "");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCReceiptHDRTRNMsg(_RetVal, _RetStr);
        }

    }
}
