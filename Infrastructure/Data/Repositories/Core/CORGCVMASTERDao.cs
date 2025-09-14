using Application.RepositoryInterfaces.Core;
using BFilesCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORGCVMASTERDao : ICORGCVMASTERDao
    {
        private readonly DbManager _dbManager;

        public CORGCVMASTERDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORGCVMASTERLIST> GetCORGCVMASTERS()
        {
            string sortExpression = "GCV_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORGCVMASTERS(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORGCVMASTERLIST> GetCORGCVMASTERS(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CorGCVMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'GCV_NAME',");
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
            int GCV_Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORGCVMASTERLIST> list = new List<CORGCVMASTERLIST>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int GCV_ID = Convert.ToInt32(row["GCV_ID"]);
                string GCV_NAME = Convert.ToString(row["GCV_NAME"]);
                string GCV_STARTDATE = Convert.ToString(row["GCV_STARTDATE"]);
                string GCV_ENDDATE = Convert.ToString(row["GCV_ENDDATE"]);
                decimal GCV_PRICE = Convert.ToDecimal(row["GCV_PRICE"]);
                int GCV_CENCODE = Convert.ToInt32(row["GCV_CENCODE"]);
                string GCV_RowStatus = Convert.ToString(row["GCV_RowStatus"]);
                list.Add(new CORGCVMASTERLIST(GCV_ID, GCV_NAME, GCV_STARTDATE, GCV_ENDDATE, GCV_PRICE, GCV_CENCODE, GCV_RowStatus, GCV_Count));
            }
            return list;
        }

        public CORGCVMASTER GetCORGCVMASTER(int CORGCVId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORGCVMaster_Select " + CORGCVId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int GCV_ID = Convert.ToInt32(row["GCV_ID"]);
            string GCV_NAME = Convert.ToString(row["GCV_NAME"]);
            string GCV_STARTDATE = Convert.ToString(row["GCV_STARTDATE"]);
            string GCV_ENDDATE = Convert.ToString(row["GCV_ENDDATE"]);
            decimal GCV_PRICE = Convert.ToDecimal(row["GCV_PRICE"]);
            int GCV_CENCODE = int.Parse(row["GCV_CENCODE"].ToString());
            int GCV_CreatedByUserID = Convert.ToInt32(row["GCV_CreatedByUserID"]);
            string GCV_CreatedDateTime = Convert.ToString(row["GCV_CreatedDateTime"]);
            int GCV_UpdatedByUserID = Convert.ToInt32(row["GCV_UpdatedByUserID"]);
            string GCV_UpdatedDateTime = Convert.ToString(row["GCV_UpdatedDateTime"]);
            string GCV_RowStatus = Convert.ToString(row["GCV_RowStatus"]);
            long GCV_RowVersion = long.Parse(row["GCV_RowVersion"].ToString());
            #endregion

            return new CORGCVMASTER(GCV_ID, GCV_NAME, GCV_STARTDATE, GCV_ENDDATE, GCV_PRICE, GCV_CENCODE, GCV_CreatedByUserID, GCV_CreatedDateTime, GCV_UpdatedByUserID, GCV_UpdatedDateTime, GCV_RowStatus, GCV_RowVersion);
        }

        public CORGCVMASTERMSG InsertCORGCVMASTER(CORGCVMASTER CorGCVMASTER, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORGcvMaster_Insert '");
            sql.Append(CorGCVMASTER.GCV_NAME + "','");
            sql.Append(CorGCVMASTER.GCV_STARTDATE + "','");
            sql.Append(CorGCVMASTER.GCV_ENDDATE + "','");
            sql.Append(CorGCVMASTER.GCV_PRICE + "',");
            sql.Append(CorGCVMASTER.GCV_CENCODE + ",");
            sql.Append(CorGCVMASTER.GCV_CreatedByUserID + ",");
            sql.Append(CorGCVMASTER.GCV_RowStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion
            return new CORGCVMASTERMSG(_RetVal, _RetStr);
        }
        public CORGCVMASTERMSG UpdateCORGCVMASTER(CORGCVMASTER CorGCVMASTER, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORGcvMaster_Update ");
            sql.Append(CorGCVMASTER.GCV_ID + ",'");
            sql.Append(CorGCVMASTER.GCV_NAME + "','");
            sql.Append(CorGCVMASTER.GCV_STARTDATE + "','");
            sql.Append(CorGCVMASTER.GCV_ENDDATE + "','");
            sql.Append(CorGCVMASTER.GCV_PRICE + "','");
            sql.Append(CorGCVMASTER.GCV_CENCODE + "',");
            sql.Append(CorGCVMASTER.GCV_UpdatedByUserID + ",");
            sql.Append(CorGCVMASTER.GCV_RowStatus + ",");
            sql.Append(CorGCVMASTER.GCV_RowVersion);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion
            return new CORGCVMASTERMSG(_RetVal, _RetStr);
        }
        public CORGCVMASTERMSG DeleteCORGCVMASTER(int corGCVmasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_COR_CORGcv_Delete " + corGCVmasterId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORGCVMASTERMSG(_RetVal, _RetStr);
        }

    }
}
