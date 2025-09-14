using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class CONTariffHDRMSTDao : ICONTariffHDRMSTDao
    {
        private readonly DbManager _dbManager;

        public CONTariffHDRMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CONTariffHDRMSTList> GetCONTariffHDRMSTs()
        {
            string sortExpression = "CTAMST_TariffID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCONTariffHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CONTariffHDRMSTList> GetCONTariffHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CONTariffHDRMST_SelectAll] ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CTAMST_StartDate',");
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
            IList<CONTariffHDRMSTList> list = new List<CONTariffHDRMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int CTAMST_TariffID = int.Parse(row["CTAMST_TariffID"].ToString());
                int CTAMST_ContractorID = int.Parse(row["CTAMST_ContractorID"].ToString());
                string CTAMST_StartDate = row["CTAMST_StartDate"].ToString();
                string CONMST_Name = row["CONMST_Name"].ToString();
                list.Add(new CONTariffHDRMSTList(CTAMST_TariffID, CTAMST_ContractorID, CTAMST_StartDate, CONMST_Name, Count));
            }
            return list;
        }

        public CONTariffHDRMST GetCONTariffHDRMST(int CONTariffHDRMSTid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CONTariffHDRMST_Select] " + CONTariffHDRMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CTAMST_TariffID = Convert.ToInt32(row["CTAMST_TariffID"]);
            string CTAMST_StartDate = Convert.ToString(row["CTAMST_StartDate"]);
            int CTAMST_ContractorID = Convert.ToInt32(row["CTAMST_ContractorID"]);
            int CTAMST_CreatedByUserID = Convert.ToInt32(row["CTAMST_CreatedByUserID"]);
            string CTAMST_CreatedDateTime = Convert.ToString(row["CTAMST_CreatedDateTime"]);
            int CTAMST_UpdatedByUserID = Convert.ToInt32(row["CTAMST_UpdatedByUserID"]);
            string CTAMST_UpdatedDateTime = Convert.ToString(row["CTAMST_UpdatedDateTime"]);
            int CTAMST_RowStatus = Convert.ToInt32(row["CTAMST_RowStatus"]);
            #endregion

            return new
            CONTariffHDRMST(CTAMST_TariffID, CTAMST_StartDate, CTAMST_ContractorID, CTAMST_CreatedByUserID, CTAMST_CreatedDateTime, CTAMST_UpdatedByUserID, CTAMST_UpdatedDateTime, CTAMST_RowStatus);
        }

        public CONTariffHDRMSTMsg InsertCONTariffHDRMST(CONTariffHDRMST CONTariffHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CONTariffHDRMST_Insert ");
            sql.Append("N'" + CONTariffHDRMST.CTAMST_StartDate + "',");
            sql.Append(CONTariffHDRMST.CTAMST_ContractorID + ",");
            sql.Append(CONTariffHDRMST.CTAMST_CreatedByUserID + ",");

            sql.Append(CONTariffHDRMST.CTAMST_UpdatedByUserID + ",");
            sql.Append("N'" + CONTariffHDRMST.CTAMST_UpdatedDateTime + "',");
            sql.Append(CONTariffHDRMST.CTAMST_RowStatus + "");


            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CONTariffHDRMSTMsg(_RetVal, _RetStr);
        }

        public CONTariffHDRMSTMsg UpdateCONTariffHDRMST(CONTariffHDRMST CONTariffHDRMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CONTariffHDRMST_Update] ");
            sql.Append(CONTariffHDRMST.CTAMST_TariffID + ",");
            sql.Append("N'" + CONTariffHDRMST.CTAMST_StartDate + "',");
            sql.Append(CONTariffHDRMST.CTAMST_ContractorID + ",");
            sql.Append(CONTariffHDRMST.CTAMST_CreatedByUserID + ",");
            sql.Append("N'" + CONTariffHDRMST.CTAMST_CreatedDateTime + "',");
            sql.Append(CONTariffHDRMST.CTAMST_UpdatedByUserID + ",");
            sql.Append("N'" + CONTariffHDRMST.CTAMST_UpdatedDateTime + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CONTariffHDRMSTMsg(_RetVal, _RetStr);
        }

        public CONTariffHDRMSTMsg DeleteCONTariffHDRMST(int CONTariffHDRMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_CONTariffHDRMST_Delete] " + CONTariffHDRMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CONTariffHDRMSTMsg(_RetVal, _RetStr);
        }

    }
}
