using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class BILBillingCycleMasterDao : IBILBillingCycleMasterDao
    {
        private readonly DbManager _dbManager;

        public BILBillingCycleMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILBillingCycleMasterList> GetBILBillingCycleMasters()
        {
            string sortExpression = "BCCMST_BillingID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILBillingCycleMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }
        // <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<BILBillingCycleAreaMasterList> GetBILBillingCycleArea()
        {

            int criteria = 0;
            return GetBILBillingCycleArea(criteria);
        }

        public IList<BILBillingCycleAreaMasterList> GetBILBillingCycleArea(int criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USp_GetAreaforBillingCycle ");
            sql.Append(criteria);

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILBillingCycleAreaMasterList> list = new List<BILBillingCycleAreaMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                string AreaName = row["AREMST_Name"].ToString();
                int CD_ControlID = int.Parse(row["AREMST_AreaCode"].ToString());


                list.Add(new BILBillingCycleAreaMasterList(AreaName, CD_ControlID));
            }
            return list;

        }


        public IList<BILBillingCycleMasterList> GetBILBillingCycleMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingCycleMaster_SelectAll ");

            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'BCCMST_BillingID',");
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

            //String Building for Order by Column.
            // sql.Append(criteria+"'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILBillingCycleMasterList> list = new List<BILBillingCycleMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int BCCMST_BillingID = int.Parse(row["BCCMST_BillingID"].ToString());
                int CD_ControlID = int.Parse(row["CD_ControlID"].ToString());
                string CustomerType = row["CustomerType"].ToString();
                string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
                string BCCMST_StartDate = row["BCCMST_StartDate"].ToString();
                string BCCMST_EndDate = row["BCCMST_EndDate"].ToString();
                int BCCMST_CycleFor = int.Parse(row["BCCMST_CycleFor"].ToString());
                string BCCMST_BillingTime = row["BCCMST_BillingTime"].ToString();

                int BCCMST_SGraceDays = int.Parse(row["BCCMST_SGraceDays"].ToString());
                int BCCMST_EGraceDays = int.Parse(row["BCCMST_EGraceDays"].ToString());
                string BCCMST_RowStatus = row["BCCMST_RowStatus"].ToString();
                string CENMST_Name = row["CENMST_Name"].ToString();

                list.Add(new BILBillingCycleMasterList(BCCMST_BillingID, CD_ControlID, CustomerType, BCCMST_ShortName, BCCMST_StartDate, BCCMST_EndDate, BCCMST_CycleFor, BCCMST_BillingTime, BCCMST_SGraceDays, BCCMST_EGraceDays, BCCMST_RowStatus, CENMST_Name, Count));
            }
            return list;
        }

        public BILBillingCycleMaster GetBILBillingCycleMaster(int BILBillingCycleMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingCycleMaster_Select " + BILBillingCycleMasterid);


            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];

            int RetVal = 0; string RetStr = "";

            if (dtList.Rows.Count > 0 && dtRowCount.Rows.Count > 0)
            {
                DataRow row = dtList.Rows[0];
                DataRow row1 = dtRowCount.Rows[0];

                //DataRow row = _dbManager.GetDataRow(sql.ToString());
                #region"Variables Declaration"
                int BCCMST_BillingID = Convert.ToInt32(row["BCCMST_BillingID"]);
                string BCCMST_ShortName = Convert.ToString(row["BCCMST_ShortName"]);
                string BCCMST_StartDate = Convert.ToString(row["BCCMST_StartDate"]);
                int BCCMST_SGraceDays = Convert.ToInt32(row["BCCMST_SGraceDays"]);
                string BCCMST_EndDate = Convert.ToString(row["BCCMST_EndDate"]);
                int BCCMST_EGraceDays = Convert.ToInt32(row["BCCMST_EGraceDays"]);
                int BCCMST_CycleFor = Convert.ToInt32(row["BCCMST_CycleFor"]);
                int BCCMST_CENCode = Convert.ToInt32(row["BCCMST_CENCode"]);
                int BCCMST_BillingTime = Convert.ToInt32(row["BCCMST_BillingTime"]);
                int BCCMST_CreatedByUserID = Convert.ToInt32(row["BCCMST_CreatedByUserID"]);
                string BCCMST_CreatedDateTime = Convert.ToString(row["BCCMST_CreatedDateTime"]);
                int BCCMST_UpdatedByUserID = Convert.ToInt32(row["BCCMST_UpdatedByUserID"]);
                string BCCMST_UpdatedDateTime = Convert.ToString(row["BCCMST_UpdatedDateTime"]);
                int BCCMST_RowStatus = Convert.ToInt32(row["BCCMST_RowStatus"]);
                long BCCMST_RowVersion = (long)row["BCCMST_RowVersion"];

                RetVal = int.Parse(row1["RetVal"].ToString());
                RetStr = row1["RetStr"].ToString();

                return new BILBillingCycleMaster(BCCMST_BillingID, BCCMST_ShortName, BCCMST_StartDate, BCCMST_SGraceDays, BCCMST_EndDate, BCCMST_EGraceDays, BCCMST_CycleFor, BCCMST_CENCode, BCCMST_BillingTime, BCCMST_CreatedByUserID, BCCMST_CreatedDateTime, BCCMST_UpdatedByUserID, BCCMST_UpdatedDateTime, BCCMST_RowStatus, BCCMST_RowVersion, RetVal, RetStr);
            }
            else
            {
                return new BILBillingCycleMaster();
            }

            #endregion
        }

        public BILBillingCycleMasterMsg InsertBILBillingCycleMaster(BILBillingCycleMaster BILBillingCycleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingCycleMaster_Insert ");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_ShortName + "',");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_StartDate + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_SGraceDays + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_EndDate + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_EGraceDays + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_CycleFor + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_CENCode + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_BillingTime + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_CreatedByUserID + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_CreatedDateTime + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_UpdatedByUserID + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_UpdatedDateTime + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_RowStatus);//+",");
                                                               //sql.Append(BILBillingCycleMaster.BCCMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILBillingCycleMasterMsg(_RetVal, _RetStr);
        }

        public BILBillingCycleMasterMsg UpdateBILBillingCycleMaster(BILBillingCycleMaster BILBillingCycleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingCycleMaster_Update ");
            sql.Append(BILBillingCycleMaster.BCCMST_BillingID + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_ShortName + "',");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_StartDate + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_SGraceDays + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_EndDate + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_EGraceDays + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_CycleFor + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_CENCode + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_BillingTime + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_CreatedByUserID + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_CreatedDateTime + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_UpdatedByUserID + ",");
            sql.Append("N'" + BILBillingCycleMaster.BCCMST_UpdatedDateTime + "',");
            sql.Append(BILBillingCycleMaster.BCCMST_RowStatus + ",");
            sql.Append(BILBillingCycleMaster.BCCMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILBillingCycleMasterMsg(_RetVal, _RetStr);
        }

        public BILBillingCycleMasterMsg DeleteBILBillingCycleMaster(int BILBillingCycleMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILBillingCycleMaster_Delete " + BILBillingCycleMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new BILBillingCycleMasterMsg(_RetVal, _RetStr);
        }
    }
}

