using Application.RepositoryInterfaces.Core;
using Application.ServiceInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Core
{
    public class ControlDetailMasterService : IControlDetailMasterService
    {
        private readonly IControlDetailMasterDao _ControlDetailMasterDao;

        public ControlDetailMasterService(IControlDetailMasterDao ControlDetailMasterDao)
        {
            _ControlDetailMasterDao = ControlDetailMasterDao;
        }

        public IList<ControlDetailMasterList> GetControl_Details()
        {
            return _ControlDetailMasterDao.GetControlDetailMasters();
        }
        public IList<ControlDetailMasterList> GetControlDetailMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            return _ControlDetailMasterDao.GetControlDetailMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ControlHeaderMasterList> GetControlHeaderMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            return _ControlDetailMasterDao.GetControlHeaderMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }
        public ControlDetailMaster GetControlDetailMaster(int control_detailId)
        {
            ControlDetailMaster controldetailmaster = _ControlDetailMasterDao.GetControlDetailMaster(control_detailId);

            return controldetailmaster;
        }
        public ControlDetailMasterMsg AddControlDetailMaster(ControlDetailMaster control_detail)
        {
            ControlDetailMasterMsg ControlDetailMasterMsg = _ControlDetailMasterDao.InsertControlDetailMaster(control_detail);
            return ControlDetailMasterMsg;
        }
        public ControlDetailMasterMsg UpdateControlDetailMaster(ControlDetailMaster control_detail)
        {
            ControlDetailMasterMsg ControlDetailMasterMsg = _ControlDetailMasterDao.UpdateControlDetailMaster(control_detail);
            return ControlDetailMasterMsg;
        }

        public ControlDetailMasterMsg DeleteControlDetailMaster(int control_detailId)
        {
            ControlDetailMasterMsg ControlDetailMasterMsg = _ControlDetailMasterDao.DeleteControlDetailMaster(control_detailId);
            return ControlDetailMasterMsg;
        }

    }
}
