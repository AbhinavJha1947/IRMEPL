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
    public class CORTariffExtraConnDTLMSTDao : ICORTariffExtraConnDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORTariffExtraConnDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORTariffExtraConnDTLMSTList> GetCORTariffExtraConnDTLMSTs(int TEDMST_TariffID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffExtraConnDTLMST_SelectAll " + TEDMST_TariffID);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORTariffExtraConnDTLMSTList> list = new List<CORTariffExtraConnDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                int TEDMST_ExtraConnTypeID = int.Parse(row["TEDMST_ExtraConnTypeID"].ToString());
                string CD_ControlType = row["CD_ControlType"].ToString();
                decimal TEDMST_Amount = decimal.Parse(row["TEDMST_Amount"].ToString());
                list.Add(new CORTariffExtraConnDTLMSTList(TEDMST_ExtraConnTypeID, CD_ControlType, TEDMST_Amount));

            }
            return list;
        }

        public CORTariffHDRMSTMsg InsertCORTariffExtraConnDTLMST(CORTariffExtraConnDTLMST CORTariffExtraConnDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffExtraConnDTLMST_Insert ");
            sql.Append(CORTariffExtraConnDTLMST.TEDMST_TariffID + ",");
            sql.Append(CORTariffExtraConnDTLMST.TEDMST_ExtraConnTypeID + ",");
            sql.Append(CORTariffExtraConnDTLMST.TEDMST_Amount);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }
    }

}
