//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	PRDMeterUpdateTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	PRDMeterUpdateTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	PRDMeterUpdateTRN
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _METNOU_ID;
		private decimal _METNOU_ApplicationId;
		private decimal _METNOU_OldMeterNo;
		private decimal _METNOU_NewMeterNo;
		private int _METNOU_UpdatedByUserID;
		private string _METNOU_UpdatedDateTime;
		private long _METNOU_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for PRDMeterUpdateTRN class.
	/// </summary>
	public PRDMeterUpdateTRN() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
	public PRDMeterUpdateTRN(int METNOU_ID,decimal METNOU_ApplicationId,decimal METNOU_OldMeterNo,decimal METNOU_NewMeterNo,int METNOU_UpdatedByUserID,string METNOU_UpdatedDateTime,long METNOU_RowVersion)
	{
	this._METNOU_ID = METNOU_ID;
	this._METNOU_ApplicationId = METNOU_ApplicationId;
	this._METNOU_OldMeterNo = METNOU_OldMeterNo;
	this._METNOU_NewMeterNo = METNOU_NewMeterNo;
	this._METNOU_UpdatedByUserID = METNOU_UpdatedByUserID;
	this._METNOU_UpdatedDateTime = METNOU_UpdatedDateTime;
	this._METNOU_RowVersion = METNOU_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int METNOU_ID
		{
			 get { return _METNOU_ID; }
			 set { _METNOU_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal METNOU_ApplicationId
		{
			 get { return _METNOU_ApplicationId; }
			 set { _METNOU_ApplicationId = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal METNOU_OldMeterNo
		{
			 get { return _METNOU_OldMeterNo; }
			 set { _METNOU_OldMeterNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal METNOU_NewMeterNo
		{
			 get { return _METNOU_NewMeterNo; }
			 set { _METNOU_NewMeterNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int METNOU_UpdatedByUserID
		{
			 get { return _METNOU_UpdatedByUserID; }
			 set { _METNOU_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string METNOU_UpdatedDateTime
		{
			 get { return _METNOU_UpdatedDateTime; }
			 set { _METNOU_UpdatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long METNOU_RowVersion
		{
			 get { return _METNOU_RowVersion; }
			 set { _METNOU_RowVersion = value; }
		}

	}

public class 	PRDMeterUpdateTRNList
{
      /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private Int32 _METNOU_ID;
        private string _ApplicationNo;
        private string _CustomerName;
        private string _APPMST_Address;
        private string _APPMST_Landmark;
        private string _AREMST_Name;
        private string _CustomerType;
        private string _PlanName;
        private Int64 _METNOU_OldMeterNo;
        private Int64 _METNOU_NewMeterNo;
        private string _METNOU_UpdatedDateTime;
        private string _METNOU_UpdatedByUserID;
        private Int32 _Count;
              
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDMeterUpdateTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDMeterUpdateTRNList(int METNOU_ID, string ApplicationNo, string CustomerName, string APPMST_Address, string APPMST_Landmark, string AREMST_Name, string CustomerType, string PlanName, Int64 METNOU_OldMeterNo, Int64 METNOU_NewMeterNo, string METNOU_UpdatedDateTime, string METNOU_UpdatedByUserID, int Count)
        {
            this._METNOU_ID = METNOU_ID;
            this._ApplicationNo = ApplicationNo;
            this._CustomerName = CustomerName;
            this._APPMST_Address = APPMST_Address;
            this._APPMST_Landmark = APPMST_Landmark;
            this._AREMST_Name = AREMST_Name;
            this._CustomerType = CustomerType;
            this._PlanName = PlanName;
            this._METNOU_OldMeterNo = METNOU_OldMeterNo;
            this._METNOU_NewMeterNo = METNOU_NewMeterNo;
            this._METNOU_UpdatedDateTime = METNOU_UpdatedDateTime;
            this._METNOU_UpdatedByUserID = METNOU_UpdatedByUserID;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METNOU_ID
        {
            get { return _METNOU_ID; }
            set { _METNOU_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public string APPMST_Address
        {
            get { return _APPMST_Address; }
            set { _APPMST_Address = value; }
        }

        public string APPMST_Landmark
        {
            get { return _APPMST_Landmark; }
            set { _APPMST_Landmark = value; }
        }

        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }
        }

        public string CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }

        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
        }

        public Int64 METNOU_OldMeterNo
        {
            get { return _METNOU_OldMeterNo; }
            set { _METNOU_OldMeterNo = value; }
        }

        public Int64 METNOU_NewMeterNo
        {
            get { return _METNOU_NewMeterNo; }
            set { _METNOU_NewMeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METNOU_UpdatedDateTime
        {
            get { return _METNOU_UpdatedDateTime; }
            set { _METNOU_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public string METNOU_UpdatedByUserID
        {
            get { return _METNOU_UpdatedByUserID; }
            set { _METNOU_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public int Count
        {
            get { return _Count; }

        }
}


public class PRDMeterUpdateTRNMsg
{
	// Class level Local Variables Declaration.
	#region "Variables Declaration"
private int _RetVal;
private string _RetStr;
	#endregion

	/// <summary>
	//Overloaded default constructor for the Salutation class. 
	/// </summary>
public PRDMeterUpdateTRNMsg(){ }
	/// <summary>
	//Overloaded constructor for the Salutation class. 
	/// </summary>
	/// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	/// <param name="saltnmName">Name of the Salutation.</param>
public PRDMeterUpdateTRNMsg(int RetVal, string RetStr)
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
