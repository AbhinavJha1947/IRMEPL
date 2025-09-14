using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORMaterialDTLMSTDao : ICORMaterialDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORMaterialDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORMaterialDTLMSTList> GetCORMaterialDTLMSTs()
        {
            string sortExpression = "MTDMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORMaterialDTLMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORMaterialDTLMSTList> GetCORMaterialDTLMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialDTLMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'MTDMST_ID',");
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
            IList<CORMaterialDTLMSTList> list = new List<CORMaterialDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int MTDMST_ID = int.Parse(row["MTDMST_ID"].ToString());
                int MTDMST_MaterialID = int.Parse(row["MTDMST_MaterialID"].ToString());
                int MTDMST_TaxID = int.Parse(row["MTDMST_TaxID"].ToString());
                list.Add(new CORMaterialDTLMSTList(MTDMST_ID, MTDMST_MaterialID, MTDMST_TaxID, Count));
                //list.Add(new CORBankMasterList(BANMST_BkCode, BANMST_BankName, BANMST_Address, BankCounter));
            }
            return list;
        }

        public CORMaterialDTLMST GetCORMaterialDTLMST(int CORMaterialDTLMSTid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialDTLMST_Select " + CORMaterialDTLMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int MTDMST_ID = Convert.ToInt32(row["MTDMST_ID"]);
            int MTDMST_MaterialID = Convert.ToInt32(row["MTDMST_MaterialID"]);
            int MTDMST_TaxID = Convert.ToInt32(row["MTDMST_TaxID"]);

            #endregion

            return new
            CORMaterialDTLMST(MTDMST_ID, MTDMST_MaterialID, MTDMST_TaxID);
        }

        public CORMaterialDTLMSTMsg InsertCORMaterialDTLMST(CORMaterialDTLMST CORMaterialDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialDTLMST_Insert ");
            sql.Append(CORMaterialDTLMST.MTDMST_MaterialID + ",");
            sql.Append(CORMaterialDTLMST.MTDMST_TaxID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new CORMaterialDTLMSTMsg(_RetVal, _RetStr);
        }

        public CORMaterialDTLMSTMsg UpdateCORMaterialDTLMST(CORMaterialDTLMST CORMaterialDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Core_CORMaterialDTLMST_Update ");
            sql.Append(CORMaterialDTLMST.MTDMST_ID + ",");
            sql.Append(CORMaterialDTLMST.MTDMST_MaterialID + ",");
            sql.Append(CORMaterialDTLMST.MTDMST_TaxID + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORMaterialDTLMSTMsg(_RetVal, _RetStr);
        }

        public CORMaterialDTLMSTMsg DeleteCORMaterialDTLMST(int CORMaterialDTLMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialDTLMST_Delete " + CORMaterialDTLMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORMaterialDTLMSTMsg(_RetVal, _RetStr);
        }
    }
}

