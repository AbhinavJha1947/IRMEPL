using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class TarrifFromPlanDao : ITarrifFromPlanDao
    {
        private readonly DbManager _dbManager;

        public TarrifFromPlanDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public TarrifFromPlan GetTarrifFromPlan(decimal Applicationid, int centercode, int receipttye)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_GetDueAmount " + Applicationid + ",");
            sql.Append(centercode + ",");
            sql.Append(receipttye + "");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal AmountDue = Convert.ToInt32(row["TDLMST_Amount"]);
            // int TPDMSTPlanID = Convert.ToInt32(row["TPDMST_PlanID"]);

            #endregion

            return new
            TarrifFromPlan(AmountDue);
        }

    }
}
