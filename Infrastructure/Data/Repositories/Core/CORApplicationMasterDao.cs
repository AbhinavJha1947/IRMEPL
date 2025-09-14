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
    public class CORApplicationMasterDao : ICORApplicationMasterDao
    {
        private readonly DbManager _dbManager;

        public CORApplicationMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public IList<CORApplicationMasterList> GetCORApplicationMasters()
        {
            string sortExpression = "APPMST_AppID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCORApplicationMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CORApplicationMasterList> GetCORApplicationMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_AppID',");
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
            IList<CORApplicationMasterList> list = new List<CORApplicationMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string APPMST_AppDate = row["APPMST_AppDate"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string APPMST_FName = row["APPMST_FName"].ToString();
                string APPMST_MName = row["APPMST_MName"].ToString();
                string APPMST_LName = row["APPMST_LName"].ToString();
                //string APPMST_No_of_Family_members = row["APPMST_No_of_Family_members"].ToString();
                string APPMST_Name = row["APPMST_Name"].ToString();
                string APPMST_Area = row["APPMST_Area"].ToString();
                string AREMST_Name = row["AREMST_Name"].ToString();
                string StateName = row["StateName"].ToString();
                string CityName = row["CityName"].ToString();
                string APPMST_CustType = row["APPMST_CustType"].ToString();
                string APPMST_CustCategory = row["APPMST_CustCategory"].ToString();
                string APPMST_Plan = row["APPMST_Plan"].ToString();
                string APPMST_WOType = row["APPMST_WOType"].ToString();
                int APPMST_WOTYPEID = int.Parse(row["APPMST_WOTYPEID"].ToString());
                int APPMST_CustType1 = int.Parse(row["APPMST_CustType1"].ToString());
                int APPMST_PlanId = int.Parse(row["APPMST_PlanId"].ToString());
                string APPMST_Address = row["APPMST_Address"].ToString();
                string APPMST_Landmark = row["APPMST_Landmark"].ToString();
                string APPMST_OMStatus = row["APPMST_OMStatus"].ToString();
                string APPMST_Phone = row["APPMST_Phone"].ToString();
                decimal APPMST_Mobile = decimal.Parse(row["APPMST_Mobile"].ToString());
                string APPMST_BlockNo = row["APPMST_BlockNo"].ToString();
                string APPMST_Email = row["APPMST_Email"].ToString();
                string ConversionDate = row["ConversionDate"].ToString();
                string APPMST_RowStatus = row["APPMST_RowStatus"].ToString();
                string APPMST_BarCodeImagePath = row["APPMST_BarCodeImagePath"].ToString();
                string APPMST_Latitude = row["APPMST_Latitude"].ToString();
                string APPMST_Longitude = row["APPMST_Longitude"].ToString();
                int APPMST_ContractorID = row["APPMST_ContractorID"] != DBNull.Value ? int.Parse(row["APPMST_ContractorID"].ToString()) : 0;

                list.Add(new CORApplicationMasterList(APPMST_AppID, APPMST_AppNo, APPMST_AppDate, APPMST_CustomerID, APPMST_FName, APPMST_MName, APPMST_LName, APPMST_Name, APPMST_Area, AREMST_Name, StateName, CityName, APPMST_CustType, APPMST_CustCategory, APPMST_Plan, APPMST_WOType, APPMST_WOTYPEID, APPMST_CustType1, APPMST_PlanId, APPMST_Address, APPMST_Landmark, APPMST_BlockNo, APPMST_OMStatus, APPMST_Phone, APPMST_Mobile, APPMST_Email, ConversionDate, APPMST_RowStatus, Count, APPMST_BarCodeImagePath, APPMST_Latitude, APPMST_Longitude, APPMST_ContractorID));
            }
            return list;
        }
        public IList<CORApplicationMasterList> GetCORApplicationMobileNo(int CenterID, int OMStatus)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_SelectMobileNo ");
            //String Building for Order by Column.
            sql.Append(CenterID + ",");
            sql.Append(OMStatus + "");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORApplicationMasterList> list = new List<CORApplicationMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                decimal APPMST_Mobile = decimal.Parse(row["APPMST_Mobile"].ToString());
                list.Add(new CORApplicationMasterList(APPMST_Mobile));
            }
            return list;
        }


        public CORApplicationMaster GetCORApplicationMaster(int CORApplicationMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Select " + CORApplicationMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            Int64 APPMST_AppID = Convert.ToInt64(row["APPMST_AppID"]);
            string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
            string APPMST_AppDate = Convert.ToString(row["APPMST_AppDate"]);
            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            int APPMST_NoOfConnection = Convert.ToInt32(row["APPMST_NoOfConnection"]);
            string APPMST_FName = Convert.ToString(row["APPMST_FName"]);
            string APPMST_MName = Convert.ToString(row["APPMST_MName"]);
            string APPMST_LName = Convert.ToString(row["APPMST_LName"]);
            //string APPMST_No_of_Family_members = Convert.ToString(row["APPMST_No_of_Family_members"]);
            string APPMST_DOB = Convert.ToString(row["APPMST_DOB"]);
            string APPMST_Phone = Convert.ToString(row["APPMST_Phone"]);
            string APPMST_Email = Convert.ToString(row["APPMST_Email"]);
            string APPMST_Address1 = Convert.ToString(row["APPMST_Address1"]);
            string APPMST_Address2 = Convert.ToString(row["APPMST_Address2"]);
            string APPMST_LandmarkAdd = Convert.ToString(row["APPMST_LandmarkAdd"]);
            string APPMST_BlockNo = Convert.ToString(row["APPMST_BlockNo"].ToString());
            int APPMST_Country = Convert.ToInt32(row["APPMST_Country"]);
            int APPMST_State = Convert.ToInt32(row["APPMST_State"]);
            int APPMST_City = Convert.ToInt32(row["APPMST_City"]);
            int APPMST_Area = Convert.ToInt32(row["APPMST_Area"]);
            int APPMST_Pincode = Convert.ToInt32(row["APPMST_Pincode"]);
            Int64 APPMST_Mobile = Convert.ToInt64(row["APPMST_Mobile"]);
            int APPMST_PropertyTypeID = Convert.ToInt32(row["APPMST_PropertyTypeID"]);
            int APPMST_OwnershipStatus = Convert.ToInt32(row["APPMST_OwnershipStatus"]);
            string APPMST_EstablishmentName = Convert.ToString(row["APPMST_EstablishmentName"]);
            string APPMST_TypeofEstablishmentIfOther = Convert.ToString(row["APPMST_TypeofEstablishmentIfOther"]);
            string APPMST_OwnerName = Convert.ToString(row["APPMST_OwnerName"]);
            string APPMST_OwnerPhone = Convert.ToString(row["APPMST_OwnerPhone"]);
            int APPMST_SubmitDoc1 = Convert.ToInt32(row["APPMST_SubmitDoc1"]);
            int APPMST_SubmitDoc2 = Convert.ToInt32(row["APPMST_SubmitDoc2"]);
            int APPMST_CorporateID = Convert.ToInt32(row["APPMST_CorporateID"]);
            int APPMST_ContractorID = Convert.ToInt32(row["APPMST_ContractorID"]);
            int APPMST_BillingTo = Convert.ToInt32(row["APPMST_BillingTo"]);
            int APPMST_OMStatus = Convert.ToInt32(row["APPMST_OMStatus"]);
            int APPMST_BillingStatus = Convert.ToInt32(row["APPMST_BillingStatus"]);
            int APPMST_CustType = Convert.ToInt32(row["APPMST_CustType"]);
            int APPMST_CustCategory = Convert.ToInt32(row["APPMST_CustCategory"]);
            int APPMST_PlanId = Convert.ToInt32(row["APPMST_PlanId"]);
            string APPMST_Remark = Convert.ToString(row["APPMST_Remark"]);
            int APPMST_CenCode = Convert.ToInt32(row["APPMST_CenCode"]);
            int APPMST_CreatedByUserID = Convert.ToInt32(row["APPMST_CreatedByUserID"]);
            string APPMST_CreatedDateTime = Convert.ToString(row["APPMST_CreatedDateTime"]);
            int APPMST_UpdatedByUserID = Convert.ToInt32(row["APPMST_UpdatedByUserID"]);
            string APPMST_UpdatedDateTime = Convert.ToString(row["APPMST_UpdatedDateTime"]);
            int APPMST_RowStatus = Convert.ToInt32(row["APPMST_RowStatus"]);
            long APPMST_RowVersion = (long)row["APPMST_RowVersion"];
            string APPMST_BarCodeImagePath = Convert.ToString(row["APPMST_BarCodeImagePath"]);

            string APPMST_ConsumerNumber = Convert.ToString(row["APPMST_ConsumerNumber"]);
            string APPMST_Distributor = Convert.ToString(row["APPMST_Distributor"]);
            string APPMST_OMC = Convert.ToString(row["APPMST_OMC"]);
            string APPAadharcard = Convert.ToString(row["APPMST_AADHARNO"]);
            bool APPMST_EmailSubscription = false;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_EmailSubscription"])))
                APPMST_EmailSubscription = (bool)row["APPMST_EmailSubscription"];
            string APPMST_Latitude = string.Empty;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_Latitude"])))
                APPMST_Latitude = (string)row["APPMST_Latitude"];
            string APPMST_Longitude = string.Empty;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_Longitude"])))
                APPMST_Longitude = (string)row["APPMST_Longitude"];

            #endregion

            return new
            CORApplicationMaster(APPMST_AppID, APPMST_AppNo, APPMST_AppDate, APPMST_CustomerID, APPMST_NoOfConnection, APPMST_FName, APPMST_MName, APPMST_LName, APPMST_DOB, APPMST_Phone, APPMST_Mobile, APPMST_Email, APPMST_Address1, APPMST_Address2, APPMST_LandmarkAdd, APPMST_BlockNo, APPMST_Country, APPMST_State, APPMST_City, APPMST_Area, APPMST_Pincode, APPMST_PropertyTypeID, APPMST_OwnershipStatus, APPMST_EstablishmentName, APPMST_TypeofEstablishmentIfOther, APPMST_OwnerName, APPMST_OwnerPhone, APPMST_SubmitDoc1, APPMST_SubmitDoc2, APPMST_CorporateID, APPMST_ContractorID, APPMST_BillingTo, APPMST_OMStatus, APPMST_BillingStatus, APPMST_CustType, APPMST_CustCategory, APPMST_PlanId, APPMST_Remark, APPMST_CenCode, APPMST_CreatedByUserID, APPMST_CreatedDateTime, APPMST_UpdatedByUserID, APPMST_UpdatedDateTime, APPMST_RowStatus, APPMST_RowVersion, 0, 0, "", "", APPMST_BarCodeImagePath, APPMST_ConsumerNumber, APPMST_Distributor, APPMST_OMC, APPAadharcard, APPMST_EmailSubscription, "", APPMST_Latitude, APPMST_Longitude, 0, 0);
        }

        public CORApplicationMaster GetCORApplicationMaster(int CORApplicationMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Select " + CORApplicationMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            Int64 APPMST_AppID = Convert.ToInt64(row["APPMST_AppID"]);
            string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
            string APPMST_AppDate = Convert.ToString(row["APPMST_AppDate"]);
            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            int APPMST_NoOfConnection = Convert.ToInt32(row["APPMST_NoOfConnection"]);
            string APPMST_FName = Convert.ToString(row["APPMST_FName"]);
            string APPMST_MName = Convert.ToString(row["APPMST_MName"]);
            string APPMST_LName = Convert.ToString(row["APPMST_LName"]);
            //string APPMST_No_of_Family_members = Convert.ToString(row["APPMST_No_of_Family_members"]);
            string APPMST_DOB = Convert.ToString(row["APPMST_DOB"]);
            string APPMST_Phone = Convert.ToString(row["APPMST_Phone"]);
            string APPMST_Email = Convert.ToString(row["APPMST_Email"]);
            string APPMST_Address1 = Convert.ToString(row["APPMST_Address1"]);
            string APPMST_Address2 = Convert.ToString(row["APPMST_Address2"]);
            string APPMST_LandmarkAdd = Convert.ToString(row["APPMST_LandmarkAdd"]);
            string APPMST_BlockNo = Convert.ToString(row["APPMST_BlockNo"].ToString());
            int APPMST_Country = Convert.ToInt32(row["APPMST_Country"]);
            int APPMST_State = Convert.ToInt32(row["APPMST_State"]);
            int APPMST_City = Convert.ToInt32(row["APPMST_City"]);
            int APPMST_Area = Convert.ToInt32(row["APPMST_Area"]);
            int APPMST_Pincode = Convert.ToInt32(row["APPMST_Pincode"]);
            Int64 APPMST_Mobile = Convert.ToInt64(row["APPMST_Mobile"]);
            int APPMST_PropertyTypeID = Convert.ToInt32(row["APPMST_PropertyTypeID"]);
            int APPMST_OwnershipStatus = Convert.ToInt32(row["APPMST_OwnershipStatus"]);
            string APPMST_EstablishmentName = Convert.ToString(row["APPMST_EstablishmentName"]);
            string APPMST_TypeofEstablishmentIfOther = Convert.ToString(row["APPMST_TypeofEstablishmentIfOther"]);
            string APPMST_OwnerName = Convert.ToString(row["APPMST_OwnerName"]);
            string APPMST_OwnerPhone = Convert.ToString(row["APPMST_OwnerPhone"]);
            int APPMST_SubmitDoc1 = Convert.ToInt32(row["APPMST_SubmitDoc1"]);
            int APPMST_SubmitDoc2 = Convert.ToInt32(row["APPMST_SubmitDoc2"]);
            int APPMST_CorporateID = Convert.ToInt32(row["APPMST_CorporateID"]);
            int APPMST_ContractorID = Convert.ToInt32(row["APPMST_ContractorID"]);
            int APPMST_BillingTo = Convert.ToInt32(row["APPMST_BillingTo"]);
            int APPMST_OMStatus = Convert.ToInt32(row["APPMST_OMStatus"]);
            int APPMST_BillingStatus = Convert.ToInt32(row["APPMST_BillingStatus"]);
            int APPMST_CustType = Convert.ToInt32(row["APPMST_CustType"]);
            int APPMST_CustCategory = Convert.ToInt32(row["APPMST_CustCategory"]);
            int APPMST_PlanId = Convert.ToInt32(row["APPMST_PlanId"]);
            string APPMST_Remark = Convert.ToString(row["APPMST_Remark"]);
            int APPMST_CenCode = Convert.ToInt32(row["APPMST_CenCode"]);
            int APPMST_CreatedByUserID = Convert.ToInt32(row["APPMST_CreatedByUserID"]);
            string APPMST_CreatedDateTime = Convert.ToString(row["APPMST_CreatedDateTime"]);
            int APPMST_UpdatedByUserID = Convert.ToInt32(row["APPMST_UpdatedByUserID"]);
            string APPMST_UpdatedDateTime = Convert.ToString(row["APPMST_UpdatedDateTime"]);
            int APPMST_RowStatus = Convert.ToInt32(row["APPMST_RowStatus"]);
            long APPMST_RowVersion = (long)row["APPMST_RowVersion"];
            string APPMST_BarCodeImagePath = Convert.ToString(row["APPMST_BarCodeImagePath"]);

            string APPMST_ConsumerNumber = Convert.ToString(row["APPMST_ConsumerNumber"]);
            string APPMST_Distributor = Convert.ToString(row["APPMST_Distributor"]);
            string APPMST_OMC = Convert.ToString(row["APPMST_OMC"]);
            string APPAadharcard = Convert.ToString(row["APPMST_AADHARNO"]);
            bool APPMST_EmailSubscription = false;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_EmailSubscription"])))
                APPMST_EmailSubscription = (bool)row["APPMST_EmailSubscription"];

            string APPMST_Latitude = string.Empty;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_Latitude"])))
                APPMST_Latitude = (string)row["APPMST_Latitude"];
            string APPMST_Longitude = string.Empty;
            if (!string.IsNullOrEmpty(Convert.ToString(row["APPMST_Longitude"])))
                APPMST_Longitude = (string)row["APPMST_Longitude"];

            #endregion

            return new
            CORApplicationMaster(APPMST_AppID, APPMST_AppNo, APPMST_AppDate, APPMST_CustomerID, APPMST_NoOfConnection, APPMST_FName, APPMST_MName, APPMST_LName, APPMST_DOB, APPMST_Phone, APPMST_Mobile, APPMST_Email, APPMST_Address1, APPMST_Address2, APPMST_LandmarkAdd, APPMST_BlockNo, APPMST_Country, APPMST_State, APPMST_City, APPMST_Area, APPMST_Pincode, APPMST_PropertyTypeID, APPMST_OwnershipStatus, APPMST_EstablishmentName, APPMST_TypeofEstablishmentIfOther, APPMST_OwnerName, APPMST_OwnerPhone, APPMST_SubmitDoc1, APPMST_SubmitDoc2, APPMST_CorporateID, APPMST_ContractorID, APPMST_BillingTo, APPMST_OMStatus, APPMST_BillingStatus, APPMST_CustType, APPMST_CustCategory, APPMST_PlanId, APPMST_Remark, APPMST_CenCode, APPMST_CreatedByUserID, APPMST_CreatedDateTime, APPMST_UpdatedByUserID, APPMST_UpdatedDateTime, APPMST_RowStatus, APPMST_RowVersion, 0, 0, "", "", APPMST_BarCodeImagePath, APPMST_ConsumerNumber, APPMST_Distributor, APPMST_OMC, APPAadharcard, APPMST_EmailSubscription, "", APPMST_Latitude, APPMST_Latitude, 0, 0);
        }

        public CORApplicationMaster2 GetCORApplicationMaster2(string CORAPPMST_CustomerID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Select2 " + CORAPPMST_CustomerID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            if (row != null)
            {
                int APPMST_CenCode = Convert.ToInt32(row["APPMST_CenCode"]);
                string CENMST_CenterPrefix = row["CENMST_CenterPrefix"].ToString();
                int APPMST_AppID = Convert.ToInt32(row["APPMST_AppID"]);
                int APPMST_CustType = Convert.ToInt32(row["APPMST_CustType"]);
                int APPMST_PlanId = Convert.ToInt32(row["APPMST_PlanId"]);
                string APPMST_FName = row["APPMST_FName"].ToString();
                string APPMST_LName = row["APPMST_LName"].ToString();
                //string APPMST_No_of_Family_members = row["APPMST_No_of_Family_members"].ToString();
                string APPMST_Email = row["APPMST_Email"].ToString();
                string APPMST_Password = row["APPMST_Password"].ToString();
                string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
                string APPMST_MName = row["APPMST_MName"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string CenterName = row["CenterName"].ToString();
                return new CORApplicationMaster2(APPMST_CenCode, CENMST_CenterPrefix, APPMST_AppID, APPMST_CustType, APPMST_PlanId, APPMST_FName, APPMST_LName, APPMST_Email, APPMST_Password, APPMST_CustomerID, APPMST_MName, APPMST_AppNo, CenterName);
            }
            #endregion
            else
            {
                return null;
            }
        }

        public CORApplicationMaster3 GetCORApplicationMaster3(string CORAPPMST_CustomerID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Select3 " + CORAPPMST_CustomerID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            string APPMST_CustomerID = row["APPMST_CustomerID"].ToString();
            Int64 APPMST_Mobile = Convert.ToInt64(row["APPMST_Mobile"]);
            #endregion
            return new
            CORApplicationMaster3(APPMST_CustomerID, APPMST_Mobile);

        }

        public CORApplicationMasterForAS GetCORApplicationMasterForAS(int CORApplicationMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_appDetailForAdvanceSearch " + CORApplicationMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int APPMST_AppID = int.Parse(row["APPMST_AppID"].ToString());
            string APPMST_Address1 = Convert.ToString(row["APPMST_Address1"]);
            string APPMST_Address2 = Convert.ToString(row["APPMST_Address2"]);
            string APPMST_AppNo = Convert.ToString(row["APPMST_AppNo"]);
            string APPMST_AppDate = Convert.ToString(row["APPMST_AppDate"]);
            string CENMST_Name = Convert.ToString(row["CENMST_Name"]);
            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            string custype = Convert.ToString(row["custype"]);
            Int64 APPMST_Mobile = Convert.ToInt64(row["APPMST_Mobile"]);
            string APPMST_FName = Convert.ToString(row["APPMST_FName"]);
            string APPMST_MName = Convert.ToString(row["APPMST_MName"]);
            string APPMST_LName = Convert.ToString(row["APPMST_LName"]);
            string APPMST_OwnerName = Convert.ToString(row["APPMST_OwnerName"]);
            string Ownerstatus = Convert.ToString(row["Ownerstatus"]);
            string APPMST_Phone = Convert.ToString(row["APPMST_Phone"]);
            int APPMST_Pincode = Convert.ToInt32(row["APPMST_Pincode"]);
            string Plantype = Convert.ToString(row["Plantype"]);
            string Planname = Convert.ToString(row["Planname"]);
            string PropertyType = Convert.ToString(row["PropertyType"]);
            string areaName = Convert.ToString(row["areaName"]);
            string OMSTATUS = Convert.ToString(row["OMSTATUS"]);


            int APPMST_CorporateID = Convert.ToInt32(row["APPMST_CorporateID"]);
            string APPMST_Remark = Convert.ToString(row["APPMST_Remark"]);
            string CenterState = Convert.ToString(row["CenterState"]);

            #endregion

            return new
            CORApplicationMasterForAS(APPMST_AppID, APPMST_Address1, APPMST_Address2, APPMST_AppNo, APPMST_AppDate, CENMST_Name, APPMST_CustomerID, custype, APPMST_Mobile, APPMST_FName, APPMST_MName, APPMST_LName, APPMST_OwnerName, Ownerstatus, APPMST_Phone, APPMST_Pincode, Plantype, Planname, PropertyType, areaName, OMSTATUS, APPMST_CorporateID, APPMST_Remark, CenterState);
        }

        public decimal GetCORApplicationMaster_GetChargeAmount(int ApplicationID, int CorporateID, int ChargeHead, string TransactionDate, decimal BasicAmount)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_GetChargeAmount " + ApplicationID);
            sql.Append("," + CorporateID);
            sql.Append("," + ChargeHead);
            sql.Append(",'" + TransactionDate + "'");
            sql.Append("," + BasicAmount);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            decimal ChargeAmount = Convert.ToInt32(row["ChargeAmount"]);
            #endregion

            return ChargeAmount;
        }
        public int GetCORApplicationMaster_CheckTariff(int ApplicationID, int ChargeID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_GetCORApplicationMaster_CheckTariff " + ApplicationID);
            sql.Append("," + ChargeID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int TariffVal = Convert.ToInt32(row["TPDMST_TariffVal"]);
            #endregion

            return TariffVal;
        }

        public CORApplicationMaster1 GetCORApplicationMaster1(int CORApplicationMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Select1 " + CORApplicationMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            Int64 APPMST_AppID = Convert.ToInt64(row["APPMST_AppID"]);
            string APPMST_AppNo = row["APPMST_AppNo"].ToString();
            string APPMST_AppName = row["APPMST_AppName"].ToString();
            string APPMST_CustomerID = Convert.ToString(row["APPMST_CustomerID"]);
            Int32 JOBHDR_ContractorID = Convert.ToInt32(row["JOBHDR_ContractorID"].ToString());

            #endregion

            return new
            CORApplicationMaster1(APPMST_AppID, APPMST_AppNo, APPMST_AppName, APPMST_CustomerID, JOBHDR_ContractorID);
        }

        public CORApplicationMasterMsg InsertCORApplicationMaster(CORApplicationMaster CORApplicationMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Insert ");
            sql.Append("N'" + CORApplicationMaster.APPMST_AppNo + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_AppDate + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_CustomerID + "',");
            sql.Append(CORApplicationMaster.APPMST_NoOfConnection + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_FName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_MName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_LName + "',");
            //sql.Append("N'" + CORApplicationMaster.APPMST_No_of_Family_members + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_DOB + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Phone + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Email + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Address1.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Address2.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_LandmarkAdd.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_BlockNo.Replace("'", "''") + "',");

            sql.Append(CORApplicationMaster.APPMST_Country + ",");
            sql.Append(CORApplicationMaster.APPMST_State + ",");
            sql.Append(CORApplicationMaster.APPMST_City + ",");
            sql.Append(CORApplicationMaster.APPMST_Area + ",");
            sql.Append(CORApplicationMaster.APPMST_Pincode + ",");
            sql.Append(CORApplicationMaster.APPMST_Mobile + ",");
            sql.Append(CORApplicationMaster.APPMST_PropertyTypeID + ",");
            sql.Append(CORApplicationMaster.APPMST_OwnershipStatus + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_EstablishmentName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_TypeofEstablishmentIfOther + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_OwnerName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_OwnerPhone + "',");
            sql.Append(CORApplicationMaster.APPMST_SubmitDoc1 + ",");
            sql.Append(CORApplicationMaster.APPMST_SubmitDoc2 + ",");
            sql.Append(CORApplicationMaster.APPMST_CorporateID + ",");
            sql.Append(CORApplicationMaster.APPMST_ContractorID + ",");
            sql.Append(CORApplicationMaster.APPMST_BillingTo + ",");
            sql.Append(CORApplicationMaster.APPMST_OMStatus + ",");
            sql.Append(CORApplicationMaster.APPMST_BillingStatus + ",");
            sql.Append(CORApplicationMaster.APPMST_CustType + ",");
            sql.Append(CORApplicationMaster.APPMST_CustCategory + ",");
            sql.Append(CORApplicationMaster.APPMST_PlanId + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_Remark + "',");
            sql.Append(CORApplicationMaster.APPMST_CenCode + ",");
            sql.Append(CORApplicationMaster.APPMST_CreatedByUserID + ",");
            sql.Append(CORApplicationMaster.APPMST_RowStatus + ",");
            sql.Append(CORApplicationMaster.APPMST_RowVersion + ",'");
            sql.Append(CORApplicationMaster.APPMST_BarCodeImagePath + "','");
            sql.Append(CORApplicationMaster.APPMST_ConsumerNumber + "','");
            sql.Append(CORApplicationMaster.APPMST_Distributor + "','");
            sql.Append(CORApplicationMaster.APPMST_OMC + "','");
            //sql.Append(CORApplicationMaster.APPMST_Password + "','");
            sql.Append(CORApplicationMaster.APPMST_AADHARNO + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORApplicationMasterMsg(_RetVal, _RetStr);
        }

        public CORDOCUploadDownloadLogMsg AddCORDOCUploadDownload(CORDOCUploadDownload CORDOCUploadDownload, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_CORDOCUploadDownload_Insert ");
            sql.Append("N'" + CORDOCUploadDownload.AppNo + "',");
            sql.Append("N'" + CORDOCUploadDownload.DOC_Filename + "',");
            sql.Append(CORDOCUploadDownload.DOC_CreatedByUserID);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORDOCUploadDownloadLogMsg(_RetVal, _RetStr);



        }
        public IList<CORDOCUploadDownload> GetCORDOCUploadDownload(int ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC User_CORDOCUploadDownload_Select ");
            //String Building for Order by Column.
            sql.Append(ApplicationID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<CORDOCUploadDownload> list = new List<CORDOCUploadDownload>();
            foreach (DataRow row in dtList.Rows)
            {
                int SrNo = int.Parse(row["SrNo"].ToString());
                string DOC_Filename = row["DOC_Filename"].ToString();
                string AppNo = row["APPMST_AppNo"].ToString(); // Added by Divya on 26/8/2019
                list.Add(new CORDOCUploadDownload(SrNo, AppNo, DOC_Filename, 0, 0, 1));
                //list.Add(new CORDOCUploadDownload(SrNo,"",DOC_Filename,0,0,1)); //Commented By Divya on 26/8/2019
            }
            return list;
        }
        public DataSet GetCustomerTransactionLedger(string AppNo, string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, int blnexport)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC GET_Ledger_View ");
            //String Building for Order by Column.
            sql.Append("'" + AppNo + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            //  DataTable dtList = ds.Tables[0];
            return ds;
        }


        public IList<CORCustomerSurveyDetail> GetCustomerSurveyDetailList(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria, int blnexport)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORCustomerSurvey_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'APPMST_AppID',");
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
            sql.Append(criteria + "',");
            sql.Append(blnexport + "");

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<CORCustomerSurveyDetail> list = new List<CORCustomerSurveyDetail>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
                int CUSTSRV_ID = int.Parse(row["CUSTSRV_ID"].ToString());
                int CUSTSRV_ApplicationID = int.Parse(row["CUSTSRV_ApplicationID"].ToString());
                string UserName = row["UserName"].ToString();
                string APPMST_AppNo = row["APPMST_AppNo"].ToString();
                string CUSTSRV_MeterNo = row["CUSTSRV_MeterNo"].ToString();
                string CUSTSRV_MeterReading = row["CUSTSRV_MeterReading"].ToString();
                string CUSTSRV_Latitude = row["CUSTSRV_Latitude"].ToString();
                string CUSTSRV_Longitude = row["CUSTSRV_Longitude"].ToString();
                string CUSTSRV_RubberTube = row["CUSTSRV_RubberTube"].ToString();
                string customer_name = row["customer_name"].ToString();
                string customer_address = row["customer_address"].ToString();
                int APPMST_State = int.Parse(row["APPMST_State"].ToString());
                int APPMST_City = int.Parse(row["APPMST_City"].ToString());
                string APPMST_StateName = row["APPMST_StateName"].ToString();
                string APPMST_CityName = row["APPMST_CityName"].ToString();
                int APPMST_Area = int.Parse(row["APPMST_Area"].ToString());
                string APPMST_Area_Name = row["APPMST_Area_Name"].ToString();
                string APPMST_Mobile = row["APPMST_Mobile"].ToString();
                string APPMST_Email = row["APPMST_Email"].ToString();
                string CUSTSRV_Remarks = row["CUSTSRV_Remarks"].ToString();
                int CUSTSRV_CreatedByUserID = int.Parse(row["CUSTSRV_CreatedByUserID"].ToString());
                string CUSTSRV_CreatedDateTime = row["CUSTSRV_CreatedDateTime"].ToString();
                long ROwVersion = 0; //long.Parse(row["ROwVersion"].ToString());

                // list.Add(new CORCustomerSurveyDetail(APPMST_AppID, APPMST_AppNo, APPMST_AppDate, APPMST_CustomerID, APPMST_FName, APPMST_MName, APPMST_LName, APPMST_Name, APPMST_Area, AREMST_Name, StateName, CityName, APPMST_CustType, APPMST_CustCategory, APPMST_Plan, APPMST_WOType, APPMST_WOTYPEID, APPMST_CustType1, APPMST_PlanId, APPMST_Address, APPMST_Landmark, APPMST_BlockNo, APPMST_OMStatus, APPMST_Phone, APPMST_Mobile, APPMST_Email, ConversionDate, APPMST_RowStatus, Count, APPMST_BarCodeImagePath, APPMST_Latitude, APPMST_Longitude));
                list.Add(new CORCustomerSurveyDetail(CUSTSRV_ID, CUSTSRV_ApplicationID, UserName, APPMST_AppNo, CUSTSRV_MeterNo, CUSTSRV_MeterReading, CUSTSRV_Latitude, CUSTSRV_Longitude, CUSTSRV_RubberTube, customer_name, customer_address, APPMST_State, APPMST_StateName, APPMST_City, APPMST_CityName, APPMST_Area, APPMST_Area_Name, APPMST_Mobile, APPMST_Email, CUSTSRV_Remarks, Count, CUSTSRV_CreatedByUserID, CUSTSRV_CreatedDateTime, ROwVersion));
            }
            return list;
        }

        public CORApplicationMasterMsg InsertCORApplicationMaster_ForCSVUpload(CORApplicationMaster CORApplicationMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Insert_ForCSVUpload ");
            sql.Append("N'" + CORApplicationMaster.APPMST_AppNo + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_AppDate + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_CustomerID + "',");
            sql.Append(CORApplicationMaster.APPMST_NoOfConnection + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_FName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_MName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_LName + "',");
            //sql.Append("N'" + CORApplicationMaster.APPMST_No_of_Family_members + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_DOB + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Phone + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Email + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Address1.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Address2.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_LandmarkAdd.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_BlockNo.Replace("'", "''") + "',");

            sql.Append(CORApplicationMaster.APPMST_Country + ",");
            sql.Append(CORApplicationMaster.APPMST_State + ",");
            sql.Append(CORApplicationMaster.APPMST_City + ",");
            sql.Append(CORApplicationMaster.APPMST_Area + ",");
            sql.Append(CORApplicationMaster.APPMST_Pincode + ",");
            sql.Append(CORApplicationMaster.APPMST_Mobile + ",");
            sql.Append(CORApplicationMaster.APPMST_PropertyTypeID + ",");
            sql.Append(CORApplicationMaster.APPMST_OwnershipStatus + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_EstablishmentName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_TypeofEstablishmentIfOther + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_OwnerName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_OwnerPhone + "',");
            sql.Append(CORApplicationMaster.APPMST_SubmitDoc1 + ",");
            sql.Append(CORApplicationMaster.APPMST_SubmitDoc2 + ",");
            sql.Append(CORApplicationMaster.APPMST_CorporateID + ",");
            sql.Append(CORApplicationMaster.APPMST_ContractorID + ",");
            sql.Append(CORApplicationMaster.APPMST_BillingTo + ",");
            sql.Append(CORApplicationMaster.APPMST_OMStatus + ",");
            sql.Append(CORApplicationMaster.APPMST_BillingStatus + ",");
            sql.Append(CORApplicationMaster.APPMST_CustType + ",");
            sql.Append(CORApplicationMaster.APPMST_CustCategory + ",");
            sql.Append(CORApplicationMaster.APPMST_PlanId + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_Remark + "',");
            sql.Append(CORApplicationMaster.APPMST_CenCode + ",");
            sql.Append(CORApplicationMaster.APPMST_CreatedByUserID + ",");
            sql.Append(CORApplicationMaster.APPMST_RowStatus + ",'");
            sql.Append(CORApplicationMaster.APPMST_BarCodeImagePath + "',");
            sql.Append(CORApplicationMaster.APPMST_RowVersion + ",");
            sql.Append(CORApplicationMaster.PayMode + ",");
            sql.Append(CORApplicationMaster.ReceivedAmt + ",");
            if (string.IsNullOrEmpty(CORApplicationMaster.ChequeNo))
                CORApplicationMaster.ChequeNo = "";

            sql.Append("N'" + CORApplicationMaster.ChequeNo.Replace("'", "''") + "','");
            sql.Append(CORApplicationMaster.ChequeDate + "',");
            sql.Append(CORApplicationMaster.MICRNo + ",");
            sql.Append(CORApplicationMaster.BankID + ",'");

            sql.Append(CORApplicationMaster.APPMST_ConsumerNumber + "','");
            sql.Append(CORApplicationMaster.APPMST_Distributor + "','");
            sql.Append(CORApplicationMaster.APPMST_OMC + "','");
            sql.Append(CORApplicationMaster.APPMST_AADHARNO + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CORApplicationMasterMsg(_RetVal, _RetStr);
        }

        public CORApplicationMasterMsg UpdateCORApplicationMasterEmailSubs(CORApplicationMaster CORApplicationMaster, string UpdateType, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_UpdateEmailSubscription ");
            sql.Append("N'" + CORApplicationMaster.APPMST_CustomerID + "',");
            sql.Append(CORApplicationMaster.APPMST_EmailSubscription + ",");
            sql.Append(CORApplicationMaster.APPMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_UpdatedDateTime + "',");
            sql.Append(CORApplicationMaster.APPMST_RowVersion);


            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationMasterMsg(_RetVal, _RetStr);
        }


        public CORApplicationMasterMsg UpdateJobSheetAppMSTLatLongHDRTRN_Update(CORApplicationMaster CORApplicationMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetAppMSTLatLongHDRTRN_Update ");
            sql.Append(CORApplicationMaster.APPMST_AppID + ",'");
            sql.Append(CORApplicationMaster.APPMST_Latitude + "','");
            sql.Append(CORApplicationMaster.APPMST_Longitude + "',");
            sql.Append(CORApplicationMaster.APPMST_RowVersion);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationMasterMsg(_RetVal, _RetStr);
        }

        public CORApplicationMasterMsg UpdateCORApplicationMaster(CORApplicationMaster CORApplicationMaster, string UpdateType, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Update ");
            sql.Append(CORApplicationMaster.APPMST_AppID + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_AppNo + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_AppDate + "',");
            sql.Append(CORApplicationMaster.APPMST_NoOfConnection + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_FName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_MName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_LName + "',");
            //sql.Append("N'" + CORApplicationMaster.APPMST_No_of_Family_members + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_DOB + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Phone + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Email + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Address1.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_Address2.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_LandmarkAdd.Replace("'", "''") + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_BlockNo.Replace("'", "''") + "',");

            sql.Append(CORApplicationMaster.APPMST_Country + ",");
            sql.Append(CORApplicationMaster.APPMST_State + ",");
            sql.Append(CORApplicationMaster.APPMST_City + ",");
            sql.Append(CORApplicationMaster.APPMST_Area + ",");
            sql.Append(CORApplicationMaster.APPMST_Pincode + ",");
            sql.Append(CORApplicationMaster.APPMST_Mobile + ",");
            sql.Append(CORApplicationMaster.APPMST_PropertyTypeID + ",");
            sql.Append(CORApplicationMaster.APPMST_OwnershipStatus + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_EstablishmentName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_TypeofEstablishmentIfOther + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_OwnerName + "',");
            sql.Append("N'" + CORApplicationMaster.APPMST_OwnerPhone + "',");
            sql.Append(CORApplicationMaster.APPMST_SubmitDoc1 + ",");
            sql.Append(CORApplicationMaster.APPMST_SubmitDoc2 + ",");
            sql.Append(CORApplicationMaster.APPMST_CorporateID + ",");
            sql.Append(CORApplicationMaster.APPMST_ContractorID + ",");
            sql.Append(CORApplicationMaster.APPMST_BillingTo + ",");
            sql.Append(CORApplicationMaster.APPMST_CustType + ",");
            sql.Append(CORApplicationMaster.APPMST_CustCategory + ",");
            sql.Append(CORApplicationMaster.APPMST_PlanId + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_Remark + "',");
            sql.Append(CORApplicationMaster.APPMST_CenCode + ",");
            sql.Append(CORApplicationMaster.APPMST_UpdatedByUserID + ",");
            sql.Append("N'" + CORApplicationMaster.APPMST_UpdatedDateTime + "',");
            sql.Append(CORApplicationMaster.APPMST_RowStatus + ",");
            sql.Append(CORApplicationMaster.APPMST_RowVersion + ",'");
            sql.Append(CORApplicationMaster.APPMST_ConsumerNumber + "','");
            sql.Append(CORApplicationMaster.APPMST_Distributor + "','");
            sql.Append(CORApplicationMaster.APPMST_OMC + "','");
            sql.Append(CORApplicationMaster.APPMST_AADHARNO + "','");
            sql.Append(UpdateType + "'");

            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationMasterMsg(_RetVal, _RetStr);
        }
        public CORApplicationMasterChange UpdateCorApplication_Change(CORApplicationMaster CORApplicationMaster, string UpdateType, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ChangePassword ");
            sql.Append("'" + CORApplicationMaster.APPMST_CustomerID + "',");
            sql.Append("'" + CORApplicationMaster.APPMST_Password + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            string _RetVal = Convert.ToString(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion
            return new CORApplicationMasterChange(_RetVal, _RetStr);
        }


        public CORApplicationMasterProfile UpdateCORApplicationMaster_PRF(CORApplicationMaster CORApplicationMaster, string UpdateType, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_UpdateCustomerProfile ");
            sql.Append(CORApplicationMaster.APPMST_AppID + ",");
            sql.Append("'" + CORApplicationMaster.APPMST_Email + "',");
            sql.Append(CORApplicationMaster.APPMST_Mobile + ",");
            sql.Append("'" + CORApplicationMaster.APPMST_Phone + "'");



            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationMasterProfile(_RetVal, _RetStr);
        }

        public CORApplicationMasterMsg DeleteCORApplicationMaster(int CORApplicationMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CORApplicationMaster_Delete " + CORApplicationMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CORApplicationMasterMsg(_RetVal, _RetStr);
        }

    }
}
