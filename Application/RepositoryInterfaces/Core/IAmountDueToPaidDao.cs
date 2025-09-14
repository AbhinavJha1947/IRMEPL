using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces.Core
{
    public interface IAmountDueToPaidDao
    {
        public AmountDueToPaid GetAmountDueToPaid(int receipttype, int headid, decimal Applicationid, int corporate, ref SqlConnection cn, ref SqlTransaction trn);

        public AmountDueToPaid GetAmountDueToPaid(int receipttype, int headid, decimal Applicationid, int corporate, string chequeNo);

    }
}
