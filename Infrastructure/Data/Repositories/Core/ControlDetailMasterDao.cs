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
    public class ControlDetailMasterDao : IControlDetailMasterDao
    {
        private readonly DbManager _dbManager;

        public ControlDetailMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public IList<ControlDetailMasterList> GetControlDetailMasters()
        {
            string sortExpression = "CD_ControlID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = 10;
            string criteria = "";
            return GetControlDetailMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ControlDetailMasterList> GetControlDetailMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("USP_ControlDetail_SelectAll ");

            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CD_ControlID',");
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

            //String Building for Page Size
            sql.Append(pageSize + ",'");

            //String Building for For Count.
            sql.Append(criteria + "'");

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Controlcount = int.Parse(dtRowCount.Rows[0][0].ToString());

            IList<ControlDetailMasterList> list = new List<ControlDetailMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int Control_ID = int.Parse(row["CD_ControlID"].ToString());
                int CD_CHMID = int.Parse(row["CD_CHMID"].ToString());
                string Control_Type = row["CD_ControlType"].ToString();
                string Enitity_Type = row["CHM_Type"].ToString();
                string Control_Status = row["CD_ControlStatus"].ToString();
                string CD_ControlSeq = row["CD_ControlSeq"].ToString();
                //decimal ITMRTD_Rate =decimal.Parse(row["ITMRTD_Rate"].ToString());

                list.Add(new ControlDetailMasterList(Control_ID, CD_CHMID, Control_Type, Enitity_Type, Control_Status, CD_ControlSeq, Controlcount));
            }
            return list;
        }
        public IList<ControlHeaderMasterList> GetControlHeaderMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("USP_ControlHeader_SelectAll ");

            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CD_CHMID',");
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

            //String Building for Page Size
            sql.Append(pageSize + ",'");

            //String Building for For Count.
            sql.Append(criteria + "'");

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Controlcount = int.Parse(dtRowCount.Rows[0][0].ToString());

            IList<ControlHeaderMasterList> list = new List<ControlHeaderMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CHM_ID = int.Parse(row["CHM_ID"].ToString());
                string Control_Type = row["CHM_Type"].ToString();

                list.Add(new ControlHeaderMasterList(CHM_ID, Control_Type));
            }
            return list;
        }
        public ControlDetailMaster GetControlDetailMaster(int Controlid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("USP_ControlDetail_SelectForUpdate " + Controlid);

            DataRow row = _dbManager.GetDataRow(sql.ToString());


            /// Procedure level Local Variables Declaration.
            #region "Variables Declaration"

            int _Control_Id = int.Parse(row["CD_ControlID"].ToString());
            int _CD_CHMID = int.Parse(row["CD_CHMID"].ToString());
            string _Control_Type = row["CD_ControlType"].ToString();

            string _CD_ControlSeq = row["CD_ControlSeq"].ToString();
            int _Control_Status = Convert.ToBoolean(row["CD_ControlStatus"]) == true ? 1 : 0;

            #endregion

            return new ControlDetailMaster(_Control_Id, _CD_CHMID, _Control_Type, _CD_ControlSeq, _Control_Status);
        }
        public ControlDetailMasterMsg InsertControlDetailMaster(ControlDetailMaster control_detail)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ControlDetail_Insert ");

            sql.Append(control_detail.CD_ControlID + ", ");
            sql.Append(control_detail.CD_CHMID + ", '");
            sql.Append(control_detail.CD_ControlType + "', '");
            sql.Append(control_detail.CD_ControlSeq + "',");
            sql.Append(control_detail.CD_ControlStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region "Variables Declaration"

            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();

            #endregion

            return new ControlDetailMasterMsg(_RetVal, _RetStr);
        }
        public ControlDetailMasterMsg UpdateControlDetailMaster(ControlDetailMaster control_detail)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ControlDetail_UpdateAll ");

            sql.Append(control_detail.CD_ControlID + ", ");
            sql.Append(control_detail.CD_CHMID + ", '");
            sql.Append(control_detail.CD_ControlType + "', '");
            sql.Append(control_detail.CD_ControlSeq + "',");
            sql.Append(control_detail.CD_ControlStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region "Variables Declaration"

            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();

            #endregion

            return new ControlDetailMasterMsg(_RetVal, _RetStr);
        }
        public ControlDetailMasterMsg DeleteControlDetailMaster(int Controlid)
        {
            DataRow row = _dbManager.GetDataRow("EXEC USP_ControlDetail_Delete " + Controlid);
            int _RetVal = int.Parse(row["RetVal"].ToString());
            string _RetStr = row["RetStr"].ToString();
            return new ControlDetailMasterMsg(_RetVal, _RetStr);
        }

    }
}
