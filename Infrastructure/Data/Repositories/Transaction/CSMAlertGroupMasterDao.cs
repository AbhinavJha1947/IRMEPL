using Application.RepositoryInterfaces.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Core.Entities.Transaction;
using System.Data;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class CSMAlertGroupMasterDao : ICSMAlertGroupMasterDao
    {
        private readonly DbManager _dbManager;

        public CSMAlertGroupMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMAlertGroupMasterList> GetCSMAlertGroupMasters()
        {
            string sortExpression = "AGMMST_AlertGroupId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMAlertGroupMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CSMAlertGroupMasterList> GetCSMAlertGroupMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'AGMMST_AlertGroupId',");
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
            IList<CSMAlertGroupMasterList> list = new List<CSMAlertGroupMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int AGMMST_AlertGroupId = int.Parse(row["AGMMST_AlertGroupId"].ToString());
                string AGMMST_AlertNameId = row["AGMMST_AlertNameId"].ToString();
                string AGM_MST_CallType = row["AGMMST_CallType"].ToString();
                string AGMMST_ViaEmail = row["AGMMST_ViaEmail"].ToString();
                string AGMMST_ViaSMS = row["AGMMST_ViaSMS"].ToString();
                string AGMMST_CenterId = row["AGMMST_CenterId"].ToString();
                list.Add(new CSMAlertGroupMasterList(AGMMST_AlertGroupId, AGMMST_AlertNameId, AGM_MST_CallType, AGMMST_ViaEmail, AGMMST_ViaSMS, AGMMST_CenterId, Count));
            }
            return list;
        }

        public CSMAlertGroupMaster GetCSMAlertGroupMaster(int CSMAlertGroupMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupMaster_Select " + CSMAlertGroupMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int AGMMST_AlertGroupId = Convert.ToInt32(row["AGMMST_AlertGroupId"]);
            int AGMMST_AlertNameId = Convert.ToInt32(row["AGMMST_AlertNameId"]);
            int AGMMST_CallType = Convert.ToInt32(row["AGMMST_CallType"]);
            short AGMMST_ViaEmail = (short)int.Parse((row["AGMMST_ViaEmail"].ToString()));
            short AGMMST_ViaSMS = (short)(int.Parse((row["AGMMST_ViaSMS"]).ToString()));
            int AGMMST_CenterId = Convert.ToInt32(row["AGMMST_CenterId"]);
            int AGMMST_UserId = Convert.ToInt32(row["AGMMST_UserId"]);
            string AGMMST_DateTime = Convert.ToString(row["AGMMST_DateTime"].ToString());
            long AGMMST_RowVersion = (long)row["AGMMST_RowVersion"];

            #endregion

            return new
            CSMAlertGroupMaster(AGMMST_AlertGroupId, AGMMST_AlertNameId, AGMMST_CallType, AGMMST_ViaEmail, AGMMST_ViaSMS, AGMMST_CenterId, AGMMST_UserId, AGMMST_DateTime, AGMMST_RowVersion);
        }

        public CSMAlertGroupMasterMsg InsertCSMAlertGroupMaster(CSMAlertGroupMaster CSMAlertGroupMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupMaster_Insert ");
            sql.Append(CSMAlertGroupMaster.AGMMST_AlertNameId + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_CallType + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_ViaEmail + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_ViaSMS + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_CenterId + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_UserId + "");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CSMAlertGroupMasterMsg(_RetVal, _RetStr);
        }

        public CSMAlertGroupMasterMsg UpdateCSMAlertGroupMaster(CSMAlertGroupMaster CSMAlertGroupMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupMaster_Update ");
            sql.Append(CSMAlertGroupMaster.AGMMST_AlertGroupId + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_AlertNameId + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_CallType + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_ViaEmail + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_ViaSMS + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_CenterId + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_UserId + ",");
            sql.Append(CSMAlertGroupMaster.AGMMST_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMAlertGroupMasterMsg(_RetVal, _RetStr);
        }

        public CSMAlertGroupMasterMsg DeleteCSMAlertGroupMaster(int CSMAlertGroupMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMAlertGroupMaster_Delete " + CSMAlertGroupMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMAlertGroupMasterMsg(_RetVal, _RetStr);
        }

    }
}
