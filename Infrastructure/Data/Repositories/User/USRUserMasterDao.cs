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
    public class USRUserMasterDao : IUSRUserMasterDao
    {
        private readonly DbManager _dbManager;

        public USRUserMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
            /// <summary>
            /// </summary>
            /// <returns>StorageType list.</returns>
            public IList<USRUserMasterList> GetUSRUserMasters()
            {
                string sortExpression = "USRMST_UserID";
                string sortType = "ASC";
                int pageIndex = 0;
                int pageSize = -1;
                string criteria = "";
                return GetUSRUserMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
            }

            public IList<USRUserMasterforgetMsg> GetUSRUserMasters_forget()
            {
                string criteria = "";
                return GetUSRUserMasters_forget(criteria);
            }


            public IList<USRUserMasterforgetMsg> GetUSRUserMasters_forget(string criteria)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUser_Forgetpassword");
                sql.Append(criteria);
                DataSet ds = _dbManager.GetDataSet(sql.ToString());
                DataTable dtList = ds.Tables[0];
                IList<USRUserMasterforgetMsg> list = new List<USRUserMasterforgetMsg>();
                if (dtList.Rows.Count > 0 && dtList != null)
                {
                    int Count = int.Parse(dtList.Rows[0][0].ToString());
                    foreach (DataRow row in dtList.Rows)
                    {
                        int USER_ID = int.Parse(row["USER_ID"].ToString());
                        string USER_EmailID = row["USER_EmailID"].ToString();
                        string USER_Password = row["USER_Password"].ToString();
                        string USER_FirstName = row["USER_FirstName"].ToString();
                        string USER_LastName = row["USER_LastName"].ToString();
                        string USER_UserName = row["USER_LoginID"].ToString();
                        list.Add(new USRUserMasterforgetMsg(USER_EmailID, USER_Password, USER_FirstName, USER_LastName, USER_UserName));
                    }
                }
                else
                {
                    dtList = null;
                }
                return list;
            }

        public IList<USRUserMasterList> GetUSRUserMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_USRUserMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'USER_FirstName',");
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
            string safeCriteria = criteria.Replace("'", "''");
            sql.Append(safeCriteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<USRUserMasterList> list = new List<USRUserMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int USER_ID = int.Parse(row["USER_ID"].ToString());
                int USER_Type = int.Parse(row["USER_Type"].ToString());
                string strUSER_Type = row["VarUser_Type"].ToString();
                string CENMST_CenterCode = row["CENMST_CenterCode"].ToString();
                string CENMST_Name = row["CENMST_Name"].ToString();
                string USER_FirstName = row["USER_FirstName"].ToString();
                string USER_MiddleName = row["USER_MiddleName"].ToString();
                string USER_LastName = row["USER_LastName"].ToString();
                string UserName = row["UserName"].ToString();
                string USER_PhoneNo = row["USER_PhoneNo"].ToString();
                string USER_MobileNo = row["USER_MobileNo"].ToString();
                string USER_EmailID = row["USER_EmailID"].ToString();
                string USER_LoginID = row["USER_LoginID"].ToString();
                string USER_Password = row["USER_Password"].ToString();
                string USER_Status = row["USER_Status"].ToString();
                string DESI_ID = row["DESI_ID"].ToString();
                string DESI_Name = row["DESI_Name"].ToString();
                string USER_LastUpdateDate = row["USER_LastUpdateDate"].ToString();
                string CSMDESI_Name = row["CSMDESI_Name"].ToString();

                list.Add(new USRUserMasterList(USER_ID, USER_Type, strUSER_Type, CENMST_CenterCode, CENMST_Name, USER_FirstName, USER_MiddleName, USER_LastName, UserName, USER_PhoneNo, USER_MobileNo, USER_EmailID, USER_LoginID, USER_Password, USER_Status, DESI_ID, DESI_Name, USER_LastUpdateDate, CSMDESI_Name, Count));
            }
            return list;
        }

        public USRUserMaster GetUSRUserMaster(int USRUserMasterid)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserMaster_Select " + USRUserMasterid);
                DataRow row = _dbManager.GetDataRow(sql.ToString());
                #region"Variables Declaration"

                int USER_ID = Convert.ToInt32(row["USER_ID"]);
                int User_Type = Convert.ToInt32(row["User_Type"]);
                string USER_BranchID = Convert.ToString(row["USER_BranchID"]);
                string USER_PEMPCode = Convert.ToString(row["USER_PEMPCode"]);
                string USER_FirstName = Convert.ToString(row["USER_FirstName"]);
                string USER_MiddleName = Convert.ToString(row["USER_MiddleName"]);
                string USER_LastName = Convert.ToString(row["USER_LastName"]);
                string USER_EmailID = Convert.ToString(row["USER_EmailID"]);
                string USER_LoginID = Convert.ToString(row["USER_LoginID"]);
                string USER_Password = Convert.ToString(row["USER_Password"]);
                string USER_PhoneNo = Convert.ToString(row["USER_PhoneNo"]);
                string USER_MobileNo = Convert.ToString(row["USER_MobileNo"]);
                int USER_DesigID = Convert.ToInt32(row["USER_DesigID"]);
                int USER_Status = Convert.ToInt32(row["USER_Status"]);
                int USER_UpdatedByUserID = Convert.ToInt32(row["USER_UpdatedByUserID"]);
                string USER_LastUpdateDate = Convert.ToString(row["USER_LastUpdateDate"]);
                int USER_CSMDesigID = Convert.ToInt32(row["USER_CSMDesigID"]);
                long ROwVersion = long.Parse(row["ROwVersion"].ToString());

                #endregion

                return new
                USRUserMaster(USER_ID, User_Type, USER_BranchID, USER_PEMPCode, USER_FirstName, USER_MiddleName, USER_LastName, USER_EmailID, USER_LoginID, USER_Password, USER_PhoneNo, USER_MobileNo, USER_DesigID, USER_CSMDesigID, USER_Status, USER_UpdatedByUserID, USER_LastUpdateDate, ROwVersion);
            }

            public USRUserMasterMsg InsertUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserMaster_Insert ");
                sql.Append(USRUserMaster.USER_ID + ",");
                sql.Append(USRUserMaster.User_Type + ",'");
                sql.Append(USRUserMaster.USER_BranchID + "','");
                sql.Append(USRUserMaster.USER_PEMPCode + "','");
                sql.Append(USRUserMaster.USER_FirstName + "','");
                sql.Append(USRUserMaster.USER_MiddleName + "','");
                sql.Append(USRUserMaster.USER_LastName + "','");
                sql.Append(USRUserMaster.USER_EmailID + "','");
                sql.Append(USRUserMaster.USER_LoginID + "','");
                sql.Append(USRUserMaster.USER_Password + "','");
                sql.Append(USRUserMaster.USER_PhoneNo + "','");
                sql.Append(USRUserMaster.USER_MobileNo + "',");
                sql.Append(USRUserMaster.USER_Status + ",");
                sql.Append(USRUserMaster.USER_DesigID + ",");
                sql.Append(USRUserMaster.USER_CSMDesigID + ",");

                sql.Append(USRUserMaster.USER_UpdatedByUserID);
                DataRow row = _dbManager.GetDataRowWithTransaction(sql.ToString(), ref objCon, ref trn);
                #region"Variables Declaration"

                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);
                #endregion

                return new USRUserMasterMsg(_RetVal, _RetStr);
            }

            public USRUserMasterMsg UpdateUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserMaster_Update ");
                sql.Append(USRUserMaster.USER_ID + ",");
                sql.Append(USRUserMaster.User_Type + ",'");
                sql.Append(USRUserMaster.USER_BranchID + "','");
                sql.Append(USRUserMaster.USER_PEMPCode + "','");
                sql.Append(USRUserMaster.USER_FirstName + "','");
                sql.Append(USRUserMaster.USER_MiddleName + "','");
                sql.Append(USRUserMaster.USER_LastName + "','");
                sql.Append(USRUserMaster.USER_EmailID + "','");
                sql.Append(USRUserMaster.USER_LoginID + "','");
                sql.Append(USRUserMaster.USER_Password + "','");
                sql.Append(USRUserMaster.USER_PhoneNo + "','");
                sql.Append(USRUserMaster.USER_MobileNo + "',");
                sql.Append(USRUserMaster.USER_Status + ",");
                sql.Append(USRUserMaster.USER_DesigID + ",");
                sql.Append(USRUserMaster.USER_CSMDesigID + ",");
                sql.Append(USRUserMaster.USER_UpdatedByUserID + ",");
                sql.Append(USRUserMaster.ROwVersion);
                DataRow row = _dbManager.GetDataRowWithTransaction(sql.ToString(), ref objCon, ref trn);

                #region"Variables Declaration"

                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);

                #endregion

                return new USRUserMasterMsg(_RetVal, _RetStr);
            }

            public USRUserMasterMsg UpdatePasswordUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC user_USRUserMaster_UpdatePassword ");
                sql.Append(USRUserMaster.USER_ID + ",'");
                sql.Append(USRUserMaster.USER_Password + "',");
                sql.Append(USRUserMaster.USER_UpdatedByUserID);
                DataRow row = _dbManager.GetDataRowWithTransaction(sql.ToString(), ref objCon, ref trn);

                #region"Variables Declaration"

                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);

                #endregion

                return new USRUserMasterMsg(_RetVal, _RetStr);
            }

            public USRUserMasterMsg DeleteUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRUserMaster_Delete ");
                sql.Append(USRUserMaster.USER_ID);
                //return Db.Update(sql.ToString(), ref objCon, ref trn);
                DataRow row = _dbManager.GetDataRowWithTransaction(sql.ToString(), ref objCon, ref trn);
                #region"Variables Declaration"
                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);

                #endregion
                return new USRUserMasterMsg(_RetVal, _RetStr);

            }
        }
    }

