using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Application.Services.User
{
    public class USRUserRoleMasterService : IUSRUserRoleMasterService
    {
        private readonly IUSRUserRoleMasterDao _USRUserRoleMasterDao;

        public USRUserRoleMasterService(IUSRUserRoleMasterDao USRUserRoleMasterDao)
        {
            _USRUserRoleMasterDao = USRUserRoleMasterDao;
        }
        public IList<USRUserRoleMasterList> GetUSRUserRoleMasters()
        {
            return _USRUserRoleMasterDao.GetUSRUserRoleMasters();
        }
        public IList<USRUserRoleMasterList> GetUSRUserRoleMasters(string criteria)
        {
            return _USRUserRoleMasterDao.GetUSRUserRoleMasters(criteria);
        }

        public USRUserRoleMaster GetUSRUserRoleMaster(int USRUserRoleMasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRUserRoleMaster usruserrolemaster = _USRUserRoleMasterDao.GetUSRUserRoleMaster(USRUserRoleMasterId, ref cn, ref trn);

            return usruserrolemaster;
        }

        public void InsertUSRUserRoleMaster(USRUserRoleMaster usruserrolemaster, ref SqlConnection cn, ref SqlTransaction trn)
        {

            _USRUserRoleMasterDao.InsertUSRUserRoleMaster(usruserrolemaster, ref cn, ref trn);
        }

        public void UpdateUSRUserRoleMaster(USRUserRoleMaster usruserrolemaster, ref SqlConnection cn, ref SqlTransaction trn)
        {

            _USRUserRoleMasterDao.UpdateUSRUserRoleMaster(usruserrolemaster, ref cn, ref trn);
        }

        public void DeleteUSRUserRoleMaster(int usruserrolemasterId, ref SqlConnection cn, ref SqlTransaction trn)
        {
            _USRUserRoleMasterDao.DeleteUSRUserRoleMaster(usruserrolemasterId, ref cn, ref trn);
        }
    }
}




