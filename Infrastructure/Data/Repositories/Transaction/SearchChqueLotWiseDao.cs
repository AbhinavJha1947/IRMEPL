using Application.RepositoryInterfaces.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class SearchChqueLotWiseDao : ISearchChqueLotWiseDao
    {
        private readonly DbManager _dbManager;

        public SearchChqueLotWiseDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
    }
}
