using Core.Entities.User;
using Microsoft.Data.SqlClient;

namespace Application.Interfaces.User
{
    public interface ICORFunctionalityHDRMSTService
    {
            IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs();

            IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs(string criteria);

        
    }
}

