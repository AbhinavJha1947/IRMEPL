using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Infrastructure.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.User
{
    public class CORPrivilegeMasterDao : ICORPrivilegeMasterDao
    {
        private readonly DbManager _dbManager;

        public CORPrivilegeMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters()
        {

            string criteria = "";
            return GetCORPrivilegeMasters(criteria);
        }

        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_USRPrivilegeMaster_SelectAll ");
            //String Building for Order by Column.
            sql.Append("'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORPrivilegeMasterList> list = new List<CORPrivilegeMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int PRVL_ID = int.Parse(row["PRVL_ID"].ToString());
                int PRVL_ROLE_ID = int.Parse(row["PRVL_ROLE_ID"].ToString());
                int PRVL_ScreenID = int.Parse(row["PRVL_ScreenID"].ToString());
                int PRVL_FunctionID = int.Parse(row["PRVL_FunctionID"].ToString());

                list.Add(new CORPrivilegeMasterList(PRVL_ID, PRVL_ROLE_ID, PRVL_ScreenID, PRVL_FunctionID));
            }
            return list;
        }
        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_USRPrivilegeMaster_SelectAll ");
            //String Building for Order by Column.
            sql.Append("'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSetWithTransaction(sql.ToString(), ref cn, ref trn);
            DataTable dtList = ds.Tables[0];
            IList<CORPrivilegeMasterList> list = new List<CORPrivilegeMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int PRVL_ID = int.Parse(row["PRVL_ID"].ToString());
                int PRVL_ROLE_ID = int.Parse(row["PRVL_ROLE_ID"].ToString());
                int PRVL_ScreenID = int.Parse(row["PRVL_ScreenID"].ToString());
                int PRVL_FunctionID = int.Parse(row["PRVL_FunctionID"].ToString());

                list.Add(new CORPrivilegeMasterList(PRVL_ID, PRVL_ROLE_ID, PRVL_ScreenID, PRVL_FunctionID));
            }
            return list;
        }

        public CORPrivilegeMaster GetCORPrivilegeMaster(int CORPrivilegeMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_USRPrivilegeMaster_Select " + CORPrivilegeMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int PRVL_ID = Convert.ToInt32(row["PRVL_ID"]);
            int PRVL_ROLE_ID = Convert.ToInt32(row["PRVL_ROLE_ID"]);
            int PRVL_ScreenID = Convert.ToInt32(row["PRVL_ScreenID"]);
            int PRVL_FunctionID = Convert.ToInt32(row["PRVL_FunctionID"]);
            int PRVL_UpdatedByUserID = Convert.ToInt32(row["PRVL_UpdatedByUserID"]);
            string PRVL_LastUpdateDate = Convert.ToString(row["PRVL_LastUpdateDate"]);
            long PRVL_RowVersion = Convert.ToInt32(row["PRVL_RowVersion"]);
            #endregion

            return new
            CORPrivilegeMaster(PRVL_ID, PRVL_ROLE_ID, PRVL_ScreenID, PRVL_FunctionID, PRVL_UpdatedByUserID, PRVL_LastUpdateDate, PRVL_RowVersion);
        }

        public void InsertCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_USRPrivilegeMaster_Insert ");
            sql.Append(CORPrivilegeMaster.PRVL_ID + ",");
            sql.Append(CORPrivilegeMaster.PRVL_ROLE_ID + ",");
            sql.Append(CORPrivilegeMaster.PRVL_ScreenID + ",");
            sql.Append(CORPrivilegeMaster.PRVL_FunctionID + ",");
            sql.Append(CORPrivilegeMaster.PRVL_UpdatedByUserID);
            _dbManager.InsertWithTransaction(sql.ToString(), ref objCon, ref trn);
        }

        //public void UpdateUSRPrivilegeMaster(USRPrivilegeMaster USRPrivilegeMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC User_USRPrivilegeMaster_Update ");
        //    sql.Append(USRPrivilegeMaster.PRVMST_ID + ",");
        //    sql.Append(USRPrivilegeMaster.PRVMST_RoleID + ",");
        //    sql.Append(USRPrivilegeMaster.PRVMST_ScreenID + ",");
        //    sql.Append(USRPrivilegeMaster.PRVMST_FUNCTHID + ",");
        //    sql.Append(USRPrivilegeMaster.PRVMST_CreatedByUserID + ",");
        //    sql.Append(USRPrivilegeMaster.PRVMST_CreatedDate + "',");
        //    sql.Append(USRPrivilegeMaster.PRVMST_UpdatedByUserID + ",");
        //    sql.Append(USRPrivilegeMaster.PRVMST_LastUpdateDate + "',");
        //    sql.Append(USRPrivilegeMaster.PRVMST_AUDITMID + ",");
        //    _dbManager.Insert(sql.ToString(), ref cn, ref trn);
        //}

        public void DeleteCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_USRPrivilegeMaster_Delete ");
            sql.Append(CORPrivilegeMaster.PRVL_ROLE_ID);
            sql.Append(",");
            sql.Append(CORPrivilegeMaster.PRVL_ScreenID);
            sql.Append(",");
            sql.Append(CORPrivilegeMaster.PRVL_FunctionID);

            _dbManager.UpdateWithTransaction(sql.ToString(), ref objCon, ref trn);
        }
        /// <summary>
        /// </summary>
        /// <returns>StorageType list.</returns>
        public IList<USRFunctionalityRights> GetFunctionalityRights()
        {
            int userid = 0;
            string FormName = "";
            return GetFunctionalityRights(userid, FormName);
        }

        public IList<USRFunctionalityRights> GetFunctionalityRights(int userid, string FormName)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_USRPrivilegeMaster_GetPriviledge ");
            sql.Append(userid + ",'");
            sql.Append(FormName + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<USRFunctionalityRights> list = new List<USRFunctionalityRights>();
            foreach (DataRow row in dtList.Rows)
            {
                int FunctionID = int.Parse(row["FunctionID"].ToString());
                string FunctionName = row["FunctionName"].ToString();
                list.Add(new USRFunctionalityRights(FunctionID, FunctionName));
            }
            return list;
        }

    }
}
    
