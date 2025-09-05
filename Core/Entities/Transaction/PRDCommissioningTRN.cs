//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Transaction
{
/// <summary>
/// Class that holds information about a 	PRDCommissioningTRN.
///
/// Enterprise Design Pattern: Domain Model, Identity Field.
/// </summary>
/// <remarks>
/// This is where your business logic resides. In this example there are none.
/// Another place for business logic and business rules is in the Service.
/// For an example see 	PRDCommissioningTRNService in the Service layer.
///
/// The Domain Model Design Pattern states that domain objects incorporate
/// both behavior and data. Behavior may include simple or complex business logic.
///
/// The Identity Field Design Pattern saves the ID field in an object to maintain
/// identity between an in-memory business object and that database rows.
/// </remarks>
    
    public class PRDCommissioningTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private long _COMTRN_ID;
        private long _COMTRN_ApplicationID;
        private string _COMTRN_CustomerID;
        private decimal _COMTRN_InitialReading;
        private string _COMTRN_DateOfComm;
        private int _COMTRN_ContractorID;
        private string _COMTRN_Remarks;
        private int _COMTRN_CreatedByUserID;
        private string _COMTRN_CreatedDateTime;
        private int _COMTRN_UpdatedByUserID;
        private string _COMTRN_UpdatedDateTime;
        private int _COMTRN_RowStatus;
        private long _COMTRN_RowVersion;
        private int _RetVal;
        private string _RetStr;
        private string _COMTRN_ApplicationNo;
        private int _CENMST_CenterCode;
        private int _COMTRN_SMSFlag;
        #endregion

        /// <summary>
        /// Default constructor for PRDCommissioningTRN class.
        /// </summary>
        public PRDCommissioningTRN() { }
        public PRDCommissioningTRN(string COMTRN_ApplicationNo, decimal COMTRN_InitialReading, string COMTRN_DateOfComm, string COMTRN_Remarks, int RetVal, string RetStr, int COMTRN_SMSFlag)
        {
            this._COMTRN_ApplicationNo = COMTRN_ApplicationNo;
            this._COMTRN_InitialReading = COMTRN_InitialReading;
            this._COMTRN_DateOfComm = COMTRN_DateOfComm;
            this._COMTRN_InitialReading = COMTRN_InitialReading;
            this._COMTRN_DateOfComm = COMTRN_DateOfComm;
            this._RetVal = RetVal;
            this._RetStr = RetStr;
            this._COMTRN_SMSFlag = COMTRN_SMSFlag;
        }
        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDCommissioningTRN(long COMTRN_ID, long COMTRN_ApplicationID, string COMTRN_CustomerID, decimal COMTRN_InitialReading, string COMTRN_DateOfComm, int COMTRN_ContractorID, string COMTRN_Remarks, int COMTRN_CreatedByUserID, string COMTRN_CreatedDateTime, int COMTRN_UpdatedByUserID, string COMTRN_UpdatedDateTime, int COMTRN_RowStatus, long COMTRN_RowVersion, int RetVal, string RetStr, int COMTRN_SMSFlag)
        {
            this._COMTRN_ID = COMTRN_ID;
            this._COMTRN_ApplicationID = COMTRN_ApplicationID;
            this._COMTRN_CustomerID = COMTRN_CustomerID;
            this._COMTRN_InitialReading = COMTRN_InitialReading;
            this._COMTRN_DateOfComm = COMTRN_DateOfComm;
            this._COMTRN_ContractorID = COMTRN_ContractorID;
            this._COMTRN_Remarks = COMTRN_Remarks;
            this._COMTRN_CreatedByUserID = COMTRN_CreatedByUserID;
            this._COMTRN_CreatedDateTime = COMTRN_CreatedDateTime;
            this._COMTRN_UpdatedByUserID = COMTRN_UpdatedByUserID;
            this._COMTRN_UpdatedDateTime = COMTRN_UpdatedDateTime;
            this._COMTRN_RowStatus = COMTRN_RowStatus;
            this._COMTRN_RowVersion = COMTRN_RowVersion;
            this._RetVal = RetVal;
            this._RetStr = RetStr;
            this._COMTRN_SMSFlag = COMTRN_SMSFlag;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long COMTRN_ID
        {
            get { return _COMTRN_ID; }
            set { _COMTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long COMTRN_ApplicationID
        {
            get { return _COMTRN_ApplicationID; }
            set { _COMTRN_ApplicationID = value; }
        }
        public string COMTRN_ApplicationNo
        {
            get { return _COMTRN_ApplicationNo; }
            set { _COMTRN_ApplicationNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string COMTRN_CustomerID
        {
            get { return _COMTRN_CustomerID; }
            set { _COMTRN_CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal COMTRN_InitialReading
        {
            get { return _COMTRN_InitialReading; }
            set { _COMTRN_InitialReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string COMTRN_DateOfComm
        {
            get { return _COMTRN_DateOfComm; }
            set { _COMTRN_DateOfComm = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int COMTRN_ContractorID
        {
            get { return _COMTRN_ContractorID; }
            set { _COMTRN_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string COMTRN_Remarks
        {
            get { return _COMTRN_Remarks; }
            set { _COMTRN_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int COMTRN_CreatedByUserID
        {
            get { return _COMTRN_CreatedByUserID; }
            set { _COMTRN_CreatedByUserID = value; }
        }
        public int CENMST_CenterCode
        {
            get { return _CENMST_CenterCode; }
            set { _CENMST_CenterCode = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string COMTRN_CreatedDateTime
        {
            get { return _COMTRN_CreatedDateTime; }
            set { _COMTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int COMTRN_UpdatedByUserID
        {
            get { return _COMTRN_UpdatedByUserID; }
            set { _COMTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string COMTRN_UpdatedDateTime
        {
            get { return _COMTRN_UpdatedDateTime; }
            set { _COMTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int COMTRN_RowStatus
        {
            get { return _COMTRN_RowStatus; }
            set { _COMTRN_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long COMTRN_RowVersion
        {
            get { return _COMTRN_RowVersion; }
            set { _COMTRN_RowVersion = value; }
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
        public int COMTRN_SMSFlag
        {
            get { return _COMTRN_SMSFlag; }
            set { _COMTRN_SMSFlag = value; }
        }
    }
    public class PRDCommissioningTRNList
    {
        private long _COMTRN_ID;
        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _APPMST_CustomerID;
        //private long _WORTRN_WorkOrdNo;        
        //private string _WORTRN_WorkOrdRefNo;
        
        private string _AppName;
        private string _COMTRN_DateOfComm;
        //private string _WORTRN_WorkOrdDate;
        
        private string _AppAddress;
        private int _APPMST_Area;
        private string _AreaName;
        private int _APPMST_PlanId;
        private string _PLAMST_PlanName;    
        private string _CustomerType;
        private decimal _COMTRN_InitialReading;
        private string _CONMST_Name;
        //private string _JOBHDR_DateofInst;    
        private int _Count;


        /// <summary>
	        /// Default constructor for BILBillingCycleMaster class.
	        /// </summary>
	        public PRDCommissioningTRNList() { }

	        /// <summary>
	        /// Overloaded constructor for the Branch class.
	        /// </summary>
            public PRDCommissioningTRNList(long COMTRN_ID, int APPMST_AppID, string APPMST_AppNo, string APPMST_CustomerID, string AppName,
                string COMTRN_DateOfComm, string AppAddress,int APPMST_Area, string AreaName,int APPMST_PlanId, string PLAMST_PlanName, string CustomerType,decimal InitialReading,string ConName, int Count)
            {
                this._COMTRN_ID = COMTRN_ID;
                this._APPMST_AppID = APPMST_AppID;
                this._APPMST_AppNo = APPMST_AppNo;
                this._APPMST_CustomerID = APPMST_CustomerID;
                //this._WORTRN_WorkOrdNo = WORTRN_WorkOrdNo;
                //this._CustomerType = CustomerType;
                //this._BCCMST_ShortName = BCCMST_ShortName;     
                this._APPMST_Area = APPMST_Area;
                this._AppName= AppName;
                this._APPMST_PlanId = APPMST_PlanId;
                this._COMTRN_DateOfComm = COMTRN_DateOfComm;
                this._AppAddress= AppAddress;
                this._AreaName= AreaName;
                this._PLAMST_PlanName= PLAMST_PlanName;            
                this._CustomerType = CustomerType;
                this._COMTRN_InitialReading = InitialReading;
                this._CONMST_Name = ConName;
                this._Count = Count;
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public long COMTRN_ID
            {
                get { return _COMTRN_ID; }
                set { _COMTRN_ID = value; }
            }          

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int APPMST_AppID
            {
                get { return _APPMST_AppID; }
                set { _APPMST_AppID = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string APPMST_AppNo
            {
                get { return _APPMST_AppNo; }
                set { _APPMST_AppNo = value; }
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
            public string AppName
            {
                get { return _AppName; }
                set { _AppName = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string COMTRN_DateOfComm
            {
                get { return _COMTRN_DateOfComm; }
                set { _COMTRN_DateOfComm = value; }
            }        

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string AppAddress
            {
                get { return _AppAddress; }
                set { _AppAddress = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int APPMST_Area
            {
                get { return _APPMST_Area; }
                set { _APPMST_Area = value; }
            }
            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string AreaName
            {
                get { return _AreaName; }
                set { _AreaName = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public int APPMST_PlanId
            {
                get { return _APPMST_PlanId; }
                set { _APPMST_PlanId = value; }
            }

            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string PLAMST_PlanName
            {
                get { return _PLAMST_PlanName; }
                set { _PLAMST_PlanName = value; }
            }
            
            /// <summary>
            //Write Column Description here. 
            /// </summary>
            public string CustomerType
            {
                get { return _CustomerType; }
                set { _CustomerType = value; }
            } 
            public string ConName
            {
                get { return _CONMST_Name; }
                set { _CONMST_Name = value; }
            }
            public decimal InitialReading
            {
                get { return _COMTRN_InitialReading; }
                set { _COMTRN_InitialReading = value; }
            } 
            /// <summary>
            //Write Column Description here. 
            /// </summary>
            /// this._COMTRN_InitialReading = InitialReading;
                
            public int Count
            {
                get { return _Count; }
                set { _Count = value; }
            }
    }
    public class PRDCommissioningTRNListDetail
    {
        //private long _COMTRN_ID;
        private int _APPMST_AppID;
        //private string _APPMST_CustomerID;
        //private long _WORTRN_WorkOrdNo;        
        //private string _WORTRN_WorkOrdRefNo;
        private string _APPMST_AppNo;
        private string _AppName;
        //private string _COMTRN_DateOfComm;
        //private string _WORTRN_WorkOrdDate;

        private string _AppAddress;
        private string _AreaName;
        private string _PLAMST_PlanName;
        private string _ContractorName;
        private string _WORTRN_WorkOrdRefNo;
        //private string _CustomerType;
        //private string _JOBHDR_DateofInst;    
        private int _Count;


        /// <summary>
        /// Default constructor for BILBillingCycleMaster class.
        /// </summary>
        public PRDCommissioningTRNListDetail() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDCommissioningTRNListDetail(int APPMST_AppID, string APPMST_AppNo, string AppName,
            string AppAddress, string AreaName, string PLAMST_PlanName, string ContractorName, string WORTRN_WorkOrdRefNo, int Count)
        {
            //this._COMTRN_ID = COMTRN_ID;
            this._APPMST_AppID = APPMST_AppID;
            //this._APPMST_CustomerID = APPMST_CustomerID;
            //this._WORTRN_WorkOrdNo = WORTRN_WorkOrdNo;
            //this._CustomerType = CustomerType;
            //this._BCCMST_ShortName = BCCMST_ShortName;
            this._APPMST_AppNo = APPMST_AppNo;
            this._AppName = AppName;
            //this._COMTRN_DateOfComm = COMTRN_DateOfComm;
            this._AppAddress = AppAddress;
            this._AreaName = AreaName;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._ContractorName = ContractorName;
            this._WORTRN_WorkOrdRefNo = WORTRN_WorkOrdRefNo;
            //this._CustomerType = CustomerType;
            this._Count = Count;
        }

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public long COMTRN_ID
        //{
        //    get { return _COMTRN_ID; }
        //    set { _COMTRN_ID = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public string APPMST_CustomerID
        //{
        //    get { return _APPMST_CustomerID; }
        //    set { _APPMST_CustomerID = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AppName
        {
            get { return _AppName; }
            set { _AppName = value; }
        }

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public string COMTRN_DateOfComm
        //{
        //    get { return _COMTRN_DateOfComm; }
        //    set { _COMTRN_DateOfComm = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AppAddress
        {
            get { return _AppAddress; }
            set { _AppAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AreaName
        {
            get { return _AreaName; }
            set { _AreaName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ContractorName
        {
            get { return _ContractorName; }
            set { _ContractorName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_WorkOrdRefNo
        {
            get { return _WORTRN_WorkOrdRefNo; }
            set { _WORTRN_WorkOrdRefNo = value; }
        }

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public string CustomerType
        //{
        //    get { return _CustomerType; }
        //    set { _CustomerType = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }
    public class PRDCommissioningTRN_GetMeterNo
    {
        #region "Variables Declaration"
		    private long _CMRMST_MeterNo;
            private decimal _CMRMST_InitialReading;
	    #endregion

	    /// <summary>
	    /// Default constructor for PRDCommissioningTRN class.
	    /// </summary>
	    public PRDCommissioningTRN_GetMeterNo() { }

	    /// <summary>
	    /// Overloaded constructor for the Branch class.
	    /// </summary>
        public PRDCommissioningTRN_GetMeterNo(long CMRMST_MeterNo, decimal CMRMST_InitialReading)
	    {
            this._CMRMST_MeterNo = CMRMST_MeterNo;
            this._CMRMST_InitialReading = CMRMST_InitialReading;
	    }

	    /// <summary>
	    //Write Column Description here. 
	    /// </summary>
        public long CMRMST_MeterNo
		    {
                get { return _CMRMST_MeterNo; }
                set { _CMRMST_MeterNo = value; }
		    }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CMRMST_InitialReading
        {
            get { return _CMRMST_InitialReading; }
            set { _CMRMST_InitialReading = value; }
        }
    }
    public class PRDCommissioningTRNMsg
    {
	    // Class level Local Variables Declaration.
	    #region "Variables Declaration"
    private int _RetVal;
    private string _RetStr;
	    #endregion

	    /// <summary>
	    //Overloaded default constructor for the Salutation class. 
	    /// </summary>
    public PRDCommissioningTRNMsg(){ }
	    /// <summary>
	    //Overloaded constructor for the Salutation class. 
	    /// </summary>
	    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
	    /// <param name="saltnmName">Name of the Salutation.</param>
    public PRDCommissioningTRNMsg(int RetVal, string RetStr)
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
