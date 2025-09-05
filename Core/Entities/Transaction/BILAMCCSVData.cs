//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	BILAMCCSVData.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	BILAMCCSVDataService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	BILAMCCSVData
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _AMCCSV_ID;
        private int _AMCCSV_CenCode;
		private string _AMCCSV_ApplicationNo;
		private string _AMCCSV_Date;
		private int _AMCCSV_MeterNo;
		private string _AMCCSV_Regulator;
		private decimal _AMCCSV_Pressure;
		private int _AMCCSV_ExtraKitchen;
		private int _AMCCSV_ExtraBathroom;
		private int _AMCCSV_Leakage;
		private int _AMCCSV_SingleVentilation;
		private string _AMCCSV_HouseClosed;
		private string _AMCCSV_DCForceDC;
		private string _AMCCSV_DMLT;
		private string _AMCCSV_PHC;
		private string _AMCCSV_UnSafeConn;
		private int _AMCCSV_MeterStop;
		private int _AMCCSV_ChangeRubTube;
		private int _AMCCSV_ChangeNeoRubCap;
		private int _AMCCSV_ChangeRubTubeClamp;
		private int _AMCCSV_ChangeMainISOValve;
		private int _AMCCSV_ChangeAdapter;
		private int _AMCCSV_ChangeTF;
		private int _AMCCSV_ChangeGIElbow;
		private int _AMCCSV_ChangeHexNipple;
		private int _AMCCSV_ChangeGIClamp;
		private int _AMCCSV_ChangeORingAdapter;
		private int _AMCCSV_ChangeORingUnion;
		private int _AMCCSV_ChangeScrew;
		private int _AMCCSV_ChangeRollPlug;
		private int _AMCCSV_ChangeRCCGuardNail;
		private int _AMCCSV_ChangeGIUnion;
		private int _AMCCSV_ChangePECoupler;
		private int _AMCCSV_LeakageInMainISOValve;
		private int _AMCCSV_LeakageInRegOrRegAdapter;
		private int _AMCCSV_LeakageInUnion;
		private int _AMCCSV_LeakageInMeterOrMeterAdapter;
		private int _AMCCSV_LeakageInTF;
		private int _AMCCSV_LeakageInGIFitting;
		private int _AMCCSV_LeakageInRubTube;
		private string _AMCCSV_Remarks;
        private int _AMCCSV_CreatedByUserID;
	#endregion

	/// <summary>
	/// Default constructor for BILAMCCSVData class.
	/// </summary>
	public BILAMCCSVData() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public BILAMCCSVData(int AMCCSV_ID, int AMCCSV_CenCode, string AMCCSV_ApplicationNo, string AMCCSV_Date, int AMCCSV_MeterNo, string AMCCSV_Regulator, decimal AMCCSV_Pressure, int AMCCSV_ExtraKitchen, int AMCCSV_ExtraBathroom, int AMCCSV_Leakage, int AMCCSV_SingleVentilation, string AMCCSV_HouseClosed, string AMCCSV_DCForceDC, string AMCCSV_DMLT, string AMCCSV_PHC, string AMCCSV_UnSafeConn, int AMCCSV_MeterStop, int AMCCSV_ChangeRubTube, int AMCCSV_ChangeNeoRubCap, int AMCCSV_ChangeRubTubeClamp, int AMCCSV_ChangeMainISOValve, int AMCCSV_ChangeAdapter, int AMCCSV_ChangeTF, int AMCCSV_ChangeGIElbow, int AMCCSV_ChangeHexNipple, int AMCCSV_ChangeGIClamp, int AMCCSV_ChangeORingAdapter, int AMCCSV_ChangeORingUnion, int AMCCSV_ChangeScrew, int AMCCSV_ChangeRollPlug, int AMCCSV_ChangeRCCGuardNail, int AMCCSV_ChangeGIUnion, int AMCCSV_ChangePECoupler, int AMCCSV_LeakageInMainISOValve, int AMCCSV_LeakageInRegOrRegAdapter, int AMCCSV_LeakageInUnion, int AMCCSV_LeakageInMeterOrMeterAdapter, int AMCCSV_LeakageInTF, int AMCCSV_LeakageInGIFitting, int AMCCSV_LeakageInRubTube, string AMCCSV_Remarks, int AMCCSV_CreatedByUserID)
	{
	this._AMCCSV_ID = AMCCSV_ID;
    this._AMCCSV_CenCode = AMCCSV_CenCode;
	this._AMCCSV_ApplicationNo = AMCCSV_ApplicationNo;
	this._AMCCSV_Date = AMCCSV_Date;
	this._AMCCSV_MeterNo = AMCCSV_MeterNo;
	this._AMCCSV_Regulator = AMCCSV_Regulator;
	this._AMCCSV_Pressure = AMCCSV_Pressure;
	this._AMCCSV_ExtraKitchen = AMCCSV_ExtraKitchen;
	this._AMCCSV_ExtraBathroom = AMCCSV_ExtraBathroom;
	this._AMCCSV_Leakage = AMCCSV_Leakage;
	this._AMCCSV_SingleVentilation = AMCCSV_SingleVentilation;
	this._AMCCSV_HouseClosed = AMCCSV_HouseClosed;
	this._AMCCSV_DCForceDC = AMCCSV_DCForceDC;
	this._AMCCSV_DMLT = AMCCSV_DMLT;
	this._AMCCSV_PHC = AMCCSV_PHC;
	this._AMCCSV_UnSafeConn = AMCCSV_UnSafeConn;
	this._AMCCSV_MeterStop = AMCCSV_MeterStop;
	this._AMCCSV_ChangeRubTube = AMCCSV_ChangeRubTube;
	this._AMCCSV_ChangeNeoRubCap = AMCCSV_ChangeNeoRubCap;
	this._AMCCSV_ChangeRubTubeClamp = AMCCSV_ChangeRubTubeClamp;
	this._AMCCSV_ChangeMainISOValve = AMCCSV_ChangeMainISOValve;
	this._AMCCSV_ChangeAdapter = AMCCSV_ChangeAdapter;
	this._AMCCSV_ChangeTF = AMCCSV_ChangeTF;
	this._AMCCSV_ChangeGIElbow = AMCCSV_ChangeGIElbow;
	this._AMCCSV_ChangeHexNipple = AMCCSV_ChangeHexNipple;
	this._AMCCSV_ChangeGIClamp = AMCCSV_ChangeGIClamp;
	this._AMCCSV_ChangeORingAdapter = AMCCSV_ChangeORingAdapter;
	this._AMCCSV_ChangeORingUnion = AMCCSV_ChangeORingUnion;
	this._AMCCSV_ChangeScrew = AMCCSV_ChangeScrew;
	this._AMCCSV_ChangeRollPlug = AMCCSV_ChangeRollPlug;
	this._AMCCSV_ChangeRCCGuardNail = AMCCSV_ChangeRCCGuardNail;
	this._AMCCSV_ChangeGIUnion = AMCCSV_ChangeGIUnion;
	this._AMCCSV_ChangePECoupler = AMCCSV_ChangePECoupler;
	this._AMCCSV_LeakageInMainISOValve = AMCCSV_LeakageInMainISOValve;
	this._AMCCSV_LeakageInRegOrRegAdapter = AMCCSV_LeakageInRegOrRegAdapter;
	this._AMCCSV_LeakageInUnion = AMCCSV_LeakageInUnion;
	this._AMCCSV_LeakageInMeterOrMeterAdapter = AMCCSV_LeakageInMeterOrMeterAdapter;
	this._AMCCSV_LeakageInTF = AMCCSV_LeakageInTF;
	this._AMCCSV_LeakageInGIFitting = AMCCSV_LeakageInGIFitting;
	this._AMCCSV_LeakageInRubTube = AMCCSV_LeakageInRubTube;
	this._AMCCSV_Remarks = AMCCSV_Remarks;
    this._AMCCSV_CreatedByUserID = AMCCSV_CreatedByUserID;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ID
		{
			 get { return _AMCCSV_ID; }
			 set { _AMCCSV_ID = value; }
		}

        
            /// <summary>
	//Write Column Description here. 
	/// </summary>
    public int AMCCSV_CenCode
		{
            get { return _AMCCSV_CenCode; }
            set { _AMCCSV_CenCode = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public string AMCCSV_ApplicationNo
		{
			 get { return _AMCCSV_ApplicationNo; }
			 set { _AMCCSV_ApplicationNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_Date
		{
			 get { return _AMCCSV_Date; }
			 set { _AMCCSV_Date = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_MeterNo
		{
			 get { return _AMCCSV_MeterNo; }
			 set { _AMCCSV_MeterNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_Regulator
		{
			 get { return _AMCCSV_Regulator; }
			 set { _AMCCSV_Regulator = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal AMCCSV_Pressure
		{
			 get { return _AMCCSV_Pressure; }
			 set { _AMCCSV_Pressure = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ExtraKitchen
		{
			 get { return _AMCCSV_ExtraKitchen; }
			 set { _AMCCSV_ExtraKitchen = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ExtraBathroom
		{
			 get { return _AMCCSV_ExtraBathroom; }
			 set { _AMCCSV_ExtraBathroom = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_Leakage
		{
			 get { return _AMCCSV_Leakage; }
			 set { _AMCCSV_Leakage = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_SingleVentilation
		{
			 get { return _AMCCSV_SingleVentilation; }
			 set { _AMCCSV_SingleVentilation = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_HouseClosed
		{
			 get { return _AMCCSV_HouseClosed; }
			 set { _AMCCSV_HouseClosed = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_DCForceDC
		{
			 get { return _AMCCSV_DCForceDC; }
			 set { _AMCCSV_DCForceDC = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_DMLT
		{
			 get { return _AMCCSV_DMLT; }
			 set { _AMCCSV_DMLT = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_PHC
		{
			 get { return _AMCCSV_PHC; }
			 set { _AMCCSV_PHC = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_UnSafeConn
		{
			 get { return _AMCCSV_UnSafeConn; }
			 set { _AMCCSV_UnSafeConn = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_MeterStop
		{
			 get { return _AMCCSV_MeterStop; }
			 set { _AMCCSV_MeterStop = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeRubTube
		{
			 get { return _AMCCSV_ChangeRubTube; }
			 set { _AMCCSV_ChangeRubTube = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeNeoRubCap
		{
			 get { return _AMCCSV_ChangeNeoRubCap; }
			 set { _AMCCSV_ChangeNeoRubCap = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeRubTubeClamp
		{
			 get { return _AMCCSV_ChangeRubTubeClamp; }
			 set { _AMCCSV_ChangeRubTubeClamp = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeMainISOValve
		{
			 get { return _AMCCSV_ChangeMainISOValve; }
			 set { _AMCCSV_ChangeMainISOValve = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeAdapter
		{
			 get { return _AMCCSV_ChangeAdapter; }
			 set { _AMCCSV_ChangeAdapter = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeTF
		{
			 get { return _AMCCSV_ChangeTF; }
			 set { _AMCCSV_ChangeTF = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeGIElbow
		{
			 get { return _AMCCSV_ChangeGIElbow; }
			 set { _AMCCSV_ChangeGIElbow = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeHexNipple
		{
			 get { return _AMCCSV_ChangeHexNipple; }
			 set { _AMCCSV_ChangeHexNipple = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeGIClamp
		{
			 get { return _AMCCSV_ChangeGIClamp; }
			 set { _AMCCSV_ChangeGIClamp = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeORingAdapter
		{
			 get { return _AMCCSV_ChangeORingAdapter; }
			 set { _AMCCSV_ChangeORingAdapter = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeORingUnion
		{
			 get { return _AMCCSV_ChangeORingUnion; }
			 set { _AMCCSV_ChangeORingUnion = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeScrew
		{
			 get { return _AMCCSV_ChangeScrew; }
			 set { _AMCCSV_ChangeScrew = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeRollPlug
		{
			 get { return _AMCCSV_ChangeRollPlug; }
			 set { _AMCCSV_ChangeRollPlug = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeRCCGuardNail
		{
			 get { return _AMCCSV_ChangeRCCGuardNail; }
			 set { _AMCCSV_ChangeRCCGuardNail = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangeGIUnion
		{
			 get { return _AMCCSV_ChangeGIUnion; }
			 set { _AMCCSV_ChangeGIUnion = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_ChangePECoupler
		{
			 get { return _AMCCSV_ChangePECoupler; }
			 set { _AMCCSV_ChangePECoupler = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInMainISOValve
		{
			 get { return _AMCCSV_LeakageInMainISOValve; }
			 set { _AMCCSV_LeakageInMainISOValve = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInRegOrRegAdapter
		{
			 get { return _AMCCSV_LeakageInRegOrRegAdapter; }
			 set { _AMCCSV_LeakageInRegOrRegAdapter = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInUnion
		{
			 get { return _AMCCSV_LeakageInUnion; }
			 set { _AMCCSV_LeakageInUnion = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInMeterOrMeterAdapter
		{
			 get { return _AMCCSV_LeakageInMeterOrMeterAdapter; }
			 set { _AMCCSV_LeakageInMeterOrMeterAdapter = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInTF
		{
			 get { return _AMCCSV_LeakageInTF; }
			 set { _AMCCSV_LeakageInTF = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInGIFitting
		{
			 get { return _AMCCSV_LeakageInGIFitting; }
			 set { _AMCCSV_LeakageInGIFitting = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int AMCCSV_LeakageInRubTube
		{
			 get { return _AMCCSV_LeakageInRubTube; }
			 set { _AMCCSV_LeakageInRubTube = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string AMCCSV_Remarks
		{
			 get { return _AMCCSV_Remarks; }
			 set { _AMCCSV_Remarks = value; }
		}

        /// <summary>
	//Write Column Description here. 
	/// </summary>
    public int AMCCSV_CreatedByUserID
		{
            get { return _AMCCSV_CreatedByUserID; }
            set { _AMCCSV_CreatedByUserID = value; }
		}
	}

public class 	BILAMCCSVDataList
{
//Write this List class yourself.
//This List Class can not be generate using this utility.
//--VBS
}


public class BILAMCCSVDataMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public BILAMCCSVDataMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public BILAMCCSVDataMsg(int RetVal, string RetStr)
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
