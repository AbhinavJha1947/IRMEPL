using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Application.RepositoryInterfaces.Core;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORTariffMATDTLMSTDao : ICORTariffMATDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORTariffMATDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORTariffMATDTLMSTList> GetCORTariffMATDTLMSTs(int TMDMST_TariffID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffMATDTLMST_SelectAll " + TMDMST_TariffID);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORTariffMATDTLMSTList> list = new List<CORTariffMATDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                string TMDMST_MaterialID = row["TMDMST_MaterialID"].ToString();
                string MATMST_Shortname = row["MATMST_Shortname"].ToString();
                string TMDMST_ConnType = row["TMDMST_ConnType"].ToString();
                decimal TMDMST_Amount = decimal.Parse(row["TMDMST_Amount"].ToString());
                list.Add(new CORTariffMATDTLMSTList(TMDMST_MaterialID, MATMST_Shortname, TMDMST_ConnType, TMDMST_Amount));

            }
            return list;
        }

        public CORTariffHDRMSTMsg InsertCORTariffMATDTLMST(CORTariffMATDTLMST CORTariffMATDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffMATDTLMST_Insert ");
            sql.Append(CORTariffMATDTLMST.TMDMST_TariffID + ",");
            sql.Append(CORTariffMATDTLMST.TMDMST_MaterialID + ",");
            sql.Append(CORTariffMATDTLMST.TMDMST_ConnType + ",");
            sql.Append(CORTariffMATDTLMST.TMDMST_Amount);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }
    }

}
