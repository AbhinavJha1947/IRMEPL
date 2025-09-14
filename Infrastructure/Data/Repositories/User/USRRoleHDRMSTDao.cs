using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.User
{
    public class USRRoleHDRMSTDao : IUSRRoleHDRMSTDao
    {
        private readonly DbManager _dbManager;

        public USRRoleHDRMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }


            /// <summary>
            /// Gets a list of all OtherCharges.
            /// </summary>
            /// <returns>Other Charges list.</returns>
            public IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs()
            {
                string sortExpression = "ROLH_ID";
                string sortType = "ASC";
                int pageIndex = 0;
                int pageSize = 10;
                string criteria = "";
                return GetUSRRoleHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
            }

            /// <summary>
            /// Gets a sorted list of all branches.
            /// </summary>
            /// <param name="sortExpression">Sort order.</param>
            /// <returns>Sorted list of Branches.</returns>
            public IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("USP_USRRoleHDRMST_SelectAll ");

                //String Building for Order by Column.
                if (String.IsNullOrEmpty(sortExpression) == true)
                {
                    sql.Append("'ROLH_ID',");
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

                //String Building for Page Size
                //sql.Append(pageSize + ",");
                sql.Append(pageSize + ",'");

                //String Building for For Count.
                sql.Append(criteria + "'");

                DataSet ds = _dbManager.GetDataSet(sql.ToString());
                DataTable dtList = ds.Tables[0];
                DataTable dtRowCount = ds.Tables[1];
                int rolecount = int.Parse(dtRowCount.Rows[0][0].ToString());

                IList<USRRoleHDRMSTList> list = new List<USRRoleHDRMSTList>();
                foreach (DataRow row in dtList.Rows)
                {

                    int ROLH_ID = int.Parse(row["ROLH_ID"].ToString());
                    string ROLH_Name = row["ROLH_Name"].ToString();
                    string ROLH_Status = row["ROLH_Status"].ToString();

                    list.Add(new USRRoleHDRMSTList(ROLH_ID, ROLH_Name, ROLH_Status, rolecount));
                }
                //list.Add(new BranchMst());
                return list;
            }

            /// <summary>
            /// Gets a basetest.
            /// </summary>
            /// <param name="branchId">Unique base test identifier.</param>
            /// <returns>Customer.</returns>

            /// <summary>
            /// Gets a basetest.
            /// </summary>
            /// <param name="branchId">Unique base test identifier.</param>
            /// <returns>Customer.</returns>
            public USRRoleHDRMST GetUSRRoleHDRMST(int USRRoleHDRMSTId)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("USP_USRRoleHDRMST_Select " + USRRoleHDRMSTId);

                DataRow row = _dbManager.GetDataRow(sql.ToString());

                /// procedure level local variables declaration.
                //#region "variables declaration"            
                int _ROLH_CMPMID = int.Parse(row["ROLH_CMPMID"].ToString());
                int _ROLH_ID = int.Parse(row["ROLH_ID"].ToString());
                string _ROLH_Name = row["ROLH_Name"].ToString();
                int _ROLH_Status = Convert.ToBoolean(row["ROLH_Status"]) == true ? 1 : 0;
                int _ROLH_UpdatedByUserID = int.Parse(row["ROLH_UpdatedByUserID"].ToString());
                string _ROLH_LastUpdateDate = row["ROLH_LastUpdateDate"].ToString();
                long ROLH_RowVersion = (long)row["ROLH_RowVersion"];


                //#endregion

                return new USRRoleHDRMST(_ROLH_CMPMID, _ROLH_ID, _ROLH_Name, _ROLH_Status, _ROLH_UpdatedByUserID, _ROLH_LastUpdateDate, ROLH_RowVersion);
            }


            /// <summary>
            /// Inserts a new Other Charges. 
            /// </summary>
            /// <remarks>
            /// Following insert,Other Charges object will contain new identifier.
            /// </remarks>
            /// <param name="CustomerSegment">Other Charges.</param>
            public USRRoleHDRMSTMsg InsertUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleHDRMST_Insert ");
                sql.Append(usrrolehdrmst.ROLH_CMPMID + ",");
                sql.Append(usrrolehdrmst.ROLH_ID + ",");
                sql.Append(DbManager.Escape(usrrolehdrmst.ROLH_Name) + ",");
                sql.Append(usrrolehdrmst.ROLH_Status + ",");
                sql.Append(usrrolehdrmst.ROLH_UpdatedByUserID);

                DataRow row = _dbManager.GetDataRow(sql.ToString());
                #region "Variables Declaration"
                int _RetVal = int.Parse(row["RetVal"].ToString());
                usrrolehdrmst.ROLH_ID = _RetVal;
                string _RetStr = row["RetStr"].ToString();
                #endregion
                return new USRRoleHDRMSTMsg(_RetVal, _RetStr);

            }

            /// <summary>
            /// Updates a Base test.
            /// </summary>
            /// <param name="branch">Othercharges.</param>
            /// <returns>Number of OtherCharges records updated.</returns>
            public USRRoleHDRMSTMsg UpdateUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleHDRMST_Update ");
                sql.Append(usrrolehdrmst.ROLH_ID + ",");
                sql.Append(DbManager.Escape(usrrolehdrmst.ROLH_Name) + ",");
                sql.Append(usrrolehdrmst.ROLH_Status + ",");
                sql.Append(usrrolehdrmst.ROLH_UpdatedByUserID + ",");
                sql.Append(usrrolehdrmst.ROLH_RowVersion);


                DataRow row = _dbManager.GetDataRow(sql.ToString());
                //#region "Variables Declaration"
                int _RetVal = int.Parse(row["RetVal"].ToString());
                string _RetStr = row["RetStr"].ToString();
                //#endregion
                return new USRRoleHDRMSTMsg(_RetVal, _RetStr);
            }

            /// <summary>
            /// Deletes a Base test
            /// </summary>
            /// <param name="branch">Branch.</param>
            /// <returns>Number of Branch records deleted.</returns>
            public USRRoleHDRMSTMsg DeleteUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC User_USRRoleHDRMST_Delete ");
                sql.Append(usrrolehdrmst.ROLH_ID);
                //return Db.Update(sql.ToString());

                DataRow row = _dbManager.GetDataRow(sql.ToString());
                int _RetVal = int.Parse(row["RetVal"].ToString());
                string _RetStr = row["RetStr"].ToString();
                return new USRRoleHDRMSTMsg(_RetVal, _RetStr);
            }

            //#region IUSRRoleHDRMSTDao Members


            //public USRRoleHDRMST GetUSRRoleHDRMST(int USRRoleHDRMSTId)
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //#endregion

            //#region IUSRRoleHDRMSTDao Members

            //IList<USRRoleHDRMSTList> IUSRRoleHDRMSTDao.GetUSRRoleHDRMSTs()
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //IList<USRRoleHDRMSTList> IUSRRoleHDRMSTDao.GetUSRRoleHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //USRRoleHDRMST IUSRRoleHDRMSTDao.GetUSRRoleHDRMST(int USRRoleHDRMSTId)
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //USRRoleHDRMSTMsg IUSRRoleHDRMSTDao.InsertUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //USRRoleHDRMSTMsg IUSRRoleHDRMSTDao.UpdateUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //USRRoleHDRMSTMsg IUSRRoleHDRMSTDao.DeleteUSRRoleHDRMST(int USRRoleHDRMSTId)
            //{
            //    throw new Exception("The method or operation is not implemented.");
            //}

            //#endregion
        
    }
}

