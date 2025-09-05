//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CorDesignationMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CorDesignationMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CorDesignationMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _DESI_ID;
		private string _DESI_Name;
        
	#endregion

	/// <summary>
	/// Default constructor for CorDesignationMaster class.
	/// </summary>
	public CorDesignationMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CorDesignationMaster(int DESI_ID,string DESI_Name)
	{
	this._DESI_ID = DESI_ID;
	this._DESI_Name = DESI_Name;
   
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int DESI_ID
		{
			 get { return _DESI_ID; }
			 set { _DESI_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string DESI_Name
		{
			 get { return _DESI_Name; }
			 set { _DESI_Name = value; }
		}
   

	}

public class 	CorDesignationMasterList
{

    #region "Variables Declaration"
    private int _DESI_ID;
    private string _DESI_Name;
    private int _Count;
    #endregion
    public CorDesignationMasterList() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public CorDesignationMasterList(int DESI_ID, string DESI_Name, int Count)
	{
	this._DESI_ID = DESI_ID;
	this._DESI_Name = DESI_Name;
    this._Count = Count;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int DESI_ID
		{
			 get { return _DESI_ID; }
			 set { _DESI_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string DESI_Name
		{
			 get { return _DESI_Name; }
			 set { _DESI_Name = value; }
		}
    public int Count
    {
        get { return _Count; }
    }
}

public class CorDesignationMasterMsg
{
    // Class level Local Variables Declaration.
    #region "Variables Declaration"
    private int _RetVal;
    private string _RetStr;
    #endregion

    /// <summary>
    //Overloaded default constructor for the Salutation class. 
    /// </summary>
    public CorDesignationMasterMsg() { }
    /// <summary>
    //Overloaded constructor for the Salutation class. 
    /// </summary>
    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
    /// <param name="saltnmName">Name of the Salutation.</param>
    public CorDesignationMasterMsg(int RetVal, string RetStr)
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
