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
    
    public class PRDInvoiceHDRTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _INVHDR_InvoiceNo;
        private string _INVHDR_InvoiceRefNo;
        private string _INVHDR_InvoiceDate;
        private decimal _INVHDR_ApplicationID;
        private int _INVHDR_JobSheetID;
        private int _INVHDR_PlanId;
        private decimal _INVHDR_TotalPlanAmount;
        private decimal _INVHDR_TotalReceived;
        private int _INVHDR_InvoiceType;
        private int _INVHDR_MeterNo;
        private int _INVHDR_CreatedByUserID;
        private string _INVHDR_CreatedDateTime;
        private int _INVHDR_UpdatedByUserID;
        private string _INVHDR_UpdatedDateTime;
        private int _INVHDR_RowStatus;
        private long _INVHDR_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for PRDInvoiceHDRTRN class.
        /// </summary>
        public PRDInvoiceHDRTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDInvoiceHDRTRN(decimal INVHDR_InvoiceNo, string INVHDR_InvoiceRefNo, string INVHDR_InvoiceDate, decimal INVHDR_ApplicationID, int INVHDR_JobSheetID, int INVHDR_PlanId, decimal INVHDR_TotalPlanAmount, decimal INVHDR_TotalReceived, int INVHDR_InvoiceType, int INVHDR_MeterNo, int INVHDR_CreatedByUserID, string INVHDR_CreatedDateTime, int INVHDR_UpdatedByUserID, string INVHDR_UpdatedDateTime, int INVHDR_RowStatus, long INVHDR_RowVersion)
        {
            this._INVHDR_InvoiceNo = INVHDR_InvoiceNo;
            this._INVHDR_InvoiceRefNo = INVHDR_InvoiceRefNo;
            this._INVHDR_InvoiceDate = INVHDR_InvoiceDate;
            this._INVHDR_ApplicationID = INVHDR_ApplicationID;
            this._INVHDR_PlanId = INVHDR_PlanId;
            this._INVHDR_JobSheetID = INVHDR_JobSheetID;
            this._INVHDR_TotalPlanAmount = INVHDR_TotalPlanAmount;
            this._INVHDR_TotalReceived = INVHDR_TotalReceived;
            this._INVHDR_InvoiceType = INVHDR_InvoiceType;
            this._INVHDR_MeterNo = INVHDR_MeterNo;
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
        public decimal INVHDR_InvoiceNo
        {
            get { return _INVHDR_InvoiceNo; }
            set { _INVHDR_InvoiceNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceRefNo
        {
            get { return _INVHDR_InvoiceRefNo; }
            set { _INVHDR_InvoiceRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceDate
        {
            get { return _INVHDR_InvoiceDate; }
            set { _INVHDR_InvoiceDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_ApplicationID
        {
            get { return _INVHDR_ApplicationID; }
            set { _INVHDR_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_JobSheetID
        {
            get { return _INVHDR_JobSheetID; }
            set { _INVHDR_JobSheetID = value; }
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
        public decimal INVHDR_TotalPlanAmount
        {
            get { return _INVHDR_TotalPlanAmount; }
            set { _INVHDR_TotalPlanAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal INVHDR_TotalReceived
        {
            get { return _INVHDR_TotalReceived; }
            set { _INVHDR_TotalReceived = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_InvoiceType
        {
            get { return _INVHDR_InvoiceType; }
            set { _INVHDR_InvoiceType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_MeterNo
        {
            get { return _INVHDR_MeterNo; }
            set { _INVHDR_MeterNo = value; }
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

    public class PRDInvoiceHDRTRNList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private string _KeyField;
        private Int32 _INVHDR_InvoiceNo;
        private string _INVHDR_InvoiceRefNo;
        private string _INVHDR_InvoiceDate;
        private string _ApplicationNo;
        private string _CustomerID;
        private string _CustomerName;
        private string _Area;
        private string _CustomerType;
        private string _WorkType;
        private string _PlanName;
        private string _DNAdvanceReceiptDate;


        private decimal _DNAdvanceAmount;


        private decimal _TaxonDNAdvanceAmount;


        private decimal _TotalDNAdvanceReceived;


        private decimal _DebitNoteAmount;


        private decimal _ActualDNAmount;


        private decimal _TaxonActualDNAmount;


        private decimal _DNAmount;


        private decimal _TotalDebitNoteAmount;


        private string _DNAmountPaymentDate;


        private decimal _DNAmountPaymentreceived;


        //private decimal _INVHDR_Amt;
        //private decimal _INVHDR_TotalReceived;
        //private decimal _ActualDNAmt;
        //private decimal _tax;
        private Int32 _Count;


        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDInvoiceHDRTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDInvoiceHDRTRNList(string KeyField, int INVHDR_InvoiceNo, string INVHDR_InvoiceRefNo, string INVHDR_InvoiceDate, string ApplicationNo, string CustomerID, string CustomerName, string Area, string CustomerType, string WorkType, string PlanName, string DNAdvanceReceiptDate, decimal DNAdvanceAmount, decimal TaxonDNAdvanceAmount, decimal TotalDNAdvanceReceived, decimal DebitNoteAmount, decimal ActualDNAmount, decimal TaxonActualDNAmount, decimal DNAmount, decimal TotalDebitNoteAmount, string DNAmountPaymentDate, decimal DNAmountPaymentreceived, int Count)
        {
            this._KeyField = KeyField;
            this._INVHDR_InvoiceNo = INVHDR_InvoiceNo;
            this._INVHDR_InvoiceRefNo = INVHDR_InvoiceRefNo;
            this._INVHDR_InvoiceDate = INVHDR_InvoiceDate;
            this._ApplicationNo = ApplicationNo;
            this._CustomerID = CustomerID;
            this._CustomerName = CustomerName;
            this._Area = Area;
            this._CustomerType = CustomerType;
            this._WorkType = WorkType;
            this._PlanName = PlanName;
            this._DNAdvanceReceiptDate = DNAdvanceReceiptDate;
            this._DNAdvanceAmount = DNAdvanceAmount;

            this._TaxonDNAdvanceAmount = TaxonDNAdvanceAmount;

            this._TotalDNAdvanceReceived = TotalDNAdvanceReceived;

            this._DebitNoteAmount = DebitNoteAmount;

            this._ActualDNAmount = ActualDNAmount;

            this._TaxonActualDNAmount = TaxonActualDNAmount;

            this._DNAmount = DNAmount;

            this._TotalDebitNoteAmount = TotalDebitNoteAmount;

            this._DNAmountPaymentDate = DNAmountPaymentDate;

            this._DNAmountPaymentreceived = DNAmountPaymentreceived;
            //this._INVHDR_Amt = INVHDR_Amt;
            //this._INVHDR_TotalReceived = INVHDR_TotalReceived;
            //this._ActualDNAmt = ActualDNAmt;
            //this._tax = tax;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string KeyField
        {
            get { return _KeyField; }
            set { _KeyField = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_InvoiceNo
        {
            get { return _INVHDR_InvoiceNo; }
            set { _INVHDR_InvoiceNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceRefNo
        {
            get { return _INVHDR_InvoiceRefNo; }
            set { _INVHDR_InvoiceRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceDate
        {
            get { return _INVHDR_InvoiceDate; }
            set { _INVHDR_InvoiceDate = value; }
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

        public string WorkType
        {
            get { return _WorkType; }
            set { _WorkType = value; }
        }

        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
        }
        public string DNAdvanceReceiptDate
        {
            get { return _DNAdvanceReceiptDate; }
            set { _DNAdvanceReceiptDate = value; }
        }

        public decimal DNAdvanceAmount
        {
            get { return _DNAdvanceAmount; }
            set { _DNAdvanceAmount = value; }
        }

        public decimal TaxonDNAdvanceAmount
        {
            get { return _TaxonDNAdvanceAmount; }
            set { _TaxonDNAdvanceAmount = value; }
        }

        public decimal TotalDNAdvanceReceived
        {
            get { return _TotalDNAdvanceReceived; }
            set { _TotalDNAdvanceReceived = value; }
        }

        public decimal DebitNoteAmount
        {
            get { return _DebitNoteAmount; }
            set { _DebitNoteAmount = value; }
        }

        public decimal ActualDNAmount
        {
            get { return _ActualDNAmount; }
            set { _ActualDNAmount = value; }
        }

        public decimal TaxonActualDNAmount
        {
            get { return _TaxonActualDNAmount; }
            set { _TaxonActualDNAmount = value; }
        }

        public decimal DNAmount
        {
            get { return _DNAmount; }
            set { _DNAmount = value; }
        }

        public decimal TotalDebitNoteAmount
        {
            get { return _TotalDebitNoteAmount; }
            set { _TotalDebitNoteAmount = value; }
        }

        public string DNAmountPaymentDate
        {
            get { return _DNAmountPaymentDate; }
            set { _DNAmountPaymentDate = value; }
        }

        public decimal DNAmountPaymentreceived
        {
            get { return _DNAmountPaymentreceived; }
            set { _DNAmountPaymentreceived = value; }
        }
        //public decimal INVHDR_Amt
        //{
        //    get { return _INVHDR_Amt; }
        //    set { _INVHDR_Amt = value; }
        //}

        //public decimal tax
        //{
        //    get { return _tax; }
        //    set { _tax = value; }
        //}

        //public decimal INVHDR_TotalReceived
        //{
        //    get { return _INVHDR_TotalReceived; }
        //    set { _INVHDR_TotalReceived = value; }
        //}

        //public decimal ActualDNAmt
        //{
        //    get { return _ActualDNAmt; }
        //    set { _ActualDNAmt = value; }
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }

        }
    }

    public class PRDInvoiceHDRTRN_MeterNo
    {
        #region "Variables Declaration"
        private long _MeterNo;
        #endregion
        public PRDInvoiceHDRTRN_MeterNo() { }
        public PRDInvoiceHDRTRN_MeterNo(long MeterNo)
        {
            this._MeterNo = MeterNo;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long MeterNo
        {
            get { return _MeterNo; }
            set { _MeterNo = value; }
        }
    }

    public class PRDInvoiceHDRTRN_AppID
    {
        #region "Variables Declaration"
        private int _AppID;
        #endregion
        public PRDInvoiceHDRTRN_AppID() { }
        public PRDInvoiceHDRTRN_AppID(int AppID)
        {
            this._AppID = AppID;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AppID
        {
            get { return _AppID; }
            set { _AppID = value; }
        }
    }

    public class PRDInvoiceHDRTRN_MaterialDetail
    {
        #region "Variables Declaration"
        private int _JOBDTL_ID;
        private int _JOBDTL_ConnType;
        private string _ConnType;
        private int _JOBDTL_MaterialID;
        private string _MaterialName;
        private decimal _JOBDTL_PipeLength;
        private int _JOBDTL_ExtraConnType;
        private string _ExtraConnType;
        private int _JOBDTL_NoOfExtConn;

        #endregion
        public PRDInvoiceHDRTRN_MaterialDetail() { }
        public PRDInvoiceHDRTRN_MaterialDetail(int JOBDTL_ID, int JOBDTL_ConnType, string ConnType, int JOBDTL_MaterialID, string MaterialName, decimal JOBDTL_PipeLength, int JOBDTL_ExtraConnType, string ExtraConnType, int JOBDTL_NoOfExtConn)
        {
            this._JOBDTL_ID = JOBDTL_ID;
            this._JOBDTL_ConnType = JOBDTL_ConnType;
            this._ConnType = ConnType;
            this._JOBDTL_MaterialID = JOBDTL_MaterialID;
            this._MaterialName = MaterialName;
            this._JOBDTL_PipeLength = JOBDTL_PipeLength;
            this._JOBDTL_ExtraConnType = JOBDTL_ExtraConnType;
            this._ExtraConnType = ExtraConnType;
            this._JOBDTL_NoOfExtConn = JOBDTL_NoOfExtConn;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ID
        {
            get { return _JOBDTL_ID; }
            set { _JOBDTL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ConnType
        {
            get { return _JOBDTL_ConnType; }
            set { _JOBDTL_ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ConnType
        {
            get { return _ConnType; }
            set { _ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_MaterialID
        {
            get { return _JOBDTL_MaterialID; }
            set { _JOBDTL_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }

        public decimal JOBDTL_PipeLength
        {
            get { return _JOBDTL_PipeLength; }
            set { _JOBDTL_PipeLength = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ExtraConnType
        {
            get { return _JOBDTL_ExtraConnType; }
            set { _JOBDTL_ExtraConnType = value; }
        }

        public string ExtraConnType
        {
            get { return _ExtraConnType; }
            set { _ExtraConnType = value; }
        }

        public int JOBDTL_NoOfExtConn
        {
            get { return _JOBDTL_NoOfExtConn; }
            set { _JOBDTL_NoOfExtConn = value; }
        }
    }

    public class PRDInvoiceHDRTRN_ExtraConnectionDetail
    {
        #region "Variables Declaration"
        private int _JOBDTL_ID;
        private int _JOBDTL_ExtraConnType;
        private string _ExtraConnType;
        private int _JOBDTL_NoOfExtConn;
        #endregion
        public PRDInvoiceHDRTRN_ExtraConnectionDetail() { }
        public PRDInvoiceHDRTRN_ExtraConnectionDetail(int JOBDTL_ID, int JOBDTL_ExtraConnType, string ExtraConnType, int JOBDTL_NoOfExtConn)
        {
            this._JOBDTL_ID = JOBDTL_ID;
            this._JOBDTL_ExtraConnType = JOBDTL_ExtraConnType;
            this._ExtraConnType = ExtraConnType;
            this._JOBDTL_NoOfExtConn = JOBDTL_NoOfExtConn;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ID
        {
            get { return _JOBDTL_ID; }
            set { _JOBDTL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ExtraConnType
        {
            get { return _JOBDTL_ExtraConnType; }
            set { _JOBDTL_ExtraConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ExtraConnType
        {
            get { return _ExtraConnType; }
            set { _ExtraConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_NoOfExtConn
        {
            get { return _JOBDTL_NoOfExtConn; }
            set { _JOBDTL_NoOfExtConn = value; }
        }
    }

    public class PRDInvoiceHDRTRN_Detail
    {
        #region "Variables Declaration"
        private string _KeyField;
        private string _JobSheetNo;
        private string _JOBHDR_DateofInst;
        private string _APPMST_AppDate;
        private string _APPMST_AppNo;
        private string _APPMST_CustomerID;
        private string _CustomerName;
        private string _WorkOrderType;
        private string _OMStatus;
        private string _CustomerType;
        private string _PlanName;
        private int _Count;
        #endregion
        public PRDInvoiceHDRTRN_Detail() { }
        public PRDInvoiceHDRTRN_Detail(string KeyField, string JobSheetNo, string JOBHDR_DateofInst, string APPMST_AppDate, string APPMST_AppNo, string APPMST_CustomerID, string CustomerName, string WorkOrderType, string OMStatus, string CustomerType, string PlanName, int Count)
        {
            this._KeyField = KeyField;
            this._JobSheetNo = JobSheetNo;
            this._JOBHDR_DateofInst = JOBHDR_DateofInst;
            this._APPMST_AppDate = APPMST_AppDate;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._CustomerName = CustomerName;
            this._WorkOrderType = WorkOrderType;
            this._OMStatus = OMStatus;
            this._CustomerType = CustomerType;
            this._PlanName = PlanName;
            this._Count = Count;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string KeyField
        {
            get { return _KeyField; }
            set { _KeyField = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JobSheetNo
        {
            get { return _JobSheetNo; }
            set { _JobSheetNo = value; }
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
        public string APPMST_AppDate
        {
            get { return _APPMST_AppDate; }
            set { _APPMST_AppDate = value; }
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
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WorkOrderType
        {
            get { return _WorkOrderType; }
            set { _WorkOrderType = value; }
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
        public string CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
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
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class PRDInvoiceHDRTRN_Detail_Recalculate
    {
        #region "Variables Declaration"
        private string _ApplicationNo;
        private string _CustomerID;
        private string _CustomerName;
        private string _Address;
        private string _INVHDR_InvoiceRefNo;
        private string _INVHDR_InvoiceDate;
        private int _INVHDR_InvoiceType;
        private string _INVHDR_Remarks;
        private string _ContractorName;
        private decimal _JOBHDR_ActualAmt;
        private string _JOBHDR_Remarks;
        private string _JOBHDR_DateofInst;
        private string _PlanName;
        private string _CustomerType;
        private string _WorkOrderType;
        private string _WORTRN_WorkOrdDate;
        #endregion

        public PRDInvoiceHDRTRN_Detail_Recalculate() { }
        public PRDInvoiceHDRTRN_Detail_Recalculate(string ApplicationNo, string CustomerID, string CustomerName, string Address, string INVHDR_InvoiceRefNo, string INVHDR_InvoiceDate, int INVHDR_InvoiceType, string INVHDR_Remarks, string ContractorName, decimal JOBHDR_ActualAmt, string JOBHDR_Remarks, string JOBHDR_DateofInst, string PlanName, string CustomerType, string WorkOrderType, string WORTRN_WorkOrdDate)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerID = CustomerID;
            this._CustomerName = CustomerName;
            this._Address = Address;
            this._INVHDR_InvoiceRefNo = INVHDR_InvoiceRefNo;
            this._INVHDR_InvoiceDate = INVHDR_InvoiceDate;
            this._INVHDR_InvoiceType = INVHDR_InvoiceType;
            this._INVHDR_Remarks = INVHDR_Remarks;
            this._ContractorName = ContractorName;
            this._JOBHDR_ActualAmt = JOBHDR_ActualAmt;
            this._JOBHDR_Remarks = JOBHDR_Remarks;
            this._JOBHDR_DateofInst = JOBHDR_DateofInst;
            this._PlanName = PlanName;
            this._CustomerType = CustomerType;
            this._WorkOrderType = WorkOrderType;
            this._WORTRN_WorkOrdDate = WORTRN_WorkOrdDate;
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }

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
        public string INVHDR_InvoiceRefNo
        {
            get { return _INVHDR_InvoiceRefNo; }
            set { _INVHDR_InvoiceRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceDate
        {
            get { return _INVHDR_InvoiceDate; }
            set { _INVHDR_InvoiceDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_InvoiceType
        {
            get { return _INVHDR_InvoiceType; }
            set { _INVHDR_InvoiceType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_Remarks
        {
            get { return _INVHDR_Remarks; }
            set { _INVHDR_Remarks = value; }
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
        public decimal JOBHDR_ActualAmt
        {
            get { return _JOBHDR_ActualAmt; }
            set { _JOBHDR_ActualAmt = value; }
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
        public string PlanName
        {
            get { return _PlanName; }
            set { _PlanName = value; }
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
        public string WorkOrderType
        {
            get { return _WorkOrderType; }
            set { _WorkOrderType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string WORTRN_WorkOrdDate
        {
            get { return _WORTRN_WorkOrdDate; }
            set { _WORTRN_WorkOrdDate = value; }
        }
    }

    public class PRDInvoiceHDRTRN_HdrDtlInsert
    {
        #region "Variables Declaration"
        private int _CenCode;
        private int _INVHDR_InvoiceNo;
        private string _INVHDR_InvoiceDate;
        private int _INVHDR_ApplicationID;
        private int _JOBHDR_JobSheetID;
        private int _INVHDR_InvoiceType;
        private string _INVHDR_Remarks;
        private decimal _JOBHDR_ActualAmt;
        private int _blnCalcReCalc;
        private int _INVHDR_CreatedByUserID;
        #endregion
        public PRDInvoiceHDRTRN_HdrDtlInsert() { }
        public PRDInvoiceHDRTRN_HdrDtlInsert(int CenCode, int INVHDR_InvoiceNo, string INVHDR_InvoiceDate, int INVHDR_ApplicationID, int JOBHDR_JobSheetID, int INVHDR_InvoiceType, string INVHDR_Remarks, decimal JOBHDR_ActualAmt, int blnCalcReCalc, int INVHDR_CreatedByUserID)
        {
            this._CenCode = CenCode;
            this._INVHDR_InvoiceNo = INVHDR_InvoiceNo;
            this._INVHDR_InvoiceDate = INVHDR_InvoiceDate;
            this._INVHDR_ApplicationID = INVHDR_ApplicationID;
            this._JOBHDR_JobSheetID = JOBHDR_JobSheetID;
            this._INVHDR_InvoiceType = INVHDR_InvoiceType;
            this._INVHDR_Remarks = INVHDR_Remarks;
            this._JOBHDR_ActualAmt = JOBHDR_ActualAmt;
            this._blnCalcReCalc = blnCalcReCalc;
            this._INVHDR_CreatedByUserID = INVHDR_CreatedByUserID;
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
        public int INVHDR_InvoiceNo
        {
            get { return _INVHDR_InvoiceNo; }
            set { _INVHDR_InvoiceNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceDate
        {
            get { return _INVHDR_InvoiceDate; }
            set { _INVHDR_InvoiceDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_ApplicationID
        {
            get { return _INVHDR_ApplicationID; }
            set { _INVHDR_ApplicationID = value; }
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
        public int INVHDR_InvoiceType
        {
            get { return _INVHDR_InvoiceType; }
            set { _INVHDR_InvoiceType = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_Remarks
        {
            get { return _INVHDR_Remarks; }
            set { _INVHDR_Remarks = value; }
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
        public int blnCalcReCalc
        {
            get { return _blnCalcReCalc; }
            set { _blnCalcReCalc = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_CreatedByUserID
        {
            get { return _INVHDR_CreatedByUserID; }
            set { _INVHDR_CreatedByUserID = value; }
        }
    }

    public class PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate
    {
        #region "Variables Declaration"
        private int _CenCode;
        private int _INVHDR_InvoiceNo;
        private string _INVHDR_InvoiceDate;
        private string _INVHDR_Remarks;
        private int _INVHDR_ApplicationID;
        private int _JOBHDR_JobSheetID;
        private string _MCDtl;
        private string _ECDtl;
        private decimal _JOBHDR_ActualAmt;
        private int _INVHDR_CreatedByUserID;
        #endregion
        public PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate() { }
        public PRDInvoiceHDRTRN_HdrDtlInsert_Recalculate(int CenCode, int INVHDR_InvoiceNo, string INVHDR_InvoiceDate, string INVHDR_Remarks, int INVHDR_ApplicationID, int JOBHDR_JobSheetID, string MCDtl, string ECDtl, decimal JOBHDR_ActualAmt, int INVHDR_CreatedByUserID)
        {
            this._CenCode = CenCode;
            this._INVHDR_InvoiceNo = INVHDR_InvoiceNo;
            this._INVHDR_InvoiceDate = INVHDR_InvoiceDate;
            this._INVHDR_Remarks = INVHDR_Remarks;
            this._INVHDR_ApplicationID = INVHDR_ApplicationID;
            this._JOBHDR_JobSheetID = JOBHDR_JobSheetID;
            this._MCDtl = MCDtl;
            this._ECDtl = ECDtl;
            this._JOBHDR_ActualAmt = JOBHDR_ActualAmt;
            this._INVHDR_CreatedByUserID = INVHDR_CreatedByUserID;
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
        public int INVHDR_InvoiceNo
        {
            get { return _INVHDR_InvoiceNo; }
            set { _INVHDR_InvoiceNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_InvoiceDate
        {
            get { return _INVHDR_InvoiceDate; }
            set { _INVHDR_InvoiceDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string INVHDR_Remarks
        {
            get { return _INVHDR_Remarks; }
            set { _INVHDR_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int INVHDR_ApplicationID
        {
            get { return _INVHDR_ApplicationID; }
            set { _INVHDR_ApplicationID = value; }
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
        public string MCDtl
        {
            get { return _MCDtl; }
            set { _MCDtl = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ECDtl
        {
            get { return _ECDtl; }
            set { _ECDtl = value; }
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
        public int INVHDR_CreatedByUserID
        {
            get { return _INVHDR_CreatedByUserID; }
            set { _INVHDR_CreatedByUserID = value; }
        }
    }

    public class PRDInvoiceHDRTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDInvoiceHDRTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDInvoiceHDRTRNMsg(int RetVal, string RetStr)
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

    public class PRDInvoiceAdvanceHistoryList
    {
        #region "Variables Declaration"
        protected int _Row;
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
        protected string _WorkType;
        protected string _ReasonforRevisionOfDN;
        protected string _OrgExtraConAmt;
        protected string _RevisedExtraConAmt;
        protected string _DiffExtraConAmt;
        protected string _OrgExtraMatrialAmt;
        protected string _RevisedExtraMatrialAmt;
        protected string _DiffExtraMatrialAmt;
        protected string _OrgDNAmount;
        protected string _RevisedDNAmount;
        protected string _DiffDNAmount;
        protected string _OrgConnDepositeAmount;
        protected string _RevisedConnDepositeAmount;
        protected string _DiffConnDepositeAmount;
        protected string _OrgGasDepositeAmount;
        protected string _RevisedGasDepositeAmount;
        protected string _DiffGasDepositeAmount;
        protected string _OriginalCBC;
        protected string _RevisedCBC;
        protected string _DiffCBC;
        protected string _OriginalAppFees;
        protected string _RevisedAppFees;
        protected string _DiffAppFees;
        protected int _Count;


        #endregion

        public PRDInvoiceAdvanceHistoryList() { }
        public PRDInvoiceAdvanceHistoryList(int Row, string type, int OriginalLogID, int RevisedLogID, int OriginalInvoiceID, int RevisedInvoiceID,
            string OriginalINVfrom, string RevisedInvFrom, string INVHDR_DeleteDateTime, string CreatedDateTime,
            string CustomerID, string AppNo, string OriginalInvNo, string revisedInvNo, string OriginalInvDate, string revisedInvDate,
            string worktype, string ReasonforRevisionOfDN, string OrgExtraConAmt, string RevisedExtraConAmt,
            string DiffExtraConAmt, string OrgExtraMatrialAmt, string RevisedExtraMatrialAmt, string DiffExtraMatrialAmt,
            string OrgDNAmount, string RevisedDNAmount, string DiffDNAmount, string OrgConnDepositeAmount, string RevisedConnDepositeAmount, string DiffConnDepositeAmount,
            string OrgGasDepositeAmount, string RevisedGasDepositeAmount, string DiffGasDepositeAmount, string OriginalCBC, string RevisedCBC, string DiffCBC,
            string OriginalAppFees, string RevisedAppFees, string DiffAppFees, int Count)
        {

            this._Row = Row;
            this._type = type;
            this._OriginalLogID = OriginalLogID;
            this._RevisedLogID = RevisedLogID;
            this._OriginalInvoiceID = OriginalInvoiceID;
            this._RevisedInvoiceID = RevisedInvoiceID;
            this._OriginalINVfrom = OriginalINVfrom;
            this._RevisedInvFrom = RevisedInvFrom;
            this._INVHDR_DeleteDateTime = INVHDR_DeleteDateTime;
            this._CreatedDateTime = CreatedDateTime;
            this._CustomerID = CustomerID;
            this._AppNo = AppNo;
            this._OriginalInvNo = OriginalInvNo;
            this._revisedInvNo = revisedInvNo;
            this._OriginalInvDate = OriginalInvDate;
            this._revisedInvDate = revisedInvDate;
            this._WorkType = worktype;
            this._ReasonforRevisionOfDN = ReasonforRevisionOfDN;
            this._OrgExtraConAmt = OrgExtraConAmt;
            this._RevisedExtraConAmt = RevisedExtraConAmt;
            this._DiffExtraConAmt = DiffExtraConAmt;
            this._OrgExtraMatrialAmt = OrgExtraMatrialAmt;
            this._RevisedExtraMatrialAmt = RevisedExtraMatrialAmt;
            this._DiffExtraMatrialAmt = DiffExtraMatrialAmt;
            this._OrgDNAmount = OrgDNAmount;
            this._RevisedDNAmount = RevisedDNAmount;
            this._DiffDNAmount = DiffDNAmount;
            this._OrgConnDepositeAmount = OrgConnDepositeAmount;
            this._RevisedConnDepositeAmount = RevisedConnDepositeAmount;
            this._DiffConnDepositeAmount = DiffConnDepositeAmount;
            this._OrgGasDepositeAmount = OrgGasDepositeAmount;
            this._RevisedGasDepositeAmount = RevisedGasDepositeAmount;
            this._DiffGasDepositeAmount = DiffGasDepositeAmount;
            this._OriginalCBC = OriginalCBC;
            this._RevisedCBC = RevisedCBC;
            this._DiffCBC = DiffCBC;
            this._OriginalAppFees = OriginalAppFees;
            this._RevisedAppFees = RevisedAppFees;
            this._DiffAppFees = DiffAppFees;
            this._Count = Count;

        }

      

        public int Row
        {
            get { return _Row; }
            set { _Row = value; }
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
        public string WorkType
        {
            get { return _WorkType; }
            set { _WorkType = value; }

        }
        public string ReasonforRevisionOfDN
        {
            get { return _ReasonforRevisionOfDN; }
            set { _ReasonforRevisionOfDN = value; }

        }

        public string OrgExtraConAmt
        {
            get { return _OrgExtraConAmt; }
            set { _OrgExtraConAmt = value; }

        }
        public string RevisedExtraConAmt
        {
            get { return _RevisedExtraConAmt; }
            set { _RevisedExtraConAmt = value; }

        }
        public string DiffExtraConAmt
        {
            get { return _DiffExtraConAmt; }
            set { _DiffExtraConAmt = value; }

        }
        public string OrgExtraMatrialAmt
        {
            get { return _OrgExtraMatrialAmt; }
            set { _OrgExtraMatrialAmt = value; }

        }
        public string RevisedExtraMatrialAmt
        {
            get { return _RevisedExtraMatrialAmt; }
            set { _RevisedExtraMatrialAmt = value; }

        }
        public string DiffExtraMatrialAmt
        {
            get { return _DiffExtraMatrialAmt; }
            set { _DiffExtraMatrialAmt = value; }

        }
        public string OrgDNAmount
        {
            get { return _OrgDNAmount; }
            set { _OrgDNAmount = value; }

        }
        public string RevisedDNAmount
        {
            get { return _RevisedDNAmount; }
            set { _RevisedDNAmount = value; }

        }
        public string DiffDNAmount
        {
            get { return _DiffDNAmount; }
            set { _DiffDNAmount = value; }

        }
        public string OrgConnDepositeAmount
        {
            get { return _OrgConnDepositeAmount; }
            set { _OrgConnDepositeAmount = value; }

        }
        public string RevisedConnDepositeAmount
        {
            get { return _RevisedConnDepositeAmount; }
            set { _RevisedConnDepositeAmount = value; }

        }
        public string DiffConnDepositeAmount
        {
            get { return _DiffConnDepositeAmount; }
            set { _DiffConnDepositeAmount = value; }

        }
        public string OrgGasDepositeAmount
        {
            get { return _OrgGasDepositeAmount; }
            set { _OrgGasDepositeAmount = value; }

        }
        public string RevisedGasDepositeAmount
        {
            get { return _RevisedGasDepositeAmount; }
            set { _RevisedGasDepositeAmount = value; }

        }
        public string DiffGasDepositeAmount
        {
            get { return _DiffGasDepositeAmount; }
            set { _DiffGasDepositeAmount = value; }

        }
        public string OriginalCBC
        {
            get { return _OriginalCBC; }
            set { _OriginalCBC = value; }

        }

        public string RevisedCBC
        {
            get { return _RevisedCBC; }
            set { _RevisedCBC = value; }

        }
        public string DiffCBC
        {
            get { return _DiffCBC; }
            set { _DiffCBC = value; }

        }

        public string OriginalAppFees
        {
            get { return _OriginalAppFees; }
            set { _OriginalAppFees = value; }
        }
        public string RevisedAppFees
        {
            get { return _RevisedAppFees; }
            set { _RevisedAppFees = value; }
        }
        public string DiffAppFees
        {
            get { return _DiffAppFees; }
            set { _DiffAppFees = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }

        }

    }

}
