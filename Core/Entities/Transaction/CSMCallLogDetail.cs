//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CSMCallLogDetail.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CSMCallLogDetailService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CSMCallLogDetail
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _CALDTL_CallLogId;
        private string _CALDTL_TokenNo;
        private int _CALDTL_Appid;
        private string _CALDTL_FName;
        private string _CALDTL_MName;
        private string _CALDTL_LName;
        private string _CALDTL_ReportingPerson;
        private string _CALDTL_ReportDate;
        private string _CALDTL_ReportTime;
        private string _CALDTL_StartTime;
        private string _CALDTL_EndTime;
        private int _CALDTL_ConcernedDepartment;
        private int _CALDTL_ProblemId;
        private string _CALDTL_Remarks;
        private string _CALDTL_ContactPerson;
        private string _CALDTL_Phone;
        private string _CALDTL_Mobile;
        private string _CALDTL_EmailId;
        private string _CALDTL_Address;
        private int _CALDTL_Area;
        private int _CALDTL_City;
        private string _CALDTL_PreferedDate;
        private string _CALDTL_PreferedTime;
        private int _CALDTL_Status;
        private string _CALDTL_ForceCloseRemarks;
        private int _CALDTL_CenCode;
        private int _CALDTL_UserId;
        private string _CALDTL_DateTime;
        private int _CALDTL_SendSms;
        private int _CALDTL_SendEmail;
        private string _Priority;
        private string _ClosedBefore;
        private string _Area;
        private string _CustomerName;
        private string _Problem;
        private string _APPMST_AppNo;
        private int _CALLOD_AllocatedTo;
        private long _APPMST_RowVersion;
        private int _CALDTL_CallType;
        #endregion

        /// <summary>
        /// Default constructor for CSMCallLogDetail class.
        /// </summary>
        public CSMCallLogDetail() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMCallLogDetail(decimal CALDTL_CallLogId, string CALDTL_TokenNo, int CALDTL_Appid, string CALDTL_FName, string CALDTL_MName, string CALDTL_LName, string CALDTL_ReportingPerson, string CALDTL_ReportDate, string CALDTL_ReportTime, string CALDTL_StartTime, string CALDTL_EndTime, int CALDTL_ConcernedDepartment, int CALDTL_ProblemId, string CALDTL_Remarks, string CALDTL_ContactPerson, string CALDTL_Phone, string CALDTL_Mobile, string CALDTL_EmailId, string CALDTL_Address, int CALDTL_Area, int CALDTL_City, string CALDTL_PreferedDate, string CALDTL_PreferedTime, int CALDTL_Status, string CALDTL_ForceCloseRemarks, int CALDTL_CenCode, int CALDTL_UserId, string CALDTL_DateTime, int CALDTL_SendSms, int CALDTL_SendEmail, string Priority, string ClosedBefore, string Area, string CustomerName, string Problem, string AppNo,int CALLOD_AllocatedTo, long APPMST_RowVersion)
        {
            this._CALDTL_CallLogId = CALDTL_CallLogId;
            this._CALDTL_TokenNo = CALDTL_TokenNo;
            this._CALDTL_Appid = CALDTL_Appid;
            this._CALDTL_FName = CALDTL_FName;
            this._CALDTL_MName = CALDTL_MName;
            this._CALDTL_LName = CALDTL_LName;
            this._CALDTL_ReportingPerson = CALDTL_ReportingPerson;
            this._CALDTL_ReportDate = CALDTL_ReportDate;
            this._CALDTL_ReportTime = CALDTL_ReportTime;
            this._CALDTL_StartTime = CALDTL_StartTime;
            this._CALDTL_EndTime = CALDTL_EndTime;
            this._CALDTL_ConcernedDepartment = CALDTL_ConcernedDepartment;
            this._CALDTL_ProblemId = CALDTL_ProblemId;
            this._CALDTL_Remarks = CALDTL_Remarks;
            this._CALDTL_ContactPerson = CALDTL_ContactPerson;
            this._CALDTL_Phone = CALDTL_Phone;
            this._CALDTL_Mobile = CALDTL_Mobile;
            this._CALDTL_EmailId = CALDTL_EmailId;
            this._CALDTL_Address = CALDTL_Address;
            this._CALDTL_Area = CALDTL_Area;
            this._CALDTL_City = CALDTL_City;
            this._CALDTL_PreferedDate = CALDTL_PreferedDate;
            this._CALDTL_PreferedTime = CALDTL_PreferedTime;
            this._CALDTL_Status = CALDTL_Status;
            this._CALDTL_ForceCloseRemarks = CALDTL_ForceCloseRemarks;
            this._CALDTL_CenCode = CALDTL_CenCode;
            this._CALDTL_UserId = CALDTL_UserId;
            this._CALDTL_DateTime = CALDTL_DateTime;
            this._CALDTL_SendSms = CALDTL_SendSms;
            this._CALDTL_SendEmail = CALDTL_SendEmail;
            this._Priority = Priority;
            this._Problem = Problem;
            this._CustomerName = CustomerName;
            this._ClosedBefore = ClosedBefore;
            this._Area = Area;
            this._APPMST_AppNo = AppNo;
            this._CALLOD_AllocatedTo = CALLOD_AllocatedTo;
            this._APPMST_RowVersion = APPMST_RowVersion;
            
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CALDTL_CallLogId
        {
            get { return _CALDTL_CallLogId; }
            set { _CALDTL_CallLogId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_TokenNo
        {
            get { return _CALDTL_TokenNo; }
            set { _CALDTL_TokenNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_Appid
        {
            get { return _CALDTL_Appid; }
            set { _CALDTL_Appid = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_FName
        {
            get { return _CALDTL_FName; }
            set { _CALDTL_FName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_MName
        {
            get { return _CALDTL_MName; }
            set { _CALDTL_MName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_LName
        {
            get { return _CALDTL_LName; }
            set { _CALDTL_LName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_ReportingPerson
        {
            get { return _CALDTL_ReportingPerson; }
            set { _CALDTL_ReportingPerson = value; }
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

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_StartTime
        {
            get { return _CALDTL_StartTime; }
            set { _CALDTL_StartTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_EndTime
        {
            get { return _CALDTL_EndTime; }
            set { _CALDTL_EndTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_ConcernedDepartment
        {
            get { return _CALDTL_ConcernedDepartment; }
            set { _CALDTL_ConcernedDepartment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_ProblemId
        {
            get { return _CALDTL_ProblemId; }
            set { _CALDTL_ProblemId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_Remarks
        {
            get { return _CALDTL_Remarks; }
            set { _CALDTL_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_ContactPerson
        {
            get { return _CALDTL_ContactPerson; }
            set { _CALDTL_ContactPerson = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_Phone
        {
            get { return _CALDTL_Phone; }
            set { _CALDTL_Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_Mobile
        {
            get { return _CALDTL_Mobile; }
            set { _CALDTL_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_EmailId
        {
            get { return _CALDTL_EmailId; }
            set { _CALDTL_EmailId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_Address
        {
            get { return _CALDTL_Address; }
            set { _CALDTL_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_Area
        {
            get { return _CALDTL_Area; }
            set { _CALDTL_Area = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_City
        {
            get { return _CALDTL_City; }
            set { _CALDTL_City = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_PreferedDate
        {
            get { return _CALDTL_PreferedDate; }
            set { _CALDTL_PreferedDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_PreferedTime
        {
            get { return _CALDTL_PreferedTime; }
            set { _CALDTL_PreferedTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_Status
        {
            get { return _CALDTL_Status; }
            set { _CALDTL_Status = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_ForceCloseRemarks
        {
            get { return _CALDTL_ForceCloseRemarks; }
            set { _CALDTL_ForceCloseRemarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_CenCode
        {
            get { return _CALDTL_CenCode; }
            set { _CALDTL_CenCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_UserId
        {
            get { return _CALDTL_UserId; }
            set { _CALDTL_UserId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_DateTime
        {
            get { return _CALDTL_DateTime; }
            set { _CALDTL_DateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_SendSms
        {
            get { return _CALDTL_SendSms; }
            set { _CALDTL_SendSms = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_SendEmail
        {
            get { return _CALDTL_SendEmail; }
            set { _CALDTL_SendEmail = value; }
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

        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
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
        public string AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }


        public int CALLOD_AllocatedTo
        {
            get { return _CALLOD_AllocatedTo; }
            set { _CALLOD_AllocatedTo = value; }
        }
        
        public long APPMST_RowVersion
        {
            get { return _APPMST_RowVersion; }
            set { _APPMST_RowVersion = value; }
        }
      
    }

    public class CSMCallLogDetailList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CALDTL_CallLogId;
        private int _CALDTL_Appid;
        private string _Name;
        private string _CALDTL_ReportDate;
        private string _Priority;
        private string _PROMST_Description;
        private string _Status;
        private string _APPMST_AppNo;
       
        private string _AREMST_Name;
        private string _PROMST_ProblemType;
        private string _CALDTL_ConcernedDepartment;
        private string _CALDTL_TokenNo;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CSMProblemMaster class.
        /// </summary>
        public CSMCallLogDetailList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMCallLogDetailList(int CALDTL_CallLogId, string APPMST_AppNo, string Name, string CALDTL_ReportDate, string Priority, string PROMST_Description, string Status, string AREMST_Name, string CALDTL_ConcernedDepartment, string CALDTL_TokenNo, int Count)
        {
            this._CALDTL_CallLogId = CALDTL_CallLogId;
            this._APPMST_AppNo = APPMST_AppNo;
            this._PROMST_Description = PROMST_Description;
            this._Name = Name;
            this._Priority = Priority;
            this._CALDTL_ReportDate = CALDTL_ReportDate;
            this._Status = Status;

            this._AREMST_Name= AREMST_Name;
            this._CALDTL_ConcernedDepartment = CALDTL_ConcernedDepartment;
            this._CALDTL_TokenNo = CALDTL_TokenNo;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CALDTL_CallLogId
        {
            get { return _CALDTL_CallLogId; }
            set { _CALDTL_CallLogId = value; }
        }

        public int CALDTL_Appid
        {
            get { return _CALDTL_Appid; }
            set { _CALDTL_Appid = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PROMST_Description
        {
            get { return _PROMST_Description; }
            set { _PROMST_Description = value; }
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
        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
       
        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }
        }
       
              public string CALDTL_ConcernedDepartment
        {
            get { return _CALDTL_ConcernedDepartment; }
            set { _CALDTL_ConcernedDepartment = value; }
        }
              public string CALDTL_TokenNo
        {
            get { return _CALDTL_TokenNo; }
            set { _CALDTL_TokenNo = value; }
        }
        
         public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }

    public class CSMCallLogDetailMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMCallLogDetailMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMCallLogDetailMsg(int RetVal, string RetStr)
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

    
    public class CSMAdvanceCallLogDetail
    {
        #region "Variables Declaration"
        private string _CALDTL_TokenNo;
        private string _APPMST_AppNo;
        private string _APPMST_CustomerID;
        private string _PROMST_Description;
        private string _CALDTL_ReportDate;
        private string _CALDTL_ReportTime;
        private string _Status;
        private int _Count;
        #endregion

        public CSMAdvanceCallLogDetail() { }
        public CSMAdvanceCallLogDetail(string CALDTL_TokenNo, string APPMST_AppNo, string APPMST_CustomerID, string PROMST_Description, string CALDTL_ReportDate, string CALDTL_ReportTime, string Status,int Count)
        {
            this._CALDTL_TokenNo = CALDTL_TokenNo;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._PROMST_Description = PROMST_Description;
            this._CALDTL_ReportDate = CALDTL_ReportDate;
            this._CALDTL_ReportTime = CALDTL_ReportTime;
            this._Status = Status;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CALDTL_TokenNo
        {
            get { return _CALDTL_TokenNo; }
            set { _CALDTL_TokenNo = value; }
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
        public string PROMST_Description
        {
            get { return _PROMST_Description; }
            set { _PROMST_Description = value; }
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
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }
}
