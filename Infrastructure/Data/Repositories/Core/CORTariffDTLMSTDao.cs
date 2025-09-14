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
    public class CORTariffDTLMSTDao : ICORTariffDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORTariffDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORTariffDTLMSTList> GetCORTariffDTLMSTs(int TDLMST_TariffID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffDTLMST_SelectAll " + TDLMST_TariffID);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORTariffDTLMSTList> list = new List<CORTariffDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                int TDLMST_ChargeId = int.Parse(row["TDLMST_ChargeId"].ToString());
                int TDLMST_ChargeType = int.Parse(row["TDLMST_ChargeType"].ToString());
                string CHGMST_Name = row["CHGMST_Name"].ToString();
                decimal TDLMST_Amount = decimal.Parse(row["TDLMST_Amount"].ToString());
                list.Add(new CORTariffDTLMSTList(TDLMST_ChargeId, TDLMST_ChargeType, CHGMST_Name, TDLMST_Amount));

            }
            return list;
        }

        public CORTariffHDRMSTMsg InsertCORTariffDTLMST(CORTariffDTLMST CORTariffDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffDTLMST_Insert ");
            sql.Append(CORTariffDTLMST.TDLMST_TariffID + ",");
            sql.Append(CORTariffDTLMST.TDLMST_ChargeId + ",");
            sql.Append(CORTariffDTLMST.TDLMST_ChargeType + ",");
            sql.Append(CORTariffDTLMST.TDLMST_Amount);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }
    }

}
