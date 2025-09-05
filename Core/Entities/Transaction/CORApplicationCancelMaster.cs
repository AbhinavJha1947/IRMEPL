//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CORApplicationCancelMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORApplicationCancelMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORApplicationCancelMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _APCMST_ID;
        private decimal _APCMST_ApplicationID;
        private decimal _APCMST_Charges;
        private int _APCMST_TariffID;
        private string _APCMST_CancelDT;
        private string _APCMST_Reason;
        private int _APCMST_CreatedByUserID;
        private string _APCMST_CreatedDateTime;
        private int _APCMST_UpdatedByUserID;
        private string _APCMST_UpdatedDateTime;
        private int _APCMST_RowStatus;
        private long _APCMST_RowVersion;
        private string _APPMST_AppNo;
        private string _APPMST_Name;
        private string _APPMST_Phone;
        private decimal _APPMST_Mobile;
        private string _cusType;
        private string _PLAMST_PlanName;
        private string _APCMST_RequestNo;
        private int _Editable;
        #endregion

        /// <summary>
        /// Default constructor for CORApplicationCancelMaster class.
        /// </summary>
        public CORApplicationCancelMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORApplicationCancelMaster(int APCMST_ID, decimal APCMST_ApplicationID, decimal APCMST_Charges, int APCMST_TariffID, string APCMST_CancelDT, string APCMST_Reason, int APCMST_CreatedByUserID, string APCMST_CreatedDateTime, int APCMST_UpdatedByUserID, string APCMST_UpdatedDateTime, int APCMST_RowStatus, long APCMST_RowVersion, string APPMST_AppNo, string APPMST_Name, string APPMST_Phone, decimal APPMST_Mobile, string cusType, string PLAMST_PlanName, string APCMST_RequestNo, int Editable)
        {
            this._APCMST_ID = APCMST_ID;
            this._APCMST_ApplicationID = APCMST_ApplicationID;
            this._APCMST_Charges = APCMST_Charges;
            this._APCMST_TariffID = APCMST_TariffID;
            this._APCMST_CancelDT = APCMST_CancelDT;
            this._APCMST_Reason = APCMST_Reason;
            this._APCMST_CreatedByUserID = APCMST_CreatedByUserID;
            this._APCMST_CreatedDateTime = APCMST_CreatedDateTime;
            this._APCMST_UpdatedByUserID = APCMST_UpdatedByUserID;
            this._APCMST_UpdatedDateTime = APCMST_UpdatedDateTime;
            this._APCMST_RowStatus = APCMST_RowStatus;
            this._APCMST_RowVersion = APCMST_RowVersion;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_Name = APPMST_Name;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._cusType = cusType;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._APCMST_RequestNo = APCMST_RequestNo;
            this._Editable = Editable;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APCMST_ID
        {
            get { return _APCMST_ID; }
            set { _APCMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal APCMST_ApplicationID
        {
            get { return _APCMST_ApplicationID; }
            set { _APCMST_ApplicationID = value; }
        }    

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal APCMST_Charges
        {
            get { return _APCMST_Charges; }
            set { _APCMST_Charges = value; }
        }
        
        public int APCMST_TariffID
        {
            get { return _APCMST_TariffID; }
            set { _APCMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APCMST_CancelDT
        {
            get { return _APCMST_CancelDT; }
            set { _APCMST_CancelDT = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APCMST_Reason
        {
            get { return _APCMST_Reason; }
            set { _APCMST_Reason = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APCMST_CreatedByUserID
        {
            get { return _APCMST_CreatedByUserID; }
            set { _APCMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APCMST_CreatedDateTime
        {
            get { return _APCMST_CreatedDateTime; }
            set { _APCMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APCMST_UpdatedByUserID
        {
            get { return _APCMST_UpdatedByUserID; }
            set { _APCMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APCMST_UpdatedDateTime
        {
            get { return _APCMST_UpdatedDateTime; }
            set { _APCMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APCMST_RowStatus
        {
            get { return _APCMST_RowStatus; }
            set { _APCMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long APCMST_RowVersion
        {
            get { return _APCMST_RowVersion; }
            set { _APCMST_RowVersion = value; }
        }

        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
       
        public string APPMST_Name
        {
            get { return _APPMST_Name; }
            set { _APPMST_Name = value; }
        }
   
        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }
        public string cusType
        {
            get { return _cusType; }
            set { _cusType = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
       
        public string APCMST_RequestNo
        {
            get { return _APCMST_RequestNo; }
            set { _APCMST_RequestNo = value; }
        }

        public int Editable
        {
            get { return _Editable; }
            set { _Editable = value; }
        }
    }

    public class CORApplicationCancelMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _APCMST_ID;
        private decimal _APCMST_ApplicationID;
        private string _APPMST_AppNo;
        private string _APCMST_CancelDT;
        private string _APPMST_Name;
        private decimal _APCMST_Charges;
        private decimal _APPMST_Mobile;
        private string _APPMST_Phone;
        private string _APCMST_Reason;
        private string _APCMST_RequestNo;        
        private int _Count;
        #endregion
        public CORApplicationCancelMasterList() { }
        public CORApplicationCancelMasterList(int APCMST_ID, decimal APCMST_ApplicationID, string APPMST_AppNo, string APCMST_CancelDT, string APPMST_Name, decimal APCMST_Charges, decimal APPMST_Mobile, string APPMST_Phone, string APCMST_Reason, string APCMST_RequestNo, int Count)
        {

            this._APCMST_ID = APCMST_ID;
            this._APCMST_ApplicationID = APCMST_ApplicationID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APCMST_CancelDT = APCMST_CancelDT;
            this._APPMST_Name = APPMST_Name;
            this._APCMST_Charges = APCMST_Charges;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APCMST_Reason = APCMST_Reason;
            this._APCMST_RequestNo = APCMST_RequestNo;
            this._Count = Count;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APCMST_ID
        {
            get { return _APCMST_ID; }
            set { _APCMST_ID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
    
        public decimal APCMST_ApplicationID
        {
            get { return _APCMST_ApplicationID; }
            set { _APCMST_ApplicationID = value; }
        }

        public decimal APCMST_Charges
        {
            get { return _APCMST_Charges; }
            set { _APCMST_Charges = value; }
        }
        public string APCMST_CancelDT
        {
            get { return _APCMST_CancelDT; }
            set { _APCMST_CancelDT = value; }
        }
        public string APPMST_Name
        {
            get { return _APPMST_Name; }
            set { _APPMST_Name = value; }
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
        public string APCMST_Reason
        {
            get { return _APCMST_Reason; }
            set { _APCMST_Reason = value; }
        }
        public string APCMST_RequestNo
        {
            get { return _APCMST_RequestNo; }
            set { _APCMST_RequestNo = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }


    public class CORApplicationCancelMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORApplicationCancelMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORApplicationCancelMasterMsg(int RetVal, string RetStr)
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
}

