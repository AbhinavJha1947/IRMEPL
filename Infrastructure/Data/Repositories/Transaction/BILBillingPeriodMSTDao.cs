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
    public class BILBillingPeriodMSTDao : IBILBillingPeriodMSTDao
    {
        private readonly DbManager _dbManager;

        public BILBillingPeriodMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILBillingPeriodMSTList> GetBILBillingPeriodMSTs()
        {
            string sortExpression = "BILMST_PeriodID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILBillingPeriodMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILBillingPeriodMSTList> GetBILBillingPeriodMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingPeriodMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'BILMST_PeriodID',");
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
            IList<BILBillingPeriodMSTList> list = new List<BILBillingPeriodMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                int BILMST_PeriodID = int.Parse(row["BILMST_PeriodID"].ToString());
                string BILMST_Name = row["BILMST_Name"].ToString();
                string BILMST_RowStatus = row["BILMST_RowStatus"].ToString();

                list.Add(new BILBillingPeriodMSTList(BILMST_PeriodID, BILMST_Name, BILMST_RowStatus, Count));
            }
            return list;
        }

        public BILBillingPeriodMST GetBILBillingPeriodMST(int BILBillingPeriodMSTid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingPeriodMST_Select " + BILBillingPeriodMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int BILMST_PeriodID = Convert.ToInt32(row["BILMST_PeriodID"]);
            string BILMST_Name = Convert.ToString(row["BILMST_Name"]);
            int BILMST_CreatedBy = Convert.ToInt32(row["BILMST_CreatedBy"]);
            string BILMST_CreatedDate = Convert.ToString(row["BILMST_CreatedDate"]);
            int BILMST_UpdatedBy = Convert.ToInt32(row["BILMST_UpdatedBy"]);
            string BILMST_UpdatedDate = Convert.ToString(row["BILMST_UpdatedDate"]);
            int BILMST_RowStatus = Convert.ToInt32(row["BILMST_RowStatus"]);
            long BILMST_RowVersion = (long)row["BILMST_RowVersion"];


            #endregion

            return new
            BILBillingPeriodMST(BILMST_PeriodID, BILMST_Name, BILMST_CreatedBy, BILMST_CreatedDate, BILMST_UpdatedBy, BILMST_UpdatedDate, BILMST_RowStatus, BILMST_RowVersion);
        }

        public BILBillingPeriodMSTMsg InsertBILBillingPeriodMST(BILBillingPeriodMST BILBillingPeriodMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingPeriodMST_Insert ");
            sql.Append("N'" + BILBillingPeriodMST.BILMST_Name + "',");
            sql.Append(BILBillingPeriodMST.BILMST_CreatedBy + ",");
            sql.Append(BILBillingPeriodMST.BILMST_UpdatedBy + ",");
            sql.Append(BILBillingPeriodMST.BILMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILBillingPeriodMSTMsg(_RetVal, _RetStr);
        }

        public BILBillingPeriodMSTMsg UpdateBILBillingPeriodMST(BILBillingPeriodMST BILBillingPeriodMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingPeriodMST_Update ");
            sql.Append(BILBillingPeriodMST.BILMST_PeriodID + ",");
            sql.Append("N'" + BILBillingPeriodMST.BILMST_Name + "',");
            sql.Append(BILBillingPeriodMST.BILMST_CreatedBy + ",");
            //sql.Append("N'"+BILBillingPeriodMST.BILMST_CreatedDate+"',");
            sql.Append(BILBillingPeriodMST.BILMST_UpdatedBy + ",");
            //sql.Append("N'"+BILBillingPeriodMST.BILMST_UpdatedDate+"',");
            sql.Append(BILBillingPeriodMST.BILMST_RowStatus + ",");
            sql.Append(BILBillingPeriodMST.BILMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILBillingPeriodMSTMsg(_RetVal, _RetStr);
        }

        public BILBillingPeriodMSTMsg DeleteBILBillingPeriodMST(int BILBillingPeriodMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingPeriodMST_Delete " + BILBillingPeriodMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILBillingPeriodMSTMsg(_RetVal, _RetStr);
        }
    }
}

