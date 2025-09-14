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
    public class CSTCustomerListDao : ICSTCustomerListDao
    {
        private readonly DbManager _dbManager;

        public CSTCustomerListDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSTCustomerList> GetCSTCustomerLists()
        {

            //string criteria = "";
            //int biilingid;
            //int area;
            //int custtype;
            //int billingtime;

            return GetCSTCustomerLists();
        }

        public IList<CSTCustomerList> GetCSTCustomerLists(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_Bill_CustomerList_Print ");
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CustomerId',");
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
            IList<CSTCustomerList> list = new List<CSTCustomerList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***

                string CustomerId = row["CustomerId"].ToString();
                string ApplicationId = row["Name"].ToString();
                string TypeOfCust = row["CustomerType"].ToString();
                string Address1 = row["AddressLine"].ToString();
                string Address2 = row["Society"].ToString();
                string Landmark = row["Landmark"].ToString();
                string AreaN = row["AreaName"].ToString();
                string Phone = row["Phone"].ToString();
                string Mobile = row["Mobile"].ToString();
                decimal PreviousReading = decimal.Parse(row["PreviousReading"].ToString());
                string CurrentReading = row["CurrentReading"].ToString();
                string ReadingDate = row["ReadingDate"].ToString();
                string CollectionDate = row["CollectionDate"].ToString();
                Int64 MeterNo = Int64.Parse(row["MeterNo"].ToString());

                list.Add(new CSTCustomerList(CustomerId, ApplicationId, TypeOfCust, Address1, Address2, Landmark, AreaN, Phone, Mobile, PreviousReading, CurrentReading, ReadingDate, CollectionDate, MeterNo, Count));
            }
            return list;
        }


        public IList<OMCUstomerList> GetOMCustomerLists()
        {
            return GetOMCustomerLists();
        }

        public IList<OMCUstomerList> GetOMCustomerLists(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CustomerList_OMNotice_SelectAll ");
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'ApplicationNo',");
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
            IList<OMCUstomerList> list = new List<OMCUstomerList>();
            foreach (DataRow row in dtList.Rows)
            {
                int ApplicationId = int.Parse(row["ApplicationId"].ToString());
                string ApplicationNo = row["ApplicationNo"].ToString();
                string CustomerId = row["CustomerId"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string Address = row["Address1"].ToString();
                string Area = row["Area"].ToString();
                string Plan = row["Plan1"].ToString();
                string NoticeIssued = row["NoticeIssued"].ToString();
                // change by rekha on 13-07-10 bcoz no 'MeterNo' not exists in sp
                //int MeterNo = int.Parse(row["MeterNo"].ToString());
                //list.Add(new OMCUstomerList(ApplicationId,ApplicationNo, CustomerId, CustomerName, Address, Area, Plan, NoticeIssued,MeterNo, Count));
                list.Add(new OMCUstomerList(ApplicationId, ApplicationNo, CustomerId, CustomerName, Address, Area, Plan, NoticeIssued, 0, Count));
            }
            return list;
        }

    }
}
