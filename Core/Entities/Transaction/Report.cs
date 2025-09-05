//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDInvoiceHDRTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDInvoiceHDRTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>

    
    public class CallSummaryRpt_List
    {
        #region "Variables Declaration"
        private string _CenterName;
        private string _CallType;
        private int _TotalCall;
        private int _OpenCall;
        private int _AllocatedCall;
        private int _TransferCall;
        private int _OnHoldCall;
        private int _ExtendedCall;
        private int _ForceClosedCall;
        private int _SolvedCall;
        private int _Count;

        #endregion
        public CallSummaryRpt_List() { }
        public CallSummaryRpt_List(string CenterName, string CallType, int TotalCall, int OpenCall, int AllocatedCall, int TransferCall, int OnHoldCall, int ExtendedCall, int ForceClosedCall, int SolvedCall, int Count)
        {
            this._CenterName = CenterName;
            this._CallType = CallType;
            this._TotalCall = TotalCall;
            this._OpenCall = OpenCall;
            this._AllocatedCall = AllocatedCall;
            this._TransferCall = TransferCall;
            this._OnHoldCall = OnHoldCall;
            this._ExtendedCall = ExtendedCall;
            this._ForceClosedCall = ForceClosedCall;
            this._SolvedCall = SolvedCall;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CallType
        {
            get { return _CallType; }
            set { _CallType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TotalCall
        {
            get { return _TotalCall; }
            set { _TotalCall = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OpenCall
        {
            get { return _OpenCall; }
            set { _OpenCall = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AllocatedCall
        {
            get { return _AllocatedCall; }
            set { _AllocatedCall = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TransferCall
        {
            get { return _TransferCall; }
            set { _TransferCall = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OnHoldCall
        {
            get { return _OnHoldCall; }
            set { _OnHoldCall = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ExtendedCall
        {
            get { return _ExtendedCall; }
            set { _ExtendedCall = value; }
        }

        public int ForceClosedCall
        {
            get { return _ForceClosedCall; }
            set { _ForceClosedCall = value; }
        }

        public int SolvedCall
        {
            get { return _SolvedCall; }
            set { _SolvedCall = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    
    public class NoticeRpt
    {
        #region "Variables Declaration"
        private int _CenCode;
        private int _CustType;
        private int _AreaId;
        private string _NoticeNo;
        private string _CustomerID;
        private string _FromDate;
        private string _ToDate;
        private int _UserId;
        #endregion
        public NoticeRpt() { }
        public NoticeRpt(int CenCode, int CustType, int WorkType, int AreaId, string NoticeNo, string CustomerID, string FromDate, string ToDate, int UserID)
        {
            this._CenCode = CenCode;
            this._CustType = CustType;
            this._AreaId = AreaId;
            this._NoticeNo = NoticeNo;
            this._CustomerID = CustomerID;
            this._FromDate = FromDate;
            this._ToDate = ToDate;
            this._UserId = UserId;
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
        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AreaId
        {
            get { return _AreaId; }
            set { _AreaId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NoticeNo
        {
            get { return _NoticeNo; }
            set { _NoticeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }

    
    public class DebitNoteRpt
    {
        #region "Variables Declaration"
        private int _CenCode;
        private int _CustType;
        private int _WorkType;
        private int _AreaId;
        private string _DebitNoteRefNo;
        private string _ApplicationNo;
        private string _FromDate;
        private string _ToDate;
        private int _UserId;
        private int _INVHDR_LogID;
        #endregion
        public DebitNoteRpt() { }
        public DebitNoteRpt(int CenCode, int CustType, int WorkType, int AreaId, string DebitNoteRefNo, string ApplicationNo, string FromDate, string ToDate, int UserID, int INVHDR_LogID)
        {
            this._CenCode = CenCode;
            this._CustType = CustType;
            this._WorkType = WorkType;
            this._AreaId = AreaId;
            this._DebitNoteRefNo = DebitNoteRefNo;
            this._ApplicationNo = ApplicationNo;
            this._FromDate = FromDate;
            this._ToDate = ToDate;
            this._UserId = UserId;
            this._INVHDR_LogID = INVHDR_LogID;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public int INVHDR_LogID
        {
            get { return _INVHDR_LogID; }
            set { _INVHDR_LogID = value; }
        }
        public int CenCode
        {
            get { return _CenCode; }
            set { _CenCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int WorkType
        {
            get { return _WorkType; }
            set { _WorkType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AreaId
        {
            get { return _AreaId; }
            set { _AreaId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DebitNoteRefNo
        {
            get { return _DebitNoteRefNo; }
            set { _DebitNoteRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }

    
    public class OutStandingRpt_List
    {
        #region "Variables Declaration"
        private string _ApplicationNo;
        private string _CustomerID;
        private string _CustomerName;
        private string _Address;
        private string _Area;
        private string _Phone;
        private string _Mobile;
        private string _CustType;
        private string _PlanName;
        private decimal _NConnDNOSAmt;
        private decimal _EConnDNOSAmt;
        private decimal _AConnDNOSAmt;
        private decimal _BilOSAmt;
        private decimal _TotOSAmt;
        private decimal _Advance;
        private decimal _ActOSAmt;
        private string _OMStatus;
        private string _LastDueDate;
        private string _1stBillPending;
        private string _2ndBillPending;
        private string _3rdBillPending;
        private string _4thBillPending;
        private string _5thBillPending;
        private string _6thBillPending;

        private int _Count;
        #endregion
        public OutStandingRpt_List() { }
        public OutStandingRpt_List(string ApplicationNo, string CustomerID, string CustomerName,
            string Address, string Area, string Phone, string Mobile, string CustType, string PlanName,
            decimal NConnDNOSAmt, decimal EConnDNOSAmt, decimal AConnDNOSAmt, decimal BilOSAmt,
            decimal TotOSAmt, decimal Advance, decimal ActOSAmt, string OMStatus,string LastDueDate,
            string firstBillPending,string secondBillPending,string thirdBillPending, string fourthBillPending,
            string fifthBillPending, string sixthBillPending, int Count)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerID = CustomerID;
            this._CustomerName = CustomerName;
            this._Address = Address;
            this._Area = Area;
            this._Phone = Phone;
            this._Mobile = Mobile;
            this._CustType = CustType;
            this._PlanName = PlanName;
            this._NConnDNOSAmt = NConnDNOSAmt;
            this._EConnDNOSAmt = EConnDNOSAmt;
            this._AConnDNOSAmt = AConnDNOSAmt;
            this._BilOSAmt = BilOSAmt;
            this._TotOSAmt = TotOSAmt;
            this._Advance = Advance;
            this._ActOSAmt = ActOSAmt;
            this._OMStatus = OMStatus;
            this._LastDueDate=LastDueDate;
            this._1stBillPending = firstBillPending;
            this._2ndBillPending = secondBillPending;
            this._3rdBillPending = thirdBillPending;
            this._4thBillPending = fourthBillPending;
            this._5thBillPending = fifthBillPending;
            this._6thBillPending = sixthBillPending;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public string LastDueDate
        {
      
            get { return _LastDueDate; }
            set { _LastDueDate = value; }
        }
        public string FirstBillPending
        {

            get { return _1stBillPending; }
            set { _1stBillPending = value; }
        }
        public string SecondBillPending
        {

            get { return _2ndBillPending; }
            set { _2ndBillPending = value; }
        }
        public string ThirdBillPending
        {

            get { return _3rdBillPending; }
            set { _3rdBillPending = value; }
        }
        public string FourthBillPending
        {

            get { return _4thBillPending; }
            set { _4thBillPending = value; }
        }
        public string FifthBillPending
        {

            get { return _5thBillPending; }
            set { _5thBillPending = value; }
        }
        public string SixthBillPending
        {

            get { return _6thBillPending; }
            set { _6thBillPending = value; }
        }

        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
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
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
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
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NConnDNOSAmt
        {
            get { return _NConnDNOSAmt; }
            set { _NConnDNOSAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal EConnDNOSAmt
        {
            get { return _EConnDNOSAmt; }
            set { _EConnDNOSAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal AConnDNOSAmt
        {
            get { return _AConnDNOSAmt; }
            set { _AConnDNOSAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal BilOSAmt
        {
            get { return _BilOSAmt; }
            set { _BilOSAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotOSAmt
        {
            get { return _TotOSAmt; }
            set { _TotOSAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal Advance
        {
            get { return _Advance; }
            set { _Advance = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal ActOSAmt
        {
            get { return _ActOSAmt; }
            set { _ActOSAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMStatus
        {
            get { return _OMStatus; }
            set { _OMStatus = value; }
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

    
    public class DailyCollectionRpt_List
    {
        #region "Variables Declaration"
        private string _CenterName;
        private string _CollectionDate;
        private DateTime _CollectionDate1;
        private decimal _DomesticAmt;
        private decimal _CommercialAmt;
        private decimal _NonCommercialAmt;
        private decimal _DNAmt;
        private string _PayMode;
        private decimal _AlterationModification;
        private decimal _RegistrationCharges;
        private decimal _ERCForceClosure;
        private decimal _MeterReplacementCharges;
        private decimal _ChequeBounceCharges;
        private decimal _TemporaryDisconnection;
        private decimal _PermanentDisconnection;
        private decimal _ExtraConnectionRequest;
        private decimal _NameTransfer;
        private decimal _Reconnection;
        private decimal _AdvanceReceipt;
        private decimal _AdvanceDebitNote;
        private int _Count;
        #endregion
        public DailyCollectionRpt_List() { }
        public DailyCollectionRpt_List(string CenterName, string CollectionDate, DateTime CollectionDate1,
            decimal DomesticAmt, decimal CommercialAmt, decimal NonCommercialAmt, decimal DNAmt,
            string PayMode, decimal AlterationModification, decimal RegistrationCharges, decimal ERCForceClosure,
            decimal MeterReplacementCharges, decimal ChequeBounceCharges, decimal TemporaryDisconnection,
            decimal PermanentDisconnection, decimal ExtraConnectionRequest, decimal NameTransfer,
            decimal Reconnection, decimal AdvanceReceipt, decimal AdvanceDebitNote, int Count)
        {
            this._CenterName = CenterName;
            this._CollectionDate = CollectionDate;
            this._CollectionDate1 = CollectionDate1;
            this._DomesticAmt = DomesticAmt;
            this._CommercialAmt = CommercialAmt;
            this._NonCommercialAmt = NonCommercialAmt;
            this._DNAmt = DNAmt;
            this._PayMode = PayMode;
            this._AlterationModification = AlterationModification;
            this._RegistrationCharges = RegistrationCharges;
            this._ERCForceClosure = ERCForceClosure;
            this._MeterReplacementCharges = MeterReplacementCharges;
            this._ChequeBounceCharges = ChequeBounceCharges;
            this._TemporaryDisconnection = TemporaryDisconnection;
            this._PermanentDisconnection = PermanentDisconnection;
            this._ExtraConnectionRequest = ExtraConnectionRequest;
            this._NameTransfer = NameTransfer;
            this._Reconnection = Reconnection;
            this._AdvanceReceipt = AdvanceReceipt;
            this._AdvanceDebitNote = AdvanceDebitNote;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CollectionDate
        {
            get { return _CollectionDate; }
            set { _CollectionDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public DateTime CollectionDate1
        {
            get { return _CollectionDate1; }
            set { _CollectionDate1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DomesticAmt
        {
            get { return _DomesticAmt; }
            set { _DomesticAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CommercialAmt
        {
            get { return _CommercialAmt; }
            set { _CommercialAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NonCommercialAmt
        {
            get { return _NonCommercialAmt; }
            set { _NonCommercialAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DNAmt
        {
            get { return _DNAmt; }
            set { _DNAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PayMode
        {
            get { return _PayMode; }
            set { _PayMode = value; }
        }
        public decimal AlterationModification
        {
            get { return _AlterationModification; }
            set { _AlterationModification = value; }
        }
        public decimal RegistrationCharges
        {
            get { return _RegistrationCharges; }
            set { _RegistrationCharges = value; }
        }
        public decimal ERCForceClosure
        {
            get { return _ERCForceClosure; }
            set { _ERCForceClosure = value; }
        }
        public decimal MeterReplacementCharges
        {
            get { return _MeterReplacementCharges; }
            set { _MeterReplacementCharges = value; }
        }
        public decimal ChequeBounceCharges
        {
            get { return _ChequeBounceCharges; }
            set { _ChequeBounceCharges = value; }
        }
        public decimal TemporaryDisconnection
        {
            get { return _TemporaryDisconnection; }
            set { _TemporaryDisconnection = value; }
        }
        public decimal PermanentDisconnection
        {
            get { return _PermanentDisconnection; }
            set { _PermanentDisconnection = value; }
        }

        public decimal ExtraConnectionRequest
        {
            get { return _ExtraConnectionRequest; }
            set { _ExtraConnectionRequest = value; }
        }
        public decimal NameTransfer
        {
            get { return _NameTransfer; }
            set { _NameTransfer = value; }
        }
        public decimal Reconnection
        {
            get { return _Reconnection; }
            set { _Reconnection = value; }
        }
        public decimal AdvanceReceipt
        {
            get { return _AdvanceReceipt; }
            set { _AdvanceReceipt = value; }
        }
        public decimal AdvanceDebitNote
        {
            get { return _AdvanceDebitNote; }
            set { _AdvanceDebitNote = value; }
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

    
    public class DashBoardForCollectionRpt_List
    {
        #region "Variables Declaration"
        private string _CenterName;
        private decimal _DomesticAmt;
        //private decimal _CommercialAmt;
        //private decimal _NonCommercialAmt;
        private decimal _DNAmt;
        private string _PayMode;
        private decimal _AlterationModification;
        private decimal _RegistrationCharges;
        private decimal _ERCForceClosure;
        private decimal _MeterReplacementCharges;
        private decimal _ChequeBounceCharges;
        private decimal _TemporaryDisconnection;
        private decimal _PermanentDisconnection;
        private decimal _ExtraConnectionRequest;
        private decimal _NameTransfer;
        private decimal _Reconnection;
        private decimal _AdvanceReceipt;
        private decimal _AdvanceDebitNote;
        private decimal _Total;
        private int _Count;
        #endregion
        public DashBoardForCollectionRpt_List() { }
        public DashBoardForCollectionRpt_List(string CenterName, decimal DomesticAmt, decimal DNAmt, string PayMode,
            decimal AlterationModification, decimal RegistrationCharges, decimal ERCForceClosure,
            decimal MeterReplacementCharges, decimal ChequeBounceCharges, decimal TemporaryDisconnection,
            decimal PermanentDisconnection, decimal ExtraConnectionRequest, decimal NameTransfer,
            decimal Reconnection, decimal AdvanceReceipt, decimal AdvanceDebitNote, decimal Total, int Count)
        {
            this._CenterName = CenterName;
            this._DomesticAmt = DomesticAmt;
            //this._CommercialAmt = CommercialAmt;
            //this._NonCommercialAmt = NonCommercialAmt;
            this._DNAmt = DNAmt;
            this._PayMode = PayMode;
            this._AlterationModification = AlterationModification;
            this._RegistrationCharges = RegistrationCharges;
            this._ERCForceClosure = ERCForceClosure;
            this._MeterReplacementCharges = MeterReplacementCharges;
            this._ChequeBounceCharges = ChequeBounceCharges;
            this._TemporaryDisconnection = TemporaryDisconnection;
            this._PermanentDisconnection = PermanentDisconnection;
            this._ExtraConnectionRequest = ExtraConnectionRequest;
            this._NameTransfer = NameTransfer;
            this._Reconnection = Reconnection;
            this._AdvanceReceipt = AdvanceReceipt;
            this._AdvanceDebitNote = AdvanceDebitNote;
            this._Total = Total;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DomesticAmt
        {
            get { return _DomesticAmt; }
            set { _DomesticAmt = value; }
        }

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public decimal CommercialAmt
        //{
        //    get { return _CommercialAmt; }
        //    set { _CommercialAmt = value; }
        //}

        ///// <summary>
        ////Write Column Description here. 
        ///// </summary>
        //public decimal NonCommercialAmt
        //{
        //    get { return _NonCommercialAmt; }
        //    set { _NonCommercialAmt = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DNAmt
        {
            get { return _DNAmt; }
            set { _DNAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PayMode
        {
            get { return _PayMode; }
            set { _PayMode = value; }
        }
        public decimal AlterationModification
        {
            get { return _AlterationModification; }
            set { _AlterationModification = value; }
        }
        public decimal RegistrationCharges
        {
            get { return _RegistrationCharges; }
            set { _RegistrationCharges = value; }
        }
        public decimal ERCForceClosure
        {
            get { return _ERCForceClosure; }
            set { _ERCForceClosure = value; }
        }
        public decimal MeterReplacementCharges
        {
            get { return _MeterReplacementCharges; }
            set { _MeterReplacementCharges = value; }
        }
        public decimal ChequeBounceCharges
        {
            get { return _ChequeBounceCharges; }
            set { _ChequeBounceCharges = value; }
        }
        public decimal TemporaryDisconnection
        {
            get { return _TemporaryDisconnection; }
            set { _TemporaryDisconnection = value; }
        }
        public decimal PermanentDisconnection
        {
            get { return _PermanentDisconnection; }
            set { _PermanentDisconnection = value; }
        }

        public decimal ExtraConnectionRequest
        {
            get { return _ExtraConnectionRequest; }
            set { _ExtraConnectionRequest = value; }
        }
        public decimal NameTransfer
        {
            get { return _NameTransfer; }
            set { _NameTransfer = value; }
        }
        public decimal Reconnection
        {
            get { return _Reconnection; }
            set { _Reconnection = value; }
        }
        public decimal AdvanceReceipt
        {
            get { return _AdvanceReceipt; }
            set { _AdvanceReceipt = value; }
        }

        public decimal AdvanceDebitNote
        {
            get { return _AdvanceDebitNote; }
            set { _AdvanceDebitNote = value; }
        }

        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
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

    
    public class PendingBillSummaryRpt_List
    {
        #region "Variables Declaration"
        private string _CenterName;
        private string _ApplicationNo;
        private string _CustomerID;
        private string _AreaName;
        private string _CustomerName;
        private string _CustAddress;
        private string _Phone;
        private string _Mobile;
        private string _BillingPeriod;
        private string _BillNo;
        private string _BillDate;
        private DateTime _BillDate1;
        private decimal _NetTotal;
        private decimal _PrevBalance;
        private decimal _PLatePayment;
        private decimal _SecDeposit;
        private decimal _InstallAmt;
        private decimal _LatePayment;
        private decimal _TotBillAmt;
        private decimal _DNAmt;
        private decimal _TotDueAmt;
        private string _DueDate;
        private DateTime _DueDate1;
        private decimal _CNAmt;
        private int _Count;
        #endregion
        public PendingBillSummaryRpt_List() { }
        public PendingBillSummaryRpt_List(string CenterName, string ApplicationNo, string CustomerID, string AreaName, string CustomerName, string CustAddress, string Phone, string Mobile, string BillingPeriod, string BillNo, string BillDate, DateTime BillDate1,
            decimal NetTotal, decimal PrevBalance, decimal PLatePayment, decimal SecDeposit, decimal InstallAmt, decimal LatePayment, decimal TotBillAmt, decimal DNAmt, decimal TotDueAmt, string DueDate, DateTime DueDate1, decimal CNAmt, int Count)
        {
            this._CenterName = CenterName;
            this._ApplicationNo = ApplicationNo;
            this._CustomerID = CustomerID;
            this._AreaName = AreaName;
            this._CustomerName = CustomerName;
            this._CustAddress = CustAddress;
            this._Phone = Phone;
            this._Mobile = Mobile;
            this._BillingPeriod = BillingPeriod;
            this._BillNo = BillNo;
            this._BillDate = BillDate;
            this._BillDate1 = BillDate1;
            this._NetTotal = NetTotal;
            this._PrevBalance = PrevBalance;
            this._PLatePayment = PLatePayment;
            this._SecDeposit = SecDeposit;
            this._InstallAmt = InstallAmt;
            this._LatePayment = LatePayment;
            this._TotBillAmt = TotBillAmt;
            this._DNAmt = DNAmt;
            this._TotDueAmt = TotDueAmt;
            this._DueDate = DueDate;
            this._DueDate1 = DueDate1;
            this._CNAmt = CNAmt;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
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
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustAddress
        {
            get { return _CustAddress; }
            set { _CustAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BillingPeriod
        {
            get { return _BillingPeriod; }
            set { _BillingPeriod = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public DateTime BillDate1
        {
            get { return _BillDate1; }
            set { _BillDate1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NetTotal
        {
            get { return _NetTotal; }
            set { _NetTotal = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PrevBalance
        {
            get { return _PrevBalance; }
            set { _PrevBalance = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLatePayment
        {
            get { return _PLatePayment; }
            set { _PLatePayment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal SecDeposit
        {
            get { return _SecDeposit; }
            set { _SecDeposit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal InstallAmt
        {
            get { return _InstallAmt; }
            set { _InstallAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal LatePayment
        {
            get { return _LatePayment; }
            set { _LatePayment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotBillAmt
        {
            get { return _TotBillAmt; }
            set { _TotBillAmt = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DNAmt
        {
            get { return _DNAmt; }
            set { _DNAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotDueAmt
        {
            get { return _TotDueAmt; }
            set { _TotDueAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DueDate
        {
            get { return _DueDate; }
            set { _DueDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public DateTime DueDate1
        {
            get { return _DueDate1; }
            set { _DueDate1 = value; }
        }
        public decimal CNAmt
        {
            get { return _CNAmt; }
            set { _CNAmt = value; }
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


    
    public class DatewiseReceiptRpt_List
    {
        #region "Variables Declaration"
        private string _ApplicationNo;
        private string _CustomerID;
        private string _ReceiptDate;
        private DateTime _ReceiptDate1;
        private decimal _RecBillAmt;
        private decimal _RecDNAmt;
        private decimal _RecTotAmt;
        private string _ReceiptNo;
        private string _BillingCycle;
        private string _PayMode;
        private string _ChequeNo;
        private string _PLAMST_PlanName;
        private int _Count;
        #endregion
        public DatewiseReceiptRpt_List() { }
        public DatewiseReceiptRpt_List(string ApplicationNo, string CustomerID, string ReceiptDate, DateTime ReceiptDate1,
            decimal RecBillAmt, decimal RecDNAmt, decimal RecTotAmt, string ReceiptNo, string BillingCycle, string PayMode, string PLAMST_PlanName, string ChequeNo, int Count)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerID = CustomerID;
            this._ReceiptDate = ReceiptDate;
            this._ReceiptDate1 = ReceiptDate1;
            this._RecBillAmt = RecBillAmt;
            this._RecDNAmt = RecDNAmt;
            this._RecTotAmt = RecTotAmt;

            this._ReceiptNo = ReceiptNo;
            this._BillingCycle = BillingCycle;
            this._PayMode = PayMode;
            this._ChequeNo = ChequeNo;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._Count = Count;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BillingCycle
        {
            get { return _BillingCycle; }
            set { _BillingCycle = value; }
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
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ReceiptDate
        {
            get { return _ReceiptDate; }
            set { _ReceiptDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public DateTime ReceiptDate1
        {
            get { return _ReceiptDate1; }
            set { _ReceiptDate1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RecBillAmt
        {
            get { return _RecBillAmt; }
            set { _RecBillAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RecDNAmt
        {
            get { return _RecDNAmt; }
            set { _RecDNAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RecTotAmt
        {
            get { return _RecTotAmt; }
            set { _RecTotAmt = value; }
        }

        public string ReceiptNo
        {
            get { return _ReceiptNo; }
            set { _ReceiptNo = value; }
        }

        public string PayMode
        {
            get { return _PayMode; }
            set { _PayMode = value; }
        }

        public string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
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


    
    public class GetDebitNotDispatchedList_List
    {
        #region "Variables Declaration"

        private string _ApplicationNo;
        private string _CustomerID;
        private string _CustomerName;
        private string _DebitNoteDate;
        private int _ApplicationId;
        private string _Address;
        private string _PlanName;
        private string _Area;
        private string _DebiteNoteNo;
        private string _CustomerType;
        private int _Count;
        #endregion
        public GetDebitNotDispatchedList_List() { }
        public GetDebitNotDispatchedList_List(string DebiteNoteNo, string DebitNoteDate, string ApplicationNo, string CustomerID,
            string CustomerName, string Address, string PlanName, string Area, string CustomerType, int ApplicationId, int Count)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerID = CustomerID;
            this._CustomerName = CustomerName;
            this._DebitNoteDate = DebitNoteDate;
            this._ApplicationId = ApplicationId;
            this._Address = Address;
            this._PlanName = PlanName;
            this._Area = Area;
            this._DebiteNoteNo = DebiteNoteNo;
            this._CustomerType = CustomerType;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
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
        public string DebitNoteDate
        {
            get { return _DebitNoteDate; }
            set { _DebitNoteDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ApplicationId
        {
            get { return _ApplicationId; }
            set { _ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
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
        public string DebiteNoteNo
        {
            get { return _DebiteNoteNo; }
            set { _DebiteNoteNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
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

    
    public class BillInvoiceRpt
    {
        #region "Variables Declaration"
        private int _CenCode;
        private int _AreaId;
        private string _CustomerID;
        private int _CustType;
        private int _BillingId;
        private int _UserId;
        private int _InvType;
        private int _InvoiceID;
        private string _FromNo;
        private string _ToNo;
        private string _BillDate;
        private int _INVHDR_LogID;

        #endregion
        public BillInvoiceRpt() { }
        public BillInvoiceRpt(int CenCode, int AreaId, string CustomerID, int CustType, int BillingId, int UserID, int InvType, int InvoiceID, string FromNo, string ToNo, string BillDate, int INVHDR_LogID)
        {
            this._CenCode = CenCode;
            this._AreaId = AreaId;
            this._CustomerID = CustomerID;
            this._CustType = CustType;
            this._BillingId = BillingId;
            this._UserId = UserId;
            this._InvType = InvType;
            this._InvoiceID = InvoiceID;
            this._FromNo = FromNo;
            this._ToNo = ToNo;
            this._BillDate = BillDate;
            this._INVHDR_LogID = INVHDR_LogID;
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
        public int AreaId
        {
            get { return _AreaId; }
            set { _AreaId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BillingId
        {
            get { return _BillingId; }
            set { _BillingId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int InvType
        {
            get { return _InvType; }
            set { _InvType = value; }
        } /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }

        public string FromNo
        {
            get { return _FromNo; }
            set { _FromNo = value; }
        }

        public string ToNo
        {
            get { return _ToNo; }
            set { _ToNo = value; }
        }
        public string BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        public int INVHDR_LogID
        {
            get { return _INVHDR_LogID; }
            set { _INVHDR_LogID = value; }
        }

    }
    
    public class CorporateBillRpt
    {
        #region "Variables Declaration"

        private int _CorpId;
        private int _BillingId;
        private int _UserId;

        #endregion
        public CorporateBillRpt() { }
        public CorporateBillRpt(int CorpId, int BillingId, int UserId)
        {
            this._CorpId = CorpId;
            this._BillingId = BillingId;
            this._UserId = UserId;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CorpId
        {
            get { return _CorpId; }
            set { _CorpId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BillingId
        {
            get { return _BillingId; }
            set { _BillingId = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }


    
    public class AMCRpt_List
    {
        #region "Variables Declaration"
        private string _ApplicationNo;
        private string _CustomerName;
        private string _Address;
        private string _Area;
        private string _LastAMCDue;
        private int _NoOfAMCPaid;
        private string _AMCCSV_Date;
        private int _AMCCSV_MeterNo;
        private string _AMCCSV_Regulator;
        private decimal _AMCCSV_Pressure;
        private int _AMCCSV_ExtraKitchen;
        private int _AMCCSV_ExtraBathroom;
        private string _AMCCSV_Leakage;
        private string _AMCCSV_SingleVentilation;
        private string _AMCCSV_HouseClosed;
        private string _AMCCSV_DCForceDC;
        private string _AMCCSV_DMLT;
        private string _AMCCSV_PHC;
        private string _AMCCSV_UnSafeConn;
        private int _AMCCSV_MeterStop;
        private int _AMCCSV_ChangeRubTube;
        private int _AMCCSV_ChangeNeoRubCap;
        private int _AMCCSV_ChangeRubTubeClamp;
        private int _AMCCSV_ChangeMainISOValve;
        private int _AMCCSV_ChangeAdapter;
        private int _AMCCSV_ChangeTF;
        private int _AMCCSV_ChangeGIElbow;
        private int _AMCCSV_ChangeHexNipple;
        private int _AMCCSV_ChangeGIClamp;
        private int _AMCCSV_ChangeORingAdapter;
        private int _AMCCSV_ChangeORingUnion;
        private int _AMCCSV_ChangeScrew;
        private int _AMCCSV_ChangeRollPlug;
        private int _AMCCSV_ChangeRCCGuardNail;
        private int _AMCCSV_ChangeGIUnion;
        private int _AMCCSV_ChangePECoupler;
        private int _AMCCSV_LeakageInMainISOValve;
        private int _AMCCSV_LeakageInRegOrRegAdapter;
        private int _AMCCSV_LeakageInUnion;
        private int _AMCCSV_LeakageInMeterOrMeterAdapter;
        private int _AMCCSV_LeakageInTF;
        private int _AMCCSV_LeakageInGIFitting;
        private int _AMCCSV_LeakageInRubTube;
        private string _AMCCSV_Remarks;

        private int _Count;
        #endregion
        public AMCRpt_List() { }
        public AMCRpt_List(string ApplicationNo, string CustomerName, string Address, string Area, string LastAMCDue, int NoOfAMCPaid, string AMCCSV_Date, int AMCCSV_MeterNo, string AMCCSV_Regulator, decimal AMCCSV_Pressure, int AMCCSV_ExtraKitchen, int AMCCSV_ExtraBathroom, string AMCCSV_Leakage, string AMCCSV_SingleVentilation, string AMCCSV_HouseClosed, string AMCCSV_DCForceDC, string AMCCSV_DMLT, string AMCCSV_PHC, string AMCCSV_UnSafeConn, int AMCCSV_MeterStop, int AMCCSV_ChangeRubTube, int AMCCSV_ChangeNeoRubCap, int AMCCSV_ChangeRubTubeClamp, int AMCCSV_ChangeMainISOValve, int AMCCSV_ChangeAdapter, int AMCCSV_ChangeTF, int AMCCSV_ChangeGIElbow, int AMCCSV_ChangeHexNipple, int AMCCSV_ChangeGIClamp, int AMCCSV_ChangeORingAdapter, int AMCCSV_ChangeORingUnion, int AMCCSV_ChangeScrew, int AMCCSV_ChangeRollPlug, int AMCCSV_ChangeRCCGuardNail, int AMCCSV_ChangeGIUnion, int AMCCSV_ChangePECoupler, int AMCCSV_LeakageInMainISOValve, int AMCCSV_LeakageInRegOrRegAdapter, int AMCCSV_LeakageInUnion, int AMCCSV_LeakageInMeterOrMeterAdapter, int AMCCSV_LeakageInTF, int AMCCSV_LeakageInGIFitting, int AMCCSV_LeakageInRubTube, string AMCCSV_Remarks, int Count)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerName = CustomerName;
            this._Address = Address;
            this._Area = Area;
            this._LastAMCDue = LastAMCDue;
            this._NoOfAMCPaid = NoOfAMCPaid;
            this._AMCCSV_Date = AMCCSV_Date;
            this._AMCCSV_MeterNo = AMCCSV_MeterNo;
            this._AMCCSV_Regulator = AMCCSV_Regulator;
            this._AMCCSV_Pressure = AMCCSV_Pressure;
            this._AMCCSV_ExtraKitchen = AMCCSV_ExtraKitchen;
            this._AMCCSV_ExtraBathroom = AMCCSV_ExtraBathroom;
            this._AMCCSV_Leakage = AMCCSV_Leakage;
            this._AMCCSV_SingleVentilation = AMCCSV_SingleVentilation;
            this._AMCCSV_HouseClosed = AMCCSV_HouseClosed;
            this._AMCCSV_DCForceDC = AMCCSV_DCForceDC;
            this._AMCCSV_DMLT = AMCCSV_DMLT;
            this._AMCCSV_PHC = AMCCSV_PHC;
            this._AMCCSV_UnSafeConn = AMCCSV_UnSafeConn;
            this._AMCCSV_MeterStop = AMCCSV_MeterStop;
            this._AMCCSV_ChangeRubTube = AMCCSV_ChangeRubTube;
            this._AMCCSV_ChangeNeoRubCap = AMCCSV_ChangeNeoRubCap;
            this._AMCCSV_ChangeRubTubeClamp = AMCCSV_ChangeRubTubeClamp;
            this._AMCCSV_ChangeMainISOValve = AMCCSV_ChangeMainISOValve;
            this._AMCCSV_ChangeAdapter = AMCCSV_ChangeAdapter;
            this._AMCCSV_ChangeTF = AMCCSV_ChangeTF;
            this._AMCCSV_ChangeGIElbow = AMCCSV_ChangeGIElbow;
            this._AMCCSV_ChangeHexNipple = AMCCSV_ChangeHexNipple;
            this._AMCCSV_ChangeGIClamp = AMCCSV_ChangeGIClamp;
            this._AMCCSV_ChangeORingAdapter = AMCCSV_ChangeORingAdapter;
            this._AMCCSV_ChangeORingUnion = AMCCSV_ChangeORingUnion;
            this._AMCCSV_ChangeScrew = AMCCSV_ChangeScrew;
            this._AMCCSV_ChangeRollPlug = AMCCSV_ChangeRollPlug;
            this._AMCCSV_ChangeRCCGuardNail = AMCCSV_ChangeRCCGuardNail;
            this._AMCCSV_ChangeGIUnion = AMCCSV_ChangeGIUnion;
            this._AMCCSV_ChangePECoupler = AMCCSV_ChangePECoupler;
            this._AMCCSV_LeakageInMainISOValve = AMCCSV_LeakageInMainISOValve;
            this._AMCCSV_LeakageInRegOrRegAdapter = AMCCSV_LeakageInRegOrRegAdapter;
            this._AMCCSV_LeakageInUnion = AMCCSV_LeakageInUnion;
            this._AMCCSV_LeakageInMeterOrMeterAdapter = AMCCSV_LeakageInMeterOrMeterAdapter;
            this._AMCCSV_LeakageInTF = AMCCSV_LeakageInTF;
            this._AMCCSV_LeakageInGIFitting = AMCCSV_LeakageInGIFitting;
            this._AMCCSV_LeakageInRubTube = AMCCSV_LeakageInRubTube;
            this._AMCCSV_Remarks = AMCCSV_Remarks;
            this._Count = Count;
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


        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        public string LastAMCDue
        {
            get { return _LastAMCDue; }
            set { _LastAMCDue = value; }
        }

        public int NoOfAMCPaid
        {
            get { return _NoOfAMCPaid; }
            set { _NoOfAMCPaid = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_Date
        {
            get { return _AMCCSV_Date; }
            set { _AMCCSV_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_MeterNo
        {
            get { return _AMCCSV_MeterNo; }
            set { _AMCCSV_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_Regulator
        {
            get { return _AMCCSV_Regulator; }
            set { _AMCCSV_Regulator = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal AMCCSV_Pressure
        {
            get { return _AMCCSV_Pressure; }
            set { _AMCCSV_Pressure = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ExtraKitchen
        {
            get { return _AMCCSV_ExtraKitchen; }
            set { _AMCCSV_ExtraKitchen = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ExtraBathroom
        {
            get { return _AMCCSV_ExtraBathroom; }
            set { _AMCCSV_ExtraBathroom = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_Leakage
        {
            get { return _AMCCSV_Leakage; }
            set { _AMCCSV_Leakage = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_SingleVentilation
        {
            get { return _AMCCSV_SingleVentilation; }
            set { _AMCCSV_SingleVentilation = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_HouseClosed
        {
            get { return _AMCCSV_HouseClosed; }
            set { _AMCCSV_HouseClosed = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_DCForceDC
        {
            get { return _AMCCSV_DCForceDC; }
            set { _AMCCSV_DCForceDC = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_DMLT
        {
            get { return _AMCCSV_DMLT; }
            set { _AMCCSV_DMLT = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_PHC
        {
            get { return _AMCCSV_PHC; }
            set { _AMCCSV_PHC = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_UnSafeConn
        {
            get { return _AMCCSV_UnSafeConn; }
            set { _AMCCSV_UnSafeConn = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_MeterStop
        {
            get { return _AMCCSV_MeterStop; }
            set { _AMCCSV_MeterStop = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeRubTube
        {
            get { return _AMCCSV_ChangeRubTube; }
            set { _AMCCSV_ChangeRubTube = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeNeoRubCap
        {
            get { return _AMCCSV_ChangeNeoRubCap; }
            set { _AMCCSV_ChangeNeoRubCap = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeRubTubeClamp
        {
            get { return _AMCCSV_ChangeRubTubeClamp; }
            set { _AMCCSV_ChangeRubTubeClamp = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeMainISOValve
        {
            get { return _AMCCSV_ChangeMainISOValve; }
            set { _AMCCSV_ChangeMainISOValve = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeAdapter
        {
            get { return _AMCCSV_ChangeAdapter; }
            set { _AMCCSV_ChangeAdapter = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeTF
        {
            get { return _AMCCSV_ChangeTF; }
            set { _AMCCSV_ChangeTF = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeGIElbow
        {
            get { return _AMCCSV_ChangeGIElbow; }
            set { _AMCCSV_ChangeGIElbow = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeHexNipple
        {
            get { return _AMCCSV_ChangeHexNipple; }
            set { _AMCCSV_ChangeHexNipple = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeGIClamp
        {
            get { return _AMCCSV_ChangeGIClamp; }
            set { _AMCCSV_ChangeGIClamp = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeORingAdapter
        {
            get { return _AMCCSV_ChangeORingAdapter; }
            set { _AMCCSV_ChangeORingAdapter = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeORingUnion
        {
            get { return _AMCCSV_ChangeORingUnion; }
            set { _AMCCSV_ChangeORingUnion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeScrew
        {
            get { return _AMCCSV_ChangeScrew; }
            set { _AMCCSV_ChangeScrew = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeRollPlug
        {
            get { return _AMCCSV_ChangeRollPlug; }
            set { _AMCCSV_ChangeRollPlug = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeRCCGuardNail
        {
            get { return _AMCCSV_ChangeRCCGuardNail; }
            set { _AMCCSV_ChangeRCCGuardNail = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangeGIUnion
        {
            get { return _AMCCSV_ChangeGIUnion; }
            set { _AMCCSV_ChangeGIUnion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_ChangePECoupler
        {
            get { return _AMCCSV_ChangePECoupler; }
            set { _AMCCSV_ChangePECoupler = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInMainISOValve
        {
            get { return _AMCCSV_LeakageInMainISOValve; }
            set { _AMCCSV_LeakageInMainISOValve = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInRegOrRegAdapter
        {
            get { return _AMCCSV_LeakageInRegOrRegAdapter; }
            set { _AMCCSV_LeakageInRegOrRegAdapter = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInUnion
        {
            get { return _AMCCSV_LeakageInUnion; }
            set { _AMCCSV_LeakageInUnion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInMeterOrMeterAdapter
        {
            get { return _AMCCSV_LeakageInMeterOrMeterAdapter; }
            set { _AMCCSV_LeakageInMeterOrMeterAdapter = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInTF
        {
            get { return _AMCCSV_LeakageInTF; }
            set { _AMCCSV_LeakageInTF = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInGIFitting
        {
            get { return _AMCCSV_LeakageInGIFitting; }
            set { _AMCCSV_LeakageInGIFitting = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AMCCSV_LeakageInRubTube
        {
            get { return _AMCCSV_LeakageInRubTube; }
            set { _AMCCSV_LeakageInRubTube = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AMCCSV_Remarks
        {
            get { return _AMCCSV_Remarks; }
            set { _AMCCSV_Remarks = value; }
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

    
    public class ReceiptPrint
    {
        #region "Variables Declaration"

        private string _RecieptDate;
        private string _RECHDR_ReceiptRefNo;
        private string _APPMST_CustomerID;
        private string _Customer_Name;
        private decimal _RECHDR_ChequeAmount;
        private string _RECHDR_PayMode;
        private string _RECHDR_ChequeNo;
        private string _RECHDR_ChequeDate;
        private long _APPMST_AppID;
        private string _BillDate;
        private string _BillingCycle;
        private string _BankName;
        private string _CD_Controltype;
        private string _INVHDR_InvNo;
        private string _Rechdr_CenCode;
        private string _RECHDR_ReceiptType;
        private string _RECHDR_FromDate;
        private string _RECHDR_ToDate;
        private string _RECHDR_ReceiptNo;
        private int _UserId;
        #endregion
        public ReceiptPrint() { }
        public ReceiptPrint(string RecieptDate,
         string RECHDR_ReceiptRefNo,
         string APPMST_CustomerID,
         string Customer_Name,
         decimal RECHDR_ChequeAmount,
         string RECHDR_PayMode,
         string RECHDR_ChequeNo,
         string RECHDR_ChequeDate,
         long APPMST_AppID,
         string BillDate,
         string BillingCycle,
         string BankName,
         string CD_Controltype, string INVHDR_InvNo, string Rechdr_CenCode, string RECHDR_ReceiptType, string RECHDR_FromDate, string RECHDR_ToDate, string RECHDR_ReceiptNo, int UserId)
        {

            this._RecieptDate = RecieptDate;
            this._RECHDR_ReceiptRefNo = RECHDR_ReceiptRefNo;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._Customer_Name = Customer_Name;
            this._RECHDR_ChequeAmount = RECHDR_ChequeAmount;
            this._RECHDR_PayMode = RECHDR_PayMode;
            this._RECHDR_ChequeNo = RECHDR_ChequeNo;
            this._RECHDR_ChequeDate = RECHDR_ChequeDate;
            this._APPMST_AppID = APPMST_AppID;
            this._BillDate = BillDate;
            this._BillingCycle = BillingCycle;
            this._BankName = BankName;
            this._CD_Controltype = CD_Controltype;
            this._INVHDR_InvNo = INVHDR_InvNo;
            this._Rechdr_CenCode = Rechdr_CenCode;
            this._RECHDR_ReceiptType = RECHDR_ReceiptType;
            this._RECHDR_FromDate = RECHDR_FromDate;
            this._RECHDR_ToDate = RECHDR_ToDate;
            this._RECHDR_ReceiptNo = RECHDR_ReceiptNo;
            this._UserId = UserId;
        }



        public string RecieptDate
        {
            get { return _RecieptDate; }
            set { _RecieptDate = value; }
        }
        public string RECHDR_ReceiptRefNo
        {
            get { return _RECHDR_ReceiptRefNo; }
            set { _RECHDR_ReceiptRefNo = value; }
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string Customer_Name
        {
            get { return _Customer_Name; }
            set { _Customer_Name = value; }
        }
        public decimal RECHDR_ChequeAmount
        {
            get { return _RECHDR_ChequeAmount; }
            set { _RECHDR_ChequeAmount = value; }
        }
        public string RECHDR_PayMode
        {
            get { return _RECHDR_PayMode; }
            set { _RECHDR_PayMode = value; }
        }
        public string RECHDR_ChequeNo
        {
            get { return _RECHDR_ChequeNo; }
            set { _RECHDR_ChequeNo = value; }
        }
        public string RECHDR_ChequeDate
        {
            get { return _RECHDR_ChequeDate; }
            set { _RECHDR_ChequeDate = value; }
        }
        public long APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public string BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }
        public string BillingCycle
        {
            get { return _BillingCycle; }
            set { _BillingCycle = value; }
        }
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }
        public string CD_Controltype
        {
            get { return _CD_Controltype; }
            set { _CD_Controltype = value; }
        }
        public string INVHDR_InvNo
        {
            get { return _INVHDR_InvNo; }
            set { _INVHDR_InvNo = value; }
        }
        public string Rechdr_CenCode
        {
            get { return _Rechdr_CenCode; }
            set { _Rechdr_CenCode = value; }
        }
        public string RECHDR_ReceiptType
        {
            get { return _RECHDR_ReceiptType; }
            set { _RECHDR_ReceiptType = value; }
        }
        public string RECHDR_FromDate
        {
            get { return _RECHDR_FromDate; }
            set { _RECHDR_FromDate = value; }
        }
        public string RECHDR_ToDate
        {
            get { return _RECHDR_ToDate; }
            set { _RECHDR_ToDate = value; }
        }
        public string RECHDR_ReceiptNo
        {
            get { return _RECHDR_ReceiptNo; }
            set { _RECHDR_ReceiptNo = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

    }

    
    public class CenterwiseStatus
    {
        #region "Variables Declaration"
        private string _CenterName;
        private int _NoOfRegistration;
        private int _OpenStatus;
        private int _ToBeInstalledStatus;
        private int _InstalledStatus;
        private int _CommissionedStatus;
        private int _TempDisconnStatus;
        private int _PermDisconnStatus;
        private int _ReconnStatus;
        private int _AppCancelledStatus;
        private int _PNGConsumersStatus;
        private int _ForceTempDisconnected;
        private int _ForcePermDisconnected;
        private int _Count;
        private int _Enrolments;
        private int _Applications;
        private int _PaymentsToBeRealized;
        private int _RegChequeDishonored;
        private int _Registrations;


        #endregion
        public CenterwiseStatus() { }
        public CenterwiseStatus(string CenterName, int NoOfRegistration, int OpenStatus, int ToBeInstalledStatus, int InstalledStatus, int CommissionedStatus, int TempDisconnStatus, int PermDisconnStatus, int ReconnStatus, int AppCancelledStatus, int PNGConsumersStatus, int ForceTempDisconnected, int ForcePermDisconnected, int Count, int Enrolments, int Applications, int PaymentsToBeRealized, int RegChequeDishonored, int Registrations)
        {
            this._CenterName = CenterName;
            this._NoOfRegistration = NoOfRegistration;
            this._OpenStatus = OpenStatus;
            this._ToBeInstalledStatus = ToBeInstalledStatus;
            this._InstalledStatus = InstalledStatus;
            this._CommissionedStatus = CommissionedStatus;
            this._TempDisconnStatus = TempDisconnStatus;
            this._PermDisconnStatus = PermDisconnStatus;
            this._ReconnStatus = ReconnStatus;
            this._AppCancelledStatus = AppCancelledStatus;
            this._PNGConsumersStatus = PNGConsumersStatus;
            this._ForceTempDisconnected = ForceTempDisconnected;
            this._ForcePermDisconnected = ForcePermDisconnected;
            this._Count = Count;
            this._Enrolments = Enrolments;
            this._Applications = Applications;
            this._PaymentsToBeRealized = PaymentsToBeRealized;
            this._RegChequeDishonored = RegChequeDishonored;
            this._Registrations = Registrations;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NoOfRegistration
        {
            get { return _NoOfRegistration; }
            set { _NoOfRegistration = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OpenStatus
        {
            get { return _OpenStatus; }
            set { _OpenStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ToBeInstalledStatus
        {
            get { return _ToBeInstalledStatus; }
            set { _ToBeInstalledStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int InstalledStatus
        {
            get { return _InstalledStatus; }
            set { _InstalledStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CommissionedStatus
        {
            get { return _CommissionedStatus; }
            set { _CommissionedStatus = value; }
        }

        public int TempDisconnStatus
        {
            get { return _TempDisconnStatus; }
            set { _TempDisconnStatus = value; }
        }

        public int PermDisconnStatus
        {
            get { return _PermDisconnStatus; }
            set { _PermDisconnStatus = value; }
        }

        public int ReconnStatus
        {
            get { return _ReconnStatus; }
            set { _ReconnStatus = value; }
        }

        public int AppCancelledStatus
        {
            get { return _AppCancelledStatus; }
            set { _AppCancelledStatus = value; }
        }

        public int PNGConsumersStatus
        {
            get { return _PNGConsumersStatus; }
            set { _PNGConsumersStatus = value; }
        }
        public int ForceTempDisconnected
        {
            get { return _ForceTempDisconnected; }
            set { _ForceTempDisconnected = value; }
        }

        public int ForcePermDisconnected
        {
            get { return _ForcePermDisconnected; }
            set { _ForcePermDisconnected = value; }
        }


        public int Enrolments
        {
            get { return _Enrolments; }
            set { _Enrolments = value; }
        }

        public int Applications
        {
            get { return _Applications; }
            set { _Applications = value; }
        }

        public int PaymentsToBeRealized
        {
            get { return _PaymentsToBeRealized; }
            set { _PaymentsToBeRealized = value; }
        }

        public int RegChequeDishonored
        {
            get { return _RegChequeDishonored; }
            set { _RegChequeDishonored = value; }
        }

        public int Registrations
        {
            get { return _Registrations; }
            set { _Registrations = value; }
        }



        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }

    
    public class OnlinepaymentReport
    {
        #region "Variables Declaration"
        private string _ReceiptDate;
        private int _Receipts;
        private string _PayMode;
        private string _PayStatus;
        private decimal _Amount;
        private int _Count;
        private int _TotalReceipts;
        private decimal _TotalAmount;

        #endregion

        public OnlinepaymentReport() { }
        public OnlinepaymentReport(string ReceiptDate, int Receipts, string PayMode, string PayStatus, decimal Amount, int Count, int TotalReceipts, decimal TotalAmount)
        {
            this._ReceiptDate = ReceiptDate;
            this._Receipts = Receipts;
            this._PayMode = PayMode;
            this._PayStatus = PayStatus;
            this._Amount = Amount;
            this._Count = Count;
            this._TotalReceipts = TotalReceipts;
            this._TotalAmount = TotalAmount;
        }

        public string ReceiptDate
        {
            get { return _ReceiptDate; }
            set { _ReceiptDate = value; }
        }

        public int Receipts
        {
            get { return _Receipts; }
            set { _Receipts = value; }
        }
        public string PayMode
        {
            get { return _PayMode; }
            set { _PayMode = value; }
        }

        public string PayStatus
        {
            get { return _PayStatus; }
            set { _PayStatus = value; }
        }

        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public int TotalReceipts
        {
            get { return _TotalReceipts; }
            set { _TotalReceipts = value; }
        }
        public decimal TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }

    }

    
    public class OnlinepaymentReportgrid
    {
        #region "Variables Declaration"
        private string _ReceiptDate;
        private int _ReceiptID;
        private string _ReceiptNo;
        private string _ReceiptType;
        private string _PayMode;
        private string _PayStatus;
        private decimal _Amount;
        private string _InstNo;
        private string _InstDate;
        private int _Count;

        #endregion

        public OnlinepaymentReportgrid() { }
        public OnlinepaymentReportgrid(string ReceiptDate, int ReceiptID, string ReceiptNo, string ReceiptType, string PayMode, string PayStatus, decimal Amount, string InstNo, string InstDate, int Count)
        {
            this._ReceiptDate = ReceiptDate;
            this._ReceiptID = ReceiptID;
            this._ReceiptNo = ReceiptNo;
            this._ReceiptType = ReceiptType;
            this._PayMode = PayMode;
            this._PayStatus = PayStatus;
            this._Amount = Amount;
            this._InstNo = InstNo;
            this._InstDate = InstDate;
            this._Count = Count;
        }

        public string ReceiptDate
        {
            get { return _ReceiptDate; }
            set { _ReceiptDate = value; }
        }

        public int ReceiptID
        {
            get { return _ReceiptID; }
            set { _ReceiptID = value; }
        }

        public string ReceiptNo
        {
            get { return _ReceiptNo; }
            set { _ReceiptNo = value; }
        }

        public string ReceiptType
        {
            get { return _ReceiptType; }
            set { _ReceiptType = value; }
        }

        public string PayMode
        {
            get { return _PayMode; }
            set { _PayMode = value; }
        }

        public string PayStatus
        {
            get { return _PayStatus; }
            set { _PayStatus = value; }
        }

        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public string InstNo
        {
            get { return _InstNo; }
            set { _InstNo = value; }
        }
        public string InstDate
        {
            get { return _InstDate; }
            set { _InstDate = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    
    public class CenterwiseChequeStatus
    {
        #region "Variables Declaration"
        private string _CenterName;
        private int _NoOfCheques;
        private int _InHandCheques;
        private int _ForClearingCheques;
        private int _RealizedCheques;
        private int _DishonouredCheques;
        private int _DishonouredReprCheques;
        private int _DishonuredReplCheques;
        private int _Count;
        #endregion

        public CenterwiseChequeStatus() { }
        public CenterwiseChequeStatus(string CenterName, int NoOfCheques, int InHandCheques, int ForClearingCheques, int RealizedCheques, int DishonouredCheques, int DishonouredReprCheques, int DishonuredReplCheques, int Count)
        {
            this._CenterName = CenterName;
            this._NoOfCheques = NoOfCheques;
            this._InHandCheques = InHandCheques;
            this._ForClearingCheques = ForClearingCheques;
            this._RealizedCheques = RealizedCheques;
            this._DishonouredCheques = DishonouredCheques;
            this._DishonouredReprCheques = DishonouredReprCheques;
            this._DishonuredReplCheques = DishonuredReplCheques;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NoOfCheques
        {
            get { return _NoOfCheques; }
            set { _NoOfCheques = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int InHandCheques
        {
            get { return _InHandCheques; }
            set { _InHandCheques = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ForClearingCheques
        {
            get { return _ForClearingCheques; }
            set { _ForClearingCheques = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RealizedCheques
        {
            get { return _RealizedCheques; }
            set { _RealizedCheques = value; }
        }
        /// <summary>s
        //Write Column Description here. 
        /// </summary>
        public int DishonouredCheques
        {
            get { return _DishonouredCheques; }
            set { _DishonouredCheques = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DishonouredReprCheques
        {
            get { return _DishonouredReprCheques; }
            set { _DishonouredReprCheques = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DishonuredReplCheques
        {
            get { return _DishonuredReplCheques; }
            set { _DishonuredReplCheques = value; }
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

    
    public class HeadwiseReceiptList
    {
        #region "Variables Declaration"
        private int _CDUTRN_ApplicationId;
        private string _APPMST_AppNo;
        private string _APPMST_AppDate;
        private string _CDUTRN_RecDate;
        private string _APPMST_CustomerID;
        private string _CustomerName;
        private string _TypeofCust;
        private string _HeadName;
        private int _CDUTRN_AmountDue;
        private int _CDUTRN_AmountReceived;
        private int _OustStanding;
        private int _Count;
        #endregion
        public HeadwiseReceiptList() { }
        public HeadwiseReceiptList(int CDUTRN_ApplicationId, string APPMST_AppNo, string APPMST_AppDate, string CDUTRN_RecDate, string APPMST_CustomerID, string CustomerName, string TypeofCust, string HeadName, int CDUTRN_AmountDue, int CDUTRN_AmountReceived, int OustStanding, int Count)
        {
            this._CDUTRN_ApplicationId = CDUTRN_ApplicationId;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppDate = APPMST_AppDate;
            this._CDUTRN_RecDate = CDUTRN_RecDate;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._CustomerName = CustomerName;
            this._TypeofCust = TypeofCust;
            this._HeadName = HeadName;
            this._CDUTRN_AmountDue = CDUTRN_AmountDue;
            this._CDUTRN_AmountReceived = CDUTRN_AmountReceived;
            this._OustStanding = OustStanding;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDUTRN_ApplicationId
        {
            get { return _CDUTRN_ApplicationId; }
            set { _CDUTRN_ApplicationId = value; }
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
        public string CDUTRN_RecDate
        {
            get { return _CDUTRN_RecDate; }
            set { _CDUTRN_RecDate = value; }
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
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string TypeofCust
        {
            get { return _TypeofCust; }
            set { _TypeofCust = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string HeadName
        {
            get { return _HeadName; }
            set { _HeadName = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDUTRN_AmountDue
        {
            get { return _CDUTRN_AmountDue; }
            set { _CDUTRN_AmountDue = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CDUTRN_AmountReceived
        {
            get { return _CDUTRN_AmountReceived; }
            set { _CDUTRN_AmountReceived = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OustStanding
        {
            get { return _OustStanding; }
            set { _OustStanding = value; }
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

    
    public class BillingReportList
    {
        #region "Variables Declaration"
        private string _APPMST_CustomerID;
        private string _Name;
        private string _BCCMST_ShortName;
        private string _PrevReadingDate;
        private string _METTRN_ReadingDate;
        private float _METTRN_PrevReading;
        private float _METTRN_CurrentReading;
        private float _ConsumedUnits;
        private int _ConsumptionDays;
        private float _Consumptionfactor;
        private float _AVGConsumptionfactor;
        private int _Count;
        #endregion
        public BillingReportList() { }
        public BillingReportList(string APPMST_CustomerID, string Name, string BCCMST_ShortName, string PrevReadingDate, string METTRN_ReadingDate, float METTRN_PrevReading, float METTRN_CurrentReading, float ConsumedUnits, int ConsumptionDays, float Consumptionfactor, float AVGConsumptionfactor ,int Count)
        {
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._Name = Name;
            this._BCCMST_ShortName = BCCMST_ShortName;
            this._PrevReadingDate = PrevReadingDate;
            this._METTRN_ReadingDate = METTRN_ReadingDate;
            this._METTRN_PrevReading = METTRN_PrevReading;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
            this._ConsumedUnits = ConsumedUnits;
            this._ConsumptionDays = ConsumptionDays;
            this._Consumptionfactor = Consumptionfactor;
            this._AVGConsumptionfactor = AVGConsumptionfactor;
            this._Count = Count;
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }

        public string PrevReadingDate
        {
            get { return _PrevReadingDate; }
            set { _PrevReadingDate = value; }
        }

        public string METTRN_ReadingDate
        {
            get { return _METTRN_ReadingDate; }
            set { _METTRN_ReadingDate = value; }
        }

        public float METTRN_PrevReading
        {
            get { return _METTRN_PrevReading; }
            set { _METTRN_PrevReading = value; }
        }

        public float METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }

        public float ConsumedUnits
        {
            get { return _ConsumedUnits; }
            set { _ConsumedUnits = value; }
        }
        public int ConsumptionDays
        {
            get { return _ConsumptionDays; }
            set { _ConsumptionDays = value; }
        }
        public float Consumptionfactor
        {
            get { return _Consumptionfactor; }
            set { _Consumptionfactor = value; }
        }
        public float AVGConsumptionfactor
        {
            get { return _AVGConsumptionfactor; }
            set { _AVGConsumptionfactor = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    
    public class BILReportList
    {
        #region "Variables Declaration"
        private int _INVHDR_InvoiceID;
        private string _INVHDR_InvNo;
        private string _BillingCycle;
        private string _Customer_Id;
        private string _Name;
        private decimal _INVHDR_ConsumedUnit;
        private decimal _INVHDR_GasPrice;
        private decimal _INVHDR_GasAmount;
        private decimal _INVHDR_MinUnit;
        private decimal _INVHDR_MinCharges;
        private decimal _INVHDR_Rent;
        private decimal _INVHDR_AMC;
        private decimal _RebateAmount;
        private decimal _NetTotal;
        private decimal _Previousbalance;
        private decimal _PLatePayment;
        private decimal _INVHDR_InstallmentAmount;
        private decimal _INVHDR_SecurityDeposit;
        private decimal _INVHDR_DebitNoteAmount;
        private decimal _Total_Amt_Due;
        private decimal _INVHDR_LatePayment;
        private decimal _Total_Amt_Due_Date;
        private string _INVHDR_DueDate;
        private decimal _INVHDR_RecieptAmount;
        private decimal _INVHDR_ClosingBalance;

        private string _INVHDR_InvDate;
        private decimal _INVHDR_ApplicationId;
        private int _Count;
        private decimal _INVHDR_CurrentReading;
        private int _INVHDR_BillingId;
        private decimal _INVHDR_RebateQty;
        private int _INVHDR_CorporateId;
        private decimal _RealizedAmt;
        private string _INVHDR_PayType;
        private decimal _ActRealizedAmt;
        private decimal _INVHDR_CreditNoteAmount;
        private string _receiptType;
        private decimal _INVHDR_LatePayment1;
        private decimal _INVHDR_RegChargesAmount;

        #endregion

        public BILReportList() { }
        public BILReportList(int INVHDR_InvoiceID, string INVHDR_InvNo, string BillingCycle,
            string Customer_Id, string Name, decimal INVHDR_ConsumedUnit, decimal INVHDR_GasPrice,
            decimal INVHDR_GasAmount, decimal INVHDR_MinUnit, decimal INVHDR_Mincharges, decimal INVHDR_Rent,
            decimal INVHDR_AMC, decimal RebateAmount, decimal NetTotal, decimal Previousbalance,
            decimal PLatePayment, decimal INVHDR_InstallmentAmount, decimal INVHDR_SecurityDeposit,
            decimal INVHDR_DebitNoteAmount, decimal Total_Amt_Due, decimal INVHDR_LatePayment,
            decimal Total_Amt_Due_Date, string INVHDR_DueDate, decimal INVHDR_RecieptAmount,
            decimal INVHDR_ClosingBalance, string INVHDR_InvDate, decimal INVHDR_ApplicationId,
            decimal INVHDR_CurrentReading, int INVHDR_BillingId, decimal INVHDR_RebateQty, int INVHDR_CorporateId, decimal RealizedAmt, string INVHDR_PayType,
            decimal ActRealizedAmt, decimal INVHDR_CreditNoteAmount, int Count, string receiptType, decimal INVHDR_LatePayment1, decimal INVHDR_RegChargesAmount)
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
            this._Previousbalance = Previousbalance;
            this._PLatePayment = PLatePayment;
            this.INVHDR_InstallmentAmount = INVHDR_InstallmentAmount;
            this.INVHDR_SecurityDeposit = INVHDR_SecurityDeposit;
            this._INVHDR_DebitNoteAmount = INVHDR_DebitNoteAmount;
            this._Total_Amt_Due = Total_Amt_Due;
            this._INVHDR_LatePayment = INVHDR_LatePayment;
            this._Total_Amt_Due_Date = Total_Amt_Due_Date;
            this._INVHDR_DueDate = INVHDR_DueDate;
            this._INVHDR_RecieptAmount = INVHDR_RecieptAmount;
            this._INVHDR_ClosingBalance = INVHDR_ClosingBalance;

            this._INVHDR_InvDate = INVHDR_InvDate;
            this._INVHDR_ApplicationId = INVHDR_ApplicationId;
            this._INVHDR_CurrentReading = INVHDR_CurrentReading;
            this.INVHDR_BillingId = INVHDR_BillingId;
            this._INVHDR_RebateQty = INVHDR_RebateQty;
            this._INVHDR_CorporateId = INVHDR_CorporateId;
            this._RealizedAmt = RealizedAmt;
            this._INVHDR_PayType = INVHDR_PayType;
            this._ActRealizedAmt = ActRealizedAmt;
            this._INVHDR_CreditNoteAmount = INVHDR_CreditNoteAmount;
            this._Count = Count;
            this._receiptType = receiptType;
            this._INVHDR_LatePayment1 = INVHDR_LatePayment1;
            this._INVHDR_RegChargesAmount = INVHDR_RegChargesAmount;

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

        public string receiptType
        {
            get { return _receiptType; }
            set { _receiptType = value; }
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

        public decimal Total_Amt_Due
        {
            get { return _Total_Amt_Due; }
            set { _Total_Amt_Due = value; }
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

        public string INVHDR_InvDate
        {
            get { return _INVHDR_InvDate; }
            set { _INVHDR_InvDate = value; }
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
        public decimal RealizedAmt
        {
            get { return _RealizedAmt; }
            set { _RealizedAmt = value; }
        }
        public string INVHDR_PayType
        {
            get { return _INVHDR_PayType; }
            set { _INVHDR_PayType = value; }
        }
        public decimal INVHDR_LatePayment1
        {
            get { return _INVHDR_LatePayment1; }
            set { _INVHDR_LatePayment1 = value; }
        }

        public decimal ActRealizedAmt
        {
            get { return _ActRealizedAmt; }
            set { _ActRealizedAmt = value; }
        }
        public decimal INVHDR_CreditNoteAmount
        {
            get { return _INVHDR_CreditNoteAmount; }
            set { _INVHDR_CreditNoteAmount = value; }
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
    }
    
    public class JobSheetDetailList
    {
        #region "Variables Declaration"
        private string _EngineerName;
        private string _DateofInst;
        private string _APPMST_CustomerID;
        private string _APPMST_AppNo;
        private string _CENMST_Name;
        private string _DateOfComm;
        private string _CreatedDate;
        private string _OMStatus;
        private string _JobSheetType;
        private string _Latitude;
        private string _Longitude;
        private int _JOBHDR_JobSheetType;
        private int _Count;
        #endregion
        public JobSheetDetailList() { }
        public JobSheetDetailList(string EngineerName, string DateofInst, string APPMST_CustomerID, string APPMST_AppNo,
            string CENMST_Name, string DateOfComm, string CreatedDate, string OMStatus, string JobSheetType, int JOBHDR_JobSheetType, string Latitude, string Longitude, int Count)
        {

            this._EngineerName = EngineerName;
            this._DateofInst = DateofInst;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CENMST_Name = CENMST_Name;
            this._DateOfComm = DateOfComm;
            this._CreatedDate = CreatedDate;
            this._OMStatus = OMStatus;
            this._JobSheetType = JobSheetType;
            this._JOBHDR_JobSheetType = JOBHDR_JobSheetType;
            this._Latitude = Latitude;
            this._Longitude = Longitude;
            this._Count = Count;
        }
        public string EngineerName
        {
            get { return _EngineerName; }
            set { _EngineerName = value; }
        }
        public string DateofInst
        {
            get { return _DateofInst; }
            set { _DateofInst = value; }
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
        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }
        public string DateOfComm
        {
            get { return _DateOfComm; }
            set { _DateOfComm = value; }
        }
        public string CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        public string OMStatus
        {
            get { return _OMStatus; }
            set { _OMStatus = value; }
        }
        public string JobSheetType
        {
            get { return _JobSheetType; }
            set { _JobSheetType = value; }
        }
        public int JOBHDR_JobSheetType
        {
            get { return _JOBHDR_JobSheetType; }
            set { _JOBHDR_JobSheetType = value; }
        }
        public string Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }
        public string Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    
    public class MaterialEstimationRpt
    {
        #region "Variables Declaration"
        private int _CenCode;
        private int _EstimationID;
        private int _UserId;
        #endregion
        public MaterialEstimationRpt() { }
        // public MaterialEstimationRpt(int CenCode, int CustType, int WorkType, int AreaId, string DebitNoteRefNo, string ApplicationNo, string FromDate, string ToDate, int UserID)
        public MaterialEstimationRpt(int CenCode, int EstimationID, int UserID)
        {
            this._CenCode = CenCode;
            this._UserId = UserId;
            this._EstimationID = EstimationID;

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
        public int EstimationID
        {
            get { return _EstimationID; }
            set { _EstimationID = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }

    
    public class DomesticCustomerStatus
    {
        #region "Variables Declaration"
        private string _CenterName;
        private int _RegEnrol;
        private int _Registration;
        private int _Conversion;
        private double _ConversionPercent;
    #endregion

        public DomesticCustomerStatus() { }
        public DomesticCustomerStatus(string CenterName, int RegEnrol, int Registration, int Conversion, double ConversionPercent)
        {
            this._CenterName = CenterName;
            this._RegEnrol = RegEnrol;
            this._Registration = Registration;
            this._Conversion = Conversion;
            this._ConversionPercent = ConversionPercent;
            
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RegEnrol
        {
            get { return _RegEnrol; }
            set { _RegEnrol = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Registration
        {
            get { return _Registration; }
            set { _Registration = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Conversion
        {
            get { return _Conversion; }
            set { _Conversion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public double ConversionPercent
        {
            get { return _ConversionPercent; }
            set { _ConversionPercent = value; }
        }


    }

    
    public class CSMCallReport
    {
        #region "Variables Declaration"
        private string _SrNo;
        private string _AppNo;
        private string _CustomerID;
        private string _RequestDate;
        private string _Status;
        private string _EstimatedFinishDate;
        private string _OverDueDays;
        private string _ComplainCategory;
        private string _ComplainType;
        private string _ResponsiblePerson;
        private string _CurrentLevel;
        private string _ComplainEscalationto;
        private string _AppStatus;
        private string _CustomerName;
        private string _Address;
        private string _Area;
        private string _MobileNo;
        private string _RegistrationDate;
        private string _CommissioningDate;
        private int _Count;

        #endregion

        #region constructor

        public CSMCallReport() { }
          public CSMCallReport(string SrNo, string AppNo, string CustomerID, string RequestDate, string Status, string EstimatedFinishDate, string OverDueDays,
              string ComplainCategory, string ComplainType, string ResponsiblePerson, string CurrentLevel, string ComplainEscalationto, string AppStatus, string CustomerName,
             string Address, string Area, string MobileNo, string RegistrationDate, string CommissioningDate,int count)
        {
            this._SrNo = SrNo;
            this._AppNo = AppNo;
            this._CustomerID = CustomerID;
            this._RequestDate = RequestDate;
            this._Status = Status;
            this._EstimatedFinishDate = EstimatedFinishDate;
            this._OverDueDays = OverDueDays;
            this._ComplainCategory = ComplainCategory;
            this._ComplainType = ComplainType;
            this._ResponsiblePerson = ResponsiblePerson;
            this._CurrentLevel = CurrentLevel;
            this._ComplainEscalationto = ComplainEscalationto;
            this._AppStatus = AppStatus;
            this._CustomerName = CustomerName;
            this._Address = Address;
            this._Area = Area;
            this._MobileNo = MobileNo;
            this._RegistrationDate = RegistrationDate;
            this._CommissioningDate = CommissioningDate;

            this._Count = count;

        }
        #endregion

          #region Property

          public int count
          {
              get { return _Count; }
              set { _Count = value; }
          }
          public string SrNo
          {
              get { return _SrNo; }
              set { _SrNo = value; }
          }

        
         
        public string AppNo
          {
              get { return _AppNo; }
              set { _AppNo = value; }
          }
        
        public string CustomerID
          {
              get { return _CustomerID; }
              set { _CustomerID = value; }
          }

          public string RequestDate
          {
              get { return _RequestDate; }
              set { _RequestDate = value; }
          }

        public string Status
          {
              get { return _Status; }
              set { _Status = value; }
          }
          public string EstimatedFinishDate
          {
              get { return _EstimatedFinishDate; }
              set { _EstimatedFinishDate = value; }
          }
        
        public string OverDueDays
          {
              get { return _OverDueDays; }
              set { _OverDueDays = value; }
          }
          public string ComplainCategory
          {
              get { return _ComplainCategory; }
              set { _ComplainCategory = value; }
          }

          public string ComplainType
          {
              get { return _ComplainType; }
              set { _ComplainType = value; }
          }
          public string ResponsiblePerson
          {
              get { return _ResponsiblePerson; }
              set { _ResponsiblePerson = value; }
          }

          public string CurrentLevel
          {
              get { return _CurrentLevel; }
              set { _CurrentLevel = value; }
          }

          public string ComplainEscalationto
          {
              get { return _ComplainEscalationto; }
              set { _ComplainEscalationto = value; }
          }

          public string AppStatus
          {
              get { return _AppStatus; }
              set { _AppStatus = value; }
          }
        
        public string CustomerName
          {
              get { return _CustomerName; }
              set { _CustomerName = value; }
          }
          public string Address
          {
              get { return _Address; }
              set { _Address = value; }
          }
          public string Area
          {
              get { return _Area; }
              set { _Area = value; }
          }
        
        public string MobileNo
          {
              get { return _MobileNo; }
              set { _MobileNo = value; }
          }

        
        
        public string RegistrationDate
          {
              get { return _RegistrationDate; }
              set { _RegistrationDate = value; }
          }

          public string CommissioningDate
          {
              get { return _CommissioningDate; }
              set { _CommissioningDate = value; }
          }

        
        #endregion
    }

    
    public class AgeingRpt
    {
        #region "Variables Declaration"
        private string _CustomerID;
        private int _CenterCode;
        private string _FromDate;
        private int _CityCode;
        private int _AreaCode;
        #endregion
        public AgeingRpt() { }
        public AgeingRpt( string CustomerID,int CenterCode,int CityCode,int AreaCode, string FromDate)
        {
            this._CustomerID = CustomerID;
            this._CenterCode = CenterCode;
            this._FromDate = FromDate;
        this._CityCode = CityCode;
        this._AreaCode = AreaCode;
           
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        public int CenterCode
        {
            get { return _CenterCode; }
            set { _CenterCode = value; }
        }
        public int AreaCode
        {
            get { return _AreaCode; }
            set { _AreaCode = value; }
        }
        public int CityCode
        {
            get { return _CityCode; }
            set { _CityCode = value; }
        }

        public string FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
    }
}


