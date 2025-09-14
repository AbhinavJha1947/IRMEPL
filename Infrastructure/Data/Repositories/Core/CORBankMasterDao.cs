using Application.RepositoryInterfaces.Core;
using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Core
{
    public class CORBankMasterDao : ICORBankMasterDao
    {
        private readonly DbManager _dbManager;

        public CORBankMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORBankMasterList> GetCORBankMasters()
        {
            string sortExpression = "BANMST_BkCode";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORBankMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORBankMasterList> GetCORBankMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORBankMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'BANMST_BkCode',");
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
            int BankCounter = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORBankMasterList> list = new List<CORBankMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int BANMST_BkCode = int.Parse(row["BANMST_BkCode"].ToString());
                string BANMST_BankName = row["BANMST_BankName"].ToString();
                string BANMST_Address = row["BANMST_Address"].ToString();
                int BANMST_MicrNo = int.Parse(row["BANMST_MicrNo"].ToString());
                string CenterName = row["CenterName"].ToString();
                string CompanyBank = row["CompanyBank"].ToString();
                string BANMST_RowStatus = row["BANMST_RowStatus"].ToString();
                list.Add(new CORBankMasterList(BANMST_BkCode, BANMST_BankName, BANMST_Address, BANMST_MicrNo, CenterName, CompanyBank, BANMST_RowStatus, BankCounter));
            }
            return list;
        }

        public CORBankMaster GetCORBankMaster(int CORBankMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORBankMaster_Select " + CORBankMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int BANMST_BkCode = Convert.ToInt32(row["BANMST_BkCode"]);
            int BANMST_MicrNo = Convert.ToInt32(row["BANMST_MicrNo"]);
            string BANMST_BankName = Convert.ToString(row["BANMST_BankName"]);
            string BANMST_Address = Convert.ToString(row["BANMST_Address"]);
            string BANMST_AccountNo = Convert.ToString(row["BANMST_AccountNo"]);
            string BANMST_SubAccDomestic = Convert.ToString(row["BANMST_SubAccDomestic"]);
            string BANMST_SubAccCommercial = Convert.ToString(row["BANMST_SubAccCommercial"]);
            string BANMST_SubAccNonCommercial = Convert.ToString(row["BANMST_SubAccNonCommercial"]);
            string BANMST_ManagerName = Convert.ToString(row["BANMST_ManagerName"]);
            int BANMST_CompanyBank = Convert.ToInt32(row["BANMST_CompanyBank"]);
            int BANMST_CreatedByUserID = Convert.ToInt32(row["BANMST_CreatedByUserID"]);
            string BANMST_CreatedDateTime = Convert.ToString(row["BANMST_CreatedDateTime"]);
            //int BANMST_UpdatedByUserID=Convert.ToInt32(row["BANMST_UpdatedByUserID"]);
            //string BANMST_UpdatedDateTime=Convert.ToString(row["BANMST_UpdatedDateTime"]);
            int BANMST_UpdatedByUserID = 0;
            string BANMST_UpdatedDateTime = "";
            int BANMST_RowStatus = Convert.ToInt32(row["BANMST_RowStatus"]);
            int BANMST_CENCode = Convert.ToInt32(row["BANMST_CENCode"]);
            long BANMST_RowVersion = (long)row["BANMST_RowVersion"];


            #endregion

            return new
            CORBankMaster(BANMST_BkCode, BANMST_MicrNo, BANMST_BankName, BANMST_Address, BANMST_AccountNo, BANMST_SubAccDomestic, BANMST_SubAccCommercial, BANMST_SubAccNonCommercial, BANMST_ManagerName, BANMST_CompanyBank, BANMST_CreatedByUserID, BANMST_CreatedDateTime, BANMST_UpdatedByUserID, BANMST_UpdatedDateTime, BANMST_RowStatus, BANMST_CENCode, BANMST_RowVersion);
        }

        public CORBankMasterMsg InsertCORBankMaster(CORBankMaster CORBankMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORBankMaster_Insert ");
            sql.Append(CORBankMaster.BANMST_MicrNo + ",'");
            sql.Append(CORBankMaster.BANMST_BankName + "','");
            sql.Append(CORBankMaster.BANMST_Address + "','");
            sql.Append(CORBankMaster.BANMST_AccountNo + "','");
            sql.Append(CORBankMaster.BANMST_SubAccDomestic + "','");
            sql.Append(CORBankMaster.BANMST_SubAccCommercial + "','");
            sql.Append(CORBankMaster.BANMST_SubAccNonCommercial + "','");
            sql.Append(CORBankMaster.BANMST_ManagerName + "',");
            sql.Append(CORBankMaster.BANMST_CompanyBank + ",");
            sql.Append(CORBankMaster.BANMST_CreatedByUserID + ",");
            sql.Append(CORBankMaster.BANMST_RowStatus + ",");
            sql.Append(CORBankMaster.BANMST_CENCode);
            //sql.Append(CORBankMaster.BANMST_RowVersion+",");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORBankMasterMsg(_RetVal, _RetStr);
        }

        public CORBankMasterMsg UpdateCORBankMaster(CORBankMaster CORBankMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORBankMaster_Update ");
            sql.Append(CORBankMaster.BANMST_BkCode + ",");
            sql.Append(CORBankMaster.BANMST_MicrNo + ",'");
            sql.Append(CORBankMaster.BANMST_BankName + "','");
            sql.Append(CORBankMaster.BANMST_Address + "','");
            sql.Append(CORBankMaster.BANMST_AccountNo + "','");
            sql.Append(CORBankMaster.BANMST_SubAccDomestic + "','");
            sql.Append(CORBankMaster.BANMST_SubAccCommercial + "','");
            sql.Append(CORBankMaster.BANMST_SubAccNonCommercial + "','");
            sql.Append(CORBankMaster.BANMST_ManagerName + "',");
            sql.Append(CORBankMaster.BANMST_CompanyBank + ",");
            sql.Append(CORBankMaster.BANMST_CreatedByUserID + ",");
            sql.Append(CORBankMaster.BANMST_RowStatus + ",");
            sql.Append(CORBankMaster.BANMST_CENCode + ",");
            sql.Append(CORBankMaster.BANMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORBankMasterMsg(_RetVal, _RetStr);
        }

        public CORBankMasterMsg DeleteCORBankMaster(int CORBankMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORBankMaster_Delete " + CORBankMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORBankMasterMsg(_RetVal, _RetStr);
        }
    }
}

