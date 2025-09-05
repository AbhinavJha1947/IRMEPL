//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDJobSheetHDRTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDJobSheetHDRTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class PRDJobSheetHDRTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _JOBHDR_JobSheetID;
        private int _JOBHDR_ApplicationId;
        private int _JOBHDR_ContractorID;
        private string _JOBHDR_Remarks;
        private string _JOBHDR_DateofInst;
        private int _JOBHDR_PlanId;
        private int _JOBHDR_PlanFor;
        private int _JOBHDR_TypeofHouse;
        private int _JOBHDR_Flag;
        private int _JOBHDR_JobSheetType;
        private Int64 _JOBHDR_MeterNo;
        private int _JOBHDR_WorkOrdno;
        private decimal _JOBHDR_ActualAmt;
        private int _JOBHDR_CreatedByUserID;
        private string _JOBHDR_CreatedDateTime;
        private int _JOBHDR_UpdatedByUserID;
        private string _JOBHDR_UpdatedDateTime;
        private int _JOBHDR_RowStatus;
        private long _JOBHDR_RowVersion;
        private string _JOBHDR_ImagePath;
        #endregion

        /// <summary>
        /// Default constructor for PRDJobSheetHDRTRN class.
        /// </summary>
        public PRDJobSheetHDRTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDJobSheetHDRTRN(int JOBHDR_JobSheetID, int JOBHDR_ApplicationId, int JOBHDR_ContractorID, string JOBHDR_Remarks, string JOBHDR_DateofInst, int JOBHDR_PlanId, int JOBHDR_PlanFor, int JOBHDR_TypeofHouse, int JOBHDR_Flag, int JOBHDR_JobSheetType, Int64 JOBHDR_MeterNo, int JOBHDR_WorkOrdno, decimal JOBHDR_ActualAmt, int JOBHDR_CreatedByUserID, string JOBHDR_CreatedDateTime, int JOBHDR_UpdatedByUserID, string JOBHDR_UpdatedDateTime, int JOBHDR_RowStatus, long JOBHDR_RowVersion, string JOBHDR_ImagePath)
        {
            this._JOBHDR_JobSheetID = JOBHDR_JobSheetID;
            this._JOBHDR_ApplicationId = JOBHDR_ApplicationId;
            this._JOBHDR_ContractorID = JOBHDR_ContractorID;
            this._JOBHDR_Remarks = JOBHDR_Remarks;
            this._JOBHDR_DateofInst = JOBHDR_DateofInst;
            this._JOBHDR_PlanId = JOBHDR_PlanId;
            this._JOBHDR_PlanFor = JOBHDR_PlanFor;
            this._JOBHDR_TypeofHouse = JOBHDR_TypeofHouse;
            this._JOBHDR_Flag = JOBHDR_Flag;
            this._JOBHDR_JobSheetType = JOBHDR_JobSheetType;
            this._JOBHDR_MeterNo = JOBHDR_MeterNo;
            this._JOBHDR_WorkOrdno = JOBHDR_WorkOrdno;
            this._JOBHDR_ActualAmt = JOBHDR_ActualAmt;
            this._JOBHDR_CreatedByUserID = JOBHDR_CreatedByUserID;
            this._JOBHDR_CreatedDateTime = JOBHDR_CreatedDateTime;
            this._JOBHDR_UpdatedByUserID = JOBHDR_UpdatedByUserID;
            this._JOBHDR_UpdatedDateTime = JOBHDR_UpdatedDateTime;
            this._JOBHDR_RowStatus = JOBHDR_RowStatus;
            this._JOBHDR_RowVersion = JOBHDR_RowVersion;
            this._JOBHDR_ImagePath = JOBHDR_ImagePath;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_JobSheetID
        {
            get { return _JOBHDR_JobSheetID; }
            set { _JOBHDR_JobSheetID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_ApplicationId
        {
            get { return _JOBHDR_ApplicationId; }
            set { _JOBHDR_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_ContractorID
        {
            get { return _JOBHDR_ContractorID; }
            set { _JOBHDR_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBHDR_Remarks
        {
            get { return _JOBHDR_Remarks; }
            set { _JOBHDR_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBHDR_DateofInst
        {
            get { return _JOBHDR_DateofInst; }
            set { _JOBHDR_DateofInst = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_PlanId
        {
            get { return _JOBHDR_PlanId; }
            set { _JOBHDR_PlanId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_PlanFor
        {
            get { return _JOBHDR_PlanFor; }
            set { _JOBHDR_PlanFor = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_TypeofHouse
        {
            get { return _JOBHDR_TypeofHouse; }
            set { _JOBHDR_TypeofHouse = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_Flag
        {
            get { return _JOBHDR_Flag; }
            set { _JOBHDR_Flag = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_JobSheetType
        {
            get { return _JOBHDR_JobSheetType; }
            set { _JOBHDR_JobSheetType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int64 JOBHDR_MeterNo
        {
            get { return _JOBHDR_MeterNo; }
            set { _JOBHDR_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_WorkOrdno
        {
            get { return _JOBHDR_WorkOrdno; }
            set { _JOBHDR_WorkOrdno = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal JOBHDR_ActualAmt
        {
            get { return _JOBHDR_ActualAmt; }
            set { _JOBHDR_ActualAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_CreatedByUserID
        {
            get { return _JOBHDR_CreatedByUserID; }
            set { _JOBHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBHDR_CreatedDateTime
        {
            get { return _JOBHDR_CreatedDateTime; }
            set { _JOBHDR_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_UpdatedByUserID
        {
            get { return _JOBHDR_UpdatedByUserID; }
            set { _JOBHDR_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBHDR_UpdatedDateTime
        {
            get { return _JOBHDR_UpdatedDateTime; }
            set { _JOBHDR_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBHDR_RowStatus
        {
            get { return _JOBHDR_RowStatus; }
            set { _JOBHDR_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long JOBHDR_RowVersion
        {
            get { return _JOBHDR_RowVersion; }
            set { _JOBHDR_RowVersion = value; }
        }

        public string JOBHDR_ImagePath
        {
            get { return _JOBHDR_ImagePath; }
            set { _JOBHDR_ImagePath = value; }
        }
    }
    
    public class PRDJobSheetEdit
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _WORTRN_WorkOrdNo;
        private int _WORTRN_WorkOrderTYpe;
        private string _WORTRN_WorkOrdRefNo;
        private string _WORTRN_WorkOrdDate;
        private int _APPMST_AppID;
        private string _APPMST_CustomerID;
        //private string _CD_ControlType;
        private string _APPMST_AppNo;
        private string _APP_Name;
        private int _APPMST_CustType;
        private string _Address;
        private int _APPMST_PlanId;
        private int _WORTRN_ContractorID;
        private int _WORTRN_HouseType;
        private string _APPMST_Latitude;
        private string _APPMST_Longitude;
        private int _isPaymentReceived;
        // private int _WORTRN_ContractorID;
        //private string _CONMST_Name;
        #endregion

        /// <summary>
        /// Default constructor for PRDJobSheetHDRTRN class.
        /// </summary>
        public PRDJobSheetEdit() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDJobSheetEdit(int WORTRN_WorkOrderTYpe, int WORTRN_WorkOrdNo, string WORTRN_WorkOrdRefNo, string WORTRN_WorkOrdDate, int APPMST_AppID, string APPMST_AppNo, string APP_Name, int APPMST_CustType, string Address, int APPMST_PlanId, int WORTRN_ContractorID, int WORTRN_HouseType, string APPMST_Latitude, string APPMST_Longitude, int isPaymentReceived, string APPMST_CustomerID)
        {


            this._WORTRN_WorkOrderTYpe = WORTRN_WorkOrderTYpe;
            this._WORTRN_WorkOrdNo = WORTRN_WorkOrdNo;
            this._WORTRN_WorkOrdRefNo = WORTRN_WorkOrdRefNo;
            this._WORTRN_WorkOrdDate = WORTRN_WorkOrdDate;
            this._APPMST_AppID = APPMST_AppID;
            //this._CD_ControlType = CD_ControlType;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APP_Name = APP_Name;
            this._APPMST_CustType = APPMST_CustType;
            this._Address = Address;
            this._APPMST_PlanId = APPMST_PlanId;
            this._WORTRN_ContractorID = WORTRN_ContractorID;
            this._WORTRN_HouseType = WORTRN_HouseType;
            this._APPMST_Latitude = APPMST_Latitude;
            this._APPMST_Longitude = APPMST_Longitude;
            this._isPaymentReceived = isPaymentReceived;
            this._APPMST_CustomerID = APPMST_CustomerID;
            //this._CONMST_Name = CONMST_Name;
            //this._WORTRN_ContractorID = WORTRN_ContractorID;
        }



        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public int WORTRN_WorkOrderTYpe
        {
            get { return _WORTRN_WorkOrderTYpe; }
            set { _WORTRN_WorkOrderTYpe = value; }
        }
        public int WORTRN_WorkOrdNo
        {
            get { return _WORTRN_WorkOrdNo; }
            set { _WORTRN_WorkOrdNo = value; }
        }
        public string WORTRN_WorkOrdRefNo
        {
            get { return _WORTRN_WorkOrdRefNo; }
            set { _WORTRN_WorkOrdRefNo = value; }
        }
        public string WORTRN_WorkOrdDate
        {
            get { return _WORTRN_WorkOrdDate; }
            set { _WORTRN_WorkOrdDate = value; }
        }
        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        //public string CD_ControlType
        //{
        //    get { return _CD_ControlType; }
        //    set { _CD_ControlType = value; }
        //}
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public string APP_Name
        {
            get { return _APP_Name; }
            set { _APP_Name = value; }
        }
        public int APPMST_CustType
        {
            get { return _APPMST_CustType; }
            set { _APPMST_CustType = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public int APPMST_PlanId
        {
            get { return _APPMST_PlanId; }
            set { _APPMST_PlanId = value; }
        }

        public int WORTRN_ContractorID
        {
            get { return _WORTRN_ContractorID; }
            set { _WORTRN_ContractorID = value; }
        }
        public int WORTRN_HouseType
        {
            get { return _WORTRN_HouseType; }
            set { _WORTRN_HouseType = value; }
        }

        public string APPMST_Latitude
        {
            get { return _APPMST_Latitude; }
            set { _APPMST_Latitude = value; }
        }
        public string APPMST_Longitude
        {
            get { return _APPMST_Longitude; }
            set { _APPMST_Longitude = value; }
        }
        public int isPaymentReceived
        {
            get { return _isPaymentReceived; }
            set { _isPaymentReceived = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        //public int WORTRN_ContractorID
        //{
        //    get { return _WORTRN_ContractorID; }
        //    set { _WORTRN_ContractorID = value; }
        //}

    }

    public class PRDJobSheetHDRTRNLIST
    {
        private int _JOBHDR_JobSheetID;
        private int _JOBHDR_ApplicationId;
        private string _APPMST_AppNo;
        private string _JOBHDR_ContractorID;
        private string _JOBHDR_DateofInst;
        private string _JOBHDR_PlanFor;
        private string _JOBHDR_TypeofHouse;
        private string _JOBHDR_JobSheetType;
        private string _JOBHDR_MeterNo;
        private string _JOBHDR_WorkOrdno;
        private string _JOBHDR_ActualAmt;
        private string _JOBHDR_ImagePath;

        private int _Count;



        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDJobSheetHDRTRNLIST() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDJobSheetHDRTRNLIST(int JOBHDR_JobSheetID, int JOBHDR_ApplicationId, string APPMST_AppNo, string JOBHDR_ContractorID, string JOBHDR_DateofInst, string JOBHDR_PlanFor, string JOBHDR_TypeofHouse, string JOBHDR_JobSheetType, string JOBHDR_MeterNo, string JOBHDR_WorkOrdno, string JOBHDR_ActualAmt, string JOBHDR_ImagePath, int Count)
        {
            this._JOBHDR_JobSheetID = JOBHDR_JobSheetID;
            this._JOBHDR_ApplicationId = JOBHDR_ApplicationId;
            this._APPMST_AppNo = APPMST_AppNo;
            this._JOBHDR_ContractorID = JOBHDR_ContractorID;
            this._JOBHDR_DateofInst = JOBHDR_DateofInst;
            this._JOBHDR_PlanFor = JOBHDR_PlanFor;
            this._JOBHDR_TypeofHouse = JOBHDR_TypeofHouse;
            this._JOBHDR_JobSheetType = JOBHDR_JobSheetType;

            this._JOBHDR_WorkOrdno = JOBHDR_WorkOrdno;
            this._JOBHDR_ActualAmt = JOBHDR_ActualAmt;
            this._JOBHDR_ImagePath = JOBHDR_ImagePath;

            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public int JOBHDR_JobSheetID
        {
            get { return _JOBHDR_JobSheetID; }
            set { _JOBHDR_JobSheetID = value; }
        }
        public int JOBHDR_ApplicationId
        {
            get { return _JOBHDR_ApplicationId; }
            set { _JOBHDR_ApplicationId = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }
        public string JOBHDR_ContractorID
        {
            get { return _JOBHDR_ContractorID; }
            set { _JOBHDR_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBHDR_DateofInst
        {
            get { return _JOBHDR_DateofInst; }
            set { _JOBHDR_DateofInst = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBHDR_PlanFor
        {
            get { return _JOBHDR_PlanFor; }
            set { _JOBHDR_PlanFor = value; }
        }

        public string JOBHDR_TypeofHouse
        {
            get { return _JOBHDR_TypeofHouse; }
            set { _JOBHDR_TypeofHouse = value; }
        }
        public string JOBHDR_JobSheetType
        {
            get { return _JOBHDR_JobSheetType; }
            set { _JOBHDR_JobSheetType = value; }
        }

        public string JOBHDR_MeterNo
        {
            get { return _JOBHDR_MeterNo; }
            set { _JOBHDR_MeterNo = value; }
        }

        public string JOBHDR_WorkOrdno
        {
            get { return _JOBHDR_WorkOrdno; }
            set { _JOBHDR_WorkOrdno = value; }
        }

        public string JOBHDR_ImagePath
        {
            get { return _JOBHDR_ImagePath; }
            set { _JOBHDR_ImagePath = value; }
        }
        

        public int Count
        {
            get { return _Count; }
        }
    }

    public class PRDJobSheetHDRTRNList
    {
        private string _KeyField;
        private int _WORTRN_WorkOrdNo;
        private string _WORTRN_WorkOrdRefNo;
        private string _APPMST_AppNo;
        private string _WORTRN_WorkOrdDate;
        private string _APPMST_CustomerID;
        private string _CD_ControlType;

        private string _APP_Name;
        private string _PLAMST_PlanName;
        private string _Address;
        private int _APPMST_Area;
        private string _AREMST_Name;
        private int _WORTRN_ContractorID;
        private string _CONMST_Name;
        private int _JOBHDR_JobSheetID;
        private string _JOBHDR_DateofInst;
        private string _JOBHDR_Remarks;
        private decimal _JOBHDR_MeterNo;
        private string _JOBHDR_RowStatus;
        private string _JOBHDR_ImagePath;
        private int _jobcount;



        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDJobSheetHDRTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDJobSheetHDRTRNList(string KeyField, int WORTRN_WorkOrdNo, string WORTRN_WorkOrdRefNo, string APPMST_AppNo, string WORTRN_WorkOrdDate, string APPMST_CustomerID, string CD_ControlType, string APP_Name, string PLAMST_PlanName, string Address, int APPMST_Area, string AREMST_Name, int WORTRN_ContractorID, string CONMST_Name, int JOBHDR_JobSheetID, string JOBHDR_DateofInst, string JOBHDR_Remarks, decimal JOBHDR_MeterNo, string JOBHDR_RowStatus, string JOBHDR_ImagePath, int jobcount)
        {
            this._KeyField = KeyField;
            this._WORTRN_WorkOrdNo = WORTRN_WorkOrdNo;
            this._WORTRN_WorkOrdRefNo = WORTRN_WorkOrdRefNo;
            this._APPMST_AppNo = APPMST_AppNo;
            this._WORTRN_WorkOrdDate = WORTRN_WorkOrdDate;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._CD_ControlType = CD_ControlType;
            this._APP_Name = APP_Name;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._Address = Address;
            this._APPMST_Area = APPMST_Area;
            this._AREMST_Name = AREMST_Name;
            this._WORTRN_ContractorID = WORTRN_ContractorID;
            this._CONMST_Name = CONMST_Name;
            this._JOBHDR_JobSheetID = JOBHDR_JobSheetID;
            this._JOBHDR_DateofInst = JOBHDR_DateofInst;
            this._JOBHDR_Remarks = JOBHDR_Remarks;
            this._JOBHDR_MeterNo = JOBHDR_MeterNo;
            this._JOBHDR_RowStatus = JOBHDR_RowStatus;
            this._JOBHDR_ImagePath = JOBHDR_ImagePath;
            this._jobcount = jobcount;
        }

        public string KeyField
        {
            get { return _KeyField; }
            set { _KeyField = value; }
        }
        public int WORTRN_WorkOrdNo
        {
            get { return _WORTRN_WorkOrdNo; }
            set { _WORTRN_WorkOrdNo = value; }
        }
        public string WORTRN_WorkOrdRefNo
        {
            get { return _WORTRN_WorkOrdRefNo; }
            set { _WORTRN_WorkOrdRefNo = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
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
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        public string APP_Name
        {
            get { return _APP_Name; }
            set { _APP_Name = value; }
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

        public int APPMST_Area
        {
            get { return _APPMST_Area; }
            set { _APPMST_Area = value; }
        }
        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }

        }
        public int WORTRN_ContractorID
        {
            get { return _WORTRN_ContractorID; }
            set { _WORTRN_ContractorID = value; }
        }

        public string CONMST_Name
        {
            get { return _CONMST_Name; }
            set { _CONMST_Name = value; }
        }
        public int JOBHDR_JobSheetID
        {
            get { return _JOBHDR_JobSheetID; }
            set { _JOBHDR_JobSheetID = value; }
        }
        public string JOBHDR_DateofInst
        {
            get { return _JOBHDR_DateofInst; }
            set { _JOBHDR_DateofInst = value; }
        }

        public int jobcount
        {
            get { return _jobcount; }

        }
        public string JOBHDR_Remarks
        {
            get { return _JOBHDR_Remarks; }
            set { _JOBHDR_Remarks = value; }
        }
        public decimal JOBHDR_MeterNo
        {
            get { return _JOBHDR_MeterNo; }
            set { _JOBHDR_MeterNo = value; }
        }

        public string JOBHDR_RowStatus
        {
            get { return _JOBHDR_RowStatus; }
            set { _JOBHDR_RowStatus = value; }
        }
        public string JOBHDR_ImagePath
        {
            get { return _JOBHDR_ImagePath; }
            set { _JOBHDR_ImagePath = value; }
        }
        
    }
    
    public class PRDJobSheetHDRTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDJobSheetHDRTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDJobSheetHDRTRNMsg(int RetVal, string RetStr)
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
