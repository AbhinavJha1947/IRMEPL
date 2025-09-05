using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Application.Services.User
{
    public class CORPrivilegeMasterService : ICORPrivilegeMasterService
    {
        private readonly ICORPrivilegeMasterDao _CORPrivilegeMasterDao;

        public CORPrivilegeMasterService(ICORPrivilegeMasterDao corprivilegemasterDao)
        {
            _CORPrivilegeMasterDao = corprivilegemasterDao;
        }
        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters()
        {
            return _CORPrivilegeMasterDao.GetCORPrivilegeMasters();
        }

        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria)
        {
            return _CORPrivilegeMasterDao.GetCORPrivilegeMasters(criteria);
        }
        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria, ref SqlConnection cn, ref SqlTransaction trn)
        {
            return _CORPrivilegeMasterDao.GetCORPrivilegeMasters(criteria, ref cn, ref trn);
        }
        public CORPrivilegeMaster GetCORPrivilegeMaster(int CORPrivilegeMasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            CORPrivilegeMaster corprivilegemaster = _CORPrivilegeMasterDao.GetCORPrivilegeMaster(CORPrivilegeMasterId, ref cn, ref trn);

            return corprivilegemaster;
        }
        public void AddCORPrivilegeMaster(CORPrivilegeMaster corprivilegemaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            _CORPrivilegeMasterDao.InsertCORPrivilegeMaster(corprivilegemaster, ref cn, ref trn);
        }
        public void DeleteCORPrivilegeMaster(CORPrivilegeMaster corprivilegemaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            _CORPrivilegeMasterDao.DeleteCORPrivilegeMaster(corprivilegemaster, ref cn, ref trn);
        }
        public IList<USRFunctionalityRights> GetFunctionalityRights()
        {
            return _CORPrivilegeMasterDao.GetFunctionalityRights();
        }
        public IList<USRFunctionalityRights> GetFunctionalityRights(int userid, string FormName)
        {
            return _CORPrivilegeMasterDao.GetFunctionalityRights(userid, FormName);
        }

        void ICORPrivilegeMasterService.InsertCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            throw new NotImplementedException();
        }
    }
}




