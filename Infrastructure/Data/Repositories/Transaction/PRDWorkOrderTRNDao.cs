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
    public class PRDWorkOrderTRNDao : IPRDWorkOrderTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDWorkOrderTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDWorkOrderTRNList> GetPRDWorkOrderTRNs()
        {
            string sortExpression = "WORTRN_WorkOrdNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDWorkOrderTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDWorkOrderTRNList> GetPRDWorkOrderTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDWorkOrderTRN_SelectAll");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'WORTRN_WorkOrdNo',");
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
            int workordercount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDWorkOrderTRNList> list = new List<PRDWorkOrderTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int WORTRN_WorkOrdNo = int.Parse(row["WORTRN_WorkOrdNo"].ToString());
                string WORTRN_WorkOrdRefNo = row["WORTRN_WorkOrdRefNo"].ToString();
                string CD_ControlType = row["CD_ControlType"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string WORTRN_WorkOrdDate = row["WORTRN_WorkOrdDate"].ToString();
                string App_Name = row["App_Name"].ToString();
                string CONMST_Name = row["CONMST_Name"].ToString();
                string AREMST_Name = row["AREMST_Name"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string Address = row["Address"].ToString();
                string WO_Freeze = row["WO_Freeze"].ToString();
                decimal APPMST_Mobile = decimal.Parse(row["APPMST_Mobile"].ToString());
                decimal WORTRN_WorkOrdAmt = decimal.Parse(row["WORTRN_WorkOrdAmt"].ToString());
                string WORTRN_Remarks = Convert.ToString(row["WORTRN_Remarks"]);

                list.Add(new PRDWorkOrderTRNList(WORTRN_WorkOrdNo, APPMST_AppNo, CD_ControlType, WORTRN_WorkOrdRefNo, WORTRN_WorkOrdDate, App_Name, CONMST_Name, AREMST_Name, PLAMST_PlanName, Address, workordercount, WO_Freeze, APPMST_Mobile, WORTRN_WorkOrdAmt, WORTRN_Remarks));
            }
            return list;
        }
        public IList<PrdAppworkorderList> GetPrdAppworkorders()
        {
            string sortExpression = "APPMST_AppID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPrdAppworkorders(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PrdAppworkorderList> GetPrdAppworkorders(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDWorkOrderMaster_GetAll ");
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
            int count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PrdAppworkorderList> list = new List<PrdAppworkorderList>();
            foreach (DataRow row in dtList.Rows)
            {
                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APPMST_AppDate = row["APPMST_AppDate"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string APPMST_Address2 = row["APPMST_Address2"].ToString();
                string APPMST_Name = row["APPMST_Name"].ToString();
                string APPMST_Area = row["APPMST_Area"].ToString();
                string APPMST_CustType = row["APPMST_CustType"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string APPMST_WOType = row["APPMST_WOType"].ToString();
                int APPMST_WOTYPEID = int.Parse(row["APPMST_WOTYPEID"].ToString());
                int RequestID = int.Parse(row["WORTRN_RequestID"].ToString());
                decimal APPMST_Mobile = decimal.Parse(row["APPMST_Mobile"].ToString());
                decimal WORTRN_WorkOrdAmt = decimal.Parse(row["WORTRN_WorkOrdAmt"].ToString());
                string CHQDTL_RealizedDate = row["CHQDTL_RealizedDate"].ToString();
                string RECHDR_Date = row["RECHDR_Date"].ToString();
                list.Add(new PrdAppworkorderList(CHQDTL_RealizedDate, RECHDR_Date, APPMST_AppID, APPMST_AppNo, APPMST_AppDate, APPMST_CustomerID, APPMST_Address2, APPMST_Name, APPMST_Area, APPMST_CustType, PLAMST_PlanName, APPMST_WOType, APPMST_WOTYPEID, RequestID, APPMST_Mobile, WORTRN_WorkOrdAmt, count));
            }
            return list;
        }



        public IList<PrdAppworkorderListEdit> GetPrdAppworkordersEdit()
        {
            string sortExpression = "APPMST_AppID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPrdAppworkordersEdit(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PrdAppworkorderListEdit> GetPrdAppworkordersEdit(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDWorkOrderMaster_GetForEdit ");
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
            int count1 = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PrdAppworkorderListEdit> list = new List<PrdAppworkorderListEdit>();
            foreach (DataRow row in dtList.Rows)
            {
                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APPMST_AppDate = row["APPMST_AppDate"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string APPMST_Address2 = row["APPMST_Address2"].ToString();
                string APPMST_Name = row["APPMST_Name"].ToString();
                string APPMST_Area = row["APPMST_Area"].ToString();
                string APPMST_CustType = row["APPMST_CustType"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string APPMST_WOType = row["APPMST_WOType"].ToString();
                int APPMST_WOTYPEID = int.Parse(row["APPMST_WOTYPEID"].ToString());
                int RequestID = int.Parse(row["WORTRN_RequestID"].ToString());
                decimal APPMST_Mobile = decimal.Parse(row["APPMST_Mobile"].ToString());
                decimal WORTRN_WorkOrdAmt = Convert.ToDecimal(row["WORTRN_WorkOrdAmt"]);
                string CHQDTL_RealizedDate = string.Empty;
                if (!string.IsNullOrEmpty(Convert.ToString(row["CHQDTL_RealizedDate"])))
                    CHQDTL_RealizedDate = row["CHQDTL_RealizedDate"].ToString();
                list.Add(new PrdAppworkorderListEdit(CHQDTL_RealizedDate, APPMST_AppID, APPMST_AppNo, APPMST_AppDate, APPMST_CustomerID, APPMST_Address2, APPMST_Name, APPMST_Area, APPMST_CustType, PLAMST_PlanName, APPMST_WOType, APPMST_WOTYPEID, RequestID, APPMST_Mobile, WORTRN_WorkOrdAmt, count1));
            }
            return list;
        }

        public PRDWorkOrderTRN GetPRDWorkOrderTRN(int PRDWorkOrderTRNid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRN_Select " + PRDWorkOrderTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int WORTRN_WorkOrdNo = Convert.ToInt32(row["WORTRN_WorkOrdNo"]);
            string WORTRN_WorkOrdRefNo = Convert.ToString(row["WORTRN_WorkOrdRefNo"]);
            string WORTRN_WorkOrdDate = Convert.ToString(row["WORTRN_WorkOrdDate"]);
            int WORTRN_ApplicationID = Convert.ToInt32(row["WORTRN_ApplicationID"]);
            int WORTRN_WorkOrderTYpe = Convert.ToInt32(row["WORTRN_WorkOrderTYpe"]);
            int WORTRN_ContractorID = Convert.ToInt32(row["WORTRN_ContractorID"]);
            string WORTRN_Remarks = Convert.ToString(row["WORTRN_Remarks"]);
            int WORTRN_Flag = Convert.ToInt32(row["WORTRN_Flag"]);
            int WORTRN_CreatedByUserID = Convert.ToInt32(row["WORTRN_CreatedByUserID"]);
            string WORTRN_CreatedDateTime = Convert.ToString(row["WORTRN_CreatedDateTime"]);
            int WORTRN_UpdatedByUserID = Convert.ToInt32(row["WORTRN_UpdatedByUserID"]);
            string WORTRN_UpdatedDateTime = Convert.ToString(row["WORTRN_UpdatedDateTime"]);
            int WORTRN_RowStatus = Convert.ToInt32(row["WORTRN_RowStatus"]);
            long WORTRN_RowVersion = long.Parse(row["WORTRN_RowVersion"].ToString());
            int WORTRN_Freeze = Convert.ToInt32(row["WORTRN_Freeze"]);
            int WORTRN_RequestID = Convert.ToInt32(row["WORTRN_RequestID"]);
            decimal WORTRN_WorkOrdAmt = Convert.ToDecimal(row["WORTRN_WorkOrdAmt"]);
            #endregion

            return new
            PRDWorkOrderTRN(WORTRN_WorkOrdNo, WORTRN_WorkOrdRefNo, WORTRN_WorkOrdDate, WORTRN_ApplicationID, WORTRN_WorkOrderTYpe, WORTRN_ContractorID, WORTRN_Remarks, WORTRN_Flag, WORTRN_CreatedByUserID, WORTRN_CreatedDateTime, WORTRN_UpdatedByUserID, WORTRN_UpdatedDateTime, WORTRN_RowStatus, WORTRN_RowVersion, WORTRN_Freeze, WORTRN_RequestID, WORTRN_WorkOrdAmt);
        }

        public PRDWorkOrderTRN GetPRDWorkOrderTRN(int PRDWorkOrderTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRN_Select " + PRDWorkOrderTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int WORTRN_WorkOrdNo = Convert.ToInt32(row["WORTRN_WorkOrdNo"]);
            string WORTRN_WorkOrdRefNo = Convert.ToString(row["WORTRN_WorkOrdRefNo"]);
            string WORTRN_WorkOrdDate = Convert.ToString(row["WORTRN_WorkOrdDate"]);
            int WORTRN_ApplicationID = Convert.ToInt32(row["WORTRN_ApplicationID"]);
            int WORTRN_WorkOrderTYpe = Convert.ToInt32(row["WORTRN_WorkOrderTYpe"]);
            int WORTRN_ContractorID = Convert.ToInt32(row["WORTRN_ContractorID"]);
            string WORTRN_Remarks = Convert.ToString(row["WORTRN_Remarks"]);
            int WORTRN_Flag = Convert.ToInt32(row["WORTRN_Flag"]);
            int WORTRN_CreatedByUserID = Convert.ToInt32(row["WORTRN_CreatedByUserID"]);
            string WORTRN_CreatedDateTime = Convert.ToString(row["WORTRN_CreatedDateTime"]);
            int WORTRN_UpdatedByUserID = Convert.ToInt32(row["WORTRN_UpdatedByUserID"]);
            string WORTRN_UpdatedDateTime = Convert.ToString(row["WORTRN_UpdatedDateTime"]);
            int WORTRN_RowStatus = Convert.ToInt32(row["WORTRN_RowStatus"]);
            long WORTRN_RowVersion = long.Parse(row["WORTRN_RowVersion"].ToString());
            int WORTRN_Freeze = Convert.ToInt32(row["WORTRN_Freeze"]);
            int WORTRN_RequestID = Convert.ToInt32(row["WORTRN_RequestID"]);
            decimal WORTRN_WorkOrdAmt = Convert.ToDecimal(row["WORTRN_WorkOrdAmt"]);
            #endregion

            return new
            PRDWorkOrderTRN(WORTRN_WorkOrdNo, WORTRN_WorkOrdRefNo, WORTRN_WorkOrdDate, WORTRN_ApplicationID, WORTRN_WorkOrderTYpe, WORTRN_ContractorID, WORTRN_Remarks, WORTRN_Flag, WORTRN_CreatedByUserID, WORTRN_CreatedDateTime, WORTRN_UpdatedByUserID, WORTRN_UpdatedDateTime, WORTRN_RowStatus, WORTRN_RowVersion, WORTRN_Freeze, WORTRN_RequestID, WORTRN_WorkOrdAmt);
        }
        public PRDWorkOrderTRN GetPRDWorkOrderTRNforDDL(string PRDWorkOrderTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRN_SelectforFreez " + PRDWorkOrderTRNid);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());
            int WORTRN_WorkOrdNo = 0;
            string WORTRN_WorkOrdRefNo = "";
            string WORTRN_WorkOrdDate = "";
            int WORTRN_ApplicationID = 0;
            int WORTRN_WorkOrderTYpe = 0;
            int WORTRN_ContractorID = 0;
            string WORTRN_Remarks = "";
            int WORTRN_Flag = 0;
            int WORTRN_CreatedByUserID = 0;
            string WORTRN_CreatedDateTime = "";
            int WORTRN_UpdatedByUserID = 0;
            string WORTRN_UpdatedDateTime = "";
            int WORTRN_RowStatus = 0;
            long WORTRN_RowVersion = 0;
            int WORTRN_Freeze = 0;
            decimal WORTRN_WorkOrdAmt = 0;
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"
                WORTRN_WorkOrdNo = Convert.ToInt32(row["WORTRN_WorkOrdNo"]);
                WORTRN_WorkOrdRefNo = Convert.ToString(row["WORTRN_WorkOrdRefNo"]);
                WORTRN_WorkOrdDate = Convert.ToString(row["WORTRN_WorkOrdDate"]);
                WORTRN_ApplicationID = Convert.ToInt32(row["WORTRN_ApplicationID"]);
                WORTRN_WorkOrderTYpe = Convert.ToInt32(row["WORTRN_WorkOrderTYpe"]);
                WORTRN_ContractorID = Convert.ToInt32(row["WORTRN_ContractorID"]);
                WORTRN_Remarks = Convert.ToString(row["WORTRN_Remarks"]);
                WORTRN_Flag = Convert.ToInt32(row["WORTRN_Flag"]);
                WORTRN_CreatedByUserID = Convert.ToInt32(row["WORTRN_CreatedByUserID"]);
                WORTRN_CreatedDateTime = Convert.ToString(row["WORTRN_CreatedDateTime"]);
                WORTRN_UpdatedByUserID = Convert.ToInt32(row["WORTRN_UpdatedByUserID"]);
                WORTRN_UpdatedDateTime = Convert.ToString(row["WORTRN_UpdatedDateTime"]);
                WORTRN_RowStatus = Convert.ToInt32(row["WORTRN_RowStatus"]);
                WORTRN_RowVersion = long.Parse(row["WORTRN_RowVersion"].ToString());
                WORTRN_Freeze = Convert.ToInt32(row["WORTRN_Freeze"]);
                WORTRN_WorkOrdAmt = Convert.ToDecimal(row["WORTRN_WorkOrdAmt"]);
                #endregion
            }
            return new
            PRDWorkOrderTRN(WORTRN_WorkOrdNo, WORTRN_WorkOrdRefNo, WORTRN_WorkOrdDate, WORTRN_ApplicationID, WORTRN_WorkOrderTYpe, WORTRN_ContractorID, WORTRN_Remarks, WORTRN_Flag, WORTRN_CreatedByUserID, WORTRN_CreatedDateTime, WORTRN_UpdatedByUserID, WORTRN_UpdatedDateTime, WORTRN_RowStatus, WORTRN_RowVersion, WORTRN_Freeze, 0, WORTRN_WorkOrdAmt);
        }


        public PRDWorkOrderTRNMsg InsertPRDWorkOrderTRN(PRDWorkOrderTRN PRDWorkOrderTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRN_Insert '");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdRefNo + "','");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdDate + "',");
            sql.Append(PRDWorkOrderTRN.WORTRN_ApplicationID + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrderTYpe + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_ContractorID + ",'");
            sql.Append(PRDWorkOrderTRN.WORTRN_Remarks + "',");
            sql.Append(PRDWorkOrderTRN.WORTRN_Flag + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_CreatedByUserID + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_RowStatus + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_RequestID + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdAmt);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDWorkOrderTRNMsg(_RetVal, _RetStr);
        }

        //public PRDWorkOrderTRNMsg InsertPRDWorkOrderTRNForFreez(PRDWorkOrderTRN PRDWorkOrderTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC usp_PRDWorkOrderTRNFreez_Insert '");
        //    sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdRefNo + "','");           
        //    sql.Append(PRDWorkOrderTRN.WORTRN_Freeze);
        //    DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
        //    #region"Variables Declaration"

        //    int _RetVal = Convert.ToInt32(row["RetVal"]);
        //    string _RetStr = Convert.ToString(row["RetStr"]);
        //    #endregion

        //    return new PRDWorkOrderTRNMsg(_RetVal, _RetStr);
        //}

        public PRDWorkOrderTRNMsg UpdatePRDWorkOrderTRN(PRDWorkOrderTRN PRDWorkOrderTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRN_Update ");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdNo + ",'");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdRefNo + "','");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdDate + "',");
            sql.Append(PRDWorkOrderTRN.WORTRN_ApplicationID + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrderTYpe + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_ContractorID + ",'");
            sql.Append(PRDWorkOrderTRN.WORTRN_Remarks + "',");
            sql.Append(PRDWorkOrderTRN.WORTRN_Flag + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_CreatedByUserID + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_UpdatedByUserID + ",'");
            sql.Append(PRDWorkOrderTRN.WORTRN_UpdatedDateTime + "',");
            sql.Append(PRDWorkOrderTRN.WORTRN_RowStatus + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_RequestID + ",");
            sql.Append(PRDWorkOrderTRN.WORTRN_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDWorkOrderTRNMsg(_RetVal, _RetStr);
        }
        public PRDWorkOrderTRNMsg UpdatePRDWorkOrderTRNForFreez(PRDWorkOrderTRN PRDWorkOrderTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRNFreez_Update '");
            sql.Append(PRDWorkOrderTRN.WORTRN_WorkOrdRefNo + "'");
            //sql.Append(PRDWorkOrderTRN.WORTRN_Freeze);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDWorkOrderTRNMsg(_RetVal, _RetStr);
        }
        public PRDWorkOrderTRNMsg DeletePRDWorkOrderTRN(int PRDWorkOrderTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_PRDWorkOrderTRN_Delete " + PRDWorkOrderTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDWorkOrderTRNMsg(_RetVal, _RetStr);
        }

    }
}
