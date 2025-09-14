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
    public class PRDExConnReqFormHDRTRNDao : IPRDExConnReqFormHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDExConnReqFormHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDExConnReqFormHDRTRNList> GetPRDExConnReqFormHDRTRNs()
        {
            string sortExpression = "EXCHDR_EConnID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDExConnReqFormHDRTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDExConnReqFormHDRTRNList> GetPRDExConnReqFormHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'EXCHDR_EConnID',");
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
            IList<PRDExConnReqFormHDRTRNList> list = new List<PRDExConnReqFormHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int EXCHDR_EConnID = int.Parse(row["EXCHDR_EConnID"].ToString());
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string EXCHDR_RequestDate = row["EXCHDR_RequestDate"].ToString();
                int CD_ControlID = int.Parse(row["CD_ControlID"].ToString());
                string RequestFor = row["RequestFor"].ToString();
                decimal EXCHDR_DueAmount = decimal.Parse(row["EXCHDR_DueAmount"].ToString());
                decimal EXCHDR_ReceivedAmount = decimal.Parse(row["EXCHDR_ReceivedAmount"].ToString());
                decimal EstimatedAmount = decimal.Parse(row["EstimatedAmount"].ToString());
                string EXCHDR_RequestNo = row["EXCHDR_RequestNo"].ToString();
                int EXCHDR_RequestStatus = Convert.ToInt32(row["EXCHDR_RequestStatus"]);
                int EXCHDR_RequestCancelStatus = Convert.ToInt32(row["EXCHDR_RequestCancelStatus"]);
                string EXCHDR_RequestCancelDate = Convert.ToString(row["EXCHDR_RequestCancelDate"]);

                list.Add(new PRDExConnReqFormHDRTRNList(EXCHDR_EConnID, APPMST_CustomerID, APPMST_AppNo, CustomerName, EXCHDR_RequestDate, CD_ControlID, RequestFor, EXCHDR_DueAmount, EXCHDR_ReceivedAmount, EstimatedAmount, EXCHDR_RequestNo, EXCHDR_RequestStatus, EXCHDR_RequestCancelStatus, EXCHDR_RequestCancelDate, Count));
            }
            return list;
        }

        //public IList<PRDExConnReqFormDTLTRNList_CustomerData> GetPRDExConnReqFormConnection()
        //{
        //    string sortExpression = "EXCHDR_EConnID";
        //    string sortType = "ASC";
        //    int pageIndex = 0;
        //    int pageSize = -1;
        //    string criteria = "";
        //    return GetPRDExConnReqFormConnection(sortExpression, sortType, pageIndex, pageSize, criteria);
        //}

        //public IList<PRDExConnReqFormDTLTRNList_CustomerData> GetPRDExConnReqFormConnection(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_ExtraConncetionBindData ");
        //    //String Building for Order by Column.
        //    if (String.IsNullOrEmpty(sortExpression) == true)
        //    {
        //        sql.Append("'CD_ControlType',");
        //    }
        //    else
        //    {
        //        sql.Append("'" + sortExpression + "',");
        //    }
        //    //String Building for Sorintg Type
        //    if (String.IsNullOrEmpty(sortType) == true)
        //    {
        //        sql.Append("'ASC',");
        //    }
        //    else
        //    {
        //        sql.Append("'" + sortType + "',");
        //    }
        //    //String Building for Page Index
        //    sql.Append(pageIndex + ",");
        //    sql.Append(pageSize + ",'");
        //    sql.Append(criteria + "'");          
        //    DataSet ds = _dbManager.GetDataSet(sql.ToString());
        //    DataTable dtList = ds.Tables[0];
        //    DataTable dtRowCount = ds.Tables[1];
        //    int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
        //    IList<PRDExConnReqFormDTLTRNList_CustomerData> list = new List<PRDExConnReqFormDTLTRNList_CustomerData>();
        //    foreach (DataRow row in dtList.Rows)
        //    {

        //        string CD_ControlType = (row["CD_ControlType"].ToString());
        //        int EXCDTL_NoOfConnection = int.Parse(row["EXCDTL_NoOfConnection"].ToString());


        //        list.Add(new PRDExConnReqFormDTLTRNList_CustomerData(CD_ControlType, EXCDTL_NoOfConnection));
        //    }
        //    return list;
        //}



        public PRDExConnReqFormHDRTRN GetPRDExConnReqFormHDRTRN(int PRDExConnReqFormHDRTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRN_Select " + PRDExConnReqFormHDRTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            decimal EXCHDR_EConnID = Convert.ToDecimal(row["EXCHDR_EConnID"]);
            decimal EXCHDR_ApplicationID = Convert.ToDecimal(row["EXCHDR_ApplicationID"]);
            string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
            string EXCHDR_RequestDate = Convert.ToString(row["EXCHDR_RequestDate"]);
            int EXCHDR_RequestFor = Convert.ToInt32(row["EXCHDR_RequestFor"]);
            int EXCHDR_RequestStatus = Convert.ToInt32(row["EXCHDR_RequestStatus"]);
            decimal EXCHDR_DueAmount = Convert.ToDecimal(row["EXCHDR_DueAmount"]);
            decimal EXCHDR_ReceiptID = Convert.ToDecimal(row["EXCHDR_ReceiptID"]);
            decimal EXCHDR_ReceivedAmount = Convert.ToDecimal(row["EXCHDR_ReceivedAmount"]);
            string EXCHDR_Remarks = Convert.ToString(row["EXCHDR_Remarks"]);
            int EXCHDR_CreatedByUserID = Convert.ToInt32(row["EXCHDR_CreatedByUserID"]);
            string EXCHDR_CreatedDateTime = Convert.ToString(row["EXCHDR_CreatedDateTime"]);
            int EXCHDR_UpdatedByUserID = Convert.ToInt32(row["EXCHDR_UpdatedByUserID"]);
            string EXCHDR_UpdatedDateTime = Convert.ToString(row["EXCHDR_UpdatedDateTime"]);
            int EXCHDR_RowStatus = Convert.ToInt32(row["EXCHDR_RowStatus"]);
            long EXCHDR_RowVersion = (long)row["EXCHDR_RowVersion"];
            string EXCHDR_RequestNo = row["EXCHDR_RequestNo"].ToString();
            int Editable = Convert.ToInt32(row["Editable"].ToString());
            int EXCHDR_RequestCancelStatus = Convert.ToInt32(row["Editable"].ToString());
            string EXCHDR_RequestCancelDate = Convert.ToString(row["Editable"]).Trim();
            #endregion

            return new
            PRDExConnReqFormHDRTRN(EXCHDR_EConnID, EXCHDR_ApplicationID, APPMST_CustomerID, EXCHDR_RequestDate, EXCHDR_RequestFor, EXCHDR_RequestStatus, EXCHDR_DueAmount, EXCHDR_ReceiptID, EXCHDR_ReceivedAmount, EXCHDR_Remarks, EXCHDR_CreatedByUserID, EXCHDR_CreatedDateTime, EXCHDR_UpdatedByUserID, EXCHDR_UpdatedDateTime, EXCHDR_RowStatus, EXCHDR_RowVersion, EXCHDR_RequestNo, Editable, EXCHDR_RequestCancelStatus, EXCHDR_RequestCancelDate);
        }

        public PRDExConnReqFormHDRTRNMsg InsertPRDExConnReqFormHDRTRN(PRDExConnReqFormHDRTRN PRDExConnReqFormHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRN_Insert ");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_ApplicationID + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_RequestDate + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RequestFor + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RequestStatus + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_DueAmount + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_ReceiptID + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_ReceivedAmount + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_Remarks.Replace("'", "''") + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_CreatedByUserID + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_CreatedDateTime + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RowStatus + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDExConnReqFormHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDExConnReqFormHDRTRNMsg UpdatePRDExConnReqFormHDRTRN(PRDExConnReqFormHDRTRN PRDExConnReqFormHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRN_Update ");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_EConnID + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_ApplicationID + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_RequestDate + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RequestFor + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RequestStatus + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_DueAmount + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_ReceiptID + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_ReceivedAmount + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_Remarks.Replace("'", "''") + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_CreatedByUserID + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_CreatedDateTime + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_UpdatedByUserID + ",");
            sql.Append("N'" + PRDExConnReqFormHDRTRN.EXCHDR_UpdatedDateTime + "',");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RowStatus + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDExConnReqFormHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDExConnReqFormHDRTRNMsg DeletePRDExConnReqFormHDRTRN(int PRDExConnReqFormHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRN_Delete " + PRDExConnReqFormHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDExConnReqFormHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDExConnReqFormHDRTRNMsg CancelPRDExConnReqFormHDRTRN(PRDExConnReqFormHDRTRN PRDExConnReqFormHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormHDRTRN_Cancel " + PRDExConnReqFormHDRTRN.EXCHDR_EConnID + ",");
            sql.Append(PRDExConnReqFormHDRTRN.EXCHDR_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDExConnReqFormHDRTRNMsg(_RetVal, _RetStr);
        }

    }
}
