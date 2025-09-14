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
    public class CSMCallAllocationDetailDao : ICSMCallAllocationDetailDao
    {
        private readonly DbManager _dbManager;

        public CSMCallAllocationDetailDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMCallAllocationDetailList> GetCSMCallAllocationDetails()
        {
            string sortExpression = "CALLOD_CallAllocationId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMCallAllocationDetails(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CSMCallAllocationDetailList> GetCSMCallAllocationDetails(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallAllocationDetail_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CALDTL_TokenNo',");
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
            IList<CSMCallAllocationDetailList> list = new List<CSMCallAllocationDetailList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CALDTL_CallLogId = int.Parse(row["CALDTL_CallLogId"].ToString());
                string CALDTL_TokenNo = row["CALDTL_TokenNo"].ToString();
                int CALDTL_Appid = int.Parse(row["CALDTL_Appid"].ToString());
                string CustomerName = row["CustomerName"].ToString();
                string CALDTL_ReportDate = row["CALDTL_ReportDate"].ToString();
                string CALDTL_ReportTime = row["CALDTL_ReportTime"].ToString();
                string CALDTL_Phone = row["CALDTL_Phone"].ToString();
                string CALDTL_Mobile = row["CALDTL_Mobile"].ToString();
                string Priority = row["Priority"].ToString();
                string ClosedBefore = row["ClosedBefore"].ToString();
                string Area = row["Area"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string CADTL_CallStatus = row["CallStatus"].ToString();
                string AllocatedTo = row["AllocatedTo"].ToString();
                string UpdatedBy = row["UpdatedBy"].ToString();
                string CALLOD_AttendDate = row["CALLOD_AttendDate"].ToString();
                string CALLOD_AttendTime = row["CALLOD_AttendTime"].ToString();
                string CALLOD_FCR_Remarks = row["CALLOD_FCR_Remarks"].ToString();
                string PROMST_Description = row["PROMST_Description"].ToString();
                string CallType = row["CallType"].ToString();
                list.Add(new CSMCallAllocationDetailList(CALDTL_CallLogId, CALDTL_TokenNo, CALDTL_Appid, CustomerName, CALDTL_ReportDate, CALDTL_ReportTime, CALDTL_Phone, CALDTL_Mobile, ClosedBefore, Priority, Area, APPMST_AppNo, APPMST_CustomerID, CADTL_CallStatus, AllocatedTo, UpdatedBy, CALLOD_AttendDate, CALLOD_AttendTime, CALLOD_FCR_Remarks, PROMST_Description, CallType, Count));
            }
            return list;
        }

        public CSMCallAllocationDetail GetCSMCallAllocationDetail(int CSMCallAllocationDetailid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallAllocationDetail_Select " + CSMCallAllocationDetailid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            decimal CALLOD_CallAllocationId = Convert.ToDecimal(row["CALLOD_CallAllocationId"]);
            decimal CALLOD_CallLogId = Convert.ToDecimal(row["CALLOD_CallLogId"]);
            string CALLOD_TokenNo = Convert.ToString(row["CALLOD_TokenNo"]);
            int CALLOD_ProblemId = Convert.ToInt32(row["CALLOD_ProblemId"]);
            int CALLOD_ProblemType = Convert.ToInt32(row["CALLOD_ProblemType"]);
            string CALLOD_Remarks = Convert.ToString(row["CALLOD_Remarks"]);
            string CALLOD_AdminRemarks = Convert.ToString(row["CALLOD_AdminRemarks"]);
            string CALLOD_AllocationDate = Convert.ToString(row["CALLOD_AllocationDate"]);
            string CALLOD_AllocationTime = Convert.ToString(row["CALLOD_AllocationTime"]);
            int CALLOD_AllocatedTo = Convert.ToInt32(row["CALLOD_AllocatedTo"]);
            int CALLOD_AllocatedBy = Convert.ToInt32(row["CALLOD_AllocatedBy"]);
            string CALLOD_AttendDate = Convert.ToString(row["CALLOD_AttendDate"]);
            string CALLOD_AttendTime = Convert.ToString(row["CALLOD_AttendTime"]);
            string CALLOD_ContactedPerson = Convert.ToString(row["CALLOD_ContactedPerson"]);
            string CALLOD_FCR_Remarks = Convert.ToString(row["CALLOD_FCR_Remarks"]);
            int CALLOD_Status = Convert.ToInt32(row["CALLOD_Status"]);
            int CALLOD_CenterId = Convert.ToInt32(row["CALLOD_CenterId"]);
            int CALLOD_FCRFilled_By = 0;
            if (row["CALLOD_FCRFilled_By"] != DBNull.Value)
            {
                CALLOD_FCRFilled_By = Convert.ToInt32(row["CALLOD_FCRFilled_By"]);
            }
            string CALLOD_FCR_Date = Convert.ToString(row["CALLOD_FCR_Date"]);
            string CALLOD_FCR_SaveTime = Convert.ToString(row["CALLOD_FCR_SaveTime"]);
            string CALLOD_ExtendedTime = Convert.ToString(row["CALLOD_ExtendedTime"]);
            string CALDTL_Phone = Convert.ToString(row["CALDTL_Phone"]);
            string CALDTL_Mobile = Convert.ToString(row["CALDTL_Mobile"]);
            string CALDTL_EmailId = Convert.ToString(row["CALDTL_EmailId"]);
            string Address = Convert.ToString(row["Address"]);
            int CALDTL_Appid = Convert.ToInt32(row["CALDTL_Appid"]);
            string Problem = Convert.ToString(row["ProblemDesc"]);
            string CustomerName = Convert.ToString(row["CustomerName"]);
            string Priority = Convert.ToString(row["Priority"]);
            string ClosedBefore = Convert.ToString(row["ClosedBefore"]);
            string CALDTL_PreferedDate = Convert.ToString(row["CALDTL_PreferedDate"]);
            string CALDTL_PreferedTime = Convert.ToString(row["CALDTL_PreferedTime"]);
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            #endregion

            return new
            CSMCallAllocationDetail(CALLOD_CallAllocationId, CALLOD_CallLogId, CALLOD_TokenNo, CALLOD_ProblemId, CALLOD_ProblemType, CALLOD_Remarks, CALLOD_AdminRemarks, CALLOD_AllocationDate, CALLOD_AllocationTime, CALLOD_AllocatedTo, CALLOD_AllocatedBy, CALLOD_AttendDate, CALLOD_AttendTime, CALLOD_ContactedPerson, CALLOD_FCR_Remarks, CALLOD_Status, CALLOD_CenterId, CALLOD_FCRFilled_By, CALLOD_FCR_Date, CALLOD_FCR_SaveTime, CALLOD_ExtendedTime, CALDTL_Phone, CALDTL_Mobile, CALDTL_Appid, CustomerName, CALDTL_PreferedDate, CALDTL_PreferedTime, CALDTL_EmailId, Address, Problem, Priority, ClosedBefore, APPMST_AppNo);
        }

        public CSMCallAllocationDetailMsg InsertCSMCallAllocationDetail(CSMCallAllocationDetail CSMCallAllocationDetail, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallAllocationDetail_Insert ");

            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_AdminRemarks + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_CallLogIds + "',");
            sql.Append(CSMCallAllocationDetail.CALLOD_AllocatedTo + ",");
            sql.Append(CSMCallAllocationDetail.CALLOD_AllocatedBy + ",");
            sql.Append(CSMCallAllocationDetail.CALLOD_CenterId);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CSMCallAllocationDetailMsg(_RetVal, _RetStr);
        }

        public CSMCallAllocationDetailMsg UpdateCSMCallAllocationDetail(CSMCallAllocationDetail CSMCallAllocationDetail, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMCallAllocationDetail_Update ");
            sql.Append(CSMCallAllocationDetail.CALLOD_CallAllocationId + ",");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_AllocationDate + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_AllocationTime + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_AttendDate + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_AttendTime + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_ContactedPerson + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_FCR_Remarks + "',");
            sql.Append(CSMCallAllocationDetail.CALLOD_Status + ",");
            sql.Append(CSMCallAllocationDetail.CALLOD_FCRFilled_By + ",");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_FCR_Date + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_FCR_SaveTime + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_ExtendedTime + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALDTL_PreferedDate + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALDTL_PreferedTime + "',");
            sql.Append("N'" + CSMCallAllocationDetail.CALLOD_AdminRemarks + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMCallAllocationDetailMsg(_RetVal, _RetStr);
        }

        public CSMCallAllocationDetailMsg DeleteCSMCallAllocationDetail(int CSMCallAllocationDetailID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_CSMCallAllocationDetail_Delete " + CSMCallAllocationDetailID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMCallAllocationDetailMsg(_RetVal, _RetStr);
        }

    }
}
