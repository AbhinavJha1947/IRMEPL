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
    public class PRDJobSheetHDRTRNDao : IPRDJobSheetHDRTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDJobSheetHDRTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDJobSheetHDRTRNList> GetPRDJobSheetHDRTRNs()
        {
            string sortExpression = "WORTRN_WorkOrdNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";

            return null;
        }

        public IList<PRDJobSheetHDRTRNList> GetPRDJobSheetHDRTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, int IsAddMode)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDWorkOrderTRN_SelectAll_ForJobsheet ");
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
            sql.Append(criteria + "',");
            sql.Append(IsAddMode);
            //sql.Append(blnExport)
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int jobcount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDJobSheetHDRTRNList> list = new List<PRDJobSheetHDRTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                string KeyField = row["KeyField"].ToString();
                int WORTRN_WorkOrdNo = int.Parse(row["WORTRN_WorkOrdNo"].ToString());
                string WORTRN_WorkOrdRefNo = row["WORTRN_WorkOrdRefNo"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string WORTRN_WorkOrdDate = row["WORTRN_WorkOrdDate"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string CD_ControlType = row["CD_ControlType"].ToString();
                string APP_Name = row["APP_Name"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string Address = row["Address"].ToString();
                int APPMST_Area = int.Parse(row["APPMST_Area"].ToString());
                string AREMST_Name = row["AREMST_Name"].ToString();
                int WORTRN_ContractorID = int.Parse(row["WORTRN_ContractorID"].ToString());
                string CONMST_Name = row["CONMST_Name"].ToString();
                int JOBHDR_JobSheetID = int.Parse(row["JOBHDR_JobSheetID"].ToString());
                string JOBHDR_DateofInst = row["JOBHDR_DateofInst"].ToString();
                string JOBHDR_Remarks = row["JOBHDR_Remarks"].ToString();
                decimal JOBHDR_MeterNo = decimal.Parse(row["JOBHDR_MeterNo"].ToString());
                string JOBHDR_RowStatus = row["JOBHDR_RowStatus"].ToString();
                string JOBHDR_ImagePath = row["JOBHDR_ImagePath"].ToString();
                list.Add(new PRDJobSheetHDRTRNList(KeyField, WORTRN_WorkOrdNo, WORTRN_WorkOrdRefNo, APPMST_AppNo, WORTRN_WorkOrdDate, APPMST_CustomerID, CD_ControlType, APP_Name, PLAMST_PlanName, Address, APPMST_Area, AREMST_Name, WORTRN_ContractorID, CONMST_Name, JOBHDR_JobSheetID, JOBHDR_DateofInst, JOBHDR_Remarks, JOBHDR_MeterNo, JOBHDR_RowStatus, JOBHDR_ImagePath, jobcount));
            }
            return list;
        }

        public IList<PRDJobSheetHDRTRNLIST> GetPRDJobSheetHDRTRNS()
        {
            string sortExpression = "JOBHDR_JobSheetID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";

            return null;
        }

        public IList<PRDJobSheetHDRTRNLIST> GetPRDJobSheetHDRTRNS(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetHDRTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'JOBHDR_JobSheetID',");
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
            DataSet ds = _dbManager.GetDataSet(sql.ToString(), ref cn, ref trn);
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDJobSheetHDRTRNLIST> list = new List<PRDJobSheetHDRTRNLIST>();
            foreach (DataRow row in dtList.Rows)
            {
                int JOBHDR_JobSheetID = int.Parse(row["JOBHDR_JobSheetID"].ToString());
                int JOBHDR_ApplicationId = int.Parse(row["JOBHDR_ApplicationId"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string JOBHDR_ContractorID = row["JOBHDR_ContractorID"].ToString();
                string JOBHDR_DateofInst = row["JOBHDR_DateofInst"].ToString();
                string JOBHDR_PlanFor = row["JOBHDR_PlanFor"].ToString();
                string JOBHDR_TypeofHouse = row["JOBHDR_TypeofHouse"].ToString();
                string JOBHDR_JobSheetType = row["JOBHDR_JobSheetType"].ToString();
                string JOBHDR_MeterNo = row["JOBHDR_MeterNo"].ToString();
                string JOBHDR_WorkOrdno = row["JOBHDR_WorkOrdno"].ToString();
                string JOBHDR_ActualAmt = row["JOBHDR_ActualAmt"].ToString();
                string JOBHDR_ImagePath = row["JOBHDR_ImagePath"].ToString();

                list.Add(new PRDJobSheetHDRTRNLIST(JOBHDR_JobSheetID, JOBHDR_ApplicationId, APPMST_AppNo, JOBHDR_ContractorID, JOBHDR_DateofInst, JOBHDR_PlanFor, JOBHDR_TypeofHouse, JOBHDR_JobSheetType, JOBHDR_MeterNo, JOBHDR_WorkOrdno, JOBHDR_ActualAmt, JOBHDR_ImagePath, Count));
            }
            return list;
        }

        public PRDJobSheetHDRTRN GetPRDJobSheetHDRTRN(int JOBHDR_JobSheetID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_PRDJobSheetHDRTRN_Select " + JOBHDR_JobSheetID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            //int JOBHDR_JobSheetID = Convert.ToInt32(row["JOBHDR_JobSheetID"]);
            int JOBHDR_ApplicationId = Convert.ToInt32(row["JOBHDR_ApplicationId"]);
            int JOBHDR_ContractorID = Convert.ToInt32(row["JOBHDR_ContractorID"]);
            string JOBHDR_Remarks = Convert.ToString(row["JOBHDR_Remarks"]);
            string JOBHDR_DateofInst = Convert.ToString(row["JOBHDR_DateofInst"]);
            int JOBHDR_PlanId = Convert.ToInt32(row["JOBHDR_PlanId"]);
            int JOBHDR_PlanFor = Convert.ToInt32(row["JOBHDR_PlanFor"]);
            int JOBHDR_TypeofHouse = Convert.ToInt32(row["JOBHDR_TypeofHouse"]);
            int JOBHDR_Flag = Convert.ToInt32(row["JOBHDR_Flag"]);
            int JOBHDR_JobSheetType = Convert.ToInt32(row["JOBHDR_JobSheetType"]);
            int JOBHDR_MeterNo = Convert.ToInt32(row["JOBHDR_MeterNo"]);
            int JOBHDR_WorkOrdno = Convert.ToInt32(row["JOBHDR_WorkOrdno"]);
            decimal JOBHDR_ActualAmt = Convert.ToDecimal(row["JOBHDR_ActualAmt"]);
            int JOBHDR_CreatedByUserID = Convert.ToInt32(row["JOBHDR_CreatedByUserID"]);
            string JOBHDR_CreatedDateTime = Convert.ToString(row["JOBHDR_CreatedDateTime"]);
            int JOBHDR_UpdatedByUserID = Convert.ToInt32(row["JOBHDR_UpdatedByUserID"]);
            string JOBHDR_UpdatedDateTime = Convert.ToString(row["JOBHDR_UpdatedDateTime"]);
            int JOBHDR_RowStatus = Convert.ToInt32(row["JOBHDR_RowStatus"]);
            long JOBHDR_RowVersion = long.Parse(row["JOBHDR_RowVersion"].ToString());
            string JOBHDR_ImagePath = Convert.ToString(row["JOBHDR_ImagePath"]);
            #endregion

            return new
            PRDJobSheetHDRTRN(JOBHDR_JobSheetID, JOBHDR_ApplicationId, JOBHDR_ContractorID, JOBHDR_Remarks, JOBHDR_DateofInst, JOBHDR_PlanId, JOBHDR_PlanFor, JOBHDR_TypeofHouse, JOBHDR_Flag, JOBHDR_JobSheetType, JOBHDR_MeterNo, JOBHDR_WorkOrdno, JOBHDR_ActualAmt, JOBHDR_CreatedByUserID, JOBHDR_CreatedDateTime, JOBHDR_UpdatedByUserID, JOBHDR_UpdatedDateTime, JOBHDR_RowStatus, JOBHDR_RowVersion, JOBHDR_ImagePath);
        }

        public PRDJobSheetHDRTRN GetUsp_PRDJobSheetHDRTRN_Select_ByAppNoAndDtOfInst(string APPMST_AppNo, string JOBHDR_DateofInst)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_PRDJobSheetHDRTRN_Select_ByAppNoAndDtOfInst ");
            sql.Append("'" + APPMST_AppNo + "'");
            sql.Append(",'" + JOBHDR_DateofInst + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            int JOBHDR_JobSheetID = 0;
            int JOBHDR_ApplicationId = 0;
            int JOBHDR_ContractorID = 0;
            string JOBHDR_Remarks = "";

            int JOBHDR_PlanId = 0;
            int JOBHDR_PlanFor = 0;
            int JOBHDR_TypeofHouse = 0;
            int JOBHDR_Flag = 0;
            int JOBHDR_JobSheetType = 0;
            int JOBHDR_MeterNo = 0;
            int JOBHDR_WorkOrdno = 0;
            decimal JOBHDR_ActualAmt = 0;
            int JOBHDR_CreatedByUserID = 0;
            string JOBHDR_CreatedDateTime = "0";
            int JOBHDR_UpdatedByUserID = 0;
            string JOBHDR_UpdatedDateTime = "0";
            int JOBHDR_RowStatus = 0;
            long JOBHDR_RowVersion = 0;
            string JOBHDR_ImagePath = "";
            if (row != null)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(row["JOBHDR_JobSheetID"])))
                {
                    #region"Variables Declaration"
                    JOBHDR_JobSheetID = Convert.ToInt32(row["JOBHDR_JobSheetID"]);
                    JOBHDR_ImagePath = Convert.ToString(row["JOBHDR_ImagePath"]);
                    #endregion
                }
            }
            return new
            PRDJobSheetHDRTRN(JOBHDR_JobSheetID, JOBHDR_ApplicationId, JOBHDR_ContractorID, JOBHDR_Remarks, JOBHDR_DateofInst, JOBHDR_PlanId, JOBHDR_PlanFor, JOBHDR_TypeofHouse, JOBHDR_Flag, JOBHDR_JobSheetType, JOBHDR_MeterNo, JOBHDR_WorkOrdno, JOBHDR_ActualAmt, JOBHDR_CreatedByUserID, JOBHDR_CreatedDateTime, JOBHDR_UpdatedByUserID, JOBHDR_UpdatedDateTime, JOBHDR_RowStatus, JOBHDR_RowVersion, JOBHDR_ImagePath);

        }
        public PRDJobSheetEdit GetPRDJobSheetEdit(int JOBHDR_WorkOrdno)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_PRDJobSheetHDRTRNEdit_Select " + JOBHDR_WorkOrdno);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int WORTRN_WorkOrderTYpe = Convert.ToInt32(row["WORTRN_WorkOrderTYpe"]);
            int WORTRN_WorkOrdNo = Convert.ToInt32(row["WORTRN_WorkOrdNo"]);
            string WORTRN_WorkOrdRefNo = Convert.ToString(row["WORTRN_WorkOrdRefNo"]);
            string WORTRN_WorkOrdDate = Convert.ToString(row["WORTRN_WorkOrdDate"]);
            int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
            //string CD_ControlType = row["CD_ControlType"].ToString();
            string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
            string APP_Name = Convert.ToString(row["APP_Name"]);
            int APPMST_CustType = Convert.ToInt32(row["APPMST_CustType"]);
            string Address = Convert.ToString(row["Address"]);
            int APPMST_PlanId = Convert.ToInt32(row["APPMST_PlanId"]);
            int WORTRN_ContractorID = Convert.ToInt32(row["WORTRN_ContractorID"]);
            int WORTRN_HouseType = Convert.ToInt32(row["WORTRN_HouseType"]);
            string APPMST_Latitude = string.Empty;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_Latitude"])))
                APPMST_Latitude = (string)row["APPMST_Latitude"];
            string APPMST_Longitude = string.Empty;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_Longitude"])))
                APPMST_Longitude = (string)row["APPMST_Longitude"];

            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            //int WORTRN_ContractorID = Convert.ToInt32(row["WORTRN_ContractorID"]);  

            int isPaymentReceived = Convert.ToInt32(row["isPaymentReceived"]); //Hina 23/10/2019
            #endregion

            return new
            PRDJobSheetEdit(WORTRN_WorkOrderTYpe, WORTRN_WorkOrdNo, WORTRN_WorkOrdRefNo, WORTRN_WorkOrdDate, APPMST_AppID, APPMST_AppNo, APP_Name, APPMST_CustType, Address, APPMST_PlanId, WORTRN_ContractorID, WORTRN_HouseType, APPMST_Latitude, APPMST_Longitude, isPaymentReceived, APPMST_CustomerID);
        }

        public PRDJobSheetHDRTRNMsg InsertPRDJobSheetHDRTRN(PRDJobSheetHDRTRN PRDJobSheetHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetHDRTRN_Insert ");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ApplicationId + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ContractorID + ",'");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_Remarks.Replace("'", "''") + "','");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_DateofInst + "',");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_PlanId + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_PlanFor + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_TypeofHouse + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_Flag + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_JobSheetType + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_MeterNo + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_WorkOrdno + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ActualAmt + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_CreatedByUserID + ",");
            //sql.Append(PRDJobSheetHDRTRN.JOBHDR_UpdatedByUserID + ",");          
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_RowStatus + ",");
            sql.Append("'" + PRDJobSheetHDRTRN.JOBHDR_ImagePath + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDJobSheetHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetHDRTRNMsg UpdatePRDJobSheetHDRTRN(PRDJobSheetHDRTRN PRDJobSheetHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetHDRTRN_Update ");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_JobSheetID + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ApplicationId + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ContractorID + ",'");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_Remarks.Replace("'", "''") + "','");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_DateofInst + "',");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_PlanId + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_PlanFor + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_TypeofHouse + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_Flag + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_JobSheetType + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_MeterNo + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_WorkOrdno + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ActualAmt + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_UpdatedByUserID + ",'");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_UpdatedDateTime + "',");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_RowStatus + ",");
            sql.Append("'" + PRDJobSheetHDRTRN.JOBHDR_ImagePath + "',");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDJobSheetHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetHDRTRNMsg UpdateUsp_PRDJobSheetHDRTRN_Update_ImagePath(string APPMST_AppNo, string JOBHDR_DateofInst, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_PRDJobSheetHDRTRN_Update_ImagePath ");
            sql.Append(APPMST_AppNo + ",");

            sql.Append("'" + JOBHDR_DateofInst + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDJobSheetHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetHDRTRNMsg DeletePRDJobSheetHDRTRN(int PRDJobSheetHDRTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetHDRTRN_Delete " + PRDJobSheetHDRTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDJobSheetHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetHDRTRNMsg InsertPRDJobSheetHDRTRN_ForCSVUpload(PRDJobSheetHDRTRN PRDJobSheetHDRTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDJobSheetHDRTRN_Insert_ForCSVUpload] ");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ApplicationId + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ContractorID + ",'");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_Remarks.Replace("'", "''") + "','");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_DateofInst + "',");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_PlanId + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_PlanFor + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_TypeofHouse + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_Flag + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_JobSheetType + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_MeterNo + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_WorkOrdno + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_ActualAmt + ",");
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_CreatedByUserID + ",");
            //sql.Append(PRDJobSheetHDRTRN.JOBHDR_UpdatedByUserID + ",");          
            sql.Append(PRDJobSheetHDRTRN.JOBHDR_RowStatus + ",");
            sql.Append("'" + PRDJobSheetHDRTRN.JOBHDR_ImagePath + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDJobSheetHDRTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetHDRTRNMsg ApprovePRDJobSheetHDRTRN(int ApprovalStatus, string PRDJobSheetHDRTRNIds, Int32 UserID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetHDRTRN_Approval " + ApprovalStatus + ",'" + PRDJobSheetHDRTRNIds + "'," + UserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDJobSheetHDRTRNMsg(_RetVal, _RetStr);
        }


    }
}
