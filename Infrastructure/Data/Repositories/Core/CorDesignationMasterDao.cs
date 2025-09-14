using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class CorDesignationMasterDao : ICorDesignationMasterDao
    {
        private readonly DbManager _dbManager;

        public CorDesignationMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CorDesignationMasterList> GetCorDesignationMasters()
        {
            string sortExpression = "DESI_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCorDesignationMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CorDesignationMasterList> GetCorDesignationMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            if (sortExpression == "CSM")
                sql.Append("EXEC USP_CSMDesignationMaster_SelectAll ");
            else
                sql.Append("EXEC USP_CorDesignationMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'DESI_ID',");
            }
            else
            {
                sql.Append("'" + sortExpression + "',");
            }
            //String Building for Sorintg Type
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append("'ASC',");
            }
            else
            {
                sql.Append("'" + sortType + "',");
            }
            //String Building for Page Index
            sql.Append(pageIndex + ",");
            sql.Append(pageSize + ",'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CorDesignationMasterList> list = new List<CorDesignationMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int DESI_ID = int.Parse(row["DESI_ID"].ToString());
                string DESI_Name = row["DESI_Name"].ToString();
                list.Add(new CorDesignationMasterList(DESI_ID, DESI_Name, Count));
            }
            return list;
        }

    }
}
