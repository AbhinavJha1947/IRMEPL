using Core.Entities.User;

namespace Application.Interfaces.User
{
    public interface ICORScreenMasterService
    {
            IList<CORScreenMasterList> GetCORScreenMasters();

            IList<CORScreenMasterList> GetCORScreenMasters(int USERID, string criteria);


        
    }
}

