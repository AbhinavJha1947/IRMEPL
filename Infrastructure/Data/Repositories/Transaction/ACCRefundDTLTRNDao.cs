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
    public class ACCRefundDTLTRNDao : IACCRefundDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCRefundDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCRefundDTLTRNList> GetACCRefundDTLTRNs(decimal REFDTL_RefundNo, int Refundtype, decimal Applicationid, int corporate)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundDTLTRN_SelectAll " + REFDTL_RefundNo + ",");
            sql.Append(Refundtype + ",");
            sql.Append(Applicationid + ",");
            sql.Append(corporate);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());


            IList<ACCRefundDTLTRNList> list = new List<ACCRefundDTLTRNList>();
            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];
                foreach (DataRow row in dtList.Rows)
                {
                    string RefNo = row["INVHDR_InvoiceRefNo"].ToString();
                    int REFDTL_RefID = int.Parse(row["REFDTL_RefID"].ToString());
                    int REFDTL_RefType = int.Parse(row["REFDTL_RefType"].ToString());
                    int REFDTL_HeadId = int.Parse(row["REFDTL_HeadId"].ToString());
                    string HeadName = row["HeadName"].ToString();
                    decimal REFDTL_Amount = decimal.Parse(row["REFDTL_Amount"].ToString());
                    Int64 REFDTL_TransactionID = Int64.Parse(row["REFDTL_TransactionID"].ToString());
                    string RefType = row["RefType"].ToString();
                    list.Add(new ACCRefundDTLTRNList(RefNo, REFDTL_RefID, REFDTL_RefType, REFDTL_HeadId, HeadName, REFDTL_Amount, REFDTL_TransactionID, RefType));
                }
            }
            return list;
        }

        public ACCRefundDTLTRN GetACCRefundDTLTRN(decimal ACCRefundDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_ACCRefundDTLTRN_Select " + ACCRefundDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int REFDTL_ID = 0;
            decimal REFDTL_RefundNo = Convert.ToDecimal(row["REFDTL_RefundNo"]);
            int REFDTL_RefId = Convert.ToInt32(row["REFDTL_RefID"]);
            int REFDTL_RefType = Convert.ToInt32(row["REFDTL_RefType"]);
            int REFDTL_HeadId = Convert.ToInt32(row["REFDTL_HeadId"]);
            decimal REFDTL_Amount = Convert.ToDecimal(row["REFDTL_Amount"]);
            decimal REFDTL_Balance = Convert.ToDecimal(row["REFDTL_Balance"]);
            Int64 REFDTL_TransactionID = Int64.Parse(row["REFDTL_TransactionID"].ToString());
            #endregion

            return new
            ACCRefundDTLTRN(REFDTL_ID, REFDTL_RefundNo, REFDTL_RefId, REFDTL_RefType, REFDTL_HeadId, REFDTL_Amount, REFDTL_Balance, REFDTL_TransactionID);
        }

        public ACCRefundHDRTRNMsg InsertACCRefundDTLTRN(ACCRefundDTLTRN ACCRefundDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundDTLTRN_Insert ");
            sql.Append(ACCRefundDTLTRN.REFDTL_RefundNo + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_RefId + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_RefType + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_HeadId + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_Amount + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_TransactionID);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCRefundHDRTRNMsg(_RetVal, _RetStr);
        }

        public ACCRefundHDRTRNMsg InsertACCRefundDTLTRN_ForCSVUpload(ACCRefundDTLTRN ACCRefundDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCRefundDTLTRN_Insert_ForCSVUpload ");
            sql.Append(ACCRefundDTLTRN.REFDTL_RefundNo + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_HeadId + ",");
            sql.Append(ACCRefundDTLTRN.REFDTL_Amount + "");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCRefundHDRTRNMsg(_RetVal, _RetStr);
        }
    }
}

