//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CORNameTransferMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORNameTransferMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORNameTransferMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _NAMMST_ID;
        private decimal _NAMMST_ApplicationID;
        private string _APPMST_CustomerID;
        private string _NAMMST_FName;
        private string _NAMMST_MName;
        private string _NAMMST_LName;
        private decimal _NAMMST_Charges;
        private int _NAMMST_TariffID;
        private string _NAMMST_TransferDT;
        private int _NAMMST_SubmitDoc1;
        private int _NAMMST_SubmitDoc2;
        private string _NAMMST_Phone;
        private decimal _NAMMST_Mobile;
        private string _NAMMST_Reason;
        private int _NAMMST_CreatedByUserID;
        private string _NAMMST_CreatedDateTime;
        private int _NAMMST_UpdatedByUserID;
        private string _NAMMST_UpdatedDateTime;
        private int _NAMMST_RowStatus;
        private long _NAMMST_RowVersion;
        private string _APPMST_AppNo;
        private string _APPMST_FName;
        private string _APPMST_MName;
        private string _APPMST_LName;
        private string _APPMST_Phone;
        private decimal _APPMST_Mobile;
        private int _APPMST_SubmitDoc1;
        private int _APPMST_SubmitDoc2;
        private string _cusType;
        private string _PLAMST_PlanName;
        private string _NAMMST_RequestNo;
        private string _Message;
        private int _Editable;
        #endregion

        /// <summary>
        /// Default constructor for CORNameTransferMaster class.
        /// </summary>
        public CORNameTransferMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORNameTransferMaster(int NAMMST_ID, decimal NAMMST_ApplicationID, string NAMMST_FName, string NAMMST_MName, string NAMMST_LName, decimal NAMMST_Charges, int NAMMST_TariffID, string NAMMST_TransferDT, int NAMMST_SubmitDoc1, int NAMMST_SubmitDoc2, string NAMMST_Phone, decimal NAMMST_Mobile, string NAMMST_Reason, int NAMMST_CreatedByUserID, string NAMMST_CreatedDateTime, int NAMMST_UpdatedByUserID, string NAMMST_UpdatedDateTime, int NAMMST_RowStatus, long NAMMST_RowVersion, string APPMST_AppNo, string APPMST_CustomerID, string APPMST_FName, string APPMST_MName, string APPMST_LName, string APPMST_Phone, decimal APPMST_Mobile, int APPMST_SubmitDoc1, int APPMST_SubmitDoc2, string cusType, string PLAMST_PlanName, string NAMMST_RequestNo, string Message, int Editable)
        {
            this._NAMMST_ID = NAMMST_ID;
            this._NAMMST_ApplicationID = NAMMST_ApplicationID;
            this._NAMMST_FName = NAMMST_FName;
            this._NAMMST_MName = NAMMST_MName;
            this._NAMMST_LName = NAMMST_LName;
            this._NAMMST_Charges = NAMMST_Charges;
            this._NAMMST_TariffID = NAMMST_TariffID;
            this._NAMMST_TransferDT = NAMMST_TransferDT;
            this._NAMMST_SubmitDoc1 = NAMMST_SubmitDoc1;
            this._NAMMST_SubmitDoc2 = NAMMST_SubmitDoc2;
            this._NAMMST_Phone = NAMMST_Phone;
            this._NAMMST_Mobile = NAMMST_Mobile;
            this._NAMMST_Reason = NAMMST_Reason;
            this._NAMMST_CreatedByUserID = NAMMST_CreatedByUserID;
            this._NAMMST_CreatedDateTime = NAMMST_CreatedDateTime;
            this._NAMMST_UpdatedByUserID = NAMMST_UpdatedByUserID;
            this._NAMMST_UpdatedDateTime = NAMMST_UpdatedDateTime;
            this._NAMMST_RowStatus = NAMMST_RowStatus;
            this._NAMMST_RowVersion = NAMMST_RowVersion;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_LName = APPMST_LName;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_SubmitDoc1 = APPMST_SubmitDoc1;
            this._APPMST_SubmitDoc2 = APPMST_SubmitDoc2;
            this._cusType = cusType;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._NAMMST_RequestNo = NAMMST_RequestNo;
            this._Message = Message;
            this._Editable = Editable;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_ID
        {
            get { return _NAMMST_ID; }
            set { _NAMMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NAMMST_ApplicationID
        {
            get { return _NAMMST_ApplicationID; }
            set { _NAMMST_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_FName
        {
            get { return _NAMMST_FName; }
            set { _NAMMST_FName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_MName
        {
            get { return _NAMMST_MName; }
            set { _NAMMST_MName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_LName
        {
            get { return _NAMMST_LName; }
            set { _NAMMST_LName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NAMMST_Charges
        {
            get { return _NAMMST_Charges; }
            set { _NAMMST_Charges = value; }
        }
        
        public int NAMMST_TariffID
        {
            get { return _NAMMST_TariffID; }
            set { _NAMMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_TransferDT
        {
            get { return _NAMMST_TransferDT; }
            set { _NAMMST_TransferDT = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_SubmitDoc1
        {
            get { return _NAMMST_SubmitDoc1; }
            set { _NAMMST_SubmitDoc1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_SubmitDoc2
        {
            get { return _NAMMST_SubmitDoc2; }
            set { _NAMMST_SubmitDoc2 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_Phone
        {
            get { return _NAMMST_Phone; }
            set { _NAMMST_Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NAMMST_Mobile
        {
            get { return _NAMMST_Mobile; }
            set { _NAMMST_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_Reason
        {
            get { return _NAMMST_Reason; }
            set { _NAMMST_Reason = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_CreatedByUserID
        {
            get { return _NAMMST_CreatedByUserID; }
            set { _NAMMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_CreatedDateTime
        {
            get { return _NAMMST_CreatedDateTime; }
            set { _NAMMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_UpdatedByUserID
        {
            get { return _NAMMST_UpdatedByUserID; }
            set { _NAMMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NAMMST_UpdatedDateTime
        {
            get { return _NAMMST_UpdatedDateTime; }
            set { _NAMMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_RowStatus
        {
            get { return _NAMMST_RowStatus; }
            set { _NAMMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long NAMMST_RowVersion
        {
            get { return _NAMMST_RowVersion; }
            set { _NAMMST_RowVersion = value; }
        }

        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
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
        public int APPMST_SubmitDoc1
        {
            get { return _APPMST_SubmitDoc1; }
            set { _APPMST_SubmitDoc1 = value; }
        }
        public int APPMST_SubmitDoc2
        {
            get { return _APPMST_SubmitDoc2; }
            set { _APPMST_SubmitDoc2 = value; }
        }
        public string NAMMST_RequestNo
        {
            get { return _NAMMST_RequestNo; }
            set { _NAMMST_RequestNo = value; }
        }
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        public int Editable
        {
            get { return _Editable; }
            set { _Editable = value; }
        }
    }

    public class CORNameTransferMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _NAMMST_ID;
        private decimal _NAMMST_ApplicationID;
        private string _APPMST_AppNo;
        private string _APPMST_CustomerID;
        private string _NAMMST_TransferDT;
        private string _NAMMST_Name;
        private decimal _NAMMST_Charges;
        private decimal _NAMMST_ChargesReceived;
        private decimal _NAMMST_Mobile;
        private string _NAMMST_Phone;
        private string _NAMMST_Reason;
        private string _NAMMST_RequestNo;
        private int _Count;
        #endregion
        public CORNameTransferMasterList() { }
        public CORNameTransferMasterList(int NAMMST_ID, decimal NAMMST_ApplicationID, string APPMST_AppNo, string APPMST_CustomerID, string NAMMST_TransferDT, string NAMMST_Name, decimal NAMMST_Charges, decimal NAMMST_ChargesReceived, decimal NAMMST_Mobile, string NAMMST_Phone, string NAMMST_Reason, string NAMMST_RequestNo, int Count)
        {

            this._NAMMST_ID = NAMMST_ID;
            this._NAMMST_ApplicationID = NAMMST_ApplicationID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._NAMMST_TransferDT = NAMMST_TransferDT;
            this._NAMMST_Name = NAMMST_Name;
            this._NAMMST_Charges = NAMMST_Charges;
            this._NAMMST_ChargesReceived = NAMMST_ChargesReceived;            
            this._NAMMST_Phone = NAMMST_Phone;
            this._NAMMST_Mobile = NAMMST_Mobile;
            this._NAMMST_Reason = NAMMST_Reason;
            this._NAMMST_RequestNo = NAMMST_RequestNo;
            this._Count = Count;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NAMMST_ID
        {
            get { return _NAMMST_ID; }
            set { _NAMMST_ID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public decimal NAMMST_ApplicationID
        {
            get { return _NAMMST_ApplicationID; }
            set { _NAMMST_ApplicationID = value; }
        }

        public decimal NAMMST_Charges
        {
            get { return _NAMMST_Charges; }
            set { _NAMMST_Charges = value; }
        }

        public decimal NAMMST_ChargesReceived
        {
            get { return _NAMMST_ChargesReceived; }
            set { _NAMMST_ChargesReceived = value; }

        }
        public string NAMMST_TransferDT
        {
            get { return _NAMMST_TransferDT; }
            set { _NAMMST_TransferDT = value; }
        }
        public string NAMMST_Name
        {
            get { return _NAMMST_Name; }
            set { _NAMMST_Name = value; }
        }
        public string NAMMST_Phone
        {
            get { return _NAMMST_Phone; }
            set { _NAMMST_Phone = value; }
        }
        public decimal NAMMST_Mobile
        {
            get { return _NAMMST_Mobile; }
            set { _NAMMST_Mobile = value; }
        }
        public string NAMMST_Reason
        {
            get { return _NAMMST_Reason; }
            set { _NAMMST_Reason = value; }
        }
        public string NAMMST_RequestNo
        {
            get { return _NAMMST_RequestNo; }
            set { _NAMMST_RequestNo = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }


    public class CORNameTransferMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORNameTransferMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORNameTransferMasterMsg(int RetVal, string RetStr)
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

