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
    public interface IUSRUserMasterDao
    {
       
        public IList<USRUserMasterList> GetUSRUserMasters();
        public IList<USRUserMasterforgetMsg> GetUSRUserMasters_forget();

        public IList<USRUserMasterforgetMsg> GetUSRUserMasters_forget(string criteria);
        public IList<USRUserMasterList> GetUSRUserMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
        public USRUserMaster GetUSRUserMaster(int USRUserMasterid);
        public USRUserMasterMsg InsertUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public USRUserMasterMsg UpdateUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public USRUserMasterMsg UpdatePasswordUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public USRUserMasterMsg DeleteUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection objCon, ref SqlTransaction trn);
    }
}
