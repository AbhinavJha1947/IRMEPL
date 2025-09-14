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
    public class CORSchemeMasterDao : ICORSchemeMasterDao
    {
        private readonly DbManager _dbManager;

        public CORSchemeMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORSchemeMasterList> GetCORSchemeMasters()
        {
            string sortExpression = "SCHMST_Code";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORSchemeMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORSchemeMasterList> GetCORSchemeMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORSchemeMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'SCHMST_Code',");
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
            int SchemeCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORSchemeMasterList> list = new List<CORSchemeMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int SCHMST_Code = int.Parse(row["SCHMST_Code"].ToString());
                String SCHMST_ApplicableOn = row["SCHMST_ApplicableOn"].ToString();
                string SCHMST_Name = row["SCHMST_Name"].ToString();
                string SCHMST_StartDate = row["SCHMST_StartDate"].ToString();
                string SCHMST_EndDate = row["SCHMST_EndDate"].ToString();
                decimal SCHMST_Amount = decimal.Parse(row["SCHMST_Amount"].ToString());
                string SCHMST_RowStatus = row["SCHMST_RowStatus"].ToString();

                list.Add(new CORSchemeMasterList(SCHMST_Code, SCHMST_ApplicableOn, SCHMST_Name, SCHMST_StartDate, SCHMST_EndDate, SCHMST_Amount, SCHMST_RowStatus, SchemeCount));
            }
            return list;
        }

        public CORSchemeMaster GetCORSchemeMaster(int CORSchemeMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORSchemeMaster_Select " + CORSchemeMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int SCHMST_Code = Convert.ToInt32(row["SCHMST_Code"]);
            int SCHMST_ApplicableOn = Convert.ToInt32(row["SCHMST_ApplicableOn"]);
            string SCHMST_Name = Convert.ToString(row["SCHMST_Name"]);
            string SCHMST_StartDate = Convert.ToString(row["SCHMST_StartDate"]);
            string SCHMST_EndDate = Convert.ToString(row["SCHMST_EndDate"]);
            decimal SCHMST_Amount = Convert.ToDecimal(row["SCHMST_Amount"]);
            int SCHMST_CreatedByUserID = Convert.ToInt32(row["SCHMST_CreatedByUserID"]);
            string SCHMST_CreatedDateTime = Convert.ToString(row["SCHMST_CreatedDateTime"]);
            int SCHMST_UpdatedByUserID = Convert.ToInt32(row["SCHMST_UpdatedByUserID"]);
            int SCHMST_Edit = Convert.ToInt32(row["SCHMST_Edit"]);
            string SCHMST_UpdatedDateTime = Convert.ToString(row["SCHMST_UpdatedDateTime"]);
            int SCHMST_RowStatus = Convert.ToInt32(row["SCHMST_RowStatus"]);
            long SCHMST_RowVersion = (long)row["SCHMST_RowVersion"];

            #endregion

            return new
            CORSchemeMaster(SCHMST_Code, SCHMST_ApplicableOn, SCHMST_Name, SCHMST_StartDate, SCHMST_EndDate, SCHMST_Amount, SCHMST_CreatedByUserID, SCHMST_CreatedDateTime, SCHMST_UpdatedByUserID, SCHMST_UpdatedDateTime, SCHMST_RowStatus, SCHMST_RowVersion, SCHMST_Edit);
        }

        public CORSchemeMasterMsg InsertCORSchemeMaster(CORSchemeMaster CORSchemeMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORSchemeMaster_Insert ");
            sql.Append(CORSchemeMaster.SCHMST_ApplicableOn + ",");
            sql.Append("'" + CORSchemeMaster.SCHMST_Name + "',");
            sql.Append("'" + CORSchemeMaster.SCHMST_StartDate + "',");
            sql.Append("'" + CORSchemeMaster.SCHMST_EndDate + "',");
            sql.Append(CORSchemeMaster.SCHMST_Amount + ",");
            sql.Append(CORSchemeMaster.SCHMST_CreatedByUserID + ",");
            sql.Append(CORSchemeMaster.SCHMST_RowStatus + "");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORSchemeMasterMsg(_RetVal, _RetStr);
        }

        public CORSchemeMasterMsg UpdateCORSchemeMaster(CORSchemeMaster CORSchemeMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORSchemeMaster_Update ");
            sql.Append(CORSchemeMaster.SCHMST_Code + ",");
            sql.Append(CORSchemeMaster.SCHMST_ApplicableOn + ",");
            sql.Append("'" + CORSchemeMaster.SCHMST_Name + "',");
            sql.Append("'" + CORSchemeMaster.SCHMST_StartDate + "',");
            sql.Append("'" + CORSchemeMaster.SCHMST_EndDate + "',");
            sql.Append(CORSchemeMaster.SCHMST_Amount + ",");
            sql.Append(CORSchemeMaster.SCHMST_UpdatedByUserID + ",");
            sql.Append(CORSchemeMaster.SCHMST_RowStatus + ",");
            sql.Append(CORSchemeMaster.SCHMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORSchemeMasterMsg(_RetVal, _RetStr);
        }

        public CORSchemeMasterMsg DeleteCORSchemeMaster(int CORSchemeMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORSchemeMaster_Delete " + CORSchemeMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORSchemeMasterMsg(_RetVal, _RetStr);
        }
    }
}

