//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILMeterReadingTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILMeterReadingTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILMeterReadingTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _METTRN_ID;
        private int _METTRN_ApplicationId;
        private string _APPMST_CustomerID;
        private int _METTRN_BillingId;
        private long _METTRN_MeterNo;
        private string _METTRN_ReadingDate;
        private decimal _METTRN_CurrentReading;
        private decimal _METTRN_PrevReading;
        private string _METTRN_CollectionDate;
        private int _METTRN_CreatedByUserID;
        private string _METTRN_CreatedDateTime;
        private int _METTRN_UpdatedByUserID;
        private string _METTRN_UpdatedDateTime;
        private int _METTRN_RowStatus;
        private long _METTRN_RowVersion;
        private string _METTRN_Remarks;
        private int _METTRN_ISHouseLock;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingTRN(int METTRN_ID, int METTRN_ApplicationId, string APPMST_CustomerID, int METTRN_BillingId, long METTRN_MeterNo, string METTRN_ReadingDate, decimal METTRN_CurrentReading, decimal METTRN_PrevReading, string METTRN_CollectionDate, int METTRN_CreatedByUserID, string METTRN_CreatedDateTime, int METTRN_UpdatedByUserID, string METTRN_UpdatedDateTime, int METTRN_RowStatus, long METTRN_RowVersion, string METTRN_Remarks, int METTRN_ISHouseLock)
        {
            this._METTRN_ID = METTRN_ID;
            this._METTRN_ApplicationId = METTRN_ApplicationId;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._METTRN_BillingId = METTRN_BillingId;
            this._METTRN_MeterNo = METTRN_MeterNo;
            this._METTRN_ReadingDate = METTRN_ReadingDate;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
            this._METTRN_PrevReading = METTRN_PrevReading;
            this._METTRN_CollectionDate = METTRN_CollectionDate;
            this._METTRN_CreatedByUserID = METTRN_CreatedByUserID;
            this._METTRN_CreatedDateTime = METTRN_CreatedDateTime;
            this._METTRN_UpdatedByUserID = METTRN_UpdatedByUserID;
            this._METTRN_UpdatedDateTime = METTRN_UpdatedDateTime;
            this._METTRN_RowStatus = METTRN_RowStatus;
            this._METTRN_RowVersion = METTRN_RowVersion;
            this._METTRN_Remarks = METTRN_Remarks;
            this._METTRN_ISHouseLock = METTRN_ISHouseLock;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_ID
        {
            get { return _METTRN_ID; }
            set { _METTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_ApplicationId
        {
            get { return _METTRN_ApplicationId; }
            set { _METTRN_ApplicationId = value; }
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
        public int METTRN_BillingId
        {
            get { return _METTRN_BillingId; }
            set { _METTRN_BillingId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long METTRN_MeterNo
        {
            get { return _METTRN_MeterNo; }
            set { _METTRN_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METTRN_ReadingDate
        {
            get { return _METTRN_ReadingDate; }
            set { _METTRN_ReadingDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }


        public decimal METTRN_PrevReading
        {
            get { return _METTRN_PrevReading; }
            set { _METTRN_PrevReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METTRN_CollectionDate
        {
            get { return _METTRN_CollectionDate; }
            set { _METTRN_CollectionDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_CreatedByUserID
        {
            get { return _METTRN_CreatedByUserID; }
            set { _METTRN_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METTRN_CreatedDateTime
        {
            get { return _METTRN_CreatedDateTime; }
            set { _METTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_UpdatedByUserID
        {
            get { return _METTRN_UpdatedByUserID; }
            set { _METTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METTRN_UpdatedDateTime
        {
            get { return _METTRN_UpdatedDateTime; }
            set { _METTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_RowStatus
        {
            get { return _METTRN_RowStatus; }
            set { _METTRN_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long METTRN_RowVersion
        {
            get { return _METTRN_RowVersion; }
            set { _METTRN_RowVersion = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METTRN_Remarks
        {
            get { return _METTRN_Remarks; }
            set { _METTRN_Remarks = value; }
        }

        public int METTRN_ISHouseLock
        {
            get { return _METTRN_ISHouseLock; }
            set { _METTRN_ISHouseLock = value; }
        }
    }

    public class BILMeterReadingTRNList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _METTRN_ID;
        private string _APPMST_CustomerID;
        private int _APPMST_AppID;
        private string _CustomerName;
        private string _BCCMST_ShortName;
        private Int64 _CMRMST_MeterNo;
        private decimal _METTRN_CurrentReading;
        private decimal _METTRN_PrevReading;
        private decimal _ConsumedUnit;
        private string _METTRN_ReadingDate;
        private string _METTRN_ISHouseLock;
        private string _METTRN_BillGenerated;
        private Int64 _INVHDR_InvoiceID;
        private string _METTRN_ImageName;
        private string _METTRN_Latitude;
        private string _METTRN_Longitude;
        private string _METTRN_isMismatch;
        private string _METTRN_PhysicalMeterNo;
        private string _METTRN_Remarks;
        private string _METTRN_isFromApp;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingTRNList(int METTRN_ID, string APPMST_CustomerID, int APPMST_AppID, string CustomerName, string BCCMST_ShortName, Int64 CMRMST_MeterNo, 
        decimal METTRN_CurrentReading, decimal METTRN_PrevReading, decimal ConsumedUnit, string METTRN_ReadingDate, string METTRN_ISHouseLock, string METTRN_BillGenerated, 
        Int64 INVHDR_InvoiceID,string METTRN_ImageName,string METTRN_Latitude ,string METTRN_Longitude, string METTRN_isMismatch, string METTRN_PhysicalMeterNo,string METTRN_Remarks,string METTRN_isFromApp, int Count)
        {
            this._METTRN_ID = METTRN_ID;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_AppID = APPMST_AppID;
            this._CustomerName = CustomerName;
            this._BCCMST_ShortName = BCCMST_ShortName;
            this._CMRMST_MeterNo = CMRMST_MeterNo;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
            this._METTRN_PrevReading = METTRN_PrevReading;
            this._ConsumedUnit = ConsumedUnit;
            this._METTRN_ReadingDate = METTRN_ReadingDate;
            this._METTRN_ISHouseLock = METTRN_ISHouseLock;
            this._METTRN_BillGenerated = METTRN_BillGenerated;
            this._INVHDR_InvoiceID = INVHDR_InvoiceID;
            this._METTRN_ImageName = METTRN_ImageName;
            this._METTRN_Latitude = METTRN_Latitude;
            this._METTRN_Longitude = METTRN_Longitude;
            this._METTRN_isMismatch = METTRN_isMismatch;
            this._METTRN_PhysicalMeterNo = METTRN_PhysicalMeterNo;
            this._METTRN_Remarks = METTRN_Remarks;
            this._METTRN_isFromApp = METTRN_isFromApp;

            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_ID
        {
            get { return _METTRN_ID; }
            set { _METTRN_ID = value; }
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
        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int64 CMRMST_MeterNo
        {
            get { return _CMRMST_MeterNo; }
            set { _CMRMST_MeterNo = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }

        public decimal METTRN_PrevReading
        {
            get { return _METTRN_PrevReading; }
            set { _METTRN_PrevReading = value; }
        }

        public decimal ConsumedUnit
        {
            get { return _ConsumedUnit; }
            set { _ConsumedUnit = value; }
        }
        
        public string METTRN_ReadingDate
        {
            get { return _METTRN_ReadingDate; }
            set { _METTRN_ReadingDate = value; }
        }

        public string METTRN_ISHouseLock
        {
            get { return _METTRN_ISHouseLock; }
            set { _METTRN_ISHouseLock = value; }
        }

        public string METTRN_BillGenerated
        {
            get { return _METTRN_BillGenerated; }
            set { _METTRN_BillGenerated = value; }
        }

        public Int64 INVHDR_InvoiceID
        {
            get { return _INVHDR_InvoiceID; }
            set { _INVHDR_InvoiceID = value; }
        }

        public string METTRN_ImageName
        {
            get { return _METTRN_ImageName; }
            set { _METTRN_ImageName = value; }
        }

        public string METTRN_Latitude
        {
            get { return _METTRN_Latitude; }
            set { _METTRN_Latitude = value; }
        }
        public string METTRN_Longitude
        {
            get { return _METTRN_Longitude; }
            set { _METTRN_Longitude = value; }
        }

        public string METTRN_isMismatch
        {
            get { return _METTRN_isMismatch; }
            set { _METTRN_isMismatch = value; }
        }

        public string METTRN_PhysicalMeterNo
        {
            get { return _METTRN_PhysicalMeterNo; }
            set { _METTRN_PhysicalMeterNo = value; }
        }
        public string METTRN_Remarks
        {
            get { return _METTRN_Remarks; }
            set { _METTRN_Remarks = value; }
        }
      
        public string METTRN_isFromApp
        {
            get { return _METTRN_isFromApp; }
            set { _METTRN_isFromApp = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class BILMeterReadingTRN_SelectAll_DetailGrid
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private long _METTRN_ID;
        private int _METTRN_ApplciationID;
        private long _METTRN_MeterNo;
        private decimal _METTRN_PreviousReading;
        private decimal _METTRN_CurrentReading;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingTRN_SelectAll_DetailGrid() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingTRN_SelectAll_DetailGrid(long METTRN_ID, int METTRN_ApplciationID, long METTRN_MeterNo, decimal METTRN_PreviousReading, decimal METTRN_CurrentReading)
        {
            this._METTRN_ID = METTRN_ID;
            this._METTRN_ApplciationID = METTRN_ApplciationID;
            this._METTRN_MeterNo = METTRN_MeterNo;
            this._METTRN_PreviousReading = METTRN_PreviousReading;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long METTRN_ID
        {
            get { return _METTRN_ID; }
            set { _METTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_ApplciationID
        {
            get { return _METTRN_ApplciationID; }
            set { _METTRN_ApplciationID = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long METTRN_MeterNo
        {
            get { return _METTRN_MeterNo; }
            set { _METTRN_MeterNo = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METTRN_PreviousReading
        {
            get { return _METTRN_PreviousReading; }
            set { _METTRN_PreviousReading = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }
    }
    public class BILMeterReadingTRN_PrvReading
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _METTRN_BillingId;
        private decimal _METTRN_MeterNo;
        private decimal _METTRN_CurrentReading;
        private string _BCCMST_ShortName;
        private decimal _PreviouReading;

        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingTRN_PrvReading() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingTRN_PrvReading(int METTRN_BillingId, decimal METTRN_MeterNo, decimal METTRN_CurrentReading, string BCCMST_ShortName, decimal PreviouReading)
        {
            this._METTRN_BillingId = METTRN_BillingId;
            this._METTRN_MeterNo = METTRN_MeterNo;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
            this._BCCMST_ShortName = BCCMST_ShortName;
            this._PreviouReading = PreviouReading;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_BillingId
        {
            get { return _METTRN_BillingId; }
            set { _METTRN_BillingId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METTRN_MeterNo
        {
            get { return _METTRN_MeterNo; }
            set { _METTRN_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PreviouReading
        {
            get { return _PreviouReading; }
            set { _PreviouReading = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>

    }

    public class BILMeterReadingForReadOnlyInfo
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _METTRN_ID;
        // ADDED BY HIMANSHU ON 10-MAY-2010
        private int _BCCMST_BillingID;
        private string _BCCMST_StartDate;
        private string _BCCMST_EndDate;
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _CustomerAddress;
        private int _CD_ControlID;
        private string _CD_ControlType;
        private int _PLAMST_Code;
        private string _PLAMST_PlanName;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingForReadOnlyInfo() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingForReadOnlyInfo(int METTRN_ID, int BCCMST_BillingID, string BCCMST_StartDate, string BCCMST_EndDate, string APPMST_AppNo, string CustomerName, string CustomerAddress, int CD_ControlID, string CD_ControlType, int PLAMST_Code, string PLAMST_PlanName)
        {
            this._METTRN_ID = METTRN_ID;
            this._BCCMST_BillingID = BCCMST_BillingID;
            this._BCCMST_StartDate = BCCMST_StartDate;
            this._BCCMST_EndDate = BCCMST_EndDate;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CustomerName = CustomerName;
            this._CustomerAddress = CustomerAddress;
            this._CD_ControlID = CD_ControlID;
            this._CD_ControlType = CD_ControlType;
            this._PLAMST_Code = PLAMST_Code;
            this._PLAMST_PlanName = PLAMST_PlanName;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_ID
        {
            get { return _METTRN_ID; }
            set { _METTRN_ID = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_BillingID
        {
            get { return _BCCMST_BillingID; }
            set { _BCCMST_BillingID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_StartDate
        {
            get { return _BCCMST_StartDate; }
            set { _BCCMST_StartDate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_EndDate
        {
            get { return _BCCMST_EndDate; }
            set { _BCCMST_EndDate = value; }
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
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerAddress
        {
            get { return _CustomerAddress; }
            set { _CustomerAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_Code
        {
            get { return _PLAMST_Code; }
            set { _PLAMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
    }

    public class PRDExConnReqFormHDRTRNForReadOnlyInfo
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _EXCHDR_ConnID;
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _CustomerAddress;
        private int _CD_ControlID;
        private string _CD_ControlType;
        private int _PLAMST_Code;
        private string _PLAMST_PlanName;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public PRDExConnReqFormHDRTRNForReadOnlyInfo() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDExConnReqFormHDRTRNForReadOnlyInfo(int EXCHDR_ConnID, string APPMST_AppNo, string CustomerName, string CustomerAddress, int CD_ControlID, string CD_ControlType, int PLAMST_Code, string PLAMST_PlanName)
        {
            this._EXCHDR_ConnID = EXCHDR_ConnID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CustomerName = CustomerName;
            this._CustomerAddress = CustomerAddress;
            this._CD_ControlID = CD_ControlID;
            this._CD_ControlType = CD_ControlType;
            this._PLAMST_Code = PLAMST_Code;
            this._PLAMST_PlanName = PLAMST_PlanName;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCHDR_ConnID
        {
            get { return _EXCHDR_ConnID; }
            set { _EXCHDR_ConnID = value; }
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
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerAddress
        {
            get { return _CustomerAddress; }
            set { _CustomerAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_Code
        {
            get { return _PLAMST_Code; }
            set { _PLAMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
    }

    public class BILMeterReadingForReadOnlyInfoForCustomerId
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _METTRN_ID;
        private int _APPMST_AppID;
        private string _APPMST_CustomerId;
        private string _BCCMST_StartDate;
        private string _BCCMST_EndDate;
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _CustomerAddress;
        private int _CD_ControlID;
        private string _CD_ControlType;
        private int _PLAMST_Code;
        private string _PLAMST_PlanName;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingForReadOnlyInfoForCustomerId() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingForReadOnlyInfoForCustomerId(int METTRN_ID, int APPMST_AppID, string APPMST_CustomerId, string BCCMST_StartDate, string BCCMST_EndDate, string APPMST_AppNo, string CustomerName, string CustomerAddress, int CD_ControlID, string CD_ControlType, int PLAMST_Code, string PLAMST_PlanName)
        {
            this._METTRN_ID = METTRN_ID;
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_CustomerId = APPMST_CustomerId;
            this._BCCMST_StartDate = BCCMST_StartDate;
            this._BCCMST_EndDate = BCCMST_EndDate;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CustomerName = CustomerName;
            this._CustomerAddress = CustomerAddress;
            this._CD_ControlID = CD_ControlID;
            this._CD_ControlType = CD_ControlType;
            this._PLAMST_Code = PLAMST_Code;
            this._PLAMST_PlanName = PLAMST_PlanName;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METTRN_ID
        {
            get { return _METTRN_ID; }
            set { _METTRN_ID = value; }
        }

        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_Code
        {
            get { return _PLAMST_Code; }
            set { _PLAMST_Code = value; }
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
        public string APPMST_CustomerId
        {
            get { return _APPMST_CustomerId; }
            set { _APPMST_CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_StartDate
        {
            get { return _BCCMST_StartDate; }
            set { _BCCMST_StartDate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_EndDate
        {
            get { return _BCCMST_EndDate; }
            set { _BCCMST_EndDate = value; }
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
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerAddress
        {
            get { return _CustomerAddress; }
            set { _CustomerAddress = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
    }

    public class BILMeterReadingForBillingCycle
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BCCMST_BillingID;
        private string _BCCMST_ShortName;
        //private string _BCCMST_StartDate;
        //private string _BCCMST_EndDate;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingForBillingCycle() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingForBillingCycle(int BCCMST_BillingID, string BCCMST_ShortName)//, string BCCMST_StartDate, string BCCMST_EndDate)
        {
            this._BCCMST_BillingID = BCCMST_BillingID;
            this._BCCMST_ShortName = BCCMST_ShortName;
            // this._BCCMST_StartDate = BCCMST_StartDate;
            // this._BCCMST_EndDate = BCCMST_EndDate;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_BillingID
        {
            get { return _BCCMST_BillingID; }
            set { _BCCMST_BillingID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }
        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public string BCCMST_StartDate
        //{
        //    get { return _BCCMST_StartDate; }
        //    set { _BCCMST_StartDate = value; }
        //}
        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public string BCCMST_EndDate
        //{
        //    get { return _BCCMST_EndDate; }
        //    set { _BCCMST_EndDate = value; }
        //}
    }

    public class BillingCycleCustomerWise
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private string _yearCycle;

        #endregion

        public string YearCycle
        {
            get { return _yearCycle; }
            set { _yearCycle = value; }
        }
        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BillingCycleCustomerWise() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BillingCycleCustomerWise(string YearCycle)
        {
            this._yearCycle = YearCycle;

        }


    }

    //public class BILMeterReadingForBillingCycleEdit
    //{
    //    /// Class level Local Variables Declaration.
    //    #region "Variables Declaration"
    //    private int _BCCMST_BillingID;
    //    private string _BCCMST_ShortName;
    //    //private string _BCCMST_StartDate;
    //    //private string _BCCMST_EndDate;
    //    #endregion

    //    /// <summary>
    //    /// Default constructor for BILMeterReadingTRN class.
    //    /// </summary>
    //    public BILMeterReadingForBillingCycleEdit() { }

    //    /// <summary>
    //    /// Overloaded constructor for the Branch class.
    //    /// </summary>
    //    public BILMeterReadingForBillingCycleEdit(int BCCMST_BillingID, string BCCMST_ShortName)//, string BCCMST_StartDate, string BCCMST_EndDate)
    //    {
    //        this._BCCMST_BillingID = BCCMST_BillingID;
    //        this._BCCMST_ShortName = BCCMST_ShortName;
    //        // this._BCCMST_StartDate = BCCMST_StartDate;
    //        // this._BCCMST_EndDate = BCCMST_EndDate;
    //    }

    //    /// <summary>
    //    //Write Column Description here. 
    //    /// </summary>
    //    public int BCCMST_BillingID
    //    {
    //        get { return _BCCMST_BillingID; }
    //        set { _BCCMST_BillingID = value; }
    //    }

    //    /// <summary>
    //    //Write Column Description here. 
    //    /// </summary>
    //    public string BCCMST_ShortName
    //    {
    //        get { return _BCCMST_ShortName; }
    //        set { _BCCMST_ShortName = value; }
    //    }
    //    ///// <summary>
    //    ////Write Column Description here. 
    //    ///// </summary>
    //    //public string BCCMST_StartDate
    //    //{
    //    //    get { return _BCCMST_StartDate; }
    //    //    set { _BCCMST_StartDate = value; }
    //    //}
    //    ///// <summary>
    //    ////Write Column Description here. 
    //    ///// </summary>
    //    //public string BCCMST_EndDate
    //    //{
    //    //    get { return _BCCMST_EndDate; }
    //    //    set { _BCCMST_EndDate = value; }
    //    //}
    //}







    public class BILMeterReadingDateForBillingCycle
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BCCMST_BillingID;
        private string _BCCMST_ShortName;
        private string _BCCMST_StartDate;
        private string _BCCMST_EndDate;
        #endregion

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public BILMeterReadingDateForBillingCycle() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILMeterReadingDateForBillingCycle(int BCCMST_BillingID, string BCCMST_ShortName, string BCCMST_StartDate, string BCCMST_EndDate)
        {
            this._BCCMST_BillingID = BCCMST_BillingID;
            this._BCCMST_ShortName = BCCMST_ShortName;
            this._BCCMST_StartDate = BCCMST_StartDate;
            this._BCCMST_EndDate = BCCMST_EndDate;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BCCMST_BillingID
        {
            get { return _BCCMST_BillingID; }
            set { _BCCMST_BillingID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_StartDate
        {
            get { return _BCCMST_StartDate; }
            set { _BCCMST_StartDate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BCCMST_EndDate
        {
            get { return _BCCMST_EndDate; }
            set { _BCCMST_EndDate = value; }
        }
    }











    public class BILMeterReadingTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILMeterReadingTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILMeterReadingTRNMsg(int RetVal, string RetStr)
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
