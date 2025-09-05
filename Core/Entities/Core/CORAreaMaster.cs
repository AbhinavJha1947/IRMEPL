//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORAreaMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORAreaMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORAreaMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _AREMST_AreaCode;
		private string _AREMST_Name;       
		private int _AREMST_CENCode;
        private int _AREMST_CityCode;
        private int _AREMST_StateCode;
		private int _AREMST_CreatedByUserID;
		private string _AREMST_CreatedDateTime;
		private int _AREMST_UpdatedByUserID;
		private string _AREMST_UpdatedDateTime;
		private int _AREMST_RowStatus;
		private long _AREMST_RowVersion;
        private int _AREMST_BillingPeriod;
	#endregion

	/// <summary>
	/// Default constructor for CORAreaMaster class.
	/// </summary>
	public CORAreaMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public CORAreaMaster(int AREMST_AreaCode, string AREMST_Name, int AREMST_CENCode, int AREMST_CityCode, int AREMST_StateCode, int AREMST_CreatedByUserID, string AREMST_CreatedDateTime, int AREMST_UpdatedByUserID, string AREMST_UpdatedDateTime, int AREMST_RowStatus, long AREMST_RowVersion, int AREMST_BillingPeriod)
	{
	this._AREMST_AreaCode = AREMST_AreaCode;
	this._AREMST_Name = AREMST_Name;
	this._AREMST_CENCode = AREMST_CENCode;
    this._AREMST_CityCode = AREMST_CityCode;
    this._AREMST_StateCode = AREMST_StateCode;
	this._AREMST_CreatedByUserID = AREMST_CreatedByUserID;
	this._AREMST_CreatedDateTime = AREMST_CreatedDateTime;
	this._AREMST_UpdatedByUserID = AREMST_UpdatedByUserID;
	this._AREMST_UpdatedDateTime = AREMST_UpdatedDateTime;
	this._AREMST_RowStatus = AREMST_RowStatus;
	this._AREMST_RowVersion = AREMST_RowVersion;
    this._AREMST_BillingPeriod = AREMST_BillingPeriod;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AREMST_AreaCode
		{
			 get { return _AREMST_AreaCode; }
			 set { _AREMST_AreaCode = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AREMST_Name
		{
			 get { return _AREMST_Name; }
			 set { _AREMST_Name = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AREMST_CENCode
		{
			 get { return _AREMST_CENCode; }
			 set { _AREMST_CENCode = value; }
		}
    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int AREMST_CityCode
    {
        get { return _AREMST_CityCode; }
        set { _AREMST_CityCode = value; }
    }
    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int AREMST_StateCode
    {
        get { return _AREMST_StateCode; }
        set { _AREMST_StateCode = value; }
    }
	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AREMST_CreatedByUserID
		{
			 get { return _AREMST_CreatedByUserID; }
			 set { _AREMST_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AREMST_CreatedDateTime
		{
			 get { return _AREMST_CreatedDateTime; }
			 set { _AREMST_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AREMST_UpdatedByUserID
		{
			 get { return _AREMST_UpdatedByUserID; }
			 set { _AREMST_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AREMST_UpdatedDateTime
		{
			 get { return _AREMST_UpdatedDateTime; }
			 set { _AREMST_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AREMST_RowStatus
		{
			 get { return _AREMST_RowStatus; }
			 set { _AREMST_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long AREMST_RowVersion
		{
			 get { return _AREMST_RowVersion; }
			 set { _AREMST_RowVersion = value; }
		}
    /// <summary>
	//Write Column Description here. 
	/// </summary>
    public int AREMST_BillingPeriod
		{
            get { return _AREMST_BillingPeriod; }
            set { _AREMST_BillingPeriod = value; }
		}
        

	}

    public class 	CORAreaMasterList
    {
        
	    /// Class level Local Variables Declaration.
	    #region "Variables Declaration"
		    private int _AREMST_AreaCode;
		    private string _AREMST_Name;
            private string _StateName;
            private string _CityName;
		    private string _AREMST_CENCode;
            private int _AREMST_CityCode;
            private int _AREMST_StateCode;
            private string _AREMST_BillingPeriod;
            private string _AREMST_RowStatus;
            private string _GACode;
		    private int _Count;
	    #endregion

	    /// <summary>
	    /// Default constructor for CORAreaMaster class.
	    /// </summary>
	    public CORAreaMasterList() { }

	    /// <summary>
	    /// Overloaded constructor for the Branch class.
	    /// </summary>
        public CORAreaMasterList(int AREMST_AreaCode, string AREMST_Name, string StateName, string CityName, string AREMST_CENCode, int AREMST_CityCode, int AREMST_StateCode, string AREMST_BillingPeriod, string AREMST_RowStatus,string GACode, int Count)
        {
            this._AREMST_AreaCode = AREMST_AreaCode;
            this._AREMST_Name = AREMST_Name;
            this._StateName = StateName;
            this._CityName = CityName;
            this._AREMST_CENCode = AREMST_CENCode;
            this._AREMST_CityCode = AREMST_CityCode;
            this._AREMST_StateCode = AREMST_StateCode;
            this._AREMST_BillingPeriod = AREMST_BillingPeriod;
            this._AREMST_RowStatus = AREMST_RowStatus;
            this._GACode = GACode;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AREMST_AreaCode
        {
            get { return _AREMST_AreaCode; }
            set { _AREMST_AreaCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string GACode
        {
            get { return _GACode; }
            set { _GACode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AREMST_CENCode
        {
            get { return _AREMST_CENCode; }
            set { _AREMST_CENCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AREMST_CityCode
        {
            get { return _AREMST_CityCode; }
            set { _AREMST_CityCode = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AREMST_StateCode
        {
            get { return _AREMST_StateCode; }
            set { _AREMST_StateCode = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AREMST_BillingPeriod
        {
            get { return _AREMST_BillingPeriod; }
            set { _AREMST_BillingPeriod = value; }
        } 
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AREMST_RowStatus
        {
            get { return _AREMST_RowStatus; }
            set { _AREMST_RowStatus = value; }
        }  
        
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    //Write this List class yourself.
    //This List Class can not be generate using this utility.
    //--VBS
    }

    public class FetchCenterNameForLoggedinUser
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _USER_ID;
        private string _USER_LOGINID;
        private int _USER_BRANCHID;
        private string _CENMST_NAME;
        #endregion

        /// <summary>
        /// Default constructor for CORAreaMaster class.
        /// </summary>
        public FetchCenterNameForLoggedinUser() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public FetchCenterNameForLoggedinUser(int USER_ID, string USER_LOGINID, int USER_BRANCHID, string CENMST_NAME)
        {
            this._USER_ID = USER_ID;
            this._USER_LOGINID = USER_LOGINID;
            this._USER_BRANCHID = USER_BRANCHID;
            this._CENMST_NAME = CENMST_NAME;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LOGINID
        {
            get { return _USER_LOGINID; }
            set { _USER_LOGINID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USER_BRANCHID
        {
            get { return _USER_BRANCHID; }
            set { _USER_BRANCHID = value; }
        }
        public string CENMST_NAME
        {
            get { return _CENMST_NAME; }
            set { _CENMST_NAME = value; }
        }

        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
    }
    
    public class CORAreaMasterMsg
    {
	    // Class level Local Variables Declaration.
	    #region "Variables Declaration"
            private int _RetVal;
            private string _RetStr;
	    #endregion

	    /// <summary>
	    //Overloaded default constructor for the Salutation class. 
	    /// </summary>
        public CORAreaMasterMsg(){ }
	    /// <summary>
	    //Overloaded constructor for the Salutation class. 
	    /// </summary>
	    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	    /// <param name="saltnmName">Name of the Salutation.</param>
        public CORAreaMasterMsg(int RetVal, string RetStr)
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
