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
    public class CORCityStateMasterDao : ICORCityStateMasterDao
    {
        private readonly DbManager _dbManager;

        public CORCityStateMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORCityStateMasterList> GetCORCityStateMaster()
        {
            string sortExpression = "CTSMST_Code";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORCityStateMaster(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORCityStateMasterList> GetCORCityStateMaster(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CorCityStateMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'a.CTSMST_Name',");
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
            IList<CORCityStateMasterList> list = new List<CORCityStateMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int CTSMST_Code = Convert.ToInt32(row["CTSMST_Code"]);
                string CTSMST_Name = Convert.ToString(row["CTSMST_Name"]);
                string City_Name = Convert.ToString(row["City_Name"]);
                int CTSMST_Type = Convert.ToInt32(row["CTSMST_Type"]);
                int CTSMST_ParentID = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["CTSMST_ParentID"])))
                    CTSMST_ParentID = Convert.ToInt32(row["CTSMST_ParentID"]);
                string CTSMST_RowStatus = Convert.ToString(row["CTSMST_RowStatus"]);
                int CTSMST_CreatedByUserID = Convert.ToInt32(row["CTSMST_CreatedByUserID"]);
                string CTSMST_CreatedDateTime = Convert.ToString(row["CTSMST_CreatedDateTime"]);
                decimal CTSMST_GCV = 0;
                if (!string.IsNullOrEmpty(Convert.ToString(row["CTSMST_GCV"])))
                    CTSMST_GCV = Convert.ToDecimal(row["CTSMST_GCV"]);
                string CTSMST_GACode = Convert.ToString(row["CTSMST_GACode"]);
                int CTSMST_UpdatedByUserID = 0;
                string CTSMST_UpdatedDateTime = "";
                long CTSMST_RowVersion = Convert.ToInt64(0);// (long)(row["CTSMST_RowVersion"]);
                list.Add(new CORCityStateMasterList(CTSMST_Code, CTSMST_Name, City_Name, CTSMST_Type, CTSMST_ParentID, CTSMST_CreatedByUserID, CTSMST_CreatedDateTime, CTSMST_UpdatedByUserID, CTSMST_UpdatedDateTime, CTSMST_RowStatus, CTSMST_RowVersion, Count, CTSMST_GCV, CTSMST_GACode));
            }
            return list;
        }

        public CORCityStateMaster GetCORCityStateMaster(int CORCityStateMasterId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCityStateMaster_Select " + CORCityStateMasterId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CTSMST_Code = Convert.ToInt32(row["CTSMST_Code"]);
            string CTSMST_Name = Convert.ToString(row["CTSMST_Name"]);
            int CTSMST_Type = Convert.ToInt32(row["CTSMST_Type"]);
            int CTSMST_ParentID = 0;
            if (!string.IsNullOrEmpty(Convert.ToString(row["CTSMST_ParentID"])))
                CTSMST_ParentID = Convert.ToInt32(row["CTSMST_ParentID"]);
            bool CTSMST_RowStatus = Convert.ToBoolean(row["CTSMST_RowStatus"]);
            int CTSMST_CreatedByUserID = Convert.ToInt32(row["CTSMST_CreatedByUserID"]);
            string CTSMST_CreatedDateTime = Convert.ToString(row["CTSMST_CreatedDateTime"]);
            int CTSMST_UpdatedByUserID = Convert.ToInt32(row["CTSMST_UpdatedByUserID"]);
            string CTSMST_UpdatedDateTime = Convert.ToString(row["CTSMST_UpdatedDateTime"]);
            long CTSMST_RowVersion = (long)row["CTSMST_RowVersion"];
            decimal CTSMST_GCV = 0;
            if (!string.IsNullOrEmpty(Convert.ToString(row["CTSMST_GCV"])))
                CTSMST_GCV = Convert.ToDecimal(row["CTSMST_GCV"]);
            string CTSMST_GACode = Convert.ToString(row["CTSMST_GACode"]);
            #endregion

            return new
            CORCityStateMaster(CTSMST_Code, CTSMST_Name, CTSMST_Type, CTSMST_ParentID, CTSMST_CreatedByUserID, CTSMST_CreatedDateTime, CTSMST_UpdatedByUserID, CTSMST_UpdatedDateTime, CTSMST_RowStatus, CTSMST_RowVersion, CTSMST_GCV, CTSMST_GACode);
        }

        public CORCityStateMasterMsg InsertCORCityStateMaster(CORCityStateMaster CORCityStateMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCityStateMaster_Insert ");
            sql.Append("N'" + CORCityStateMaster.CTSMST_Name + "',");
            sql.Append(CORCityStateMaster.CTSMST_Type + ",");
            if (CORCityStateMaster.CTSMST_ParentID == null)
            {
                sql.Append("null,");
            }
            else
            {
                sql.Append(CORCityStateMaster.CTSMST_ParentID + ",");
            }
            if (CORCityStateMaster.CTSMST_GCV == null)
            {
                sql.Append("null,");
            }
            else
            {
                sql.Append(CORCityStateMaster.CTSMST_GCV + ",");
            }

            sql.Append(CORCityStateMaster.CTSMST_CreatedByUserID + ",");
            //sql.Append("N'"+CORAreaMaster.AREMST_CreatedDateTime+"',");
            // sql.Append(CORCityStateMaster.CTSMST_UpdatedByUserID + ",");
            //sql.Append("N'"+CORAreaMaster.AREMST_UpdatedDateTime+"',");
            if (CORCityStateMaster.CTSMST_RowStatus == true)
            {
                sql.Append(1 + ",");
            }
            else
            {
                sql.Append(0 + ",");
            }
            if (CORCityStateMaster.CTSMST_GACode == null)
            {
                sql.Append("null");
            }
            else
            {
                sql.Append("'" + CORCityStateMaster.CTSMST_GACode + "'");
            }
            //sql.Append(CORCityStateMaster.AREMST_BillingPeriod);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORCityStateMasterMsg(_RetVal, _RetStr);
        }

        public CORCityStateMasterMsg UpdateCORCityStateMaster(CORCityStateMaster CORCityStateMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCityStateMaster_Update ");
            sql.Append(CORCityStateMaster.CTSMST_Code + ",");
            sql.Append("N'" + CORCityStateMaster.CTSMST_Name + "',");
            sql.Append(CORCityStateMaster.CTSMST_Type + ",");
            if (CORCityStateMaster.CTSMST_ParentID == null)
            {
                sql.Append("null,");
            }
            else
            {
                sql.Append(CORCityStateMaster.CTSMST_ParentID + ",");
            }
            //sql.Append(CORCityStateMaster.CTSMST_ParentID + ",");            
            sql.Append(CORCityStateMaster.CTSMST_CreatedByUserID + ",");
            sql.Append("N'" + CORCityStateMaster.CTSMST_CreatedDateTime + "',");
            sql.Append(CORCityStateMaster.CTSMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORCityStateMaster.CTSMST_UpdatedDateTime + "',");
            if (CORCityStateMaster.CTSMST_RowStatus == true)
            {
                sql.Append(1);
            }
            else
            {
                sql.Append(0);
            }
            //sql.Append(CORCityStateMaster.CTSMST_RowStatus + ",");
            sql.Append("," + CORCityStateMaster.CTSMST_RowVersion);
            if (CORCityStateMaster.CTSMST_GCV == null)
            {
                sql.Append("," + "null" + ",");
            }
            else
            {
                sql.Append("," + CORCityStateMaster.CTSMST_GCV + ",");
            }
            if (CORCityStateMaster.CTSMST_GACode == null)
            {
                sql.Append("null");
            }
            else
            {
                sql.Append("'" + CORCityStateMaster.CTSMST_GACode + "'");
            }
            //  sql.Append("," + CORCityStateMaster.CTSMST_GCV);


            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORCityStateMasterMsg(_RetVal, _RetStr);
        }

        public CORCityStateMasterMsg DeleteCORCityStateMaster(int CORCityStateMasterId, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCityStateMaster_Delete " + CORCityStateMasterId);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORCityStateMasterMsg(_RetVal, _RetStr);
        }

    }
}
