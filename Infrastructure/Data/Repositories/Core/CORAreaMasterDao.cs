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
    public class CORAreaMasterDao : ICORAreaMasterDao
    {
        private readonly DbManager _dbManager;

        public CORAreaMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORAreaMasterList> GetCORAreaMasters()
        {
            string sortExpression = "AREMST_AreaCode";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORAreaMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORAreaMasterList> GetCORAreaMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAreaMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'AREMST_AreaCode',");
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
            IList<CORAreaMasterList> list = new List<CORAreaMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int AREMST_AreaCode = int.Parse(row["AREMST_AreaCode"].ToString());
                string AREMST_Name = row["AREMST_Name"].ToString();
                string StateName = row["StateName"].ToString();
                string CityName = row["CityName"].ToString();
                string AREMST_CENCode = row["AREMST_CENCode"].ToString();
                int AREMST_CityCode = Convert.ToInt32(row["AREMST_CityCode"].ToString());
                int AREMST_StateCode = Convert.ToInt32(row["AREMST_StateCode"].ToString());
                string AREMST_BillingPeriod = row["AREMST_BillingPeriod"].ToString();
                string AREMST_RowStatus = row["AREMST_RowStatus"].ToString();
                string GACode = row["GACode"].ToString();
                list.Add(new CORAreaMasterList(AREMST_AreaCode, AREMST_Name, StateName, CityName, AREMST_CENCode, AREMST_CityCode, AREMST_StateCode, AREMST_BillingPeriod, AREMST_RowStatus, GACode, Count));
            }
            return list;
        }

        public CORAreaMaster GetCORAreaMaster(int CORAreaMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAreaMaster_Select " + CORAreaMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int AREMST_AreaCode = Convert.ToInt32(row["AREMST_AreaCode"]);
            string AREMST_Name = Convert.ToString(row["AREMST_Name"]);
            int AREMST_CENCode = Convert.ToInt32(row["AREMST_CENCode"]);
            int AREMST_CityCode = Convert.ToInt32(row["AREMST_CityCode"].ToString());
            int AREMST_StateCode = Convert.ToInt32(row["AREMST_StateCode"].ToString());

            int AREMST_CreatedByUserID = Convert.ToInt32(row["AREMST_CreatedByUserID"]);
            string AREMST_CreatedDateTime = Convert.ToString(row["AREMST_CreatedDateTime"]);
            int AREMST_UpdatedByUserID = Convert.ToInt32(row["AREMST_UpdatedByUserID"]);
            string AREMST_UpdatedDateTime = Convert.ToString(row["AREMST_UpdatedDateTime"]);
            int AREMST_RowStatus = Convert.ToInt32(row["AREMST_RowStatus"]);
            long AREMST_RowVersion = (long)row["AREMST_RowVersion"];
            int AREMST_BillingPeriod = (int)row["AREMST_BillingPeriod"];

            #endregion

            return new
            CORAreaMaster(AREMST_AreaCode, AREMST_Name, AREMST_CENCode, AREMST_CityCode, AREMST_StateCode, AREMST_CreatedByUserID, AREMST_CreatedDateTime, AREMST_UpdatedByUserID, AREMST_UpdatedDateTime, AREMST_RowStatus, AREMST_RowVersion, AREMST_BillingPeriod);
        }




        public FetchCenterNameForLoggedinUser GetCenterNameForLoggedinUser(int Userid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_FetchCenterName_ForArea " + Userid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int USER_ID = Convert.ToInt32(row["USER_ID"]);
            string USER_LOGINID = Convert.ToString(row["USER_LOGINID"]);
            int USER_BRANCHID = Convert.ToInt32(row["USER_BRANCHID"]);
            string CENMST_NAME = Convert.ToString(row["CENMST_NAME"]);

            #endregion

            return new
            FetchCenterNameForLoggedinUser(USER_ID, USER_LOGINID, USER_BRANCHID, CENMST_NAME);
        }
        public CORAreaMasterMsg InsertCORAreaMaster(CORAreaMaster CORAreaMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAreaMaster_Insert ");
            sql.Append("N'" + CORAreaMaster.AREMST_Name + "',");
            sql.Append(CORAreaMaster.AREMST_CENCode + ",");
            sql.Append(CORAreaMaster.AREMST_CityCode + ",");
            sql.Append(CORAreaMaster.AREMST_StateCode + ",");
            sql.Append(CORAreaMaster.AREMST_CreatedByUserID + ",");
            //sql.Append("N'"+CORAreaMaster.AREMST_CreatedDateTime+"',");
            sql.Append(CORAreaMaster.AREMST_UpdatedByUserID + ",");
            //sql.Append("N'"+CORAreaMaster.AREMST_UpdatedDateTime+"',");
            sql.Append(CORAreaMaster.AREMST_RowStatus + ",");
            sql.Append(CORAreaMaster.AREMST_BillingPeriod);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORAreaMasterMsg(_RetVal, _RetStr);
        }

        public CORAreaMasterMsg UpdateCORAreaMaster(CORAreaMaster CORAreaMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAreaMaster_Update ");
            sql.Append(CORAreaMaster.AREMST_AreaCode + ",");
            sql.Append("N'" + CORAreaMaster.AREMST_Name + "',");
            sql.Append(CORAreaMaster.AREMST_CENCode + ",");
            sql.Append(CORAreaMaster.AREMST_CityCode + ",");
            sql.Append(CORAreaMaster.AREMST_StateCode + ",");
            sql.Append(CORAreaMaster.AREMST_CreatedByUserID + ",");
            sql.Append("N'" + CORAreaMaster.AREMST_CreatedDateTime + "',");
            sql.Append(CORAreaMaster.AREMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORAreaMaster.AREMST_UpdatedDateTime + "',");
            sql.Append(CORAreaMaster.AREMST_RowStatus + ",");
            sql.Append(CORAreaMaster.AREMST_RowVersion + ",");
            sql.Append(CORAreaMaster.AREMST_BillingPeriod);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORAreaMasterMsg(_RetVal, _RetStr);
        }

        public CORAreaMasterMsg DeleteCORAreaMaster(int CORAreaMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAreaMaster_Delete " + CORAreaMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORAreaMasterMsg(_RetVal, _RetStr);
        }

    }
}
