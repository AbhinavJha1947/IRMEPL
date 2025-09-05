using Core.Entities.User;
using Microsoft.Data.SqlClient;

namespace Application.Interfaces.User
{
    public interface IUSRUserMasterService
    {
            IList<USRUserMasterList> GetUSRUserMasters();

            IList<USRUserMasterList> GetUSRUserMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);

            IList<USRUserMasterforgetMsg> GetUSRUserMasters_forget(string sortExpression);

            USRUserMaster GetUSRUserMaster(int USRUserMasterId);

            USRUserMasterMsg InsertUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection cn, ref SqlTransaction trn);

            USRUserMasterMsg UpdateUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection cn, ref SqlTransaction trn);
            USRUserMasterMsg UpdatePasswordUSRUserMaster(USRUserMaster USRUserMaster, ref SqlConnection cn, ref SqlTransaction trn);
            USRUserMasterMsg DeleteUSRUserMaster(int usrusermasterId, ref SqlConnection cn, ref SqlTransaction trn);
        
    }
}

