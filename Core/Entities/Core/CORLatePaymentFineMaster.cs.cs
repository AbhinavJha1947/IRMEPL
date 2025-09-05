using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORMeterMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORMeterMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORLatePaymentFine
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _LPFMST_ID;
        private string _LPFMST_FromDate;
        private string _LPFMST_ToDate;
        private int _LPFMST_FromGraceDays;
        private int _LPFMST_AfterGraceDays;
        private decimal _LPFMST_Amt;
        private string _LPFMST_CreatedDateTime;
        private int _LPFMST_CreatedByUserID;
        private int _LPFMST_UpdatedByUserID;
        private string _LPFMST_UpdatedDateTime;
        private int _LPFMST_RowStatus;
        private long _LPFMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORMeterMaster class.
        /// </summary>
        public CORLatePaymentFine() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORLatePaymentFine(int LPFMST_ID, string LPFMST_FromDate, string LPFMST_ToDate, int LPFMST_FromGraceDays, int LPFMST_AfterGraceDays, decimal LPFMST_Amt, int LPFMST_CreatedByUserID, string LPFMST_CreatedDateTime, int LPFMST_UpdatedByUserID, string LPFMST_UpdatedDateTime, int LPFMST_RowStatus, long LPFMST_RowVersion)
        {

            this._LPFMST_ID = LPFMST_ID;
            this._LPFMST_FromDate = LPFMST_FromDate;
            this._LPFMST_ToDate = LPFMST_ToDate;
            this._LPFMST_FromGraceDays = LPFMST_FromGraceDays;
            this._LPFMST_AfterGraceDays = LPFMST_AfterGraceDays;
            this._LPFMST_Amt = LPFMST_Amt;
            this._LPFMST_CreatedByUserID = LPFMST_CreatedByUserID;
            this._LPFMST_CreatedDateTime = LPFMST_CreatedDateTime;
            this._LPFMST_UpdatedByUserID = LPFMST_UpdatedByUserID;
            this._LPFMST_UpdatedDateTime = LPFMST_UpdatedDateTime;
            this._LPFMST_RowStatus = LPFMST_RowStatus;
            this._LPFMST_RowVersion = LPFMST_RowVersion;
        }
        public int LPFMST_ID
        {
            get { return _LPFMST_ID; }
            set { _LPFMST_ID = value; }
        }

        public string LPFMST_FromDate
        {
            get { return _LPFMST_FromDate; }
            set { _LPFMST_FromDate = value; }
        }

        public string LPFMST_ToDate
        {
            get { return _LPFMST_ToDate; }
            set { _LPFMST_ToDate = value; }
        }

        public int LPFMST_FromGraceDays
        {
            get { return _LPFMST_FromGraceDays; }
            set { _LPFMST_FromGraceDays = value; }
        }

        public int LPFMST_AfterGraceDays
        {
            get { return _LPFMST_AfterGraceDays; }
            set { _LPFMST_AfterGraceDays = value; }
        }

        public decimal LPFMST_Amt
        {
            get { return _LPFMST_Amt; }
            set { _LPFMST_Amt = value; }
        }
        public int LPFMST_CreatedByUserID
        {
            get { return _LPFMST_CreatedByUserID; }
            set { _LPFMST_CreatedByUserID = value; }
        }
        public string LPFMST_CreatedDateTime
        {
            get { return _LPFMST_CreatedDateTime; }
            set { _LPFMST_CreatedDateTime = value; }
        }
        public int LPFMST_UpdatedByUserID
        {
            get { return _LPFMST_UpdatedByUserID; }
            set { _LPFMST_UpdatedByUserID = value; }
        }
        public string LPFMST_UpdatedDateTime
        {
            get { return _LPFMST_UpdatedDateTime; }
            set { _LPFMST_UpdatedDateTime = value; }
        }
        public int LPFMST_RowStatus
        {
            get { return _LPFMST_RowStatus; }
            set { _LPFMST_RowStatus = value; }
        }
        public long LPFMST_RowVersion
        {
            get { return _LPFMST_RowVersion; }
            set { _LPFMST_RowVersion = value; }
        }

    }
    public class CORLatePaymentFineList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _LPFMST_ID;
        private string _LPFMST_FromDate;
        private string _LPFMST_ToDate;
        private int _LPFMST_FromGraceDays;
        private int _LPFMST_AfterGraceDays;
        private decimal _LPFMST_Amt;
        private string _LPFMST_RowStatus;
        private int _LPFMSTCount;


        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORLatePaymentFineList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORLatePaymentFineList(int LPFMST_ID, string LPFMST_FromDate, string LPFMST_ToDate, int LPFMST_FromGraceDays, int LPFMST_AfterGraceDays, decimal LPFMST_Amt, string LPFMST_RowStatus, int LPFMSTCount)
        {
            this._LPFMST_ID = LPFMST_ID;
            this._LPFMST_FromDate = LPFMST_FromDate;
            this._LPFMST_ToDate = LPFMST_ToDate;
            this._LPFMST_FromGraceDays = LPFMST_FromGraceDays;
            this._LPFMST_AfterGraceDays = LPFMST_AfterGraceDays;
            this._LPFMST_Amt = LPFMST_Amt;
            this._LPFMST_RowStatus = LPFMST_RowStatus;
            this._LPFMSTCount = LPFMSTCount;
        }
        public int LPFMST_ID
        {
            get { return _LPFMST_ID; }
            set { _LPFMST_ID = value; }
        }

        public string LPFMST_FromDate
        {
            get { return _LPFMST_FromDate; }
            set { _LPFMST_FromDate = value; }
        }
        public string LPFMST_ToDate
        {
            get { return _LPFMST_ToDate; }
            set { _LPFMST_ToDate = value; }
        }

        public int LPFMST_FromGraceDays
        {
            get { return _LPFMST_FromGraceDays; }
            set { _LPFMST_FromGraceDays = value; }
        }

        public int LPFMST_AfterGraceDays
        {
            get { return _LPFMST_AfterGraceDays; }
            set { _LPFMST_AfterGraceDays = value; }
        }

        public decimal LPFMST_Amt
        {
            get { return _LPFMST_Amt; }
            set { _LPFMST_Amt = value; }
        }

        public string LPFMST_RowStatus
        {
            get { return _LPFMST_RowStatus; }
            set { _LPFMST_RowStatus = value; }
        }

        public int LPFMSTCount
        {
            get { return _LPFMSTCount; }

        }
    }
    public class CORLatePaymentFineMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the Salutation class.
        /// </summary>
        public CORLatePaymentFineMsg() { }

        /// <summary>
        /// Overloaded constructor for the Salutation class.
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORLatePaymentFineMsg(int RetVal, string RetStr)
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

