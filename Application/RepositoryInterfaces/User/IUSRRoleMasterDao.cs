using Core.Entities.User;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces.User
{
    public interface IUSRRoleMasterDao
    {
        
        public IList<USRRoleMasterList> GetUSRRoleMasters();
        public IList<USRRoleMasterList> GetUSRRoleMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
        public USRRoleMaster GetUSRRoleMaster(int USRRoleMasterid);
        public USRRoleMasterMsg InsertUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public USRRoleMasterMsg UpdateUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public int DeleteUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn);
    }
}
