using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Infrastructure.Data.Repositories.Core
{
    public class CONTariffDTLMSTDao : ICONTariffDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CONTariffDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CONTariffDTLMSTList> GetCONTariffDTLMSTs()
        {
            string sortExpression = "CTDMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCONTariffDTLMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CONTariffDTLMSTList> GetCONTariffDTLMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONTariffDTLMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CTDMST_ID',");
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
            IList<CONTariffDTLMSTList> list = new List<CONTariffDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public CONTariffDTLMST GetCONTariffDTLMST(int CONTariffDTLMSTid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONTariffDTLMST_Select " + CONTariffDTLMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CTDMST_ID = Convert.ToInt32(row["CTDMST_ID"]);
            int CTDMST_TariffID = Convert.ToInt32(row["CTDMST_TariffID"]);
            int CTDMST_MaterialID = Convert.ToInt32(row["CTDMST_MaterialID"]);
            decimal CTDMST_Rate = Convert.ToDecimal(row["CTDMST_Rate"]);

            #endregion

            return new
            CONTariffDTLMST(CTDMST_ID, CTDMST_TariffID, CTDMST_MaterialID, CTDMST_Rate);
        }

        public CONTariffDTLMSTMsg InsertCONTariffDTLMST(CONTariffDTLMST CONTariffDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CONTariffDTLMST_Insert] ");
            sql.Append(CONTariffDTLMST.CTDMST_TariffID + ",");
            sql.Append(CONTariffDTLMST.CTDMST_MaterialID + ",");
            sql.Append(CONTariffDTLMST.CTDMST_Rate + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CONTariffDTLMSTMsg(_RetVal, _RetStr);
        }

        public CONTariffDTLMSTMsg UpdateCONTariffDTLMST(CONTariffDTLMST CONTariffDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONTariffDTLMST_Update ");
            sql.Append(CONTariffDTLMST.CTDMST_ID + ",");
            sql.Append(CONTariffDTLMST.CTDMST_TariffID + ",");
            sql.Append(CONTariffDTLMST.CTDMST_MaterialID + ",");
            sql.Append(CONTariffDTLMST.CTDMST_Rate + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CONTariffDTLMSTMsg(_RetVal, _RetStr);
        }

        public CONTariffDTLMSTMsg DeleteCONTariffDTLMST(int CONTariffDTLMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CONTariffDTLMST_Delete " + CONTariffDTLMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CONTariffDTLMSTMsg(_RetVal, _RetStr);
        }

    }
}
