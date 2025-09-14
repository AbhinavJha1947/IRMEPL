using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces.Core
{
    public interface ITarrifFromPlanDao
    {
        public TarrifFromPlan GetTarrifFromPlan(decimal Applicationid, int centercode, int receipttye);
    }
}
