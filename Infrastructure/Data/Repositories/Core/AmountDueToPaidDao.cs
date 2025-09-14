using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class AmountDueToPaidDao : IAmountDueToPaidDao
    {
        private readonly DbManager _dbManager;

        public AmountDueToPaidDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public AmountDueToPaid GetAmountDueToPaid(int receipttype, int headid, decimal Applicationid, int corporate, ref SqlConnection cn, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_getDueReceiptAmount " + receipttype + ",");
            sql.Append(headid + ",");
            sql.Append(Applicationid + ",");
            sql.Append(corporate + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref cn, ref trn);

            #region"Variables Declaration"
            decimal AmountDue = Convert.ToDecimal(row["DueAmt"]);
            int TariffID = Convert.ToInt32(row["TariffID"]);
            #endregion

            return new AmountDueToPaid(AmountDue, TariffID);
        }

        public AmountDueToPaid GetAmountDueToPaid(int receipttype, int headid, decimal Applicationid, int corporate, string chequeNo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_getDueReceiptAmount " + receipttype + ",");
            sql.Append(headid + ",");
            sql.Append(Applicationid + ",");
            sql.Append(corporate + ",");
            sql.Append("'" + chequeNo + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"
            decimal AmountDue = Convert.ToDecimal(row["DueAmt"]);
            int TariffID = Convert.ToInt32(row["TariffID"]);
            #endregion

            return new AmountDueToPaid(AmountDue, TariffID);
        }
    }
}
