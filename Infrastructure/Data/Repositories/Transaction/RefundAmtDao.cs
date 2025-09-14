using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class RefundAmtDao : IRefundAmtDao
    {
        private readonly DbManager _dbManager;

        public RefundAmtDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public RefundAmt GetAmount(decimal Applicationid, int Refund)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_GetRefundAmount " + Applicationid + ",");
            sql.Append(Refund + " ");

            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal AmountDue = Convert.ToDecimal(row["amtdue"]);


            #endregion

            return new
            RefundAmt(AmountDue);
        }

    }
}
