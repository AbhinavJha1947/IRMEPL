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
    public class CORCorporateMasterDao : ICORCorporateMasterDao
    {
        private readonly DbManager _dbManager;

        public CORCorporateMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORCorporateMasterList> GetCORCorporateMasters()
        {
            string sortExpression = "CORMST_CorporateID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORCorporateMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORCorporateMasterList> GetCORCorporateMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORCorporateMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CORMST_CorporateID',");
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
            int CorporateCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORCorporateMasterList> list = new List<CORCorporateMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int CORMST_CorporateID = int.Parse(row["CORMST_CorporateID"].ToString());
                string CORMST_CorRefCode = row["CORMST_CorRefCode"].ToString();
                string CORMST_CorName = row["CORMST_CorName"].ToString();
                string CORMST_CorAddress = row["CORMST_CorAddress"].ToString();
                int CORMST_PlanID = int.Parse(row["CORMST_PlanID"].ToString());
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                string CenterName = row["CenterName"].ToString();
                string CORMST_RowStatus = row["CORMST_RowStatus"].ToString();
                list.Add(new CORCorporateMasterList(CORMST_CorporateID, CORMST_CorRefCode, CORMST_CorName, CORMST_CorAddress, CORMST_PlanID, PLAMST_PlanName, CenterName, CORMST_RowStatus, CorporateCount));
            }
            return list;
        }

        public CORCorporateMaster GetCORCorporateMaster(int CORCorporateMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCorporateMaster_Select " + CORCorporateMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CORMST_CorporateID = 0;
            string CORMST_CorRefCode = "";
            string CORMST_CorName = "";
            string CORMST_CorAddress = "";
            int CORMST_CenCode = 0;
            int CORMST_Planid = 0;
            int CORMST_CreatedByUserID = 0;
            string CORMST_CreatedDateTime = "";
            int CORMST_UpdatedByUserID = 0;
            string CORMST_UpdatedDateTime = "";
            int CORMST_RowStatus = 0;
            long CORMST_RowVersion = 0;
            if (row != null)
            {
                CORMST_CorporateID = Convert.ToInt32(row["CORMST_CorporateID"]);
                CORMST_CorRefCode = Convert.ToString(row["CORMST_CorRefCode"]);
                CORMST_CorName = Convert.ToString(row["CORMST_CorName"]);
                CORMST_CorAddress = Convert.ToString(row["CORMST_CorAddress"]);
                CORMST_CenCode = Convert.ToInt32(row["CORMST_CenCode"]);
                CORMST_Planid = Convert.ToInt32(row["CORMST_Planid"]);
                CORMST_CreatedByUserID = Convert.ToInt32(row["CORMST_CreatedByUserID"]);
                CORMST_CreatedDateTime = Convert.ToString(row["CORMST_CreatedDateTime"]);
                CORMST_UpdatedByUserID = Convert.ToInt32(row["CORMST_UpdatedByUserID"]);
                CORMST_UpdatedDateTime = Convert.ToString(row["CORMST_UpdatedDateTime"]);
                CORMST_RowStatus = Convert.ToInt32(row["CORMST_RowStatus"]);
                CORMST_RowVersion = (long)row["CORMST_RowVersion"];
            }


            #endregion

            return new
            CORCorporateMaster(CORMST_CorporateID, CORMST_CorRefCode, CORMST_CorName, CORMST_CorAddress, CORMST_CenCode, CORMST_Planid, CORMST_CreatedByUserID, CORMST_CreatedDateTime, CORMST_UpdatedByUserID, CORMST_UpdatedDateTime, CORMST_RowStatus, CORMST_RowVersion);
        }

        public CORCorporateMasterMsg InsertCORCorporateMaster(CORCorporateMaster CORCorporateMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORCorporateMaster_Insert '");
            sql.Append(CORCorporateMaster.CORMST_CorRefCode + "','");
            sql.Append(CORCorporateMaster.CORMST_CorName + "','");
            sql.Append(CORCorporateMaster.CORMST_CorAddress + "',");
            sql.Append(CORCorporateMaster.CORMST_CenCode + ",");
            sql.Append(CORCorporateMaster.CORMST_Planid + ",");
            sql.Append(CORCorporateMaster.CORMST_CreatedByUserID + ",");
            //sql.Append("N'"+CORCorporateMaster.CORMST_CreatedDateTime+"',");
            //sql.Append(CORCorporateMaster.CORMST_UpdatedByUserID+",");
            //sql.Append("N'"+CORCorporateMaster.CORMST_UpdatedDateTime+"',");
            sql.Append(CORCorporateMaster.CORMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORCorporateMasterMsg(_RetVal, _RetStr);
        }

        public CORCorporateMasterMsg UpdateCORCorporateMaster(CORCorporateMaster CORCorporateMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCorporateMaster_Update ");
            sql.Append(CORCorporateMaster.CORMST_CorporateID + ",'");
            sql.Append(CORCorporateMaster.CORMST_CorRefCode + "','");
            sql.Append(CORCorporateMaster.CORMST_CorName + "','");
            sql.Append(CORCorporateMaster.CORMST_CorAddress + "',");
            sql.Append(CORCorporateMaster.CORMST_CenCode + ",");
            sql.Append(CORCorporateMaster.CORMST_Planid + ",");

            sql.Append(CORCorporateMaster.CORMST_CreatedByUserID + ",");
            sql.Append(CORCorporateMaster.CORMST_UpdatedByUserID + ",'");
            sql.Append(CORCorporateMaster.CORMST_UpdatedDateTime + "',");
            sql.Append(CORCorporateMaster.CORMST_RowStatus + ",");
            sql.Append(CORCorporateMaster.CORMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORCorporateMasterMsg(_RetVal, _RetStr);
        }

        public CORCorporateMasterMsg DeleteCORCorporateMaster(int CORCorporateMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCorporateMaster_Delete " + CORCorporateMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORCorporateMasterMsg(_RetVal, _RetStr);
        }

    }
}
