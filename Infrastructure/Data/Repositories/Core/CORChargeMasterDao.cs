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
    public class CORChargeMasterDao : ICORChargeMasterDao
    {
        private readonly DbManager _dbManager;

        public CORChargeMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORChargeMasterList> GetCORChargeMasters()
        {
            string sortExpression = "CHGMST_Code";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORChargeMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public CORChargeMasterMsg DeleteChargeDTLMST(int CORChargeMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CorChargeDTLMST_Delete " + CORChargeMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORChargeMasterMsg(_RetVal, _RetStr);
        }
        public IList<CorChargeDTLMSTList> GetCorChargeDTLMST(string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_CorChargeDTLMST_SelectAll ");
            //String Building for Order by Column.
            sql.Append("'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CorChargeDTLMSTList> list = new List<CorChargeDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CHDMST_ID = int.Parse(row["CHDMST_ID"].ToString());
                int CHDMST_ChargeID = int.Parse(row["CHDMST_ChargeID"].ToString());
                int CHDMST_TaxID = int.Parse(row["CHDMST_TaxID"].ToString());


                list.Add(new CorChargeDTLMSTList(CHDMST_ID, CHDMST_ChargeID, CHDMST_TaxID));
            }
            return list;

        }

        public IList<CORChargeMasterList> GetCORChargeMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORChargeMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CHGMST_Code',");
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
            IList<CORChargeMasterList> list = new List<CORChargeMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int CHGMST_Code = int.Parse(row["CHGMST_Code"].ToString());
                string CHGMST_Name = row["CHGMST_Name"].ToString();
                string CHGMST_Description = row["CHGMST_Description"].ToString();
                int CHGMST_ChargeType = int.Parse(row["CHGMST_ChargeType"].ToString());

                string CHGMST_RowStatus = row["CHGMST_RowStatus"].ToString();
                int CHGMST_ControlID = 0;
                if (int.TryParse(row["CHGMST_ControlID"].ToString(), out CHGMST_ControlID))
                    CHGMST_ControlID = int.Parse(row["CHGMST_ControlID"].ToString());
                list.Add(new CORChargeMasterList(CHGMST_Code, CHGMST_Name, CHGMST_Description, CHGMST_ChargeType, CHGMST_RowStatus, CHGMST_ControlID, Count));
            }
            return list;
        }

        public CORChargeMaster GetCORChargeMaster(int CORChargeMasterId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORChargeMaster_Select " + CORChargeMasterId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CHGMST_Code = Convert.ToInt32(row["CHGMST_Code"]);
            string CHGMST_Name = Convert.ToString(row["CHGMST_Name"]);
            string CHGMST_Description = Convert.ToString(row["CHGMST_Description"]);
            int CHGMST_ChargeType = Convert.ToInt32(row["CHGMST_ChargeType"]);
            int CHGMST_CreatedByUserID = Convert.ToInt32(row["CHGMST_CreatedByUserID"]);
            string CHGMST_CreatedDateTime = Convert.ToString(row["CHGMST_CreatedDateTime"]);
            int CHGMST_ControlID = 0;
            if (!string.IsNullOrEmpty(Convert.ToString(row["CHGMST_ControlID"])))
                CHGMST_ControlID = Convert.ToInt32(row["CHGMST_ControlID"]);

            int CHGMST_UpdatedByUserID = 0;
            string CHGMST_UpdatedDateTime = "";
            int CHGMST_RowStatus = Convert.ToInt32(row["CHGMST_RowStatus"]);

            long CHGMST_RowVersion = (long)row["CHGMST_RowVersion"];


            #endregion

            return new
            CORChargeMaster(CHGMST_Code, CHGMST_Name, CHGMST_Description, CHGMST_ChargeType, CHGMST_CreatedByUserID, CHGMST_CreatedDateTime, CHGMST_UpdatedByUserID, CHGMST_UpdatedDateTime, CHGMST_RowStatus, CHGMST_RowVersion, CHGMST_ControlID);

        }

        public CORChargeMasterMsg UpdateCORChargeMaster(CorChargeDTLMST CorChargeDTLMST, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CorChargeDTLMST_Insert ");
            sql.Append(CorChargeDTLMST.CHDMST_ChargeID + ",");
            sql.Append(CorChargeDTLMST.CHDMST_TaxID);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORChargeMasterMsg(_RetVal, _RetStr);
        }

    }
}
