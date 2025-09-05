using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces.User
{
    public interface IUSRRoleHDRMSTDao
    {

        public IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs();
        public IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);
       
        public USRRoleHDRMST GetUSRRoleHDRMST(int USRRoleHDRMSTId);

        public USRRoleHDRMSTMsg InsertUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst);
        
        public USRRoleHDRMSTMsg UpdateUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst);
        
        public USRRoleHDRMSTMsg DeleteUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst);

    }
}
