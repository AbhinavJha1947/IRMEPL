using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces.Core
{
    public interface IControlDetailMasterDao
    {
        public IList<ControlDetailMasterList> GetControlDetailMasters();

        public IList<ControlDetailMasterList> GetControlDetailMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
        public IList<ControlHeaderMasterList> GetControlHeaderMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
        public ControlDetailMaster GetControlDetailMaster(int Controlid);
        public ControlDetailMasterMsg InsertControlDetailMaster(ControlDetailMaster control_detail);
        public ControlDetailMasterMsg UpdateControlDetailMaster(ControlDetailMaster control_detail);
        public ControlDetailMasterMsg DeleteControlDetailMaster(int Controlid);
        
    }
}
