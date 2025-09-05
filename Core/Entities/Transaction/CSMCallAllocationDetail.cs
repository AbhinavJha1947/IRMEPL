//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CSMCallAllocationDetail.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CSMCallAllocationDetailService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CSMCallAllocationDetail
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _CALLOD_CallAllocationId;
        private decimal _CALLOD_CallLogId;
        private string _CALLOD_TokenNo;
        private int _CALLOD_ProblemId;
        private int _CALLOD_ProblemType;
        private string _CALLOD_Remarks;
        private string _CALLOD_AdminRemarks;
        private string _CALLOD_AllocationDate;
        private string _CALLOD_AllocationTime;
        private int _CALLOD_AllocatedTo;
        private int _CALLOD_AllocatedBy;
        private string _CALLOD_AttendDate;
        private string _CALLOD_AttendTime;
        private string _CALLOD_ContactedPerson;
        private string _CALLOD_FCR_Remarks;
        private int _CALLOD_Status;
        private int _CALLOD_CenterId;
        private int _CALLOD_FCRFilled_By;
        private string _CALLOD_FCR_Date;
        private string _CALLOD_FCR_SaveTime;        
        private string _CALLOD_CallLogIds;
        private string _CALDTL_Phone;
        private string _CALDTL_Mobile;
        private int _CALDTL_Appid;
        private string _CustomerName;
        private string _CALDTL_PreferedDate;
        private string _CALDTL_PreferedTime;
        private string _CALDTL_EmailId;
        private string _Address;
        private string _Problem;
        private string _Priority;
        private string _ClosedBefore;
        private string _CALLOD_ExtendedTime;
        private string _APPMST_AppNo;
        private string _APPMST_CustomerID;
        #endregion

        /// <summary>
        /// Default constructor for CSMCallAllocationDetail class.
        /// </summary>
        public CSMCallAllocationDetail() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMCallAllocationDetail(decimal CALLOD_CallAllocationId, decimal CALLOD_CallLogId, string CALLOD_TokenNo, int CALLOD_ProblemId, int CALLOD_ProblemType, string CALLOD_Remarks, string CALLOD_AdminRemarks, string CALLOD_AllocationDate, string CALLOD_AllocationTime, int CALLOD_AllocatedTo, int CALLOD_AllocatedBy, string CALLOD_AttendDate, string CALLOD_AttendTime, string CALLOD_ContactedPerson, string CALLOD_FCR_Remarks, int CALLOD_Status, int CALLOD_CenterId, int CALLOD_FCRFilled_By, string CALLOD_FCR_Date, string CALLOD_FCR_SaveTime, string CALLOD_ExtendedTime, string CALDTL_Phone, string CALDTL_Mobile, int CALDTL_Appid, string CustomerName, string CALDTL_PreferedDate, string CALDTL_PreferedTime, string CALDTL_EmailId, string Address, string Problem, string Priority, string ClosedBefore, string APPMST_AppNo)
        {
            this._CALLOD_CallAllocationId = CALLOD_CallAllocationId;
            this._CALLOD_CallLogId = CALLOD_CallLogId;
            this._CALLOD_TokenNo = CALLOD_TokenNo;
            this._CALLOD_ProblemId = CALLOD_ProblemId;
            this._CALLOD_ProblemType = CALLOD_ProblemType;
            this._CALLOD_Remarks = CALLOD_Remarks;
            this._CALLOD_AdminRemarks = CALLOD_AdminRemarks;
            this._CALLOD_AllocationDate = CALLOD_AllocationDate;
            this._CALLOD_AllocationTime = CALLOD_AllocationTime;
            this._CALLOD_AllocatedTo = CALLOD_AllocatedTo;
            this._CALLOD_AllocatedBy = CALLOD_AllocatedBy;
            this._CALLOD_AttendDate = CALLOD_AttendDate;
            this._CALLOD_AttendTime = CALLOD_AttendTime;
            this._CALLOD_ContactedPerson = CALLOD_ContactedPerson;
            this._CALLOD_FCR_Remarks = CALLOD_FCR_Remarks;
            this._CALLOD_Status = CALLOD_Status;
            this._CALLOD_CenterId = CALLOD_CenterId;
            this._CALLOD_FCRFilled_By = CALLOD_FCRFilled_By;
            this._CALLOD_FCR_Date = CALLOD_FCR_Date;
            this._CALLOD_FCR_SaveTime = CALLOD_FCR_SaveTime;
            this._CALLOD_ExtendedTime = CALLOD_ExtendedTime;
            this._CALDTL_Phone = CALDTL_Phone;
            this._CALDTL_Mobile = CALDTL_Mobile;
            this._CALDTL_Appid = CALDTL_Appid;
            this._CustomerName = CustomerName;
            this._CALDTL_PreferedDate = CALDTL_PreferedDate;
            this._CALDTL_PreferedTime = CALDTL_PreferedTime;
            this._CALDTL_EmailId = CALDTL_EmailId;
            this._Address = Address;
            this._Problem = Problem;
            this._Priority = Priority;
            this._ClosedBefore = ClosedBefore;
            this._APPMST_AppNo = APPMST_AppNo;
            //this._CALLOD_ExtendedTime = CALLOD_ExtendedTime;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CALLOD_CallAllocationId
        {
            get { return _CALLOD_CallAllocationId; }
            set { _CALLOD_CallAllocationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CALLOD_CallLogId
        {
            get { return _CALLOD_CallLogId; }
            set { _CALLOD_CallLogId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_TokenNo
        {
            get { return _CALLOD_TokenNo; }
            set { _CALLOD_TokenNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_ProblemId
        {
            get { return _CALLOD_ProblemId; }
            set { _CALLOD_ProblemId = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_ProblemType
        {
            get { return _CALLOD_ProblemType; }
            set { _CALLOD_ProblemType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_Remarks
        {
            get { return _CALLOD_Remarks; }
            set { _CALLOD_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_AdminRemarks
        {
            get { return _CALLOD_AdminRemarks; }
            set { _CALLOD_AdminRemarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_AllocationDate
        {
            get { return _CALLOD_AllocationDate; }
            set { _CALLOD_AllocationDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_AllocationTime
        {
            get { return _CALLOD_AllocationTime; }
            set { _CALLOD_AllocationTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_AllocatedTo
        {
            get { return _CALLOD_AllocatedTo; }
            set { _CALLOD_AllocatedTo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_AllocatedBy
        {
            get { return _CALLOD_AllocatedBy; }
            set { _CALLOD_AllocatedBy = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_AttendDate
        {
            get { return _CALLOD_AttendDate; }
            set { _CALLOD_AttendDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_AttendTime
        {
            get { return _CALLOD_AttendTime; }
            set { _CALLOD_AttendTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_ContactedPerson
        {
            get { return _CALLOD_ContactedPerson; }
            set { _CALLOD_ContactedPerson = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_FCR_Remarks
        {
            get { return _CALLOD_FCR_Remarks; }
            set { _CALLOD_FCR_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_Status
        {
            get { return _CALLOD_Status; }
            set { _CALLOD_Status = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_CenterId
        {
            get { return _CALLOD_CenterId; }
            set { _CALLOD_CenterId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_FCRFilled_By
        {
            get { return _CALLOD_FCRFilled_By; }
            set { _CALLOD_FCRFilled_By = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_FCR_Date
        {
            get { return _CALLOD_FCR_Date; }
            set { _CALLOD_FCR_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_FCR_SaveTime
        {
            get { return _CALLOD_FCR_SaveTime; }
            set { _CALLOD_FCR_SaveTime = value; }
        }

        public string CALLOD_CallLogIds
        {
            get { return _CALLOD_CallLogIds; }
            set { _CALLOD_CallLogIds = value; }
        }

        public int CALDTL_Appid
        {
            get { return _CALDTL_Appid; }
            set { _CALDTL_Appid = value; }
        }

        public string CALDTL_Phone
        {
            get { return _CALDTL_Phone; }
            set { _CALDTL_Phone = value; }
        }

        public string CALDTL_Mobile
        {
            get { return _CALDTL_Mobile; }
            set { _CALDTL_Mobile = value; }
        }

        public string CALDTL_EmailId
        {
            get { return _CALDTL_EmailId; }
            set { _CALDTL_EmailId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string CALDTL_PreferedDate
        {
            get { return _CALDTL_PreferedDate; }
            set { _CALDTL_PreferedDate = value; }
        }

        public string CALDTL_PreferedTime
        {
            get { return _CALDTL_PreferedTime; }
            set { _CALDTL_PreferedTime = value; }
        }

        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

        public string ClosedBefore
        {
            get { return _ClosedBefore; }
            set { _ClosedBefore = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public string Problem
        {
            get { return _Problem; }
            set { _Problem = value; }
        }

        public string CALLOD_ExtendedTime
        {
            get { return _CALLOD_ExtendedTime; }
            set { _CALLOD_ExtendedTime = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
    }

    public class CSMCallAllocationDetailList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CALDTL_CallLogId;
        private string _CALDTL_TokenNo;
        private int _CALDTL_Appid;
        private string _CustomerName;
        private string _CALDTL_ReportDate;
        private string _CALDTL_ReportTime;
        private string _CALDTL_Phone;
        private string _CALDTL_Mobile;
        private string _Priority;
        private string _ClosedBefore;
        private string _Area;
        private string _APPMST_AppNo;
        private string _APPMST_CustomerID;
        private int _Count;
        private string _CADTL_CallStatus;
        private string _AllocatedTo;
        private string _UpdatedBy;
        private string _CALLOD_AttendDate;
        private string _CALLOD_AttendTime;
        private string _CALLOD_FCR_Remarks;
        private string _PROMST_Description;
        private string _CallType;
        #endregion

        /// <summary>
        /// Default constructor for CSMProblemMaster class.
        /// </summary>
        public CSMCallAllocationDetailList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMCallAllocationDetailList(int CALDTL_CallLogId, string CALDTL_TokenNo, int CALDTL_Appid, string CustomerName, string CALDTL_ReportDate, string CALDTL_ReportTime, string CALDTL_Phone, string CALDTL_Mobile, string ClosedBefore, string Priority, string Area, string APPMST_AppNo, string APPMST_CustomerID, string CADTL_CallStatus, string AllocatedTo, string UpdatedBy, string CALLOD_AttendDate, string CALLOD_AttendTime, string CALLOD_FCR_Remarks, string PROMST_Description, string CallType, int Count)
        {
            this._CALDTL_CallLogId = CALDTL_CallLogId;
            this._CALDTL_TokenNo = CALDTL_TokenNo;
            this._CALDTL_Appid = CALDTL_Appid;
            this._CustomerName = CustomerName;
            this._CALDTL_ReportDate = CALDTL_ReportDate;
            this._CALDTL_ReportTime = CALDTL_ReportTime;
            this._CALDTL_Phone = CALDTL_Phone;
            this._CALDTL_Mobile = CALDTL_Mobile;
            this._Priority = Priority;
            this._ClosedBefore = ClosedBefore;
            this._Area = Area;
            this._APPMST_AppNo = APPMST_AppNo;
            this.APPMST_CustomerID = APPMST_CustomerID;
            this._CADTL_CallStatus = CADTL_CallStatus;
            this._AllocatedTo = AllocatedTo;
            this._UpdatedBy = UpdatedBy;
            this._CALLOD_AttendDate = CALLOD_AttendDate;
            this._CALLOD_AttendTime = CALLOD_AttendTime;
            this._CALLOD_FCR_Remarks = CALLOD_FCR_Remarks;
            this._PROMST_Description = PROMST_Description;
            this._CallType = CallType;
            this._Count = Count;
        }

        public string CADTL_CallStatus
        {
            get { return _CADTL_CallStatus; }
            set { _CADTL_CallStatus = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_CallLogId
        {
            get { return _CALDTL_CallLogId; }
            set { _CALDTL_CallLogId = value; }
        }

        public string CALDTL_TokenNo
        {
            get { return _CALDTL_TokenNo; }
            set { _CALDTL_TokenNo = value; }
        }

        public int CALDTL_Appid
        {
            get { return _CALDTL_Appid; }
            set { _CALDTL_Appid = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_ReportDate
        {
            get { return _CALDTL_ReportDate; }
            set { _CALDTL_ReportDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_ReportTime
        {
            get { return _CALDTL_ReportTime; }
            set { _CALDTL_ReportTime = value; }
        }
        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }
        public string CALDTL_Phone
        {
            get { return _CALDTL_Phone; }
            set { _CALDTL_Phone = value; }
        }

        public string CALDTL_Mobile
        {
            get { return _CALDTL_Mobile; }
            set { _CALDTL_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ClosedBefore
        {
            get { return _ClosedBefore; }
            set { _ClosedBefore = value; }
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        public string AllocatedTo
        {
            get { return _AllocatedTo; }
            set { _AllocatedTo = value; }
        }

        public string UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }
        
        public string CALLOD_AttendDate
        {
            get { return _CALLOD_AttendDate; }
            set { _CALLOD_AttendDate = value; }
        }

        public string CALLOD_AttendTime
        {
            get { return _CALLOD_AttendTime; }
            set { _CALLOD_AttendTime = value; }
        }

        public string CALLOD_FCR_Remarks
        {
            get { return _CALLOD_FCR_Remarks; }
            set { _CALLOD_FCR_Remarks = value; }
        }

        public string PROMST_Description
        {
            get { return _PROMST_Description; }
            set { _PROMST_Description = value; }
        }
        public string CallType
        {
            get { return _CallType; }
            set { _CallType = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class CSMCallAllocationDetailMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMCallAllocationDetailMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMCallAllocationDetailMsg(int RetVal, string RetStr)
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

    public class CSMFCRDetailList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CALLOD_CallAllocationId;
        private string _CALLOD_TokenNo;
        private int _Appid;
        private string _CustomerName;
        private string _ReportDate;
        private string _ReportTime;
        private string _Phone;
        private string _Mobile;
        private string _Priority;
        private string _ClosedBefore;
        private string _Area;
        private string _APPMST_AppNo;
        private int _CALDTL_Status;
        private string _CALStatus;
        private string _APPMST_CustomerID;       
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CSMProblemMaster class.
        /// </summary>
        public CSMFCRDetailList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMFCRDetailList(int CALLOD_CallAllocationId, string CALLOD_TokenNo, int Appid, string CustomerName, string ReportDate, string ReportTime, string Phone, string Mobile, string ClosedBefore, string Priority, string Area, string APPMST_AppNo, int CALDTL_Status, string CALStatus, string APPMST_CustomerID, int Count)
        {
            this._CALLOD_CallAllocationId = CALLOD_CallAllocationId;
            this._CALLOD_TokenNo = CALLOD_TokenNo;
            this._Appid = Appid;
            this._CustomerName = CustomerName;
            this._ReportDate = ReportDate;
            this._ReportTime = ReportTime;
            this._Phone = Phone;
            this._Mobile = Mobile;
            this._Priority = Priority;
            this._ClosedBefore = ClosedBefore;
            this._Area = Area;
            this._CALDTL_Status = CALDTL_Status;
            this._CALStatus = CALStatus;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALLOD_CallAllocationId
        {
            get { return _CALLOD_CallAllocationId; }
            set { _CALLOD_CallAllocationId = value; }
        }

        public string CALLOD_TokenNo
        {
            get { return _CALLOD_TokenNo; }
            set { _CALLOD_TokenNo = value; }
        }

        public int Appid
        {
            get { return _Appid; }
            set { _Appid = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ReportDate
        {
            get { return _ReportDate; }
            set { _ReportDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ReportTime
        {
            get { return _ReportTime; }
            set { _ReportTime = value; }
        }
        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ClosedBefore
        {
            get { return _ClosedBefore; }
            set { _ClosedBefore = value; }
        }      

        public int CALDTL_Status
        {
            get { return _CALDTL_Status; }
            set { _CALDTL_Status = value; }
        }

        public string CALStatus
        {
            get { return _CALStatus; }
            set { _CALStatus = value; }
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class CSMFCRDetailMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMFCRDetailMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMFCRDetailMsg(int RetVal, string RetStr)
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


    public class CallAllocationLogDetailList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"       
        private string _CALLOD_TokenNo;
        private string _CALLOD_AdminRemarks;
        private string _CALLOD_ContactedPerson;
        private string _CALLOD_FCR_Remarks;
        private string _ComplaintStatus;
        private string _UserName;
        private string _CALLOD_FCR_Date;       
        //private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CSMProblemMaster class.
        /// </summary>
        public CallAllocationLogDetailList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CallAllocationLogDetailList(string CALLOD_TokenNo, string CALLOD_AdminRemarks, string CALLOD_ContactedPerson, string CALLOD_FCR_Remarks, string ComplaintStatus, string UserName, string CALLOD_FCR_Date)
        {
            this._CALLOD_TokenNo = CALLOD_TokenNo;
            this._CALLOD_AdminRemarks = CALLOD_AdminRemarks;
            this._CALLOD_ContactedPerson = CALLOD_ContactedPerson;
            this._CALLOD_FCR_Remarks = CALLOD_FCR_Remarks;
            this._ComplaintStatus = ComplaintStatus;
            this._UserName = UserName;
            this._CALLOD_FCR_Date = CALLOD_FCR_Date;           
            //this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>       

        public string CALLOD_TokenNo
        {
            get { return _CALLOD_TokenNo; }
            set { _CALLOD_TokenNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_AdminRemarks
        {
            get { return _CALLOD_AdminRemarks; }
            set { _CALLOD_AdminRemarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_ContactedPerson
        {
            get { return _CALLOD_ContactedPerson; }
            set { _CALLOD_ContactedPerson = value; }
        }
        public string CALLOD_FCR_Remarks
        {
            get { return _CALLOD_FCR_Remarks; }
            set { _CALLOD_FCR_Remarks = value; }
        }
        public string ComplaintStatus
        {
            get { return _ComplaintStatus; }
            set { _ComplaintStatus = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALLOD_FCR_Date
        {
            get { return _CALLOD_FCR_Date; }
            set { _CALLOD_FCR_Date = value; }
        }

        
        //public int Count
        //{
        //    get { return _Count; }
        //    set { _Count = value; }
        //}
    }

}
