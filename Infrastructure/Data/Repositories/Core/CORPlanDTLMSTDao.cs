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
    public class CORPlanDTLMSTDao : ICORPlanDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORPlanDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        
            public IList<CORPlanDTLMSTList> GetCORPlanDTLMSTs(int PDLMST_PlanID)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC USP_CORPlanDTLMST_SelectAll " + PDLMST_PlanID);
                //String Building for Order by Column.

                DataSet ds = _dbManager.GetDataSet(sql.ToString());
                IList<CORPlanDTLMSTList> list = new List<CORPlanDTLMSTList>();

                if (ds.Tables.Count > 0)
                {
                    DataTable dtList = ds.Tables[0];
                    foreach (DataRow row in dtList.Rows)
                    {
                        int PDLMST_HeadID = int.Parse(row["PDLMST_HeadID"].ToString());
                        string HeadName = row["HeadName"].ToString();
                        decimal PDLMST_Amount = decimal.Parse(row["PDLMST_Amount"].ToString());
                        bool PDLMST_Refundable = bool.Parse(row["PDLMST_Refundable"].ToString());
                        int PDLMST_NoofEMI = int.Parse(row["PDLMST_NoofEMI"].ToString());
                        int PDLMST_Collect = int.Parse(row["PDLMST_Collect"].ToString());
                        list.Add(new CORPlanDTLMSTList(PDLMST_HeadID, HeadName, PDLMST_Amount, PDLMST_Refundable, PDLMST_NoofEMI, PDLMST_Collect));

                    }
                }
                return list;
            }

            public DataTable GetAllCORPlanDTLMSTs(int CenterCode)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC USP_CORPlanDTLMST_SelectAllPlans " + CenterCode);
                //String Building for Order by Column.

                DataSet ds = _dbManager.GetDataSet(sql.ToString());
                //IList<CORPlanDTLMSTList> list = new List<CORPlanDTLMSTList>();
                DataTable dtList = null;
                if (ds.Tables.Count > 0)
                {
                    dtList = ds.Tables[0];
                }
                return dtList;
            }


            public CORPlanHDRMSTMsg InsertCORPlanDTLMST(CORPlanDTLMST CORPlanDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("EXEC USP_CORPlanDTLMST_Insert ");
                sql.Append(CORPlanDTLMST.PDLMST_PlanID + ",");
                sql.Append(CORPlanDTLMST.PDLMST_HeadID + ",");
                sql.Append(CORPlanDTLMST.PDLMST_Amount + ",");
                sql.Append(CORPlanDTLMST.PDLMST_Refundable + ",");
                sql.Append(CORPlanDTLMST.PDLMST_NoofEMI + ",");
                sql.Append(CORPlanDTLMST.PDLMST_Collect);
                DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
                #region"Variables Declaration"

                int _RetVal = Convert.ToInt32(row["RetVal"]);
                string _RetStr = Convert.ToString(row["RetStr"]);
                #endregion

                return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
            }

    }
}
