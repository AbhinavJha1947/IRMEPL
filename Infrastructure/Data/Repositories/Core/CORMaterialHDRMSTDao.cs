using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Infrastructure.Data.Repositories.Core
{
    public class CORMaterialHDRMSTDao : ICORMaterialHDRMSTDao
    {
        private readonly DbManager _dbManager;

        public CORMaterialHDRMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORMaterialHDRMSTList> GetCORMaterialHDRMSTs()
        {
            string sortExpression = "MATMST_MaterialID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORMaterialHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORMaterialHDRMSTList> GetCORMaterialHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialHDRMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'MATMST_MaterialID',");
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
            IList<CORMaterialHDRMSTList> list = new List<CORMaterialHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int MATMST_MaterialID = int.Parse(row["MATMST_MaterialID"].ToString());
                string MATMST_Shortname = row["MATMST_Shortname"].ToString();
                string MATMST_Description = row["MATMST_Description"].ToString();
                string MATMST_MaterialType = row["MATMST_MaterialType"].ToString();
                string TAX = row["TAX"].ToString();
                string MATMST_RowStatus = row["MATMST_RowStatus"].ToString();
                list.Add(new CORMaterialHDRMSTList(MATMST_MaterialID, MATMST_Shortname, MATMST_Description, MATMST_MaterialType, TAX, MATMST_RowStatus, Count));
            }
            return list;

        }

        public CORMaterialHDRMST GetCORMaterialHDRMST(int CORMaterialHDRMSTid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialHDRMST_Select " + CORMaterialHDRMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int MATMST_MaterialID = Convert.ToInt32(row["MATMST_MaterialID"]);
            int MATMST_MaterialType = Convert.ToInt32(row["MATMST_MaterialType"]);
            string MATMST_Shortname = Convert.ToString(row["MATMST_Shortname"]);
            string MATMST_Description = Convert.ToString(row["MATMST_Description"]);
            int MATMST_CreatedByUserID = Convert.ToInt32(row["MATMST_CreatedByUserID"]);
            string MATMST_CreatedDateTime = Convert.ToString(row["MATMST_CreatedDateTime"]);
            int MATMST_UpdatedByUserID = Convert.ToInt32(row["MATMST_UpdatedByUserID"]);
            string MATMST_UpdatedDateTime = Convert.ToString(row["MATMST_UpdatedDateTime"]);
            int MATMST_RowStatus = Convert.ToInt32(row["MATMST_RowStatus"]);
            long MATMST_RowVersion = (long)row["MATMST_RowVersion"];
            #endregion

            return new
            CORMaterialHDRMST(MATMST_MaterialID, MATMST_MaterialType, MATMST_Shortname, MATMST_Description, MATMST_CreatedByUserID, MATMST_CreatedDateTime, MATMST_UpdatedByUserID, MATMST_UpdatedDateTime, MATMST_RowStatus, MATMST_RowVersion);
        }

        public CORMaterialHDRMSTMsg InsertCORMaterialHDRMST(CORMaterialHDRMST CORMaterialHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialHDRMST_Insert ");
            sql.Append(CORMaterialHDRMST.MATMST_MaterialType + ",");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_Shortname + "',");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_Description + "',");
            sql.Append(CORMaterialHDRMST.MATMST_CreatedByUserID + ",");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_CreatedDateTime + "',");
            sql.Append(CORMaterialHDRMST.MATMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_UpdatedDateTime + "',");
            sql.Append(CORMaterialHDRMST.MATMST_RowStatus);
            //sql.Append(CORMaterialHDRMST.MATMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORMaterialHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORMaterialHDRMSTMsg UpdateCORMaterialHDRMST(CORMaterialHDRMST CORMaterialHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialHDRMST_Update ");
            sql.Append(CORMaterialHDRMST.MATMST_MaterialID + ",");
            sql.Append(CORMaterialHDRMST.MATMST_MaterialType + ",");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_Shortname + "',");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_Description + "',");
            sql.Append(CORMaterialHDRMST.MATMST_CreatedByUserID + ",");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_CreatedDateTime + "',");
            sql.Append(CORMaterialHDRMST.MATMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORMaterialHDRMST.MATMST_UpdatedDateTime + "',");
            sql.Append(CORMaterialHDRMST.MATMST_RowStatus + ",");
            sql.Append(CORMaterialHDRMST.MATMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORMaterialHDRMSTMsg(_RetVal, _RetStr);
        }

        public CORMaterialHDRMSTMsg DeleteCORMaterialHDRMST(int CORMaterialHDRMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORMaterialHDRMST_Delete " + CORMaterialHDRMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORMaterialHDRMSTMsg(_RetVal, _RetStr);
        }

    }
}
