//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	ACCFormSellAmountCollect.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	ACCFormSellAmountCollectService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	ACCFormSellAmountCollect
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _FSAC_Srno;
		private string _FSAC_Date;
		private int _FSAC_NoofForm;
		private decimal _FSAC_Amount;
		private int _FSAC_CenCode;
		private int _FSAC_Createdby;
		private string _FSAC_CreatedDate;
		private int _FSAC_Updatedby;
		private string _FSAC_UpdatedDate;
	#endregion

	/// <summary>
	/// Default constructor for ACCFormSellAmountCollect class.
	/// </summary>
	public ACCFormSellAmountCollect() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public ACCFormSellAmountCollect(int FSAC_Srno,string FSAC_Date,int FSAC_NoofForm,decimal FSAC_Amount,int FSAC_CenCode,int FSAC_Createdby,string FSAC_CreatedDate,int FSAC_Updatedby,string FSAC_UpdatedDate)
	{
	this._FSAC_Srno = FSAC_Srno;
	this._FSAC_Date = FSAC_Date;
	this._FSAC_NoofForm = FSAC_NoofForm;
	this._FSAC_Amount = FSAC_Amount;
	this._FSAC_CenCode = FSAC_CenCode;
	this._FSAC_Createdby = FSAC_Createdby;
	this._FSAC_CreatedDate = FSAC_CreatedDate;
	this._FSAC_Updatedby = FSAC_Updatedby;
	this._FSAC_UpdatedDate = FSAC_UpdatedDate;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSAC_Srno
		{
			 get { return _FSAC_Srno; }
			 set { _FSAC_Srno = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string FSAC_Date
		{
			 get { return _FSAC_Date; }
			 set { _FSAC_Date = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSAC_NoofForm
		{
			 get { return _FSAC_NoofForm; }
			 set { _FSAC_NoofForm = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal FSAC_Amount
		{
			 get { return _FSAC_Amount; }
			 set { _FSAC_Amount = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSAC_CenCode
		{
			 get { return _FSAC_CenCode; }
			 set { _FSAC_CenCode = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSAC_Createdby
		{
			 get { return _FSAC_Createdby; }
			 set { _FSAC_Createdby = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string FSAC_CreatedDate
		{
			 get { return _FSAC_CreatedDate; }
			 set { _FSAC_CreatedDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSAC_Updatedby
		{
			 get { return _FSAC_Updatedby; }
			 set { _FSAC_Updatedby = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string FSAC_UpdatedDate
		{
			 get { return _FSAC_UpdatedDate; }
			 set { _FSAC_UpdatedDate = value; }
		}

	}

public class 	ACCFormSellAmountCollectList
{
    //Write this List class yourself.
    //This List Class can not be generate using this utility.
    //--VBS

    #region "Variables Declaration"
    private int _FSAC_Srno;
    private string _FSAC_Date;
    private int _FSAC_NoofForm;
    private decimal _FSAC_Amount;
    private int _Count;
    #endregion

    public ACCFormSellAmountCollectList()
    {
    }
    public ACCFormSellAmountCollectList(int FSAC_Srno,string FSAC_Date,int FSAC_NoofForm,decimal FSAC_Amount, int Count)
	{
	this._FSAC_Srno = FSAC_Srno;
	this._FSAC_Date = FSAC_Date;
	this._FSAC_NoofForm = FSAC_NoofForm;
	this._FSAC_Amount = FSAC_Amount;
    this._Count = Count;
	}
    public int FSAC_Srno
    {
        get { return _FSAC_Srno; }
        set { _FSAC_Srno = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public string FSAC_Date
    {
        get { return _FSAC_Date; }
        set { _FSAC_Date = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public int FSAC_NoofForm
    {
        get { return _FSAC_NoofForm; }
        set { _FSAC_NoofForm = value; }
    }

    /// <summary>
    //Write Column Description here. 
    /// </summary>
    public decimal FSAC_Amount
    {
        get { return _FSAC_Amount; }
        set { _FSAC_Amount = value; }
    }
    public int Count
    {
        get { return _Count; }
        set { _Count = value; }
    }

}


public class ACCFormSellAmountCollectMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public ACCFormSellAmountCollectMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public ACCFormSellAmountCollectMsg(int RetVal, string RetStr)
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
