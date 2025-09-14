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
    public class CORPlanMATDTLMSTDao : ICORPlanMATDTLMSTDao
    {
        private readonly DbManager _dbManager;

        public CORPlanMATDTLMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public IList<CORPlanMATDTLMSTList> GetCORPlanMATDTLMSTs(int PMDMST_PlanID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanMATDTLMST_SelectAll " + PMDMST_PlanID);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());

            IList<CORPlanMATDTLMSTList> list = new List<CORPlanMATDTLMSTList>();

            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];

                foreach (DataRow row in dtList.Rows)
                {
                    int PMDMST_MaterialID = int.Parse(row["PMDMST_MaterialID"].ToString());
                    string MaterialName = row["MaterialName"].ToString();
                    decimal PMDMST_PipeLengthFree = decimal.Parse(row["PMDMST_PipeLengthFree"].ToString());
                    int PMDMST_PipeConnType = int.Parse(row["PMDMST_PipeConnType"].ToString());
                    string PipeConnType = row["PipeConnType"].ToString();
                    int PMDMST_ExtraConnType = int.Parse(row["PMDMST_ExtraConnType"].ToString());
                    string ExtraConnType = row["ExtraConnType"].ToString();
                    int PMDMST_PropertyTypeID = int.Parse(row["PMDMST_PropertyTypeID"].ToString());
                    string PropertyType = row["PropertyType"].ToString();
                    list.Add(new CORPlanMATDTLMSTList(PMDMST_MaterialID, MaterialName, PMDMST_PipeLengthFree, PMDMST_PipeConnType, PipeConnType, PMDMST_ExtraConnType, ExtraConnType, PMDMST_PropertyTypeID, PropertyType));
                }
            }

            return list;
        }

        public CORPlanHDRMSTMsg InsertCORPlanMATDTLMST(CORPlanMATDTLMST CORPlanMATDTLMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORPlanMATDTLMST_Insert ");
            sql.Append(CORPlanMATDTLMST.PMDMST_PlanID + ",");
            sql.Append(CORPlanMATDTLMST.PMDMST_MaterialID + ",");
            sql.Append(CORPlanMATDTLMST.PMDMST_PipeLengthFree + ",");
            sql.Append(CORPlanMATDTLMST.PMDMST_PropertyTypeID + ",");
            sql.Append(CORPlanMATDTLMST.PMDMST_PipeConnType + ",");
            sql.Append(CORPlanMATDTLMST.PMDMST_ExtraConnType);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORPlanHDRMSTMsg(_RetVal, _RetStr);
        }
    }

}
