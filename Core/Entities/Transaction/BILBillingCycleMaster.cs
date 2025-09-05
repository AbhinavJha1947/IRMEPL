//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILBillingCycleMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILBillingCycleMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
	
	public class 	BILBillingCycleMaster
	{
	    /// Class level Local Variables Declaration.
	    #region "Variables Declaration"

		private int _BCCMST_BillingID;
		private string _BCCMST_ShortName;
		private string _BCCMST_StartDate;
		private int _BCCMST_SGraceDays;
		private string _BCCMST_EndDate;
		private int _BCCMST_EGraceDays;
		private int _BCCMST_CycleFor;
		private int _BCCMST_CENCode;
		private int _BCCMST_BillingTime;
		private int _BCCMST_CreatedByUserID;
		private string _BCCMST_CreatedDateTime;
		private int _BCCMST_UpdatedByUserID;
		private string _BCCMST_UpdatedDateTime;
		private int _BCCMST_RowStatus;
		private long _BCCMST_RowVersion;

        private int _RetVal;
        private string _RetStr;

	    #endregion

	    /// <summary>
	    /// Default constructor for BILBillingCycleMaster class.
	    /// </summary>
	    public BILBillingCycleMaster() { }

	    /// <summary>
	    /// Overloaded constructor for the Branch class.
	    /// </summary>
        public BILBillingCycleMaster(int BCCMST_BillingID, string BCCMST_ShortName, string BCCMST_StartDate, int BCCMST_SGraceDays, string BCCMST_EndDate, int BCCMST_EGraceDays, int BCCMST_CycleFor, int BCCMST_CENCode, int BCCMST_BillingTime, int BCCMST_CreatedByUserID, string BCCMST_CreatedDateTime, int BCCMST_UpdatedByUserID, string BCCMST_UpdatedDateTime, int BCCMST_RowStatus, long BCCMST_RowVersion, int RetVal, string RetStr)
	    {
	        this._BCCMST_BillingID = BCCMST_BillingID;
	        this._BCCMST_ShortName = BCCMST_ShortName;
	        this._BCCMST_StartDate = BCCMST_StartDate;
	        this._BCCMST_SGraceDays = BCCMST_SGraceDays;
	        this._BCCMST_EndDate = BCCMST_EndDate;
	        this._BCCMST_EGraceDays = BCCMST_EGraceDays;
	        this._BCCMST_CycleFor = BCCMST_CycleFor;
	        this._BCCMST_CENCode = BCCMST_CENCode;
	        this._BCCMST_BillingTime = BCCMST_BillingTime;
	        this._BCCMST_CreatedByUserID = BCCMST_CreatedByUserID;
	        this._BCCMST_CreatedDateTime = BCCMST_CreatedDateTime;
	        this._BCCMST_UpdatedByUserID = BCCMST_UpdatedByUserID;
	        this._BCCMST_UpdatedDateTime = BCCMST_UpdatedDateTime;
	        this._BCCMST_RowStatus = BCCMST_RowStatus;
	        this._BCCMST_RowVersion = BCCMST_RowVersion;

            this._RetVal = RetVal;
            this._RetStr = RetStr;
	    }

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_BillingID
		{
			 get { return _BCCMST_BillingID; }
			 set { _BCCMST_BillingID = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public string BCCMST_ShortName
		{
			 get { return _BCCMST_ShortName; }
			 set { _BCCMST_ShortName = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public string BCCMST_StartDate
		{
			 get { return _BCCMST_StartDate; }
			 set { _BCCMST_StartDate = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_SGraceDays
		{
			 get { return _BCCMST_SGraceDays; }
			 set { _BCCMST_SGraceDays = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public string BCCMST_EndDate
		{
			 get { return _BCCMST_EndDate; }
			 set { _BCCMST_EndDate = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_EGraceDays
		{
			 get { return _BCCMST_EGraceDays; }
			 set { _BCCMST_EGraceDays = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_CycleFor
		{
			 get { return _BCCMST_CycleFor; }
			 set { _BCCMST_CycleFor = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_CENCode
		{
			 get { return _BCCMST_CENCode; }
			 set { _BCCMST_CENCode = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_BillingTime
		{
			 get { return _BCCMST_BillingTime; }
			 set { _BCCMST_BillingTime = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_CreatedByUserID
		{
			 get { return _BCCMST_CreatedByUserID; }
			 set { _BCCMST_CreatedByUserID = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public string BCCMST_CreatedDateTime
		{
			 get { return _BCCMST_CreatedDateTime; }
			 set { _BCCMST_CreatedDateTime = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_UpdatedByUserID
		{
			 get { return _BCCMST_UpdatedByUserID; }
			 set { _BCCMST_UpdatedByUserID = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public string BCCMST_UpdatedDateTime
		{
			 get { return _BCCMST_UpdatedDateTime; }
			 set { _BCCMST_UpdatedDateTime = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public int BCCMST_RowStatus
		{
			 get { return _BCCMST_RowStatus; }
			 set { _BCCMST_RowStatus = value; }
		}

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
	    public long BCCMST_RowVersion
		{
			 get { return _BCCMST_RowVersion; }
			 set { _BCCMST_RowVersion = value; }
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
    public class BILBillingCycleAreaMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private string _AreaName;
        private int _AreaCode;
        
        #endregion

        /// <summary>
        /// Default constructor for BILBillingCycleMaster class.
        /// </summary>
        public BILBillingCycleAreaMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILBillingCycleAreaMasterList(string  AreaName, int AreaCode)
        {
            this._AreaName = AreaName;
            this._AreaCode = AreaCode;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AreaName
        {
            get { return _AreaName; }
            set { _AreaName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AreaCode
        {
            get { return _AreaCode; }
            set { _AreaCode = value; }
        }        


    }
    public class 	BILBillingCycleMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BCCMST_BillingID;
        private int _CD_ControlID;
        private string _CustomerType;        
        private string _BCCMST_ShortName;
        private string _BCCMST_StartDate;
        private string _BCCMST_EndDate;
        private int _BCCMST_CycleFor;
        private string _BCCMST_BillingTime;

        private int _BCCMST_SGraceDays;
        private int _BCCMST_EGraceDays;
        private string _BCCMST_RowStatus;
        private string _CENMST_Name;
        private int _Count;
        #endregion

        /// <summary>
	    /// Default constructor for BILBillingCycleMaster class.
	    /// </summary>
	    public BILBillingCycleMasterList() { }

	    /// <summary>
	    /// Overloaded constructor for the Branch class.
	    /// </summary>
        public BILBillingCycleMasterList(int BCCMST_BillingID, int CD_ControlID, string CustomerType, string BCCMST_ShortName, string BCCMST_StartDate, string BCCMST_EndDate, int BCCMST_CycleFor, string BCCMST_BillingTime, int BCCMST_SGraceDays, int BCCMST_EGraceDays, string BCCMST_RowStatus, string CENMST_Name, int Count)
        {
            this._BCCMST_BillingID = BCCMST_BillingID;
            this._CD_ControlID = CD_ControlID;
            this._CustomerType = CustomerType;
            this._BCCMST_ShortName = BCCMST_ShortName;
            this._BCCMST_StartDate = BCCMST_StartDate;
            this._BCCMST_EndDate = BCCMST_EndDate;
            this._BCCMST_CycleFor = BCCMST_CycleFor;
            this._BCCMST_BillingTime = BCCMST_BillingTime;
           
            this._BCCMST_SGraceDays = BCCMST_SGraceDays;
            this._BCCMST_EGraceDays = BCCMST_EGraceDays;
            this._BCCMST_RowStatus = BCCMST_RowStatus;
            this._CENMST_Name = CENMST_Name;
            this._Count = Count;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_BillingID
        {
            get { return _BCCMST_BillingID; }
            set { _BCCMST_BillingID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }        

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_StartDate
        {
            get { return _BCCMST_StartDate; }
            set { _BCCMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_EndDate
        {
            get { return _BCCMST_EndDate; }
            set { _BCCMST_EndDate = value; }
        }
        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_CycleFor
        {
            get { return _BCCMST_CycleFor; }
            set { _BCCMST_CycleFor = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_BillingTime
        {
            get { return _BCCMST_BillingTime; }
            set { _BCCMST_BillingTime = value; }
        }
        /// <summary>
       


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_SGraceDays
        {
            get { return _BCCMST_SGraceDays; }
            set { _BCCMST_SGraceDays = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_EGraceDays
        {
            get { return _BCCMST_EGraceDays; }
            set { _BCCMST_EGraceDays = value; }
        }

         /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_RowStatus
        {
            get { return _BCCMST_RowStatus; }
            set { _BCCMST_RowStatus = value; }
        }

        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }


    public class BILBillingCycleMasterMsg
    {
	    // Class level Local Variables Declaration.
	    #region "Variables Declaration"
            private int _RetVal;
            private string _RetStr;
	    #endregion

	    /// <summary>
	    //Overloaded default constructor for the Salutation class. 
	    /// </summary>
        public BILBillingCycleMasterMsg(){ }
	    /// <summary>
	    //Overloaded constructor for the Salutation class. 
	    /// </summary>
	    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	    /// <param name="saltnmName">Name of the Salutation.</param>
        public BILBillingCycleMasterMsg(int RetVal, string RetStr)
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
