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
    public class CONJobsheetMaterialHDRMSTDao : ICONJobsheetMaterialHDRMSTDao
    {
        private readonly DbManager _dbManager;

        public CONJobsheetMaterialHDRMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CONJobsheetMaterialHDRMSTList> GetCONJobsheetMaterialHDRMSTs()
        {
            string sortExpression = "CJMHDR_MaterialID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            int CallType = 0;
            return GetCONJobsheetMaterialHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria, CallType);
        }

        public IList<CONJobsheetMaterialHDRMSTList> GetCONJobsheetMaterialHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, int CallType)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CONJobsheetMaterialHDRMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CJMHDR_MaterialID',");
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
            sql.Append(criteria + "',");
            sql.Append(CallType + "");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CONJobsheetMaterialHDRMSTList> list = new List<CONJobsheetMaterialHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                decimal CJMHDR_MaterialID = decimal.Parse(row["CJMHDR_MaterialID"].ToString());
                string CJMHDR_MaterialDesc = row["CJMHDR_MaterialDesc"].ToString();
                string CJMHDR_MaterialUnit = row["CJMHDR_MaterialUnit"].ToString();
                decimal Rate = decimal.Parse(row["Rate"].ToString());
                list.Add(new CONJobsheetMaterialHDRMSTList(CJMHDR_MaterialID, CJMHDR_MaterialDesc, CJMHDR_MaterialUnit, Rate, Count));
            }
            return list;
        }

        public CONJobsheetMaterialHDRMST GetCONJobsheetMaterialHDRMST(int CONJobsheetMaterialHDRMSTid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONJobsheetMaterialHDRMST_Select " + CONJobsheetMaterialHDRMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal CJMHDR_MaterialID = Convert.ToDecimal(row["CJMHDR_MaterialID"]);
            string CJMHDR_MaterialDesc = Convert.ToString(row["CJMHDR_MaterialDesc"]);
            string CJMHDR_MaterialUnit = Convert.ToString(row["CJMHDR_MaterialUnit"]);

            #endregion

            return new
            CONJobsheetMaterialHDRMST(CJMHDR_MaterialID, CJMHDR_MaterialDesc, CJMHDR_MaterialUnit);
        }

        public CONJobsheetMaterialHDRMSTMsg InsertCONJobsheetMaterialHDRMST(CONJobsheetMaterialHDRMST CONJobsheetMaterialHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONJobsheetMaterialHDRMST_Insert ");
            sql.Append("N'" + CONJobsheetMaterialHDRMST.CJMHDR_MaterialDesc + "',");
            sql.Append("N'" + CONJobsheetMaterialHDRMST.CJMHDR_MaterialUnit + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new CONJobsheetMaterialHDRMSTMsg(_RetVal, _RetStr);
        }

        public CONJobsheetMaterialHDRMSTMsg UpdateCONJobsheetMaterialHDRMST(CONJobsheetMaterialHDRMST CONJobsheetMaterialHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONJobsheetMaterialHDRMST_Update ");
            sql.Append(CONJobsheetMaterialHDRMST.CJMHDR_MaterialID + ",");
            sql.Append("N'" + CONJobsheetMaterialHDRMST.CJMHDR_MaterialDesc + "',");
            sql.Append("N'" + CONJobsheetMaterialHDRMST.CJMHDR_MaterialUnit + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CONJobsheetMaterialHDRMSTMsg(_RetVal, _RetStr);
        }

        public CONJobsheetMaterialHDRMSTMsg DeleteCONJobsheetMaterialHDRMST(int CONJobsheetMaterialHDRMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CONJobsheetMaterialHDRMST_Delete " + CONJobsheetMaterialHDRMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CONJobsheetMaterialHDRMSTMsg(_RetVal, _RetStr);
        }

    }
}
