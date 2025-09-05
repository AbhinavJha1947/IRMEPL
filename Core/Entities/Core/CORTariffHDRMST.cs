//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORTariffHDRMST.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORTariffHDRMSTService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORTariffHDRMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TARMST_TariffID;
        private string _TARMST_StartDate;
        private int _TARMST_TariffFor;
        private decimal _TARMST_MinUnit;
        private decimal _TARMST_UnitLimitForDomesticPrice;
        private decimal _TARMST_Rent;
        private decimal _TARMST_GasPrice;
        private decimal _TARMST_CommercialGasPrice;
        private bool _TARMST_IsTaxIncluded;
        private int _TARMST_CenCode;
        private int _TARMST_CreatedByUserID;
        private string _TARMST_CreatedDateTime;
        private int _TARMST_UpdatedByUserID;
        private string _TARMST_UpdatedDateTime;
        private int _TARMST_RowStatus;
        private long _TARMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffHDRMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffHDRMST(int TARMST_TariffID, string TARMST_StartDate, int TARMST_TariffFor, decimal TARMST_MinUnit, decimal TARMST_UnitLimitForDomesticPrice, decimal TARMST_Rent, decimal TARMST_GasPrice, decimal TARMST_CommercialGasPrice, bool TARMST_IsTaxIncluded, int TARMST_CenCode, int TARMST_CreatedByUserID, int TARMST_UpdatedByUserID, int TARMST_RowStatus, long TARMST_RowVersion)
        {
            this._TARMST_TariffID = TARMST_TariffID;
            this._TARMST_StartDate = TARMST_StartDate;
            this._TARMST_TariffFor = TARMST_TariffFor;
            this._TARMST_MinUnit = TARMST_MinUnit;
            this._TARMST_UnitLimitForDomesticPrice=TARMST_UnitLimitForDomesticPrice;
            this._TARMST_CommercialGasPrice=TARMST_CommercialGasPrice;
            this._TARMST_Rent = TARMST_Rent;
            this._TARMST_GasPrice = TARMST_GasPrice;
            this._TARMST_IsTaxIncluded = TARMST_IsTaxIncluded;
            this._TARMST_CenCode = TARMST_CenCode;
            this._TARMST_CreatedByUserID = TARMST_CreatedByUserID;
            this._TARMST_UpdatedByUserID = TARMST_UpdatedByUserID;
            this._TARMST_RowVersion = TARMST_RowVersion;
            this._TARMST_RowStatus = TARMST_RowStatus;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_TariffID
        {
            get { return _TARMST_TariffID; }
            set { _TARMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TARMST_StartDate
        {
            get { return _TARMST_StartDate; }
            set { _TARMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_TariffFor
        {
            get { return _TARMST_TariffFor; }
            set { _TARMST_TariffFor = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_MinUnit
        {
            get { return _TARMST_MinUnit; }
            set { _TARMST_MinUnit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_UnitLimitForDomesticPrice
        {
            get { return _TARMST_UnitLimitForDomesticPrice; }
            set { _TARMST_UnitLimitForDomesticPrice = value; }
        }
        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_CommercialGasPrice
        {
            get { return _TARMST_CommercialGasPrice; }
            set { _TARMST_CommercialGasPrice = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_Rent
        {
            get { return _TARMST_Rent; }
            set { _TARMST_Rent = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_GasPrice
        {
            get { return _TARMST_GasPrice; }
            set { _TARMST_GasPrice = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public bool TARMST_IsTaxIncluded
        {
            get { return _TARMST_IsTaxIncluded; }
            set { _TARMST_IsTaxIncluded = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_CenCode
        {
            get { return _TARMST_CenCode; }
            set { _TARMST_CenCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_CreatedByUserID
        {
            get { return _TARMST_CreatedByUserID; }
            set { _TARMST_CreatedByUserID = value; }
        }

        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_UpdatedByUserID
        {
            get { return _TARMST_UpdatedByUserID; }
            set { _TARMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_RowStatus
        {
            get { return _TARMST_RowStatus; }
            set { _TARMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long TARMST_RowVersion
        {
            get { return _TARMST_RowVersion; }
            set { _TARMST_RowVersion = value; }
        }
    }

    public class CORTariffHDRMSTList
    {
         /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private string _CenterName;
        private int _TARMST_TariffID;
        private string _TARMST_StartDate;
        private string _TARMST_TariffFor;
        private string _Plans;
        private decimal _TARMST_MinUnit;
        private decimal _TARMST_UnitLimitForDomesticPrice;
        private decimal _TARMST_Rent;
        private decimal _TARMST_GasPrice;
        private decimal _TARMST_CommercialGasPrice;
        private string _TARMST_IsTaxIncluded;
        private string _TARMST_RowStatus;
        private int _TariffCount;
       

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORTariffHDRMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORTariffHDRMSTList(string CenterName, int TARMST_TariffID, string TARMST_StartDate, string TARMST_TariffFor, string Plans, decimal TARMST_MinUnit, decimal TARMST_UnitLimitForDomesticPrice, decimal TARMST_Rent, decimal TARMST_GasPrice, decimal TARMST_CommercialGasPrice, string TARMST_IsTaxIncluded, string TARMST_RowStatus, int TariffCount)
        {
            this._CenterName = CenterName;
            this._TARMST_TariffID = TARMST_TariffID;
            this._TARMST_StartDate = TARMST_StartDate;
            this._TARMST_TariffFor = TARMST_TariffFor;
            this._Plans = Plans;
            this._TARMST_MinUnit = TARMST_MinUnit;
            this._TARMST_UnitLimitForDomesticPrice = TARMST_UnitLimitForDomesticPrice;            
            this._TARMST_Rent = TARMST_Rent;
            this._TARMST_GasPrice = TARMST_GasPrice;
            this._TARMST_CommercialGasPrice = TARMST_CommercialGasPrice;
            this._TARMST_IsTaxIncluded = TARMST_IsTaxIncluded;
            this._TARMST_RowStatus = TARMST_RowStatus;
            this._TariffCount = TariffCount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_TariffID
        {
            get { return _TARMST_TariffID; }
            set { _TARMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TARMST_StartDate
        {
            get { return _TARMST_StartDate; }
            set { _TARMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TARMST_TariffFor
        {
            get { return _TARMST_TariffFor; }
            set { _TARMST_TariffFor = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Plans
        {
            get { return _Plans; }
            set { _Plans = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_MinUnit
        {
            get { return _TARMST_MinUnit; }
            set { _TARMST_MinUnit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_UnitLimitForDomesticPrice
        {
            get { return _TARMST_UnitLimitForDomesticPrice; }
            set { _TARMST_UnitLimitForDomesticPrice = value; }
        }

        public decimal TARMST_Rent
        {
            get { return _TARMST_Rent; }
            set { _TARMST_Rent = value; }
        }

        public decimal TARMST_GasPrice
        {
            get { return _TARMST_GasPrice; }
            set { _TARMST_GasPrice = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TARMST_CommercialGasPrice
        {
            get { return _TARMST_CommercialGasPrice; }
            set { _TARMST_CommercialGasPrice = value; }
        }
        public string TARMST_IsTaxIncluded
        {
            get { return _TARMST_IsTaxIncluded; }
            set { _TARMST_IsTaxIncluded = value; }
        }

        public string TARMST_RowStatus
        {
            get { return _TARMST_RowStatus; }
            set { _TARMST_RowStatus = value; }
        }  

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TariffCount
        {
            get { return _TariffCount; }

        }
    }


    public class CORTariffHDRMSTMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORTariffHDRMSTMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORTariffHDRMSTMsg(int RetVal, string RetStr)
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

    
    public class CORTariffHDRMST_CheckPlansAttached
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TARMST_TariffID;
        private int _TARMST_CenCode;
        private string _TARMST_StartDate;
        private string _Plans;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffHDRMST_CheckPlansAttached() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffHDRMST_CheckPlansAttached(int TARMST_TariffID, int TARMST_CenCode, string TARMST_StartDate, string Plans)
        {
            this._TARMST_TariffID = TARMST_TariffID;
            this._TARMST_CenCode = TARMST_CenCode;
            this._TARMST_StartDate = TARMST_StartDate;
            this._Plans = Plans;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_TariffID
        {
            get { return _TARMST_TariffID; }
            set { _TARMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_CenCode
        {
            get { return _TARMST_CenCode; }
            set { _TARMST_CenCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TARMST_StartDate
        {
            get { return _TARMST_StartDate; }
            set { _TARMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Plans
        {
            get { return _Plans; }
            set { _Plans = value; }
        }
    }

    
    public class CORTariffHDRMST_CheckPlansForBillingDone
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TARMST_TariffID;
        private int _TARMST_CenCode;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffHDRMST_CheckPlansForBillingDone() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffHDRMST_CheckPlansForBillingDone(int TARMST_TariffID, int TARMST_CenCode)
        {
            this._TARMST_TariffID = TARMST_TariffID;
            this._TARMST_CenCode = TARMST_CenCode;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_TariffID
        {
            get { return _TARMST_TariffID; }
            set { _TARMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TARMST_CenCode
        {
            get { return _TARMST_CenCode; }
            set { _TARMST_CenCode = value; }
        }
    }

    
    public class CORTariffDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TDLMST_ID;
        private int _TDLMST_TariffID;
        private int _TDLMST_ChargeId;
        private int _TDLMST_ChargeType;
        private decimal _TDLMST_Amount;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffDTLMST(int TDLMST_ID, int TDLMST_TariffID, int TDLMST_ChargeId, int TDLMST_ChargeType, decimal TDLMST_Amount)
        {
            this._TDLMST_ID = TDLMST_ID;
            this._TDLMST_TariffID = TDLMST_TariffID;
            this._TDLMST_ChargeId = TDLMST_ChargeId;
            this._TDLMST_ChargeType = TDLMST_ChargeType;
            this._TDLMST_Amount = TDLMST_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TDLMST_ID
        {
            get { return _TDLMST_ID; }
            set { _TDLMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TDLMST_TariffID
        {
            get { return _TDLMST_TariffID; }
            set { _TDLMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TDLMST_ChargeId
        {
            get { return _TDLMST_ChargeId; }
            set { _TDLMST_ChargeId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TDLMST_ChargeType
        {
            get { return _TDLMST_ChargeType; }
            set { _TDLMST_ChargeType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TDLMST_Amount
        {
            get { return _TDLMST_Amount; }
            set { _TDLMST_Amount = value; }
        }
    }

    public class CORTariffDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TDLMST_ChargeId;
        private int _TDLMST_ChargeType;
        private string _CHGMST_Name;
        private decimal _TDLMST_Amount;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORTariffDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORTariffDTLMSTList(int TDLMST_ChargeId, int TDLMST_ChargeType, string CHGMST_Name, decimal TDLMST_Amount)
        {
            this._TDLMST_ChargeId = TDLMST_ChargeId;
            this._TDLMST_ChargeType = TDLMST_ChargeType;
            this._CHGMST_Name = CHGMST_Name;
            this._TDLMST_Amount = TDLMST_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TDLMST_ChargeId
        {
            get { return _TDLMST_ChargeId; }
            set { _TDLMST_ChargeId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TDLMST_ChargeType
        {
            get { return _TDLMST_ChargeType; }
            set { _TDLMST_ChargeType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHGMST_Name
        {
            get { return _CHGMST_Name; }
            set { _CHGMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TDLMST_Amount
        {
            get { return _TDLMST_Amount; }
            set { _TDLMST_Amount = value; }
        }
    }

    
    public class CORTariffMATDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TMDMST_ID;
        private int _TMDMST_TariffID;
        private int _TMDMST_MaterialID;
        private int _TMDMST_ConnType;
        private decimal _TMDMST_Amount;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffMATDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffMATDTLMST(int TMDMST_ID, int TMDMST_TariffID, int TMDMST_MaterialID, int TMDMST_ConnType, decimal TMDMST_Amount)
        {
            this._TMDMST_ID = TMDMST_ID;
            this._TMDMST_TariffID = TMDMST_TariffID;
            this._TMDMST_MaterialID = TMDMST_MaterialID;
            this._TMDMST_ConnType = TMDMST_ConnType;
            this._TMDMST_Amount = TMDMST_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TMDMST_ID
        {
            get { return _TMDMST_ID; }
            set { _TMDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TMDMST_TariffID
        {
            get { return _TMDMST_TariffID; }
            set { _TMDMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TMDMST_MaterialID
        {
            get { return _TMDMST_MaterialID; }
            set { _TMDMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TMDMST_ConnType
        {
            get { return _TMDMST_ConnType; }
            set { _TMDMST_ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TMDMST_Amount
        {
            get { return _TMDMST_Amount; }
            set { _TMDMST_Amount = value; }
        }
    }

    public class CORTariffMATDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private string _TMDMST_MaterialID;
        private string _MATMST_Shortname;
        private string _TMDMST_ConnType;
        private decimal _TMDMST_Amount;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORTariffMATDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORTariffMATDTLMSTList(string TMDMST_MaterialID, string MATMST_Shortname, string TMDMST_ConnType, decimal TMDMST_Amount)
        {
            this._TMDMST_MaterialID = TMDMST_MaterialID;
            this._MATMST_Shortname = MATMST_Shortname;
            this._TMDMST_ConnType = TMDMST_ConnType;
            this._TMDMST_Amount = TMDMST_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TMDMST_MaterialID
        {
            get { return _TMDMST_MaterialID; }
            set { _TMDMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string MATMST_Shortname
        {
            get { return _MATMST_Shortname; }
            set { _MATMST_Shortname = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TMDMST_ConnType
        {
            get { return _TMDMST_ConnType; }
            set { _TMDMST_ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TMDMST_Amount
        {
            get { return _TMDMST_Amount; }
            set { _TMDMST_Amount = value; }
        }
    }

    
    public class CORTariffExtraConnDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TEDMST_ID;
        private int _TEDMST_TariffID;
        private int _TEDMST_ExtraConnTypeID;
        private decimal _TEDMST_Amount;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffExtraConnDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffExtraConnDTLMST(int TEDMST_ID, int TEDMST_TariffID, int TEDMST_ExtraConnTypeID, decimal TEDMST_Amount)
        {
            this._TEDMST_ID = TEDMST_ID;
            this._TEDMST_TariffID = TEDMST_TariffID;
            this._TEDMST_ExtraConnTypeID = TEDMST_ExtraConnTypeID;
            this._TEDMST_Amount = TEDMST_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TEDMST_ID
        {
            get { return _TEDMST_ID; }
            set { _TEDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TEDMST_TariffID
        {
            get { return _TEDMST_TariffID; }
            set { _TEDMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TEDMST_ExtraConnTypeID
        {
            get { return _TEDMST_ExtraConnTypeID; }
            set { _TEDMST_ExtraConnTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TEDMST_Amount
        {
            get { return _TEDMST_Amount; }
            set { _TEDMST_Amount = value; }
        }
    }

    public class CORTariffExtraConnDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TEDMST_ExtraConnTypeID;
        private string _CD_ControlType;
        private decimal _TEDMST_Amount;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORTariffExtraConnDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORTariffExtraConnDTLMSTList(int TEDMST_ExtraConnTypeID, string CD_ControlType, decimal TEDMST_Amount)
        {
            this._TEDMST_ExtraConnTypeID = TEDMST_ExtraConnTypeID;
            this._CD_ControlType = CD_ControlType;
            this._TEDMST_Amount = TEDMST_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TEDMST_ExtraConnTypeID
        {
            get { return _TEDMST_ExtraConnTypeID; }
            set { _TEDMST_ExtraConnTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TEDMST_Amount
        {
            get { return _TEDMST_Amount; }
            set { _TEDMST_Amount = value; }
        }
    }

    
    public class CORTariffPlanDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TPDMST_ID;
        private int _TPDMST_TariffID;
        private int _TPDMST_PlanID;
        #endregion

        /// <summary>
        /// Default constructor for CORTariffHDRMST class.
        /// </summary>
        public CORTariffPlanDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTariffPlanDTLMST(int TPDMST_ID, int TPDMST_TariffID, int TPDMST_PlanID)
        {
            this._TPDMST_ID = TPDMST_ID;
            this._TPDMST_TariffID = TPDMST_TariffID;
            this._TPDMST_PlanID = TPDMST_PlanID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TPDMST_ID
        {
            get { return _TPDMST_ID; }
            set { _TPDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TPDMST_TariffID
        {
            get { return _TPDMST_TariffID; }
            set { _TPDMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TPDMST_PlanID
        {
            get { return _TPDMST_PlanID; }
            set { _TPDMST_PlanID = value; }
        }
    }

    public class CORTariffPlanDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TPDMST_PlanID;
        private string _PLAMST_PlanName;
        private bool _Checked;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORTariffPlanDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORTariffPlanDTLMSTList(int TPDMST_PlanID, string PLAMST_PlanName, bool Checked)
        {
            this._TPDMST_PlanID = TPDMST_PlanID;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._Checked = Checked;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TPDMST_PlanID
        {
            get { return _TPDMST_PlanID; }
            set { _TPDMST_PlanID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public bool Checked
        {
            get { return _Checked; }
            set { _Checked = value; }
        }
    }
}
