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
    public class CORContractorMasterDao : ICORContractorMasterDao
    {
        private readonly DbManager _dbManager;

        public CORContractorMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORContractorMasterList> GetCORContractorMasters()
        {
            string sortExpression = "CONMST_Code";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORContractorMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORContractorMasterList> GetCORContractorMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORContractorMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CONMST_Code',");
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
            int CONMST_Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORContractorMasterList> list = new List<CORContractorMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int CONMST_Code = int.Parse(row["CONMST_Code"].ToString());
                string CONMST_Name = row["CONMST_Name"].ToString();
                string CONMST_ContType = row["CONMST_ContType"].ToString();
                string CONMST_RowStatus = row["CONMST_RowStatus"].ToString();
                int CONMST_CenCode = int.Parse(row["CONMST_CenCode"].ToString());
                string CENMST_Name = row["CENMST_Name"].ToString();
                list.Add(new CORContractorMasterList(CONMST_Code, CONMST_Name, CONMST_ContType, CONMST_CenCode, CONMST_RowStatus, CENMST_Name, CONMST_Count));
            }
            return list;
        }

        public CORContractorMaster GetCORContractorMaster(int ContractorMasterCode)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORContractorMaster_Select " + ContractorMasterCode);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CONMST_Code = Convert.ToInt32(row["CONMST_Code"]);
            string CONMST_Name = Convert.ToString(row["CONMST_Name"]);
            int CONMST_ContType = Convert.ToInt32(row["CONMST_ContType"]);
            int CONMST_CenCode = Convert.ToInt32(row["CONMST_CenCode"]);
            int CONMST_CreatedByUserID = Convert.ToInt32(row["CONMST_CreatedByUserID"]);
            string CONMST_CreatedDateTime = Convert.ToString(row["CONMST_CreatedDateTime"]);
            int CONMST_UpdatedByUserID = Convert.ToInt32(row["CONMST_UpdatedByUserID"]);
            string CONMST_UpdatedDateTime = Convert.ToString(row["CONMST_UpdatedDateTime"]);
            int CONMST_RowStatus = Convert.ToInt32(row["CONMST_RowStatus"]);
            long CONMST_RowVersion = long.Parse(row["CONMST_RowVersion"].ToString());
            #endregion

            return new
            CORContractorMaster(CONMST_Code, CONMST_Name, CONMST_ContType, CONMST_CenCode, CONMST_CreatedByUserID, CONMST_CreatedDateTime, CONMST_UpdatedByUserID, CONMST_UpdatedDateTime, CONMST_RowStatus, CONMST_RowVersion);
        }

        public CORContractorMasterMsg InsertCORContractorMaster(CORContractorMaster CORContractorMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORContractorMaster_Insert '");
            sql.Append(CORContractorMaster.CONMST_Name + "',");
            sql.Append(CORContractorMaster.CONMST_ContType + ",");
            sql.Append(CORContractorMaster.CONMST_CenCode + ",");
            sql.Append(CORContractorMaster.CONMST_CreatedByUserID + ",");
            sql.Append(CORContractorMaster.CONMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORContractorMasterMsg(_RetVal, _RetStr);
        }

        public CORContractorMasterMsg UpdateCORContractorMaster(CORContractorMaster CORContractorMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORContractorMaster_Update ");
            sql.Append(CORContractorMaster.CONMST_Code + ",'");
            sql.Append(CORContractorMaster.CONMST_Name + "',");
            sql.Append(CORContractorMaster.CONMST_ContType + ",");
            sql.Append(CORContractorMaster.CONMST_CenCode + ",");
            sql.Append(CORContractorMaster.CONMST_UpdatedByUserID + ",");
            sql.Append(CORContractorMaster.CONMST_RowStatus + ",");
            sql.Append(CORContractorMaster.CONMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORContractorMasterMsg(_RetVal, _RetStr);
        }

        public CORContractorMasterMsg DeleteCORContractorMaster(int ContractorMasterCode, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORContractorMaster_Delete " + ContractorMasterCode);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORContractorMasterMsg(_RetVal, _RetStr);
        }

    }
}
