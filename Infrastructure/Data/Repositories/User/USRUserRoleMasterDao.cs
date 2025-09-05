using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.User
{
    public class USRUserRoleMasterDao : IUSRUserRoleMasterDao
    {
            /// <summary>
            /// </summary>
            /// <returns>StorageType list.</returns>
            public IList<USRUserRoleMasterList> GetUSRUserRoleMasters()
            {
                string sortExpression = "USRROL_ID";
                string sortType = "ASC";
                int pageIndex = 0;
                int pageSize = -1;
                string criteria = "";
                return GetUSRUserRoleMasters(criteria);
            }

            public IList<USRUserRoleMasterList> GetUSRUserRoleMasters(string criteria)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserRoleMaster_SelectAll ");
                sql.Append("'");
                sql.Append(criteria + "'");
                DataSet ds = Infrastructure.Data.DbManager.GetDataSet(sql.ToString());
                DataTable dtList = ds.Tables[0];
                IList<USRUserRoleMasterList> list = new List<USRUserRoleMasterList>();
                foreach (DataRow row in dtList.Rows)
                {
                    //int ROLH_ID = Convert.ToInt32(row["ROLH_ID"]);
                    //string ROLH_Name = row["ROLH_Name"].ToString();
                    //string ROLH_Status = row["ROLH_Status"].ToString();

                    //list.Add(new USRUserRoleMasterList(ROLH_ID, ROLH_Name, ROLH_Status));
                    int USRROL_ID = Convert.ToInt32(row["USRROL_ID"]);
                    int USRROL_UserID = Convert.ToInt32(row["USRROL_UserID"]);
                    int USRROL_RoleID = Convert.ToInt32(row["USRROL_RoleID"]);

                    list.Add(new USRUserRoleMasterList(USRROL_ID, USRROL_UserID, USRROL_RoleID));
                }
                return list;
            }

            public USRUserRoleMaster GetUSRUserRoleMaster(int USRUserRoleMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserRoleMaster_Select " + USRUserRoleMasterid);
                DataRow row = DbManager.GetDataRow(sql.ToString());
                #region"Variables Declaration"
                int USRROL_ID = Convert.ToInt32(row["USRROL_ID"]);
                int USRROL_UserID = Convert.ToInt32(row["USRROL_UserID"]);
                int USRROL_RoleID = Convert.ToInt32(row["USRROL_RoleID"]);
                int USRROL_CreatedByUserID = Convert.ToInt32(row["USRROL_CreatedByUserID"]);
                string USRROL_CreatedDate = Convert.ToString(row["USRROL_CreatedDate"]);
                int USRROL_UpdatedByUserID = Convert.ToInt32(row["USRROL_UpdatedByUserID"]);
                string USRROL_LastUpdateDate = Convert.ToString(row["USRROL_LastUpdateDate"]);
                long USRROL_RowVersion = long.Parse(row["USRROL_RowVersion"].ToString());
                int USRROL_AUDITMID = Convert.ToInt32(row["USRROL_AUDITMID"]);

                #endregion

                return new
                USRUserRoleMaster(USRROL_ID, USRROL_UserID, USRROL_RoleID, USRROL_CreatedByUserID, USRROL_CreatedDate, USRROL_UpdatedByUserID, USRROL_LastUpdateDate, USRROL_RowVersion, USRROL_AUDITMID);
            }

            public void InsertUSRUserRoleMaster(USRUserRoleMaster USRUserRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserRoleMaster_Insert ");
                sql.Append(USRUserRoleMaster.USRROL_UserID + ",");
                sql.Append(USRUserRoleMaster.USRROL_RoleID + ",");
                sql.Append(USRUserRoleMaster.USRROL_CreatedByUserID + ",");
                sql.Append(USRUserRoleMaster.USRROL_AUDITMID);
            DbManager.Insert(sql.ToString(), ref objCon, ref trn);

            }

            public void UpdateUSRUserRoleMaster(USRUserRoleMaster USRUserRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserRoleMaster_Update ");
                sql.Append(USRUserRoleMaster.USRROL_ID + ",");
                sql.Append(USRUserRoleMaster.USRROL_UserID + ",");
                sql.Append(USRUserRoleMaster.USRROL_RoleID + ",");
                sql.Append(USRUserRoleMaster.USRROL_UpdatedByUserID + ",");
                sql.Append(USRUserRoleMaster.USRROL_AUDITMID);
               DbManager.Update(sql.ToString(), ref objCon, ref trn);

            }

            public void DeleteUSRUserRoleMaster(int USRUserRoleMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
            {


                StringBuilder sql = new StringBuilder();

                sql.Append("EXEC User_USRUserRoleMaster_Delete ");
                sql.Append(USRUserRoleMasterID.ToString());

            DbManager.Update(sql.ToString(), ref objCon, ref trn);
            }
        
    }
}
