using Core.Entities.User;

namespace Application.Interfaces.User
{
    public interface IUSRRoleHDRMSTService
    {
        IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs();
        IList<USRRoleHDRMSTList> GetUSRRoleHDRMSTs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria);

        USRRoleHDRMST GetUSRRoleHDRMST(int USRRoleHDRMSTId);
        USRRoleHDRMSTMsg InsertUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst);
        USRRoleHDRMSTMsg UpdateUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst);
        USRRoleHDRMSTMsg DeleteUSRRoleHDRMST(USRRoleHDRMST usrrolehdrmst);

    }
}



