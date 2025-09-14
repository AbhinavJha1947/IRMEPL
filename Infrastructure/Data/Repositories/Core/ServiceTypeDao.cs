using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class ServiceTypeDao : IServiceTypeDao
    {
        private readonly DbManager _dbManager;

        public ServiceTypeDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ServiceTypeList> GetServiceTypes()
        {
            string sortExpression = "TYPM_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = 10;
            string criteria = "";
            int TYPM_CMPMID = 0;
            return GetServiceTypes(sortExpression, sortType, pageIndex, pageSize, TYPM_CMPMID, criteria);
        }

        /// <summary>
        /// Gets a sorted list of all StorageType.
        /// </summary>
        /// <param name="sortExpression">Sort order.</param>
        /// <returns>Sorted list of StorageType.</returns>
        public IList<ServiceTypeList> GetServiceTypes(string sortExpression, string sortType, int pageIndex, int pageSize, int TYPM_CMPMID, string criteria)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORServiceTypeMaster_SelectAll ");

            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'TYPM_ID',");
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

            //String Building for Page Size
            //sql.Append(pageSize + ",");
            sql.Append(pageSize + ",");
            sql.Append(TYPM_CMPMID + ",'");
            //String Building for For Count.
            sql.Append(criteria + "'");


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int servicetypecount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<ServiceTypeList> list = new List<ServiceTypeList>();

            foreach (DataRow row in dtList.Rows)
            {
                int TYPM_ID = int.Parse(row["TYPM_ID"].ToString());
                string TYPM_Name = row["TYPM_Name"].ToString();
                string TYPM_Status = row["TYPM_Status"].ToString();

                list.Add(new ServiceTypeList(TYPM_ID, TYPM_Name, TYPM_Status, servicetypecount));
            }

            //list.Add(new ServiceType());
            return list;
        }

        public IList<ServiceTypeList> GetServiceTypes(string sortExpression, string sortType, int pageIndex, int pageSize, int TYPM_CMPMID, string criteria, ref SqlConnection cn, ref SqlTransaction trn)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORServiceTypeMaster_SelectAll ");

            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'TYPM_ID',");
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

            //String Building for Page Size
            //sql.Append(pageSize + ",");
            sql.Append(pageSize + ",");
            sql.Append(TYPM_CMPMID + ",'");
            //String Building for For Count.
            sql.Append(criteria + "'");


            DataSet ds = _dbManager.GetDataSet(sql.ToString(), ref cn, ref trn);
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int servicetypecount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<ServiceTypeList> list = new List<ServiceTypeList>();

            foreach (DataRow row in dtList.Rows)
            {
                int TYPM_ID = int.Parse(row["TYPM_ID"].ToString());
                string TYPM_Name = row["TYPM_Name"].ToString();
                string TYPM_Status = row["TYPM_Status"].ToString();

                list.Add(new ServiceTypeList(TYPM_ID, TYPM_Name, TYPM_Status, servicetypecount));
            }

            //list.Add(new ServiceType());
            return list;
        }


        /// <summary>
        /// Gets a ServiceType.
        /// </summary>
        /// <param name="branchId">Unique StorageType identifier.</param>
        /// <returns>StorageType.</returns>
        public ServiceType GetServiceType(int ServiceTypeId)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORServiceTypeMaster_Select " + ServiceTypeId);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            /// Procedure level Local Variables Declaration.
            #region "Variables Declaration"

            int _TYPM_ID = int.Parse(row["TYPM_ID"].ToString());
            int _TYPM_CMPMID = int.Parse(row["TYPM_CMPMID"].ToString());
            string _TYPM_Name = row["TYPM_Name"].ToString();
            int _TYPM_Status = Convert.ToBoolean(row["TYPM_Status"]) == true ? 1 : 0;
            int _TYPM_AUDITMID = int.Parse(row["TYPM_AUDITMID"].ToString());
            long _TYPM_RowVersion = long.Parse(row["TYPM_RowVersion"].ToString());
            #endregion

            return new ServiceType(_TYPM_ID, _TYPM_CMPMID, _TYPM_Name, _TYPM_Status, _TYPM_AUDITMID, _TYPM_RowVersion);
        }

        public ServiceType GetServiceType(int ServiceTypeId, ref SqlConnection cn, ref SqlTransaction trn)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORServiceTypeMaster_Select " + ServiceTypeId);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);

            /// Procedure level Local Variables Declaration.
            #region "Variables Declaration"

            int _TYPM_ID = int.Parse(row["TYPM_ID"].ToString());
            int _TYPM_CMPMID = int.Parse(row["TYPM_CMPMID"].ToString());
            string _TYPM_Name = row["TYPM_Name"].ToString();
            int _TYPM_Status = Convert.ToBoolean(row["TYPM_Status"]) == true ? 1 : 0;
            int _TYPM_AUDITMID = int.Parse(row["TYPM_AUDITMID"].ToString());
            long _TYPM_RowVersion = long.Parse(row["TYPM_RowVersion"].ToString());
            #endregion

            return new ServiceType(_TYPM_ID, _TYPM_CMPMID, _TYPM_Name, _TYPM_Status, _TYPM_AUDITMID, _TYPM_RowVersion);
        }


        /// <summary>
        /// Inserts a new ServiceType. 
        /// </summary>
        /// <remarks>
        /// Following insert, ServiceType object will contain new identifier.
        /// </remarks>
        /// <param name="branchmst">Branch.</param>
        public ServiceTypeMsg InsertServiceType(ServiceType servicetype, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORServiceTypeMaster_Insert ");
            //sql.Append(servicetype.TYPM_ID + ",");
            sql.Append(servicetype.TYPM_CMPMID + ",");
          //  sql.Append(_dbManager.Escape(servicetype.TYPM_Name) + ", ");
            sql.Append(servicetype.TYPM_Status + ",");
            sql.Append(servicetype.TYPM_AUDITMID);


            //Assign new branch Id back to business object

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            servicetype.TYPM_ID = _RetVal;
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ServiceTypeMsg(_RetVal, _RetStr);

            //int id = _dbManager.Insert(sql.ToString(), true);
            //servicetype.TYPM_ID = id;
        }

        /// <summary>
        /// Updates a ServiceType.
        /// </summary>
        /// <param name="branch">ServiceType.</param>
        /// <returns>Number of ServiceType records updated.</returns>
        public ServiceTypeMsg UpdateServiceType(ServiceType servicetype, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORServiceTypeMaster_UpdateAll ");
            sql.Append(servicetype.TYPM_ID + ", ");
            sql.Append(servicetype.TYPM_CMPMID + ", ");
            //sql.Append(_dbManager.Escape(servicetype.TYPM_Name) + ", ");
            sql.Append(servicetype.TYPM_Status + ", ");
            sql.Append(servicetype.TYPM_AUDITMID + ",");
            sql.Append(servicetype.TYPM_RowVersion);

            //return _dbManager.Update(sql.ToString());
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region "Variables Declaration"
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            #endregion
            return new ServiceTypeMsg(_RetVal, _RetStr);

            //return 0;
        }


        /// <summary>
        /// Deletes a servicetype
        /// </summary>
        /// <param name="branch">Branch.</param>
        /// <returns>Number of Branch records deleted.</returns>
        public int DeleteServiceType(ServiceType servicetype, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" DELETE FROM CORServiceTypeMaster  ");
            sql.Append("  WHERE TYPM_ID = " + servicetype.TYPM_ID);

            return _dbManager.Update(sql.ToString(), ref cn, ref trn);
            //return 0;
        }

    }
}
