using Application.RepositoryInterfaces.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class ReportDao : IReportDao
    {
        private readonly DbManager _dbManager;

        public ReportDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
    }
}
