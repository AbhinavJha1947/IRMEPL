//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORAppExtraConnDtlMST.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORAppExtraConnDtlMSTService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORAppExtraConnDtlMST
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private decimal _AEDMST_ID;
		private decimal _AEDMST_AppID;
		private int _AEDMST_ConnType;
		private int _AEDMST_NoofConn;
	#endregion

	/// <summary>
	/// Default constructor for CORAppExtraConnDtlMST class.
	/// </summary>
	public CORAppExtraConnDtlMST() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CORAppExtraConnDtlMST(decimal AEDMST_ID,decimal AEDMST_AppID,int AEDMST_ConnType,int AEDMST_NoofConn)
	{
	this._AEDMST_ID = AEDMST_ID;
	this._AEDMST_AppID = AEDMST_AppID;
	this._AEDMST_ConnType = AEDMST_ConnType;
	this._AEDMST_NoofConn = AEDMST_NoofConn;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal AEDMST_ID
		{
			 get { return _AEDMST_ID; }
			 set { _AEDMST_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal AEDMST_AppID
		{
			 get { return _AEDMST_AppID; }
			 set { _AEDMST_AppID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AEDMST_ConnType
		{
			 get { return _AEDMST_ConnType; }
			 set { _AEDMST_ConnType = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AEDMST_NoofConn
		{
			 get { return _AEDMST_NoofConn; }
			 set { _AEDMST_NoofConn = value; }
		}

	}

public class 	CORAppExtraConnDtlMSTList
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
    private int _AEDMST_ConnTypeID;
    private int _AEDMST_NoofConn;
    private string _AEDMST_ConnType;
	#endregion
    /// <summary>
	/// Default constructor for CORAppExtraConnDtlMST class.
	/// </summary>
	public CORAppExtraConnDtlMSTList() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public CORAppExtraConnDtlMSTList(int AEDMST_ConnTypeID, string AEDMST_ConnType, int AEDMST_NoofConn)
    {
        this._AEDMST_ConnTypeID = AEDMST_ConnTypeID;
        this._AEDMST_ConnType = AEDMST_ConnType;
        this._AEDMST_NoofConn = AEDMST_NoofConn;
    }
    public int AEDMST_ConnTypeID
    {
        get { return _AEDMST_ConnTypeID; }
        set { _AEDMST_ConnTypeID = value; }
    }

    
    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string AEDMST_ConnType
    {
        get { return _AEDMST_ConnType; }
        set { _AEDMST_ConnType = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int AEDMST_NoofConn
    {
        get { return _AEDMST_NoofConn; }
        set { _AEDMST_NoofConn = value; }
    }
//Write this List class yourself.
//This List Class can not be generate using this utility.
//--VBS
}


public class CORAppExtraConnDtlMSTMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CORAppExtraConnDtlMSTMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CORAppExtraConnDtlMSTMsg(int RetVal, string RetStr)
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
