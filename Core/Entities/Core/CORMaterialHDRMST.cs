//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
/// <summary>
/// Class that holds information about a 	CORMaterialHDRMST.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	CORMaterialHDRMSTService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	CORMaterialHDRMST
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _MATMST_MaterialID;
		private int _MATMST_MaterialType;
		private string _MATMST_Shortname;
		private string _MATMST_Description;
		private int _MATMST_CreatedByUserID;
		private string _MATMST_CreatedDateTime;
		private int _MATMST_UpdatedByUserID;
		private string _MATMST_UpdatedDateTime;
		private int _MATMST_RowStatus;
		private long _MATMST_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for CORMaterialHDRMST class.
	/// </summary>
	public CORMaterialHDRMST() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public CORMaterialHDRMST(int MATMST_MaterialID,int MATMST_MaterialType,string MATMST_Shortname,string MATMST_Description,int MATMST_CreatedByUserID,string MATMST_CreatedDateTime,int MATMST_UpdatedByUserID,string MATMST_UpdatedDateTime,int MATMST_RowStatus,long MATMST_RowVersion)
	{
	this._MATMST_MaterialID = MATMST_MaterialID;
	this._MATMST_MaterialType = MATMST_MaterialType;
	this._MATMST_Shortname = MATMST_Shortname;
	this._MATMST_Description = MATMST_Description;
	this._MATMST_CreatedByUserID = MATMST_CreatedByUserID;
	this._MATMST_CreatedDateTime = MATMST_CreatedDateTime;
	this._MATMST_UpdatedByUserID = MATMST_UpdatedByUserID;
	this._MATMST_UpdatedDateTime = MATMST_UpdatedDateTime;
	this._MATMST_RowStatus = MATMST_RowStatus;
	this._MATMST_RowVersion = MATMST_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int MATMST_MaterialID
		{
			 get { return _MATMST_MaterialID; }
			 set { _MATMST_MaterialID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int MATMST_MaterialType
		{
			 get { return _MATMST_MaterialType; }
			 set { _MATMST_MaterialType = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string MATMST_Shortname
		{
			 get { return _MATMST_Shortname; }
			 set { _MATMST_Shortname = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string MATMST_Description
		{
			 get { return _MATMST_Description; }
			 set { _MATMST_Description = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int MATMST_CreatedByUserID
		{
			 get { return _MATMST_CreatedByUserID; }
			 set { _MATMST_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string MATMST_CreatedDateTime
		{
			 get { return _MATMST_CreatedDateTime; }
			 set { _MATMST_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int MATMST_UpdatedByUserID
		{
			 get { return _MATMST_UpdatedByUserID; }
			 set { _MATMST_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string MATMST_UpdatedDateTime
		{
			 get { return _MATMST_UpdatedDateTime; }
			 set { _MATMST_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int MATMST_RowStatus
		{
			 get { return _MATMST_RowStatus; }
			 set { _MATMST_RowStatus = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long MATMST_RowVersion
		{
			 get { return _MATMST_RowVersion; }
			 set { _MATMST_RowVersion = value; }
		}

	}

public class 	CORMaterialHDRMSTList
{
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
            private int _MATMST_MaterialID;
            private string _MATMST_Shortname;
            private string _MATMST_Description;
            private string _MATMST_MaterialType;
            private string _TAX;
            private string _MATMST_RowStatus;
            private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORMaterialHDRMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORMaterialHDRMSTList(int MATMST_MaterialID, string MATMST_Shortname, string MATMST_Description,string MATMST_MaterialType, string TAX, string MATMST_RowStatus, int Count)
        {
            this._MATMST_MaterialID = MATMST_MaterialID;
            this._MATMST_Shortname = MATMST_Shortname;
            this._MATMST_Description = MATMST_Description;
            this._MATMST_MaterialType = MATMST_MaterialType;
            this._TAX = TAX;
            this._MATMST_RowStatus = MATMST_RowStatus;
            this._Count = Count;
            
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MATMST_MaterialID
        {
            get { return _MATMST_MaterialID; }
            set { _MATMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string MATMST_Shortname
        {
            get { return _MATMST_Shortname; }
            set { _MATMST_Shortname = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string MATMST_Description
        {
            get { return _MATMST_Description; }
            set { _MATMST_Description = value; }
        }
        public string MATMST_MaterialType
        {
            get { return _MATMST_MaterialType; }
            set { _MATMST_MaterialType = value; }
        }
    
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TAX
        {
            get { return _TAX; }
            set { _TAX = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string MATMST_RowStatus
        {
            get { return _MATMST_RowStatus; }
            set { _MATMST_RowStatus = value; }
        }
        public int Count
        {
            get { return _Count; }
            
        }
}


public class CORMaterialHDRMSTMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public CORMaterialHDRMSTMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public CORMaterialHDRMSTMsg(int RetVal, string RetStr)
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
