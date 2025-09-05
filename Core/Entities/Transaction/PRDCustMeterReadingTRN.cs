//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDCustMeterReadingTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDCustMeterReadingTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class PRDCustMeterReadingTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CMRMST_ID;
        private long _CMRMST_ApplicationID;
        private long _CMRMST_MeterNo;
        private decimal _CMRMST_InitialReading;
        private string _CMRMST_StartDate;
        private string _CMRMST_ReplaceDate;
        private decimal _CMRMST_PreviousReading;
        private int _CMRMST_CreatedByUserID;
        private string _CMRMST_CreatedDateTime;
        private int _CMRMST_UpdatedByUserID;
        private string _CMRMST_UpdatedDateTime;
        private int _CMRMST_RowStatus;
        private long _CMRMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for PRDCustMeterReadingTRN class.
        /// </summary>
        public PRDCustMeterReadingTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDCustMeterReadingTRN(int CMRMST_ID, long CMRMST_ApplicationID, long CMRMST_MeterNo, decimal CMRMST_InitialReading, string CMRMST_StartDate, string CMRMST_ReplaceDate, decimal CMRMST_PreviousReading, int CMRMST_CreatedByUserID, string CMRMST_CreatedDateTime, int CMRMST_UpdatedByUserID, string CMRMST_UpdatedDateTime, int CMRMST_RowStatus, long CMRMST_RowVersion)
        {
            this._CMRMST_ID = CMRMST_ID;
            this._CMRMST_ApplicationID = CMRMST_ApplicationID;
            this._CMRMST_MeterNo = CMRMST_MeterNo;
            this._CMRMST_InitialReading = CMRMST_InitialReading;
            this._CMRMST_StartDate = CMRMST_StartDate;
            this._CMRMST_ReplaceDate = CMRMST_ReplaceDate;
            this._CMRMST_PreviousReading = CMRMST_PreviousReading;
            this._CMRMST_CreatedByUserID = CMRMST_CreatedByUserID;
            this._CMRMST_CreatedDateTime = CMRMST_CreatedDateTime;
            this._CMRMST_UpdatedByUserID = CMRMST_UpdatedByUserID;
            this._CMRMST_UpdatedDateTime = CMRMST_UpdatedDateTime;
            this._CMRMST_RowStatus = CMRMST_RowStatus;
            this._CMRMST_RowVersion = CMRMST_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CMRMST_ID
        {
            get { return _CMRMST_ID; }
            set { _CMRMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CMRMST_ApplicationID
        {
            get { return _CMRMST_ApplicationID; }
            set { _CMRMST_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CMRMST_MeterNo
        {
            get { return _CMRMST_MeterNo; }
            set { _CMRMST_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CMRMST_InitialReading
        {
            get { return _CMRMST_InitialReading; }
            set { _CMRMST_InitialReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CMRMST_StartDate
        {
            get { return _CMRMST_StartDate; }
            set { _CMRMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CMRMST_ReplaceDate
        {
            get { return _CMRMST_ReplaceDate; }
            set { _CMRMST_ReplaceDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CMRMST_PreviousReading
        {
            get { return _CMRMST_PreviousReading; }
            set { _CMRMST_PreviousReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CMRMST_CreatedByUserID
        {
            get { return _CMRMST_CreatedByUserID; }
            set { _CMRMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CMRMST_CreatedDateTime
        {
            get { return _CMRMST_CreatedDateTime; }
            set { _CMRMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CMRMST_UpdatedByUserID
        {
            get { return _CMRMST_UpdatedByUserID; }
            set { _CMRMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CMRMST_UpdatedDateTime
        {
            get { return _CMRMST_UpdatedDateTime; }
            set { _CMRMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CMRMST_RowStatus
        {
            get { return _CMRMST_RowStatus; }
            set { _CMRMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CMRMST_RowVersion
        {
            get { return _CMRMST_RowVersion; }
            set { _CMRMST_RowVersion = value; }
        }

    }

    public class PRDCustMeterReadingTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS

        #region "Variables Declaration"
        private int _CMRMST_ID;
        private int _CMRMST_ApplicationID;
        private string _APPMST_AppNo;
        private string _CMRMST_MeterNo;
        private string _CMRMST_InitialReading;
        private string _CMRMST_StartDate;
        private string _CMRMST_ReplaceDate;
        private string _CMRMST_PreviousReading;
        #endregion

         /// </summary>
        public PRDCustMeterReadingTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDCustMeterReadingTRNList(int CMRMST_ID, int CMRMST_ApplicationID, string APPMST_AppNo, string CMRMST_MeterNo, string CMRMST_InitialReading, string CMRMST_StartDate, string CMRMST_ReplaceDate, string CMRMST_PreviousReading)
        {


            this._CMRMST_ID = CMRMST_ID;
            this._CMRMST_ApplicationID = CMRMST_ApplicationID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CMRMST_MeterNo = CMRMST_MeterNo;
            this._CMRMST_InitialReading = CMRMST_InitialReading;
            this._CMRMST_StartDate = CMRMST_StartDate;
            this._CMRMST_ReplaceDate = CMRMST_ReplaceDate;
            this._CMRMST_PreviousReading = CMRMST_PreviousReading;
        }


        public int CMRMST_ID
        {
            get { return _CMRMST_ID; }
            set { _CMRMST_ID = value; }
        }
        public int CMRMST_ApplicationID
        {
            get { return _CMRMST_ApplicationID; }
            set { _CMRMST_ApplicationID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public string CMRMST_MeterNo
        {
            get { return _CMRMST_MeterNo; }
            set { _CMRMST_MeterNo = value; }
        }
        public string CMRMST_InitialReading
        {
            get { return _CMRMST_InitialReading; }
            set { _CMRMST_InitialReading = value; }

        }
        public string CMRMST_StartDate
        {
            get { return _CMRMST_StartDate; }
            set { _CMRMST_StartDate = value; }
        }
        public string CMRMST_ReplaceDate
        {
            get { return _CMRMST_ReplaceDate; }
            set { _CMRMST_ReplaceDate = value; }
        }
        public string CMRMST_PreviousReading
        {
            get { return _CMRMST_PreviousReading; }
            set { _CMRMST_PreviousReading = value; }
        }
    }

    public class PRDCustomerreadingNOlist
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _CMRMST_ID;
        //private int _CMRMST_ApplicationID;
        private Int64 _CMRMST_MeterNo;
        private decimal _CMRMST_InitialReading;
        // private int _WORTRN_ContractorID;
        //private string _CONMST_Name;
        #endregion

        /// <summary>
        /// Default constructor for PRDJobSheetHDRTRN class.
        /// </summary>
        public PRDCustomerreadingNOlist() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDCustomerreadingNOlist(int CMRMST_ID, Int64 CMRMST_MeterNo, decimal CMRMST_InitialReading)
        {


            this._CMRMST_ID = CMRMST_ID;
            //this._CMRMST_ApplicationID = CMRMST_ApplicationID;
            this._CMRMST_MeterNo = CMRMST_MeterNo;
            this._CMRMST_InitialReading = CMRMST_InitialReading;

        }


        public int CMRMST_ID
        {
            get { return _CMRMST_ID; }
            set { _CMRMST_ID = value; }
        }
        //public int CMRMST_ApplicationID
        //{
        //    get { return _CMRMST_ApplicationID; }
        //    set { _CMRMST_ApplicationID = value; }
        //}
        public Int64 CMRMST_MeterNo
        {
            get { return _CMRMST_MeterNo; }
            set { _CMRMST_MeterNo = value; }
        }
        public decimal CMRMST_InitialReading
        {
            get { return _CMRMST_InitialReading; }
            set { _CMRMST_InitialReading = value; }
        }



    }
    public class PRDCustMeterReadingTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDCustMeterReadingTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDCustMeterReadingTRNMsg(int RetVal, string RetStr)
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
    public class PRDCustMeterReadingTRNMsg1
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDCustMeterReadingTRNMsg1() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDCustMeterReadingTRNMsg1(int RetVal, string RetStr)
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
