//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	BILBillingPeriodMST.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	BILBillingPeriodMSTService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	BILBillingPeriodMST
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _BILMST_PeriodID;
		private string _BILMST_Name;
		private int _BILMST_CreatedBy;
		private string _BILMST_CreatedDate;
		private int _BILMST_UpdatedBy;
		private string _BILMST_UpdatedDate;
		private int _BILMST_RowStatus;
        private long _BILMST_RowVersion; 
	#endregion

	/// <summary>
	/// Default constructor for BILBillingPeriodMST class.
	/// </summary>
	public BILBillingPeriodMST() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public BILBillingPeriodMST(int BILMST_PeriodID, string BILMST_Name, int BILMST_CreatedBy, string BILMST_CreatedDate, int BILMST_UpdatedBy, string BILMST_UpdatedDate, int BILMST_RowStatus, long BILMST_RowVersion)
	{
	this._BILMST_PeriodID = BILMST_PeriodID;
	this._BILMST_Name = BILMST_Name;
	this._BILMST_CreatedBy = BILMST_CreatedBy;
	this._BILMST_CreatedDate = BILMST_CreatedDate;
	this._BILMST_UpdatedBy = BILMST_UpdatedBy;
	this._BILMST_UpdatedDate = BILMST_UpdatedDate;
	this._BILMST_RowStatus = BILMST_RowStatus;
    this._BILMST_RowVersion = BILMST_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BILMST_PeriodID
		{
			 get { return _BILMST_PeriodID; }
			 set { _BILMST_PeriodID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BILMST_Name
		{
			 get { return _BILMST_Name; }
			 set { _BILMST_Name = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BILMST_CreatedBy
		{
			 get { return _BILMST_CreatedBy; }
			 set { _BILMST_CreatedBy = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BILMST_CreatedDate
		{
			 get { return _BILMST_CreatedDate; }
			 set { _BILMST_CreatedDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BILMST_UpdatedBy
		{
			 get { return _BILMST_UpdatedBy; }
			 set { _BILMST_UpdatedBy = value; }
		}
        
	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BILMST_RowStatus
		{
			 get { return _BILMST_RowStatus; }
			 set { _BILMST_RowStatus = value; }
		}

    public long BILMST_RowVersion
    {
        get { return _BILMST_RowVersion; }
        set { _BILMST_RowVersion = value; }
    }
	}

    public class BILBillingPeriodMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BILMST_PeriodID;
        private string _BILMST_Name;
        private string _BILMST_RowStatus;
        private int _Count;     
        #endregion

        /// <summary>
        /// Default constructor for BILBillingCycleMaster class.
        /// </summary>
        public BILBillingPeriodMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILBillingPeriodMSTList(int BILMST_PeriodID, string BILMST_Name, string BILMST_RowStatus, int Count)
        {
            this._BILMST_PeriodID = BILMST_PeriodID;            
            this._BILMST_Name = BILMST_Name;
            this._BILMST_RowStatus = BILMST_RowStatus;            
            this._Count = Count;            
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BILMST_PeriodID
        {
            get { return _BILMST_PeriodID; }
            set { _BILMST_PeriodID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BILMST_Name
        {
            get { return _BILMST_Name; }
            set { _BILMST_Name = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BILMST_RowStatus
        {
            get { return _BILMST_RowStatus; }
            set { _BILMST_RowStatus = value; }
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
    public class BILBillingPeriodMSTMsg
    {
	    // Class level Local Variables Declaration.
	    #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
	    #endregion

	    /// <summary>
	    //Overloaded default constructor for the Salutation class. 
	    /// </summary>
        public BILBillingPeriodMSTMsg(){ }
	    /// <summary>
	    //Overloaded constructor for the Salutation class. 
	    /// </summary>
	    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	    /// <param name="saltnmName">Name of the Salutation.</param>
        public BILBillingPeriodMSTMsg(int RetVal, string RetStr)
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
