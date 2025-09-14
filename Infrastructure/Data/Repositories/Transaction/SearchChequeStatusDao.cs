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
    public class SearchChequeStatusDao : ISearchChequeStatusDao
    {
        private readonly DbManager _dbManager;

        public SearchChequeStatusDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<SearchChequeStatus> GetSearchChequeStatus()
        {
            string sortExpression = "APPMST_AppNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetSearchChequeStatus(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<SearchChequeStatus> GetSearchChequeStatus(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_ChequeDetail_Search   ");

            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_AppNo',");
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

            IList<SearchChequeStatus> list = new List<SearchChequeStatus>();

            foreach (DataRow row in dtList.Rows)
            {
                string ApplicationNo = row["ApplicationNo"].ToString();
                string CustomerId = row["CustomerId"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string ReceiptNo = row["ReceiptNo"].ToString();
                string ReceiptDate = row["ReceiptDate"].ToString();
                string ChequeNo = Convert.ToString(row["ChequeNo"].ToString());
                string ChequeDate = row["ChequeDate"].ToString();
                decimal ChequeAmount = decimal.Parse(row["ChequeAmount"].ToString());
                string BankName = row["BankName"].ToString();
                string RealizedDate = row["RealizedDate"].ToString();
                string DishonourDate = row["DishonourDate"].ToString();
                string LotNo = row["LotNo"].ToString();
                string DepositDate = row["DepositDate"].ToString();
                string ControlType = row["ControlType"].ToString();

                list.Add(new SearchChequeStatus(ApplicationNo, CustomerId, CustomerName, ReceiptNo, ReceiptDate, ChequeNo, ChequeDate, ChequeAmount, BankName, RealizedDate, DishonourDate, LotNo, DepositDate, ControlType, Count));

            }

            return list;
        }

    }
}
