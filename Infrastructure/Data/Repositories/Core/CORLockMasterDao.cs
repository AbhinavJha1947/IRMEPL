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
    public class CORLockMasterDao : ICORLockMasterDao
    {
        private readonly DbManager _dbManager;

        public CORLockMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORLOCKMASTERLIST> GetCORLOCKMASTERS()
        {
            string sortExpression = "LCK_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORLOCKMASTERS(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORLOCKMASTERLIST> GetCORLOCKMASTERS(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CorLOCKMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'LCK_ID',");
            }
            else
            {
                sql.Append("'" + sortExpression + "',");
            }
            //String Building for Sorintg Type
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append("'DESC',");
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
            int LCK_Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORLOCKMASTERLIST> list = new List<CORLOCKMASTERLIST>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                // int LCK_ID = Convert.ToInt32(row["LCK_ID"]);
                string USER_Name = Convert.ToString(row["USER_Name"]);
                //int LCK_CreatedByUserID = Convert.ToInt32(row["LCK_CreatedByUserID"]);
                DateTime LCK_DATE = Convert.ToDateTime(row["LCK_DATE"]);
                DateTime LCK_CreatedDateTime = Convert.ToDateTime(row["LCK_CreatedDateTime"]);
                list.Add(new CORLOCKMASTERLIST(USER_Name, LCK_DATE, LCK_CreatedDateTime, LCK_Count));
            }
            return list;
        }

        public CORLOCKMASTER GetCORLOCKMASTER(int LCKID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORLOCKMaster_Select " + LCKID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int LCK_ID = Convert.ToInt32(row["LCK_ID"]);
            string LCK_DATE = Convert.ToString(row["LCK_DATE"]);
            int LCK_CreatedByUserID = Convert.ToInt32(row["LCK_CreatedByUserID"]);
            string LCK_CreatedDateTime = Convert.ToString(row["LCK_CreatedDateTime"]);
            int LCK_UpdatedByUserID = Convert.ToInt32(row["LCK_UpdatedByUserID"]);
            string LCK_UpdatedDateTime = Convert.ToString(row["LCK_UpdatedDateTime"]);
            long LCK_RowVersion = long.Parse(row["LCK_RowVersion"].ToString());
            #endregion

            return new CORLOCKMASTER(LCK_ID, LCK_DATE, LCK_CreatedByUserID, LCK_CreatedDateTime, LCK_UpdatedByUserID, LCK_UpdatedDateTime, LCK_RowVersion);
        }
        public CORLOCKMASTER GetCORLOCKMASTER()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT TOP 1 LCK_ID, FORMAT(CONVERT(DATE, LCK_DATE), 'dd-MMM-yyyy') AS LCK_DATE, LCK_CreatedByUserID, LCK_CreatedDateTime, LCK_UpdatedByUserID, LCK_UpdatedDateTime, LCK_RowVersion  FROM CORLOCKMASTER ORDER BY LCK_ID DESC");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int LCK_ID = Convert.ToInt32(row["LCK_ID"]);
            string LCK_DATE = Convert.ToString(row["LCK_DATE"]);
            int LCK_CreatedByUserID = 0;// row["LCK_CreatedByUserID"] == null ? 0 : Convert.ToInt32(row["LCK_CreatedByUserID"]);
            string LCK_CreatedDateTime = "";// row["LCK_CreatedDateTime"] == null ? "" : Convert.ToString(row["LCK_CreatedDateTime"]);
            int LCK_UpdatedByUserID = 0;// row["LCK_UpdatedByUserID"] == null ? 0 : Convert.ToInt32(row["LCK_UpdatedByUserID"]);
            string LCK_UpdatedDateTime = "";// row["LCK_UpdatedDateTime"] == null ? "" : Convert.ToString(row["LCK_UpdatedDateTime"]);
            long LCK_RowVersion = 0;// long.Parse(row["LCK_RowVersion"].ToString());
            #endregion

            return new CORLOCKMASTER(LCK_ID, LCK_DATE, LCK_CreatedByUserID, LCK_CreatedDateTime, LCK_UpdatedByUserID, LCK_UpdatedDateTime, LCK_RowVersion);
        }
        public CORLOCKMASTERMSG InsertCORLOCKMASTER(CORLOCKMASTER CorLockMASTER, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORLockMaster_Insert '");
            sql.Append(CorLockMASTER.LCK_DATE + "',");
            sql.Append(CorLockMASTER.LCK_CreatedDateTime);
            sql.Append(CorLockMASTER.LCK_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion
            return new CORLOCKMASTERMSG(_RetVal, _RetStr);
        }
        public CORLOCKMASTERMSG UpdateCORLOCKMASTER(CORLOCKMASTER CorLockMASTER, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORLockMaster_Update ");
            sql.Append(CorLockMASTER.LCK_ID + ",'");
            sql.Append(CorLockMASTER.LCK_DATE + "','");
            sql.Append(CorLockMASTER.LCK_UpdatedByUserID + ",");
            sql.Append(CorLockMASTER.LCK_RowVersion);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion
            return new CORLOCKMASTERMSG(_RetVal, _RetStr);
        }
        public CORLOCKMASTERMSG DeleteCORLOCKMASTER(int corLockMasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_COR_CORLock_Delete " + corLockMasterId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORLOCKMASTERMSG(_RetVal, _RetStr);
        }

    }
}
