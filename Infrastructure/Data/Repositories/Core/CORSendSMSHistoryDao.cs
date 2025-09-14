using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORSendSMSHistoryDao : ICORSendSMSHistoryDao
    {
        private readonly DbManager _dbManager;

        public CORSendSMSHistoryDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORSendSMSHistoryList> GetCORSendSMSHistorys()
        {
            string sortExpression = "Id";
            string sortType = "Desc";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORSendSMSHistorys(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORSendSMSHistoryList> GetCORSendSMSHistorys(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSendSMSHistory_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'sms_id',");
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
            int SendSMSCounter = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORSendSMSHistoryList> list = new List<CORSendSMSHistoryList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int sms_id = int.Parse(row["sms_id"].ToString());
                string CustomerId = string.Empty;
                string mobileno = row["mobileno"].ToString();
                string message = row["message"].ToString();
                string enterdate = row["enterdate"].ToString();
                string sentdate = row["sentdate"].ToString();
                string SendStatus = row["SendStatus"].ToString();
                list.Add(new CORSendSMSHistoryList(sms_id, CustomerId, mobileno, message, enterdate, sentdate, SendStatus, SendSMSCounter));
            }
            return list;
        }

        public CORSendSMSHistory GetCORSendSMSHistory(int CORSendSMSHistoryid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSendSMSHistory_Select " + CORSendSMSHistoryid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int sms_id = int.Parse(row["sms_id"].ToString());
            string CustomerId = string.Empty;
            string mobileno = row["mobileno"].ToString();
            string message = row["message"].ToString();
            string enterdate = row["enterdate"].ToString();
            string sentdate = row["sentdate"].ToString();
            int SendStatus = Convert.ToInt32(row["SendStatus"].ToString() == "1" ? 1 : 0);
            string Remarks = Convert.ToString(row["Remarks"]);
            string ErrorDescription = Convert.ToString(row["ErrorDescription"]);
            int CreatedBy = Convert.ToInt32(row["UserId"]);
            string CreatedDate = row["enterdate"].ToString();

            #endregion

            return new
            CORSendSMSHistory(sms_id, CustomerId, mobileno, message, SendStatus, Remarks, ErrorDescription, sentdate, CreatedBy, CreatedDate);
        }
    }
}

