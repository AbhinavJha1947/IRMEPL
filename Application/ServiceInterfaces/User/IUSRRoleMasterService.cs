using Core.Entities.User;
using System.Data.SqlClient;

namespace Application.Interfaces.User
{
    public interface IUSRRoleMasterService
    {
            IList<USRRoleMasterList> GetUSRRoleMasters();

            IList<USRRoleMasterList> GetUSRRoleMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);

            USRRoleMaster GetUSRRoleMaster(int USRRoleMasterId);

            USRRoleMasterMsg InsertUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection cn, ref SqlTransaction trn);

            USRRoleMasterMsg UpdateUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection cn, ref SqlTransaction trn);

            int DeleteUSRRoleMaster(USRRoleMaster USRRoleMaster, ref SqlConnection cn, ref SqlTransaction trn);
        
    }
}

