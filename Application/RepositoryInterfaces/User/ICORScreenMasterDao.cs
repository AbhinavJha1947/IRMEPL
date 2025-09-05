using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces.User
{
    public interface ICORScreenMasterDao
    {
        public IList<CORScreenMasterList> GetCORScreenMasters();
        public IList<CORScreenMasterList> GetCORScreenMasters(int USERID, string criteria);
    }
}
