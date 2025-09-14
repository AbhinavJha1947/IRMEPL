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
    public class CORLatePaymentFineDao : ICORLatePaymentFineDao
    {
        private readonly DbManager _dbManager;

        public CORLatePaymentFineDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORLatePaymentFineList> GetCORLatePaymentFines()
        {
            string sortExpression = "LPFMST_ID";
            string sortType = "Desc";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORLatePaymentFine(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORLatePaymentFineList> GetCORLatePaymentFine(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [Usp_CORLatePaymentFineMaster_SelectAll] ");
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'LPFMST_ID',");
            }
            else
            {
                sql.Append("'" + sortExpression + "',");
            }
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append("'ASC',");
            }
            else
            {
                sql.Append("'" + sortType + "',");
            }
            sql.Append(pageIndex + ",");
            sql.Append(pageSize + ",'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int LPFMSTCount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORLatePaymentFineList> list = new List<CORLatePaymentFineList>();
            foreach (DataRow row in dtList.Rows)
            {
                int LPFMST_ID = int.Parse(row["LPFMST_ID"].ToString());
                string LPFMST_FromDate = row["LPFMST_FromDate"].ToString();
                string LPFMST_ToDate = row["LPFMST_ToDate"].ToString();
                int LPFMST_FromGraceDays = int.Parse(row["LPFMST_FromGraceDays"].ToString());
                int LPFMST_AfterGraceDays = int.Parse(row["LPFMST_AfterGraceDays"].ToString());
                decimal LPFMST_Amt = decimal.Parse(row["LPFMST_Amt"].ToString());
                string LPFMST_RowStatus = row["LPFMST_RowStatus"].ToString();

                list.Add(new CORLatePaymentFineList(LPFMST_ID, LPFMST_FromDate, LPFMST_ToDate, LPFMST_FromGraceDays, LPFMST_AfterGraceDays, LPFMST_Amt, LPFMST_RowStatus, LPFMSTCount));
            }
            return list;
        }

        public CORLatePaymentFine GetCORLatePaymentFine(int CORLatePaymentFineid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [Usp_CORLatePaymentFineMaster_Select] " + CORLatePaymentFineid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int LPFMST_ID = Convert.ToInt32(row["LPFMST_ID"]);
            string LPFMST_FromDate = Convert.ToString(row["LPFMST_FromDate"]);
            string LPFMST_ToDate = Convert.ToString(row["LPFMST_ToDate"]);
            int LPFMST_FromGraceDays = Convert.ToInt32(row["LPFMST_FromGraceDays"]);
            int LPFMST_AfterGraceDays = Convert.ToInt32(row["LPFMST_AfterGraceDays"]);
            decimal LPFMST_Amt = Convert.ToInt32(row["LPFMST_Amt"]);
            int LPFMST_CreatedByUserID = Convert.ToInt32(row["LPFMST_CreatedByUserID"]);
            string LPFMST_CreatedDateTime = Convert.ToString(row["LPFMST_CreatedDateTime"]);
            int LPFMST_UpdatedByUserID = Convert.ToInt32(row["LPFMST_UpdatedByUserID"]);
            string LPFMST_UpdatedDateTime = Convert.ToString(row["LPFMST_UpdatedDateTime"]);
            int LPFMST_RowStatus = Convert.ToInt32(row["LPFMST_RowStatus"]);
            long LPFMST_RowVersion = long.Parse(row["LPFMST_RowVersion"].ToString());
            #endregion

            return new
            CORLatePaymentFine(LPFMST_ID, LPFMST_FromDate, LPFMST_ToDate, LPFMST_FromGraceDays, LPFMST_AfterGraceDays, LPFMST_Amt, LPFMST_CreatedByUserID, LPFMST_CreatedDateTime, LPFMST_UpdatedByUserID, LPFMST_UpdatedDateTime, LPFMST_RowStatus, LPFMST_RowVersion);
        }

        public CORLatePaymentFineMsg InsertCORLatePaymentFine(CORLatePaymentFine LatePaymentFine, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [usp_CORLatePaymentFineMaster_Insert] ");
            sql.Append("'" + LatePaymentFine.LPFMST_FromDate + "',");
            sql.Append("'" + LatePaymentFine.LPFMST_ToDate + "',");
            sql.Append(LatePaymentFine.LPFMST_FromGraceDays + ",");
            sql.Append(LatePaymentFine.LPFMST_AfterGraceDays + ",");
            sql.Append(LatePaymentFine.LPFMST_Amt + ",");
            sql.Append(LatePaymentFine.LPFMST_CreatedByUserID + ",");
            sql.Append(LatePaymentFine.LPFMST_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORLatePaymentFineMsg(_RetVal, _RetStr);
        }

        public CORLatePaymentFineMsg UpdateCORLatePaymentFine(CORLatePaymentFine CORLatePaymentFine, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORLatePaymentFineMaster_Update ");
            sql.Append(CORLatePaymentFine.LPFMST_ID + ",");
            sql.Append("'" + CORLatePaymentFine.LPFMST_FromDate + "',");
            sql.Append("'" + CORLatePaymentFine.LPFMST_ToDate + "',");
            sql.Append(CORLatePaymentFine.LPFMST_FromGraceDays + ",");
            sql.Append(CORLatePaymentFine.LPFMST_AfterGraceDays + ",");
            sql.Append(CORLatePaymentFine.LPFMST_Amt + ",");
            sql.Append(CORLatePaymentFine.LPFMST_UpdatedByUserID + ",");
            sql.Append(CORLatePaymentFine.LPFMST_RowStatus + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORLatePaymentFineMsg(_RetVal, _RetStr);
        }

        public CORLatePaymentFineMsg DeleteCORLatePaymentFine(int CORLatePaymentFineID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORLatePaymentFineMaster_Delete " + CORLatePaymentFineID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORLatePaymentFineMsg(_RetVal, _RetStr);
        }

    }
}
