//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORCompanyMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORCompanyMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORCompanyMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _CMPMST_CompanyCode;
		private string _CMPMST_CompanyName;
		private string _CMPMST_RegAddress;
		private string _CMPMST_WebSite;
		private int _CMPMST_BusinessType;
		private string _CMPMST_GSTNoDT;
		private string _CMPMST_CSTNoDT;
		private string _CMPMST_TINNoDT;
		private string _CMPMST_VATNoDT;
		private string _CMPMST_ExRegNo;
		private int _CMPMST_CreatedByUserID;
		private string _CMPMST_CreatedDateTime;
		private int _CMPMST_UpdatedByUserID;
		private string _CMPMST_UpdatedDateTime;
		private int _CMPMST_RowStatus;
		private long _CMPMST_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for CORCompanyMaster class.
	/// </summary>
	public CORCompanyMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CORCompanyMaster(int CMPMST_CompanyCode,string CMPMST_CompanyName,string CMPMST_RegAddress,string CMPMST_WebSite,int CMPMST_BusinessType,string CMPMST_GSTNoDT,string CMPMST_CSTNoDT,string CMPMST_TINNoDT,string CMPMST_VATNoDT,string CMPMST_ExRegNo,int CMPMST_CreatedByUserID,string CMPMST_CreatedDateTime,int CMPMST_UpdatedByUserID,string CMPMST_UpdatedDateTime,int CMPMST_RowStatus,long CMPMST_RowVersion)
	{
	this._CMPMST_CompanyCode = CMPMST_CompanyCode;
	this._CMPMST_CompanyName = CMPMST_CompanyName;
	this._CMPMST_RegAddress = CMPMST_RegAddress;
	this._CMPMST_WebSite = CMPMST_WebSite;
	this._CMPMST_BusinessType = CMPMST_BusinessType;
	this._CMPMST_GSTNoDT = CMPMST_GSTNoDT;
	this._CMPMST_CSTNoDT = CMPMST_CSTNoDT;
	this._CMPMST_TINNoDT = CMPMST_TINNoDT;
	this._CMPMST_VATNoDT = CMPMST_VATNoDT;
	this._CMPMST_ExRegNo = CMPMST_ExRegNo;
	this._CMPMST_CreatedByUserID = CMPMST_CreatedByUserID;
	this._CMPMST_CreatedDateTime = CMPMST_CreatedDateTime;
	this._CMPMST_UpdatedByUserID = CMPMST_UpdatedByUserID;
	this._CMPMST_UpdatedDateTime = CMPMST_UpdatedDateTime;
	this._CMPMST_RowStatus = CMPMST_RowStatus;
	this._CMPMST_RowVersion = CMPMST_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CMPMST_CompanyCode
		{
			 get { return _CMPMST_CompanyCode; }
			 set { _CMPMST_CompanyCode = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_CompanyName
		{
			 get { return _CMPMST_CompanyName; }
			 set { _CMPMST_CompanyName = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_RegAddress
		{
			 get { return _CMPMST_RegAddress; }
			 set { _CMPMST_RegAddress = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_WebSite
		{
			 get { return _CMPMST_WebSite; }
			 set { _CMPMST_WebSite = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CMPMST_BusinessType
		{
			 get { return _CMPMST_BusinessType; }
			 set { _CMPMST_BusinessType = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_GSTNoDT
		{
			 get { return _CMPMST_GSTNoDT; }
			 set { _CMPMST_GSTNoDT = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_CSTNoDT
		{
			 get { return _CMPMST_CSTNoDT; }
			 set { _CMPMST_CSTNoDT = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_TINNoDT
		{
			 get { return _CMPMST_TINNoDT; }
			 set { _CMPMST_TINNoDT = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_VATNoDT
		{
			 get { return _CMPMST_VATNoDT; }
			 set { _CMPMST_VATNoDT = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_ExRegNo
		{
			 get { return _CMPMST_ExRegNo; }
			 set { _CMPMST_ExRegNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CMPMST_CreatedByUserID
		{
			 get { return _CMPMST_CreatedByUserID; }
			 set { _CMPMST_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_CreatedDateTime
		{
			 get { return _CMPMST_CreatedDateTime; }
			 set { _CMPMST_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CMPMST_UpdatedByUserID
		{
			 get { return _CMPMST_UpdatedByUserID; }
			 set { _CMPMST_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string CMPMST_UpdatedDateTime
		{
			 get { return _CMPMST_UpdatedDateTime; }
			 set { _CMPMST_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CMPMST_RowStatus
		{
			 get { return _CMPMST_RowStatus; }
			 set { _CMPMST_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long CMPMST_RowVersion
		{
			 get { return _CMPMST_RowVersion; }
			 set { _CMPMST_RowVersion = value; }
		}

	}

public class 	CORCompanyMasterList
{
//Write this List class yourself.
//This List Class can not be generate using this utility.
//--VBS
}


public class CORCompanyMasterMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CORCompanyMasterMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CORCompanyMasterMsg(int RetVal, string RetStr)
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
