//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORSetupConfigMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORSetupConfigMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORSetupConfigMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _SCFMST_ConfigID;
		private string _SCFMST_KeyText;
		private string _SCFMST_KeyValue;
		private int _SCFMST_CreatedByUserID;
		private string _SCFMST_CreatedDateTime;
		private int _SCFMST_UpdatedByUserID;
		private string _SCFMST_UpdatedDateTime;
		private int _SCFMST_RowStatus;
		private long _SCFMST_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for CORSetupConfigMaster class.
	/// </summary>
	public CORSetupConfigMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public CORSetupConfigMaster(int SCFMST_ConfigID, string SCFMST_KeyText, string SCFMST_KeyValue, int SCFMST_CreatedByUserID, string SCFMST_CreatedDateTime, int SCFMST_UpdatedByUserID, string SCFMST_UpdatedDateTime, int SCFMST_RowStatus, long SCFMST_RowVersion)
	{
	this._SCFMST_ConfigID = SCFMST_ConfigID;
	this._SCFMST_KeyText = SCFMST_KeyText;
	this._SCFMST_KeyValue = SCFMST_KeyValue;
	this._SCFMST_CreatedByUserID = SCFMST_CreatedByUserID;
	this._SCFMST_CreatedDateTime = SCFMST_CreatedDateTime;
	this._SCFMST_UpdatedByUserID = SCFMST_UpdatedByUserID;
	this._SCFMST_UpdatedDateTime = SCFMST_UpdatedDateTime;
	this._SCFMST_RowStatus = SCFMST_RowStatus;
	this._SCFMST_RowVersion = SCFMST_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int SCFMST_ConfigID
		{
			 get { return _SCFMST_ConfigID; }
			 set { _SCFMST_ConfigID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string SCFMST_KeyText
		{
			 get { return _SCFMST_KeyText; }
			 set { _SCFMST_KeyText = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string SCFMST_KeyValue
		{
			 get { return _SCFMST_KeyValue; }
			 set { _SCFMST_KeyValue = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int SCFMST_CreatedByUserID
		{
			 get { return _SCFMST_CreatedByUserID; }
			 set { _SCFMST_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string SCFMST_CreatedDateTime
		{
			 get { return _SCFMST_CreatedDateTime; }
			 set { _SCFMST_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int SCFMST_UpdatedByUserID
		{
			 get { return _SCFMST_UpdatedByUserID; }
			 set { _SCFMST_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string SCFMST_UpdatedDateTime
		{
			 get { return _SCFMST_UpdatedDateTime; }
			 set { _SCFMST_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int SCFMST_RowStatus
		{
			 get { return _SCFMST_RowStatus; }
			 set { _SCFMST_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long SCFMST_RowVersion
		{
			 get { return _SCFMST_RowVersion; }
			 set { _SCFMST_RowVersion = value; }
		}
    }

    public class 	CORSetupConfigMasterList
    {
        
	    /// Class level Local Variables Declaration.
	    #region "Variables Declaration"
		    private int _SCFMST_ConfigID;
		    private string _SCFMST_KeyText;
		    private string _SCFMST_KeyValue;
            private string _SCFMST_RowStatus;
		    private int _Count;
	    #endregion

	    /// <summary>
	    /// Default constructor for CORSetupConfigMaster class.
	    /// </summary>
	    public CORSetupConfigMasterList() { }

	    /// <summary>
	    /// Overloaded constructor for the Branch class.
	    /// </summary>
        public CORSetupConfigMasterList(int SCFMST_ConfigID, string SCFMST_KeyText, string SCFMST_KeyValue,string SCFMST_RowStatus, int Count)
        {
            this._SCFMST_ConfigID = SCFMST_ConfigID;
            this._SCFMST_KeyText = SCFMST_KeyText;
            this._SCFMST_KeyValue = SCFMST_KeyValue;
            this._SCFMST_RowStatus = SCFMST_RowStatus;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int SCFMST_ConfigID
        {
            get { return _SCFMST_ConfigID; }
            set { _SCFMST_ConfigID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCFMST_KeyText
        {
            get { return _SCFMST_KeyText; }
            set { _SCFMST_KeyText = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCFMST_KeyValue
        {
            get { return _SCFMST_KeyValue; }
            set { _SCFMST_KeyValue = value; }
        }
                
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCFMST_RowStatus
        {
            get { return _SCFMST_RowStatus; }
            set { _SCFMST_RowStatus = value; }
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

    public class CORSetupConfigMasterMsg
    {
	    // Class level Local Variables Declaration.
	    #region "Variables Declaration"
            private int _RetVal;
            private string _RetStr;
	    #endregion

	    /// <summary>
	    //Overloaded default constructor for the Salutation class. 
	    /// </summary>
        public CORSetupConfigMasterMsg(){ }
	    /// <summary>
	    //Overloaded constructor for the Salutation class. 
	    /// </summary>
	    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	    /// <param name="saltnmName">Name of the Salutation.</param>
        public CORSetupConfigMasterMsg(int RetVal, string RetStr)
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
