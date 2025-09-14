using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces.Core
{
    public interface ICORCenterMasterService
    {
        public IList<CORCenterMasterList> GetCORCenterMasters();

        public IList<CORCenterMasterList> GetCORCenterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);

        public IList<CORCenterMasterList> GetCORCenterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection cn, ref SqlTransaction trn);


        public CORCenterMaster GetCORCenterMaster(int CORCenterMasterCode);

        public CORCenterMasterMsg AddCORCenterMaster(CORCenterMaster corcentermaster, ref SqlConnection cn, ref SqlTransaction trn);

        public CORCenterMasterMsg UpdateCORCenterMaster(CORCenterMaster corcentermaster, ref SqlConnection cn, ref SqlTransaction trn);

        public CORCenterMasterMsg DeleteCORCenterMaster(int CORCenterMasterCode, ref SqlConnection cn, ref SqlTransaction trn);
        

    }
}
