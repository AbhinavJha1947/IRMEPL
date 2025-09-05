//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORApplicationMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORApplicationMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORApplicationMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _APPMST_AppDate;
        private string _APPMST_CustomerID;
        private int _APPMST_NoOfConnection;
        private string _APPMST_FName;
        private string _APPMST_MName;
        private string _APPMST_LName;
        //private string _APPMST_No_of_Family_members;
        private string _APPMST_DOB;
        private string _APPMST_Phone;
        private decimal _APPMST_Mobile;
        private string _APPMST_Email;
        private string _APPMST_Address1;
        private string _APPMST_Address2;
        private string _APPMST_LandmarkAdd;
        private int _APPMST_Country;
        private int _APPMST_State;
        private int _APPMST_City;
        private int _APPMST_Area;
        private int _APPMST_Pincode;
        private int _APPMST_PropertyTypeID;
        private int _APPMST_OwnershipStatus;
        private string _APPMST_EstablishmentName;
        private string _APPMST_TypeofEstablishmentIfOther;
        private string _APPMST_OwnerName;
        private string _APPMST_OwnerPhone;
        private int _APPMST_SubmitDoc1;
        private int _APPMST_SubmitDoc2;
        private int _APPMST_CorporateID;
        private int _APPMST_ContractorID;
        private int _APPMST_BillingTo;
        private int _APPMST_OMStatus;
        private int _APPMST_BillingStatus;
        private int _APPMST_CustType;
        private int _APPMST_CustCategory;
        private int _APPMST_PlanId;
        private string _APPMST_Remark;
        private int _APPMST_CenCode;
        private int _APPMST_CreatedByUserID;
        private string _APPMST_CreatedDateTime;
        private int _APPMST_UpdatedByUserID;
        private string _APPMST_UpdatedDateTime;
        private int _APPMST_RowStatus;
        private long _APPMST_RowVersion;
        private string _APPMST_BlockNo;
        private int _PayMode;
        private decimal _ReceivedAmt;
        private string _ChequeNo;
        private string _ChequeDate;
        
        private long _MICRNo;
        private int _BankID;

        private string _APPMST_BarCodeImagePath;
        private string _APPMST_Password;
        private string _APPMST_ConsumerNumber;
        private string _APPMST_Distributor;
        private string _APPMST_OMC;
        private string _APPMST_AADHARNO;
        private string _APPMST_Latitude;
        private string _APPMST_Longitude;
        private bool _APPMST_EmailSubscription;
        
        //private int _ChargeID;
        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public CORApplicationMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationMaster( decimal APPMST_AppID, string APPMST_AppNo, string APPMST_AppDate, string APPMST_CustomerID, int APPMST_NoOfConnection, string APPMST_FName, string APPMST_MName, string APPMST_LName,string APPMST_DOB, string APPMST_Phone, decimal APPMST_Mobile, string APPMST_Email, string APPMST_Address1, string APPMST_Address2, string APPMST_LandmarkAdd, string APPMST_BlockNo, int APPMST_Country, int APPMST_State, int APPMST_City, int APPMST_Area, int APPMST_Pincode, int APPMST_PropertyTypeID, int APPMST_OwnershipStatus, string APPMST_EstablishmentName, string APPMST_TypeofEstablishmentIfOther, string APPMST_OwnerName, string APPMST_OwnerPhone, int APPMST_SubmitDoc1, int APPMST_SubmitDoc2, int APPMST_CorporateID, int APPMST_ContractorID, int APPMST_BillingTo, int APPMST_OMStatus, int APPMST_BillingStatus, int APPMST_CustType, int APPMST_CustCategory, int APPMST_PlanId, string APPMST_Remark, int APPMST_CenCode, int APPMST_CreatedByUserID, string APPMST_CreatedDateTime, int APPMST_UpdatedByUserID, string APPMST_UpdatedDateTime, int APPMST_RowStatus, long APPMST_RowVersion, int PayMode, decimal ReceivedAmt, string ChequeNo, string ChequeDate, string APPMST_BarCodeImagePath, string APPMST_ConsumerNumber, string APPMST_Distributor, string APPMST_OMC, string APPMST_AADHARNO, bool APPMST_EmailSubscription, string APPMST_Password, string APPMST_Latitude, string APPMST_Longitude, long MICRNo, int BankID)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppDate = APPMST_AppDate;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_NoOfConnection = APPMST_NoOfConnection;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_LName = APPMST_LName;
            //this._APPMST_No_of_Family_members = APPMST_No_of_Family_members;
            this._APPMST_DOB = APPMST_DOB;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_Email = APPMST_Email;
            this._APPMST_Address1 = APPMST_Address1;
            this._APPMST_Address2 = APPMST_Address2;
            this._APPMST_LandmarkAdd = APPMST_LandmarkAdd;
            this._APPMST_BlockNo = APPMST_BlockNo;
            this._APPMST_Country = APPMST_Country;
            this._APPMST_State = APPMST_State;
            this._APPMST_City = APPMST_City;
            this._APPMST_Area = APPMST_Area;
            this._APPMST_Pincode = APPMST_Pincode;
            this._APPMST_PropertyTypeID = APPMST_PropertyTypeID;
            this._APPMST_OwnershipStatus = APPMST_OwnershipStatus;
            this._APPMST_EstablishmentName = APPMST_EstablishmentName;
            this._APPMST_TypeofEstablishmentIfOther = APPMST_TypeofEstablishmentIfOther;
            this._APPMST_OwnerName = APPMST_OwnerName;
            this._APPMST_OwnerPhone = APPMST_OwnerPhone;
            this._APPMST_SubmitDoc1 = APPMST_SubmitDoc1;
            this._APPMST_SubmitDoc2 = APPMST_SubmitDoc2;
            this._APPMST_CorporateID = APPMST_CorporateID;
            this._APPMST_ContractorID = APPMST_ContractorID;
            this._APPMST_BillingTo = APPMST_BillingTo;
            this._APPMST_OMStatus = APPMST_OMStatus;
            this._APPMST_BillingStatus = APPMST_BillingStatus;
            this._APPMST_CustType = APPMST_CustType;
            this._APPMST_CustCategory = APPMST_CustCategory;
            this._APPMST_PlanId = APPMST_PlanId;
            this._APPMST_Remark = APPMST_Remark;
            this._APPMST_CenCode = APPMST_CenCode;
            this._APPMST_CreatedByUserID = APPMST_CreatedByUserID;
            this._APPMST_CreatedDateTime = APPMST_CreatedDateTime;
            this._APPMST_UpdatedByUserID = APPMST_UpdatedByUserID;
            this._APPMST_UpdatedDateTime = APPMST_UpdatedDateTime;
            this._APPMST_RowStatus = APPMST_RowStatus;
            this._APPMST_RowVersion = APPMST_RowVersion;
            this._PayMode = PayMode;
            this._ReceivedAmt = ReceivedAmt;
            this._ChequeNo = ChequeNo;
            this._ChequeDate = ChequeDate;
            this._APPMST_BarCodeImagePath = APPMST_BarCodeImagePath;
            this._APPMST_ConsumerNumber = APPMST_ConsumerNumber;
            this._APPMST_Distributor = APPMST_Distributor;
            this._APPMST_OMC = APPMST_OMC;
            this._APPMST_AADHARNO = APPMST_AADHARNO;
            this._APPMST_EmailSubscription = APPMST_EmailSubscription;
            this._APPMST_Password = APPMST_Password;
            this._APPMST_Latitude = APPMST_Latitude;
            this._APPMST_Longitude = APPMST_Longitude;

            this._MICRNo = MICRNo;
            this._BankID = BankID;
            
        }
        //public CORApplicationMaster(long APPMST_AppID, int ChargeID)
        //{
        //    this._APPMST_AppID = APPMST_AppID;
        //    this._ChargeID = ChargeID;
        //}
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
       
        public decimal APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }


        public string APPMST_Password
        {
            get { return _APPMST_Password; }
            set { _APPMST_Password = value; }
        }

        public string APPMST_AADHARNO
        {
            get { return _APPMST_AADHARNO; }
            set { _APPMST_AADHARNO = value; }
        }

        public bool APPMST_EmailSubscription
        {
            get { return _APPMST_EmailSubscription; }
            set { _APPMST_EmailSubscription = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppDate
        {
            get { return _APPMST_AppDate; }
            set { _APPMST_AppDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_NoOfConnection
        {
            get { return _APPMST_NoOfConnection; }
            set { _APPMST_NoOfConnection = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_FName
        {
            get { return _APPMST_FName; }
            set { _APPMST_FName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_MName
        {
            get { return _APPMST_MName; }
            set { _APPMST_MName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_LName
        {
            get { return _APPMST_LName; }
            set { _APPMST_LName = value; }
        }

        //public string APPMST_No_of_Family_members
        //{
        //    get { return _APPMST_No_of_Family_members; }
        //    set { _APPMST_No_of_Family_members = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_DOB
        {
            get { return _APPMST_DOB; }
            set { _APPMST_DOB = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Email
        {
            get { return _APPMST_Email; }
            set { _APPMST_Email = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Address1
        {
            get { return _APPMST_Address1; }
            set { _APPMST_Address1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Address2
        {
            get { return _APPMST_Address2; }
            set { _APPMST_Address2 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_LandmarkAdd
        {
            get { return _APPMST_LandmarkAdd; }
            set { _APPMST_LandmarkAdd = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_BlockNo
        {
            get { return _APPMST_BlockNo; }
            set { _APPMST_BlockNo = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_Country
        {
            get { return _APPMST_Country; }
            set { _APPMST_Country = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_State
        {
            get { return _APPMST_State; }
            set { _APPMST_State = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_City
        {
            get { return _APPMST_City; }
            set { _APPMST_City = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_Area
        {
            get { return _APPMST_Area; }
            set { _APPMST_Area = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_Pincode
        {
            get { return _APPMST_Pincode; }
            set { _APPMST_Pincode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_PropertyTypeID
        {
            get { return _APPMST_PropertyTypeID; }
            set { _APPMST_PropertyTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_OwnershipStatus
        {
            get { return _APPMST_OwnershipStatus; }
            set { _APPMST_OwnershipStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_EstablishmentName
        {
            get { return _APPMST_EstablishmentName; }
            set { _APPMST_EstablishmentName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_TypeofEstablishmentIfOther
        {
            get { return _APPMST_TypeofEstablishmentIfOther; }
            set { _APPMST_TypeofEstablishmentIfOther = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_OwnerName
        {
            get { return _APPMST_OwnerName; }
            set { _APPMST_OwnerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_OwnerPhone
        {
            get { return _APPMST_OwnerPhone; }
            set { _APPMST_OwnerPhone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_SubmitDoc1
        {
            get { return _APPMST_SubmitDoc1; }
            set { _APPMST_SubmitDoc1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_SubmitDoc2
        {
            get { return _APPMST_SubmitDoc2; }
            set { _APPMST_SubmitDoc2 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CorporateID
        {
            get { return _APPMST_CorporateID; }
            set { _APPMST_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_ContractorID
        {
            get { return _APPMST_ContractorID; }
            set { _APPMST_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_BillingTo
        {
            get { return _APPMST_BillingTo; }
            set { _APPMST_BillingTo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_OMStatus
        {
            get { return _APPMST_OMStatus; }
            set { _APPMST_OMStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_BillingStatus
        {
            get { return _APPMST_BillingStatus; }
            set { _APPMST_BillingStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CustType
        {
            get { return _APPMST_CustType; }
            set { _APPMST_CustType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CustCategory
        {
            get { return _APPMST_CustCategory; }
            set { _APPMST_CustCategory = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_PlanId
        {
            get { return _APPMST_PlanId; }
            set { _APPMST_PlanId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Remark
        {
            get { return _APPMST_Remark; }
            set { _APPMST_Remark = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CenCode
        {
            get { return _APPMST_CenCode; }
            set { _APPMST_CenCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CreatedByUserID
        {
            get { return _APPMST_CreatedByUserID; }
            set { _APPMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CreatedDateTime
        {
            get { return _APPMST_CreatedDateTime; }
            set { _APPMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_UpdatedByUserID
        {
            get { return _APPMST_UpdatedByUserID; }
            set { _APPMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_UpdatedDateTime
        {
            get { return _APPMST_UpdatedDateTime; }
            set { _APPMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_RowStatus
        {
            get { return _APPMST_RowStatus; }
            set { _APPMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long APPMST_RowVersion
        {
            get { return _APPMST_RowVersion; }
            set { _APPMST_RowVersion = value; }
        }

        public int PayMode
        {
            get { return _PayMode; }
            set { _PayMode = value; }
        }

        public decimal ReceivedAmt
        {
            get { return _ReceivedAmt; }
            set { _ReceivedAmt = value; }
        }

        public string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
        }

        public string ChequeDate
        {
            get { return _ChequeDate; }
            set { _ChequeDate = value; }
        }
        public string APPMST_BarCodeImagePath
        {
            get { return _APPMST_BarCodeImagePath; }
            set { _APPMST_BarCodeImagePath = value; }
        }
        public string APPMST_ConsumerNumber
        {
            get { return _APPMST_ConsumerNumber; }
            set { _APPMST_ConsumerNumber = value; }
        }
        public string APPMST_Distributor
        {
            get { return _APPMST_Distributor; }
            set { _APPMST_Distributor = value; }
        }
        public string APPMST_OMC
        {
            get { return _APPMST_OMC; }
            set { _APPMST_OMC = value; }
        }
        public string APPMST_Latitude
        {
            get { return _APPMST_Latitude; }
            set { _APPMST_Latitude = value; }
        }
        
        public string APPMST_Longitude
        {
            get { return _APPMST_Longitude; }
            set { _APPMST_Longitude = value; }
        }
        //public int ChargeID
        //{
        //    get { return _ChargeID; }
        //    set { _ChargeID = value; }
        //}

        public long MICRNo
        {
            get { return _MICRNo; }
            set { _MICRNo = value; }
        }

        public Int32 BankID
        {
            get { return _BankID; }
            set { _BankID = value; }
        }
    }


    public class CORApplicationMasterProfile
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private long _APPMST_AppID;
        private decimal _APPMST_Mobile;
        private string _APPMST_Phone;
        private string _APPMST_Email;
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public CORApplicationMasterProfile(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;

        }
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }
        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationMasterProfile(long APPMST_AppID, decimal APPMST_Mobile, string APPMST_Phone, string APPMST_Email)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_Email = APPMST_Email;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_Phone = APPMST_Phone;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Email
        {
            get { return _APPMST_Email; }
            set { _APPMST_Email = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

    }



    public class CORApplicationMasterChange
    {
        #region "Variables Declaration"
        private long _APPMST_AppID;
        private string _APPMST_Password;
        private string _RetVal;
        private string _RetStr;
        #endregion

        public CORApplicationMasterChange(string RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;

        }
        public string RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }
        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }

        public CORApplicationMasterChange(long APPMST_AppID, string APPMST_Password)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_Password = APPMST_Password;
        }
        public long APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public string APPMST_Password
        {
            get { return _APPMST_Password; }
            set { _APPMST_Password = value; }
        }
    }

    public class CORApplicationMaster1
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private long _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _APPMST_AppName;
        private string _APPMST_CustomerID;
        private int _JOBHDR_ContractorID;

        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public CORApplicationMaster1() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationMaster1(long APPMST_AppID, string APPMST_AppNo, string APPMST_AppName, string APPMST_CustomerID, int JOBHDR_ContractorID)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppName = APPMST_AppName;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._JOBHDR_ContractorID = JOBHDR_ContractorID;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppName
        {
            get { return _APPMST_AppName; }
            set { _APPMST_AppName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_ContractorID
        {
            get { return _JOBHDR_ContractorID; }
            set { _JOBHDR_ContractorID = value; }
        }
    }

    public class CORApplicationMaster3
    {
        private string _APPMST_CustomerID;
        private decimal _APPMST_Mobile;

        public CORApplicationMaster3() { }

        public CORApplicationMaster3(string APPMST_CustomerID, decimal APPMST_Mobile)
        {
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_Mobile = APPMST_Mobile;
        }

        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

    }



    public class CORApplicationMaster2
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _APPMST_CenCode;
        private string _CENMST_CenterPrefix;
        private int _APPMST_AppID;
        private string _APPMST_Password;
        private string _APPMST_Email;
        private int _APPMST_CustType;
        private int _APPMST_PlanId;
        private string _APPMST_CustomerID;
        private string _APPMST_FName;
        private string _APPMST_LName;
        //private string _APPMST_No_of_Family_members;
        private string _APPMST_MName;
        private string _APPMST_AppNo;
        private string _CenterName;
        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public CORApplicationMaster2() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationMaster2(int APPMST_CenCode, string CENMST_CenterPrefix, int APPMST_AppID, int APPMST_CustType, int APPMST_PlanId, string APPMST_FName, 
            string APPMST_LName, string APPMST_Email, string APPMST_Password, string APPMST_CustomerID,string APPMST_MName,string APPMST_AppNo,
            string CenterName)
        {
            this._APPMST_CenCode = APPMST_CenCode;
            this._CENMST_CenterPrefix = CENMST_CenterPrefix;
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_Email = APPMST_Email;
            this._APPMST_Password = APPMST_Password;
            this._APPMST_CustType = APPMST_CustType;
            this._APPMST_PlanId = APPMST_PlanId;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_LName = APPMST_LName;
            //this._APPMST_No_of_Family_members = APPMST_No_of_Family_members;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CenterName = CenterName;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CenCode
        {
            get { return _APPMST_CenCode; }
            set { _APPMST_CenCode = value; }
        }

        public string CENMST_CenterPrefix
        {
            get { return _CENMST_CenterPrefix; }
            set { _CENMST_CenterPrefix = value; }
        }

        public string APPMST_MName
        {
            get { return _APPMST_MName; }
            set { _APPMST_MName = value; }
        }

        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }


        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }

        public int APPMST_CustType
        {
            get { return _APPMST_CustType; }
            set { _APPMST_CustType = value; }
        }

        public int APPMST_PlanId
        {
            get { return _APPMST_PlanId; }
            set { _APPMST_PlanId = value; }
        }

        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        public string APPMST_FName
        {
            get { return _APPMST_FName; }
            set { _APPMST_FName = value; }
        }

        public string APPMST_Email
        {
            get { return _APPMST_Email; }
            set { _APPMST_Email = value; }
        }

        //public string APPMST_No_of_Family_members
        //{
        //    get { return _APPMST_No_of_Family_members; }
        //    set { _APPMST_No_of_Family_members = value; }
        //}

        public string APPMST_Password
        {
            get { return _APPMST_Password; }
            set { _APPMST_Password = value; }
        }
        public string APPMST_LName
        {
            get { return _APPMST_LName; }
            set { _APPMST_LName = value; }
        }
    }
    public class CORApplicationMasterForAS
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _APPMST_AppID;
        private string _APPMST_Address1;
        private string _APPMST_Address2;
        private string _APPMST_AppNo;
        private string _APPMST_AppDate;
        private string _CENMST_Name;
        private string _APPMST_CustomerID;
        private string _CusType;
        private decimal _APPMST_Mobile;
        private string _APPMST_FName;
        private string _APPMST_MName;
        private string _APPMST_LName;
        private string _APPMST_OwnerName;
        private string _Ownerstatus;
        private string _APPMST_Phone;
        private int _APPMST_Pincode;
        private string _Plantype;
        private string _PlanName;
        private string _PropertyType;
        private string _areaName;
        private string _OMSTATUS;
        private int _APPMST_CorporateID;
        private string _APPMST_Remark;

        //Hina Added 23/10/2019
        private string _CenterState;




        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public CORApplicationMasterForAS() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationMasterForAS(decimal APPMST_AppID, string APPMST_Address1, string APPMST_Address2, string APPMST_AppNo, string APPMST_AppDate, string CENMST_Name, string APPMST_CustomerID, string CusType, decimal APPMST_Mobile, string APPMST_FName, string APPMST_MName, string APPMST_LName, string APPMST_OwnerName, string Ownerstatus, string APPMST_Phone, int APPMST_Pincode, string Plantype, string PlanName, string PropertyType, string areaName, string OMSTATUS, int APPMST_CorporateID, string APPMST_Remark, string CenterState)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_Address1 = APPMST_Address1;
            this._APPMST_Address2 = APPMST_Address2;
            this._APPMST_AppDate = APPMST_AppDate;

            this._CENMST_Name = CENMST_Name;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._CusType = CusType;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_LName = APPMST_LName;
            this._APPMST_OwnerName = APPMST_OwnerName;
            this._Ownerstatus = Ownerstatus;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Pincode = APPMST_Pincode;
            this._Plantype = Plantype;
            this._PlanName = PlanName;
            this._PropertyType = PropertyType;
            this._areaName = areaName;
            this._OMSTATUS = OMSTATUS;
            this._APPMST_CorporateID = APPMST_CorporateID;
            this._APPMST_Remark = APPMST_Remark;
            this._CenterState = CenterState;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public string APPMST_Remark
        {
            get { return _APPMST_Remark; }
            set { _APPMST_Remark = value; }
        }
        public string APPMST_Address1
        {
            get { return _APPMST_Address1; }
            set { _APPMST_Address1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Address2
        {
            get { return _APPMST_Address2; }
            set { _APPMST_Address2 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public string APPMST_AppDate
        {
            get { return _APPMST_AppDate; }
            set { _APPMST_AppDate = value; }
        }
        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string CusType
        {
            get { return _CusType; }
            set { _CusType = value; }
        }
        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }
        public string APPMST_FName
        {
            get { return _APPMST_FName; }
            set { _APPMST_FName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_MName
        {
            get { return _APPMST_MName; }
            set { _APPMST_MName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_LName
        {
            get { return _APPMST_LName; }
            set { _APPMST_LName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public string APPMST_OwnerName
        {
            get { return _APPMST_OwnerName; }
            set { _APPMST_OwnerName = value; }
        }
        public string Ownerstatus
        {
            get { return _Ownerstatus; }
            set { _Ownerstatus = value; }
        }

        public int APPMST_CorporateID
        {
            get { return _APPMST_CorporateID; }
            set { _APPMST_CorporateID = value; }
        }
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }
        public int APPMST_Pincode
        {
            get { return _APPMST_Pincode; }
            set { _APPMST_Pincode = value; }
        }
        public string Plantype
        {
            get { return _Plantype; }
            set { _Plantype = value; }
        }
        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
        }

        public string PropertyType
        {
            get { return _PropertyType; }
            set { _PropertyType = value; }
        }
        public string areaName
        {
            get { return _areaName; }
            set { _areaName = value; }
        }
        public string OMSTATUS
        {
            get { return _OMSTATUS; }
            set { _OMSTATUS = value; }
        }

        public string CenterState
        {
            get {return _CenterState; }
            set { _CenterState = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>


    }
    public class CORCustomerSurveyDetail
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CUSTSRV_ID;
        private int _CUSTSRV_ApplicationID;
        private string _UserName;
        private string _APPMST_AppNo;
        private string _CUSTSRV_MeterNo;
        private string _CUSTSRV_MeterReading;
        private string _CUSTSRV_Latitude;
        private string _CUSTSRV_Longitude;
        private string _CUSTSRV_RubberTube;
        private string _CUSTSRV_Remarks;
        private int _CUSTSRV_CreatedByUserID;
        private string _CUSTSRV_CreatedDateTime;

        private string _customer_name;
        private string _customer_address;
        private int _APPMST_State;
        private string _APPMST_StateName;
        private int _APPMST_City;
        private string _APPMST_CityName;
        private int _APPMST_Area;
        private string _APPMST_Area_Name;
        private string _APPMST_Mobile;
        private string _APPMST_Email;
        private int _Count;
        private long _ROwVersion;
        //private int _RetVal;
        //private string _RetStr;

        #endregion

        /// <summary>
        /// Default constructor for USRUserMaster class.
        /// </summary>
        public CORCustomerSurveyDetail() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORCustomerSurveyDetail(int CUSTSRV_ID, int CUSTSRV_ApplicationID, string UserName, string APPMST_AppNo, string CUSTSRV_MeterNo, string CUSTSRV_MeterReading, string CUSTSRV_Latitude, string CUSTSRV_Longitude, string CUSTSRV_RubberTube, string customer_name, string customer_address, int APPMST_State, string APPMST_StateName, int APPMST_City, string APPMST_CityName, int APPMST_Area, string APPMST_Area_Name, string APPMST_Mobile, string APPMST_Email, string CUSTSRV_Remarks,int Count, int CUSTSRV_CreatedByUserID, string CUSTSRV_CreatedDateTime, long ROwVersion)
        {
            this._CUSTSRV_ID = CUSTSRV_ID;
            this._CUSTSRV_ApplicationID = CUSTSRV_ApplicationID;
            this._UserName = UserName;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CUSTSRV_MeterNo = CUSTSRV_MeterNo;
            this._CUSTSRV_MeterReading = CUSTSRV_MeterReading;
            this._CUSTSRV_Latitude = CUSTSRV_Latitude;
            this._CUSTSRV_Longitude = CUSTSRV_Longitude;
            this._CUSTSRV_RubberTube = CUSTSRV_RubberTube;
            this._CUSTSRV_Remarks = CUSTSRV_Remarks;
            this._CUSTSRV_CreatedByUserID = CUSTSRV_CreatedByUserID;
            this._CUSTSRV_CreatedDateTime = CUSTSRV_CreatedDateTime;
            this._customer_name = customer_name;
            this._customer_address = customer_address;
            this._APPMST_State = APPMST_State;
            this._APPMST_StateName = APPMST_StateName;
            this._APPMST_City = APPMST_City;
            this._APPMST_CityName = APPMST_CityName;
            this._APPMST_Area = APPMST_Area;
            this._APPMST_Area_Name = APPMST_Area_Name;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_Email = APPMST_Email;
            this._Count = Count;
            //this._RetVal = RetVal;
            //this._RetStr = RetStr;
        }

        //public int RetVal
        //{
        //    get { return _RetVal; }
        //    set { _RetVal = value; }
        //}

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public string RetStr
        //{
        //    get { return _RetStr; }
        //    set { _RetStr = value; }
        //}

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CUSTSRV_ID
        {
            get { return _CUSTSRV_ID; }
            set { _CUSTSRV_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CUSTSRV_ApplicationID
        {
            get { return _CUSTSRV_ApplicationID; }
            set { _CUSTSRV_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CUSTSRV_MeterNo
        {
            get { return _CUSTSRV_MeterNo; }
            set { _CUSTSRV_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CUSTSRV_MeterReading
        {
            get { return _CUSTSRV_MeterReading; }
            set { _CUSTSRV_MeterReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CUSTSRV_Latitude
        {
            get { return _CUSTSRV_Latitude; }
            set { _CUSTSRV_Latitude = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CUSTSRV_Longitude
        {
            get { return _CUSTSRV_Longitude; }
            set { _CUSTSRV_Longitude = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CUSTSRV_Remarks
        {
            get { return _CUSTSRV_Remarks; }
            set { _CUSTSRV_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CUSTSRV_RubberTube
        {
            get { return _CUSTSRV_RubberTube; }
            set { _CUSTSRV_RubberTube = value; }
        }

        public int CUSTSRV_CreatedByUserID
        {
            get { return _CUSTSRV_CreatedByUserID; }
            set { _CUSTSRV_CreatedByUserID = value; }
        }

        public string customer_name
        {
            get { return _customer_name; }
            set { _customer_name = value; }
        }
        public string customer_address
        {
            get { return _customer_address; }
            set { _customer_address = value; }
        }
        public int APPMST_State
        {
            get { return _APPMST_State; }
            set { _APPMST_State = value; }
        }
        public string APPMST_StateName
        {
            get { return _APPMST_StateName; }
            set { _APPMST_StateName = value; }
        }
        public int APPMST_City
        {
            get { return _APPMST_City; }
            set { _APPMST_City = value; }
        }
        public string APPMST_CityName
        {
            get { return _APPMST_CityName; }
            set { _APPMST_CityName = value; }
        }
        public int APPMST_Area
        {
            get { return _APPMST_Area; }
            set { _APPMST_Area = value; }
        }
        public string APPMST_Area_Name
        {
            get { return _APPMST_Area_Name; }
            set { _APPMST_Area_Name = value; }
        }
        public string APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }
        public string APPMST_Email
        {
            get { return _APPMST_Email; }
            set { _APPMST_Email = value; }
        }

        public string CUSTSRV_CreatedDateTime
        {
            get { return _CUSTSRV_CreatedDateTime; }
            set { _CUSTSRV_CreatedDateTime = value; }
        }

        public long ROwVersion
        {
            get { return _ROwVersion; }
            set { _ROwVersion = value; }
        }

    }
    public class CORApplicationMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _APPMST_AppDate;
        private string _APPMST_CustomerID;
        private string _APPMST_FName;
        private string _APPMST_MName;
        private string _APPMST_LName;
        //private string _APPMST_No_of_Family_members;
        private string _APPMST_Name;
        private string _APPMST_Area;
        private string _AREMST_Name;
        private string _StateName;
        private string _CityName;
        private string _APPMST_CustType;
        private string _APPMST_CustCategory;
        private string _APPMST_Plan;
        private string _APPMST_Address;
        private string _APPMST_Landmark;
        private string _APPMST_BlockNo;
        private string _APPMST_WOType;
        private int _APPMST_WOTYPEID;
        private int _APPMST_CustType1;
        private int _APPMST_PlanId;
        private string _APPMST_OMStatus;
        private string _APPMST_Phone;
        private decimal _APPMST_Mobile;
        private string _APPMST_Email;
        private string _ConversionDate;
        private string _APPMST_RowStatus;
        private int _Count;
        private string _APPMST_BarCodeImagePath;
        private string _APPMST_Latitude;
        private string _APPMST_Longitude;
        private int _APPMST_ContractorID;

        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public CORApplicationMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationMasterList(int APPMST_AppID, string APPMST_AppNo, string APPMST_AppDate, string APPMST_CustomerID, string APPMST_FName, string APPMST_MName, string APPMST_LName,  string APPMST_Name, string APPMST_Area, string AREMST_Name, string StateName, string CityName, string APPMST_CustType, string APPMST_CustCategory, string APPMST_Plan, string APPMST_WOType, int APPMST_WOTYPEID, int APPMST_CustType1, int APPMST_PlanId, string APPMST_Address, string APPMST_Landmark, string APPMST_BlockNo, string APPMST_OMStatus, string APPMST_Phone, decimal APPMST_Mobile, string APPMST_Email, string ConversionDate, string APPMST_RowStatus, int Count, string APPMST_BarCodeImagePath, string APPMST_Latitude, string APPMST_Longitude, int APPMST_ContractorID)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppDate = APPMST_AppDate;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_LName = APPMST_LName;
            //this._APPMST_No_of_Family_members = APPMST_No_of_Family_members;
            this._APPMST_Name = APPMST_Name;
            this._APPMST_Area = APPMST_Area;
            this._AREMST_Name = AREMST_Name;
            this._StateName = StateName;
            this._CityName = CityName;
            this._APPMST_CustType = APPMST_CustType;
            this._APPMST_CustCategory = APPMST_CustCategory;
            this._APPMST_Plan = APPMST_Plan;
            this._APPMST_WOType = APPMST_WOType;
            this._APPMST_WOTYPEID = APPMST_WOTYPEID;
            this._APPMST_CustType1 = APPMST_CustType1;
            this._APPMST_PlanId = APPMST_PlanId;
            this._APPMST_Address = APPMST_Address;
            this._APPMST_Landmark = APPMST_Landmark;
            this._APPMST_BlockNo = APPMST_BlockNo;
            this._APPMST_OMStatus = APPMST_OMStatus;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_Email = APPMST_Email;
            this._ConversionDate = ConversionDate;
            this._APPMST_RowStatus = APPMST_RowStatus;
            this._Count = Count;
            this._APPMST_BarCodeImagePath = APPMST_BarCodeImagePath;
            this._APPMST_Latitude = APPMST_Latitude;
            this._APPMST_Longitude = APPMST_Longitude;
            this._APPMST_ContractorID = APPMST_ContractorID;
        }
        public CORApplicationMasterList(decimal APPMST_Mobile)
        {
            this._APPMST_Mobile = APPMST_Mobile;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public int APPMST_ContractorID
        {
            get { return _APPMST_ContractorID; }
            set { _APPMST_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppDate
        {
            get { return _APPMST_AppDate; }
            set { _APPMST_AppDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_FName
        {
            get { return _APPMST_FName; }
            set { _APPMST_FName = value; }
        }

        public string APPMST_MName
        {
            get { return _APPMST_MName; }
            set { _APPMST_MName = value; }
        }

        public string APPMST_LName
        {
            get { return _APPMST_LName; }
            set { _APPMST_LName = value; }
        }

        //public string APPMST_No_of_Family_members
        //{
        //    get { return _APPMST_No_of_Family_members; }
        //    set { _APPMST_No_of_Family_members = value; }
        //}
        public string APPMST_Name
        {
            get { return _APPMST_Name; }
            set { _APPMST_Name = value; }
        }

        public string APPMST_Area
        {
            get { return _APPMST_Area; }
            set { _APPMST_Area = value; }
        }

        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }
        }

        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }

        public string cityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustType
        {
            get { return _APPMST_CustType; }
            set { _APPMST_CustType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustCategory
        {
            get { return _APPMST_CustCategory; }
            set { _APPMST_CustCategory = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Plan
        {
            get { return _APPMST_Plan; }
            set { _APPMST_Plan = value; }
        }
        public string APPMST_WOType
        {
            get { return _APPMST_WOType; }
            set { _APPMST_WOType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_WOTYPEID
        {
            get { return _APPMST_WOTYPEID; }
            set { _APPMST_WOTYPEID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_CustType1
        {
            get { return _APPMST_CustType1; }
            set { _APPMST_CustType1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_PlanId
        {
            get { return _APPMST_PlanId; }
            set { _APPMST_PlanId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Address
        {
            get { return _APPMST_Address; }
            set { _APPMST_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Landmark
        {
            get { return _APPMST_Landmark; }
            set { _APPMST_Landmark = value; }
        }

        public string APPMST_OMStatus
        {
            get { return _APPMST_OMStatus; }
            set { _APPMST_OMStatus = value; }
        }
        public string APPMST_Latitude
        {
            get { return _APPMST_Latitude; }
            set { _APPMST_Latitude = value; }
        }
        public string APPMST_Longitude
        {
            get { return _APPMST_Longitude; }
            set { _APPMST_Longitude = value; }
        }
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }
        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }
        public string APPMST_BlockNo
        {
            get { return _APPMST_BlockNo; }
            set { _APPMST_BlockNo = value; }
        }
        public string APPMST_Email
        {
            get { return _APPMST_Email; }
            set { _APPMST_Email = value; }
        }

        public string ConversionDate
        {
            get { return _ConversionDate; }
            set { _ConversionDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_RowStatus
        {
            get { return _APPMST_RowStatus; }
            set { _APPMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public string APPMST_BarCodeImagePath
        {
            get { return _APPMST_BarCodeImagePath; }
            set { _APPMST_BarCodeImagePath = value; }
        }
    }

    public class CORApplicationMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORApplicationMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORApplicationMasterMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }
        /// <summary>
        //Gets or sets unique Salutation identifier. 
        //The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }
        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }

    public class createLoginRequest
    {
        public string customer_id { get; set; }
        public string password { get; set; }

    }
}
