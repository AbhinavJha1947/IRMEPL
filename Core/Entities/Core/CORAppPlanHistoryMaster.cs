//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORAppPlanHistoryMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORAppPlanHistoryMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORAppPlanHistoryMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _PLAHST_Id;
		private decimal _PLAHST_ApplicationId;
		private int _PLAHST_OldPlanId;
		private int _PLAHST_NewPlanId;
		private string _PLAHST_Date;
		private string _PLAHST_Remarks;
		private int _PLAHST_CreatedByUserID;
		private string _PLAHST_CreatedDateTime;
	#endregion

	/// <summary>
	/// Default constructor for CORAppPlanHistoryMaster class.
	/// </summary>
	public CORAppPlanHistoryMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CORAppPlanHistoryMaster(int PLAHST_Id,decimal PLAHST_ApplicationId,int PLAHST_OldPlanId,int PLAHST_NewPlanId,string PLAHST_Date,string PLAHST_Remarks,int PLAHST_CreatedByUserID,string PLAHST_CreatedDateTime)
	{
	this._PLAHST_Id = PLAHST_Id;
	this._PLAHST_ApplicationId = PLAHST_ApplicationId;
	this._PLAHST_OldPlanId = PLAHST_OldPlanId;
	this._PLAHST_NewPlanId = PLAHST_NewPlanId;
	this._PLAHST_Date = PLAHST_Date;
	this._PLAHST_Remarks = PLAHST_Remarks;
	this._PLAHST_CreatedByUserID = PLAHST_CreatedByUserID;
	this._PLAHST_CreatedDateTime = PLAHST_CreatedDateTime;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int PLAHST_Id
		{
			 get { return _PLAHST_Id; }
			 set { _PLAHST_Id = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal PLAHST_ApplicationId
		{
			 get { return _PLAHST_ApplicationId; }
			 set { _PLAHST_ApplicationId = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int PLAHST_OldPlanId
		{
			 get { return _PLAHST_OldPlanId; }
			 set { _PLAHST_OldPlanId = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int PLAHST_NewPlanId
		{
			 get { return _PLAHST_NewPlanId; }
			 set { _PLAHST_NewPlanId = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string PLAHST_Date
		{
			 get { return _PLAHST_Date; }
			 set { _PLAHST_Date = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string PLAHST_Remarks
		{
			 get { return _PLAHST_Remarks; }
			 set { _PLAHST_Remarks = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int PLAHST_CreatedByUserID
		{
			 get { return _PLAHST_CreatedByUserID; }
			 set { _PLAHST_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string PLAHST_CreatedDateTime
		{
			 get { return _PLAHST_CreatedDateTime; }
			 set { _PLAHST_CreatedDateTime = value; }
		}

	}

public class 	CORAppPlanHistoryMasterList
{
 /// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private string _ApplicationNo;
		private string _PLAHST_Date;
		private string _APPMST_CustomerID;
		private string _CustomerName;
		private string _OldPlanName;
        private string _NewPlanName;
        private string _PLAHST_Remarks;
        private string _APPMST_Plan;
        private string _APPMST_WOType;
        private int _APPMST_WOTYPEID;
        private int _NewPlanName1;
        private int _APPMST_PlanId;
        private int _Count;
		
	#endregion

	/// <summary>
	/// Default constructor for CORApplicationMaster class.
	/// </summary>
	public CORAppPlanHistoryMasterList() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public CORAppPlanHistoryMasterList(string ApplicationNo, string CustomerName, string OldPlanName, string NewPlanName, string PLAHST_Date, string PLAHST_Remarks, int Count)
	{
	    this._ApplicationNo = ApplicationNo;
        this._CustomerName = CustomerName;
        this._OldPlanName = OldPlanName;
        this._NewPlanName = NewPlanName;
	    this._PLAHST_Date = PLAHST_Date;
	    this._PLAHST_Remarks = PLAHST_Remarks;
	    this._Count = Count;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string ApplicationNo
		{
			 get { return _ApplicationNo; }
			 set { _ApplicationNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string PLAHST_Date
		{
			 get { return _PLAHST_Date; }
			 set { _PLAHST_Date = value; }
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
	public string OldPlanName
		{
			 get { return _OldPlanName; }
			 set { _OldPlanName = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string NewPlanName
		{
			 get { return _NewPlanName; }
			 set { _NewPlanName = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string PLAHST_Remarks
		{
			 get { return _PLAHST_Remarks; }
			 set { _PLAHST_Remarks = value; }
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


public class CORAppPlanHistoryMasterMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CORAppPlanHistoryMasterMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CORAppPlanHistoryMasterMsg(int RetVal, string RetStr)
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
