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
    public class CORFormSellingMasterDao : ICORFormSellingMasterDao
    {
        private readonly DbManager _dbManager;

        public CORFormSellingMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORFormSellingMasterList> GetCORFormSellingMasters()
        {
            string sortExpression = "FSMMST_Code";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORFormSellingMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORFormSellingMasterList> GetCORFormSellingMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORFormSellingMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'FSMMST_Code',");
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
            int FormCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORFormSellingMasterList> list = new List<CORFormSellingMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int FSMMST_Code = int.Parse(row["FSMMST_Code"].ToString());
                int FSMMST_FromNo = int.Parse(row["FSMMST_FromNo"].ToString());
                int FSMMST_ToNo = int.Parse(row["FSMMST_ToNo"].ToString());
                string CENMST_Name = row["CENMST_Name"].ToString();
                string FSMMST_IssuedDate = row["FSMMST_IssuedDate"].ToString();
                list.Add(new CORFormSellingMasterList(FSMMST_Code, FSMMST_FromNo, FSMMST_ToNo, CENMST_Name, FSMMST_IssuedDate, FormCount));
            }
            return list;
        }

        public CORFormSellingMaster GetCORFormSellingMaster(int CORFormSellingMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORFormSellingMaster_Select " + CORFormSellingMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int FSMMST_Code = Convert.ToInt32(row["FSMMST_Code"]);
            int FSMMST_FromNo = Convert.ToInt32(row["FSMMST_FromNo"]);
            int FSMMST_ToNo = Convert.ToInt32(row["FSMMST_ToNo"]);
            int FSMMST_IssuedToCenter = Convert.ToInt32(row["FSMMST_IssuedToCenter"]);
            string FSMMST_IssuedDate = Convert.ToString(row["FSMMST_IssuedDate"]);
            int FSMMST_CreatedByUserID = Convert.ToInt32(row["FSMMST_CreatedByUserID"]);
            string FSMMST_CreatedDateTime = Convert.ToString(row["FSMMST_CreatedDateTime"]);
            int FSMMST_UpdatedByUserID = Convert.ToInt32(row["FSMMST_UpdatedByUserID"]);
            string FSMMST_UpdatedDateTime = Convert.ToString(row["FSMMST_UpdatedDateTime"]);
            int FSMMST_RowStatus = Convert.ToInt32(row["FSMMST_RowStatus"]);
            long FSMMST_RowVersion = (long)row["FSMMST_RowVersion"];

            #endregion

            return new
            CORFormSellingMaster(FSMMST_Code, FSMMST_FromNo, FSMMST_ToNo, FSMMST_IssuedToCenter, FSMMST_IssuedDate, FSMMST_CreatedByUserID, FSMMST_CreatedDateTime, FSMMST_UpdatedByUserID, FSMMST_UpdatedDateTime, FSMMST_RowStatus, FSMMST_RowVersion);
        }

        public CORFormSellingMasterMsg InsertCORFormSellingMaster(CORFormSellingMaster CORFormSellingMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORFormSellingMaster_Insert ");
            sql.Append(CORFormSellingMaster.FSMMST_FromNo + ",");
            sql.Append(CORFormSellingMaster.FSMMST_ToNo + ",");
            sql.Append(CORFormSellingMaster.FSMMST_IssuedToCenter + ",'");
            sql.Append(CORFormSellingMaster.FSMMST_IssuedDate + "',");
            sql.Append(CORFormSellingMaster.FSMMST_CreatedByUserID + ",");
            sql.Append(CORFormSellingMaster.FSMMST_RowStatus + "");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORFormSellingMasterMsg(_RetVal, _RetStr);
        }

        public CORFormSellingMasterMsg UpdateCORFormSellingMaster(CORFormSellingMaster CORFormSellingMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORFormSellingMaster_Update ");
            sql.Append(CORFormSellingMaster.FSMMST_Code + ",");
            sql.Append(CORFormSellingMaster.FSMMST_FromNo + ",");
            sql.Append(CORFormSellingMaster.FSMMST_ToNo + ",");
            sql.Append(CORFormSellingMaster.FSMMST_IssuedToCenter + ",");
            sql.Append("'" + CORFormSellingMaster.FSMMST_IssuedDate + "',");
            sql.Append(CORFormSellingMaster.FSMMST_UpdatedByUserID + ",");
            sql.Append(CORFormSellingMaster.FSMMST_RowStatus + ",");
            sql.Append(CORFormSellingMaster.FSMMST_RowVersion + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORFormSellingMasterMsg(_RetVal, _RetStr);
        }

        public CORFormSellingMasterMsg DeleteCORFormSellingMaster(int CORFormSellingMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORFormSellingMaster_Delete " + CORFormSellingMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORFormSellingMasterMsg(_RetVal, _RetStr);
        }

        public CORFormSellingMasterMsg InsertCORFormSellingMaster_ForCSVUpload(CORFormSellingMaster CORFormSellingMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [usp_CORFormSellingMaster_Insert_ForCSVUpload] ");
            sql.Append(CORFormSellingMaster.FSMMST_FromNo + ",");
            sql.Append(CORFormSellingMaster.FSMMST_ToNo + ",");
            sql.Append(CORFormSellingMaster.FSMMST_IssuedToCenter + ",'");
            sql.Append(CORFormSellingMaster.FSMMST_IssuedDate + "',");
            sql.Append(CORFormSellingMaster.FSMMST_CreatedByUserID + ",");
            sql.Append(CORFormSellingMaster.FSMMST_RowStatus + "");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORFormSellingMasterMsg(_RetVal, _RetStr);
        }

    }
}
