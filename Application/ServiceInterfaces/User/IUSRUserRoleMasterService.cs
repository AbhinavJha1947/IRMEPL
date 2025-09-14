using Core.Entities.User;
using System.Data.SqlClient;

namespace Application.Interfaces.User
{
    public interface IUSRUserRoleMasterService
    {
            IList<USRUserRoleMasterList> GetUSRUserRoleMasters();

            IList<USRUserRoleMasterList> GetUSRUserRoleMasters(string criteria);

            USRUserRoleMaster GetUSRUserRoleMaster(int USRUserRoleMasterId, ref SqlConnection cn, ref SqlTransaction trn);

            void InsertUSRUserRoleMaster(USRUserRoleMaster USRUserRoleMaster, ref SqlConnection cn, ref SqlTransaction trn);
            void UpdateUSRUserRoleMaster(USRUserRoleMaster USRUserRoleMaster, ref SqlConnection cn, ref SqlTransaction trn);
            void DeleteUSRUserRoleMaster(int USRUserRoleMasterId, ref SqlConnection cn, ref SqlTransaction trn);
        
    }
}

