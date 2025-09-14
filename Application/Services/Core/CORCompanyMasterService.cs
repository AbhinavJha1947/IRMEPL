using Application.RepositoryInterfaces.Core;
using Application.ServiceInterfaces.Core;
using Core.Entities.Core;
using System.Data.SqlClient;

namespace Application.Services.Core
{
    public class CORCompanyMasterService : ICORCompanyMasterService
    {

        private readonly ICORCompanyMasterDao _CORCompanyMasterDao;

        public CORCompanyMasterService(ICORCompanyMasterDao CORCompanyMasterDao)
        {
            _CORCompanyMasterDao = CORCompanyMasterDao;
        }
        public IList<CORCompanyMasterList> GetCORCompanyMasters()
        {
            return _CORCompanyMasterDao.GetCORCompanyMasters();
        }

        public IList<CORCompanyMasterList> GetCORCompanyMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            return _CORCompanyMasterDao.GetCORCompanyMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public CORCompanyMaster GetCORCompanyMaster(int CORCompanyMasterId)
        {
            CORCompanyMaster corcompanymaster = _CORCompanyMasterDao.GetCORCompanyMaster(CORCompanyMasterId);

            return corcompanymaster;
        }
        public CORCompanyMasterMsg AddCORCompanyMaster(CORCompanyMaster corcompanymaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
           
                CORCompanyMasterMsg CORCompanyMasterMsg = _CORCompanyMasterDao.InsertCORCompanyMaster(corcompanymaster, ref cn, ref trn);
                return CORCompanyMasterMsg;
            
        }

        public CORCompanyMasterMsg UpdateCORCompanyMaster(CORCompanyMaster corcompanymaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
           
                CORCompanyMasterMsg CORCompanyMasterMsg = _CORCompanyMasterDao.UpdateCORCompanyMaster(corcompanymaster, ref cn, ref trn);
                return CORCompanyMasterMsg;
            
        }

        public CORCompanyMasterMsg DeleteCORCompanyMaster(int corcompanymasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            
                CORCompanyMasterMsg CORCompanyMasterMsg = _CORCompanyMasterDao.DeleteCORCompanyMaster(corcompanymasterId, ref cn, ref trn);
                return CORCompanyMasterMsg;
            
        }

    }
}
