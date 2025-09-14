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
    public class CORApplicationCancelMasterDao : ICORApplicationCancelMasterDao
    {
        private readonly DbManager _dbManager;

        public CORApplicationCancelMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORApplicationCancelMasterList> GetCORApplicationCancelMasters()
        {
            string sortExpression = "APCMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORApplicationCancelMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORApplicationCancelMasterList> GetCORApplicationCancelMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORApplicationCancelMaster_SelectAll");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APCMST_ID',");
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
            IList<CORApplicationCancelMasterList> list = new List<CORApplicationCancelMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int APCMST_ID = int.Parse(row["APCMST_ID"].ToString());
                decimal APCMST_ApplicationID = int.Parse(row["APCMST_ApplicationID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APCMST_CancelDT = row["APCMST_CancelDT"].ToString();
                string APPMST_Name = row["APPMST_Name"].ToString();
                decimal APCMST_Charges = decimal.Parse(row["APCMST_Charges"].ToString());
                decimal APPMST_Mobile = decimal.Parse(row["APPMST_Mobile"].ToString());
                string APPMST_Phone = row["APPMST_Phone"].ToString();
                string APCMST_Reason = row["APCMST_Reason"].ToString();
                string APCMST_RequestNo = row["APCMST_RequestNo"].ToString();
                list.Add(new CORApplicationCancelMasterList(APCMST_ID, APCMST_ApplicationID, APPMST_AppNo, APCMST_CancelDT, APPMST_Name, APCMST_Charges, APPMST_Mobile, APPMST_Phone, APCMST_Reason, APCMST_RequestNo, Count));
            }
            return list;
        }

        public CORApplicationCancelMaster GetCORApplicationCancelMaster(int CORApplicationCancelMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORApplicationCancelMaster_Select " + CORApplicationCancelMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int APCMST_ID = Convert.ToInt32(row["APCMST_ID"]);
            decimal APCMST_ApplicationID = Convert.ToDecimal(row["APCMST_ApplicationID"]);
            decimal APCMST_Charges = Convert.ToDecimal(row["APCMST_Charges"]);
            int APCMST_TariffID = Convert.ToInt32(row["APCMST_TariffID"]);
            string APCMST_CancelDT = Convert.ToString(row["APCMST_CancelDT"]);
            string APCMST_Reason = Convert.ToString(row["APCMST_Reason"]);
            int APCMST_CreatedByUserID = Convert.ToInt32(row["APCMST_CreatedByUserID"]);
            string APCMST_CreatedDateTime = Convert.ToString(row["APCMST_CreatedDateTime"]);
            int APCMST_UpdatedByUserID = Convert.ToInt32(row["APCMST_UpdatedByUserID"]);
            string APCMST_UpdatedDateTime = Convert.ToString(row["APCMST_UpdatedDateTime"]);
            int APCMST_RowStatus = Convert.ToInt32(row["APCMST_RowStatus"]);
            long APCMST_RowVersion = (long)row["APCMST_RowVersion"];
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            string APPMST_Name = Convert.ToString(row["APPMST_Name"]);
            string APPMST_Phone = Convert.ToString(row["APPMST_Phone"]);
            decimal APPMST_Mobile = Convert.ToDecimal(row["APPMST_Mobile"]);
            string cusType = Convert.ToString(row["cusType"]);
            string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
            string APCMST_RequestNo = Convert.ToString(row["APCMST_RequestNo"]);
            int Editable = Convert.ToInt32(row["Editable"].ToString());
            #endregion

            return new
            CORApplicationCancelMaster(APCMST_ID, APCMST_ApplicationID, APCMST_Charges, APCMST_TariffID, APCMST_CancelDT, APCMST_Reason, APCMST_CreatedByUserID, APCMST_CreatedDateTime, APCMST_UpdatedByUserID, APCMST_UpdatedDateTime, APCMST_RowStatus, APCMST_RowVersion, APPMST_AppNo, APPMST_Name, APPMST_Phone, APPMST_Mobile, cusType, PLAMST_PlanName, APCMST_RequestNo, Editable);
        }

        public CORApplicationCancelMasterMsg InsertCORApplicationCancelMaster(CORApplicationCancelMaster CORApplicationCancelMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORApplicationCancelMaster_Insert ");
            sql.Append(CORApplicationCancelMaster.APCMST_ApplicationID + ",");
            sql.Append(CORApplicationCancelMaster.APCMST_Charges + ",");
            sql.Append(CORApplicationCancelMaster.APCMST_TariffID + ",");
            sql.Append("'" + CORApplicationCancelMaster.APCMST_CancelDT + "',");
            sql.Append("'" + CORApplicationCancelMaster.APCMST_Reason.Replace("'", "''") + "',");
            sql.Append(CORApplicationCancelMaster.APCMST_CreatedByUserID + ",");
            sql.Append(CORApplicationCancelMaster.APCMST_RowStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORApplicationCancelMasterMsg(_RetVal, _RetStr);
        }

        public CORApplicationCancelMasterMsg UpdateCORApplicationCancelMaster(CORApplicationCancelMaster CORApplicationCancelMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORApplicationCancelMaster_Update ");
            sql.Append(CORApplicationCancelMaster.APCMST_ID + ",");
            sql.Append(CORApplicationCancelMaster.APCMST_ApplicationID + ",'");
            sql.Append(CORApplicationCancelMaster.APCMST_CancelDT + "',");
            sql.Append(CORApplicationCancelMaster.APCMST_Charges + ",");
            sql.Append("'" + CORApplicationCancelMaster.APCMST_Reason.Replace("'", "''") + "',");
            sql.Append(CORApplicationCancelMaster.APCMST_UpdatedByUserID + ",");
            sql.Append(CORApplicationCancelMaster.APCMST_RowStatus + ",");
            sql.Append(CORApplicationCancelMaster.APCMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationCancelMasterMsg(_RetVal, _RetStr);
        }

        public CORApplicationCancelMasterMsg DeleteCORApplicationCancelMaster(int CORApplicationCancelMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORApplicationCancelMaster_Delete " + CORApplicationCancelMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationCancelMasterMsg(_RetVal, _RetStr);
        }

    }
}
