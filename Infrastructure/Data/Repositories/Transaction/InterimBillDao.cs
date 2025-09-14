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
    public class InterimBillDao : IInterimBillDao
    {
        private readonly DbManager _dbManager;

        public InterimBillDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public ApplicationDetails GetApplicationDetails(string CustomerId, int CenId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC GET_InterimBill_Details ");
            sql.Append(CustomerId + ",");
            sql.Append(CenId);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            string BCCMST_ShortName = row["BCCMST_ShortName"].ToString();
            string BCCMST_StartDate = row["BCCMST_StartDate"].ToString();
            string BCCMST_EndDate = row["BCCMST_EndDate"].ToString();
            string METTRN_MeterNo = row["METTRN_MeterNo"].ToString();
            string METTRN_ReadingDate = row["METTRN_ReadingDate"].ToString();
            string METTRN_CurrentReading = row["METTRN_CurrentReading"].ToString();
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
            string PLAMST_PlanName = row["PLAMST_PlanName"].ToString();
            string CD_ControlType = row["CD_ControlType"].ToString();
            string Name = row["Name"].ToString();
            string Address = row["Address"].ToString();

            #endregion

            return
                new
             ApplicationDetails(BCCMST_ShortName, BCCMST_StartDate, BCCMST_EndDate, METTRN_MeterNo, METTRN_ReadingDate, METTRN_CurrentReading, APPMST_AppNo, APPMST_AppID, PLAMST_PlanName, CD_ControlType, Name, Address);
        }
    }
}

