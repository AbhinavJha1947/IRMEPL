using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces.Core
{
    public interface IControlDetailMasterService
    {
        public IList<ControlDetailMasterList> GetControl_Details();

        public IList<ControlDetailMasterList> GetControlDetailMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);

        public IList<ControlHeaderMasterList> GetControlHeaderMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);


        public ControlDetailMaster GetControlDetailMaster(int control_detailId);

        public ControlDetailMasterMsg AddControlDetailMaster(ControlDetailMaster control_detail);

        public ControlDetailMasterMsg UpdateControlDetailMaster(ControlDetailMaster control_detail);


        public ControlDetailMasterMsg DeleteControlDetailMaster(int control_detailId);
        

    }
}
