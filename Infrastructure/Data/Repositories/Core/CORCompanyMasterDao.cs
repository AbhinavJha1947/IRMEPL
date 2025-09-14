using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces.Core;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORCompanyMasterDao : ICORCompanyMasterDao
    {
        private readonly DbManager _dbManager;

        public CORCompanyMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<CORCompanyMasterList> GetCORCompanyMasters()
        {
            string sortExpression = "CMPMST_CompanyCode";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORCompanyMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORCompanyMasterList> GetCORCompanyMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCompanyMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CMPMST_CompanyCode',");
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
            IList<CORCompanyMasterList> list = new List<CORCompanyMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public CORCompanyMaster GetCORCompanyMaster(int CORCompanyMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCompanyMaster_Select " + CORCompanyMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            if (row != null)
            {
                #region"Variables Declaration"
                int CMPMST_CompanyCode = Convert.ToInt32(row["CMPMST_CompanyCode"]);
                string CMPMST_CompanyName = Convert.ToString(row["CMPMST_CompanyName"]);
                string CMPMST_RegAddress = Convert.ToString(row["CMPMST_RegAddress"]);
                string CMPMST_WebSite = Convert.ToString(row["CMPMST_WebSite"]);
                int CMPMST_BusinessType = Convert.ToInt32(row["CMPMST_BusinessType"]);
                string CMPMST_GSTNoDT = Convert.ToString(row["CMPMST_GSTNoDT"]);
                string CMPMST_CSTNoDT = Convert.ToString(row["CMPMST_CSTNoDT"]);
                string CMPMST_TINNoDT = Convert.ToString(row["CMPMST_TINNoDT"]);
                string CMPMST_VATNoDT = Convert.ToString(row["CMPMST_VATNoDT"]);
                string CMPMST_ExRegNo = Convert.ToString(row["CMPMST_ExRegNo"]);
                int CMPMST_CreatedByUserID = Convert.ToInt32(row["CMPMST_CreatedByUserID"]);
                string CMPMST_CreatedDateTime = Convert.ToString(row["CMPMST_CreatedDateTime"]);
                int CMPMST_UpdatedByUserID = Convert.ToInt32(row["CMPMST_UpdatedByUserID"]);
                string CMPMST_UpdatedDateTime = Convert.ToString(row["CMPMST_UpdatedDateTime"]);
                int CMPMST_RowStatus = Convert.ToInt32(row["CMPMST_RowStatus"]);
                long CMPMST_RowVersion = (long)row["CMPMST_RowVersion"];

                #endregion

                return new CORCompanyMaster(CMPMST_CompanyCode, CMPMST_CompanyName, CMPMST_RegAddress, CMPMST_WebSite, CMPMST_BusinessType, CMPMST_GSTNoDT, CMPMST_CSTNoDT, CMPMST_TINNoDT, CMPMST_VATNoDT, CMPMST_ExRegNo, CMPMST_CreatedByUserID, CMPMST_CreatedDateTime, CMPMST_UpdatedByUserID, CMPMST_UpdatedDateTime, CMPMST_RowStatus, CMPMST_RowVersion);
            }
            else
            {
                return new CORCompanyMaster();
            }

        }

        public CORCompanyMasterMsg InsertCORCompanyMaster(CORCompanyMaster CORCompanyMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCompanyMaster_Insert ");
            sql.Append("N'" + CORCompanyMaster.CMPMST_CompanyName + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_RegAddress + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_WebSite + "',");
            sql.Append(CORCompanyMaster.CMPMST_BusinessType + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_GSTNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_CSTNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_TINNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_VATNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_ExRegNo + "',");
            sql.Append(CORCompanyMaster.CMPMST_CreatedByUserID + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_CreatedDateTime + "',");
            sql.Append(CORCompanyMaster.CMPMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_UpdatedDateTime + "',");
            sql.Append(CORCompanyMaster.CMPMST_RowStatus + ",");
            sql.Append(CORCompanyMaster.CMPMST_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new CORCompanyMasterMsg(_RetVal, _RetStr);
        }

        public CORCompanyMasterMsg UpdateCORCompanyMaster(CORCompanyMaster CORCompanyMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCompanyMaster_Update ");
            sql.Append(CORCompanyMaster.CMPMST_CompanyCode + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_CompanyName + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_RegAddress + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_WebSite + "',");
            sql.Append(CORCompanyMaster.CMPMST_BusinessType + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_GSTNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_CSTNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_TINNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_VATNoDT + "',");
            sql.Append("N'" + CORCompanyMaster.CMPMST_ExRegNo + "',");
            sql.Append(CORCompanyMaster.CMPMST_CreatedByUserID + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_CreatedDateTime + "',");
            sql.Append(CORCompanyMaster.CMPMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORCompanyMaster.CMPMST_UpdatedDateTime + "',");
            sql.Append(CORCompanyMaster.CMPMST_RowStatus + ",");
            sql.Append(CORCompanyMaster.CMPMST_RowVersion + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORCompanyMasterMsg(_RetVal, _RetStr);
        }

        public CORCompanyMasterMsg DeleteCORCompanyMaster(int CORCompanyMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCompanyMaster_Delete " + CORCompanyMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORCompanyMasterMsg(_RetVal, _RetStr);
        }

    }
}