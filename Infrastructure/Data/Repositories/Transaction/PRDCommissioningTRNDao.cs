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
    public class PRDCommissioningTRNDao : IPRDCommissioningTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDCommissioningTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDCommissioningTRNList> GetPRDCommissioningTRNs()
        {
            string sortExpression = "COMTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDCommissioningTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<PRDCommissioningTRNListDetail> GetPRDCommissioningTRNDetails()
        {
            string sortExpression = "COMTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDCommissioningTRNDetails(sortExpression, sortType, pageIndex, pageSize, criteria);
        }






        public IList<PRDCommissioningTRNList> GetPRDCommissioningTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_AppID',");
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
            IList<PRDCommissioningTRNList> list = new List<PRDCommissioningTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                long COMTRN_ID = long.Parse(row["COMTRN_ID"].ToString());
                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string AppName = row["AppName"].ToString();
                string COMTRN_DateOfComm = row["COMTRN_DateOfComm"].ToString();
                string AppAddress = row["AppAddress"].ToString();
                int APPMST_Area = int.Parse(row["APPMST_Area"].ToString());
                string AreaName = row["AreaName"].ToString();
                int APPMST_PlanId = int.Parse(row["APPMST_PlanId"].ToString());
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string CustomerType = row["CustomerType"].ToString();
                string ConName = row["CONMST_Name"].ToString();
                decimal InitialReading = decimal.Parse(row["COMTRN_InitialReading"].ToString());
                list.Add(new PRDCommissioningTRNList(COMTRN_ID, APPMST_AppID, APPMST_AppNo, APPMST_CustomerID, AppName, COMTRN_DateOfComm, AppAddress, APPMST_Area, AreaName, APPMST_PlanId, PLAMST_PlanName, CustomerType, InitialReading, ConName, Count));
            }
            return list;
        }

        public IList<PRDCommissioningTRNListDetail> GetPRDCommissioningTRNDetails(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_SelectAllDetail ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_AppID',");
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
            IList<PRDCommissioningTRNListDetail> list = new List<PRDCommissioningTRNListDetail>();
            foreach (DataRow row in dtList.Rows)
            {
                //long COMTRN_ID = long.Parse(row["COMTRN_ID"].ToString());
                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                //string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string AppName = row["AppName"].ToString();
                string AppAddress = row["AppAddress"].ToString();
                string AreaName = row["AreaName"].ToString();
                //string COMTRN_DateOfComm = row["COMTRN_DateOfComm"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string ContractorName = row["ContractorName"].ToString();
                string WORTRN_WorkOrdRefNo = row["WORTRN_WorkOrdRefNo"].ToString();
                //string CustomerType = row["CustomerType"].ToString();
                list.Add(new PRDCommissioningTRNListDetail(APPMST_AppID, APPMST_AppNo, AppName, AppAddress, AreaName, PLAMST_PlanName, ContractorName, WORTRN_WorkOrdRefNo, Count));
            }
            return list;
        }

        //public PRDCommissioningTRN GetPRDCommissioningTRN(int PRDCommissioningTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_PRDCommissioningTRN_Select " + PRDCommissioningTRNid);


        //    DataSet ds = _dbManager.GetDataSet(sql.ToString(),ref objCon, ref trn);
        //    DataTable dtList = ds.Tables[0];
        //    DataTable dtRowCount = ds.Tables[1];

        //    DataRow row = dtList.Rows[0];
        //    DataRow row1 = dtRowCount.Rows[0];

        //    #region"Variables Declaration"
        //    long COMTRN_ID = Convert.ToInt64(row["COMTRN_ID"]);
        //    long COMTRN_ApplicationID = Convert.ToInt64(row["COMTRN_ApplicationID"]);
        //    string COMTRN_CustomerID = Convert.ToString(row["COMTRN_CustomerID"]);
        //    decimal COMTRN_InitialReading = Convert.ToDecimal(row["COMTRN_InitialReading"]);
        //    string COMTRN_DateOfComm = Convert.ToString(row["COMTRN_DateOfComm"]);
        //    int COMTRN_ContractorID = Convert.ToInt32(row["COMTRN_ContractorID"]);
        //    string COMTRN_Remarks = Convert.ToString(row["COMTRN_Remarks"]);
        //    int COMTRN_CreatedByUserID = Convert.ToInt32(row["COMTRN_CreatedByUserID"]);
        //    string COMTRN_CreatedDateTime = Convert.ToString(row["COMTRN_CreatedDateTime"]);
        //    int COMTRN_UpdatedByUserID = Convert.ToInt32(row["COMTRN_UpdatedByUserID"]);
        //    string COMTRN_UpdatedDateTime = Convert.ToString(row["COMTRN_UpdatedDateTime"]);
        //    int COMTRN_RowStatus = Convert.ToInt32(row["COMTRN_RowStatus"]);
        //    long COMTRN_RowVersion = (long)row["COMTRN_RowVersion"];


        //    int RetVal = int.Parse(row1["RetVal"].ToString());
        //    string RetStr = row1["RetStr"].ToString();

        //    #endregion

        //    return new
        //    PRDCommissioningTRN(COMTRN_ID, COMTRN_ApplicationID, COMTRN_CustomerID, COMTRN_InitialReading, COMTRN_DateOfComm, COMTRN_ContractorID, COMTRN_Remarks, COMTRN_CreatedByUserID, COMTRN_CreatedDateTime, COMTRN_UpdatedByUserID, COMTRN_UpdatedDateTime, COMTRN_RowStatus, COMTRN_RowVersion, RetVal, RetStr);
        //}

        public PRDCommissioningTRN GetPRDCommissioningTRN(int PRDCommissioningTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_Select " + PRDCommissioningTRNid);


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];

            DataRow row = dtList.Rows[0];
            DataRow row1 = dtRowCount.Rows[0];

            #region"Variables Declaration"
            long COMTRN_ID = Convert.ToInt64(row["COMTRN_ID"]);
            long COMTRN_ApplicationID = Convert.ToInt64(row["COMTRN_ApplicationID"]);
            string COMTRN_CustomerID = Convert.ToString(row["COMTRN_CustomerID"]);
            decimal COMTRN_InitialReading = Convert.ToDecimal(row["COMTRN_InitialReading"]);
            string COMTRN_DateOfComm = Convert.ToString(row["COMTRN_DateOfComm"]);
            int COMTRN_ContractorID = Convert.ToInt32(row["COMTRN_ContractorID"]);
            string COMTRN_Remarks = Convert.ToString(row["COMTRN_Remarks"]);
            int COMTRN_CreatedByUserID = Convert.ToInt32(row["COMTRN_CreatedByUserID"]);
            string COMTRN_CreatedDateTime = Convert.ToString(row["COMTRN_CreatedDateTime"]);
            int COMTRN_UpdatedByUserID = Convert.ToInt32(row["COMTRN_UpdatedByUserID"]);
            string COMTRN_UpdatedDateTime = Convert.ToString(row["COMTRN_UpdatedDateTime"]);
            int COMTRN_RowStatus = Convert.ToInt32(row["COMTRN_RowStatus"]);
            long COMTRN_RowVersion = (long)row["COMTRN_RowVersion"];
            int COMTRN_SMSFlag = 0;

            int RetVal = int.Parse(row1["RetVal"].ToString());
            string RetStr = row1["RetStr"].ToString();

            #endregion

            return new
            PRDCommissioningTRN(COMTRN_ID, COMTRN_ApplicationID, COMTRN_CustomerID, COMTRN_InitialReading, COMTRN_DateOfComm, COMTRN_ContractorID, COMTRN_Remarks, COMTRN_CreatedByUserID, COMTRN_CreatedDateTime, COMTRN_UpdatedByUserID, COMTRN_UpdatedDateTime, COMTRN_RowStatus, COMTRN_RowVersion, RetVal, RetStr, COMTRN_SMSFlag);
        }



        public IList<PRDCommissioningTRN_GetMeterNo> GetPRDCommissioningTRN_GetMeterNo(long APPMST_AppID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_GetMeterNo " + APPMST_AppID);


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDCommissioningTRN_GetMeterNo> list = new List<PRDCommissioningTRN_GetMeterNo>();
            foreach (DataRow row in dtList.Rows)
            {
                long CMRMST_MeterNo = long.Parse(row["CMRMST_MeterNo"].ToString());
                decimal CMRMST_InitialReading = decimal.Parse(row["CMRMST_InitialReading"].ToString());

                list.Add(new PRDCommissioningTRN_GetMeterNo(CMRMST_MeterNo, CMRMST_InitialReading));
            }
            return list;
        }

        public PRDCommissioningTRNMsg InsertPRDCommissioningTRN(PRDCommissioningTRN PRDCommissioningTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_Insert ");
            sql.Append(PRDCommissioningTRN.COMTRN_ApplicationID + ",");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_CustomerID + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_InitialReading + ",");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_DateOfComm + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_ContractorID + ",");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_Remarks.Replace("'", "''") + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_CreatedByUserID + ",");
            sql.Append(PRDCommissioningTRN.COMTRN_SMSFlag);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDCommissioningTRNMsg(_RetVal, _RetStr);
        }
        public PRDCommissioningTRNMsg InsertPRDCommissioningTRNCSV(PRDCommissioningTRN PRDCommissioningTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_Insert_ForCSVUpload ");
            sql.Append("'" + PRDCommissioningTRN.COMTRN_ApplicationNo + "',");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_DateOfComm + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_InitialReading + ",'");
            sql.Append(PRDCommissioningTRN.COMTRN_Remarks + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_CreatedByUserID + ",");
            sql.Append(PRDCommissioningTRN.CENMST_CenterCode + ",");
            sql.Append(PRDCommissioningTRN.COMTRN_SMSFlag);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDCommissioningTRNMsg(_RetVal, _RetStr);
        }
        public PRDCommissioningTRNMsg UpdatePRDCommissioningTRN(PRDCommissioningTRN PRDCommissioningTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_Update ");
            sql.Append(PRDCommissioningTRN.COMTRN_ID + ",");
            sql.Append(PRDCommissioningTRN.COMTRN_ApplicationID + ",");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_CustomerID + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_InitialReading + ",");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_DateOfComm + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_ContractorID + ",");
            sql.Append("N'" + PRDCommissioningTRN.COMTRN_Remarks.Replace("'", "''") + "',");
            sql.Append(PRDCommissioningTRN.COMTRN_UpdatedByUserID + ",");
            sql.Append(PRDCommissioningTRN.COMTRN_RowVersion + ",");
            sql.Append(PRDCommissioningTRN.COMTRN_SMSFlag);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDCommissioningTRNMsg(_RetVal, _RetStr);
        }

        public PRDCommissioningTRNMsg DeletePRDCommissioningTRN(int PRDCommissioningTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDCommissioningTRN_Delete " + PRDCommissioningTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDCommissioningTRNMsg(_RetVal, _RetStr);
        }

    }
}
