//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORTAXMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORTAXMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORTAXMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TAXMST_ID;
        private string _TAXMST_FromDate;
        private string _TAXMST_Todate;
        private int _TAXMST_ParentTaxType;
        private int _TAXMST_TaxType;        
        private int _TAXMST_TaxFor;
        private decimal _TAXMST_Rate;
        private string _TAXMST_Description;
        private int _TAXMST_CenCode;
        private int _TAXMST_Level;
        private string _TAXMST_ApplicableON;
        private int _TAXMST_CreatedByUserID;
        private string _TAXMST_CreatedDateTime;
        private int _TAXMST_UpdatedByUserID;
        private string _TAXMST_UpdatedDateTime;
        private int _TAXMST_RowStatus;
        private long _TAXMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORTAXMaster class.
        /// </summary>
        public CORTAXMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTAXMaster(int TAXMST_ID, string TAXMST_FromDate, string TAXMST_Todate, int TAXMST_ParentTaxType, int TAXMST_TaxType, int TAXMST_TaxFor, decimal TAXMST_Rate, string TAXMST_Description, int TAXMST_CenCode, int TAXMST_Level, string TAXMST_ApplicableON, int TAXMST_CreatedByUserID, string TAXMST_CreatedDateTime, int TAXMST_UpdatedByUserID, string TAXMST_UpdatedDateTime, int TAXMST_RowStatus, long TAXMST_RowVersion)
        {
            this._TAXMST_ID = TAXMST_ID;
            this._TAXMST_FromDate = TAXMST_FromDate;
            this._TAXMST_Todate = TAXMST_Todate;
            this._TAXMST_ParentTaxType = TAXMST_ParentTaxType;
            this._TAXMST_TaxType = TAXMST_TaxType;
            this._TAXMST_TaxFor = TAXMST_TaxFor;
            this._TAXMST_Rate = TAXMST_Rate;
            this._TAXMST_Description = TAXMST_Description;
            this._TAXMST_CenCode = TAXMST_CenCode;
            this._TAXMST_Level = TAXMST_Level;
            this._TAXMST_ApplicableON = TAXMST_ApplicableON;
            this._TAXMST_CreatedByUserID = TAXMST_CreatedByUserID;
            this._TAXMST_CreatedDateTime = TAXMST_CreatedDateTime;
            this._TAXMST_UpdatedByUserID = TAXMST_UpdatedByUserID;
            this._TAXMST_UpdatedDateTime = TAXMST_UpdatedDateTime;
            this._TAXMST_RowStatus = TAXMST_RowStatus;
            this._TAXMST_RowVersion = TAXMST_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_ID
        {
            get { return _TAXMST_ID; }
            set { _TAXMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_FromDate
        {
            get { return _TAXMST_FromDate; }
            set { _TAXMST_FromDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_Todate
        {
            get { return _TAXMST_Todate; }
            set { _TAXMST_Todate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_ParentTaxType
        {
            get { return _TAXMST_ParentTaxType; }
            set { _TAXMST_ParentTaxType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_TaxType
        {
            get { return _TAXMST_TaxType; }
            set { _TAXMST_TaxType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_TaxFor
        {
            get { return _TAXMST_TaxFor; }
            set { _TAXMST_TaxFor = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TAXMST_Rate
        {
            get { return _TAXMST_Rate; }
            set { _TAXMST_Rate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_Description
        {
            get { return _TAXMST_Description; }
            set { _TAXMST_Description = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_CenCode
        {
            get { return _TAXMST_CenCode; }
            set { _TAXMST_CenCode = value; }
        }
        public int TAXMST_Level
        {
            get { return _TAXMST_Level; }
            set { _TAXMST_Level = value; }
        }
        public string TAXMST_ApplicableON
        {
            get { return _TAXMST_ApplicableON; }
            set { _TAXMST_ApplicableON = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_CreatedByUserID
        {
            get { return _TAXMST_CreatedByUserID; }
            set { _TAXMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_CreatedDateTime
        {
            get { return _TAXMST_CreatedDateTime; }
            set { _TAXMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_UpdatedByUserID
        {
            get { return _TAXMST_UpdatedByUserID; }
            set { _TAXMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_UpdatedDateTime
        {
            get { return _TAXMST_UpdatedDateTime; }
            set { _TAXMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_RowStatus
        {
            get { return _TAXMST_RowStatus; }
            set { _TAXMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long TAXMST_RowVersion
        {
            get { return _TAXMST_RowVersion; }
            set { _TAXMST_RowVersion = value; }
        }

    }

    public class CORTAXMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _TAXMST_ID;
        private string _TAXMST_CenCode;
        private string _TAXMST_FromDate;
        private string _TAXMST_Todate;
        private string _TAXMST_ParentTaxType;
        private string _TAXMST_TaxType;
        private string _TAXMST_TaxFor;
        private string _TAXMST_Description;
        private decimal _TAXMST_Rate;
        private string _TAXMST_ApplicableON;
        private string _TAXMST_RowStatus;
        private int _TaxCount;
        #endregion

        /// <summary>
        /// Default constructor for CORContractorMaster class.
        /// </summary>
        public CORTAXMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORTAXMasterList(int TAXMST_ID, string TAXMST_CenCode, string TAXMST_FromDate, string TAXMST_Todate, string TAXMST_ParentTaxType, string TAXMST_TaxType, string TAXMST_TaxFor, string TAXMST_Description, decimal TAXMST_Rate, string TAXMST_ApplicableON, string TAXMST_RowStatus, int TaxCount)
        {
            this._TAXMST_ID = TAXMST_ID;
            this._TAXMST_CenCode = TAXMST_CenCode;
            this._TAXMST_FromDate = TAXMST_FromDate;
            this._TAXMST_Todate = TAXMST_Todate;
            this._TAXMST_ParentTaxType = TAXMST_ParentTaxType;
            this._TAXMST_TaxType = TAXMST_TaxType;
            this._TAXMST_TaxFor = TAXMST_TaxFor;
            this._TAXMST_Description = TAXMST_Description;
            this._TAXMST_Rate = TAXMST_Rate;
            this._TAXMST_ApplicableON = TAXMST_ApplicableON;
            this._TAXMST_RowStatus = TAXMST_RowStatus;
            this._TaxCount = TaxCount;
            
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TAXMST_ID
        {
            get { return _TAXMST_ID; }
            set { _TAXMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_CenCode
        {
            get { return _TAXMST_CenCode; }
            set { _TAXMST_CenCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_FromDate
        {
            get { return _TAXMST_FromDate; }
            set { _TAXMST_FromDate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_Todate
        {
            get { return _TAXMST_Todate; }
            set { _TAXMST_FromDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_ParentTaxType
        {
            get { return _TAXMST_ParentTaxType; }
            set { _TAXMST_ParentTaxType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_TaxType
        {
            get { return _TAXMST_TaxType; }
            set { _TAXMST_TaxType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_TaxFor
        {
            get { return _TAXMST_TaxFor; }
            set { _TAXMST_TaxFor = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_Description
        {
            get { return _TAXMST_Description; }
            set { _TAXMST_Description = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TAXMST_Rate
        {
            get { return _TAXMST_Rate; }
            set { _TAXMST_Rate = value; }
        }
        public string TAXMST_ApplicableON
        {
            get { return _TAXMST_ApplicableON; }
            set { _TAXMST_ApplicableON = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAXMST_RowStatus
        {
            get { return _TAXMST_RowStatus; }
            set { _TAXMST_RowStatus = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TaxCount
        {
            get { return _TaxCount; }
            set { _TaxCount = value; }
        }


        
    }
    public class CORTAXMasterMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the Salutation class.
        /// </summary>
        public CORTAXMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Salutation class.
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORTAXMasterMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        /// <summary>
        /// Gets or sets unique Salutation identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        /// <summary>
        /// Gets or sets Country Name.        
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }
}
