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
    public class CSMCallLogDetailDao : ICSMCallLogDetailDao
    {
        private readonly DbManager _dbManager;

        public CSMCallLogDetailDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMCallLogDetailList> GetCSMCallLogDetails()
        {
            string sortExpression = "CALDTL_CallLogId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMCallLogDetails(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CSMCallLogDetailList> GetCSMCallLogDetails(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallLogDetail_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CALDTL_CallLogId',");
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
            IList<CSMCallLogDetailList> list = new List<CSMCallLogDetailList>();
            foreach (DataRow row in dtList.Rows)
            {
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string Name = row["Name"].ToString();
                string CALDTL_ReportDate = row["CALDTL_ReportDate"].ToString();
                string Priority = row["Priority"].ToString();
                string PROMST_Description = row["PROMST_Description"].ToString();
                string Status = row["CStatus"].ToString();

                string AREMST_Name = row["AREMST_Name"].ToString();
                string CALDTL_ConcernedDepartment = row["CALDTL_ConcernedDepartment"].ToString();
                string CALDTL_TokenNo = row["CALDTL_TokenNo"].ToString();

                int CALDTL_CallLogId = int.Parse(row["CALDTL_CallLogId"].ToString());
                list.Add(new CSMCallLogDetailList(CALDTL_CallLogId, APPMST_AppNo, Name, CALDTL_ReportDate, Priority, PROMST_Description, Status, AREMST_Name, CALDTL_ConcernedDepartment, CALDTL_TokenNo, Count));
            }
            return list;
        }

        public CSMCallLogDetail GetCSMCallLogDetail(int CSMCallLogDetailid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallLogDetail_Select " + CSMCallLogDetailid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            decimal CALDTL_CallLogId = Convert.ToDecimal(row["CALDTL_CallLogId"]);
            string CALDTL_TokenNo = Convert.ToString(row["CALDTL_TokenNo"]);
            int CALDTL_Appid = Convert.ToInt32(row["CALDTL_Appid"]);
            string CALDTL_FName = Convert.ToString(row["CALDTL_FName"]);
            string CALDTL_MName = Convert.ToString(row["CALDTL_MName"]);
            string CALDTL_LName = Convert.ToString(row["CALDTL_LName"]);
            string CALDTL_ReportingPerson = Convert.ToString(row["CALDTL_ReportingPerson"]);
            string CALDTL_ReportDate = Convert.ToString(row["CALDTL_ReportDate"]);
            string CALDTL_ReportTime = Convert.ToString(row["CALDTL_ReportTime"]);
            string CALDTL_StartTime = Convert.ToString(row["CALDTL_StartTime"]);
            string CALDTL_EndTime = Convert.ToString(row["CALDTL_EndTime"]);
            int CALDTL_ConcernedDepartment = Convert.ToInt32(row["CALDTL_ConcernedDepartment"]);
            int CALDTL_ProblemId = Convert.ToInt32(row["CALDTL_ProblemId"]);
            string CALDTL_Remarks = Convert.ToString(row["CALDTL_Remarks"]);
            string CALDTL_ContactPerson = Convert.ToString(row["CALDTL_ContactPerson"]);
            string CALDTL_Phone = Convert.ToString(row["CALDTL_Phone"]);
            string CALDTL_Mobile = Convert.ToString(row["CALDTL_Mobile"]);
            string CALDTL_EmailId = Convert.ToString(row["CALDTL_EmailId"]);
            string CALDTL_Address = Convert.ToString(row["CALDTL_Address"]);
            int CALDTL_Area = Convert.ToInt32(row["CALDTL_Area"]);
            int CALDTL_City = 0;//Convert.ToInt32(row["CALDTL_City"]);
            string CALDTL_PreferedDate = Convert.ToString(row["CALDTL_PreferedDate"]);
            string CALDTL_PreferedTime = Convert.ToString(row["CALDTL_PreferedTime"]);
            int CALDTL_Status = Convert.ToInt32(row["CALDTL_Status"]);
            string CALDTL_ForceCloseRemarks = Convert.ToString(row["CALDTL_ForceCloseRemarks"]);
            int CALDTL_CenCode = Convert.ToInt32(row["CALDTL_CenCode"]);
            int CALDTL_UserId = Convert.ToInt32(row["CALDTL_UserId"]);
            string CALDTL_DateTime = Convert.ToString(row["CALDTL_DateTime"]);
            int CALDTL_SendSms = Convert.ToInt32(row["CALDTL_SendSms"]);
            int CALDTL_SendEmail = Convert.ToInt32(row["CALDTL_SendEmail"]);
            string Problem = Convert.ToString(row["Problem"]);
            string CustomerName = Convert.ToString(row["CustomerName"]);
            string Priority = Convert.ToString(row["Priority"]);
            string ClosedBefore = Convert.ToString(row["ClosedBefore"]);
            string Area = Convert.ToString(row["Area"]);
            string AppNo = Convert.ToString(row["APPMST_AppNo"]);
            int CALLOD_AllocatedTo = Convert.ToInt32(row["CALLOD_AllocatedTo"]);
            long APPMST_RowVersion = (long)row["CALDTL_RowVersion"];

            #endregion

            return new
            CSMCallLogDetail(CALDTL_CallLogId, CALDTL_TokenNo, CALDTL_Appid, CALDTL_FName, CALDTL_MName, CALDTL_LName, CALDTL_ReportingPerson, CALDTL_ReportDate, CALDTL_ReportTime, CALDTL_StartTime, CALDTL_EndTime, CALDTL_ConcernedDepartment, CALDTL_ProblemId, CALDTL_Remarks, CALDTL_ContactPerson, CALDTL_Phone, CALDTL_Mobile, CALDTL_EmailId, CALDTL_Address, CALDTL_Area, CALDTL_City, CALDTL_PreferedDate, CALDTL_PreferedTime, CALDTL_Status, CALDTL_ForceCloseRemarks, CALDTL_CenCode, CALDTL_UserId, CALDTL_DateTime, CALDTL_SendSms, CALDTL_SendEmail, Priority, ClosedBefore, Area, CustomerName, Problem, AppNo, CALLOD_AllocatedTo, APPMST_RowVersion);
        }

        public CSMCallLogDetailMsg InsertCSMCallLogDetail(CSMCallLogDetail CSMCallLogDetail, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallLogDetail_Insert ");
            sql.Append(CSMCallLogDetail.CALDTL_Appid + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_FName + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_MName + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_LName + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ReportingPerson + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ReportDate + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ReportTime + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_StartTime + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_EndTime + "',");
            sql.Append(CSMCallLogDetail.CALDTL_ConcernedDepartment + ",");
            sql.Append(CSMCallLogDetail.CALDTL_ProblemId + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Remarks + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ContactPerson + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Phone + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Mobile + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_EmailId + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Address + "',");
            sql.Append(CSMCallLogDetail.CALDTL_Area + ",");
            sql.Append(CSMCallLogDetail.CALDTL_City + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_PreferedDate + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_PreferedTime + "',");
            sql.Append(CSMCallLogDetail.CALDTL_Status + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ForceCloseRemarks + "',");
            sql.Append(CSMCallLogDetail.CALDTL_CenCode + ",");
            sql.Append(CSMCallLogDetail.CALDTL_UserId + ",");
            //sql.Append("N'" + CSMCallLogDetail.CALDTL_DateTime + "',");
            sql.Append(CSMCallLogDetail.CALDTL_SendSms + ",");

            sql.Append(CSMCallLogDetail.CALDTL_SendEmail + ",");
            sql.Append(CSMCallLogDetail.APPMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CSMCallLogDetailMsg(_RetVal, _RetStr);
        }

        public CSMCallLogDetailMsg UpdateCSMCallLogDetail(CSMCallLogDetail CSMCallLogDetail, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallLogDetail_Update ");
            sql.Append(CSMCallLogDetail.CALDTL_CallLogId + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_TokenNo + "',");
            sql.Append(CSMCallLogDetail.CALDTL_Appid + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_FName + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_MName + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_LName + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ReportingPerson + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ReportDate + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ReportTime + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_StartTime + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_EndTime + "',");
            sql.Append(CSMCallLogDetail.CALDTL_ConcernedDepartment + ",");
            sql.Append(CSMCallLogDetail.CALDTL_ProblemId + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Remarks + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ContactPerson + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Phone + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Mobile + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_EmailId + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_Address + "',");
            sql.Append(CSMCallLogDetail.CALDTL_Area + ",");
            sql.Append(CSMCallLogDetail.CALDTL_City + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_PreferedDate + "',");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_PreferedTime + "',");
            sql.Append(CSMCallLogDetail.CALDTL_Status + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ForceCloseRemarks + "',");
            sql.Append(CSMCallLogDetail.CALDTL_CenCode + ",");
            sql.Append(CSMCallLogDetail.CALDTL_UserId + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_DateTime + "',");
            sql.Append(CSMCallLogDetail.CALDTL_SendSms + ",");

            sql.Append(CSMCallLogDetail.CALDTL_SendEmail + ",");
            sql.Append(CSMCallLogDetail.APPMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMCallLogDetailMsg(_RetVal, _RetStr);
        }

        public CSMCallLogDetailMsg UpdateCSMCallLogDetailForceClose(CSMCallLogDetail CSMCallLogDetail, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallLogForceClose_Update ");
            sql.Append(CSMCallLogDetail.CALDTL_CallLogId + ",");
            sql.Append("N'" + CSMCallLogDetail.CALDTL_ForceCloseRemarks + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMCallLogDetailMsg(_RetVal, _RetStr);
        }

        public CSMCallLogDetailMsg DeleteCSMCallLogDetail(int CSMCallLogDetailID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallLogDetail_Delete " + CSMCallLogDetailID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMCallLogDetailMsg(_RetVal, _RetStr);
        }
        public IList<CSMAdvanceCallLogDetail> GetCSMAdvanceCallLogDetail(string SortColumn, string SortType, int PageIndex, int PageSize, string Criteria, int blnExport)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [usp_AdvanceCallLogDetail_Report] ");
            sql.Append("'" + SortColumn + "',");
            sql.Append("'" + SortType + "',");
            sql.Append("" + PageIndex + ",");
            sql.Append("" + PageSize + ",");
            sql.Append("'" + Criteria + "',");
            sql.Append("" + blnExport + "");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int _Count = int.Parse(dtRowCount.Rows[0][0].ToString());

            IList<CSMAdvanceCallLogDetail> list = new List<CSMAdvanceCallLogDetail>();
            foreach (DataRow row in dtList.Rows)
            {
                string _CALDTL_TokenNo = row["CALDTL_TokenNo"].ToString();
                string _APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string _APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string _PROMST_Description = row["PROMST_Description"].ToString();
                string _CALDTL_ReportDate = row["CALDTL_ReportDate"].ToString();
                string _CALDTL_ReportTime = row["CALDTL_ReportTime"].ToString();
                string _Status = row["Status"].ToString();
                list.Add(new CSMAdvanceCallLogDetail(_CALDTL_TokenNo, _APPMST_AppNo, _APPMST_CustomerID, _PROMST_Description, _CALDTL_ReportDate, _CALDTL_ReportTime, _Status, _Count));
            }
            return list;
        }
    }
}
