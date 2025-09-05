//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORBankMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORBankMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORBankMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BANMST_BkCode;
        private int _BANMST_MicrNo;
        private string _BANMST_BankName;
        private string _BANMST_Address;
        private string _BANMST_AccountNo;
        private string _BANMST_SubAccDomestic;
        private string _BANMST_SubAccCommercial;
        private string _BANMST_SubAccNonCommercial;
        private string _BANMST_ManagerName;
        private int _BANMST_CompanyBank;
        private int _BANMST_CreatedByUserID;
        private string _BANMST_CreatedDateTime;
        private int _BANMST_UpdatedByUserID;
        private string _BANMST_UpdatedDateTime;
        private int _BANMST_RowStatus;
        private int _BANMST_CENCode; 
        private long _BANMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORBankMaster class.
        /// </summary>
        public CORBankMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORBankMaster(int BANMST_BkCode, int BANMST_MicrNo, string BANMST_BankName, string BANMST_Address, string BANMST_AccountNo, string BANMST_SubAccDomestic,string  BANMST_SubAccCommercial,string  BANMST_SubAccNonCommercial,string BANMST_ManagerName, int BANMST_CompanyBank, int BANMST_CreatedByUserID, string BANMST_CreatedDateTime, int BANMST_UpdatedByUserID, string BANMST_UpdatedDateTime, int BANMST_RowStatus, int BANMST_CENCode, long BANMST_RowVersion)
        {
            this._BANMST_BkCode = BANMST_BkCode;
            this._BANMST_MicrNo = BANMST_MicrNo;
            this._BANMST_BankName = BANMST_BankName;
            this._BANMST_Address = BANMST_Address;
            this._BANMST_AccountNo = BANMST_AccountNo;
            this._BANMST_SubAccDomestic = BANMST_SubAccDomestic;
            this._BANMST_SubAccCommercial = BANMST_SubAccCommercial;
            this._BANMST_SubAccNonCommercial = BANMST_SubAccNonCommercial;
            this._BANMST_ManagerName = BANMST_ManagerName;
            this._BANMST_CompanyBank = BANMST_CompanyBank;
            this._BANMST_CreatedByUserID = BANMST_CreatedByUserID;
            this._BANMST_CreatedDateTime = BANMST_CreatedDateTime;
            this._BANMST_UpdatedByUserID = BANMST_UpdatedByUserID;
            this._BANMST_UpdatedDateTime = BANMST_UpdatedDateTime;
            this._BANMST_RowStatus = BANMST_RowStatus;
            this._BANMST_CENCode = BANMST_CENCode;
            this._BANMST_RowVersion = BANMST_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_BkCode
        {
            get { return _BANMST_BkCode; }
            set { _BANMST_BkCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_MicrNo
        {
            get { return _BANMST_MicrNo; }
            set { _BANMST_MicrNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_BankName
        {
            get { return _BANMST_BankName; }
            set { _BANMST_BankName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_Address
        {
            get { return _BANMST_Address; }
            set { _BANMST_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_AccountNo
        {
            get { return _BANMST_AccountNo; }
            set { _BANMST_AccountNo = value; }
        }

        public string BANMST_SubAccDomestic
        {
            get { return _BANMST_SubAccDomestic; }
            set { _BANMST_SubAccDomestic = value; }
        }

        public string BANMST_SubAccCommercial
        {
            get { return _BANMST_SubAccCommercial; }
            set { _BANMST_SubAccCommercial = value; }
        }

        public string BANMST_SubAccNonCommercial
        {
            get { return _BANMST_SubAccNonCommercial; }
            set { _BANMST_SubAccNonCommercial = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_ManagerName
        {
            get { return _BANMST_ManagerName; }
            set { _BANMST_ManagerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_CompanyBank
        {
            get { return _BANMST_CompanyBank; }
            set { _BANMST_CompanyBank = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_CreatedByUserID
        {
            get { return _BANMST_CreatedByUserID; }
            set { _BANMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_CreatedDateTime
        {
            get { return _BANMST_CreatedDateTime; }
            set { _BANMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_UpdatedByUserID
        {
            get { return _BANMST_UpdatedByUserID; }
            set { _BANMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_UpdatedDateTime
        {
            get { return _BANMST_UpdatedDateTime; }
            set { _BANMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_RowStatus
        {
            get { return _BANMST_RowStatus; }
            set { _BANMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 


        public int BANMST_CENCode
        {
            get { return _BANMST_CENCode; }
            set { _BANMST_CENCode = value; }
        }
        public long BANMST_RowVersion
        {
            get { return _BANMST_RowVersion; }
            set { _BANMST_RowVersion = value; }
        }

    }

    public class CORBankMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _BANMST_BkCode;
        private string _BANMST_BankName;
        private string _BANMST_Address;
        private int _BANMST_MicrNo;
        private string _CenterName;
        private string _CompanyBank;
        private string _BANMST_RowStatus;
        private int _BankCounter;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORBankMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORBankMasterList(int BANMST_BkCode, string BANMST_BankName, string BANMST_Address, int BANMST_MicrNo, string CenterName, string CompanyBank, string BANMST_RowStatus, int BankCounter)
        {
            this._BANMST_BkCode = BANMST_BkCode;
            this._BANMST_BankName = BANMST_BankName;
            this._BANMST_Address = BANMST_Address;
            this._BANMST_MicrNo = BANMST_MicrNo;
            this._CenterName = CenterName;
            this._CompanyBank = CompanyBank;
            this._BANMST_RowStatus = BANMST_RowStatus;
            this._BankCounter = BankCounter;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BANMST_BkCode
        {
            get { return _BANMST_BkCode ; }
            set { _BANMST_BkCode  = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_BankName
        {
            get { return _BANMST_BankName; }
            set { _BANMST_BankName  = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_Address
        {
            get { return _BANMST_Address; }
            set { _BANMST_Address = value; }
        }

        public int BANMST_MicrNo
        {
            get { return _BANMST_MicrNo; }
            set { _BANMST_MicrNo = value; }
        }

        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        public string CompanyBank
        {
            get { return _CompanyBank; }
            set { _CompanyBank = value; }
        }
         /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BANMST_RowStatus
        {
            get { return _BANMST_RowStatus; }
            set { _BANMST_RowStatus = value; }
        }
        
        public int  BankCounter
        {
            get { return _BankCounter ; }
            
        }
    }


    public class CORBankMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORBankMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORBankMasterMsg(int RetVal, string RetStr)
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
