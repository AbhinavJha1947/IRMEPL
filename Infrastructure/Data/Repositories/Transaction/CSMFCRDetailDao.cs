using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class CSMFCRDetailDao : ICSMFCRDetailDao
    {
        private readonly DbManager _dbManager;

        public CSMFCRDetailDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMFCRDetailList> GetCSMFCRDetails()
        {
            string sortExpression = "CALLOD_CallAllocationId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMFCRDetails(sortExpression, sortType, pageIndex, pageSize, criteria);
        }
        public IList<CSMFCRDetailList> GetCSMFCRDetails(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMFCR_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CALLOD_CallAllocationId',");
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
            IList<CSMFCRDetailList> list = new List<CSMFCRDetailList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CALDTL_CallLogId = int.Parse(row["CALLOD_CallAllocationId"].ToString());
                string CALDTL_TokenNo = row["CALLOD_TokenNo"].ToString();
                int CALDTL_Appid = int.Parse(row["CALDTL_Appid"].ToString());
                string CustomerName = row["CustomerName"].ToString();
                string ReportDate = row["AllocationDate"].ToString();
                string ReportTime = row["AllocationTime"].ToString();
                string Phone = row["CALDTL_Phone"].ToString();
                string Mobile = row["CALDTL_Mobile"].ToString();
                string Priority = row["Priority"].ToString();
                string ClosedBefore = row["ClosedBefore"].ToString();
                string Area = row["Area"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                int CALDTL_Status = int.Parse(row["CALDTL_Status"].ToString());
                string CALStatus = row["CALStatus"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();

                list.Add(new CSMFCRDetailList(CALDTL_CallLogId, CALDTL_TokenNo, CALDTL_Appid, CustomerName, ReportDate, ReportTime, Phone, Mobile, ClosedBefore, Priority, Area, APPMST_AppNo, CALDTL_Status, CALStatus, APPMST_CustomerID, Count));

            }
            return list;
        }

        public IList<CallAllocationLogDetailList> GetCallAllocationLogDetail(string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CallAllocationLogDetail ");
            sql.Append("'" + criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CallAllocationLogDetailList> list = new List<CallAllocationLogDetailList>();
            foreach (DataRow row in dtList.Rows)
            {
                string CALLOD_TokenNo = row["CALLOD_TokenNo"].ToString();
                string CALLOD_AdminRemarks = row["CALLOD_AdminRemarks"].ToString();
                string CALLOD_ContactedPerson = row["CALLOD_ContactedPerson"].ToString();
                string CALLOD_FCR_Remarks = row["CALLOD_FCR_Remarks"].ToString();
                string ComplaintStatus = row["ComplaintStatus"].ToString();
                string UserName = row["UserName"].ToString();
                string CALLOD_FCR_Date = row["CALLOD_FCR_Date"].ToString();

                list.Add(new CallAllocationLogDetailList(CALLOD_TokenNo, CALLOD_AdminRemarks, CALLOD_ContactedPerson, CALLOD_FCR_Remarks, ComplaintStatus, UserName, CALLOD_FCR_Date));

            }
            return list;
        }

    }
}
