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
    public class CORTariffPlanDTLMSTDao : ICORTariffPlanDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORTariffPlanDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORTariffPlanDTLMSTList> GetCORTariffPlanDTLMSTs(int TPDMST_TariffID, int PLAMST_PlanType)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffPlanDTLMST_SelectAll " + TPDMST_TariffID + "," + PLAMST_PlanType);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORTariffPlanDTLMSTList> list = new List<CORTariffPlanDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                int TPDMST_PlanID = int.Parse(row["TPDMST_PlanID"].ToString());
                string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
                bool Checked = bool.Parse(row["Checked"].ToString());
                list.Add(new CORTariffPlanDTLMSTList(TPDMST_PlanID, PLAMST_PlanName, Checked));
            }
            return list;
        }

        public CORTariffHDRMSTMsg InsertCORTariffPlanDTLMST(CORTariffPlanDTLMST CORTariffPlanDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORTariffPlanDTLMST_Insert ");
            sql.Append(CORTariffPlanDTLMST.TPDMST_TariffID + ",");
            sql.Append(CORTariffPlanDTLMST.TPDMST_PlanID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORTariffHDRMSTMsg(_RetVal, _RetStr);
        }
    }
}
