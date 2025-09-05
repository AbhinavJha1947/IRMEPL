using Core.Entities.User;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces.User
{
    public interface IUSRUserRoleMasterDao
    {
        public IList<USRUserRoleMasterList> GetUSRUserRoleMasters();
        public IList<USRUserRoleMasterList> GetUSRUserRoleMasters(string criteria);
        public USRUserRoleMaster GetUSRUserRoleMaster(int USRUserRoleMasterid, ref SqlConnection objCon, ref SqlTransaction trn);
        public void InsertUSRUserRoleMaster(USRUserRoleMaster USRUserRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public void UpdateUSRUserRoleMaster(USRUserRoleMaster USRUserRoleMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public void DeleteUSRUserRoleMaster(int USRUserRoleMasterID, ref SqlConnection objCon, ref SqlTransaction trn);
    }
}
