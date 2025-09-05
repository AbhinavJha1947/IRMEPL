//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	PRDExConnReqFormHDRTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	PRDExConnReqFormHDRTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	PRDExConnReqFormHDRTRN
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private decimal _EXCHDR_EConnID;
		private decimal _EXCHDR_ApplicationID;
        private string _APPMST_CustomerID;
		private string _EXCHDR_RequestDate;
		private int _EXCHDR_RequestFor;
		private int _EXCHDR_RequestStatus;
		private decimal _EXCHDR_DueAmount;
		private decimal _EXCHDR_ReceiptID;
		private decimal _EXCHDR_ReceivedAmount;
		private string _EXCHDR_Remarks;
		private int _EXCHDR_CreatedByUserID;
		private string _EXCHDR_CreatedDateTime;
		private int _EXCHDR_UpdatedByUserID;
		private string _EXCHDR_UpdatedDateTime;
		private int _EXCHDR_RowStatus;
		private long _EXCHDR_RowVersion;
        private string _EXCHDR_RequestNo;
        private int _Editable;
        private int _EXCHDR_RequestCancelStatus;
        private string _EXCHDR_RequestCancelDate;
	#endregion

	/// <summary>
	/// Default constructor for PRDExConnReqFormHDRTRN class.
	/// </summary>
	public PRDExConnReqFormHDRTRN() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public PRDExConnReqFormHDRTRN(decimal EXCHDR_EConnID, decimal EXCHDR_ApplicationID, string APPMST_CustomerID, string EXCHDR_RequestDate, int EXCHDR_RequestFor, int EXCHDR_RequestStatus, decimal EXCHDR_DueAmount, decimal EXCHDR_ReceiptID, decimal EXCHDR_ReceivedAmount, string EXCHDR_Remarks, int EXCHDR_CreatedByUserID, string EXCHDR_CreatedDateTime, int EXCHDR_UpdatedByUserID, string EXCHDR_UpdatedDateTime, int EXCHDR_RowStatus, long EXCHDR_RowVersion, string EXCHDR_RequestNo, int Editable, int EXCHDR_RequestCancelStatus, string EXCHDR_RequestCancelDate)
	{
	this._EXCHDR_EConnID = EXCHDR_EConnID;
	this._EXCHDR_ApplicationID = EXCHDR_ApplicationID;
    this._APPMST_CustomerID = APPMST_CustomerID;
	this._EXCHDR_RequestDate = EXCHDR_RequestDate;
	this._EXCHDR_RequestFor = EXCHDR_RequestFor;
	this._EXCHDR_RequestStatus = EXCHDR_RequestStatus;
	this._EXCHDR_DueAmount = EXCHDR_DueAmount;
	this._EXCHDR_ReceiptID = EXCHDR_ReceiptID;
	this._EXCHDR_ReceivedAmount = EXCHDR_ReceivedAmount;
	this._EXCHDR_Remarks = EXCHDR_Remarks;
	this._EXCHDR_CreatedByUserID = EXCHDR_CreatedByUserID;
	this._EXCHDR_CreatedDateTime = EXCHDR_CreatedDateTime;
	this._EXCHDR_UpdatedByUserID = EXCHDR_UpdatedByUserID;
	this._EXCHDR_UpdatedDateTime = EXCHDR_UpdatedDateTime;
	this._EXCHDR_RowStatus = EXCHDR_RowStatus;
	this._EXCHDR_RowVersion = EXCHDR_RowVersion;
    this._EXCHDR_RequestNo = EXCHDR_RequestNo;
    this._Editable = Editable;
    this._EXCHDR_RequestCancelStatus = EXCHDR_RequestCancelStatus;
    this._EXCHDR_RequestCancelDate = EXCHDR_RequestCancelDate;

	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal EXCHDR_EConnID
		{
			 get { return _EXCHDR_EConnID; }
			 set { _EXCHDR_EConnID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal EXCHDR_ApplicationID
		{
			 get { return _EXCHDR_ApplicationID; }
			 set { _EXCHDR_ApplicationID = value; }
		}

    /// <summary>
	//Write Column Description here. 
	/// </summary>
    public string APPMST_CustomerID
		{
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
		}
        

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string EXCHDR_RequestDate
		{
			 get { return _EXCHDR_RequestDate; }
			 set { _EXCHDR_RequestDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int EXCHDR_RequestFor
		{
			 get { return _EXCHDR_RequestFor; }
			 set { _EXCHDR_RequestFor = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int EXCHDR_RequestStatus
		{
			 get { return _EXCHDR_RequestStatus; }
			 set { _EXCHDR_RequestStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal EXCHDR_DueAmount
		{
			 get { return _EXCHDR_DueAmount; }
			 set { _EXCHDR_DueAmount = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal EXCHDR_ReceiptID
		{
			 get { return _EXCHDR_ReceiptID; }
			 set { _EXCHDR_ReceiptID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal EXCHDR_ReceivedAmount
		{
			 get { return _EXCHDR_ReceivedAmount; }
			 set { _EXCHDR_ReceivedAmount = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string EXCHDR_Remarks
		{
			 get { return _EXCHDR_Remarks; }
			 set { _EXCHDR_Remarks = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int EXCHDR_CreatedByUserID
		{
			 get { return _EXCHDR_CreatedByUserID; }
			 set { _EXCHDR_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string EXCHDR_CreatedDateTime
		{
			 get { return _EXCHDR_CreatedDateTime; }
			 set { _EXCHDR_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int EXCHDR_UpdatedByUserID
		{
			 get { return _EXCHDR_UpdatedByUserID; }
			 set { _EXCHDR_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string EXCHDR_UpdatedDateTime
		{
			 get { return _EXCHDR_UpdatedDateTime; }
			 set { _EXCHDR_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int EXCHDR_RowStatus
		{
			 get { return _EXCHDR_RowStatus; }
			 set { _EXCHDR_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long EXCHDR_RowVersion
		{
			 get { return _EXCHDR_RowVersion; }
			 set { _EXCHDR_RowVersion = value; }
		}
    public string EXCHDR_RequestNo
		{
            get { return _EXCHDR_RequestNo; }
            set { _EXCHDR_RequestNo = value; }
		}

    public int Editable
    {
        get { return _Editable; }
        set { _Editable = value; }
    }

    public int EXCHDR_RequestCancelStatus
    {
        get { return _EXCHDR_RequestCancelStatus; }
        set { _EXCHDR_RequestCancelStatus = value; }
    }

    public string EXCHDR_RequestCancelDate
    {
        get { return _EXCHDR_RequestCancelDate; }
        set { _EXCHDR_RequestCancelDate = value; }
    }

	}

    public class 	PRDExConnReqFormHDRTRNList
    {
    /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _EXCHDR_EConnID; 
        private string _APPMST_CustomerID;
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _EXCHDR_RequestDate;
        private int _CD_ControlID;
        private string _RequestFor;
        private decimal _EXCHDR_DueAmount;
        private decimal _EXCHDR_ReceivedAmount;
        private decimal _EstimatedAmount;
        private string _EXCHDR_RequestNo;
        private int _EXCHDR_RequestStatus;
        private int _EXCHDR_RequestCancelStatus;
        private string _EXCHDR_RequestCancelDate;
        private int _Count;
        #endregion

        /// <summary>
	    /// Default constructor for BILBillingCycleMaster class.
	    /// </summary>
	    public PRDExConnReqFormHDRTRNList() { }

	    /// <summary>
	    /// Overloaded constructor for the Branch class.
	    /// </summary>
        public PRDExConnReqFormHDRTRNList(int EXCHDR_EConnID, string APPMST_CustomerID, string APPMST_AppNo, string CustomerName, string EXCHDR_RequestDate, int CD_ControlID, string RequestFor, decimal EXCHDR_DueAmount, decimal EXCHDR_ReceivedAmount, decimal EstimatedAmount, string EXCHDR_RequestNo, int EXCHDR_RequestStatus, int EXCHDR_RequestCancelStatus, string EXCHDR_RequestCancelDate, int Count)
        {
            this._EXCHDR_EConnID = EXCHDR_EConnID;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CustomerName = CustomerName;
            this._EXCHDR_RequestDate = EXCHDR_RequestDate;
            this._CD_ControlID = CD_ControlID;
            this._RequestFor = RequestFor;
            this._EXCHDR_DueAmount = EXCHDR_DueAmount;
            this._EXCHDR_ReceivedAmount = EXCHDR_ReceivedAmount;
            this._EstimatedAmount = EstimatedAmount;
            this._EXCHDR_RequestNo = EXCHDR_RequestNo;
            this._EXCHDR_RequestStatus = EXCHDR_RequestStatus;
            this._EXCHDR_RequestCancelStatus = EXCHDR_RequestCancelStatus;
            this._EXCHDR_RequestCancelDate = EXCHDR_RequestCancelDate;
            this._Count = Count;
        }
        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCHDR_EConnID
        {
            get { return _EXCHDR_EConnID; }
            set { _EXCHDR_EConnID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        } 
         /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }   
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string EXCHDR_RequestDate
        {
            get { return _EXCHDR_RequestDate; }
            set { _EXCHDR_RequestDate = value; }
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
        public string RequestFor
        {
            get { return _RequestFor; }
            set { _RequestFor = value; }
        }   
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal EXCHDR_DueAmount
        {
            get { return _EXCHDR_DueAmount; }
            set { _EXCHDR_DueAmount = value; }
        }
        public decimal EXCHDR_ReceivedAmount
        {
            get { return _EXCHDR_ReceivedAmount; }
            set { _EXCHDR_ReceivedAmount = value; }
        }
         public decimal EstimatedAmount
        {
            get { return _EstimatedAmount; }
            set { _EstimatedAmount = value; }
        }
         public string EXCHDR_RequestNo
         {
             get { return _EXCHDR_RequestNo; }
             set { _EXCHDR_RequestNo = value; }
         }

         public int EXCHDR_RequestStatus 
         {
             get { return _EXCHDR_RequestStatus; }
             set { _EXCHDR_RequestStatus = value; }
         }

         public int EXCHDR_RequestCancelStatus
         {
             get { return _EXCHDR_RequestCancelStatus; }
             set { _EXCHDR_RequestCancelStatus = value; }
         }

        public string EXCHDR_RequestCancelDate
         {
             get { return _EXCHDR_RequestCancelDate; }
             set { _EXCHDR_RequestCancelDate = value; }
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
    public class PRDExConnReqFormHDRTRNMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public PRDExConnReqFormHDRTRNMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public PRDExConnReqFormHDRTRNMsg(int RetVal, string RetStr)
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
