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
    public class CORSetupConfigMasterDao : ICORSetupConfigMasterDao
    {
        private readonly DbManager _dbManager;

        public CORSetupConfigMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORSetupConfigMasterList> GetCORSetupConfigMasters()
        {
            string sortExpression = "SCFMST_ConfigID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORSetupConfigMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORSetupConfigMasterList> GetCORSetupConfigMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSetupConfigMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'SCFMST_Sequence',");
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
            IList<CORSetupConfigMasterList> list = new List<CORSetupConfigMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int SCFMST_ConfigID = int.Parse(row["SCFMST_ConfigID"].ToString());
                string SCFMST_KeyText = row["SCFMST_KeyText"].ToString();
                string SCFMST_KeyValue = row["SCFMST_KeyValue"].ToString();
                string SCFMST_RowStatus = row["SCFMST_RowStatus"].ToString();
                list.Add(new CORSetupConfigMasterList(SCFMST_ConfigID, SCFMST_KeyText, SCFMST_KeyValue, SCFMST_RowStatus, Count));
            }
            return list;
        }

        public CORSetupConfigMaster GetCORSetupConfigMaster(int CORSetupConfigMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSetupConfigMaster_Select " + CORSetupConfigMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int SCFMST_ConfigID = Convert.ToInt32(row["SCFMST_ConfigID"]);
            string SCFMST_KeyText = Convert.ToString(row["SCFMST_KeyText"]);
            string SCFMST_KeyValue = row["SCFMST_KeyValue"].ToString();
            int SCFMST_CreatedByUserID = Convert.ToInt32(row["SCFMST_CreatedByUserID"]);
            string SCFMST_CreatedDateTime = Convert.ToString(row["SCFMST_CreatedDateTime"]);
            int SCFMST_UpdatedByUserID = Convert.ToInt32(row["SCFMST_UpdatedByUserID"]);
            string SCFMST_UpdatedDateTime = Convert.ToString(row["SCFMST_UpdatedDateTime"]);
            int SCFMST_RowStatus = Convert.ToInt32(row["SCFMST_RowStatus"]);
            long SCFMST_RowVersion = (long)row["SCFMST_RowVersion"];

            #endregion

            return new
            CORSetupConfigMaster(SCFMST_ConfigID, SCFMST_KeyText, SCFMST_KeyValue, SCFMST_CreatedByUserID, SCFMST_CreatedDateTime, SCFMST_UpdatedByUserID, SCFMST_UpdatedDateTime, SCFMST_RowStatus, SCFMST_RowVersion);
        }

        public CORSetupConfigMaster GetCORSetupConfigMaster(int CORSetupConfigMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSetupConfigMaster_Select " + CORSetupConfigMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int SCFMST_ConfigID = Convert.ToInt32(row["SCFMST_ConfigID"]);
            string SCFMST_KeyText = Convert.ToString(row["SCFMST_KeyText"]);
            string SCFMST_KeyValue = row["SCFMST_KeyValue"].ToString();
            int SCFMST_CreatedByUserID = Convert.ToInt32(row["SCFMST_CreatedByUserID"]);
            string SCFMST_CreatedDateTime = Convert.ToString(row["SCFMST_CreatedDateTime"]);
            int SCFMST_UpdatedByUserID = Convert.ToInt32(row["SCFMST_UpdatedByUserID"]);
            string SCFMST_UpdatedDateTime = Convert.ToString(row["SCFMST_UpdatedDateTime"]);
            int SCFMST_RowStatus = Convert.ToInt32(row["SCFMST_RowStatus"]);
            long SCFMST_RowVersion = (long)row["SCFMST_RowVersion"];

            #endregion

            return new
            CORSetupConfigMaster(SCFMST_ConfigID, SCFMST_KeyText, SCFMST_KeyValue, SCFMST_CreatedByUserID, SCFMST_CreatedDateTime, SCFMST_UpdatedByUserID, SCFMST_UpdatedDateTime, SCFMST_RowStatus, SCFMST_RowVersion);
        }

        public CORSetupConfigMasterMsg InsertCORSetupConfigMaster(CORSetupConfigMaster CORSetupConfigMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSetupConfigMaster_Insert ");
            sql.Append("N'" + CORSetupConfigMaster.SCFMST_KeyText + "',");
            sql.Append("N'" + CORSetupConfigMaster.SCFMST_KeyValue + "',");
            sql.Append(CORSetupConfigMaster.SCFMST_CreatedByUserID + ",");
            //sql.Append("N'"+CORSetupConfigMaster.SCFMST_CreatedDateTime+"',");
            sql.Append(CORSetupConfigMaster.SCFMST_UpdatedByUserID + ",");
            //sql.Append("N'"+CORSetupConfigMaster.SCFMST_UpdatedDateTime+"',");
            sql.Append(CORSetupConfigMaster.SCFMST_RowStatus + ",");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORSetupConfigMasterMsg(_RetVal, _RetStr);
        }

        public CORSetupConfigMasterMsg UpdateCORSetupConfigMaster(CORSetupConfigMaster CORSetupConfigMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSetupConfigMaster_Update ");
            sql.Append(CORSetupConfigMaster.SCFMST_ConfigID + ",");
            sql.Append("N'" + CORSetupConfigMaster.SCFMST_KeyText + "',");
            sql.Append("N'" + CORSetupConfigMaster.SCFMST_KeyValue + "',");
            sql.Append(CORSetupConfigMaster.SCFMST_UpdatedByUserID + ",");
            sql.Append(CORSetupConfigMaster.SCFMST_RowStatus + ",");
            sql.Append(CORSetupConfigMaster.SCFMST_RowVersion);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORSetupConfigMasterMsg(_RetVal, _RetStr);
        }

        public CORSetupConfigMasterMsg DeleteCORSetupConfigMaster(int CORSetupConfigMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORSetupConfigMaster_Delete " + CORSetupConfigMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORSetupConfigMasterMsg(_RetVal, _RetStr);
        }

    }
}
