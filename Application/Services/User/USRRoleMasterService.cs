using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Application.Services.User
{
    public class USRRoleMasterService : IUSRRoleMasterService
    {
        private readonly IUSRRoleMasterDao _USRRoleMasterDao;

        public USRRoleMasterService(IUSRRoleMasterDao USRRoleMasterDao)
        {
            _USRRoleMasterDao = USRRoleMasterDao;
        }
        public IList<USRRoleMasterList> GetUSRRoleMasters()
            {
                return _USRRoleMasterDao.GetUSRRoleMasters();
            }

            public IList<USRRoleMasterList> GetUSRRoleMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
            {
                return _USRRoleMasterDao.GetUSRRoleMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
            }

            public USRRoleMaster GetUSRRoleMaster(int USRRoleMasterId)
            {
                // Retrieve USRRoleMaster
                USRRoleMaster usrrolemaster = _USRRoleMasterDao.GetUSRRoleMaster(USRRoleMasterId);

                return usrrolemaster;
            }
            public USRRoleMasterMsg AddUSRRoleMaster(USRRoleMaster usrrolemaster, ref SqlConnection cn, ref SqlTransaction trn)
            {
                USRRoleMasterMsg USRRoleMasterMsg = _USRRoleMasterDao.InsertUSRRoleMaster(usrrolemaster, ref cn, ref trn);
                return USRRoleMasterMsg;
            }
            public USRRoleMasterMsg UpdateUSRRoleMaster(USRRoleMaster usrrolemaster, ref SqlConnection cn, ref SqlTransaction trn)
            {
                USRRoleMasterMsg USRRoleMasterMsg = _USRRoleMasterDao.UpdateUSRRoleMaster(usrrolemaster, ref cn, ref trn);
                return USRRoleMasterMsg;
            }

            public int DeleteUSRRoleMaster(int usrrolemasterId, ref SqlConnection cn, ref SqlTransaction trn)
            {
                USRRoleMaster USRRoleMaster = _USRRoleMasterDao.GetUSRRoleMaster(usrrolemasterId);
                int rowsAffected = 0;
                rowsAffected = _USRRoleMasterDao.DeleteUSRRoleMaster(USRRoleMaster, ref cn, ref trn);
                return rowsAffected;
            }

        USRRoleMasterMsg IUSRRoleMasterService.InsertUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            throw new NotImplementedException();
        }

        int IUSRRoleMasterService.DeleteUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            throw new NotImplementedException();
        }
    }
}






