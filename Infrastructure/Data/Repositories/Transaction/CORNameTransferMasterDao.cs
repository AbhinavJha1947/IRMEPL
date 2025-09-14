using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class CORNameTransferMasterDao : ICORNameTransferMasterDao
    {
        private readonly DbManager _dbManager;

        public CORNameTransferMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CORNameTransferMasterList> GetCORNameTransferMasters()
        {
            string sortExpression = "NAMMST_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORNameTransferMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORNameTransferMasterList> GetCORNameTransferMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORNameTransferMaster_SelectAll");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'NAMMST_ID',");
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
            IList<CORNameTransferMasterList> list = new List<CORNameTransferMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int NAMMST_ID = int.Parse(row["NAMMST_ID"].ToString());
                decimal NAMMST_ApplicationID = int.Parse(row["NAMMST_ApplicationID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string NAMMST_TransferDT = row["NAMMST_TransferDT"].ToString();
                string NAMMST_Name = row["NAMMST_Name"].ToString();
                decimal NAMMST_Charges = decimal.Parse(row["NAMMST_Charges"].ToString());
                decimal NAMMST_ChargesReceived = decimal.Parse(row["NAMMST_ChargesReceived"].ToString());
                decimal NAMMST_Mobile = decimal.Parse(row["NAMMST_Mobile"].ToString());
                string NAMMST_Phone = row["NAMMST_Phone"].ToString();
                string NAMMST_Reason = row["NAMMST_Reason"].ToString();
                string NAMMST_RequestNo = row["NAMMST_RequestNo"].ToString();
                list.Add(new CORNameTransferMasterList(NAMMST_ID, NAMMST_ApplicationID, APPMST_AppNo, APPMST_CustomerID, NAMMST_TransferDT, NAMMST_Name, NAMMST_Charges, NAMMST_ChargesReceived, NAMMST_Mobile, NAMMST_Phone, NAMMST_Reason, NAMMST_RequestNo, Count));
            }
            return list;
        }

        public CORNameTransferMaster GetCORNameTransferMaster(int CORNameTransferMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORNameTransferMaster_Select " + CORNameTransferMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int NAMMST_ID = Convert.ToInt32(row["NAMMST_ID"]);
            decimal NAMMST_ApplicationID = Convert.ToDecimal(row["NAMMST_ApplicationID"]);
            string NAMMST_FName = Convert.ToString(row["NAMMST_FName"]);
            string NAMMST_MName = Convert.ToString(row["NAMMST_MName"]);
            string NAMMST_LName = Convert.ToString(row["NAMMST_LName"]);
            decimal NAMMST_Charges = Convert.ToDecimal(row["NAMMST_Charges"]);
            int NAMMST_TariffID = Convert.ToInt32(row["NAMMST_TariffID"]);
            string NAMMST_TransferDT = Convert.ToString(row["NAMMST_TransferDT"]);
            int NAMMST_SubmitDoc1 = Convert.ToInt32(row["NAMMST_SubmitDoc1"]);
            int NAMMST_SubmitDoc2 = Convert.ToInt32(row["NAMMST_SubmitDoc2"]);
            string NAMMST_Phone = Convert.ToString(row["NAMMST_Phone"]);
            decimal NAMMST_Mobile = Convert.ToDecimal(row["NAMMST_Mobile"]);
            string NAMMST_Reason = Convert.ToString(row["NAMMST_Reason"]);
            int NAMMST_CreatedByUserID = Convert.ToInt32(row["NAMMST_CreatedByUserID"]);
            string NAMMST_CreatedDateTime = Convert.ToString(row["NAMMST_CreatedDateTime"]);
            int NAMMST_UpdatedByUserID = Convert.ToInt32(row["NAMMST_UpdatedByUserID"]);
            string NAMMST_UpdatedDateTime = Convert.ToString(row["NAMMST_UpdatedDateTime"]);
            int NAMMST_RowStatus = Convert.ToInt32(row["NAMMST_RowStatus"]);
            long NAMMST_RowVersion = (long)row["NAMMST_RowVersion"];
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            string APPMST_FName = Convert.ToString(row["APPMST_FName"]);
            string APPMST_MName = Convert.ToString(row["APPMST_MName"]);
            string APPMST_LName = Convert.ToString(row["APPMST_LName"]);
            string APPMST_Phone = Convert.ToString(row["APPMST_Phone"]);
            decimal APPMST_Mobile = Convert.ToDecimal(row["APPMST_Mobile"]);
            int APPMST_SubmitDoc1 = Convert.ToInt32(row["APPMST_SubmitDoc1"]);
            int APPMST_SubmitDoc2 = Convert.ToInt32(row["APPMST_SubmitDoc2"]);
            string cusType = Convert.ToString(row["cusType"]);
            string PLAMST_PlanName = Convert.ToString(row["PLAMST_PlanName"]);
            string NAMMST_RequestNo = Convert.ToString(row["NAMMST_RequestNo"]);
            string Message = Convert.ToString(row["Message"]);
            int Editable = Convert.ToInt32(row["Editable"]);

            #endregion

            return new
            CORNameTransferMaster(NAMMST_ID, NAMMST_ApplicationID, NAMMST_FName, NAMMST_MName, NAMMST_LName, NAMMST_Charges, NAMMST_TariffID, NAMMST_TransferDT, NAMMST_SubmitDoc1, NAMMST_SubmitDoc2, NAMMST_Phone, NAMMST_Mobile, NAMMST_Reason, NAMMST_CreatedByUserID, NAMMST_CreatedDateTime, NAMMST_UpdatedByUserID, NAMMST_UpdatedDateTime, NAMMST_RowStatus, NAMMST_RowVersion, APPMST_AppNo, APPMST_CustomerID, APPMST_FName, APPMST_MName, APPMST_LName, APPMST_Phone, APPMST_Mobile, APPMST_SubmitDoc1, APPMST_SubmitDoc2, cusType, PLAMST_PlanName, NAMMST_RequestNo, Message, Editable);
        }

        public CORNameTransferMasterMsg InsertCORNameTransferMaster(CORNameTransferMaster CORNameTransferMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_CORNameTransferMaster_Insert ");
            sql.Append(CORNameTransferMaster.NAMMST_ApplicationID + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_FName.Replace("'", "''") + "',");
            sql.Append("'" + CORNameTransferMaster.NAMMST_MName.Replace("'", "''") + "',");
            sql.Append("'" + CORNameTransferMaster.NAMMST_LName.Replace("'", "''") + "',");
            sql.Append(CORNameTransferMaster.NAMMST_Charges + ",");
            sql.Append(CORNameTransferMaster.NAMMST_TariffID + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_TransferDT + "',");
            sql.Append(CORNameTransferMaster.NAMMST_SubmitDoc1 + ",");
            sql.Append(CORNameTransferMaster.NAMMST_SubmitDoc2 + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_Phone + "',");
            sql.Append(CORNameTransferMaster.NAMMST_Mobile + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_Reason.Replace("'", "''") + "',");
            sql.Append(CORNameTransferMaster.NAMMST_CreatedByUserID + ",");
            sql.Append(CORNameTransferMaster.NAMMST_RowStatus);

            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORNameTransferMasterMsg(_RetVal, _RetStr);
        }

        public CORNameTransferMasterMsg UpdateCORNameTransferMaster(CORNameTransferMaster CORNameTransferMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORNameTransferMaster_Update ");
            sql.Append(CORNameTransferMaster.NAMMST_ID + ",");
            sql.Append(CORNameTransferMaster.NAMMST_ApplicationID + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_FName.Replace("'", "''") + "',");
            sql.Append("'" + CORNameTransferMaster.NAMMST_MName.Replace("'", "''") + "',");
            sql.Append("'" + CORNameTransferMaster.NAMMST_LName.Replace("'", "''") + "',");
            sql.Append(CORNameTransferMaster.NAMMST_Charges + ",");
            sql.Append(CORNameTransferMaster.NAMMST_SubmitDoc1 + ",");
            sql.Append(CORNameTransferMaster.NAMMST_SubmitDoc2 + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_Phone + "',");
            sql.Append(CORNameTransferMaster.NAMMST_Mobile + ",");
            sql.Append("'" + CORNameTransferMaster.NAMMST_Reason.Replace("'", "''") + "',");


            sql.Append(CORNameTransferMaster.NAMMST_UpdatedByUserID + ",");

            sql.Append(CORNameTransferMaster.NAMMST_RowStatus + ",");
            sql.Append(CORNameTransferMaster.NAMMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORNameTransferMasterMsg(_RetVal, _RetStr);
        }

        public CORNameTransferMasterMsg DeleteCORNameTransferMaster(int CORNameTransferMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Usp_CORNameTransferMaster_Delete " + CORNameTransferMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORNameTransferMasterMsg(_RetVal, _RetStr);
        }

    }
}
