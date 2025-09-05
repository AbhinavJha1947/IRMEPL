using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces.User
{
    public interface ICORFunctionalityHDRMSTDao
    {
        public IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs();
        public IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs(string criteria);
    }
}
