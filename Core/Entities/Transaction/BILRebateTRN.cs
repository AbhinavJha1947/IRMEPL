//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILRebateTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILRebateTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILRebateTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _REBTRN_ID;
        private decimal _REBTRN_ApplicationId;
        private string _REBTRN_RebateDate;
        private decimal _REBTRN_Rent;
        private decimal _REBTRN_MinCharge;
        private decimal _REBTRN_AMC;
        private decimal _REBTRN_LatePayment;
        private decimal _REBTRN_RebateAmount;
        private decimal _REBTRN_Quantity;
        private int _REBTRN_RebateType;
        private string _REBTRN_Reason;
        private int _REBTRN_AuthorizedBy;
        private int _REBTRN_BillingId;
        private decimal _REBTRN_InvoiceID;
        private int _REBTRN_CreatedByUserID;
        private string _REBTRN_CreatedDateTime;
        private int _REBTRN_UpdatedByUserID;
        private string _REBTRN_UpdatedDateTime;
        private int _REBTRN_RowStatus;
        private long _REBTRN_RowVersion;
        private decimal _INVHDR_RecieptAmount;
        private int _INVHDR_SMSFlag;
        #endregion

        /// <summary>
        /// Default constructor for BILRebateTRN class.
        /// </summary>
        public BILRebateTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILRebateTRN(int REBTRN_ID, decimal REBTRN_ApplicationId, string REBTRN_RebateDate, decimal REBTRN_Rent, decimal REBTRN_MinCharge, decimal REBTRN_AMC, decimal REBTRN_LatePayment, decimal REBTRN_RebateAmount, decimal REBTRN_Quantity, int REBTRN_RebateType, string REBTRN_Reason, int REBTRN_AuthorizedBy, int REBTRN_BillingId, decimal REBTRN_InvoiceID, int REBTRN_CreatedByUserID, string REBTRN_CreatedDateTime, int REBTRN_UpdatedByUserID, string REBTRN_UpdatedDateTime, int REBTRN_RowStatus, long REBTRN_RowVersion, decimal INVHDR_RecieptAmount, int INVHDR_SMSFlag)
        {
            this._REBTRN_ID = REBTRN_ID;
            this._REBTRN_ApplicationId = REBTRN_ApplicationId;
            this._REBTRN_RebateDate = REBTRN_RebateDate;
            this._REBTRN_Rent = REBTRN_Rent;
            this._REBTRN_MinCharge = REBTRN_MinCharge;
            this._REBTRN_AMC = REBTRN_AMC;
            this._REBTRN_LatePayment = REBTRN_LatePayment;
            this._REBTRN_RebateAmount = REBTRN_RebateAmount;
            this._REBTRN_Quantity = REBTRN_Quantity;
            this._REBTRN_RebateType = REBTRN_RebateType;
            this._REBTRN_Reason = REBTRN_Reason;
            this._REBTRN_AuthorizedBy = REBTRN_AuthorizedBy;
            this._REBTRN_BillingId = REBTRN_BillingId;
            this._REBTRN_InvoiceID = REBTRN_InvoiceID;
            this._REBTRN_CreatedByUserID = REBTRN_CreatedByUserID;
            this._REBTRN_CreatedDateTime = REBTRN_CreatedDateTime;
            this._REBTRN_UpdatedByUserID = REBTRN_UpdatedByUserID;
            this._REBTRN_UpdatedDateTime = REBTRN_UpdatedDateTime;
            this._REBTRN_RowStatus = REBTRN_RowStatus;
            this._REBTRN_RowVersion = REBTRN_RowVersion;
            this._INVHDR_RecieptAmount = INVHDR_RecieptAmount;
            this._INVHDR_SMSFlag = INVHDR_SMSFlag;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_ID
        {
            get { return _REBTRN_ID; }
            set { _REBTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_ApplicationId
        {
            get { return _REBTRN_ApplicationId; }
            set { _REBTRN_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REBTRN_RebateDate
        {
            get { return _REBTRN_RebateDate; }
            set { _REBTRN_RebateDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_Rent
        {
            get { return _REBTRN_Rent; }
            set { _REBTRN_Rent = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_MinCharge
        {
            get { return _REBTRN_MinCharge; }
            set { _REBTRN_MinCharge = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_AMC
        {
            get { return _REBTRN_AMC; }
            set { _REBTRN_AMC = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_LatePayment
        {
            get { return _REBTRN_LatePayment; }
            set { _REBTRN_LatePayment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_RebateAmount
        {
            get { return _REBTRN_RebateAmount; }
            set { _REBTRN_RebateAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_Quantity
        {
            get { return _REBTRN_Quantity; }
            set { _REBTRN_Quantity = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_RebateType
        {
            get { return _REBTRN_RebateType; }
            set { _REBTRN_RebateType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REBTRN_Reason
        {
            get { return _REBTRN_Reason; }
            set { _REBTRN_Reason = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_AuthorizedBy
        {
            get { return _REBTRN_AuthorizedBy; }
            set { _REBTRN_AuthorizedBy = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_BillingId
        {
            get { return _REBTRN_BillingId; }
            set { _REBTRN_BillingId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REBTRN_InvoiceID
        {
            get { return _REBTRN_InvoiceID; }
            set { _REBTRN_InvoiceID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_CreatedByUserID
        {
            get { return _REBTRN_CreatedByUserID; }
            set { _REBTRN_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REBTRN_CreatedDateTime
        {
            get { return _REBTRN_CreatedDateTime; }
            set { _REBTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_UpdatedByUserID
        {
            get { return _REBTRN_UpdatedByUserID; }
            set { _REBTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REBTRN_UpdatedDateTime
        {
            get { return _REBTRN_UpdatedDateTime; }
            set { _REBTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REBTRN_RowStatus
        {
            get { return _REBTRN_RowStatus; }
            set { _REBTRN_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long REBTRN_RowVersion
        {
            get { return _REBTRN_RowVersion; }
            set { _REBTRN_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_RecieptAmount
        {
            get { return _INVHDR_RecieptAmount; }
            set { _INVHDR_RecieptAmount = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_SMSFlag
        {
            get { return _INVHDR_SMSFlag; }
            set { _INVHDR_SMSFlag = value; }
        }
    }

    public class BILRebateTRNList
    {
        #region "Variables Declaration"
        private int _REBTRN_ID;
        private string _KeyField;
        private string _REBTRN_RebateDate;
        private string _CustomerID;
        private string _ApplicationNo;
        private string _CustomerName;
        private string _CustomerType;
        private string _BillingCycle;
        private string _Area;
        private decimal _REBTRN_RebateAmount;
        private string _RebateType;
        private string _REBTRN_Reason;
        private string _AuthorizedBy;
        private int _Count;
        #endregion
        public BILRebateTRNList() { }
        public BILRebateTRNList(int REBTRN_ID, string KeyField, string REBTRN_RebateDate, string CustomerID, string ApplicationNo, string CustomerName, string Area, string CustomerType, string BillingCycle, decimal REBTRN_RebateAmount, string RebateType, string REBTRN_Reason, string AuthorizedBy, int Count)
        {
            this._REBTRN_ID = REBTRN_ID;
            this._KeyField = KeyField;
            this._REBTRN_RebateDate = REBTRN_RebateDate;
            this._CustomerID = CustomerID;
            this._ApplicationNo = ApplicationNo;
            this._CustomerName = CustomerName;
            this._Area = Area;
            this._CustomerType = CustomerType;
            this._BillingCycle = BillingCycle;
            this._REBTRN_RebateAmount = REBTRN_RebateAmount;
            this._RebateType = RebateType;
            this._REBTRN_Reason = REBTRN_Reason;
            this._AuthorizedBy = AuthorizedBy;

            this._Count = Count;
        }

        public int REBTRN_ID
        {
            get { return _REBTRN_ID; }
            set { _REBTRN_ID = value; }
        }

        public string KeyField
        {
            get { return _KeyField; }
            set { _KeyField = value; }
        }

        public string REBTRN_RebateDate
        {
            get { return _REBTRN_RebateDate; }
            set { _REBTRN_RebateDate = value; }
        }

        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
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

        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        public string CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }

        public string BillingCycle
        {
            get { return _BillingCycle; }
            set { _BillingCycle = value; }
        }

        public decimal REBTRN_RebateAmount
        {
            get { return _REBTRN_RebateAmount; }
            set { _REBTRN_RebateAmount = value; }
        }

        public string RebateType
        {
            get { return _RebateType; }
            set { _RebateType = value; }
        }

        public string REBTRN_Reason
        {
            get { return _REBTRN_Reason; }
            set { _REBTRN_Reason = value; }
        }

        public string AuthorizedBy
        {
            get { return _AuthorizedBy; }
            set { _AuthorizedBy = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    //---------------------------Added by Divya-------------------------------------------------------------------------------------------

    public class BillLeakageRebateUnit
    {
        #region "Variables Declaration"
        private int _TariffID;
        private decimal _RateUnit;
        #endregion
        public BillLeakageRebateUnit() { }
        public BillLeakageRebateUnit(int TariffID, decimal RateUnit)
        {
            this._TariffID = TariffID;
            this._RateUnit = RateUnit;
        }

        public decimal RateUnit
        {
            get { return _RateUnit; }
            set { _RateUnit = value; }
        }
        public int TariffID
        {
            get { return _TariffID; }
            set { _TariffID = value; }
        }

    }
    public class BillLeakageRebateUnitMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BillLeakageRebateUnitMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BillLeakageRebateUnitMsg(int RetVal, string RetStr)
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
    public class BILLeakageRebateTRN
    {
        #region "Variables Declaration"
        private int _rowno;
        private int _LRD_BillingCycleID;
        private string _LRD_BillingCycleName;
        private decimal _LRD_ConsumedUnit;
        private decimal _LRD_CumulativeReading;
        private string _LRD_ReadingDate;
        private string _PreReadingDate;
        private int _LRD_NoOfDays;
        private int _LRD_ExtraID;
        private string _LRD_Remarks;

        private int _Count;

        #endregion
        public BILLeakageRebateTRN() { }
        public BILLeakageRebateTRN(int rowno, int LRD_BillingCycleID, string LRD_BillingCycleName, decimal LRD_ConsumedUnit, decimal LRD_CumulativeReading, string PreReadingDate, string LRD_ReadingDate, int LRD_NoOfDays, string LRD_Remarks, int Count, int LRD_ExtraID)
        {
            this._rowno = rowno;
            this._LRD_BillingCycleID = LRD_BillingCycleID;
            this._LRD_BillingCycleName = LRD_BillingCycleName;
            this._LRD_ConsumedUnit = LRD_ConsumedUnit;
            this._LRD_CumulativeReading = LRD_CumulativeReading;
            this._LRD_ReadingDate = LRD_ReadingDate;
            this._PreReadingDate = PreReadingDate;
            this._LRD_NoOfDays = LRD_NoOfDays;
            this._LRD_Remarks = LRD_Remarks;
            this._Count = Count;
            this._LRD_ExtraID = LRD_ExtraID;
        }

        public int rowno
        {
            get { return _rowno; }
            set { _rowno = value; }
        }
        public int LRD_ExtraID
        {
            get { return _LRD_ExtraID; }
            set { _LRD_ExtraID = value; }
        }

        public int LRD_BillingCycleID
        {
            get { return _LRD_BillingCycleID; }
            set { _LRD_BillingCycleID = value; }
        }

        public string PreReadingDate
        {
            get { return _PreReadingDate; }
            set { _PreReadingDate = value; }
        }

        public string LRD_BillingCycleName
        {
            get { return _LRD_BillingCycleName; }
            set { _LRD_BillingCycleName = value; }
        }

        public decimal LRD_ConsumedUnit
        {
            get { return _LRD_ConsumedUnit; }
            set { _LRD_ConsumedUnit = value; }
        }
        public decimal LRD_CumulativeReading
        {
            get { return _LRD_CumulativeReading; }
            set { _LRD_CumulativeReading = value; }
        }

        public string LRD_ReadingDate
        {
            get { return _LRD_ReadingDate; }
            set { _LRD_ReadingDate = value; }
        }

        public int LRD_NoOfDays
        {
            get { return _LRD_NoOfDays; }
            set { _LRD_NoOfDays = value; }
        }

        public string LRD_Remarks
        {
            get { return _LRD_Remarks; }
            set { _LRD_Remarks = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }
    public class BILLeakageRebateTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILLeakageRebateTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILLeakageRebateTRNMsg(int RetVal, string RetStr)
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
    public class BILLeakageRebateHDR
    {
        #region "Variables Declaration"
        private int _LRH_ID;
        private int _LRH_AppID;
        private string _LRH_CustomerID;
        private string _LRH_CustomerName;
        private string _LRH_CustomerAddress;
        private string _LRH_ComplainNo;
        private string _LRH_ComplainDate;
        private string _LRH_ComplaintResolvedDate;
        private string _LRH_CommisionDate;
        private int _LRH_ProjectContractor;
        private int _LRH_DLPPeriodApplicable;
        private int _LRH_TerrifID;
        private decimal _LRH_UnitRate;
        private decimal _LRH_RebeatUnit;
        private decimal _LRH_RebeatAmount;
        private string _LRH_Reason;
        private int _LRH_CreatedByID;
        private int _LRH_UpdatedById;
        private int _LRH_RowStatus;
        private int _Count;
        //------------------------------
        private string _LRH_StartDate;
        private string _LRH_EndDate;
        private decimal _LRH_AvgPerDayCURegularP;
        private decimal _LRH_AvgPerDayCULeakageP;
        private decimal _LRH_LeakagePeriodCU;
        private int _LRH_LeakagePeriodDays;
        private decimal _LRH_LeakageAmount;
        private decimal _LRH_ActualConUnit;
        private decimal _LRH_ActualAmount;
        private decimal _LRH_RegularPeriodCU;
        private int _LRH_RegularPeriodDays;

        #endregion
        public BILLeakageRebateHDR() { }
        public BILLeakageRebateHDR(int LRH_ID, int LRH_AppID, string LRH_CustomerID, string LRH_CustomerName, string LRH_CustomerAddress, string LRH_ComplainNo, string LRH_ComplainDate, string LRH_ComplaintResolvedDate, string LRH_CommisionDate, int LRH_ProjectContractor, int LRH_DLPPeriodApplicable, int LRH_TerrifID, decimal LRH_UnitRate, decimal LRH_RebeatUnit, decimal LRH_RebeatAmount, string LRH_Reason, string LRH_StartDate, string LRH_EndDate, decimal LRH_AvgPerDayCURegularP, decimal LRH_AvgPerDayCULeakageP, decimal LRH_LeakagePeriodCU, int LRH_LeakagePeriodDays, decimal LRH_LeakageAmount, decimal LRH_ActualConUnit, decimal LRH_ActualAmount, decimal LRH_RegularPeriodCU, int LRH_RegularPeriodDays, int LRH_CreatedByID, int LRH_UpdatedById, int LRH_RowStatus, int Count)
        {
            this._LRH_ID = LRH_ID;
            this._LRH_AppID = LRH_AppID;
            this._LRH_CustomerID = LRH_CustomerID;
            this._LRH_ComplainNo = LRH_ComplainNo;
            this._LRH_ComplainDate = LRH_ComplainDate;
            this._LRH_ComplaintResolvedDate = LRH_ComplaintResolvedDate;
            this._LRH_CommisionDate = LRH_CommisionDate;
            this._LRH_ProjectContractor = LRH_ProjectContractor;
            this._LRH_DLPPeriodApplicable = LRH_DLPPeriodApplicable;
            this._LRH_TerrifID = LRH_TerrifID;
            this._LRH_UnitRate = LRH_UnitRate;
            this._LRH_RebeatUnit = LRH_RebeatUnit;
            this._LRH_RebeatAmount = LRH_RebeatAmount;
            this._LRH_Reason = LRH_Reason;
            this._LRH_CreatedByID = LRH_CreatedByID;
            this._LRH_UpdatedById = LRH_UpdatedById;
            this._LRH_RowStatus = LRH_RowStatus;
            this._Count = Count;
            this._LRH_CustomerName = LRH_CustomerName;
            this._LRH_CustomerAddress = LRH_CustomerAddress;
            //----------------------
            this._LRH_StartDate = LRH_StartDate;
            this._LRH_EndDate = LRH_EndDate;
            this._LRH_AvgPerDayCURegularP = LRH_AvgPerDayCURegularP;
            this._LRH_AvgPerDayCULeakageP = LRH_AvgPerDayCULeakageP;
            this._LRH_LeakagePeriodCU = LRH_LeakagePeriodCU;
            this._LRH_LeakagePeriodDays = LRH_LeakagePeriodDays;
            this._LRH_LeakageAmount = LRH_LeakageAmount;
            this._LRH_ActualConUnit = LRH_ActualConUnit;
            this._LRH_ActualAmount = LRH_ActualAmount;
            this._LRH_RegularPeriodCU = LRH_RegularPeriodCU;
            this._LRH_RegularPeriodDays = LRH_RegularPeriodDays;
        }
        public int LRH_RowStatus
        {
            get { return _LRH_RowStatus; }
            set { _LRH_RowStatus = value; }
        }
        public int LRH_ID
        {
            get { return _LRH_ID; }
            set { _LRH_ID = value; }
        }
        public int LRH_AppID
        {
            get { return _LRH_AppID; }
            set { _LRH_AppID = value; }
        }
        public string LRH_CustomerID
        {
            get { return _LRH_CustomerID; }
            set { _LRH_CustomerID = value; }
        }
        public string LRH_CustomerAddress
        {
            get { return _LRH_CustomerAddress; }
            set { _LRH_CustomerAddress = value; }
        }
        public string LRH_CustomerName
        {
            get { return _LRH_CustomerName; }
            set { _LRH_CustomerName = value; }
        }
        public string LRH_ComplainNo
        {
            get { return _LRH_ComplainNo; }
            set { _LRH_ComplainNo = value; }
        }
        public string LRH_ComplainDate
        {
            get { return _LRH_ComplainDate; }
            set { _LRH_ComplainDate = value; }
        }
        public string LRH_ComplaintResolvedDate
        {
            get { return _LRH_ComplaintResolvedDate; }
            set { _LRH_ComplaintResolvedDate = value; }
        }
        public string LRH_CommisionDate
        {
            get { return _LRH_CommisionDate; }
            set { _LRH_CommisionDate = value; }
        }
        public int LRH_ProjectContractor
        {
            get { return _LRH_ProjectContractor; }
            set { _LRH_ProjectContractor = value; }
        }
        public int LRH_DLPPeriodApplicable
        {
            get { return _LRH_DLPPeriodApplicable; }
            set { _LRH_DLPPeriodApplicable = value; }
        }
        public int LRH_TerrifID
        {
            get { return _LRH_TerrifID; }
            set { _LRH_TerrifID = value; }
        }
        public decimal LRH_UnitRate
        {
            get { return _LRH_UnitRate; }
            set { _LRH_UnitRate = value; }
        }
        public decimal LRH_RebeatUnit
        {
            get { return _LRH_RebeatUnit; }
            set { _LRH_RebeatUnit = value; }
        }
        public decimal LRH_RebeatAmount
        {
            get { return _LRH_RebeatAmount; }
            set { _LRH_RebeatAmount = value; }
        }
        //---------------------------------
        public string LRH_StartDate
        {
            get { return _LRH_StartDate; }
            set { _LRH_StartDate = value; }
        }
        public string LRH_EndDate
        {
            get { return _LRH_EndDate; }
            set { _LRH_EndDate = value; }
        }
        public decimal LRH_AvgPerDayCURegularP
        {
            get { return _LRH_AvgPerDayCURegularP; }
            set { _LRH_AvgPerDayCURegularP = value; }
        }
        public decimal LRH_AvgPerDayCULeakageP
        {
            get { return _LRH_AvgPerDayCULeakageP; }
            set { _LRH_AvgPerDayCULeakageP = value; }
        }
        public decimal LRH_LeakagePeriodCU
        {
            get { return _LRH_LeakagePeriodCU; }
            set { _LRH_LeakagePeriodCU = value; }
        }
        public int LRH_LeakagePeriodDays
        {
            get { return _LRH_LeakagePeriodDays; }
            set { _LRH_LeakagePeriodDays = value; }
        }
        public decimal LRH_LeakageAmount
        {
            get { return _LRH_LeakageAmount; }
            set { _LRH_LeakageAmount = value; }
        }
        public decimal LRH_ActualConUnit
        {
            get { return _LRH_ActualConUnit; }
            set { _LRH_ActualConUnit = value; }
        }
        public decimal LRH_ActualAmount
        {
            get { return _LRH_ActualAmount; }
            set { _LRH_ActualAmount = value; }
        }
        public decimal LRH_RegularPeriodCU
        {
            get { return _LRH_RegularPeriodCU; }
            set { _LRH_RegularPeriodCU = value; }
        }
        public int LRH_RegularPeriodDays
        {
            get { return _LRH_RegularPeriodDays; }
            set { _LRH_RegularPeriodDays = value; }
        }
        //---------------------------------

        public string LRH_Reason
        {
            get { return _LRH_Reason; }
            set { _LRH_Reason = value; }
        }
        public int LRH_CreatedByID
        {
            get { return _LRH_CreatedByID; }
            set { _LRH_CreatedByID = value; }
        }
        public int LRH_UpdatedById
        {
            get { return _LRH_UpdatedById; }
            set { _LRH_UpdatedById = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }
    public class BILLeakageRebateHDRMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILLeakageRebateHDRMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILLeakageRebateHDRMsg(int RetVal, string RetStr)
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
    public class BILLeakageRebateDTLMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILLeakageRebateDTLMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILLeakageRebateDTLMsg(int RetVal, string RetStr)
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
    public class BILLeakageRebateDTL
    {
        #region "Variables Declaration"

        private int _LRD_ID;
        private int _LRD_LRHID;
        private int _LRD_BillingCycleID;
        private string _LRD_BillingCycleName;
        private decimal _LRD_ConsumedUnit;
        private decimal _LRD_CumulativeReading;
        private string _LRD_ReadingDate;
        private string _PreReadingDate;
        private int _LRD_NoOfDays;
        private string _LRD_Remarks;
        private int _LRD_CreatedByUserID;
        private int _LRD_UpdatedByID;
        private int _LRD_RowStatus;
        private int _LRD_ExtraID;
        private int _Count;

        #endregion
        public BILLeakageRebateDTL() { }
        public BILLeakageRebateDTL(int LRD_ID, int LRD_LRHID, int LRD_BillingCycleID, string LRD_BillingCycleName, decimal LRD_ConsumedUnit, decimal LRD_CumulativeReading, string LRD_ReadingDate, string PreReadingDate, int LRD_NoOfDays, string LRD_Remarks, int LRD_CreatedByUserID, int LRD_UpdatedByID, int LRD_RowStatus, int LRD_ExtraID, int Count)
        {
            this._LRD_ID = LRD_ID;
            this._LRD_LRHID = LRD_LRHID;
            this._LRD_BillingCycleID = LRD_BillingCycleID;
            this._LRD_BillingCycleName = LRD_BillingCycleName;
            this._LRD_ConsumedUnit = LRD_ConsumedUnit;
            this._LRD_CumulativeReading = LRD_CumulativeReading;
            this._LRD_ReadingDate = LRD_ReadingDate;
            this._PreReadingDate = PreReadingDate;
            this._LRD_NoOfDays = LRD_NoOfDays;
            this._LRD_Remarks = LRD_Remarks;
            this._LRD_CreatedByUserID = LRD_CreatedByUserID;
            this._LRD_UpdatedByID = LRD_UpdatedByID;
            this._LRD_RowStatus = LRD_RowStatus;
            this._LRD_ExtraID = LRD_ExtraID;
            this._Count = Count;
        }

        public int LRD_ID
        {
            get { return _LRD_ID; }
            set { _LRD_ID = value; }
        }
        public int LRD_NoOfDays
        {
            get { return _LRD_NoOfDays; }
            set { _LRD_NoOfDays = value; }
        }
        public string LRD_Remarks
        {
            get { return _LRD_Remarks; }
            set { _LRD_Remarks = value; }
        }
        public int LRD_LRHID
        {
            get { return _LRD_LRHID; }
            set { _LRD_LRHID = value; }
        }

        public int LRD_BillingCycleID
        {
            get { return _LRD_BillingCycleID; }
            set { _LRD_BillingCycleID = value; }
        }

        public string LRD_BillingCycleName
        {
            get { return _LRD_BillingCycleName; }
            set { _LRD_BillingCycleName = value; }
        }
        public decimal LRD_ConsumedUnit
        {
            get { return _LRD_ConsumedUnit; }
            set { _LRD_ConsumedUnit = value; }
        }

        public decimal LRD_CumulativeReading
        {
            get { return _LRD_CumulativeReading; }
            set { _LRD_CumulativeReading = value; }
        }
        public string PreReadingDate
        {
            get { return _PreReadingDate; }
            set { _PreReadingDate = value; }
        }
        public string LRD_ReadingDate
        {
            get { return _LRD_ReadingDate; }
            set { _LRD_ReadingDate = value; }
        }

        public int LRD_CreatedByUserID
        {
            get { return _LRD_CreatedByUserID; }
            set { _LRD_CreatedByUserID = value; }
        }
        public int LRD_UpdatedByID
        {
            get { return _LRD_UpdatedByID; }
            set { _LRD_UpdatedByID = value; }
        }

        public int LRD_RowStatus
        {
            get { return _LRD_RowStatus; }
            set { _LRD_RowStatus = value; }
        }
        public int LRD_ExtraID
        {
            get { return _LRD_ExtraID; }
            set { _LRD_ExtraID = value; }
        }


        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------
    public class BILRebateTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILRebateTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILRebateTRNMsg(int RetVal, string RetStr)
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
