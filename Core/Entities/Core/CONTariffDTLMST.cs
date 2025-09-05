//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CONTariffDTLMST.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CONTariffDTLMSTService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CONTariffDTLMST
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _CTDMST_ID;
		private int _CTDMST_TariffID;
		private int _CTDMST_MaterialID;
		private decimal _CTDMST_Rate;
	#endregion

	/// <summary>
	/// Default constructor for CONTariffDTLMST class.
	/// </summary>
	public CONTariffDTLMST() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CONTariffDTLMST(int CTDMST_ID,int CTDMST_TariffID,int CTDMST_MaterialID,decimal CTDMST_Rate)
	{
	this._CTDMST_ID = CTDMST_ID;
	this._CTDMST_TariffID = CTDMST_TariffID;
	this._CTDMST_MaterialID = CTDMST_MaterialID;
	this._CTDMST_Rate = CTDMST_Rate;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CTDMST_ID
		{
			 get { return _CTDMST_ID; }
			 set { _CTDMST_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CTDMST_TariffID
		{
			 get { return _CTDMST_TariffID; }
			 set { _CTDMST_TariffID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int CTDMST_MaterialID
		{
			 get { return _CTDMST_MaterialID; }
			 set { _CTDMST_MaterialID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal CTDMST_Rate
		{
			 get { return _CTDMST_Rate; }
			 set { _CTDMST_Rate = value; }
		}

	}

public class 	CONTariffDTLMSTList
{
//Write this List class yourself.
//This List Class can not be generate using this utility.
//--VBS
}


public class CONTariffDTLMSTMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CONTariffDTLMSTMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CONTariffDTLMSTMsg(int RetVal, string RetStr)
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
