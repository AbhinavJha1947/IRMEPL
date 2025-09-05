//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDWorkOrderTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDWorkOrderTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class PRDWorkOrderTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _WORTRN_WorkOrdNo;
        private string _WORTRN_WorkOrdRefNo;
        private string _WORTRN_WorkOrdDate;
        private int _WORTRN_ApplicationID;
        private int _WORTRN_WorkOrderTYpe;
        private int _WORTRN_ContractorID;
        private string _WORTRN_Remarks;
        private int _WORTRN_Flag;
        private int _WORTRN_CreatedByUserID;
        private string _WORTRN_CreatedDateTime;
        private int _WORTRN_UpdatedByUserID;
        private string _WORTRN_UpdatedDateTime;
        private int _WORTRN_RowStatus;
        private long _WORTRN_RowVersion;
        private int _WORTRN_Freeze;
        private int _WORTRN_RequestID;
        private decimal _WORTRN_WorkOrdAmt;
        #endregion

        /// <summary>
        /// Default constructor for PRDWorkOrderTRN class.
        /// </summary>
        public PRDWorkOrderTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDWorkOrderTRN(int WORTRN_WorkOrdNo, string WORTRN_WorkOrdRefNo, string WORTRN_WorkOrdDate, int WORTRN_ApplicationID, int WORTRN_WorkOrderTYpe, int WORTRN_ContractorID, string WORTRN_Remarks, int WORTRN_Flag, int WORTRN_CreatedByUserID, string WORTRN_CreatedDateTime, int WORTRN_UpdatedByUserID, string WORTRN_UpdatedDateTime, int WORTRN_RowStatus, long WORTRN_RowVersion, int WORTRN_Freeze, int WORTRN_RequestID, decimal WORTRN_WorkOrdAmt)
        {
            this._WORTRN_WorkOrdNo = WORTRN_WorkOrdNo;
            this._WORTRN_WorkOrdRefNo = WORTRN_WorkOrdRefNo;
            this._WORTRN_WorkOrdDate = WORTRN_WorkOrdDate;
            this._WORTRN_ApplicationID = WORTRN_ApplicationID;
            this._WORTRN_WorkOrderTYpe = WORTRN_WorkOrderTYpe;
            this._WORTRN_ContractorID = WORTRN_ContractorID;
            this._WORTRN_Remarks = WORTRN_Remarks;
            this._WORTRN_Flag = WORTRN_Flag;
            this._WORTRN_CreatedByUserID = WORTRN_CreatedByUserID;
            this._WORTRN_CreatedDateTime = WORTRN_CreatedDateTime;
            this._WORTRN_UpdatedByUserID = WORTRN_UpdatedByUserID;
            this._WORTRN_UpdatedDateTime = WORTRN_UpdatedDateTime;
            this._WORTRN_RowStatus = WORTRN_RowStatus;
            this._WORTRN_RowVersion = WORTRN_RowVersion;
            this._WORTRN_Freeze = WORTRN_Freeze;
            this._WORTRN_RequestID = WORTRN_RequestID;
            this._WORTRN_WorkOrdAmt = WORTRN_WorkOrdAmt;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_WorkOrdNo
        {
            get { return _WORTRN_WorkOrdNo; }
            set { _WORTRN_WorkOrdNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_WorkOrdRefNo
        {
            get { return _WORTRN_WorkOrdRefNo; }
            set { _WORTRN_WorkOrdRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_WorkOrdDate
        {
            get { return _WORTRN_WorkOrdDate; }
            set { _WORTRN_WorkOrdDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_ApplicationID
        {
            get { return _WORTRN_ApplicationID; }
            set { _WORTRN_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_WorkOrderTYpe
        {
            get { return _WORTRN_WorkOrderTYpe; }
            set { _WORTRN_WorkOrderTYpe = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_ContractorID
        {
            get { return _WORTRN_ContractorID; }
            set { _WORTRN_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_Remarks
        {
            get { return _WORTRN_Remarks; }
            set { _WORTRN_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_Flag
        {
            get { return _WORTRN_Flag; }
            set { _WORTRN_Flag = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_CreatedByUserID
        {
            get { return _WORTRN_CreatedByUserID; }
            set { _WORTRN_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_CreatedDateTime
        {
            get { return _WORTRN_CreatedDateTime; }
            set { _WORTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_UpdatedByUserID
        {
            get { return _WORTRN_UpdatedByUserID; }
            set { _WORTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_UpdatedDateTime
        {
            get { return _WORTRN_UpdatedDateTime; }
            set { _WORTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_RowStatus
        {
            get { return _WORTRN_RowStatus; }
            set { _WORTRN_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long WORTRN_RowVersion
        {
            get { return _WORTRN_RowVersion; }
            set { _WORTRN_RowVersion = value; }
        }

        public int WORTRN_Freeze
        {
            get { return _WORTRN_Freeze; }
            set { _WORTRN_Freeze = value; }
        }

        public int WORTRN_RequestID
        {
            get { return _WORTRN_RequestID; }
            set { _WORTRN_RequestID = value; }
        }

        public decimal WORTRN_WorkOrdAmt
        {
            get { return _WORTRN_WorkOrdAmt; }
            set { _WORTRN_WorkOrdAmt = value; }
        }
    }

    public class PRDWorkOrderTRNList
    {
        private int _WORTRN_WorkOrdNo;
        private string _APPMST_AppNo;
        private string _CD_ControlType;
        private string _WORTRN_WorkOrdRefNo;
        private string _WORTRN_WorkOrdDate;
        private string _App_Name;
        private string _CONMST_Name;
        private string _AREMST_Name;
        private string _PLAMST_PlanName;
        private string _Address;
        private string _WO_Freeze;
        private decimal _APPMST_Mobile;
        private decimal _WORTRN_WorkOrdAmt;
        private int _workordercount;
        private string _WORTRN_Remarks;
        private string _RECHDR_Date;
         
        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDWorkOrderTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDWorkOrderTRNList(int WORTRN_WorkOrdNo, string APPMST_AppNo, string CD_ControlType, string WORTRN_WorkOrdRefNo, string WORTRN_WorkOrdDate, string App_Name, string CONMST_Name, string AREMST_Name, string PLAMST_PlanName, string Address, int workordercount, string WO_Freeze, decimal APPMST_Mobile, decimal WORTRN_WorkOrdAmt, string WORTRN_Remarks)
        {

            this._WORTRN_WorkOrdNo = WORTRN_WorkOrdNo;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CD_ControlType = CD_ControlType;
            this._WORTRN_WorkOrdRefNo = WORTRN_WorkOrdRefNo;
            this._WORTRN_WorkOrdDate = WORTRN_WorkOrdDate;
            this._App_Name = App_Name;
            this._CONMST_Name = CONMST_Name;
            this._AREMST_Name = AREMST_Name;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._Address = Address;
            this._workordercount = workordercount;
            this._WO_Freeze = WO_Freeze;
            this._APPMST_Mobile = APPMST_Mobile;
            this._WORTRN_WorkOrdAmt = WORTRN_WorkOrdAmt;
            this._WORTRN_Remarks = WORTRN_Remarks;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WORTRN_WorkOrdNo
        {
            get { return _WORTRN_WorkOrdNo; }
            set { _WORTRN_WorkOrdNo = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public string WORTRN_Remarks
        {
            get { return _WORTRN_Remarks; }
            set { _WORTRN_Remarks = value; }
        }

        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_WorkOrdRefNo
        {
            get { return _WORTRN_WorkOrdRefNo; }
            set { _WORTRN_WorkOrdRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_WorkOrdDate
        {
            get { return _WORTRN_WorkOrdDate; }
            set { _WORTRN_WorkOrdDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string App_Name
        {
            get { return _App_Name; }
            set { _App_Name = value; }
        }

        public string CONMST_Name
        {
            get { return _CONMST_Name; }
            set { _CONMST_Name = value; }
        }

        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }
        }

        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string WO_Freeze
        {
            get { return _WO_Freeze; }
            set { _WO_Freeze = value; }
        }

        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        public decimal WORTRN_WorkOrdAmt
        {
            get { return _WORTRN_WorkOrdAmt; }
            set { _WORTRN_WorkOrdAmt = value; }
        }

        public int workordercount
        {
            get { return _workordercount; }           
        }
        public string RECHDR_Date
        {
            get { return _RECHDR_Date; }
            set { _RECHDR_Date = value; }
        }
    }
    public class PrdAppworkorderList
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _APPMST_AppDate;
        private string _APPMST_CustomerID;
        private string _APPMST_Address2;
        private string _APPMST_Name;
        private string _APPMST_Area;
        private string _APPMST_CustType;
        private string _PLAMST_PlanName;
        private string _APPMST_WOType;
        private int _APPMST_WOTYPEID;
        private int _RequestID;
        private decimal _APPMST_Mobile;
        private decimal _WORTRN_WorkOrdAmt;
        private string _CHQDTL_RealizedDate;
        private int _count;
        private string _RECHDR_Date;


        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PrdAppworkorderList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PrdAppworkorderList(string CHQDTL_RealizedDate, string RECHDR_Date, int APPMST_AppID, string APPMST_AppNo, string APPMST_AppDate, string APPMST_CustomerID, string APPMST_Address2, string APPMST_Name, string APPMST_Area, string APPMST_CustType, string PLAMST_PlanName, string APPMST_WOType, int APPMST_WOTYPEID, int RequestID, decimal APPMST_Mobile, decimal WORTRN_WorkOrdAmt, int count)
        {
            this._RECHDR_Date = RECHDR_Date;
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppDate = APPMST_AppDate;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_Address2 = APPMST_Address2;
            this._APPMST_Name = APPMST_Name;
            this._APPMST_Area = APPMST_Area;
            this._APPMST_CustType = APPMST_CustType;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._APPMST_WOType = APPMST_WOType;
            this._APPMST_WOTYPEID = APPMST_WOTYPEID;
            this._RequestID = RequestID;
            this._APPMST_Mobile = APPMST_Mobile;
            this._WORTRN_WorkOrdAmt = WORTRN_WorkOrdAmt;
            this._CHQDTL_RealizedDate = CHQDTL_RealizedDate; 
            this._count = count;         
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
        public string CHQDTL_RealizedDate
        {
            get { return _CHQDTL_RealizedDate; }
            set { _CHQDTL_RealizedDate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_Date
        {
            get { return _RECHDR_Date; }
            set { _RECHDR_Date = value; }
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
        public string APPMST_AppDate
        {
            get { return _APPMST_AppDate; }
            set { _APPMST_AppDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string APPMST_Address2
        {
            get { return _APPMST_Address2; }
            set { _APPMST_Address2 = value; }
        }

        public string APPMST_Name
        {
            get { return _APPMST_Name; }
            set { _APPMST_Name = value; }
        }
        public string APPMST_Area
        {
            get { return _APPMST_Area; }
            set { _APPMST_Area = value; }
        }
        public string APPMST_CustType
        {
            get { return _APPMST_CustType; }
            set { _APPMST_CustType = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        public string APPMST_WOType
        {
            get { return _APPMST_WOType; }
            set { _APPMST_WOType = value; }
        }
        public int APPMST_WOTYPEID
        {
            get { return _APPMST_WOTYPEID; }
            set { _APPMST_WOTYPEID = value; }
        }

        public int RequestID
        {
            get { return _RequestID; }
            set { _RequestID = value; }
        }
        
        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        public decimal WORTRN_WorkOrdAmt
        {
            get { return _WORTRN_WorkOrdAmt; }
            set { _WORTRN_WorkOrdAmt = value; }
        }

        public int count
        {
            get { return _count; }
           
        }
     
    }
    public class PrdAppworkorderListEdit
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _APPMST_AppDate;
        private string _APPMST_CustomerID;
        private string _APPMST_Address2;
        private string _APPMST_Name;
        private string _APPMST_Area;
        private string _APPMST_CustType;
        private string _PLAMST_PlanName;
        private string _APPMST_WOType;
        private int _APPMST_WOTYPEID;
        private int _RequestID;
        private decimal _APPMST_Mobile;
        private decimal _WORTRN_WorkOrdAmt;
        private string _CHQDTL_RealizedDate;
        private int _count1;
        private string _RECHDR_Date;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PrdAppworkorderListEdit() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        
        public PrdAppworkorderListEdit(string CHQDTL_RealizedDate,int APPMST_AppID, string APPMST_AppNo, string APPMST_AppDate, string APPMST_CustomerID, string APPMST_Address2, string APPMST_Name, string APPMST_Area, string APPMST_CustType, string PLAMST_PlanName, string APPMST_WOType, int APPMST_WOTYPEID, int RequestID, decimal APPMST_Mobile, decimal WORTRN_WorkOrdAmt, int count1)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppDate = APPMST_AppDate;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_Address2 = APPMST_Address2;
            this._APPMST_Name = APPMST_Name;
            this._APPMST_Area = APPMST_Area;
            this._APPMST_CustType = APPMST_CustType;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._APPMST_WOType = APPMST_WOType;
            this._APPMST_WOTYPEID = APPMST_WOTYPEID;
            this._RequestID = RequestID;
            this._APPMST_Mobile = APPMST_Mobile;
            this._WORTRN_WorkOrdAmt = WORTRN_WorkOrdAmt;
            this._CHQDTL_RealizedDate = CHQDTL_RealizedDate;
            this._count1 = count1;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_RealizedDate
        {
            get { return _CHQDTL_RealizedDate; }
            set { _CHQDTL_RealizedDate = value; }
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
        public string APPMST_AppDate
        {
            get { return _APPMST_AppDate; }
            set { _APPMST_AppDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string APPMST_Address2
        {
            get { return _APPMST_Address2; }
            set { _APPMST_Address2 = value; }
        }

        public string APPMST_Name
        {
            get { return _APPMST_Name; }
            set { _APPMST_Name = value; }
        }
        public string APPMST_Area
        {
            get { return _APPMST_Area; }
            set { _APPMST_Area = value; }
        }
        public string APPMST_CustType
        {
            get { return _APPMST_CustType; }
            set { _APPMST_CustType = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        public string APPMST_WOType
        {
            get { return _APPMST_WOType; }
            set { _APPMST_WOType = value; }
        }
        
        public int APPMST_WOTYPEID
        {
            get { return _APPMST_WOTYPEID; }
            set { _APPMST_WOTYPEID = value; }
        }

        public int RequestID
        {
            get { return _RequestID; }
            set { _RequestID = value; }
        }

        public decimal APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        public decimal WORTRN_WorkOrdAmt
        {
            get { return _WORTRN_WorkOrdAmt; }
            set { _WORTRN_WorkOrdAmt = value; }
        }

        public int count1
        {
            get { return _count1; }

        }

    }
    public class PRDWorkOrderTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDWorkOrderTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDWorkOrderTRNMsg(int RetVal, string RetStr)
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

