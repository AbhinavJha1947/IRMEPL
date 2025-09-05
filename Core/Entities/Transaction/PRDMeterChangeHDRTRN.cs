//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	PRDMeterChangeHDRTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	PRDMeterChangeHDRTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
	
	public class 	PRDMeterChangeHDRTRN
	{
	/// Class level Local Variables Declaration.
	#region "Variables Declaration"
		private int _METCHG_ID;
		private int _METCHG_ApplicationId;
        private string _APPMST_CustomerID;
		private Int64 _METCHG_NewMeterNo;
		private decimal _METCHG_InitialReading;
		private string _METCHG_ReplaceDate;
		private int _METCHG_CreatedByUserID;
		private string _METCHG_CreatedDateTime;
		private int _METCHG_UpdatedByUserID;
        private string _METCHG_UpdatedDateTime;
        private string _METCHG_RequestNo;       
		private long _METCHG_RowVersion;
	#endregion

	/// <summary>
	/// Default constructor for PRDMeterChangeHDRTRN class.
	/// </summary>
	public PRDMeterChangeHDRTRN() { }

	/// <summary>
	/// Overloaded constructor for the Branch class.
	/// </summary>
    public PRDMeterChangeHDRTRN(int METCHG_ID, int METCHG_ApplicationId, string APPMST_CustomerID, Int64 METCHG_NewMeterNo, decimal METCHG_InitialReading, string METCHG_ReplaceDate, int METCHG_CreatedByUserID, string METCHG_CreatedDateTime, int METCHG_UpdatedByUserID, string METCHG_UpdatedDateTime, string METCHG_RequestNo, long METCHG_RowVersion)
	{
	this._METCHG_ID = METCHG_ID;
	this._METCHG_ApplicationId = METCHG_ApplicationId;
    this._APPMST_CustomerID = APPMST_CustomerID;
	this._METCHG_NewMeterNo = METCHG_NewMeterNo;
	this._METCHG_InitialReading = METCHG_InitialReading;
	this._METCHG_ReplaceDate = METCHG_ReplaceDate;
	this._METCHG_CreatedByUserID = METCHG_CreatedByUserID;
	this._METCHG_CreatedDateTime = METCHG_CreatedDateTime;
	this._METCHG_UpdatedByUserID = METCHG_UpdatedByUserID;
    this._METCHG_UpdatedDateTime = METCHG_UpdatedDateTime;
    this._METCHG_RequestNo = METCHG_RequestNo;  
	this._METCHG_RowVersion = METCHG_RowVersion;
	}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int METCHG_ID
		{
			 get { return _METCHG_ID; }
			 set { _METCHG_ID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int METCHG_ApplicationId
		{
			 get { return _METCHG_ApplicationId; }
			 set { _METCHG_ApplicationId = value; }
		}

        
    /// <summary>
	//Write Column Description here. 
	/// </summary>
    public string APPMST_CustomerID
		{
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
		}


	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public Int64 METCHG_NewMeterNo
		{
			 get { return _METCHG_NewMeterNo; }
			 set { _METCHG_NewMeterNo = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public decimal METCHG_InitialReading
		{
			 get { return _METCHG_InitialReading; }
			 set { _METCHG_InitialReading = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string METCHG_ReplaceDate
		{
			 get { return _METCHG_ReplaceDate; }
			 set { _METCHG_ReplaceDate = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int METCHG_CreatedByUserID
		{
			 get { return _METCHG_CreatedByUserID; }
			 set { _METCHG_CreatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public string METCHG_CreatedDateTime
		{
			 get { return _METCHG_CreatedDateTime; }
			 set { _METCHG_CreatedDateTime = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public int METCHG_UpdatedByUserID
		{
			 get { return _METCHG_UpdatedByUserID; }
			 set { _METCHG_UpdatedByUserID = value; }
		}

	/// <summary>
	//Write Column Description here. 
	/// </summary>
    public string METCHG_UpdatedDateTime
		{
            get { return _METCHG_UpdatedDateTime; }
            set { _METCHG_UpdatedDateTime = value; }
		}
    public string METCHG_RequestNo
		{
            get { return _METCHG_RequestNo; }
            set { _METCHG_RequestNo = value; }
		}        
  
	/// <summary>
	//Write Column Description here. 
	/// </summary>
	public long METCHG_RowVersion
		{
			 get { return _METCHG_RowVersion; }
			 set { _METCHG_RowVersion = value; }
		}

	}

    public class 	PRDMeterChangeHDRTRNList
    {
    /// Class level Local Variables Declaration.
            #region "Variables Declaration"
            private Int32 _METCHG_ID;
            private string _CustomerID;
            private string _CustomerName;
            private string _APPMST_Address;
            private string _APPMST_Landmark;
            private string _AREMST_Name;
            private string _CustomerType;
            private string _PlanName;
            private Int64   _METCHG_NewMeterNo;
            private decimal _METCHG_InitialReading;
            private string _METCHG_ReplaceDate;
            private string _METCHG_RequestNo;
            private Int64 _METCHD_OldMeterNo;
            private decimal _METCHD_OldMeterReading;
            private string _METCHG_UpdatedByUserID;
            private Int32 _Count;
                  
            #endregion

            /// <summary>
            /// Default constructor for branchmst class.
            /// </summary>
            public PRDMeterChangeHDRTRNList() { }

            /// <summary>
            /// Overloaded constructor for the Analyzer class.
            /// </summary>
            /// <param name=""></param>
            public PRDMeterChangeHDRTRNList(int METCHG_ID, string CustomerID, string CustomerName, string APPMST_Address, string APPMST_Landmark, string AREMST_Name, string CustomerType, string PlanName, Int64 METCHG_NewMeterNo, decimal METCHG_InitialReading, string METCHG_ReplaceDate, string METCHG_RequestNo, Int64 METCHD_OldMeterNo, decimal METCHD_OldMeterReading, string METCHG_UpdatedByUserID, int Count)
            {
                this._METCHG_ID = METCHG_ID;
                this._CustomerID = CustomerID;
                this._CustomerName = CustomerName;
                this._APPMST_Address = APPMST_Address;
                this._APPMST_Landmark = APPMST_Landmark;
                this._AREMST_Name = AREMST_Name;
                this._CustomerType = CustomerType;
                this._PlanName = PlanName;
                this._METCHG_NewMeterNo = METCHG_NewMeterNo;
                this._METCHG_InitialReading = METCHG_InitialReading;
                this._METCHG_ReplaceDate = METCHG_ReplaceDate;
                this._METCHG_RequestNo = METCHG_RequestNo;
                this._METCHD_OldMeterNo = METCHD_OldMeterNo;
                this._METCHD_OldMeterReading = METCHD_OldMeterReading;
                this._METCHG_UpdatedByUserID = METCHG_UpdatedByUserID;
                this._Count = Count;
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int METCHG_ID
            {
                get { return _METCHG_ID; }
                set { _METCHG_ID = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string CustomerID
            {
                get { return _CustomerID; }
                set { _CustomerID = value; }
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

            public Int64 METCHG_NewMeterNo
            {
                get { return _METCHG_NewMeterNo; }
                set { _METCHG_NewMeterNo = value; }
            }

            public decimal METCHG_InitialReading
            {
                get { return _METCHG_InitialReading; }
                set { _METCHG_InitialReading = value; }
            }
        
            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string METCHG_ReplaceDate
            {
                get { return _METCHG_ReplaceDate; }
                set { _METCHG_ReplaceDate = value; }
            }
            public string METCHG_RequestNo
            {
                get { return _METCHG_RequestNo; }
                set { _METCHG_RequestNo = value; }
            }

            public Int64 METCHD_OldMeterNo
            {
                get { return _METCHD_OldMeterNo; }
                set { _METCHD_OldMeterNo = value; }
            }

            public decimal METCHD_OldMeterReading
            {
                get { return _METCHD_OldMeterReading; }
                set { _METCHD_OldMeterReading = value; }
            }
            public string METCHG_UpdatedByUserID
            {
                get { return _METCHG_UpdatedByUserID; }
                set { _METCHG_UpdatedByUserID = value; }
            }
            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int Count
            {
                get { return _Count; }

            }
    }

    public class PRDMeterChangeHDRTRNMsg
    {
	        // Class level Local Variables Declaration.
	        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
	        #endregion

	        /// <summary>
	        //Overloaded default constructor for the Salutation class. 
	        /// </summary>
        public PRDMeterChangeHDRTRNMsg(){ }
	        /// <summary>
	        //Overloaded constructor for the Salutation class. 
	        /// </summary>
	        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDMeterChangeHDRTRNMsg(int RetVal, string RetStr)
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
    
    public class PRDMeterChangeDTLTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _METCHD_ID;
        private int _METCHD_METCHGID;
        private Int64 _METCHD_OldMeterNo;
        private decimal _METCHD_OldMeterReading;
        private int _METCHG_ApplicationId;
        private string _METCHG_ReplaceDate;
        #endregion

        /// <summary>
        /// Default constructor for PRDMeterChangeDTLTRN class.
        /// </summary>
        public PRDMeterChangeDTLTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDMeterChangeDTLTRN(int METCHD_ID, int METCHD_METCHGID, Int64 METCHD_OldMeterNo, decimal METCHD_OldMeterReading, int METCHG_ApplicationId, string METCHG_ReplaceDate)
        {
            this._METCHD_ID = METCHD_ID;
            this._METCHD_METCHGID = METCHD_METCHGID;
            this._METCHD_OldMeterNo = METCHD_OldMeterNo;
            this._METCHD_OldMeterReading = METCHD_OldMeterReading;
            this._METCHG_ApplicationId = METCHG_ApplicationId;
            this._METCHG_ReplaceDate = METCHG_ReplaceDate;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METCHD_ID
        {
            get { return _METCHD_ID; }
            set { _METCHD_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METCHD_METCHGID
        {
            get { return _METCHD_METCHGID; }
            set { _METCHD_METCHGID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int64 METCHD_OldMeterNo
        {
            get { return _METCHD_OldMeterNo; }
            set { _METCHD_OldMeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METCHD_OldMeterReading
        {
            get { return _METCHD_OldMeterReading; }
            set { _METCHD_OldMeterReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METCHG_ApplicationId
        {
            get { return _METCHG_ApplicationId; }
            set { _METCHG_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METCHG_ReplaceDate
        {
            get { return _METCHG_ReplaceDate; }
            set { _METCHG_ReplaceDate = value; }
        }
    }

    public class PRDMeterChangeDTLTRNList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private Int32 _METCHD_ID;
        private Int64 _METCHD_OldMeterNo;
        private decimal _PrevReading;
        private decimal _METCHD_OldMeterReading;
        private string _Checked;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDMeterChangeDTLTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDMeterChangeDTLTRNList(int METCHD_ID, Int64 METCHD_OldMeterNo, decimal PrevReading, decimal METCHD_OldMeterReading, string Checked)
        {
            this._METCHD_ID = METCHD_ID;
            this._METCHD_OldMeterNo = METCHD_OldMeterNo;
            this._PrevReading = PrevReading;
            this._METCHD_OldMeterReading = METCHD_OldMeterReading;
            this._Checked = Checked;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METCHD_ID
        {
            get { return _METCHD_ID; }
            set { _METCHD_ID = value; }
        }

        public Int64 METCHD_OldMeterNo
        {
            get { return _METCHD_OldMeterNo; }
            set { _METCHD_OldMeterNo = value; }
        }

        public decimal PrevReading
        {
            get { return _PrevReading; }
            set { _PrevReading = value; }
        }

        public decimal METCHD_OldMeterReading
        {
            get { return _METCHD_OldMeterReading; }
            set { _METCHD_OldMeterReading = value; }
        }

        public string Checked
        {
            get { return _Checked; }
            set { _Checked = value; }
        }
    }
}
