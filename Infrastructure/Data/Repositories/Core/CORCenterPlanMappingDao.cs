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
    public class CORCenterPlanMappingDao : ICORCenterPlanMappingDao
    {
        private readonly DbManager _dbManager;

        public CORCenterPlanMappingDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public CORPlanHDRMSTMsg InsertCORCenterPlanMapping(CORCenterPlanMapping CORCenterPlanMapping, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCenterPlanMapping_Insert ");
            sql.Append(CORCenterPlanMapping.CPM_CenterCode + ",");
            sql.Append(CORCenterPlanMapping.CPM_PlanCode + ",");
            sql.Append(CORCenterPlanMapping.CPM_CreatedByUserID);
            sql.Append(CORCenterPlanMapping.CPM_UpdatedByUserID + ",");
            sql.Append(CORCenterPlanMapping.CPM_RowStatus + ",");
            sql.Append(CORCenterPlanMapping.CPM_RowVersion);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }

        public IList<CORCenterPlanMappingList> GetCORCenterPlanMappings()
        {
            string sortExpression = "CENMST_CenterCode";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORCenterPlanMappings(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORCenterPlanMappingList> GetCORCenterPlanMappings(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORCenterPlanMapping_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CPM_CenterCode',");
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
            int count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORCenterPlanMappingList> list = new List<CORCenterPlanMappingList>();
            foreach (DataRow row in dtList.Rows)
            {

                int CPM_ID = int.Parse(row["CPM_ID"].ToString());
                int CPM_CenterCode = int.Parse(row["CPM_CenterCode"].ToString());
                int CPM_PlanCode = int.Parse(row["CPM_PlanCode"].ToString());
                string CENMST_Name = row["CENMST_Name"].ToString();
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                int CPM_RowStatus = int.Parse(row["CPM_RowStatus"].ToString());

                list.Add(new CORCenterPlanMappingList(CPM_ID, CPM_CenterCode, CPM_PlanCode, CENMST_Name, PLAMST_PlanName, CPM_RowStatus, count));
            }
            return list;
        }

        public CORPlanHDRMSTMsg DeleteCORCenterPlanMapping(int CPMID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORCenterPlanMapping_Delete " + CPMID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }
    }
}

