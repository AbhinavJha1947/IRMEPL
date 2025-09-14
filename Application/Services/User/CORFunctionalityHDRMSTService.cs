using Application.Interfaces.User;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Application.Services.User
{
    public class CORFunctionalityHDRMSTService : ICORFunctionalityHDRMSTService
    {
            private readonly ICORFunctionalityHDRMSTDao _corfunctionalityhdrmstDao;

            public CORFunctionalityHDRMSTService(ICORFunctionalityHDRMSTDao corfunctionalityhdrmstDao)
            {
            _corfunctionalityhdrmstDao = corfunctionalityhdrmstDao;
            }

        public IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs()
        {
            return _corfunctionalityhdrmstDao.GetCORFunctionalityHDRMSTs();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public IList<CORFunctionalityHDRMSTList> GetCORFunctionalityHDRMSTs(string criteria)
        {
            return _corfunctionalityhdrmstDao.GetCORFunctionalityHDRMSTs(criteria);
        }

    }
}







