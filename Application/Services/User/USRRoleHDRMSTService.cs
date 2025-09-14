using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Application.Services.User
{
    public class USRRoleHDRMSTService : IUSRRoleHDRMSTService
    {
        private readonly IUSRRoleHDRMSTDao _USRRoleHDRMSTDao;

        public USRRoleHDRMSTService(IUSRRoleHDRMSTDao USRRoleHDRMSTDao)
        {
            _USRRoleHDRMSTDao = USRRoleHDRMSTDao;
        }
        public IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs()
        {
            return _USRRoleHDRMSTDao.GetUSRRoleHDRMSTs();
        }

        public IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            return _USRRoleHDRMSTDao.GetUSRRoleHDRMSTs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public USRRoleHDRMST GetUSRRoleHDRMST(int USRRoleHDRMSTId)
        {
            USRRoleHDRMST usrrolehdrmst = _USRRoleHDRMSTDao.GetUSRRoleHDRMST(USRRoleHDRMSTId);

            return usrrolehdrmst;
        }

        public USRRoleHDRMSTMsg AddUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRRoleHDRMSTMsg USRRoleHDRMSTMsg = _USRRoleHDRMSTDao.InsertUSRRoleHDRMST(usrrolehdrmst);
            return USRRoleHDRMSTMsg;
        }

        public USRRoleHDRMSTMsg UpdateUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst, ref SqlConnection cn, ref SqlTransaction trn)
        {
            USRRoleHDRMSTMsg USRRoleHDRMSTMsg = _USRRoleHDRMSTDao.UpdateUSRRoleHDRMST(usrrolehdrmst);
            return USRRoleHDRMSTMsg;
        }

        public USRRoleHDRMSTMsg DeleteUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
        {
            USRRoleHDRMSTMsg USRRoleHDRMSTMsg = _USRRoleHDRMSTDao.DeleteUSRRoleHDRMST(usrrolehdrmst);
             return USRRoleHDRMSTMsg;
        }

        USRRoleHDRMSTMsg IUSRRoleHDRMSTService.InsertUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
        {
            throw new NotImplementedException();
        }

        USRRoleHDRMSTMsg IUSRRoleHDRMSTService.UpdateUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst)
        {
            throw new NotImplementedException();
        }
    }
}







