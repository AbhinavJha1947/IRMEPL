using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces.Core
{
    public interface ICORCompanyMasterService
    {
        public IList<CORCompanyMasterList> GetCORCompanyMasters();
        public IList<CORCompanyMasterList> GetCORCompanyMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
        public CORCompanyMaster GetCORCompanyMaster(int CORCompanyMasterId);
        public CORCompanyMasterMsg AddCORCompanyMaster(CORCompanyMaster corcompanymaster, ref SqlConnection cn, ref SqlTransaction trn);

        public CORCompanyMasterMsg UpdateCORCompanyMaster(CORCompanyMaster corcompanymaster, ref SqlConnection cn, ref SqlTransaction trn);

        public CORCompanyMasterMsg DeleteCORCompanyMaster(int corcompanymasterId, ref SqlConnection cn, ref SqlTransaction trn);
        

    }
}
