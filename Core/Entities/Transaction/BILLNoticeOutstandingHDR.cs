//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILLNoticeOutstandingHDR.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILLNoticeOutstandingHDRService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILLNoticeOutstandingHDR
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _ApplicationId;
        private string _CustomerID;
        private string _CustomerName;
        private string _Address;
        private string _Area;
        private string _PlanName;
        private string _DebiteNoteNo;
        private string _DebiteNoteDate;
        private decimal _TotalDue;
        private decimal _TotalReceived;
        private decimal _DebitNoteOutstandingAmount;
        private decimal _TotalDuaAmount;
        private decimal _TotalLatePayment;
        private decimal _TotalBillDueAmount;
        private decimal _TotalNetBillAmount;
        private decimal _TotalOutStandingAmount;
        private string _NoticeIssued;
        #endregion

        /// <summary>
        /// Default constructor for BILLNoticeOutstandingHDR class.
        /// </summary>
        public BILLNoticeOutstandingHDR() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILLNoticeOutstandingHDR(decimal ApplicationId, string CustomerID, string CustomerName, string Address, string Area, string PlanName, string DebiteNoteNo, string DebiteNoteDate, decimal TotalDue, decimal TotalReceived, decimal DebitNoteOutstandingAmount, decimal TotalDuaAmount, decimal TotalLatePayment, decimal TotalBillDueAmount, decimal TotalNetBillAmount, decimal TotalOutStandingAmount, string NoticeIssued)
        {
            this._ApplicationId = ApplicationId;
            this._CustomerID = CustomerID;
            this._CustomerName = CustomerName;
            this._Address = Address;
            this._Area = Area;
            this._PlanName = PlanName;
            this._DebiteNoteNo = DebiteNoteNo;
            this._DebiteNoteDate = DebiteNoteDate;
            this._TotalDue = TotalDue;
            this._TotalReceived = TotalReceived;
            this._DebitNoteOutstandingAmount = DebitNoteOutstandingAmount;
            this._TotalDuaAmount = TotalDuaAmount;
            this._TotalLatePayment = TotalLatePayment;
            this._TotalBillDueAmount = TotalBillDueAmount;
            this._TotalNetBillAmount = TotalNetBillAmount;
            this._TotalOutStandingAmount = TotalOutStandingAmount;
            this._NoticeIssued = NoticeIssued;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal ApplicationId
        {
            get { return _ApplicationId; }
            set { _ApplicationId = value; }
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
        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
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
        public string DebiteNoteDate
        {
            get { return _DebiteNoteDate; }
            set { _DebiteNoteDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalDue
        {
            get { return _TotalDue; }
            set { _TotalDue = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalReceived
        {
            get { return _TotalReceived; }
            set { _TotalReceived = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DebitNoteOutstandingAmount
        {
            get { return _DebitNoteOutstandingAmount; }
            set { _DebitNoteOutstandingAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalDuaAmount
        {
            get { return _TotalDuaAmount; }
            set { _TotalDuaAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalLatePayment
        {
            get { return _TotalLatePayment; }
            set { _TotalLatePayment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalBillDueAmount
        {
            get { return _TotalBillDueAmount; }
            set { _TotalBillDueAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalNetBillAmount
        {
            get { return _TotalNetBillAmount; }
            set { _TotalNetBillAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalOutStandingAmount
        {
            get { return _TotalOutStandingAmount; }
            set { _TotalOutStandingAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NoticeIssued
        {
            get { return _NoticeIssued; }
            set { _NoticeIssued = value; }
        }

    }

    public class BILLNoticeOutstandingHDRList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS

        #region "Variables Declaration"
        private decimal _KeyField;
        private string _CustomerID;
        private string _CustomerName;
        private string _Address;
        private string _Area;
        private string _PlanName;
        private decimal _TotalDue;
        private decimal _TotalReceived;
        private decimal _DebitNoteOutstandingAmount;
        private decimal _TotalDuaAmount;
        private decimal _TotalLatePayment;
        private decimal _TotalBillDueAmount;
        private decimal _TotalNetBillAmount;
        private decimal _BillAmt;
        private decimal _DebitNoteAmount;
        private decimal _LatePayment;
        private decimal _TotalOutStandingAmount;
        private string _NoticeIssued;
        private string _InvoiceNo;
        private string _InvoiceDate;
        private int _Count;
        #endregion

        public BILLNoticeOutstandingHDRList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public BILLNoticeOutstandingHDRList(decimal LatePayment,decimal DebitNoteAmount,decimal BillAmt,decimal KeyField, string CustomerID, string CustomerName, string Address, string Area, string PlanName, decimal TotalOutStandingAmount, string NoticeIssued, string InvoiceNo, string InvoiceDate, int Count)
        {
            this._KeyField = KeyField;
            this._CustomerID = CustomerID;
            this._CustomerName = CustomerName;
            this._Address = Address;
            this._Area = Area;
            this._PlanName = PlanName;
            this._TotalOutStandingAmount = TotalOutStandingAmount;
            this._NoticeIssued = NoticeIssued;
            this._InvoiceNo = InvoiceNo;
            this._InvoiceDate = InvoiceDate;
            this._Count = Count;
            this._BillAmt = BillAmt;
            this._DebitNoteAmount = DebitNoteAmount;
            this._LatePayment = LatePayment;
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
        public decimal BillAmt
        {
            get { return _BillAmt; }
            set { _BillAmt = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DebitNoteAmount
        {
            get { return _DebitNoteAmount; }
            set { _DebitNoteAmount = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal KeyField
        {
            get { return _KeyField; }
            set { _KeyField = value; }
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
        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalDue
        {
            get { return _TotalDue; }
            set { _TotalDue = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalReceived
        {
            get { return _TotalReceived; }
            set { _TotalReceived = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DebitNoteOutstandingAmount
        {
            get { return _DebitNoteOutstandingAmount; }
            set { _DebitNoteOutstandingAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalDuaAmount
        {
            get { return _TotalDuaAmount; }
            set { _TotalDuaAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalLatePayment
        {
            get { return _TotalLatePayment; }
            set { _TotalLatePayment = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalBillDueAmount
        {
            get { return _TotalBillDueAmount; }
            set { _TotalBillDueAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalNetBillAmount
        {
            get { return _TotalNetBillAmount; }
            set { _TotalNetBillAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TotalOutStandingAmount
        {
            get { return _TotalOutStandingAmount; }
            set { _TotalOutStandingAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NoticeIssued
        {
            get { return _NoticeIssued; }
            set { _NoticeIssued = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
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


    public class BILLNoticeOutstandingHDRMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILLNoticeOutstandingHDRMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILLNoticeOutstandingHDRMsg(int RetVal, string RetStr)
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
