using Application.RepositoryInterfaces.Core;
using Application.ServiceInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Core
{
    public class CORCenterMasterService : ICORCenterMasterService
    {
        private readonly ICORCenterMasterDao _CORCenterMasterDao;

        public CORCenterMasterService(ICORCenterMasterDao CORCenterMasterDao)
        {
            _CORCenterMasterDao = CORCenterMasterDao;
        }
        public IList<CORCenterMasterList> GetCORCenterMasters()
        {
            return _CORCenterMasterDao.GetCORCenterMasters();
        }
        public IList<CORCenterMasterList> GetCORCenterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            return _CORCenterMasterDao.GetCORCenterMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }
        public IList<CORCenterMasterList> GetCORCenterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection cn, ref SqlTransaction trn)
        {
            return _CORCenterMasterDao.GetCORCenterMasters(sortExpression, sortType, pageIndex, pageSize, criteria, ref cn, ref trn);
        }
        public CORCenterMaster GetCORCenterMaster(int CORCenterMasterCode)
        {
            // Retrieve CORCenterMaster
            CORCenterMaster corcentermaster = _CORCenterMasterDao.GetCORCenterMaster(CORCenterMasterCode);

            return corcentermaster;
        }
        public CORCenterMasterMsg AddCORCenterMaster(CORCenterMaster corcentermaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            CORCenterMasterMsg CORCenterMasterMsg = _CORCenterMasterDao.InsertCORCenterMaster(corcentermaster, ref cn, ref trn);

            return CORCenterMasterMsg;

        }
        public CORCenterMasterMsg UpdateCORCenterMaster(CORCenterMaster corcentermaster, ref SqlConnection cn, ref SqlTransaction trn)
        {
            CORCenterMasterMsg CORCenterMasterMsg = _CORCenterMasterDao.UpdateCORCenterMaster(corcentermaster, ref cn, ref trn);

            return CORCenterMasterMsg;

        }
        public CORCenterMasterMsg DeleteCORCenterMaster(int CORCenterMasterCode, ref SqlConnection cn, ref SqlTransaction trn)
        {

            CORCenterMasterMsg CORCenterMasterMsg = _CORCenterMasterDao.DeleteCORCenterMaster(CORCenterMasterCode, ref cn, ref trn);

            return CORCenterMasterMsg;

        }


    }
}
