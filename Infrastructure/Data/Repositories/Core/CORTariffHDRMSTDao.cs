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
    public class CORTariffHDRMSTDao : ICORTariffHDRMSTDao
    {
        private readonly DbManager _dbManager;

        public CORTariffHDRMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORTariffHDRMSTList> GetCORTariffHDRMSTs()
        {
            string sortExpression = "TARMST_TariffID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORTariffHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public bool checkifmaterialIdIsInUse(int matID, int connType)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC checkIfmaterialHasBeenAdded ");
            sql.Append(Convert.ToString(matID) + " , ");
            sql.Append(Convert.ToString(connType));
            DataTable ds = _dbManager.GetDataTable(sql.ToString());
            bool checkifmaterialIdIsInUsebool = false;
            checkifmaterialIdIsInUsebool = Convert.ToBoolean(ds.Rows[0]["MaterialExists"]);
            return checkifmaterialIdIsInUsebool;
        }
        public IList<CORTariffHDRMSTList> GetCORTariffHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'TARMST_TariffID',");
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
            int TariffCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORTariffHDRMSTList> list = new List<CORTariffHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                string CenterName = row["CenterName"].ToString();
                int TARMST_TariffID = int.Parse(row["TARMST_TariffID"].ToString());
                string TARMST_StartDate = row["TARMST_StartDate"].ToString();
                string TARMST_TariffFor = row["TARMST_TariffFor"].ToString();
                string Plans = row["Plans"].ToString();
                decimal TARMST_MinUnit = decimal.Parse(row["TARMST_MinUnit"].ToString());
                decimal TARMST_UnitLimitForDomesticPrice = decimal.Parse(row["TARMST_UnitLimitForDomesticPrice"].ToString());
                decimal TARMST_Rent = decimal.Parse(row["TARMST_Rent"].ToString());
                decimal TARMST_GasPrice = decimal.Parse(row["TARMST_GasPrice"].ToString());
                decimal TARMST_CommercialGasPrice = decimal.Parse(row["TARMST_CommercialGasPrice"].ToString());
                string TARMST_IsTaxIncluded = row["TARMST_IsTaxIncluded"].ToString();
                string TARMST_RowStatus = row["TARMST_RowStatus"].ToString();
                list.Add(new CORTariffHDRMSTList(CenterName, TARMST_TariffID, TARMST_StartDate, TARMST_TariffFor, Plans, TARMST_MinUnit, TARMST_UnitLimitForDomesticPrice, TARMST_Rent, TARMST_GasPrice, TARMST_CommercialGasPrice, TARMST_IsTaxIncluded, TARMST_RowStatus, TariffCount));
            }
            return list;
        }
        public IList<CORTariffHDRMSTList> GetCORTariffHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'TARMST_TariffID',");
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
            DataSet ds = _dbManager.GetDataSet(sql.ToString(), ref objCon, ref trn);
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int TariffCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORTariffHDRMSTList> list = new List<CORTariffHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                string CenterName = row["CenterName"].ToString();
                int TARMST_TariffID = int.Parse(row["TARMST_TariffID"].ToString());
                string TARMST_StartDate = row["TARMST_StartDate"].ToString();
                string TARMST_TariffFor = row["TARMST_TariffFor"].ToString();
                string Plans = row["Plans"].ToString();
                Int32 TARMST_MinUnit = int.Parse(row["TARMST_MinUnit"].ToString());
                decimal TARMST_UnitLimitForDomesticPrice = decimal.Parse(row["TARMST_UnitLimitForDomesticPrice"].ToString());
                decimal TARMST_Rent = decimal.Parse(row["TARMST_Rent"].ToString());
                decimal TARMST_GasPrice = decimal.Parse(row["TARMST_GasPrice"].ToString());
                decimal TARMST_CommercialGasPrice = decimal.Parse(row["TARMST_CommercialGasPrice"].ToString());
                string TARMST_IsTaxIncluded = row["TARMST_IsTaxIncluded"].ToString();
                string TARMST_RowStatus = row["TARMST_RowStatus"].ToString();
                list.Add(new CORTariffHDRMSTList(CenterName, TARMST_TariffID, TARMST_StartDate, TARMST_TariffFor, Plans, TARMST_MinUnit, TARMST_UnitLimitForDomesticPrice, TARMST_Rent, TARMST_GasPrice, TARMST_CommercialGasPrice, TARMST_IsTaxIncluded, TARMST_RowStatus, TariffCount));
            }
            return list;
        }

        public CORTariffHDRMST GetCORTariffHDRMST(int CORTariffHDRMSTid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_Select " + CORTariffHDRMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int TARMST_TariffID = Convert.ToInt32(row["TARMST_TariffID"]);
            string TARMST_StartDate = Convert.ToString(row["TARMST_StartDate"]);
            int TARMST_TariffFor = Convert.ToInt32(row["TARMST_TariffFor"]);
            decimal TARMST_MinUnit = Convert.ToDecimal(row["TARMST_MinUnit"]);
            decimal TARMST_UnitLimitForDomesticPrice = decimal.Parse(row["TARMST_UnitLimitForDomesticPrice"].ToString());
            decimal TARMST_Rent = Convert.ToDecimal(row["TARMST_Rent"]);
            decimal TARMST_GasPrice = Convert.ToDecimal(row["TARMST_GasPrice"]);
            decimal TARMST_CommercialGasPrice = decimal.Parse(row["TARMST_CommercialGasPrice"].ToString());
            bool TARMST_IsTaxIncluded = Convert.ToBoolean(row["TARMST_IsTaxIncluded"]);
            int TARMST_CenCode = Convert.ToInt32(row["TARMST_CenCode"]);
            int TARMST_CreatedByUserID = Convert.ToInt32(row["TARMST_CreatedByUserID"]);
            int TARMST_UpdatedByUserID = Convert.ToInt32(row["TARMST_UpdatedByUserID"]);
            int TARMST_RowStatus = Convert.ToInt32(row["TARMST_RowStatus"]);
            long TARMST_RowVersion = long.Parse(row["TARMST_RowVersion"].ToString());

            #endregion

            return new
            CORTariffHDRMST(TARMST_TariffID, TARMST_StartDate, TARMST_TariffFor, TARMST_MinUnit, TARMST_UnitLimitForDomesticPrice, TARMST_Rent, TARMST_GasPrice, TARMST_CommercialGasPrice, TARMST_IsTaxIncluded, TARMST_CenCode, TARMST_CreatedByUserID, TARMST_UpdatedByUserID, TARMST_RowStatus, TARMST_RowVersion);
        }

        public DataTable GetCORTariffHDRMST_CheckPlansAttached(CORTariffHDRMST_CheckPlansAttached CORTariffHDRMST_CheckPlansAttached, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_CheckPlansAttached ");
            sql.Append(CORTariffHDRMST_CheckPlansAttached.TARMST_TariffID + ",");
            sql.Append(CORTariffHDRMST_CheckPlansAttached.TARMST_CenCode + ",");
            sql.Append("N'" + CORTariffHDRMST_CheckPlansAttached.TARMST_StartDate + "',");
            sql.Append("N'" + CORTariffHDRMST_CheckPlansAttached.Plans + "'");

            DataTable tmpdt = _dbManager.GetDataTable(sql.ToString(), ref objCon, ref trn);
            return tmpdt;
        }

        public DataTable GetCORTariffHDRMST_CheckPlansForBillingDone(CORTariffHDRMST_CheckPlansForBillingDone CORTariffHDRMST_CheckPlansForBillingDone)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CORTariffHDRMST_CheckPlansForBillingDone] ");
            sql.Append(CORTariffHDRMST_CheckPlansForBillingDone.TARMST_TariffID + ",");
            sql.Append(CORTariffHDRMST_CheckPlansForBillingDone.TARMST_CenCode);

            DataTable tmpdt = _dbManager.GetDataTable(sql.ToString());
            return tmpdt;
        }

        public CORTariffHDRMSTMsg InsertCORTariffHDRMST(CORTariffHDRMST CORTariffHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_Insert ");
            sql.Append("N'" + CORTariffHDRMST.TARMST_StartDate + "',");
            sql.Append(CORTariffHDRMST.TARMST_TariffFor + ",");
            sql.Append(CORTariffHDRMST.TARMST_MinUnit + ",");
            sql.Append(CORTariffHDRMST.TARMST_UnitLimitForDomesticPrice + ",");
            sql.Append(CORTariffHDRMST.TARMST_Rent + ",");
            sql.Append(CORTariffHDRMST.TARMST_GasPrice + ",");
            sql.Append(CORTariffHDRMST.TARMST_CommercialGasPrice + ",");
            sql.Append(CORTariffHDRMST.TARMST_IsTaxIncluded + ",");
            sql.Append(CORTariffHDRMST.TARMST_CenCode + ",");
            sql.Append(CORTariffHDRMST.TARMST_CreatedByUserID + ",");
            sql.Append(CORTariffHDRMST.TARMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORTariffHDRMSTMsg UpdateCORTariffHDRMST(CORTariffHDRMST CORTariffHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_Update ");
            sql.Append(CORTariffHDRMST.TARMST_TariffID + ",");
            sql.Append("N'" + CORTariffHDRMST.TARMST_StartDate + "',");
            sql.Append(CORTariffHDRMST.TARMST_TariffFor + ",");
            sql.Append(CORTariffHDRMST.TARMST_MinUnit + ",");
            sql.Append(CORTariffHDRMST.TARMST_UnitLimitForDomesticPrice + ",");
            sql.Append(CORTariffHDRMST.TARMST_Rent + ",");
            sql.Append(CORTariffHDRMST.TARMST_GasPrice + ",");
            sql.Append(CORTariffHDRMST.TARMST_CommercialGasPrice + ",");
            sql.Append(CORTariffHDRMST.TARMST_IsTaxIncluded + ",");
            sql.Append(CORTariffHDRMST.TARMST_CenCode + ",");
            sql.Append(CORTariffHDRMST.TARMST_CreatedByUserID + ",");
            sql.Append(CORTariffHDRMST.TARMST_UpdatedByUserID + ",");
            sql.Append(CORTariffHDRMST.TARMST_RowStatus + ",");
            sql.Append(CORTariffHDRMST.TARMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORTariffHDRMSTMsg DeleteCORTariffHDRMST(int CORTariffHDRMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffHDRMST_Delete " + CORTariffHDRMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }
    }
}
