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
    public class CORPlanSchemeDTLMSTDao : ICORPlanSchemeDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORPlanSchemeDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public IList<CORPlanSchemeDTLMSTList> GetCORPlanSchemeDTLMSTs(int PSDMST_PlanID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanSchemeDTLMST_SelectAll " + PSDMST_PlanID);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORPlanSchemeDTLMSTList> list = new List<CORPlanSchemeDTLMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                int PSDMST_SchemeID = int.Parse(row["PSDMST_SchemeID"].ToString());
                string SCHMST_Name = row["SCHMST_Name"].ToString();
                bool Checked = bool.Parse(row["Checked"].ToString());
                list.Add(new CORPlanSchemeDTLMSTList(PSDMST_SchemeID, SCHMST_Name, Checked));
            }
            return list;
        }

        public CORPlanHDRMSTMsg InsertCORPlanSchemeDTLMST(CORPlanSchemeDTLMST CORPlanSchemeDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanSchemeDTLMST_Insert ");
            sql.Append(CORPlanSchemeDTLMST.PSDMST_PlanID + ",");
            sql.Append(CORPlanSchemeDTLMST.PSDMST_SchemeID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }
    }

}
