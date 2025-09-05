//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILCustDisconnMeterReadingTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILCustDisconnMeterReadingTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILCustDisconnMeterReadingTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CDMTRN_ID;
        private int _CDMTRN_RequestCode;
        private long _CDMTRN_MeterNo;
        private decimal _CDMTRN_ReqMeterReading;
        private decimal _CDMTRN_DisMeterReading;
        private decimal _CDMTRN_PrevMeterReading;
        private int _CDMTRN_CreatedByUserID;
        private string _CDMTRN_CreatedDateTime;
        private int _CDMTRN_UpdatedByUserID;
        private string _CDMTRN_UpdatedDateTime;
        private int _CDMTRN_RowStatus;
        private long _CDMTRN_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for BILCustDisconnMeterReadingTRN class.
        /// </summary>
        public BILCustDisconnMeterReadingTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILCustDisconnMeterReadingTRN(int CDMTRN_ID, int CDMTRN_RequestCode, long CDMTRN_MeterNo, decimal CDMTRN_ReqMeterReading, decimal CDMTRN_DisMeterReading, decimal CDMTRN_PrevMeterReading, int CDMTRN_CreatedByUserID, string CDMTRN_CreatedDateTime, int CDMTRN_UpdatedByUserID, string CDMTRN_UpdatedDateTime, int CDMTRN_RowStatus, long CDMTRN_RowVersion)
        {
            this._CDMTRN_ID = CDMTRN_ID;
            this._CDMTRN_RequestCode = CDMTRN_RequestCode;
            this._CDMTRN_MeterNo = CDMTRN_MeterNo;
            this._CDMTRN_ReqMeterReading = CDMTRN_ReqMeterReading;
            this._CDMTRN_DisMeterReading = CDMTRN_DisMeterReading;
            this._CDMTRN_PrevMeterReading = CDMTRN_PrevMeterReading;
            this._CDMTRN_CreatedByUserID = CDMTRN_CreatedByUserID;
            this._CDMTRN_CreatedDateTime = CDMTRN_CreatedDateTime;
            this._CDMTRN_UpdatedByUserID = CDMTRN_UpdatedByUserID;
            this._CDMTRN_UpdatedDateTime = CDMTRN_UpdatedDateTime;
            this._CDMTRN_RowStatus = CDMTRN_RowStatus;
            this._CDMTRN_RowVersion = CDMTRN_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDMTRN_ID
        {
            get { return _CDMTRN_ID; }
            set { _CDMTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDMTRN_RequestCode
        {
            get { return _CDMTRN_RequestCode; }
            set { _CDMTRN_RequestCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CDMTRN_MeterNo
        {
            get { return _CDMTRN_MeterNo; }
            set { _CDMTRN_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CDMTRN_ReqMeterReading
        {
            get { return _CDMTRN_ReqMeterReading; }
            set { _CDMTRN_ReqMeterReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CDMTRN_DisMeterReading
        {
            get { return _CDMTRN_DisMeterReading; }
            set { _CDMTRN_DisMeterReading = value; }
        }


        public decimal CDMTRN_PrevMeterReading
        {
            get { return _CDMTRN_PrevMeterReading; }
            set { _CDMTRN_PrevMeterReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDMTRN_CreatedByUserID
        {
            get { return _CDMTRN_CreatedByUserID; }
            set { _CDMTRN_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CDMTRN_CreatedDateTime
        {
            get { return _CDMTRN_CreatedDateTime; }
            set { _CDMTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDMTRN_UpdatedByUserID
        {
            get { return _CDMTRN_UpdatedByUserID; }
            set { _CDMTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CDMTRN_UpdatedDateTime
        {
            get { return _CDMTRN_UpdatedDateTime; }
            set { _CDMTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDMTRN_RowStatus
        {
            get { return _CDMTRN_RowStatus; }
            set { _CDMTRN_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CDMTRN_RowVersion
        {
            get { return _CDMTRN_RowVersion; }
            set { _CDMTRN_RowVersion = value; }
        }

    }

    public class BILCustDisconnMeterReadingTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
    }
    public class BILCustDisconnMeterReadingTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILCustDisconnMeterReadingTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILCustDisconnMeterReadingTRNMsg(int RetVal, string RetStr)
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
