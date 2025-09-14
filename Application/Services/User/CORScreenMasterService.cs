using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Application.Services.User
{
    public class CORScreenMasterService : ICORScreenMasterService
    {
        private readonly ICORScreenMasterDao _corscreenmasterDao;

        public CORScreenMasterService(ICORScreenMasterDao corscreenmasterDao)
        {
            _corscreenmasterDao = corscreenmasterDao;
        }
        public IList<CORScreenMasterList> GetCORScreenMasters()
        {
            return _corscreenmasterDao.GetCORScreenMasters();
        }
        public IList<CORScreenMasterList> GetCORScreenMasters(int USERID, string criteria)
        {
            return _corscreenmasterDao.GetCORScreenMasters(USERID, criteria);
        }

    }
}






