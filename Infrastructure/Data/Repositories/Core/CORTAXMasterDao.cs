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
    public class CORTAXMasterDao : ICORTAXMasterDao
    {
        private readonly DbManager _dbManager;

        public CORTAXMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORTAXMasterList> GetCORTAXMasters()
        {
            string sortExpression = "TAXMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORTAXMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORTAXMasterList> GetCORTAXMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTAXMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'TAXMST_ID',");
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
            int TaxCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORTAXMasterList> list = new List<CORTAXMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int TAXMST_ID = int.Parse(row["TAXMST_ID"].ToString());
                string TAXMST_CenCode = row["TAXMST_CenCode"].ToString();
                string TAXMST_FromDate = row["TAXMST_FromDate"].ToString();
                string TAXMST_Todate = row["TAXMST_Todate"].ToString();
                string TAXMST_ParentTaxType = row["TAXMST_ParentTaxType"].ToString();
                string TAXMST_TaxType = row["TAXMST_TaxType"].ToString();
                string TAXMST_TaxFor = row["TAXMST_TaxFor"].ToString();
                string TAXMST_Description = row["TAXMST_Description"].ToString();
                decimal TAXMST_Rate = decimal.Parse(row["TAXMST_Rate"].ToString());
                string TAXMST_ApplicableON = row["TAXMST_ApplicableON"].ToString();
                string TAXMST_RowStatus = row["TAXMST_RowStatus"].ToString();


                list.Add(new CORTAXMasterList(TAXMST_ID, TAXMST_CenCode, TAXMST_FromDate, TAXMST_Todate, TAXMST_ParentTaxType, TAXMST_TaxType, TAXMST_TaxFor, TAXMST_Description, TAXMST_Rate, TAXMST_ApplicableON, TAXMST_RowStatus, TaxCount));
            }
            return list;
        }

        public CORTAXMaster GetCORTAXMaster(int CORTAXMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORTAXMaster_Select " + CORTAXMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int TAXMST_ID = Convert.ToInt32(row["TAXMST_ID"]);
            string TAXMST_FromDate = Convert.ToString(row["TAXMST_FromDate"]);
            string TAXMST_Todate = Convert.ToString(row["TAXMST_Todate"]);
            int TAXMST_ParentTaxType = Convert.ToInt32(row["TAXMST_ParentTaxType"]);
            int TAXMST_TaxType = Convert.ToInt32(row["TAXMST_TaxType"]);
            int TAXMST_TaxFor = Convert.ToInt32(row["TAXMST_TaxFor"]);
            decimal TAXMST_Rate = Convert.ToDecimal(row["TAXMST_Rate"]);
            string TAXMST_Description = Convert.ToString(row["TAXMST_Description"]);
            int TAXMST_CenCode = Convert.ToInt32(row["TAXMST_CenCode"]);
            int TAXMST_Level = Convert.ToInt32(row["TAXMST_Level"]);
            string TAXMST_ApplicableON = row["TAXMST_ApplicableON"].ToString();
            int TAXMST_CreatedByUserID = Convert.ToInt32(row["TAXMST_CreatedByUserID"]);
            string TAXMST_CreatedDateTime = Convert.ToString(row["TAXMST_CreatedDateTime"]);
            int TAXMST_UpdatedByUserID = Convert.ToInt32(row["TAXMST_UpdatedByUserID"]);
            string TAXMST_UpdatedDateTime = Convert.ToString(row["TAXMST_UpdatedDateTime"]);
            int TAXMST_RowStatus = Convert.ToInt32(row["TAXMST_RowStatus"]);
            long TAXMST_RowVersion = long.Parse(row["TAXMST_RowVersion"].ToString());
            #endregion

            return new
            CORTAXMaster(TAXMST_ID, TAXMST_FromDate, TAXMST_Todate, TAXMST_ParentTaxType, TAXMST_TaxType, TAXMST_TaxFor, TAXMST_Rate, TAXMST_Description, TAXMST_CenCode, TAXMST_Level, TAXMST_ApplicableON, TAXMST_CreatedByUserID, TAXMST_CreatedDateTime, TAXMST_UpdatedByUserID, TAXMST_UpdatedDateTime, TAXMST_RowStatus, TAXMST_RowVersion);
        }

        public CORTAXMasterMsg InsertCORTAXMaster(CORTAXMaster CORTAXMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORTaxMaster_Insert '");
            sql.Append(CORTAXMaster.TAXMST_FromDate + "','");
            sql.Append(CORTAXMaster.TAXMST_Todate + "',");
            sql.Append(CORTAXMaster.TAXMST_ParentTaxType + ",");
            sql.Append(CORTAXMaster.TAXMST_TaxType + ",");
            sql.Append(CORTAXMaster.TAXMST_TaxFor + ",");
            sql.Append(CORTAXMaster.TAXMST_Rate + ",'");
            sql.Append(CORTAXMaster.TAXMST_Description + "',");
            sql.Append(CORTAXMaster.TAXMST_CenCode + ",");
            sql.Append(CORTAXMaster.TAXMST_Level + ",");
            sql.Append(CORTAXMaster.TAXMST_ApplicableON + ",");
            sql.Append(CORTAXMaster.TAXMST_CreatedByUserID + ",");
            sql.Append(CORTAXMaster.TAXMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORTAXMasterMsg(_RetVal, _RetStr);
        }

        public CORTAXMasterMsg UpdateCORTAXMaster(CORTAXMaster CORTAXMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORTAXMaster_Update ");
            sql.Append(CORTAXMaster.TAXMST_ID + ",'");
            sql.Append(CORTAXMaster.TAXMST_FromDate + "','");
            sql.Append(CORTAXMaster.TAXMST_Todate + "',");
            sql.Append(CORTAXMaster.TAXMST_ParentTaxType + ",");
            sql.Append(CORTAXMaster.TAXMST_TaxType + ",");
            sql.Append(CORTAXMaster.TAXMST_TaxFor + ",");
            sql.Append(CORTAXMaster.TAXMST_Rate + ",'");
            sql.Append(CORTAXMaster.TAXMST_Description + "',");
            sql.Append(CORTAXMaster.TAXMST_CenCode + ",");
            sql.Append(CORTAXMaster.TAXMST_Level + ",");
            sql.Append(CORTAXMaster.TAXMST_ApplicableON + ",");
            sql.Append(CORTAXMaster.TAXMST_UpdatedByUserID + ",");
            sql.Append(CORTAXMaster.TAXMST_RowStatus + ",");
            sql.Append(CORTAXMaster.TAXMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORTAXMasterMsg(_RetVal, _RetStr);
        }

        public CORTAXMasterMsg DeleteCORTAXMaster(int CORTAXMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTAXMaster_Delete " + CORTAXMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORTAXMasterMsg(_RetVal, _RetStr);
        }

    }
}
