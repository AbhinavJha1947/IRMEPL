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
    public class CORMeterMasterDao : ICORMeterMasterDao
    {
        private readonly DbManager _dbManager;

        public CORMeterMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORMeterMasterList> GetCORMeterMasters()
        {
            string sortExpression = "METMST_MeterNo";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORMeterMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORMeterMasterList> GetCORMeterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORMeterMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'METMST_MeterNo',");
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
            int MeterCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORMeterMasterList> list = new List<CORMeterMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                long METMST_MeterNo = long.Parse(row["METMST_MeterNo"].ToString());
                string METMST_Alloted = row["METMST_Alloted"].ToString();
                string CENMST_Name = row["CENMST_Name"].ToString();
                string CONMST_Name = row["CONMST_Name"].ToString();
                string METMST_Maker = row["METMST_Maker"].ToString();
                string METMST_IssuedDateTime = row["METMST_IssuedDateTime"].ToString();
                string METMST_Remarks = row["METMST_Remarks"].ToString();
                list.Add(new CORMeterMasterList(METMST_MeterNo, METMST_Alloted, CENMST_Name, MeterCount, CONMST_Name, METMST_Maker, METMST_IssuedDateTime, METMST_Remarks));
            }
            return list;
        }

        public CORMeterMaster GetCORMeterMaster(int CORMeterMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORMeterMaster_Select " + CORMeterMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            Int64 METMST_MeterNo = Convert.ToInt64(row["METMST_MeterNo"]);
            int METMST_Alloted = Convert.ToInt32(row["METMST_Alloted"]);
            int METMST_CENCode = Convert.ToInt32(row["METMST_CENCode"]);
            int METMST_CreatedByUserID = Convert.ToInt32(row["METMST_CreatedByUserID"]);
            string METMST_CreatedDateTime = Convert.ToString(row["METMST_CreatedDateTime"]);
            int METMST_UpdatedByUserID = Convert.ToInt32(row["METMST_UpdatedByUserID"]);
            string METMST_UpdatedDateTime = Convert.ToString(row["METMST_UpdatedDateTime"]);
            int METMST_RowStatus = Convert.ToInt32(row["METMST_RowStatus"]);
            long METMST_RowVersion = long.Parse(row["METMST_RowVersion"].ToString());
            int METMST_CONMSTCode = 0;
            string METMST_Remarks = "";
            #endregion

            return new
            CORMeterMaster(METMST_MeterNo, METMST_Alloted, METMST_CENCode, METMST_CreatedByUserID, METMST_CreatedDateTime, METMST_UpdatedByUserID, METMST_UpdatedDateTime, METMST_RowStatus, METMST_RowVersion, METMST_CONMSTCode, METMST_Remarks);
        }

        public CORMeterMasterMsg InsertCORMeterMaster(CORMeterMaster CORMeterMaster, ref SqlConnection objCon, ref SqlTransaction trn, Int64 StartNo, Int64 EndNo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CorMeterGenerateMeterNo ");
            sql.Append(StartNo + ",");
            sql.Append(EndNo + ",");
            sql.Append(CORMeterMaster.METMST_Alloted + ",");
            sql.Append(CORMeterMaster.METMST_CENCode + ",");
            sql.Append(CORMeterMaster.METMST_CreatedByUserID + ",");
            sql.Append(CORMeterMaster.METMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORMeterMasterMsg(_RetVal, _RetStr);
        }

        public CORMeterMasterMsg InsertCORMeterNoMaster(CORMeterMaster CORMeterMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMeterMaster_Insert ");
            sql.Append(CORMeterMaster.METMST_MeterNo + ",");
            sql.Append(CORMeterMaster.METMST_CENCode + ",");
            sql.Append(CORMeterMaster.METMST_CreatedByUserID + ",");
            sql.Append(CORMeterMaster.METMST_RowStatus + ",");
            sql.Append(CORMeterMaster.METMST_CONMSTCode + ",'");
            sql.Append(CORMeterMaster.METMST_Remarks + "','");
            sql.Append(CORMeterMaster.METMST_Maker + "','");
            sql.Append(CORMeterMaster.METMST_IssuedDateTime + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORMeterMasterMsg(_RetVal, _RetStr);
        }

        public CORMeterMasterMsg UpdateCORMeterMaster(CORMeterMaster CORMeterMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORMeterMaster_Update ");
            sql.Append(CORMeterMaster.METMST_Alloted + ",");
            sql.Append(CORMeterMaster.METMST_CENCode + ",");
            sql.Append(CORMeterMaster.METMST_CreatedByUserID + ",");
            sql.Append("N'" + CORMeterMaster.METMST_CreatedDateTime + "',");
            sql.Append(CORMeterMaster.METMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORMeterMaster.METMST_UpdatedDateTime + "',");
            sql.Append(CORMeterMaster.METMST_RowStatus + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORMeterMasterMsg(_RetVal, _RetStr);
        }

        public CORMeterMasterMsg DeleteCORMeterMaster(Int64 CORMeterMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMeterMaster_Delete " + CORMeterMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORMeterMasterMsg(_RetVal, _RetStr);
        }
    }
}

