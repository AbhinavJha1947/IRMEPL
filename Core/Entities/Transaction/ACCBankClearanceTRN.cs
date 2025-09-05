//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	ACCBankClearanceTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	ACCBankClearanceTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	ACCBankClearanceTRN
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _BCLTRN_ID;
		private string _BCLTRN_LotNo;
		private string _BCLTRN_DepositDate;
		private int _BCLTRN_BankID;
		private int _BCLTRN_CENCode;
		private int _BCLTRN_CreatedByUserID;
		private string _BCLTRN_CreatedDateTime;
		private int _BCLTRN_UpdatedByUserID;
		private string _BCLTRN_UpdatedDateTime;
		private int _BCLTRN_RowStatus;
        private string _BCLTRN_CMSCode;
        private int _BCLTRN_LotQty;
        private decimal _BCLTRN_LotAmt;
		private long _BCLTRN_RowVersion;
        private string _ChequeIDs;
        private string _BounceChequeIDs;
        private int _BCLTRN_PayMode;
	#endregion

	/// <summary>
	/// Default constructor for ACCBankClearanceTRN class.
	/// </summary>
	public ACCBankClearanceTRN() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public ACCBankClearanceTRN(int BCLTRN_ID, string BCLTRN_LotNo, string BCLTRN_DepositDate, int BCLTRN_BankID, int BCLTRN_CENCode, int BCLTRN_CreatedByUserID, string BCLTRN_CreatedDateTime, int BCLTRN_UpdatedByUserID, string BCLTRN_UpdatedDateTime, int BCLTRN_RowStatus, string BCLTRN_CMSCode, int BCLTRN_LotQty, decimal BCLTRN_LotAmt, long BCLTRN_RowVersion, string ChequeIDs, string BounceChequeIDs, int BCLTRN_PayMode)
	{
	this._BCLTRN_ID = BCLTRN_ID;
	this._BCLTRN_LotNo = BCLTRN_LotNo;
	this._BCLTRN_DepositDate = BCLTRN_DepositDate;
	this._BCLTRN_BankID = BCLTRN_BankID;
	this._BCLTRN_CENCode = BCLTRN_CENCode;
	this._BCLTRN_CreatedByUserID = BCLTRN_CreatedByUserID;
	this._BCLTRN_CreatedDateTime = BCLTRN_CreatedDateTime;
	this._BCLTRN_UpdatedByUserID = BCLTRN_UpdatedByUserID;
	this._BCLTRN_UpdatedDateTime = BCLTRN_UpdatedDateTime;
	this._BCLTRN_RowStatus = BCLTRN_RowStatus;
    this._BCLTRN_CMSCode = BCLTRN_CMSCode;
    this._BCLTRN_LotQty = BCLTRN_LotQty;
    this._BCLTRN_LotAmt = BCLTRN_LotAmt;
	this._BCLTRN_RowVersion = BCLTRN_RowVersion;
    this._ChequeIDs = ChequeIDs;
    this._BounceChequeIDs = BounceChequeIDs;
    this._BCLTRN_PayMode = BCLTRN_PayMode;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCLTRN_ID
		{
			 get { return _BCLTRN_ID; }
			 set { _BCLTRN_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCLTRN_LotNo
		{
			 get { return _BCLTRN_LotNo; }
			 set { _BCLTRN_LotNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCLTRN_DepositDate
		{
			 get { return _BCLTRN_DepositDate; }
			 set { _BCLTRN_DepositDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCLTRN_BankID
		{
			 get { return _BCLTRN_BankID; }
			 set { _BCLTRN_BankID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCLTRN_CENCode
		{
			 get { return _BCLTRN_CENCode; }
			 set { _BCLTRN_CENCode = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCLTRN_CreatedByUserID
		{
			 get { return _BCLTRN_CreatedByUserID; }
			 set { _BCLTRN_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCLTRN_CreatedDateTime
		{
			 get { return _BCLTRN_CreatedDateTime; }
			 set { _BCLTRN_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCLTRN_UpdatedByUserID
		{
			 get { return _BCLTRN_UpdatedByUserID; }
			 set { _BCLTRN_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string BCLTRN_UpdatedDateTime
		{
			 get { return _BCLTRN_UpdatedDateTime; }
			 set { _BCLTRN_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int BCLTRN_RowStatus
		{
			 get { return _BCLTRN_RowStatus; }
			 set { _BCLTRN_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    /// 

    public string BCLTRN_CMSCode
    {
        get { return _BCLTRN_CMSCode; }
        set { _BCLTRN_CMSCode = value; }
    }

    public int BCLTRN_LotQty
    {
        get { return _BCLTRN_LotQty; }
        set { _BCLTRN_LotQty = value; }
    }

    public decimal BCLTRN_LotAmt
    {
        get { return _BCLTRN_LotAmt; }
        set { _BCLTRN_LotAmt = value; }
    }
        
	public long BCLTRN_RowVersion
		{
			 get { return _BCLTRN_RowVersion; }
			 set { _BCLTRN_RowVersion = value; }
		}

    public string ChequeIDs
    {
        get { return _ChequeIDs; }
        set { _ChequeIDs = value; }
    }

    public string BounceChequeIDs
    {
        get { return _BounceChequeIDs; }
        set { _BounceChequeIDs = value; }
    }

    public int BCLTRN_PayMode
    {
        get { return _BCLTRN_PayMode; }
        set { _BCLTRN_PayMode = value; }
    }
}

public class 	ACCBankClearanceTRNList
{
#region "Variables Declaration"
    private int _BCLTRN_ID;
    private string _BCLTRN_LotNo;
    private string _BCLTRN_DepositDate;
    private string _BCLTRN_BankID;
    private string _BANMST_BankName;
    private string _BCLTRN_CMSCode;
    private int _BCLTRN_LotQty;
    private decimal _BCLTRN_LotAmt;
    private int _Count;
    #endregion
 
    public ACCBankClearanceTRNList() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public ACCBankClearanceTRNList(int BCLTRN_ID, string BCLTRN_LotNo, string BCLTRN_DepositDate, string BANMST_BankName, string BCLTRN_CMSCode, int BCLTRN_LotQty, decimal BCLTRN_LotAmt, int Count)
    {
        this._BCLTRN_ID = BCLTRN_ID;
        this._BCLTRN_LotNo = BCLTRN_LotNo;
        this._BCLTRN_DepositDate = BCLTRN_DepositDate;
        this._BANMST_BankName = BANMST_BankName;
        this._BCLTRN_CMSCode = BCLTRN_CMSCode;
        this._BCLTRN_LotQty = BCLTRN_LotQty;
        this._BCLTRN_LotAmt = BCLTRN_LotAmt;
        this._Count = Count;
    }


    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_ID
    {
        get { return _BCLTRN_ID; }
        set { _BCLTRN_ID = value; }
    }
    public string BCLTRN_LotNo
    {
        get { return _BCLTRN_LotNo; }
        set { _BCLTRN_LotNo = value; }
    }
    public string BCLTRN_DepositDate
    {
        get { return _BCLTRN_DepositDate; }
        set { _BCLTRN_DepositDate = value; }
    }
   
    public string BANMST_BankName
    {
        get { return _BANMST_BankName; }
        set { _BANMST_BankName = value; }
    }

    public string BCLTRN_CMSCode
    {
        get { return _BCLTRN_CMSCode; }
        set { _BCLTRN_CMSCode = value; }
    }

    public int BCLTRN_LotQty
    {
        get { return _BCLTRN_LotQty; }
        set { _BCLTRN_LotQty = value; }
    }

    public decimal BCLTRN_LotAmt
    {
        get { return _BCLTRN_LotAmt; }
        set { _BCLTRN_LotAmt = value; }
    }

    public int Count
    {
        get { return _Count; }
        set { _Count = value; }
    }
}


public class ACCBankClearanceTRNMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public ACCBankClearanceTRNMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public ACCBankClearanceTRNMsg(int RetVal, string RetStr)
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

public class ACCBankClearanceTRNForCSVUpload
{
    /// Class level Local Variables Declaration.
    #region "Variables Declaration"
    private int _BCLTRN_ID;
    private string _BCLTRN_LotNo;
    private string _BCLTRN_DepositDate;
    private int _BCLTRN_BankID;
    private int _BCLTRN_CENCode;
    private int _BCLTRN_CreatedByUserID;
    private string _BCLTRN_CreatedDateTime;
    private int _BCLTRN_UpdatedByUserID;
    private string _BCLTRN_UpdatedDateTime;
    private int _BCLTRN_RowStatus;
    private string _BCLTRN_CMSCode;
    private int _BCLTRN_LotQty;
    private decimal _BCLTRN_LotAmt;
    private long _BCLTRN_RowVersion;
    private string _ChequeIDs;
    private string _BounceChequeIDs;
    private int _BCLTRN_PayMode;
    #endregion

    /// <summary>
    /// Default constructor for ACCBankClearanceTRN class.
    /// </summary>
    public ACCBankClearanceTRNForCSVUpload() { }

    /// <summary>
    /// Overloaded constructor for the Branch class.
    /// </summary>
    public ACCBankClearanceTRNForCSVUpload(int BCLTRN_ID, string BCLTRN_LotNo, string BCLTRN_DepositDate, int BCLTRN_BankID, int BCLTRN_CENCode, int BCLTRN_CreatedByUserID, string BCLTRN_CreatedDateTime, int BCLTRN_UpdatedByUserID, string BCLTRN_UpdatedDateTime, int BCLTRN_RowStatus, string BCLTRN_CMSCode, int BCLTRN_LotQty, decimal BCLTRN_LotAmt, long BCLTRN_RowVersion, string ChequeIDs, string BounceChequeIDs, int BCLTRN_PayMode)
    {
        this._BCLTRN_ID = BCLTRN_ID;
        this._BCLTRN_LotNo = BCLTRN_LotNo;
        this._BCLTRN_DepositDate = BCLTRN_DepositDate;
        this._BCLTRN_BankID = BCLTRN_BankID;
        this._BCLTRN_CENCode = BCLTRN_CENCode;
        this._BCLTRN_CreatedByUserID = BCLTRN_CreatedByUserID;
        this._BCLTRN_CreatedDateTime = BCLTRN_CreatedDateTime;
        this._BCLTRN_UpdatedByUserID = BCLTRN_UpdatedByUserID;
        this._BCLTRN_UpdatedDateTime = BCLTRN_UpdatedDateTime;
        this._BCLTRN_RowStatus = BCLTRN_RowStatus;
        this._BCLTRN_CMSCode = BCLTRN_CMSCode;
        this._BCLTRN_LotQty = BCLTRN_LotQty;
        this._BCLTRN_LotAmt = BCLTRN_LotAmt;
        this._BCLTRN_RowVersion = BCLTRN_RowVersion;
        this._ChequeIDs = ChequeIDs;
        this._BounceChequeIDs = BounceChequeIDs;
        this._BCLTRN_PayMode = BCLTRN_PayMode;
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_ID
    {
        get { return _BCLTRN_ID; }
        set { _BCLTRN_ID = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string BCLTRN_LotNo
    {
        get { return _BCLTRN_LotNo; }
        set { _BCLTRN_LotNo = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string BCLTRN_DepositDate
    {
        get { return _BCLTRN_DepositDate; }
        set { _BCLTRN_DepositDate = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_BankID
    {
        get { return _BCLTRN_BankID; }
        set { _BCLTRN_BankID = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_CENCode
    {
        get { return _BCLTRN_CENCode; }
        set { _BCLTRN_CENCode = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_CreatedByUserID
    {
        get { return _BCLTRN_CreatedByUserID; }
        set { _BCLTRN_CreatedByUserID = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string BCLTRN_CreatedDateTime
    {
        get { return _BCLTRN_CreatedDateTime; }
        set { _BCLTRN_CreatedDateTime = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_UpdatedByUserID
    {
        get { return _BCLTRN_UpdatedByUserID; }
        set { _BCLTRN_UpdatedByUserID = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string BCLTRN_UpdatedDateTime
    {
        get { return _BCLTRN_UpdatedDateTime; }
        set { _BCLTRN_UpdatedDateTime = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int BCLTRN_RowStatus
    {
        get { return _BCLTRN_RowStatus; }
        set { _BCLTRN_RowStatus = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    /// 

    public string BCLTRN_CMSCode
    {
        get { return _BCLTRN_CMSCode; }
        set { _BCLTRN_CMSCode = value; }
    }

    public int BCLTRN_LotQty
    {
        get { return _BCLTRN_LotQty; }
        set { _BCLTRN_LotQty = value; }
    }

    public decimal BCLTRN_LotAmt
    {
        get { return _BCLTRN_LotAmt; }
        set { _BCLTRN_LotAmt = value; }
    }

    public long BCLTRN_RowVersion
    {
        get { return _BCLTRN_RowVersion; }
        set { _BCLTRN_RowVersion = value; }
    }

    public string ChequeIDs
    {
        get { return _ChequeIDs; }
        set { _ChequeIDs = value; }
    }

    public string BounceChequeIDs
    {
        get { return _BounceChequeIDs; }
        set { _BounceChequeIDs = value; }
    }

    public int BCLTRN_PayMode
    {
        get { return _BCLTRN_PayMode; }
        set { _BCLTRN_PayMode = value; }
    }
}
}
