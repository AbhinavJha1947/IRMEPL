using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.User;
using Infrastructure.Data.Interfaces.User;
using Infrastructure.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces.Core;
namespace Infrastructure.Data.Repositories.Core
{
    public class CORCenterMasterDao : ICORCenterMasterDao
    {
        private readonly DbManager _dbManager;

        public CORCenterMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public IList<CORCenterMasterList> GetCORCenterMasters()
        {
            string sortExpression = "CENMST_CenterCode";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORCenterMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORCenterMasterList> GetCORCenterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORCenterMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CENMST_CenterCode',");
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
            int centercount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORCenterMasterList> list = new List<CORCenterMasterList>();
            foreach (DataRow row in dtList.Rows)
            {

                int CENMST_CenterCode = int.Parse(row["CENMST_CenterCode"].ToString());
                string CENMST_Name = row["CENMST_Name"].ToString();
                string CENMST_CenterPrefix = row["CENMST_CenterPrefix"].ToString();
                string CENMST_Address = row["CENMST_Address"].ToString();
                string StateName = row["StateName"].ToString();
                string CityName = row["CityName"].ToString();
                string CENMST_Phone = row["CENMST_Phone"].ToString();
                int CENMST_PinCode = int.Parse(row["CENMST_PinCode"].ToString());
                string CENMST_Email = row["CENMST_Email"].ToString();
                string CENMST_GSTNoDT = row["CENMST_GSTNoDT"].ToString();
                string CENMST_VATNoDT = row["CENMST_VATNoDT"].ToString();
                string CENMST_Language = Convert.ToString(row["CENMST_Language"].ToString());
                string CENMST_RowStatus = row["CENMST_RowStatus"].ToString();
                //decimal CTSMST_GCV = Convert.ToDecimal(row["CTSMST_GCV"]);
                list.Add(new CORCenterMasterList(CENMST_CenterCode, CENMST_Name, CENMST_CenterPrefix, CENMST_Address, StateName, CityName, CENMST_Phone, CENMST_Email, CENMST_GSTNoDT, CENMST_VATNoDT, CENMST_PinCode, CENMST_Language, CENMST_RowStatus, centercount));
            }
            return list;
        }
        public IList<CORCenterMasterList> GetCORCenterMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORCenterMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CENMST_CenterCode',");
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
            int centercount = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORCenterMasterList> list = new List<CORCenterMasterList>();
            foreach (DataRow row in dtList.Rows)
            {

                int CENMST_CenterCode = int.Parse(row["CENMST_CenterCode"].ToString());
                string CENMST_Name = row["CENMST_Name"].ToString();
                string CENMST_CenterPrefix = row["CENMST_CenterPrefix"].ToString();
                string CENMST_Address = row["CENMST_Address"].ToString();
                string StateName = row["StateName"].ToString();
                string CityName = row["CityName"].ToString();
                string CENMST_Phone = row["CENMST_Phone"].ToString();
                int CENMST_PinCode = int.Parse(row["CENMST_PinCode"].ToString());
                string CENMST_Language = Convert.ToString(row["CENMST_Language"].ToString());
                string CENMST_Email = row["CENMST_Email"].ToString();
                string CENMST_GSTNoDT = row["CENMST_GSTNoDT"].ToString();
                string CENMST_VATNoDT = row["CENMST_VATNoDT"].ToString();
                string CENMST_RowStatus = row["CENMST_RowStatus"].ToString();
                //decimal CTSMST_GCV = 0;
                //if (!string.IsNullOrEmpty(Convert.ToString(row["CTSMST_GCV"])))
                //    CTSMST_GCV = Convert.ToDecimal(row["CTSMST_GCV"]);
                list.Add(new CORCenterMasterList(CENMST_CenterCode, CENMST_Name, CENMST_CenterPrefix, CENMST_Address, StateName, CityName, CENMST_Phone, CENMST_Email, CENMST_GSTNoDT, CENMST_VATNoDT, CENMST_PinCode, CENMST_Language, CENMST_RowStatus, centercount));
            }
            return list;
        }

        public CORCenterMaster GetCORCenterMaster(int CORCenterMasterCode)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORCenterMaster_Select " + CORCenterMasterCode);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int CENMST_CenterCode = Convert.ToInt32(row["CENMST_CenterCode"]);
            string CENMST_Name = Convert.ToString(row["CENMST_Name"]);
            string CENMST_CenterPrefix = Convert.ToString(row["CENMST_CenterPrefix"]);
            int CENMST_City = Convert.ToInt32(row["CENMST_City"]);
            int CENMST_State = Convert.ToInt32(row["CENMST_State"]);
            string State = Convert.ToString(row["State"]);
            string City = Convert.ToString(row["City"]);
            string CTYMST_Name = Convert.ToString(row["CTYMST_Name"]);
            string CENMST_Address = Convert.ToString(row["CENMST_Address"]);
            int CENMST_PinCode = Convert.ToInt32(row["CENMST_PinCode"]);
            string CENMST_Phone = Convert.ToString(row["CENMST_Phone"]);
            string CENMST_Phone2 = Convert.ToString(row["CENMST_Phone2"]);
            string CENMST_Phone3 = Convert.ToString(row["CENMST_Phone3"]);
            string CENMST_Email = Convert.ToString(row["CENMST_Email"]);
            string CENMST_GSTNoDT = Convert.ToString(row["CENMST_GSTNoDT"]);
            string CENMST_VATNoDT = Convert.ToString(row["CENMST_VATNoDT"]);
            int CENMST_CreatedByUserID = Convert.ToInt32(row["CENMST_CreatedByUserID"]);
            string CENMST_CreatedDateTime = Convert.ToString(row["CENMST_CreatedDateTime"]);
            int CENMST_UpdatedByUserID = Convert.ToInt32(row["CENMST_UpdatedByUserID"]);
            string CENMST_UpdatedDateTime = Convert.ToString(row["CENMST_UpdatedDateTime"]);
            int CENMST_Language = Convert.ToInt32(row["CENMST_Language"]);
            string CENMST_Latitude = Convert.ToString(row["CENMST_Latitude"]);
            string CENMST_Longitude = Convert.ToString(row["CENMST_Longitude"]);
            int CENMST_RowStatus = Convert.ToInt32(row["CENMST_RowStatus"]);
            long CENMST_RowVersion = long.Parse(row["CENMST_RowVersion"].ToString());
            string CENMST_OfficeStartTime = Convert.ToString(row["CENMST_OfficeStartTime"]);
            string CENMST_OfficeEndTime = Convert.ToString(row["CENMST_OfficeEndTime"]);
            //decimal CTSMST_GCV = 0;
            //if (!string.IsNullOrEmpty(Convert.ToString(row["CTSMST_GCV"])))
            //    CTSMST_GCV = Convert.ToDecimal(row["CTSMST_GCV"]);

            #endregion

            return new
            CORCenterMaster(CENMST_CenterCode, CENMST_Name, CENMST_CenterPrefix, CENMST_State, CENMST_City, State, City, CTYMST_Name, CENMST_Address, CENMST_PinCode, CENMST_Phone, CENMST_Phone2, CENMST_Phone3, CENMST_Email, CENMST_GSTNoDT, CENMST_VATNoDT, CENMST_CreatedByUserID, CENMST_CreatedDateTime, CENMST_UpdatedByUserID, CENMST_UpdatedDateTime, CENMST_Language, CENMST_Latitude, CENMST_Longitude, CENMST_RowStatus, CENMST_RowVersion, CENMST_OfficeStartTime, CENMST_OfficeEndTime);//, CTSMST_GCV);
        }

        public CORCenterMasterMsg InsertCORCenterMaster(CORCenterMaster CORCenterMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORCenterMaster_Insert '");
            sql.Append(CORCenterMaster.CENMST_Name + "','");
            sql.Append(CORCenterMaster.CENMST_CenterPrefix + "',");
            sql.Append(CORCenterMaster.CENMST_City + ",");
            sql.Append(CORCenterMaster.CENMST_State + ",'");
            sql.Append(CORCenterMaster.CENMST_Address + "',");
            sql.Append(CORCenterMaster.CENMST_PinCode + ",'");
            sql.Append(CORCenterMaster.CENMST_Phone + "','");
            sql.Append(CORCenterMaster.CENMST_Phone2 + "','");
            sql.Append(CORCenterMaster.CENMST_Phone3 + "','");
            sql.Append(CORCenterMaster.CENMST_Email + "','");
            //sql.Append(CORCenterMaster.CTSMST_GCV + "','");
            sql.Append(CORCenterMaster.CENMST_GSTNoDT + "','");
            sql.Append(CORCenterMaster.CENMST_VATNoDT + "',");
            sql.Append(CORCenterMaster.CENMST_CreatedByUserID + ",");
            sql.Append(CORCenterMaster.CENMST_Language + ",'");
            sql.Append(CORCenterMaster.CENMST_Latitude + "','");
            sql.Append(CORCenterMaster.CENMST_Longitude + "','");
            sql.Append(CORCenterMaster.CENMST_OfficeStartTime + "','");
            sql.Append(CORCenterMaster.CENMST_OfficeEndTime + "',");
            sql.Append(CORCenterMaster.CENMST_RowStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORCenterMasterMsg(_RetVal, _RetStr);
        }

        public CORCenterMasterMsg UpdateCORCenterMaster(CORCenterMaster CORCenterMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_COR_CORCenterMaster_Update ");
            sql.Append(CORCenterMaster.CENMST_CenterCode + ",'");
            sql.Append(CORCenterMaster.CENMST_Name + "','");
            sql.Append(CORCenterMaster.CENMST_CenterPrefix + "',");
            sql.Append(CORCenterMaster.CENMST_City + ",");
            sql.Append(CORCenterMaster.CENMST_State + ",'");
            sql.Append(CORCenterMaster.CENMST_Address + "',");
            sql.Append(CORCenterMaster.CENMST_PinCode + ",'");
            sql.Append(CORCenterMaster.CENMST_Phone + "','");
            sql.Append(CORCenterMaster.CENMST_Phone2 + "','");
            sql.Append(CORCenterMaster.CENMST_Phone3 + "','");
            sql.Append(CORCenterMaster.CENMST_Email + "','");
            sql.Append(CORCenterMaster.CENMST_GSTNoDT + "','");
            sql.Append(CORCenterMaster.CENMST_VATNoDT + "',");
            sql.Append(CORCenterMaster.CENMST_UpdatedByUserID + ",");
            sql.Append(CORCenterMaster.CENMST_Language + ",'");
            sql.Append(CORCenterMaster.CENMST_Latitude + "','");
            sql.Append(CORCenterMaster.CENMST_Longitude + "','");
            sql.Append(CORCenterMaster.CENMST_OfficeStartTime + "','");
            sql.Append(CORCenterMaster.CENMST_OfficeEndTime + "',");
            sql.Append(CORCenterMaster.CENMST_RowStatus + ",");
            sql.Append(CORCenterMaster.CENMST_RowVersion);

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORCenterMasterMsg(_RetVal, _RetStr);
        }

        public CORCenterMasterMsg DeleteCORCenterMaster(int CORCenterMasterCode, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORCenterMaster_Delete " + CORCenterMasterCode);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORCenterMasterMsg(_RetVal, _RetStr);
        }


    }
}
