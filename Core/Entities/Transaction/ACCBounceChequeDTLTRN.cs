//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	ACCBounceChequeDTLTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	ACCBounceChequeDTLTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	ACCBounceChequeDTLTRN
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _BCHDTL_ChequeID;
		private int _BCHDTL_ApplicationId;
        private int _BCHDTL_CorporateId;
		private int _BCHDTL_OldChequeID;
		private int _BCHDTL_BankId;
		private string _BCHDTL_Remarks;
        private string _BCHDTL_ChequeNo;
		private string _BCHDTL_ChequeDate;
		private int _BCHDTL_ChequeAmount;
		private int _BCHDTL_LotID;
		private string _BCHDTL_RealizedDate;
		private int _BCHDTL_Status;
		private int _BCHDTL_CENcode;
		private string _BCHDTL_DishonourDate;
		private string _BCHDTL_DisReason;
		private int _BCHDTL_IsBounceChargeIncluded;
		private decimal _BCHDTL_BounceCharges;
		private int _BCHDTL_CreatedByUserID;
		private string _BCHDTL_CreatedDateTime;
		private int _BCHDTL_UpdatedByUserID;
		private string _BCHDTL_UpdatedDateTime;
		private int _BCHDTL_RowStatus;
		private long _BCHDTL_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for ACCBounceChequeDTLTRN class.
	/// </summary>
	public ACCBounceChequeDTLTRN() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public ACCBounceChequeDTLTRN(int BCHDTL_ChequeID, int BCHDTL_ApplicationId, int BCHDTL_CorporateId, int BCHDTL_OldChequeID, int BCHDTL_BankId, string BCHDTL_Remarks, string BCHDTL_ChequeNo, string BCHDTL_ChequeDate, int BCHDTL_ChequeAmount, int BCHDTL_LotID, string BCHDTL_RealizedDate, int BCHDTL_Status, int BCHDTL_CENcode, string BCHDTL_DishonourDate, string BCHDTL_DisReason, int BCHDTL_IsBounceChargeIncluded, decimal BCHDTL_BounceCharges, int BCHDTL_CreatedByUserID, string BCHDTL_CreatedDateTime, int BCHDTL_UpdatedByUserID, string BCHDTL_UpdatedDateTime, int BCHDTL_RowStatus, long BCHDTL_RowVersion)
	{
	this._BCHDTL_ChequeID = BCHDTL_ChequeID;
	this._BCHDTL_ApplicationId = BCHDTL_ApplicationId;
    this._BCHDTL_CorporateId = BCHDTL_CorporateId;
	this._BCHDTL_OldChequeID = BCHDTL_OldChequeID;
	this._BCHDTL_BankId = BCHDTL_BankId;
	this._BCHDTL_Remarks = BCHDTL_Remarks;
	this._BCHDTL_ChequeNo = BCHDTL_ChequeNo;
	this._BCHDTL_ChequeDate = BCHDTL_ChequeDate;
	this._BCHDTL_ChequeAmount = BCHDTL_ChequeAmount;
	this._BCHDTL_LotID = BCHDTL_LotID;
	this._BCHDTL_RealizedDate = BCHDTL_RealizedDate;
	this._BCHDTL_Status = BCHDTL_Status;
	this._BCHDTL_CENcode = BCHDTL_CENcode;
	this._BCHDTL_DishonourDate = BCHDTL_DishonourDate;
	this._BCHDTL_DisReason = BCHDTL_DisReason;
	this._BCHDTL_IsBounceChargeIncluded = BCHDTL_IsBounceChargeIncluded;
	this._BCHDTL_BounceCharges = BCHDTL_BounceCharges;
	this._BCHDTL_CreatedByUserID = BCHDTL_CreatedByUserID;
	this._BCHDTL_CreatedDateTime = BCHDTL_CreatedDateTime;
	this._BCHDTL_UpdatedByUserID = BCHDTL_UpdatedByUserID;
	this._BCHDTL_UpdatedDateTime = BCHDTL_UpdatedDateTime;
	this._BCHDTL_RowStatus = BCHDTL_RowStatus;
	this._BCHDTL_RowVersion = BCHDTL_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public int BCHDTL_ChequeID
		{
			 get { return _BCHDTL_ChequeID; }
			 set { _BCHDTL_ChequeID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public int BCHDTL_ApplicationId
		{
			 get { return _BCHDTL_ApplicationId; }
			 set { _BCHDTL_ApplicationId = value; }
		}

    public int BCHDTL_CorporateId 
    {
        get { return _BCHDTL_CorporateId; }
        set { _BCHDTL_CorporateId = value; }
    }
	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_OldChequeID
		{
			 get { return _BCHDTL_OldChequeID; }
			 set { _BCHDTL_OldChequeID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_BankId
		{
			 get { return _BCHDTL_BankId; }
			 set { _BCHDTL_BankId = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_Remarks
		{
			 get { return _BCHDTL_Remarks; }
			 set { _BCHDTL_Remarks = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public string BCHDTL_ChequeNo
		{
			 get { return _BCHDTL_ChequeNo; }
			 set { _BCHDTL_ChequeNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_ChequeDate
		{
			 get { return _BCHDTL_ChequeDate; }
			 set { _BCHDTL_ChequeDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public int BCHDTL_ChequeAmount
		{
			 get { return _BCHDTL_ChequeAmount; }
			 set { _BCHDTL_ChequeAmount = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public int BCHDTL_LotID
		{
			 get { return _BCHDTL_LotID; }
			 set { _BCHDTL_LotID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_RealizedDate
		{
			 get { return _BCHDTL_RealizedDate; }
			 set { _BCHDTL_RealizedDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_Status
		{
			 get { return _BCHDTL_Status; }
			 set { _BCHDTL_Status = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_CENcode
		{
			 get { return _BCHDTL_CENcode; }
			 set { _BCHDTL_CENcode = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_DishonourDate
		{
			 get { return _BCHDTL_DishonourDate; }
			 set { _BCHDTL_DishonourDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_DisReason
		{
			 get { return _BCHDTL_DisReason; }
			 set { _BCHDTL_DisReason = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_IsBounceChargeIncluded
		{
			 get { return _BCHDTL_IsBounceChargeIncluded; }
			 set { _BCHDTL_IsBounceChargeIncluded = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal BCHDTL_BounceCharges
		{
			 get { return _BCHDTL_BounceCharges; }
			 set { _BCHDTL_BounceCharges = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_CreatedByUserID
		{
			 get { return _BCHDTL_CreatedByUserID; }
			 set { _BCHDTL_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_CreatedDateTime
		{
			 get { return _BCHDTL_CreatedDateTime; }
			 set { _BCHDTL_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_UpdatedByUserID
		{
			 get { return _BCHDTL_UpdatedByUserID; }
			 set { _BCHDTL_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCHDTL_UpdatedDateTime
		{
			 get { return _BCHDTL_UpdatedDateTime; }
			 set { _BCHDTL_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_RowStatus
		{
			 get { return _BCHDTL_RowStatus; }
			 set { _BCHDTL_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long BCHDTL_RowVersion
		{
			 get { return _BCHDTL_RowVersion; }
			 set { _BCHDTL_RowVersion = value; }
		}

	}

public class 	ACCBounceChequeDTLTRNList
{
    #region "Variables Declaration"

    private int _BCHDTL_ChequeID;
    private string _CHQDTL_Receiptno;
    private string _Recipt_No;
    private string _Recipt_Date;
    private string _BCHDTL_ChequeNo;
    private string _BCHDTL_ChequeDate;
    private string _Amount;
    private string _Application_No;
    private string _Customer_ID;
    private string _Customer_Name;
    private string _Customer_Address;
    private string _Area;
    private string _Status;
    private int _BCHDTL_BankID;
    private string _BankName;
    private string _MicrNo;
    private int _BCHDTL_IsBounceChargeIncluded;
    private decimal _BCHDTL_BounceCharges;
    private int _Count;
    #endregion

    public ACCBounceChequeDTLTRNList() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public ACCBounceChequeDTLTRNList(int BCHDTL_ChequeID, string CHQDTL_Receiptno, string Recipt_No, string Recipt_Date, string BCHDTL_ChequeNo, string BCHDTL_ChequeDate, string Amount, string Application_No, string Customer_ID, string Customer_Name, string Customer_Address, string Area, string Status,int BCHDTL_BankID, string BankName, string MicrNo, int BCHDTL_IsBounceChargeIncluded, decimal BCHDTL_BounceCharges, int Count)
	{
	this._BCHDTL_ChequeID = BCHDTL_ChequeID;
	this._CHQDTL_Receiptno = CHQDTL_Receiptno;
	this._Recipt_No = Recipt_No;
	this._Recipt_Date = Recipt_Date;
	this._BCHDTL_ChequeNo = BCHDTL_ChequeNo;
	this._BCHDTL_ChequeDate = BCHDTL_ChequeDate;
	this._Amount = Amount;
	this._Application_No = Application_No;
	this._Customer_ID = Customer_ID;
	this._Customer_Name = Customer_Name;
	this._Customer_Address = Customer_Address;
	this._Area = Area;
	this._Status = Status;
    this._BCHDTL_BankID = BCHDTL_BankID;
	this._BankName = BankName;
	this._MicrNo = MicrNo;
    this._BCHDTL_IsBounceChargeIncluded = BCHDTL_IsBounceChargeIncluded;
    this._BCHDTL_BounceCharges = BCHDTL_BounceCharges;
	this._Count= Count;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCHDTL_ChequeID
	{
		get { return _BCHDTL_ChequeID; }
		set { _BCHDTL_ChequeID = value; }
	}
    public string CHQDTL_Receiptno
    {
        get { return _CHQDTL_Receiptno; }
        set { _CHQDTL_Receiptno = value; }
    }
    public string Recipt_No
    {
        get { return _Recipt_No; }
        set { _Recipt_No = value; }
    }
    public string Recipt_Date
    {
        get { return _Recipt_Date; }
        set { _Recipt_Date = value; }
    }
    public string BCHDTL_ChequeNo
    {
        get { return _BCHDTL_ChequeNo; }
        set { _BCHDTL_ChequeNo = value; }
    }
    public string BCHDTL_ChequeDate
    {
        get { return _BCHDTL_ChequeDate; }
        set { _BCHDTL_ChequeDate = value; }
    }
    public string Amount
    {
        get { return _Amount; }
        set { _Amount = value; }
    }
    public string Application_No
    {
        get { return _Application_No; }
        set { _Application_No = value; }
    }
    public string Customer_ID
    {
        get { return _Customer_ID; }
        set { _Customer_ID = value; }
    }
    public string Customer_Name
    {
        get { return _Customer_Name; }
        set { _Customer_Name = value; }
    }
    public string Customer_Address
    {
        get { return _Customer_Address; }
        set { Customer_Address = value; }
    }
    public string Area
    {
        get { return _Area; }
        set { _Area = value; }
    }
    public string Status
    {
        get { return _Status; }
        set { _Status = value; }
    }
    public int BCHDTL_BankID
    {
        get { return _BCHDTL_BankID; }
        set { _BCHDTL_BankID = value; }
    }
    
    public string BankName
    {
        get { return _BankName; }
        set { _BankName = value; }
    }
    public string MicrNo
    {
        get { return _MicrNo; }
        set { _MicrNo = value; }
    }

    public int BCHDTL_IsBounceChargeIncluded
    {
        get { return _BCHDTL_IsBounceChargeIncluded; }
        set { _BCHDTL_IsBounceChargeIncluded = value; }
    }

    public decimal BCHDTL_BounceCharges
    {
        get { return _BCHDTL_BounceCharges; }
        set { _BCHDTL_BounceCharges = value; }
    }

    public int Count
    {
        get { return _Count; }
        set { _Count = value; }
    }
}


public class ACCBounceChequeDTLTRNMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public ACCBounceChequeDTLTRNMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public ACCBounceChequeDTLTRNMsg(int RetVal, string RetStr)
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
