using Core.Entities.User;
using Microsoft.Data.SqlClient;

namespace Application.Interfaces.User
{
    public interface ICORPrivilegeMasterService
    {
            IList<CORPrivilegeMasterList> GetCORPrivilegeMasters();
            IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria);
            IList<CORPrivilegeMasterList> GetCORPrivilegeMasters(string criteria, ref SqlConnection cn, ref SqlTransaction trn);
            CORPrivilegeMaster GetCORPrivilegeMaster(int CORPrivilegeMasterId, ref SqlConnection cn, ref SqlTransaction trn);
            void InsertCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection cn, ref SqlTransaction trn);
            void DeleteCORPrivilegeMaster(CORPrivilegeMaster CORPrivilegeMaster, ref SqlConnection cn, ref SqlTransaction trn);
            IList<USRFunctionalityRights> GetFunctionalityRights();
            IList<USRFunctionalityRights> GetFunctionalityRights(int userid, string FormName);
        
    }
}

