using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces.Core
{
    public interface ICORCompanyMasterDao
    {
        public IList<CORCompanyMasterList> GetCORCompanyMasters();
        public IList<CORCompanyMasterList> GetCORCompanyMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
        public CORCompanyMaster GetCORCompanyMaster(int CORCompanyMasterid);
        public CORCompanyMasterMsg InsertCORCompanyMaster(CORCompanyMaster CORCompanyMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public CORCompanyMasterMsg UpdateCORCompanyMaster(CORCompanyMaster CORCompanyMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public CORCompanyMasterMsg DeleteCORCompanyMaster(int CORCompanyMasterID, ref SqlConnection objCon, ref SqlTransaction trn);
    }
}
