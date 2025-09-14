using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using Application.Interfaces.User;
using Infrastructure.Data.Interfaces.User;

namespace Application.Services.User
{
    public class USRUserMasterService : IUSRUserMasterService
    {
        private readonly IUSRUserMasterDao _USRUserMasterDao;

        public USRUserMasterService(IUSRUserMasterDao USRUserMasterDao)
        {
            _USRUserMasterDao = USRUserMasterDao;
        }
        public IList<USRUserMasterList> GetUSRUserMasters()
        {
            return _USRUserMasterDao.GetUSRUserMasters();
        }

        public IList<USRUserMasterList> GetUSRUserMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            return _USRUserMasterDao.GetUSRUserMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<USRUserMasterforgetMsg> GetUSRUserMasters_Forget(string sortExpression)
        {
            return _USRUserMasterDao.GetUSRUserMasters_forget(sortExpression);
        }

        public USRUserMaster GetUSRUserMaster(int USRUserMasterId)
        {
            USRUserMaster usrusermaster = _USRUserMasterDao.GetUSRUserMaster(USRUserMasterId);

            return usrusermaster;
        }

        public USRUserMasterMsg InsertUSRUserMaster(USRUserMaster usrusermaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRUserMasterMsg USRUserMasterMsg = _USRUserMasterDao.InsertUSRUserMaster(usrusermaster, ref cn, ref trn);
            return USRUserMasterMsg;
        }

        public USRUserMasterMsg UpdateUSRUserMaster(USRUserMaster usrusermaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRUserMasterMsg USRUserMasterMsg = _USRUserMasterDao.UpdateUSRUserMaster(usrusermaster, ref cn, ref trn);
            return USRUserMasterMsg;
        }

        public USRUserMasterMsg UpdatePasswordUSRUserMaster(USRUserMaster usrusermaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRUserMasterMsg USRUserMasterMsg = _USRUserMasterDao.UpdatePasswordUSRUserMaster(usrusermaster, ref cn, ref trn);
            return USRUserMasterMsg;
        }

        public USRUserMasterMsg DeleteUSRUserMaster(int usrusermasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRUserMaster USRUserMaster = _USRUserMasterDao.GetUSRUserMaster(usrusermasterId);

            USRUserMasterMsg USRUserMasterMsg = _USRUserMasterDao.DeleteUSRUserMaster(USRUserMaster, ref cn, ref trn);
            return USRUserMasterMsg;
        }

        IList<USRUserMasterforgetMsg> IUSRUserMasterService.GetUSRUserMasters_forget(string sortExpression)
        {
            throw new NotImplementedException();
        }
    }
}






