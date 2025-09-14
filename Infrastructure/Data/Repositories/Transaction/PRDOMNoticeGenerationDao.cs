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
    public class PRDOMNoticeGenerationDao : IPRDOMNoticeGenerationDao
    {
        private readonly DbManager _dbManager;

        public PRDOMNoticeGenerationDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDOMNoticeGenerationList> GetPRDOMNoticeGenerations()
        {
            string sortExpression = "OMNTRN_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDOMNoticeGenerations(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDOMNoticeGenerationList> GetPRDOMNoticeGenerations(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDOMNoticeGeneration_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'NoticeNo',");
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
            IList<PRDOMNoticeGenerationList> list = new List<PRDOMNoticeGenerationList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int OMNTRN_ID = int.Parse(row["OMNTRN_ID"].ToString());
                string Notice_No = row["NoticeNo"].ToString();
                string NoticeDate = row["NoticeDate"].ToString();
                string CustomerId = row["CustomerId"].ToString();
                string Name = row["Name"].ToString();
                string Address1 = row["Address1"].ToString();
                string Area = row["Area"].ToString();

                list.Add(new PRDOMNoticeGenerationList(OMNTRN_ID, Notice_No, NoticeDate, CustomerId, Name, Address1, Area, Count));
            }
            return list;
        }

        public PRDOMNoticeGeneration GetPRDOMNoticeGeneration(int PRDOMNoticeGenerationid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDOMNoticeGeneration_Select " + PRDOMNoticeGenerationid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int OMNTRN_ID = Convert.ToInt32(row["OMNTRN_ID"]);
            string OMNTRN_NoticeNo = Convert.ToString(row["OMNTRN_NoticeNo"]);
            string OMNTRN_Date = Convert.ToString(row["OMNTRN_Date"]);
            int OMNTRn_AppID = Convert.ToInt32(row["OMNTRn_AppID"]);
            string OMNTRN_CustomerID = Convert.ToString(row["OMNTRN_CustomerID"]);
            int OMNTRN_Createdby = Convert.ToInt32(row["OMNTRN_Createdby"]);
            string OMNTRN_CreatedDate = Convert.ToString(row["OMNTRN_CreatedDate"]);

            #endregion

            return new
            PRDOMNoticeGeneration(OMNTRN_ID, OMNTRN_NoticeNo, OMNTRN_Date, OMNTRn_AppID, OMNTRN_CustomerID, OMNTRN_Createdby, OMNTRN_CreatedDate);
        }

        public PRDOMNoticeGenerationMsg InsertPRDOMNoticeGeneration(PRDOMNoticeGeneration PRDOMNoticeGeneration, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDOMNoticeGeneration_Insert ");
            //sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_NoticeNo + "',");
            //sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_Date + "',");
            sql.Append(PRDOMNoticeGeneration.OMNTRn_AppID + ",");
            sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_CustomerID + "',");
            sql.Append(PRDOMNoticeGeneration.OMNTRN_Createdby + "");
            // sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_CreatedDate + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDOMNoticeGenerationMsg(_RetVal, _RetStr);
        }

        public PRDOMNoticeGenerationMsg UpdatePRDOMNoticeGeneration(PRDOMNoticeGeneration PRDOMNoticeGeneration, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDOMNoticeGeneration_Update ");
            sql.Append(PRDOMNoticeGeneration.OMNTRN_ID + ",");
            sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_NoticeNo + "',");
            sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_Date + "',");
            sql.Append(PRDOMNoticeGeneration.OMNTRn_AppID + ",");
            sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_CustomerID + "',");
            sql.Append(PRDOMNoticeGeneration.OMNTRN_Createdby + ",");
            sql.Append("N'" + PRDOMNoticeGeneration.OMNTRN_CreatedDate + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new PRDOMNoticeGenerationMsg(_RetVal, _RetStr);
        }

        public PRDOMNoticeGenerationMsg DeletePRDOMNoticeGeneration(int PRDOMNoticeGenerationID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDOMNoticeGeneration_Delete " + PRDOMNoticeGenerationID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDOMNoticeGenerationMsg(_RetVal, _RetStr);
        }

    }
}
