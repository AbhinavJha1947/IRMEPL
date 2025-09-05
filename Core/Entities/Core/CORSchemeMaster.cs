//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORSchemeMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORSchemeMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORSchemeMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _SCHMST_Code;
        private int _SCHMST_ApplicableOn;
        private string _SCHMST_Name;
        private string _SCHMST_StartDate;
        private string _SCHMST_EndDate;
        private decimal _SCHMST_Amount;
        private int _SCHMST_CreatedByUserID;
        private string _SCHMST_CreatedDateTime;
        private int _SCHMST_UpdatedByUserID;
        private string _SCHMST_UpdatedDateTime;
        private int _SCHMST_RowStatus;
        private long _SCHMST_RowVersion;
        private int _SCHMST_Edit;
        #endregion

        /// <summary>
        /// Default constructor for CORSchemeMaster class.
        /// </summary>
        public CORSchemeMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORSchemeMaster(int SCHMST_Code, int SCHMST_ApplicableOn, string SCHMST_Name, string SCHMST_StartDate, string SCHMST_EndDate, decimal SCHMST_Amount, int SCHMST_CreatedByUserID, string SCHMST_CreatedDateTime, int SCHMST_UpdatedByUserID, string SCHMST_UpdatedDateTime, int SCHMST_RowStatus, long SCHMST_RowVersion, int SCHMST_Edit)
        {
            this._SCHMST_Code = SCHMST_Code;
            this._SCHMST_ApplicableOn = SCHMST_ApplicableOn;
            this._SCHMST_Name = SCHMST_Name;
            this._SCHMST_StartDate = SCHMST_StartDate;
            this._SCHMST_EndDate = SCHMST_EndDate;
            this._SCHMST_Amount = SCHMST_Amount;
            this._SCHMST_CreatedByUserID = SCHMST_CreatedByUserID;
            this._SCHMST_CreatedDateTime = SCHMST_CreatedDateTime;
            this._SCHMST_UpdatedByUserID = SCHMST_UpdatedByUserID;
            this._SCHMST_UpdatedDateTime = SCHMST_UpdatedDateTime;
            this._SCHMST_RowStatus = SCHMST_RowStatus;
            this._SCHMST_RowVersion = SCHMST_RowVersion;
            this._SCHMST_Edit = SCHMST_Edit;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCHMST_Code
        {
            get { return _SCHMST_Code; }
            set { _SCHMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCHMST_ApplicableOn
        {
            get { return _SCHMST_ApplicableOn; }
            set { _SCHMST_ApplicableOn = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_Name
        {
            get { return _SCHMST_Name; }
            set { _SCHMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_StartDate
        {
            get { return _SCHMST_StartDate; }
            set { _SCHMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_EndDate
        {
            get { return _SCHMST_EndDate; }
            set { _SCHMST_EndDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal SCHMST_Amount
        {
            get { return _SCHMST_Amount; }
            set { _SCHMST_Amount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCHMST_CreatedByUserID
        {
            get { return _SCHMST_CreatedByUserID; }
            set { _SCHMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_CreatedDateTime
        {
            get { return _SCHMST_CreatedDateTime; }
            set { _SCHMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCHMST_UpdatedByUserID
        {
            get { return _SCHMST_UpdatedByUserID; }
            set { _SCHMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_UpdatedDateTime
        {
            get { return _SCHMST_UpdatedDateTime; }
            set { _SCHMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCHMST_RowStatus
        {
            get { return _SCHMST_RowStatus; }
            set { _SCHMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCHMST_Edit
        {
            get { return _SCHMST_Edit; }
            set { _SCHMST_Edit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long SCHMST_RowVersion
        {
            get { return _SCHMST_RowVersion; }
            set { _SCHMST_RowVersion = value; }
        }

    }

    public class CORSchemeMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _SCHMST_Code;
        private string _SCHMST_ApplicableOn;
        private string _SCHMST_Name;
        private string _SCHMST_StartDate;
        private string _SCHMST_EndDate;
        private decimal _SCHMST_Amount;
        private string _SCHMST_RowStatus;
        private int _SCHMST_Edit;
        private int _SchemeCount;
        #endregion
        public CORSchemeMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORSchemeMasterList(int SCHMST_Code, string SCHMST_ApplicableOn, string SCHMST_Name, string SCHMST_StartDate, string SCHMST_EndDate, decimal SCHMST_Amount, string SCHMST_RowStatus, int SchemeCount)
        {

            this._SCHMST_Code = SCHMST_Code;
            this._SCHMST_ApplicableOn = SCHMST_ApplicableOn;
            this._SCHMST_Name = SCHMST_Name;
            this._SCHMST_StartDate = SCHMST_StartDate;
            this._SCHMST_EndDate = SCHMST_EndDate;
            this._SCHMST_Amount = SCHMST_Amount;
            this._SCHMST_RowStatus = SCHMST_RowStatus;
            this._SchemeCount = SchemeCount;
           

        }
        public int SCHMST_Code
        {
            get { return _SCHMST_Code; }
            set { _SCHMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_ApplicableOn
        {
            get { return _SCHMST_ApplicableOn; }
            set { _SCHMST_ApplicableOn = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_Name
        {
            get { return _SCHMST_Name; }
            set { _SCHMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_StartDate
        {
            get { return _SCHMST_StartDate; }
            set { _SCHMST_StartDate = value; }
        }

        public string SCHMST_EndDate
        {
            get { return _SCHMST_EndDate; }
            set { _SCHMST_EndDate = value; }
        }

        public decimal SCHMST_Amount
        {
            get { return _SCHMST_Amount; }
            set { _SCHMST_Amount = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_RowStatus
        {
            get { return _SCHMST_RowStatus; }
            set { _SCHMST_RowStatus = value; }

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SchemeCount
        {
            get { return _SchemeCount; }

        }
    }
}


public class CORSchemeMasterMsg
{
    // Class level Local Variables Declaration.
    #region "Variables Declaration"
    private int _RetVal;
    private string _RetStr;
    #endregion

    /// <summary>
    //Overloaded default constructor for the Salutation class. 
    /// </summary>
    public CORSchemeMasterMsg() { }
    /// <summary>
    //Overloaded constructor for the Salutation class. 
    /// </summary>
    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
    /// <param name="saltnmName">Name of the Salutation.</param>
    public CORSchemeMasterMsg(int RetVal, string RetStr)
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

