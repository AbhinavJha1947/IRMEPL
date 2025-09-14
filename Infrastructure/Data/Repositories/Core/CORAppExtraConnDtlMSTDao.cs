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
    public class CORAppExtraConnDtlMSTDao : ICORAppExtraConnDtlMSTDao
    {
        private readonly DbManager _dbManager;

        public CORAppExtraConnDtlMSTDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORAppExtraConnDtlMSTList> GetCORAppExtraConnDtlMSTs()
        {
            string sortExpression = "AEDMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORAppExtraConnDtlMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORAppExtraConnDtlMSTList> GetCORAppExtraConnDtlMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppExtraConnDtlMST_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_ConnTypeID',");
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
            IList<CORAppExtraConnDtlMSTList> list = new List<CORAppExtraConnDtlMSTList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int AEDMST_ConnTypeID = int.Parse(row["APPMST_ConnTypeID"].ToString());
                string AEDMST_ConnType = row["APPMST_ConnType"].ToString();
                int AEDMST_NoofConn = int.Parse(row["APPMST_NoofConn"].ToString());
                list.Add(new CORAppExtraConnDtlMSTList(AEDMST_ConnTypeID, AEDMST_ConnType, AEDMST_NoofConn));

            }
            return list;
        }

        public CORAppExtraConnDtlMST GetCORAppExtraConnDtlMST(int CORAppExtraConnDtlMSTid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppExtraConnDtlMST_Select " + CORAppExtraConnDtlMSTid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal AEDMST_ID = Convert.ToDecimal(row["AEDMST_ID"]);
            decimal AEDMST_AppID = Convert.ToDecimal(row["AEDMST_AppID"]);
            int AEDMST_ConnType = Convert.ToInt32(row["AEDMST_ConnType"]);
            int AEDMST_NoofConn = Convert.ToInt32(row["AEDMST_NoofConn"]);

            #endregion

            return new
            CORAppExtraConnDtlMST(AEDMST_ID, AEDMST_AppID, AEDMST_ConnType, AEDMST_NoofConn);
        }

        public CORAppExtraConnDtlMSTMsg InsertCORAppExtraConnDtlMST(CORAppExtraConnDtlMST CORAppExtraConnDtlMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppExtraConnDtlMST_Insert ");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_AppID + ",");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_ConnType + ",");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_NoofConn + " ");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);
            #endregion

            return new CORAppExtraConnDtlMSTMsg(_RetVal, _RetStr);
        }

        public CORAppExtraConnDtlMSTMsg UpdateCORAppExtraConnDtlMST(CORAppExtraConnDtlMST CORAppExtraConnDtlMST, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppExtraConnDtlMST_Update ");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_ID + ",");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_AppID + ",");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_ConnType + ",");
            sql.Append(CORAppExtraConnDtlMST.AEDMST_NoofConn + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORAppExtraConnDtlMSTMsg(_RetVal, _RetStr);
        }

        public CORAppExtraConnDtlMSTMsg DeleteCORAppExtraConnDtlMST(int CORAppExtraConnDtlMSTID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORAppExtraConnDtlMST_Delete " + CORAppExtraConnDtlMSTID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new CORAppExtraConnDtlMSTMsg(_RetVal, _RetStr);
        }
    }
}

