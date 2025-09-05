//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	ACCCustomerDueTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	ACCCustomerDueTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	ACCCustomerDueTRN
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _CDUTRN_ID;
		private decimal _CDUTRN_ApplicationId;
		private int _CDUTRN_Head;
		private decimal _CDUTRN_AmountDue;
		private decimal _CDUTRN_AmountReceived;
		private string _CDUTRN_RecDate;
		private int _CDUTRN_CreatedByUserID;
		private string _CDUTRN_CreatedDateTime;
		private int _CDUTRN_UpdatedByUserID;
		private string _CDUTRN_UpdatedDateTime;
		private int _CDUTRN_RowStatus;
		private long _CDUTRN_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for ACCCustomerDueTRN class.
	/// </summary>
	public ACCCustomerDueTRN() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public ACCCustomerDueTRN(int CDUTRN_ID,decimal CDUTRN_ApplicationId,int CDUTRN_Head,decimal CDUTRN_AmountDue,decimal CDUTRN_AmountReceived,string CDUTRN_RecDate,int CDUTRN_CreatedByUserID,string CDUTRN_CreatedDateTime,int CDUTRN_UpdatedByUserID,string CDUTRN_UpdatedDateTime,int CDUTRN_RowStatus,long CDUTRN_RowVersion)
	{
	this._CDUTRN_ID = CDUTRN_ID;
	this._CDUTRN_ApplicationId = CDUTRN_ApplicationId;
	this._CDUTRN_Head = CDUTRN_Head;
	this._CDUTRN_AmountDue = CDUTRN_AmountDue;
	this._CDUTRN_AmountReceived = CDUTRN_AmountReceived;
	this._CDUTRN_RecDate = CDUTRN_RecDate;
	this._CDUTRN_CreatedByUserID = CDUTRN_CreatedByUserID;
	this._CDUTRN_CreatedDateTime = CDUTRN_CreatedDateTime;
	this._CDUTRN_UpdatedByUserID = CDUTRN_UpdatedByUserID;
	this._CDUTRN_UpdatedDateTime = CDUTRN_UpdatedDateTime;
	this._CDUTRN_RowStatus = CDUTRN_RowStatus;
	this._CDUTRN_RowVersion = CDUTRN_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CDUTRN_ID
		{
			 get { return _CDUTRN_ID; }
			 set { _CDUTRN_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal CDUTRN_ApplicationId
		{
			 get { return _CDUTRN_ApplicationId; }
			 set { _CDUTRN_ApplicationId = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CDUTRN_Head
		{
			 get { return _CDUTRN_Head; }
			 set { _CDUTRN_Head = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal CDUTRN_AmountDue
		{
			 get { return _CDUTRN_AmountDue; }
			 set { _CDUTRN_AmountDue = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal CDUTRN_AmountReceived
		{
			 get { return _CDUTRN_AmountReceived; }
			 set { _CDUTRN_AmountReceived = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CDUTRN_RecDate
		{
			 get { return _CDUTRN_RecDate; }
			 set { _CDUTRN_RecDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CDUTRN_CreatedByUserID
		{
			 get { return _CDUTRN_CreatedByUserID; }
			 set { _CDUTRN_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CDUTRN_CreatedDateTime
		{
			 get { return _CDUTRN_CreatedDateTime; }
			 set { _CDUTRN_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CDUTRN_UpdatedByUserID
		{
			 get { return _CDUTRN_UpdatedByUserID; }
			 set { _CDUTRN_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CDUTRN_UpdatedDateTime
		{
			 get { return _CDUTRN_UpdatedDateTime; }
			 set { _CDUTRN_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CDUTRN_RowStatus
		{
			 get { return _CDUTRN_RowStatus; }
			 set { _CDUTRN_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long CDUTRN_RowVersion
		{
			 get { return _CDUTRN_RowVersion; }
			 set { _CDUTRN_RowVersion = value; }
		}

	}

public class 	ACCCustomerDueTRNList
{
    #region "Variables Declaration"
    private int _CDUTRN_ID;
    private decimal _CDUTRN_ApplicationId;
    private string _HeadName;
    private string _RefType;
    private string _RefNo;
    private int _CDUTRN_Head;
    private decimal _CDUTRN_AmountDue;
    private decimal _CDUTRN_AmountReceived;
    private decimal _DueAmt;
    private int _EMI;
    private int _EMIPaid;
    private int _Count;
    #endregion
public ACCCustomerDueTRNList() { }
public ACCCustomerDueTRNList(int CDUTRN_ID, decimal CDUTRN_ApplicationId, string HeadName, string RefType, string RefNo, int CDUTRN_Head, decimal CDUTRN_AmountDue, decimal CDUTRN_AmountReceived, decimal DueAmt, int EMI, int EMIPaid, int Count)
{
        this._CDUTRN_ID = CDUTRN_ID;
        this._CDUTRN_ApplicationId = CDUTRN_ApplicationId;
        this._HeadName = HeadName;
        this._RefType = RefType;
        this._RefNo = RefNo;
        this._CDUTRN_Head = CDUTRN_Head;
        this._CDUTRN_AmountDue = CDUTRN_AmountDue;
        this._CDUTRN_AmountReceived = CDUTRN_AmountReceived;
        this._DueAmt = DueAmt;
        this._EMI = EMI;
        this._EMIPaid =EMIPaid ;
        this._Count = Count;
}
    public int CDUTRN_ID
    {
        get { return _CDUTRN_ID; }
        set { _CDUTRN_ID = value; }
    }
    public decimal CDUTRN_ApplicationId
    {
        get { return _CDUTRN_ApplicationId; }
        set { _CDUTRN_ApplicationId = value; }
    }

    public string HeadName
    {
        get { return _HeadName; }
        set { _HeadName = value; }
    }

    public string RefType
    {
        get { return _RefType; }
        set { _RefType = value; }
    }

    public string RefNo
    {
        get { return _RefNo; }
        set { _RefNo = value; }
    }

    public int CDUTRN_Head
    {
        get { return _CDUTRN_Head; }
        set { _CDUTRN_Head = value; }
    }
    public decimal CDUTRN_AmountDue
    {
        get { return _CDUTRN_AmountDue; }
        set { _CDUTRN_AmountDue = value; }
    }

    public decimal CDUTRN_AmountReceived
    {
        get { return _CDUTRN_AmountReceived; }
        set { _CDUTRN_AmountReceived = value; }
    }

    public decimal DueAmt
    {
        get { return _DueAmt; }
        set { _DueAmt = value; }
    }
    public int EMI
    {
        get { return _EMI; }
        set { _EMI = value; }
    }
    public int EMIPaid
    {
        get { return _EMIPaid; }
        set { _EMIPaid = value; }
    }
    public int Count
    {
        get { return _Count; }
        set { _Count = value; }
    }
}


public class ACCCustomerDueTRNMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public ACCCustomerDueTRNMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public ACCCustomerDueTRNMsg(int RetVal, string RetStr)
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
