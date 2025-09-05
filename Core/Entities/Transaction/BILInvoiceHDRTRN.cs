//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILInvoiceHDRTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILInvoiceHDRTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILInvoiceHDRTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _INVHDR_InvoiceID;
        private string _INVHDR_InvNo;
        private string _INVHDR_InvDate;
        private int _INVHDR_ApplicationId;
        private int _INVHDR_BillingId;
        private int _INVHDR_PlanId;
        private long _INVHDR_MeterNo;
        private decimal _INVHDR_CurrentReading;
        private decimal _INVHDR_PreviousReading;
        private decimal _INVHDR_RebateQty;
        private decimal _INVHDR_ConsumedUnit;
        private decimal _INVHDR_GasAmount;
        private decimal _INVHDR_MinUnit;
        private decimal _INVHDR_Mincharges;
        private decimal _INVHDR_Rent;
        private decimal _INVHDR_AMC;
        private decimal _INVHDR_RebateAmount;
        private decimal _INVHDR_NetTotal;
        private decimal _INVHDR_PreviousBalance;
        private decimal _INVHDR_PLatePayment;
        private decimal _INVHDR_LatePayment;
        private decimal _INVHDR_RecieptAmount;
        private decimal _INVHDR_ClosingBalance;
        private decimal _INVHDR_InstallmentAmount;
        private decimal _INVHDR_DebitNoteAmount;
        private decimal _INVHDR_SecurityDeposit;
        private decimal _INVHDR_ChequeBounceCharges;
        private string _INVHDR_AmountinWords;
        private int _INVHDR_CustomerType;
        private int _INVHDR_CreatedByUserID;
        private string _INVHDR_CreatedDateTime;
        private int _INVHDR_UpdatedByUserID;
        private string _INVHDR_UpdatedDateTime;
        private int _INVHDR_RowStatus;
        private long _INVHDR_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for BILInvoiceHDRTRN class.
        /// </summary>
        public BILInvoiceHDRTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILInvoiceHDRTRN(int INVHDR_InvoiceID, string INVHDR_InvNo, string INVHDR_InvDate, int INVHDR_ApplicationId, int INVHDR_BillingId, int INVHDR_PlanId, long INVHDR_MeterNo, decimal INVHDR_CurrentReading, decimal INVHDR_PreviousReading, decimal INVHDR_RebateQty, decimal INVHDR_ConsumedUnit, decimal INVHDR_GasAmount, decimal INVHDR_MinUnit, decimal INVHDR_Mincharges, decimal INVHDR_Rent, decimal INVHDR_AMC, decimal INVHDR_RebateAmount, decimal INVHDR_NetTotal, decimal INVHDR_PreviousBalance, decimal INVHDR_PLatePayment, decimal INVHDR_LatePayment, decimal INVHDR_RecieptAmount, decimal INVHDR_ClosingBalance, decimal INVHDR_InstallmentAmount, decimal INVHDR_DebitNoteAmount, decimal INVHDR_SecurityDeposit, decimal INVHDR_ChequeBounceCharges, string INVHDR_AmountinWords, int INVHDR_CustomerType, int INVHDR_CreatedByUserID, string INVHDR_CreatedDateTime, int INVHDR_UpdatedByUserID, string INVHDR_UpdatedDateTime, int INVHDR_RowStatus, long INVHDR_RowVersion)
        {
            this._INVHDR_InvoiceID = INVHDR_InvoiceID;
            this._INVHDR_InvNo = INVHDR_InvNo;
            this._INVHDR_InvDate = INVHDR_InvDate;
            this._INVHDR_ApplicationId = INVHDR_ApplicationId;
            this._INVHDR_BillingId = INVHDR_BillingId;
            this._INVHDR_PlanId = INVHDR_PlanId;
            this._INVHDR_MeterNo = INVHDR_MeterNo;
            this._INVHDR_CurrentReading = INVHDR_CurrentReading;
            this._INVHDR_PreviousReading = INVHDR_PreviousReading;
            this._INVHDR_RebateQty = INVHDR_RebateQty;
            this._INVHDR_ConsumedUnit = INVHDR_ConsumedUnit;
            this._INVHDR_GasAmount = INVHDR_GasAmount;
            this._INVHDR_MinUnit = INVHDR_MinUnit;
            this._INVHDR_Mincharges = INVHDR_Mincharges;
            this._INVHDR_Rent = INVHDR_Rent;
            this._INVHDR_AMC = INVHDR_AMC;
            this._INVHDR_RebateAmount = INVHDR_RebateAmount;
            this._INVHDR_NetTotal = INVHDR_NetTotal;
            this._INVHDR_PreviousBalance = INVHDR_PreviousBalance;
            this._INVHDR_PLatePayment = INVHDR_PLatePayment;
            this._INVHDR_LatePayment = INVHDR_LatePayment;
            this._INVHDR_RecieptAmount = INVHDR_RecieptAmount;
            this._INVHDR_ClosingBalance = INVHDR_ClosingBalance;
            this._INVHDR_InstallmentAmount = INVHDR_InstallmentAmount;
            this._INVHDR_DebitNoteAmount = INVHDR_DebitNoteAmount;
            this._INVHDR_SecurityDeposit = INVHDR_SecurityDeposit;
            this._INVHDR_ChequeBounceCharges = INVHDR_ChequeBounceCharges;
            this._INVHDR_AmountinWords = INVHDR_AmountinWords;
            this._INVHDR_CustomerType = INVHDR_CustomerType;
            this._INVHDR_CreatedByUserID = INVHDR_CreatedByUserID;
            this._INVHDR_CreatedDateTime = INVHDR_CreatedDateTime;
            this._INVHDR_UpdatedByUserID = INVHDR_UpdatedByUserID;
            this._INVHDR_UpdatedDateTime = INVHDR_UpdatedDateTime;
            this._INVHDR_RowStatus = INVHDR_RowStatus;
            this._INVHDR_RowVersion = INVHDR_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_InvoiceID
        {
            get { return _INVHDR_InvoiceID; }
            set { _INVHDR_InvoiceID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvNo
        {
            get { return _INVHDR_InvNo; }
            set { _INVHDR_InvNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvDate
        {
            get { return _INVHDR_InvDate; }
            set { _INVHDR_InvDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_ApplicationId
        {
            get { return _INVHDR_ApplicationId; }
            set { _INVHDR_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_BillingId
        {
            get { return _INVHDR_BillingId; }
            set { _INVHDR_BillingId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_PlanId
        {
            get { return _INVHDR_PlanId; }
            set { _INVHDR_PlanId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long INVHDR_MeterNo
        {
            get { return _INVHDR_MeterNo; }
            set { _INVHDR_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_CurrentReading
        {
            get { return _INVHDR_CurrentReading; }
            set { _INVHDR_CurrentReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_PreviousReading
        {
            get { return _INVHDR_PreviousReading; }
            set { _INVHDR_PreviousReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_RebateQty
        {
            get { return _INVHDR_RebateQty; }
            set { _INVHDR_RebateQty = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_ConsumedUnit
        {
            get { return _INVHDR_ConsumedUnit; }
            set { _INVHDR_ConsumedUnit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_GasAmount
        {
            get { return _INVHDR_GasAmount; }
            set { _INVHDR_GasAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_MinUnit
        {
            get { return _INVHDR_MinUnit; }
            set { _INVHDR_MinUnit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_Mincharges
        {
            get { return _INVHDR_Mincharges; }
            set { _INVHDR_Mincharges = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_Rent
        {
            get { return _INVHDR_Rent; }
            set { _INVHDR_Rent = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_AMC
        {
            get { return _INVHDR_AMC; }
            set { _INVHDR_AMC = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_RebateAmount
        {
            get { return _INVHDR_RebateAmount; }
            set { _INVHDR_RebateAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_NetTotal
        {
            get { return _INVHDR_NetTotal; }
            set { _INVHDR_NetTotal = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_PreviousBalance
        {
            get { return _INVHDR_PreviousBalance; }
            set { _INVHDR_PreviousBalance = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_PLatePayment
        {
            get { return _INVHDR_PLatePayment; }
            set { _INVHDR_PLatePayment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_LatePayment
        {
            get { return _INVHDR_LatePayment; }
            set { _INVHDR_LatePayment = value; }
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
        public decimal INVHDR_ClosingBalance
        {
            get { return _INVHDR_ClosingBalance; }
            set { _INVHDR_ClosingBalance = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_InstallmentAmount
        {
            get { return _INVHDR_InstallmentAmount; }
            set { _INVHDR_InstallmentAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_DebitNoteAmount
        {
            get { return _INVHDR_DebitNoteAmount; }
            set { _INVHDR_DebitNoteAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_SecurityDeposit
        {
            get { return _INVHDR_SecurityDeposit; }
            set { _INVHDR_SecurityDeposit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_ChequeBounceCharges
        {
            get { return _INVHDR_ChequeBounceCharges; }
            set { _INVHDR_ChequeBounceCharges = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_AmountinWords
        {
            get { return _INVHDR_AmountinWords; }
            set { _INVHDR_AmountinWords = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_CustomerType
        {
            get { return _INVHDR_CustomerType; }
            set { _INVHDR_CustomerType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_CreatedByUserID
        {
            get { return _INVHDR_CreatedByUserID; }
            set { _INVHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_CreatedDateTime
        {
            get { return _INVHDR_CreatedDateTime; }
            set { _INVHDR_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_UpdatedByUserID
        {
            get { return _INVHDR_UpdatedByUserID; }
            set { _INVHDR_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_UpdatedDateTime
        {
            get { return _INVHDR_UpdatedDateTime; }
            set { _INVHDR_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_RowStatus
        {
            get { return _INVHDR_RowStatus; }
            set { _INVHDR_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long INVHDR_RowVersion
        {
            get { return _INVHDR_RowVersion; }
            set { _INVHDR_RowVersion = value; }
        }

    }

    
    public class BILInvoiceHDRTRN_Insert
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _INVHDR_BillingId;
        private string _INVHDR_CustomerId;
        private int _INVHDR_AreaCode;
        private string _INVHDR_InvDate;
        private int _INVHDR_CreatedByUserID;
        private string _INVHDR_CreatedDateTime;
        private int _INVHDR_SMSFlag;
        private int _blnGetOutput;
        private int _INVHDR_GeneratedFrom;
        #endregion

        /// <summary>
        /// Default constructor for BILInvoiceHDRTRN class.
        /// </summary>
        public BILInvoiceHDRTRN_Insert() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILInvoiceHDRTRN_Insert(int INVHDR_BillingId, string INVHDR_CustomerId, int INVHDR_AreaCode, string INVHDR_InvDate, int INVHDR_CreatedByUserID, string INVHDR_CreatedDateTime, int blnGetOutput, int INVHDR_SMSFlag, int INVHDR_GeneratedFrom)
        {
            this._INVHDR_BillingId = INVHDR_BillingId;
            this._INVHDR_CustomerId = INVHDR_CustomerId;
            this._INVHDR_AreaCode = INVHDR_AreaCode;
            this._INVHDR_InvDate = INVHDR_InvDate;
            this._INVHDR_CreatedByUserID = INVHDR_CreatedByUserID;
            this._INVHDR_CreatedDateTime = INVHDR_CreatedDateTime;
            this._blnGetOutput = blnGetOutput;
            this._INVHDR_SMSFlag = INVHDR_SMSFlag;
            this._INVHDR_GeneratedFrom = INVHDR_GeneratedFrom;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_BillingId
        {
            get { return _INVHDR_BillingId; }
            set { _INVHDR_BillingId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_CustomerId
        {
            get { return _INVHDR_CustomerId; }
            set { _INVHDR_CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_AreaCode
        {
            get { return _INVHDR_AreaCode; }
            set { _INVHDR_AreaCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvDate
        {
            get { return _INVHDR_InvDate; }
            set { _INVHDR_InvDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_CreatedByUserID
        {
            get { return _INVHDR_CreatedByUserID; }
            set { _INVHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_CreatedDateTime
        {
            get { return _INVHDR_CreatedDateTime; }
            set { _INVHDR_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int blnGetOutput
        {
            get { return _blnGetOutput; }
            set { _blnGetOutput = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_SMSFlag
        {
            get { return _INVHDR_SMSFlag; }
            set { _INVHDR_SMSFlag = value; }
        }

        public int INVHDR_GeneratedFrom
        {
            get { return _INVHDR_GeneratedFrom; }
            set { _INVHDR_GeneratedFrom = value; }
        }

    }

    public class BILInvoiceHDRTRNList
    {
        #region "Variables Declaration"
        protected int _INVHDR_InvoiceID;
        protected string _INVHDR_InvNo;
        protected string _BillingCycle;
        protected string _Customer_Id;
        protected string _Name;
        protected decimal _INVHDR_ConsumedUnit;
        protected decimal _INVHDR_GasPrice;
        protected decimal _INVHDR_GasAmount;
        protected decimal _INVHDR_MinUnit;
        protected decimal _INVHDR_MinCharges;
        protected decimal _INVHDR_Rent;
        protected decimal _INVHDR_AMC;
        protected decimal _RebateAmount;
        protected decimal _NetTotal;
        protected decimal _RoundOff;
        protected decimal _Previousbalance;
        protected decimal _PLatePayment;
        protected decimal _INVHDR_InstallmentAmount;
        protected decimal _INVHDR_SecurityDeposit;
        protected decimal _INVHDR_DebitNoteAmount;
        protected decimal _INVHDR_ChequeBounceCharges;
        protected decimal _Total_Amt_Due;
        protected decimal _INVHDR_LatePayment1;
        protected decimal _INVHDR_LatePayment;
        protected decimal _Total_Amt_Due_Date;
        protected string _INVHDR_DueDate;
        protected decimal _INVHDR_RecieptAmount;
        protected decimal _INVHDR_ClosingBalance;

        protected DateTime _INVHDR_InvDate1;
        protected decimal _INVHDR_ApplicationId;
        protected int _Count;
        protected decimal _INVHDR_CurrentReading;
        protected int _INVHDR_BillingId;
        protected decimal _INVHDR_RebateQty;
        protected int _INVHDR_CorporateId;
        protected decimal _INVHDR_CreditNoteAmount;
        protected decimal _INVHDR_ReceivedDebitNoteAmount;
        protected string _CenterName;
        protected string _AppNo;
        protected int _CenterCode;
        protected string _totalreceived;
        protected string _receiptType;
        protected string _receiptDate;

        protected decimal _INVHDR_RegChargesAmount;
        protected decimal _INVHDR_ReceivedRegChargesAmount;
        protected int _INVHDR_GeneratedFrom;
        protected string _INVHDR_GeneratedFromText;

        #endregion

        public BILInvoiceHDRTRNList() { }
        public BILInvoiceHDRTRNList(int INVHDR_InvoiceID, string INVHDR_InvNo, string BillingCycle,
            string Customer_Id, string Name, decimal INVHDR_ConsumedUnit, decimal INVHDR_GasPrice,
            decimal INVHDR_GasAmount, decimal INVHDR_MinUnit, decimal INVHDR_Mincharges, decimal INVHDR_Rent,
            decimal INVHDR_AMC, decimal RebateAmount, decimal NetTotal, decimal RoundOff, decimal Previousbalance,
            decimal PLatePayment, decimal INVHDR_InstallmentAmount, decimal INVHDR_SecurityDeposit,
            decimal INVHDR_DebitNoteAmount, decimal INVHDR_ChequeBounceCharges, decimal Total_Amt_Due, decimal INVHDR_LatePayment1, decimal INVHDR_LatePayment,
            decimal Total_Amt_Due_Date, string INVHDR_DueDate, decimal INVHDR_RecieptAmount,
            decimal INVHDR_ClosingBalance, DateTime INVHDR_InvDate1, decimal INVHDR_ApplicationId,
            decimal INVHDR_CurrentReading, int INVHDR_BillingId, decimal INVHDR_RebateQty, int INVHDR_CorporateId, decimal INVHDR_CreditNoteAmount,
            decimal INVHDR_ReceivedDebitNoteAmount, string CenterName, int CenterCode, string AppNo, int Count, string totalreceived, string receiptType, string receiptDate,
            decimal INVHDR_RegChargesAmount, decimal INVHDR_ReceivedRegChargesAmount, int INVHDR_GeneratedFrom, string INVHDR_GeneratedFromText)
        {

            this._INVHDR_InvoiceID = INVHDR_InvoiceID;
            this._INVHDR_InvNo = INVHDR_InvNo;
            this._BillingCycle = BillingCycle;
            this._Customer_Id = Customer_Id;
            this._Name = Name;
            this._INVHDR_ConsumedUnit = INVHDR_ConsumedUnit;
            this._INVHDR_GasPrice = INVHDR_GasPrice;
            this._INVHDR_GasAmount = INVHDR_GasAmount;
            this._INVHDR_MinUnit = INVHDR_MinUnit;
            this._INVHDR_MinCharges = INVHDR_Mincharges;
            this._INVHDR_Rent = INVHDR_Rent;
            this._INVHDR_AMC = INVHDR_AMC;
            this._RebateAmount = RebateAmount;
            this._NetTotal = NetTotal;
            this._RoundOff = RoundOff;
            this._Previousbalance = Previousbalance;
            this._PLatePayment = PLatePayment;
            this.INVHDR_InstallmentAmount = INVHDR_InstallmentAmount;
            this.INVHDR_SecurityDeposit = INVHDR_SecurityDeposit;
            this._INVHDR_DebitNoteAmount = INVHDR_DebitNoteAmount;
            this._INVHDR_ChequeBounceCharges = INVHDR_ChequeBounceCharges;
            this._Total_Amt_Due = Total_Amt_Due;
            this._INVHDR_LatePayment1 = INVHDR_LatePayment1;
            this._INVHDR_LatePayment = INVHDR_LatePayment;
            this._Total_Amt_Due_Date = Total_Amt_Due_Date;
            this._INVHDR_DueDate = INVHDR_DueDate;
            this._INVHDR_RecieptAmount = INVHDR_RecieptAmount;
            this._INVHDR_ClosingBalance = INVHDR_ClosingBalance;

            this._INVHDR_InvDate1 = INVHDR_InvDate1;
            this._INVHDR_ApplicationId = INVHDR_ApplicationId;
            this._INVHDR_CurrentReading = INVHDR_CurrentReading;
            this.INVHDR_BillingId = INVHDR_BillingId;
            this._INVHDR_RebateQty = INVHDR_RebateQty;
            this._INVHDR_CorporateId = INVHDR_CorporateId;
            this._INVHDR_CreditNoteAmount = INVHDR_CreditNoteAmount;
            this._INVHDR_ReceivedDebitNoteAmount = INVHDR_ReceivedDebitNoteAmount;
            this._CenterName = CenterName;
            this._CenterCode = CenterCode;
            this._AppNo = AppNo;
            this._Count = Count;
            this._totalreceived = totalreceived;
            this._receiptType = receiptType;
            this._receiptDate = receiptDate;

            this._INVHDR_RegChargesAmount = INVHDR_RegChargesAmount;
            this._INVHDR_ReceivedRegChargesAmount = INVHDR_ReceivedRegChargesAmount;
            this._INVHDR_GeneratedFrom = INVHDR_GeneratedFrom;
            this._INVHDR_GeneratedFromText = INVHDR_GeneratedFromText;
        }

        public int INVHDR_InvoiceID
        {
            get { return _INVHDR_InvoiceID; }
            set { _INVHDR_InvoiceID = value; }
        }

        public int CenterCode
        {
            get { return _CenterCode; }
            set { _CenterCode = value; }
        }

        public string INVHDR_InvNo
        {
            get { return _INVHDR_InvNo; }
            set { _INVHDR_InvNo = value; }
        }

        public string BillingCycle
        {
            get { return _BillingCycle; }
            set { _BillingCycle = value; }
        }

        public string Customer_Id
        {
            get { return _Customer_Id; }
            set { _Customer_Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string receiptType
        {
            get { return _receiptType; }
            set { _receiptType = value; }
        }
        public string receiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }


        public decimal INVHDR_ConsumedUnit
        {
            get { return _INVHDR_ConsumedUnit; }
            set { _INVHDR_ConsumedUnit = value; }
        }

        public decimal INVHDR_GasPrice
        {
            get { return _INVHDR_GasPrice; }
            set { _INVHDR_GasPrice = value; }
        }

        public decimal INVHDR_GasAmount
        {
            get { return _INVHDR_GasAmount; }
            set { _INVHDR_GasAmount = value; }
        }

        public decimal INVHDR_MinUnit
        {
            get { return _INVHDR_MinUnit; }
            set { _INVHDR_MinUnit = value; }
        }

        public decimal INVHDR_Mincharges
        {
            get { return _INVHDR_MinCharges; }
            set { _INVHDR_MinCharges = value; }
        }

        public decimal INVHDR_Rent
        {
            get { return _INVHDR_Rent; }
            set { _INVHDR_Rent = value; }
        }

        public decimal INVHDR_AMC
        {
            get { return _INVHDR_AMC; }
            set { _INVHDR_AMC = value; }
        }

        public decimal RebateAmount
        {
            get { return _RebateAmount; }
            set { _RebateAmount = value; }
        }

        public decimal NetTotal
        {
            get { return _NetTotal; }
            set { _NetTotal = value; }
        }

        public decimal RoundOff
        {
            get { return _RoundOff; }
            set { _RoundOff = value; }
        }

        public decimal Previousbalance
        {
            get { return _Previousbalance; }
            set { _Previousbalance = value; }
        }

        public decimal PLatePayment
        {
            get { return _PLatePayment; }
            set { _PLatePayment = value; }
        }

        public decimal INVHDR_InstallmentAmount
        {
            get { return _INVHDR_InstallmentAmount; }
            set { _INVHDR_InstallmentAmount = value; }
        }

        public decimal INVHDR_SecurityDeposit
        {
            get { return _INVHDR_SecurityDeposit; }
            set { _INVHDR_SecurityDeposit = value; }
        }

        public decimal INVHDR_DebitNoteAmount
        {
            get { return _INVHDR_DebitNoteAmount; }
            set { _INVHDR_DebitNoteAmount = value; }
        }

        public decimal INVHDR_ChequeBounceCharges
        {
            get { return _INVHDR_ChequeBounceCharges; }
            set { _INVHDR_ChequeBounceCharges = value; }
        }

        public decimal Total_Amt_Due
        {
            get { return _Total_Amt_Due; }
            set { _Total_Amt_Due = value; }
        }

        public decimal INVHDR_LatePayment1
        {
            get { return _INVHDR_LatePayment1; }
            set { _INVHDR_LatePayment1 = value; }
        }

        public decimal INVHDR_LatePayment
        {
            get { return _INVHDR_LatePayment; }
            set { _INVHDR_LatePayment = value; }
        }

        public decimal Total_Amt_Due_Date
        {
            get { return _Total_Amt_Due_Date; }
            set { _Total_Amt_Due_Date = value; }
        }

        public string INVHDR_DueDate
        {
            get { return _INVHDR_DueDate; }
            set { _INVHDR_DueDate = value; }
        }

        public decimal INVHDR_RecieptAmount
        {
            get { return _INVHDR_RecieptAmount; }
            set { _INVHDR_RecieptAmount = value; }
        }

        public decimal INVHDR_ClosingBalance
        {
            get { return _INVHDR_ClosingBalance; }
            set { _INVHDR_ClosingBalance = value; }
        }

        public DateTime INVHDR_InvDate1
        {
            get { return _INVHDR_InvDate1; }
            set { _INVHDR_InvDate1 = value; }
        }

        public decimal INVHDR_ApplicationId
        {
            get { return _INVHDR_ApplicationId; }
            set { _INVHDR_ApplicationId = value; }
        }

        public decimal INVHDR_CurrentReading
        {
            get { return _INVHDR_CurrentReading; }
            set { _INVHDR_CurrentReading = value; }
        }

        public int INVHDR_BillingId
        {
            get { return _INVHDR_BillingId; }
            set { _INVHDR_BillingId = value; }
        }

        public decimal INVHDR_RebateQty
        {
            get { return _INVHDR_RebateQty; }
            set { _INVHDR_RebateQty = value; }
        }
        public int INVHDR_CorporateId
        {
            get { return _INVHDR_CorporateId; }
            set { _INVHDR_CorporateId = value; }
        }

        public decimal INVHDR_CreditNoteAmount
        {
            get { return _INVHDR_CreditNoteAmount; }
            set { _INVHDR_CreditNoteAmount = value; }
        }

        public decimal INVHDR_ReceivedDebitNoteAmount
        {
            get { return _INVHDR_ReceivedDebitNoteAmount; }
            set { _INVHDR_ReceivedDebitNoteAmount = value; }
        }

        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        public string AppNo
        {
            get { return _AppNo; }
            set { _AppNo = value; }
        }
        public string totalreceived
        {
            get { return _totalreceived; }
            set { _totalreceived = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public decimal INVHDR_RegChargesAmount
        {
            get { return _INVHDR_RegChargesAmount; }
            set { _INVHDR_RegChargesAmount = value; }
        }

        public decimal INVHDR_ReceivedRegChargesAmount
        {
            get { return _INVHDR_ReceivedRegChargesAmount; }
            set { _INVHDR_ReceivedRegChargesAmount = value; }
        }

        public int INVHDR_GeneratedFrom
        {
            get { return _INVHDR_GeneratedFrom; }
            set { _INVHDR_GeneratedFrom = value; }
        }
        public string INVHDR_GeneratedFromText
        {
            get { return _INVHDR_GeneratedFromText; }
            set { _INVHDR_GeneratedFromText = value; }
        }
    }

    public class BILInvoiceHDRTRNListHistory : BILInvoiceHDRTRNList
    {
        #region "Variables Declaration"

        private string _INVHDR_CreatedDateTime;
        private string _INVHDR_DeleteDateTime;
        private int _INVHDR_LogID;
        #endregion

        public BILInvoiceHDRTRNListHistory() { }
        public BILInvoiceHDRTRNListHistory(int INVHDR_InvoiceID, string INVHDR_InvNo, string BillingCycle,
            string Customer_Id, string Name, decimal INVHDR_ConsumedUnit, decimal INVHDR_GasPrice,
            decimal INVHDR_GasAmount, decimal INVHDR_MinUnit, decimal INVHDR_Mincharges, decimal INVHDR_Rent,
            decimal INVHDR_AMC, decimal RebateAmount, decimal NetTotal, decimal RoundOff, decimal Previousbalance,
            decimal PLatePayment, decimal INVHDR_InstallmentAmount, decimal INVHDR_SecurityDeposit,
            decimal INVHDR_DebitNoteAmount, decimal INVHDR_ChequeBounceCharges, decimal Total_Amt_Due, decimal INVHDR_LatePayment1, decimal INVHDR_LatePayment,
            decimal Total_Amt_Due_Date, string INVHDR_DueDate, decimal INVHDR_RecieptAmount,
            decimal INVHDR_ClosingBalance, DateTime INVHDR_InvDate1, decimal INVHDR_ApplicationId,
            decimal INVHDR_CurrentReading, int INVHDR_BillingId, decimal INVHDR_RebateQty, int INVHDR_CorporateId, decimal INVHDR_CreditNoteAmount,
            decimal INVHDR_ReceivedDebitNoteAmount, string CenterName, int CenterCode, string AppNo, int Count, string totalreceived, string receiptType, string receiptDate,
            decimal INVHDR_RegChargesAmount, decimal INVHDR_ReceivedRegChargesAmount, string INVHDR_CreatedDateTime, string INVHDR_DeleteDateTime, int INVHDR_LogID)
        {

            this._INVHDR_InvoiceID = INVHDR_InvoiceID;
            this._INVHDR_InvNo = INVHDR_InvNo;
            this._BillingCycle = BillingCycle;
            this._Customer_Id = Customer_Id;
            this._Name = Name;
            this._INVHDR_ConsumedUnit = INVHDR_ConsumedUnit;
            this._INVHDR_GasPrice = INVHDR_GasPrice;
            this._INVHDR_GasAmount = INVHDR_GasAmount;
            this._INVHDR_MinUnit = INVHDR_MinUnit;
            this._INVHDR_MinCharges = INVHDR_Mincharges;
            this._INVHDR_Rent = INVHDR_Rent;
            this._INVHDR_AMC = INVHDR_AMC;
            this._RebateAmount = RebateAmount;
            this._NetTotal = NetTotal;
            this._RoundOff = RoundOff;
            this._Previousbalance = Previousbalance;
            this._PLatePayment = PLatePayment;
            this.INVHDR_InstallmentAmount = INVHDR_InstallmentAmount;
            this.INVHDR_SecurityDeposit = INVHDR_SecurityDeposit;
            this._INVHDR_DebitNoteAmount = INVHDR_DebitNoteAmount;
            this._INVHDR_ChequeBounceCharges = INVHDR_ChequeBounceCharges;
            this._Total_Amt_Due = Total_Amt_Due;
            this._INVHDR_LatePayment1 = INVHDR_LatePayment1;
            this._INVHDR_LatePayment = INVHDR_LatePayment;
            this._Total_Amt_Due_Date = Total_Amt_Due_Date;
            this._INVHDR_DueDate = INVHDR_DueDate;
            this._INVHDR_RecieptAmount = INVHDR_RecieptAmount;
            this._INVHDR_ClosingBalance = INVHDR_ClosingBalance;

            this._INVHDR_InvDate1 = INVHDR_InvDate1;
            this._INVHDR_ApplicationId = INVHDR_ApplicationId;
            this._INVHDR_CurrentReading = INVHDR_CurrentReading;
            this.INVHDR_BillingId = INVHDR_BillingId;
            this._INVHDR_RebateQty = INVHDR_RebateQty;
            this._INVHDR_CorporateId = INVHDR_CorporateId;
            this._INVHDR_CreditNoteAmount = INVHDR_CreditNoteAmount;
            this._INVHDR_ReceivedDebitNoteAmount = INVHDR_ReceivedDebitNoteAmount;
            this._CenterName = CenterName;
            this._CenterCode = CenterCode;
            this._AppNo = AppNo;
            this._Count = Count;
            this._totalreceived = totalreceived;
            this._receiptType = receiptType;
            this._receiptDate = receiptDate;

            this._INVHDR_RegChargesAmount = INVHDR_RegChargesAmount;
            this._INVHDR_ReceivedRegChargesAmount = INVHDR_ReceivedRegChargesAmount;
            this._INVHDR_CreatedDateTime = INVHDR_CreatedDateTime;
            this._INVHDR_DeleteDateTime = INVHDR_DeleteDateTime;
            this._INVHDR_LogID = INVHDR_LogID;
        }

        public string INVHDR_CreatedDateTime
        {
            get { return _INVHDR_CreatedDateTime; }
            set { _INVHDR_CreatedDateTime = value; }
        }

        public string INVHDR_DeleteDateTime
        {
            get { return _INVHDR_DeleteDateTime; }
            set { _INVHDR_DeleteDateTime = value; }
        }

        public int INVHDR_LogID
        {
            get { return _INVHDR_LogID; }
            set { _INVHDR_LogID = value; }
        }

    }

    public class BILInvoiceList
    {
        #region "Variables Declaration"
        protected string _MerchantOrderId;
        protected int _TransactionId;
        protected int _Amount;
        protected int _StoreId;
        protected int _TerminalId;
        protected int _ExpiresIn;
        protected string _FileName;
        
        #endregion

        public BILInvoiceList() { }
        public BILInvoiceList(string MerchantOrderId, int TransactionId, int Amount,
            int StoreId, int TerminalId, int ExpiresIn, string FileName)
        {

            this._MerchantOrderId = MerchantOrderId;
            this._TransactionId = TransactionId;
            this._Amount = Amount;
            this._StoreId = StoreId;
            this._TerminalId = TerminalId;
            this._ExpiresIn = ExpiresIn;
            this._FileName = FileName;
            
        }


        public string MerchantOrderId
        {
            get { return _MerchantOrderId; }
            set { _MerchantOrderId = value; }
        }

        public int TransactionId
        {
            get { return _TransactionId; }
            set { _TransactionId = value; }
        }
        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public int StoreId
        {
            get { return _StoreId; }
            set { _StoreId = value; }
        }
        public int TerminalId
        {
            get { return _TerminalId; }
            set { _TerminalId = value; }
        }
        public int ExpiresIn
        {
            get { return _ExpiresIn; }
            set { _ExpiresIn = value; }
        }
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }   
        
    }
    public class BILInvoiceList_WA
    {
         public BILInvoiceList_WA() { }
         public BILInvoiceList_WA(string bc1, string bc2, string billerBillID,
            string customer_id, string destination, string due_date, string overdue_amount, string value)
        {

            //this._MerchantOrderId = MerchantOrderId;
            //this._TransactionId = TransactionId;
            //this._Amount = Amount;
            //this._StoreId = StoreId;
            //this._TerminalId = TerminalId;
            //this._ExpiresIn = ExpiresIn;
            //this._FileName = FileName;
            //this._overdue_amount = overdue_amount;
            this.value = value;
            this.billerBillID = billerBillID;
            this.destination = destination;
            this.bc1 = bc1;
            this.bc2 = bc2;
            this.customer_id = customer_id;
            this.due_date = due_date;
            this.overdue_amount = overdue_amount;
           
            
        }
        public string value { get; set; }
        public string billerBillID { get; set; }
        public string destination { get; set; }
        public string bc1 { get; set; }
        public string bc2 { get; set; }
        public string customer_id { get; set; }
        public string due_date { get; set; }
        public string overdue_amount { get; set; }
       

    }

    public class BILInvoiceNumList
    {
        #region "Variables Declaration"
        protected int _INVHDR_InvoiceID;
        protected string _INVHDR_InvNo;
        protected string _INVHDR_InvDate;
        protected int _INVHDR_ApplicationId;
        protected int _INVHDR_BillingId;
        protected int _INVHDR_CreatedByUserID;
        protected string _INVHDR_CustomerID;

        #endregion

        public BILInvoiceNumList() { }
        public BILInvoiceNumList(int INVHDR_InvoiceID, string INVHDR_InvNo, string INVHDR_InvDate, int INVHDR_ApplicationId, int INVHDR_BillingId, int INVHDR_CreatedByUserID, string INVHDR_CustomerID)
        {

            this._INVHDR_InvoiceID = INVHDR_InvoiceID;
            this._INVHDR_InvNo = INVHDR_InvNo;
            this._INVHDR_InvDate = INVHDR_InvDate;
            this._INVHDR_ApplicationId = INVHDR_ApplicationId;
            this._INVHDR_BillingId = INVHDR_BillingId;
            this._INVHDR_CreatedByUserID = INVHDR_CreatedByUserID;
            this._INVHDR_CustomerID = INVHDR_CustomerID;
        }


        public int INVHDR_InvoiceID
        {
            get { return _INVHDR_InvoiceID; }
            set { _INVHDR_InvoiceID = value; }
        }

        public string INVHDR_InvNo
        {
            get { return _INVHDR_InvNo; }
            set { _INVHDR_InvNo = value; }
        }
        public string INVHDR_InvDate
        {
            get { return _INVHDR_InvDate; }
            set { _INVHDR_InvDate = value; }
        }
        public int INVHDR_ApplicationId
        {
            get { return _INVHDR_ApplicationId; }
            set { _INVHDR_ApplicationId = value; }
        }
        public int INVHDR_BillingId
        {
            get { return _INVHDR_BillingId; }
            set { _INVHDR_BillingId = value; }
        }

        public int INVHDR_CreatedByUserID
        {
            get { return _INVHDR_CreatedByUserID; }
            set { _INVHDR_CreatedByUserID = value; }
        }

        public string INVHDR_CustomerID
        {
            get { return _INVHDR_CustomerID; }
            set { _INVHDR_CustomerID = value; }
        }
    }



    
    public class BILInvoiceHDRTRN_GetPerUnitCharge
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CenCode;
        private int _APPMST_AppID;
        private int _BCCMST_BillingID;
        #endregion

        /// <summary>
        /// Default constructor for BILInvoiceHDRTRN class.
        /// </summary>
        public BILInvoiceHDRTRN_GetPerUnitCharge() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILInvoiceHDRTRN_GetPerUnitCharge(int CenCode, int APPMST_AppID, int BCCMST_BillingID)
        {
            this._CenCode = CenCode;
            this._APPMST_AppID = APPMST_AppID;
            this._BCCMST_BillingID = BCCMST_BillingID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CenCode
        {
            get { return _CenCode; }
            set { _CenCode = value; }
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
        public int BCCMST_BillingID
        {
            get { return _BCCMST_BillingID; }
            set { _BCCMST_BillingID = value; }
        }
    }

    public class BILInvoiceHDRTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        private string _DtRowVal1;
        private string _DtRowVal2;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILInvoiceHDRTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILInvoiceHDRTRNMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }
        public BILInvoiceHDRTRNMsg(int RetVal, string RetStr, string DtRowVal1, string DtRowVal2)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
            this._DtRowVal1 = DtRowVal1;
            this._DtRowVal2 = DtRowVal2;

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
        public string DtRowVal1
        {
            get { return _DtRowVal1; }
            set { _DtRowVal1 = value; }
        }
        public string DtRowVal2
        {
            get { return _DtRowVal2; }
            set { _DtRowVal2 = value; }
        }
    }

    
    public class BILAMCTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _AMCTRN_AMCAmount;
        private string _BCCMST_ShortName;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for BILInvoiceHDRTRN class.
        /// </summary>
        public BILAMCTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILAMCTRN(int AMCTRN_AMCAmount, string BCCMST_ShortName, int Count)
        {

            this._AMCTRN_AMCAmount = AMCTRN_AMCAmount;
            this._BCCMST_ShortName = BCCMST_ShortName;
            this._Count = Count;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCTRN_AMCAmount
        {
            get { return _AMCTRN_AMCAmount; }
            set { _AMCTRN_AMCAmount = value; }
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
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class BILInvoiceAdvanceHistoryList
    {
        #region "Variables Declaration"
        protected int _Row;
        protected int _INVHDR_LogID;
        protected string _type;
        protected int _OriginalLogID;
        protected int _RevisedLogID;
        protected int _OriginalInvoiceID;
        protected int _RevisedInvoiceID;
        protected string _OriginalINVfrom;
        protected string _RevisedInvFrom;
        protected string _INVHDR_DeleteDateTime;
        protected string _CreatedDateTime;
        protected string _CustomerID;
        protected string _AppNo;
        protected string _OriginalInvNo;
        protected string _revisedInvNo;
        protected string _OriginalInvDate;
        protected string _revisedInvDate;
        protected string _BillingCycle;
        protected string _ReasonforRevisionOfInvoice;
        protected string _CUoriginalInvoice;
        protected string _CUrevisedinvoice;
        protected string _DifferentialUnit;
        protected string _PNGSalesAMTperOriginalInvoice;
        protected string _PNGSalesAMTperrevisedInvoice;
        protected string _DifferentialPNGSalesAMT;
        protected string _ChangeinInstallmentAmount;
        protected string _ChangeinLPC;
        protected string _ChangeinAMC;
        protected string _ChangeinCBC;
        protected string _TotalChangeinInvoice;
        protected string _RentDiff;
        protected string _MinChargesDiff;
        protected string _DebitNoteDiff;
        protected string _VATDiff;
        protected string _GSTDiff;
        protected int _Count;


        #endregion

        public BILInvoiceAdvanceHistoryList() { }
        public BILInvoiceAdvanceHistoryList(int Row, int INVHDR_LogID, string type, int OriginalLogID, int RevisedLogID, int OriginalInvoiceID, int RevisedInvoiceID,
            string OriginalINVfrom, string RevisedInvFrom, string INVHDR_DeleteDateTime, string CreatedDateTime,
            string CustomerID, string AppNo, string OriginalInvNo, string revisedInvNo, string OriginalInvDate, string revisedInvDate,
            string BillingCycle, string ReasonforRevisionOfInvoice, string CUoriginalInvoice, string CUrevisedinvoice,
            string DifferentialUnit, string PNGSalesAMTperOriginalInvoice, string PNGSalesAMTperrevisedInvoice, string DifferentialPNGSalesAMT,
            string ChangeinInstallmentAmount, string ChangeinLPC, string ChangeinAMC, string ChangeinCBC, string TotalChangeinInvoice, string RentDiff,
            string MinChargesDiff, string DebitNoteDiff, string VATDiff, string GSTDiff, int Count)
        {

            this._OriginalLogID = OriginalLogID;
            this._RevisedLogID = RevisedLogID;
            this._OriginalInvoiceID = OriginalInvoiceID;
            this._RevisedInvoiceID = RevisedInvoiceID;
            this._OriginalINVfrom = OriginalINVfrom;
            this._RevisedInvFrom = RevisedInvFrom;
            this._AppNo = AppNo;
            this._BillingCycle = BillingCycle;
            this._ChangeinAMC = ChangeinAMC;
            this._ChangeinCBC = ChangeinCBC;
            this._ChangeinInstallmentAmount = ChangeinInstallmentAmount;
            this._ChangeinLPC = ChangeinLPC;
            this._CUoriginalInvoice = CUoriginalInvoice;
            this._CUrevisedinvoice = CUrevisedinvoice;
            this._CustomerID = CustomerID;
            this._DifferentialPNGSalesAMT = DifferentialPNGSalesAMT;
            this._DifferentialUnit = DifferentialUnit;
            this._INVHDR_DeleteDateTime = INVHDR_DeleteDateTime;
            this._CreatedDateTime = CreatedDateTime;
            this._INVHDR_LogID = INVHDR_LogID;
            this._OriginalInvDate = OriginalInvDate;
            this._OriginalInvNo = OriginalInvNo;
            this._PNGSalesAMTperOriginalInvoice = PNGSalesAMTperOriginalInvoice;
            this._PNGSalesAMTperrevisedInvoice = PNGSalesAMTperrevisedInvoice;
            this._ReasonforRevisionOfInvoice = ReasonforRevisionOfInvoice;
            this._revisedInvDate = revisedInvDate;
            this._revisedInvNo = revisedInvNo;
            this._Row = Row;
            this._TotalChangeinInvoice = TotalChangeinInvoice;
            this._RentDiff = RentDiff;
            this._MinChargesDiff = MinChargesDiff;
            this._DebitNoteDiff = DebitNoteDiff;
            this._VATDiff = VATDiff;
            this._GSTDiff = GSTDiff;
            this._Count = Count;
            this._type = type;

        }

        
        
        public int Row
        {
            get { return _Row; }
            set { _Row = value; }
        }
        public int INVHDR_LogID
        {
            get { return _INVHDR_LogID; }
            set { _INVHDR_LogID = value; }

        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int OriginalLogID
        {
            get { return _OriginalLogID; }
            set { _OriginalLogID = value; }
        }
        public int RevisedLogID
        {
            get { return _RevisedLogID; }
            set { _RevisedLogID = value; }
        }
        public int OriginalInvoiceID
        {
            get { return _OriginalInvoiceID; }
            set { _OriginalInvoiceID = value; }
        }
        public int RevisedInvoiceID
        {
            get { return _RevisedInvoiceID; }
            set { _RevisedInvoiceID = value; }
        }
        public string OriginalINVfrom
        {
            get { return _OriginalINVfrom; }
            set { _OriginalINVfrom = value; }
        }
        public string RevisedInvFrom
        {
            get { return _RevisedInvFrom; }
            set { _RevisedInvFrom = value; }
        }

        public string INVHDR_DeleteDateTime
        {
            get { return _INVHDR_DeleteDateTime; }
            set { _INVHDR_DeleteDateTime = value; }
        }
        public string CreatedDateTime
        {
            get { return _CreatedDateTime; }
            set { _CreatedDateTime = value; }
        }
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }

        }
        public string AppNo
        {
            get { return _AppNo; }
            set { _AppNo = value; }

        }
        public string OriginalInvNo
        {
            get { return _OriginalInvNo; }
            set { _OriginalInvNo = value; }

        }
        public string revisedInvNo
        {
            get { return _revisedInvNo; }
            set { _revisedInvNo = value; }

        }
        public string OriginalInvDate
        {
            get { return _OriginalInvDate; }
            set { _OriginalInvDate = value; }

        }
        public string revisedInvDate
        {
            get { return _revisedInvDate; }
            set { _revisedInvDate = value; }

        }
        public string BillingCycle
        {
            get { return _BillingCycle; }
            set { _BillingCycle = value; }

        }
        public string ReasonforRevisionOfInvoice
        {
            get { return _ReasonforRevisionOfInvoice; }
            set { _ReasonforRevisionOfInvoice = value; }

        }
        public string CUoriginalInvoice
        {
            get { return _CUoriginalInvoice; }
            set { _CUoriginalInvoice = value; }

        }
        public string CUrevisedinvoice
        {
            get { return _CUrevisedinvoice; }
            set { _CUrevisedinvoice = value; }

        }
        public string DifferentialUnit
        {
            get { return _DifferentialUnit; }
            set { _DifferentialUnit = value; }

        }
        public string PNGSalesAMTperOriginalInvoice
        {
            get { return _PNGSalesAMTperOriginalInvoice; }
            set { _PNGSalesAMTperOriginalInvoice = value; }

        }
        public string PNGSalesAMTperrevisedInvoice
        {
            get { return _PNGSalesAMTperrevisedInvoice; }
            set { _PNGSalesAMTperrevisedInvoice = value; }

        }
        public string DifferentialPNGSalesAMT
        {
            get { return _DifferentialPNGSalesAMT; }
            set { _DifferentialPNGSalesAMT = value; }

        }
        public string ChangeinInstallmentAmount
        {
            get { return _ChangeinInstallmentAmount; }
            set { _ChangeinInstallmentAmount = value; }

        }
        public string ChangeinLPC
        {
            get { return _ChangeinLPC; }
            set { _ChangeinLPC = value; }

        }
        public string ChangeinAMC
        {
            get { return _ChangeinAMC; }
            set { _ChangeinAMC = value; }

        }
        public string ChangeinCBC
        {
            get { return _ChangeinCBC; }
            set { _ChangeinCBC = value; }

        }
        public string TotalChangeinInvoice
        {
            get { return _TotalChangeinInvoice; }
            set { _TotalChangeinInvoice = value; }

        }
        public string RentDiff
        {
            get { return _RentDiff; }
            set { _RentDiff = value; }

        }
        public string MinChargesDiff
        {
            get { return _MinChargesDiff; }
            set { _MinChargesDiff = value; }

        }
        public string DebitNoteDiff
        {
            get { return _DebitNoteDiff; }
            set { _DebitNoteDiff = value; }

        }
        public string VATDiff
        {
            get { return _VATDiff; }
            set { _VATDiff = value; }

        }
        public string GSTDiff
        {
            get { return _GSTDiff; }
            set { _GSTDiff = value; }

        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }

        }

    }

}
