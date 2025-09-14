using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORSendEmailHistoryDao : ICORSendEmailHistoryDao
    {
        private readonly DbManager _dbManager;

        public CORSendEmailHistoryDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORSendEmailHistoryList> GetCORSendEmailHistorys()
        {
            string sortExpression = "Id";
            string sortType = "Desc";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORSendEmailHistorys(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORSendEmailHistoryList> GetCORSendEmailHistorys(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSendEmailHistory_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'Id',");
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
            int SendEmailCounter = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORSendEmailHistoryList> list = new List<CORSendEmailHistoryList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int Id = int.Parse(row["Id"].ToString());
                string CustomerId = row["CustomerId"].ToString();
                string ToEmailAddress = row["ToEmailAddress"].ToString();
                string CCEmailAddress = row["CCEmailAddress"].ToString();
                string EmailSubject = row["EmailSubject"].ToString();
                string EmailBody = row["EmailBody"].ToString();
                string CreatedDate = row["CreatedDate"].ToString();
                int NoOfAttachment = Convert.ToInt32(row["NoOfAttachment"].ToString());
                string AttachmentPath = row["AttachmentPath"].ToString();
                int CreatedBy = Convert.ToInt32(row["CreatedBy"].ToString());
                string SendStatus = row["SendStatus"].ToString();
                int IsAttachReq = Convert.ToInt32(row["IsAttachReq"]);
                list.Add(new CORSendEmailHistoryList(Id, CustomerId, ToEmailAddress, CCEmailAddress, EmailSubject, EmailBody, NoOfAttachment, AttachmentPath, SendStatus, CreatedBy, CreatedDate, SendEmailCounter, IsAttachReq));
            }
            return list;
        }

        public CORSendEmailHistory GetCORSendEmailHistory(int CORSendEmailHistoryid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSendEmailHistory_Select " + CORSendEmailHistoryid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int Id = int.Parse(row["Id"].ToString());
            string CustomerId = row["CustomerId"].ToString();
            string ToEmailAddress = row["ToEmailAddress"].ToString();
            string CCEmailAddress = row["CCEmailAddress"].ToString();
            string EmailSubject = row["EmailSubject"].ToString();
            string EmailBody = row["EmailBody"].ToString();
            string CreatedDate = row["CreatedDate"].ToString();
            int NoOfAttachment = Convert.ToInt32(row["NoOfAttachment"].ToString());
            string AttachmentPath = row["AttachmentPath"].ToString();
            int CreatedBy = Convert.ToInt32(row["CreatedBy"].ToString());
            int SendStatus = row["SendStatus"].ToString().ToLower() == "true" ? 1 : 0;
            int IsAttachReq = Convert.ToInt32(row["IsAttachReq"]);
            #endregion

            return new
            CORSendEmailHistory(Id, CustomerId, ToEmailAddress, CCEmailAddress, EmailSubject, EmailBody, SendStatus, NoOfAttachment, AttachmentPath, CreatedBy, CreatedDate, IsAttachReq);
        }
    }
}
