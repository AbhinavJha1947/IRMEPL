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
    public interface ICORPrivilegeMasterDao
    {
        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters();
        public IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria);
        public  IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria, ref SqlConnection cn, ref SqlTransaction trn);
        public CORPrivilegeMaster GetCORPrivilegeMaster(int CORPrivilegeMasterid, ref SqlConnection objCon, ref SqlTransaction trn);
        public void InsertCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection objCon, ref SqlTransaction trn);

        public void DeleteCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection objCon, ref SqlTransaction trn);
        public IList<USRFunctionalityRights> GetFunctionalityRights();
        public IList<USRFunctionalityRights> GetFunctionalityRights(int userid, string FormName);
        

    }
}
