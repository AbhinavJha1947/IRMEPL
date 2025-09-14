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
    public class USRRoleMasterDao : IUSRRoleMasterDao
    {
        private readonly DbManager _dbManager;

        public USRRoleMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
            /// <summary>
            /// </summary>
            /// <returns>StorageType list.</returns>
            public IList<USRRoleMasterList> GetUSRRoleMasters()
            {
                string sortExpression = "ROLMST_RoleID";
                string sortType = "ASC";
                int pageIndex = 0;
                int pageSize = -1;
                string criteria = "";
                return GetUSRRoleMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
            }

            public IList<USRRoleMasterList> GetUSRRoleMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleMaster_SelectAll ");
                //String Building for Order by Column.
                if (String.IsNullOrEmpty(sortExpression) == true)
                {
                    sql.Append("'ROLMST_RoleID',");
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
                IList<USRRoleMasterList> list = new List<USRRoleMasterList>();
                foreach (DataRow row in dtList.Rows)
                {
                    int ROLMST_RoleID = int.Parse(row["ROLMST_RoleID"].ToString());
                    string ROLMST_RoleName = row["ROLMST_RoleName"].ToString();
                    string ROLMST_RoleDescription = row["ROLMST_RoleDescription"].ToString();
                    string ROLMST_RowStatus = row["ROLMST_RowStatus"].ToString();

                    list.Add(new USRRoleMasterList(ROLMST_RoleID, ROLMST_RoleName, ROLMST_RoleDescription, ROLMST_RowStatus, Count));
                }
                return list;
            }

            public USRRoleMaster GetUSRRoleMaster(int USRRoleMasterid)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleMaster_Select " + USRRoleMasterid);
                DataRow row = _dbManager.GetDataRow(sql.ToString());
                #region"Variables Declaration"
                int ROLMST_RoleID = Convert.ToInt32(row["ROLMST_RoleID"]);
                string ROLMST_RoleName = Convert.ToString(row["ROLMST_RoleName"]);
                string ROLMST_RoleDescription = Convert.ToString(row["ROLMST_RoleDescription"]);
                int ROLMST_RowStatus = Convert.ToInt32(row["ROLMST_RowStatus"]);
                int ROLMST_CreatedByUserID = Convert.ToInt32(row["ROLMST_CreatedByUserID"]);
                string ROLMST_CreatedDate = Convert.ToString(row["ROLMST_CreatedDate"]);
                int ROLMST_UpdatedByUserID = Convert.ToInt32(row["ROLMST_UpdatedByUserID"]);
                string ROLMST_LastUpdateDate = Convert.ToString(row["ROLMST_LastUpdateDate"]);
                long ROLMST_RowVersion = long.Parse(row["ROLMST_RowVersion"].ToString());
                int ROLMST_AUDITMID = Convert.ToInt32(row["ROLMST_AUDITMID"]);

                #endregion

                return new
                USRRoleMaster(ROLMST_RoleID, ROLMST_RoleName, ROLMST_RoleDescription, ROLMST_RowStatus, ROLMST_CreatedByUserID, ROLMST_CreatedDate, ROLMST_UpdatedByUserID, ROLMST_LastUpdateDate, ROLMST_RowVersion, ROLMST_AUDITMID);
            }

            public USRRoleMasterMsg InsertUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleMaster_Insert '");
                sql.Append(USRRoleMaster.ROLMST_RoleName + "','");
                sql.Append(USRRoleMaster.ROLMST_RoleDescription + "',");
                sql.Append(USRRoleMaster.ROLMST_RowStatus + ",");
                sql.Append(USRRoleMaster.ROLMST_CreatedByUserID);
                DataRow row = _dbManager.GetDataRowWithTransaction(sql.ToString(), ref objCon, ref trn);
                #region"Variables Declaration"

                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);
                #endregion

                return new USRRoleMasterMsg(_RetVal, _RetStr);
            }

            public USRRoleMasterMsg UpdateUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleMaster_Update ");
                sql.Append(USRRoleMaster.ROLMST_RoleID + ",'");
                sql.Append(USRRoleMaster.ROLMST_RoleName + "','");
                sql.Append(USRRoleMaster.ROLMST_RoleDescription + "',");
                sql.Append(USRRoleMaster.ROLMST_RowStatus + ",");
                sql.Append(USRRoleMaster.ROLMST_UpdatedByUserID + ",");
                sql.Append(USRRoleMaster.ROLMST_AUDITMID);
                DataRow row = _dbManager.GetDataRowWithTransaction(sql.ToString(), ref objCon, ref trn);

                #region"Variables Declaration"

                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);

                #endregion

                return new USRRoleMasterMsg(_RetVal, _RetStr);
            }

            public int DeleteUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {


                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleMaster_Delete ");
                sql.Append(USRRoleMaster.ROLMST_RoleID);
                return _dbManager.UpdateWithTransaction(sql.ToString(), ref objCon, ref trn);

            }
        }
    }
