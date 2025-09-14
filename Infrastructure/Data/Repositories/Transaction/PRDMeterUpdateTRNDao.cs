using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class PRDMeterUpdateTRNDao : IPRDMeterUpdateTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDMeterUpdateTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDMeterUpdateTRNList> GetPRDMeterUpdateTRNs()
        {
            string sortExpression = "METNOU_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDMeterUpdateTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDMeterUpdateTRNList> GetPRDMeterUpdateTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterUpdateTRN_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'METNOU_ID',");
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
            IList<PRDMeterUpdateTRNList> list = new List<PRDMeterUpdateTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int METNOU_ID = int.Parse(row["METNOU_ID"].ToString());
                string ApplicationNo = row["ApplicationNo"].ToString();
                string CustomerName = row["CustomerName"].ToString();
                string APPMST_Address = row["APPMST_Address"].ToString();
                string APPMST_Landmark = row["APPMST_Landmark"].ToString();
                string AREMST_Name = row["AREMST_Name"].ToString();
                string CustomerType = row["CustomerType"].ToString();
                string PlanName = row["PlanName"].ToString();
                Int64 METNOU_OldMeterNo = Convert.ToInt64(row["METNOU_OldMeterNo"].ToString());
                Int64 METNOU_NewMeterNo = Convert.ToInt64(row["METNOU_NewMeterNo"].ToString());
                string METNOU_UpdatedDateTime = row["METNOU_UpdatedDateTime"].ToString();
                string METNOU_UpdatedByUserID = row["METNOU_UpdatedByUserID"].ToString();
                list.Add(new PRDMeterUpdateTRNList(METNOU_ID, ApplicationNo, CustomerName, APPMST_Address, APPMST_Landmark, AREMST_Name, CustomerType, PlanName, METNOU_OldMeterNo, METNOU_NewMeterNo, METNOU_UpdatedDateTime, METNOU_UpdatedByUserID, Count));
            }
            return list;
        }

        public PRDMeterUpdateTRN GetPRDMeterUpdateTRN(int PRDMeterUpdateTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterUpdateTRN_Select " + PRDMeterUpdateTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int METNOU_ID = Convert.ToInt32(row["METNOU_ID"]);
            decimal METNOU_ApplicationId = Convert.ToDecimal(row["METNOU_ApplicationId"]);
            decimal METNOU_OldMeterNo = Convert.ToDecimal(row["METNOU_OldMeterNo"]);
            decimal METNOU_NewMeterNo = Convert.ToDecimal(row["METNOU_NewMeterNo"]);
            int METNOU_UpdatedByUserID = Convert.ToInt32(row["METNOU_UpdatedByUserID"]);
            string METNOU_UpdatedDateTime = Convert.ToString(row["METNOU_UpdatedDateTime"]);
            long METNOU_RowVersion = (long)row["METNOU_RowVersion"];

            #endregion

            return new
            PRDMeterUpdateTRN(METNOU_ID, METNOU_ApplicationId, METNOU_OldMeterNo, METNOU_NewMeterNo, METNOU_UpdatedByUserID, METNOU_UpdatedDateTime, METNOU_RowVersion);
        }

        public PRDMeterUpdateTRNMsg InsertPRDMeterUpdateTRN(PRDMeterUpdateTRN PRDMeterUpdateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterUpdateTRN_Insert ");
            sql.Append(PRDMeterUpdateTRN.METNOU_ApplicationId + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_OldMeterNo + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_NewMeterNo + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_UpdatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDMeterUpdateTRNMsg(_RetVal, _RetStr);
        }

        public PRDMeterUpdateTRNMsg UpdatePRDMeterUpdateTRN(PRDMeterUpdateTRN PRDMeterUpdateTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterUpdateTRN_Update ");
            sql.Append(PRDMeterUpdateTRN.METNOU_ID + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_ApplicationId + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_OldMeterNo + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_NewMeterNo + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_UpdatedByUserID + ",");
            sql.Append(PRDMeterUpdateTRN.METNOU_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDMeterUpdateTRNMsg(_RetVal, _RetStr);
        }

        public PRDMeterUpdateTRNMsg DeletePRDMeterUpdateTRN(int PRDMeterUpdateTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterUpdateTRN_Delete " + PRDMeterUpdateTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDMeterUpdateTRNMsg(_RetVal, _RetStr);
        }

    }
}
