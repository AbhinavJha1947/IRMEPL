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
    public class ACCCustomerDueTRNDao : IACCCustomerDueTRNDao
    {
        private readonly DbManager _dbManager;

        public ACCCustomerDueTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCCustomerDueTRNList> GetACCCustomerDueTRNs()
        {
            string sortExpression = "CDUTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCCustomerDueTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCCustomerDueTRNList> GetACCCustomerDueTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCCustomerDueTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CDUTRN_ID',");
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
            IList<ACCCustomerDueTRNList> list = new List<ACCCustomerDueTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CDUTRN_ID = int.Parse(row["CDUTRN_ID"].ToString());
                decimal CDUTRN_ApplicationId = decimal.Parse(row["CDUTRN_ApplicationId"].ToString());
                int CDUTRN_Head = int.Parse(row["CDUTRN_Head"].ToString());
                string HeadName = row["HeadName"].ToString();
                string RefType = row["RefType"].ToString();
                string RefNo = row["RefNo"].ToString();
                decimal CDUTRN_AmountDue = decimal.Parse(row["CDUTRN_AmountDue"].ToString());
                decimal CDUTRN_AmountReceived = decimal.Parse(row["CDUTRN_AmountReceived"].ToString());
                decimal DueAmt = decimal.Parse(row["DueAmt"].ToString());
                int EMIPaid = 0;
                int EMI = int.Parse(row["EMI"].ToString());
                if (EMI > 0)
                {
                    //----------------Old Logic -----------------
                    // EMIPaid = decimal.ToInt32(CDUTRN_AmountReceived) / int.Parse(row["EMI"].ToString());

                    //---New Change 6/8/2019-------------

                    decimal EMI_Amount = CDUTRN_AmountDue / EMI;
                    EMIPaid = decimal.ToInt32(CDUTRN_AmountReceived) / decimal.ToInt32(EMI_Amount);


                }
                list.Add(new ACCCustomerDueTRNList(CDUTRN_ID, CDUTRN_ApplicationId, HeadName, RefType, RefNo, CDUTRN_Head, CDUTRN_AmountDue, CDUTRN_AmountReceived, DueAmt, EMI, EMIPaid, Count));
            }
            return list;
        }

        public ACCCustomerDueTRN GetACCCustomerDueTRN(int ACCCustomerDueTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_ACCCustomerDueTRN_Select " + ACCCustomerDueTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CDUTRN_ID = Convert.ToInt32(row["CDUTRN_ID"]);
            decimal CDUTRN_ApplicationId = Convert.ToDecimal(row["CDUTRN_ApplicationId"]);
            int CDUTRN_Head = Convert.ToInt32(row["CDUTRN_Head"]);
            decimal CDUTRN_AmountDue = Convert.ToDecimal(row["CDUTRN_AmountDue"]);
            decimal CDUTRN_AmountReceived = Convert.ToDecimal(row["CDUTRN_AmountReceived"]);
            string CDUTRN_RecDate = Convert.ToString(row["CDUTRN_RecDate"]);
            int CDUTRN_CreatedByUserID = Convert.ToInt32(row["CDUTRN_CreatedByUserID"]);
            string CDUTRN_CreatedDateTime = Convert.ToString(row["CDUTRN_CreatedDateTime"]);
            int CDUTRN_UpdatedByUserID = Convert.ToInt32(row["CDUTRN_UpdatedByUserID"]);
            string CDUTRN_UpdatedDateTime = Convert.ToString(row["CDUTRN_UpdatedDateTime"]);
            int CDUTRN_RowStatus = Convert.ToInt32(row["CDUTRN_RowStatus"]);
            long CDUTRN_RowVersion = (long)row["CDUTRN_RowVersion"];

            #endregion

            return new
            ACCCustomerDueTRN(CDUTRN_ID, CDUTRN_ApplicationId, CDUTRN_Head, CDUTRN_AmountDue, CDUTRN_AmountReceived, CDUTRN_RecDate, CDUTRN_CreatedByUserID, CDUTRN_CreatedDateTime, CDUTRN_UpdatedByUserID, CDUTRN_UpdatedDateTime, CDUTRN_RowStatus, CDUTRN_RowVersion);
        }

        public ACCCustomerDueTRNMsg InsertACCCustomerDueTRN(ACCCustomerDueTRN ACCCustomerDueTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_ACCCustomerDueTRN_Insert ");
            sql.Append(ACCCustomerDueTRN.CDUTRN_ApplicationId + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_Head + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_AmountDue + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_AmountReceived + ",");
            sql.Append("N'" + ACCCustomerDueTRN.CDUTRN_RecDate + "',");
            sql.Append(ACCCustomerDueTRN.CDUTRN_CreatedByUserID + ",");
            sql.Append("N'" + ACCCustomerDueTRN.CDUTRN_CreatedDateTime + "',");
            sql.Append(ACCCustomerDueTRN.CDUTRN_UpdatedByUserID + ",");
            sql.Append("N'" + ACCCustomerDueTRN.CDUTRN_UpdatedDateTime + "',");
            sql.Append(ACCCustomerDueTRN.CDUTRN_RowStatus + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new ACCCustomerDueTRNMsg(_RetVal, _RetStr);
        }

        public ACCCustomerDueTRNMsg InsertACCCustomerDueTRN_forDishonour(ACCCustomerDueTRN ACCCustomerDueTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCCustomerDue_ACCBounceChequeDTLTRN_Insert ");
            sql.Append(ACCCustomerDueTRN.CDUTRN_ApplicationId + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_Head + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_AmountDue + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_AmountReceived + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_CreatedByUserID + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_RowStatus + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new ACCCustomerDueTRNMsg(_RetVal, _RetStr);
        }
        public ACCCustomerDueTRNMsg UpdateACCCustomerDueTRN(ACCCustomerDueTRN ACCCustomerDueTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_ACCCustomerDueTRN_Update ");
            sql.Append(ACCCustomerDueTRN.CDUTRN_ID + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_ApplicationId + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_Head + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_AmountDue + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_AmountReceived + ",");
            sql.Append("N'" + ACCCustomerDueTRN.CDUTRN_RecDate + "',");
            sql.Append(ACCCustomerDueTRN.CDUTRN_CreatedByUserID + ",");
            sql.Append("N'" + ACCCustomerDueTRN.CDUTRN_CreatedDateTime + "',");
            sql.Append(ACCCustomerDueTRN.CDUTRN_UpdatedByUserID + ",");
            sql.Append("N'" + ACCCustomerDueTRN.CDUTRN_UpdatedDateTime + "',");
            sql.Append(ACCCustomerDueTRN.CDUTRN_RowStatus + ",");
            sql.Append(ACCCustomerDueTRN.CDUTRN_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCCustomerDueTRNMsg(_RetVal, _RetStr);
        }

        public ACCCustomerDueTRNMsg DeleteACCCustomerDueTRN(int ACCCustomerDueTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_ACCCustomerDueTRN_Delete " + ACCCustomerDueTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new ACCCustomerDueTRNMsg(_RetVal, _RetStr);
        }

        public ACCCustomerDueTRNMsg ACCCustomerDueTRN_AmountSettlement(int ApplicationID, int ConnType, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_ACCCustomerDueTRN_AmountSettlement] ");
            sql.Append(ApplicationID + ",");
            sql.Append(ConnType);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCCustomerDueTRNMsg(_RetVal, _RetStr);
        }
    }
}

