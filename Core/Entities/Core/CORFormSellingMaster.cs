//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORFormSellingMaster.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORFormSellingMasterService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that da   tabase rows.
/// </remarks>
	
	public class 	CORFormSellingMaster
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _FSMMST_Code;
		private int _FSMMST_FromNo;
		private int _FSMMST_ToNo;
		private int _FSMMST_IssuedToCenter;
		private string _FSMMST_IssuedDate;
		private int _FSMMST_CreatedByUserID;
		private string _FSMMST_CreatedDateTime;
		private int _FSMMST_UpdatedByUserID;
		private string _FSMMST_UpdatedDateTime;
		private int _FSMMST_RowStatus;
		private long _FSMMST_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for CORFormSellingMaster class.
	/// </summary>
	public CORFormSellingMaster() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CORFormSellingMaster(int FSMMST_Code,int FSMMST_FromNo,int FSMMST_ToNo,int FSMMST_IssuedToCenter,string FSMMST_IssuedDate,int FSMMST_CreatedByUserID,string FSMMST_CreatedDateTime,int FSMMST_UpdatedByUserID,string FSMMST_UpdatedDateTime,int FSMMST_RowStatus,long FSMMST_RowVersion)
	{
	this._FSMMST_Code = FSMMST_Code;
	this._FSMMST_FromNo = FSMMST_FromNo;
	this._FSMMST_ToNo = FSMMST_ToNo;
	this._FSMMST_IssuedToCenter = FSMMST_IssuedToCenter;
	this._FSMMST_IssuedDate = FSMMST_IssuedDate;
	this._FSMMST_CreatedByUserID = FSMMST_CreatedByUserID;
	this._FSMMST_CreatedDateTime = FSMMST_CreatedDateTime;
	this._FSMMST_UpdatedByUserID = FSMMST_UpdatedByUserID;
	this._FSMMST_UpdatedDateTime = FSMMST_UpdatedDateTime;
	this._FSMMST_RowStatus = FSMMST_RowStatus;
	this._FSMMST_RowVersion = FSMMST_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_Code
		{
			 get { return _FSMMST_Code; }
			 set { _FSMMST_Code = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_FromNo
		{
			 get { return _FSMMST_FromNo; }
			 set { _FSMMST_FromNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_ToNo
		{
			 get { return _FSMMST_ToNo; }
			 set { _FSMMST_ToNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_IssuedToCenter
		{
			 get { return _FSMMST_IssuedToCenter; }
			 set { _FSMMST_IssuedToCenter = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string FSMMST_IssuedDate
		{
			 get { return _FSMMST_IssuedDate; }
			 set { _FSMMST_IssuedDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_CreatedByUserID
		{
			 get { return _FSMMST_CreatedByUserID; }
			 set { _FSMMST_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string FSMMST_CreatedDateTime
		{
			 get { return _FSMMST_CreatedDateTime; }
			 set { _FSMMST_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_UpdatedByUserID
		{
			 get { return _FSMMST_UpdatedByUserID; }
			 set { _FSMMST_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string FSMMST_UpdatedDateTime
		{
			 get { return _FSMMST_UpdatedDateTime; }
			 set { _FSMMST_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int FSMMST_RowStatus
		{
			 get { return _FSMMST_RowStatus; }
			 set { _FSMMST_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long FSMMST_RowVersion
		{
			 get { return _FSMMST_RowVersion; }
			 set { _FSMMST_RowVersion = value; }
		}

	}

public class 	CORFormSellingMasterList
{
//Write this List class yourself.
//This List Class can not be generate using this utility.
//--VBS
    #region "Variables Declaration"
    private int _FSMMST_Code;
    private int _FSMMST_FromNo;
    private int _FSMMST_ToNo;
    private string _CENMST_Name;
    private string _FSMMST_IssuedDate;
    private int _FormCount;
    #endregion
    public CORFormSellingMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
    public CORFormSellingMasterList(int FSMMST_Code, int FSMMST_FromNo, int FSMMST_ToNo,string CENMST_Name, string FSMMST_IssuedDate, int FormCount)
        {

            this._FSMMST_Code = FSMMST_Code;
            this._FSMMST_FromNo = FSMMST_FromNo;
            this._FSMMST_ToNo = FSMMST_ToNo;
            this._CENMST_Name = CENMST_Name;
            this._FSMMST_IssuedDate = FSMMST_IssuedDate;
            this. _FormCount = FormCount;



        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int FSMMST_Code
        {
            get { return _FSMMST_Code; }
            set { _FSMMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int FSMMST_FromNo
        {
            get { return _FSMMST_FromNo; }
            set { _FSMMST_FromNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int FSMMST_ToNo
        {
            get { return _FSMMST_ToNo; }
            set { _FSMMST_ToNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }

        public string FSMMST_IssuedDate
        {
            get { return _FSMMST_IssuedDate; }
            set { _FSMMST_IssuedDate = value; }
        }  
        


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int FormCount
        {
            get { return _FormCount; }

        }
    }
}


public class CORFormSellingMasterMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CORFormSellingMasterMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CORFormSellingMasterMsg(int RetVal, string RetStr)
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

