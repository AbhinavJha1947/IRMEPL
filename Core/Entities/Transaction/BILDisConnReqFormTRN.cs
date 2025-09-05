//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILDisConnReqFormTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILDisConnReqFormTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILDisConnReqFormTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _DSCTRN_RequestID;
        private int _DSCTRN_ApplicationId;
        private string _DSCTRN_RequestDate;
        private int _DSCTRN_BInvoiceId;
        private int _DSCTRN_DisconnType;
        private string _DSCTRN_DisconnReqDate;
        private int _DSCTRN_DisconnReqOrderBy;
        private string _DSCTRN_DisconnReqReason;
        private decimal _DSCTRN_ReqMeterReading;
        private decimal _DSCTRN_DisconnMeterReading;
        private string _DSCTRN_ExpReconDate;
        private string _DSCTRN_ReconnDate;
        private int _DSCTRN_ReconnOrderBy;
        private int _DSCTRN_Flag;
        private int _DSCTRN_DisconnDoneby;
        private string _DSCTRN_DisconnDate;
        private string _DSCTRN_DisconnRemark;
        private int _DSCTRN_CreatedByUserID;
        private string _DSCTRN_CreatedDateTime;
        private int _DSCTRN_UpdatedByUserID;
        private string _DSCTRN_UpdatedDateTime;        
        private int _DSCTRN_RowStatus;
        private decimal _DSCTRN_DueAmount;
        private int _DSCTRN_TariffID;
        private string _DSCTRN_CreditNoteStatus;
        //private string _SType;
        private string _DSCTRN_ONMReason;
        private string _DSCTRN_CNMReason;
        private long _DSCTRN_RowVersion;
        
        #endregion

        /// <summary>
        /// Default constructor for BILDisConnReqFormTRN class.
        /// </summary>
        public BILDisConnReqFormTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILDisConnReqFormTRN(int DSCTRN_RequestID, int DSCTRN_ApplicationId, string DSCTRN_RequestDate, int DSCTRN_BInvoiceId, int DSCTRN_DisconnType, string DSCTRN_DisconnReqDate, int DSCTRN_DisconnReqOrderBy, string DSCTRN_DisconnReqReason, decimal DSCTRN_ReqMeterReading, decimal DSCTRN_DisconnMeterReading, string DSCTRN_ExpReconDate, string DSCTRN_ReconnDate, int DSCTRN_ReconnOrderBy, int DSCTRN_Flag, int DSCTRN_DisconnDoneby, string DSCTRN_DisconnDate, string DSCTRN_DisconnRemark, int DSCTRN_CreatedByUserID, string DSCTRN_CreatedDateTime, int DSCTRN_UpdatedByUserID, string DSCTRN_UpdatedDateTime, int DSCTRN_RowStatus, decimal DSCTRN_DueAmount, int DSCTRN_TariffID, string DSCTRN_CreditNoteStatus,string DSCTRN_ONMReason, string DSCTRN_CNMReason, long DSCTRN_RowVersion)
        {
            this._DSCTRN_RequestID = DSCTRN_RequestID;
            this._DSCTRN_ApplicationId = DSCTRN_ApplicationId;
            this._DSCTRN_RequestDate = DSCTRN_RequestDate;
            this._DSCTRN_BInvoiceId = DSCTRN_BInvoiceId;
            this._DSCTRN_DisconnType = DSCTRN_DisconnType;
            this._DSCTRN_DisconnReqDate = DSCTRN_DisconnReqDate;
            this._DSCTRN_DisconnReqOrderBy = DSCTRN_DisconnReqOrderBy;
            this._DSCTRN_DisconnReqReason = DSCTRN_DisconnReqReason;
            this._DSCTRN_ReqMeterReading = DSCTRN_ReqMeterReading;
            this._DSCTRN_DisconnMeterReading = DSCTRN_DisconnMeterReading;
            this._DSCTRN_ExpReconDate = DSCTRN_ExpReconDate;
            this._DSCTRN_ReconnDate = DSCTRN_ReconnDate;
            this._DSCTRN_ReconnOrderBy = DSCTRN_ReconnOrderBy;
            this._DSCTRN_Flag = DSCTRN_Flag;
            this._DSCTRN_DisconnDoneby = DSCTRN_DisconnDoneby;
            this._DSCTRN_DisconnDate = DSCTRN_DisconnDate;
            this._DSCTRN_DisconnRemark = DSCTRN_DisconnRemark;
            this._DSCTRN_CreatedByUserID = DSCTRN_CreatedByUserID;
            this._DSCTRN_CreatedDateTime = DSCTRN_CreatedDateTime;
            this._DSCTRN_UpdatedByUserID = DSCTRN_UpdatedByUserID;
            this._DSCTRN_UpdatedDateTime = DSCTRN_UpdatedDateTime;
            this._DSCTRN_DueAmount = DSCTRN_DueAmount;
            this._DSCTRN_TariffID = DSCTRN_TariffID;
            this._DSCTRN_RowStatus = DSCTRN_RowStatus;
            //this._SType = SType;
            this._DSCTRN_CreditNoteStatus = DSCTRN_CreditNoteStatus;
            this._DSCTRN_ONMReason = DSCTRN_ONMReason;
            this._DSCTRN_CNMReason = DSCTRN_CNMReason;
            this._DSCTRN_RowVersion = DSCTRN_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_RequestID
        {
            get { return _DSCTRN_RequestID; }
            set { _DSCTRN_RequestID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_ApplicationId
        {
            get { return _DSCTRN_ApplicationId; }
            set { _DSCTRN_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_RequestDate
        {
            get { return _DSCTRN_RequestDate; }
            set { _DSCTRN_RequestDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_BInvoiceId
        {
            get { return _DSCTRN_BInvoiceId; }
            set { _DSCTRN_BInvoiceId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_DisconnType
        {
            get { return _DSCTRN_DisconnType; }
            set { _DSCTRN_DisconnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_DisconnReqDate
        {
            get { return _DSCTRN_DisconnReqDate; }
            set { _DSCTRN_DisconnReqDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_DisconnReqOrderBy
        {
            get { return _DSCTRN_DisconnReqOrderBy; }
            set { _DSCTRN_DisconnReqOrderBy = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_DisconnReqReason
        {
            get { return _DSCTRN_DisconnReqReason; }
            set { _DSCTRN_DisconnReqReason = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DSCTRN_ReqMeterReading
        {
            get { return _DSCTRN_ReqMeterReading; }
            set { _DSCTRN_ReqMeterReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal DSCTRN_DisconnMeterReading
        {
            get { return _DSCTRN_DisconnMeterReading; }
            set { _DSCTRN_DisconnMeterReading = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_ExpReconDate
        {
            get { return _DSCTRN_ExpReconDate; }
            set { _DSCTRN_ExpReconDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_ReconnDate
        {
            get { return _DSCTRN_ReconnDate; }
            set { _DSCTRN_ReconnDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_ReconnOrderBy
        {
            get { return _DSCTRN_ReconnOrderBy; }
            set { _DSCTRN_ReconnOrderBy = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_Flag
        {
            get { return _DSCTRN_Flag; }
            set { _DSCTRN_Flag = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_DisconnDoneby
        {
            get { return _DSCTRN_DisconnDoneby; }
            set { _DSCTRN_DisconnDoneby = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_DisconnDate
        {
            get { return _DSCTRN_DisconnDate; }
            set { _DSCTRN_DisconnDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_DisconnRemark
        {
            get { return _DSCTRN_DisconnRemark; }
            set { _DSCTRN_DisconnRemark = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_CreatedByUserID
        {
            get { return _DSCTRN_CreatedByUserID; }
            set { _DSCTRN_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_CreatedDateTime
        {
            get { return _DSCTRN_CreatedDateTime; }
            set { _DSCTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int DSCTRN_UpdatedByUserID
        {
            get { return _DSCTRN_UpdatedByUserID; }
            set { _DSCTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string DSCTRN_UpdatedDateTime
        {
            get { return _DSCTRN_UpdatedDateTime; }
            set { _DSCTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        //public string SType
        //{
        //    get { return _SType; }
        //    set { _SType = value; }
        //}
        public int DSCTRN_RowStatus
        {
            get { return _DSCTRN_RowStatus; }
            set { _DSCTRN_RowStatus = value; }
        }

        public decimal DSCTRN_DueAmount
        {
            get { return _DSCTRN_DueAmount; }
            set { _DSCTRN_DueAmount = value; }
        }

        public int DSCTRN_TariffID
        {
            get { return _DSCTRN_TariffID; }
            set { _DSCTRN_TariffID = value; }
        }

         public string DSCTRN_CreditNoteStatus
        {
            get { return _DSCTRN_CreditNoteStatus; }
            set { _DSCTRN_CreditNoteStatus = value; }
        }

         public string DSCTRN_ONMReason
         {
             get { return _DSCTRN_ONMReason; }
             set { _DSCTRN_ONMReason = value; }
         }

         public string DSCTRN_CNMReason
         {
             get { return _DSCTRN_CNMReason; }
             set { _DSCTRN_CNMReason = value; }
         }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long DSCTRN_RowVersion
        {
            get { return _DSCTRN_RowVersion; }
            set { _DSCTRN_RowVersion = value; }
        }

    }

    public class BILDisConnReqFormTRNList
    {
             
        private int _DSCTRN_RequestID;
        private int _DSCTRN_ApplicationId;
        private string _APPMST_CustomerID;
        private string _App_Name;
        private string _Address;
        private string _AREMST_Name;
        private string _DSCTRN_DisconnReqDate;
        private string _CD_ControlType;
        private string _DSCTRN_DisconnReqReason;
        private int _DSCTRN_RowStatus;
        private int _BillReqcount;
        private string _DSCTRN_ReconnDate;
        private string _DSCTRN_ReconnOrderBy;
        private string _DSCTRN_ExpReconDate;
        private string _strDSCTRN_Flag;
        private int _DSCTRN_Flag;
        private int _DSCTRN_DisconnReqOrderBy;
        private string _DSCTRN_RequestNo;
        private decimal _DSCTRN_DueAmount;
        private decimal _DSCTRN_ReceivedAmount;
        private string _ActionDate;
        private string _AppNo;
        private string _AppStatus;
        private string _PayStatus;
        private string _DSCTRN_CreditNoteStatus;
        private string _DSCTRN_ONMReason;
        private string _DSCTRN_CNMReason;

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public BILDisConnReqFormTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public BILDisConnReqFormTRNList(int DSCTRN_RequestID, int DSCTRN_ApplicationId, string APPMST_CustomerID, string App_Name, string Address, string AREMST_Name, string DSCTRN_DisconnReqDate, string CD_ControlType, string DSCTRN_DisconnReqReason, int DSCTRN_RowStatus, string DSCTRN_ReconnDate, string DSCTRN_ReconnOrderBy, string DSCTRN_ExpReconDate, int DSCTRN_Flag, string strDSCTRN_Flag, int DSCTRN_DisconnReqOrderBy, string DSCTRN_RequestNo, decimal DSCTRN_DueAmount, decimal DSCTRN_ReceivedAmount, int BillReqcount, string ActionDate, string AppNo, string AppStatus, string PayStatus, string DSCTRN_CreditNoteStatus, string DSCTRN_ONMReason, string DSCTRN_CNMReason)
        {
            this._DSCTRN_RequestID = DSCTRN_RequestID;
            this._DSCTRN_ApplicationId =DSCTRN_ApplicationId;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._App_Name = App_Name;
            this._Address = Address;
            this._AREMST_Name = AREMST_Name;
            this._DSCTRN_DisconnReqDate = DSCTRN_DisconnReqDate;
            this._CD_ControlType = CD_ControlType;
            this._DSCTRN_DisconnReqReason = DSCTRN_DisconnReqReason;
            this._DSCTRN_RowStatus = DSCTRN_RowStatus;
            this._BillReqcount = BillReqcount;
            this._DSCTRN_ReconnDate = DSCTRN_ReconnDate;
            this._DSCTRN_ReconnOrderBy = DSCTRN_ReconnOrderBy;
            this._DSCTRN_ExpReconDate = DSCTRN_ExpReconDate;
            this._DSCTRN_Flag = DSCTRN_Flag;
            this._strDSCTRN_Flag = strDSCTRN_Flag;
            this._DSCTRN_DisconnReqOrderBy = DSCTRN_DisconnReqOrderBy;
            this._DSCTRN_RequestNo = DSCTRN_RequestNo;
            this._DSCTRN_DueAmount = DSCTRN_DueAmount;
            this._DSCTRN_ReceivedAmount = DSCTRN_ReceivedAmount;
            this._ActionDate = ActionDate;
            this._AppNo = AppNo;
            this._AppStatus = AppStatus;
            this._PayStatus = PayStatus;
            this._DSCTRN_CreditNoteStatus = DSCTRN_CreditNoteStatus;
            this._DSCTRN_ONMReason = DSCTRN_ONMReason;
            this._DSCTRN_CNMReason = DSCTRN_CNMReason;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public int DSCTRN_RequestID
        {
            get { return _DSCTRN_RequestID; }
            set { _DSCTRN_RequestID = value; }
        }


        public int DSCTRN_ApplicationId
        {
            get { return _DSCTRN_ApplicationId; }
            set { _DSCTRN_ApplicationId = value; }
        }
       
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string App_Name
        {
            get { return _App_Name; }
            set { _App_Name = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string AREMST_Name
        {
            get { return _AREMST_Name; }
            set { _AREMST_Name = value; }
        }
        public string DSCTRN_DisconnReqDate
        {
            get { return _DSCTRN_DisconnReqDate; }
            set { _DSCTRN_DisconnReqDate = value; }
        }
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }

        public string DSCTRN_DisconnReqReason
        {
            get { return _DSCTRN_DisconnReqReason; }
            set { _DSCTRN_DisconnReqReason = value; }
        }
        public int DSCTRN_RowStatus
        {
            get { return _DSCTRN_RowStatus; }
            set { _DSCTRN_RowStatus = value; }
        }
        public int BillReqcount
        {
            get { return _BillReqcount; }

        }
        public string DSCTRN_ReconnOrderBy
        {
            get { return _DSCTRN_ReconnOrderBy; }

        }
        public string DSCTRN_ReconnDate
        {
            get { return _DSCTRN_ReconnDate; }

        }
        public string DSCTRN_ExpReconDate
        {
            get { return _DSCTRN_ExpReconDate; }
            set { _DSCTRN_ExpReconDate = value; }
        }
        public int DSCTRN_Flag
        {
            get { return _DSCTRN_Flag; }

        }
        public int DSCTRN_DisconnReqOrderBy
        {
            get { return _DSCTRN_DisconnReqOrderBy; }
            set { _DSCTRN_DisconnReqOrderBy = value; }
        }
        public string DSCTRN_RequestNo
        {
            get { return _DSCTRN_RequestNo; }
            set { _DSCTRN_RequestNo = value; }
        }

        public decimal DSCTRN_DueAmount
        {
            get { return _DSCTRN_DueAmount; }
            set { _DSCTRN_DueAmount = value; }
        }

        public decimal DSCTRN_ReceivedAmount
        {
            get { return _DSCTRN_ReceivedAmount; }
            set { _DSCTRN_ReceivedAmount = value; }
        }
        
        public string strDSCTRN_Flag
        {
            get { return _strDSCTRN_Flag; }
            set { _strDSCTRN_Flag = value; }
        }

        public string ActionDate
        {
            get { return _ActionDate; }
            set { _ActionDate = value; }
        }
        public string AppNo
        {
            get { return _AppNo; }
            set { _AppNo = value; }
        }

        public string AppStatus
        {
            get { return _AppStatus; }
            set { _AppStatus = value; }
        }

        public string PayStatus
        {
            get { return _PayStatus; }
            set { _PayStatus = value; }
        }

        public string DSCTRN_CreditNoteStatus
        {
            get { return _DSCTRN_CreditNoteStatus; }
            set { _DSCTRN_CreditNoteStatus = value; }
        }

        public string DSCTRN_ONMReason
        {
            get { return _DSCTRN_ONMReason; }
            set { _DSCTRN_ONMReason = value; }
        }

        public string DSCTRN_CNMReason
        {
            get { return _DSCTRN_CNMReason; }
            set { _DSCTRN_CNMReason = value; }
        }
        

    }    
    public class BILDisConnReqFormTRNListForEdit
    {

        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _customerAddress;
        private string _CD_ControlType;
        private string _PLAMST_PlanName;
        private string _MaxinvoiceNo;
        private decimal _outstandingAmount;      
        private string _APPMST_CustomerID;
        private string _DSCTRN_RequestDate;
        private string _DSCTRN_DisconnReqDate;
       // private int _ReqOrderBy;
        private string _DSCTRN_DisconnReqOrderBy;
        private string _DSCTRN_ExpReconDate;
        private decimal _DSCTRN_DueAmount;
        private string _DSCTRN_DisconnReqReason;
        private string _DSCTRN_DisconnDate;
        private string _DSCTRN_DisconnDoneby;
        private string _DSCTRN_ReconnDate;
        private string _DSCTRN_RequestNo;
        private string _DSCTRN_CreditNoteStatus;
        private string _DSCTRN_ONMReason;
        private string _DSCTRN_CNMReason;
        
        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public BILDisConnReqFormTRNListForEdit() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public BILDisConnReqFormTRNListForEdit(int APPMST_AppID, string APPMST_AppNo, string CustomerName, string customerAddress, string CD_ControlType, string PLAMST_PlanName, string MaxinvoiceNo, decimal outstandingAmount, string APPMST_CustomerID, string DSCTRN_RequestDate, string DSCTRN_DisconnReqDate, string DSCTRN_DisconnReqOrderBy, string DSCTRN_ExpReconDate, decimal DSCTRN_DueAmount, string DSCTRN_DisconnReqReason, string DSCTRN_DisconnDate, string DSCTRN_DisconnDoneby, string DSCTRN_ReconnDate, string DSCTRN_RequestNo, string DSCTRN_CreditNoteStatus, string DSCTRN_ONMReason ,string DSCTRN_CNMReason)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CustomerName = CustomerName;
            this._customerAddress = customerAddress;
            this._CD_ControlType = CD_ControlType;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._MaxinvoiceNo = MaxinvoiceNo;
            this._outstandingAmount = outstandingAmount;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._DSCTRN_RequestDate = DSCTRN_RequestDate;
            this._DSCTRN_DisconnReqDate = DSCTRN_DisconnReqDate;
            this._DSCTRN_DisconnReqOrderBy = DSCTRN_DisconnReqOrderBy;
            this._DSCTRN_ExpReconDate = DSCTRN_ExpReconDate;
            //this._ReqOrderBy = ReqOrderBy;
            this._DSCTRN_DueAmount = DSCTRN_DueAmount;
            this._DSCTRN_DisconnReqReason = DSCTRN_DisconnReqReason;
            this._DSCTRN_DisconnDate =DSCTRN_DisconnDate;
            this._DSCTRN_DisconnDoneby = DSCTRN_DisconnDoneby;
            this._DSCTRN_ReconnDate = DSCTRN_ReconnDate;
            this._DSCTRN_RequestNo = DSCTRN_RequestNo;
            this._DSCTRN_CreditNoteStatus = DSCTRN_CreditNoteStatus;
            this._DSCTRN_ONMReason = DSCTRN_ONMReason;
            this._DSCTRN_CNMReason = DSCTRN_CNMReason;
           
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>


        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        public string customerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        public string MaxinvoiceNo
        {
            get { return _MaxinvoiceNo; }
            set { _MaxinvoiceNo = value; }
        }
        public decimal outstandingAmount
        {
            get { return _outstandingAmount; }
            set { _outstandingAmount = value; }
        }      

        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }
        public string DSCTRN_RequestDate
        {
            get { return _DSCTRN_RequestDate; }
            set { _DSCTRN_RequestDate = value; }
        }
        public string DSCTRN_DisconnReqDate
        {
            get { return _DSCTRN_DisconnReqDate; }
            set { _DSCTRN_DisconnReqDate = value; }
        }
        public string DSCTRN_DisconnReqOrderBy
        {
            get { return _DSCTRN_DisconnReqOrderBy; }
            set { _DSCTRN_DisconnReqOrderBy = value; }
        }
        public string DSCTRN_ExpReconDate
        {
            get { return _DSCTRN_ExpReconDate; }
            set { _DSCTRN_ExpReconDate = value; }
        }
        public decimal DSCTRN_DueAmount
        {
            get { return _DSCTRN_DueAmount; }
            set { _DSCTRN_DueAmount = value; }
        }
        public string DSCTRN_DisconnReqReason
        {
            get { return _DSCTRN_DisconnReqReason; }
            set { _DSCTRN_DisconnReqReason = value; }
        }
        public string DSCTRN_DisconnDate
        {
            get { return _DSCTRN_DisconnDate; }
            set { _DSCTRN_DisconnDate = value; }
        }

        public string DSCTRN_DisconnDoneby
        {
            get { return _DSCTRN_DisconnDoneby; }
            set { _DSCTRN_DisconnDoneby = value; }
        }
        public string DSCTRN_ReconnDate
        {
            get { return _DSCTRN_ReconnDate; }
            set { _DSCTRN_ReconnDate = value; }
        }
        public string DSCTRN_RequestNo
        {
            get { return _DSCTRN_RequestNo; }
            set { _DSCTRN_RequestNo = value; }
        }

        public string DSCTRN_CreditNoteStatus
        {
            get { return _DSCTRN_CreditNoteStatus; }
            set { _DSCTRN_CreditNoteStatus = value; }
        }

        public string DSCTRN_ONMReason
        {
            get { return _DSCTRN_ONMReason; }
            set { _DSCTRN_ONMReason = value; }
        }

        public string DSCTRN_CNMReason
        {
            get { return _DSCTRN_CNMReason; }
            set { _DSCTRN_CNMReason = value; }
        }


        
       
    }
    public class BillActionList
    {
        //private int _CDMTRN_RequestCode;
        private Int64 _CDMTRN_MeterNo;
        private decimal _CDMTRN_PrevMeterReading;
        private decimal _CDMTRN_DisMeterReading;
        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public BillActionList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public BillActionList(Int64 CDMTRN_MeterNo, decimal CDMTRN_PrevMeterReading, decimal CDMTRN_DisMeterReading)
        {
            //this._CDMTRN_RequestCode = CDMTRN_RequestCode;
            this._CDMTRN_MeterNo = CDMTRN_MeterNo;
            this._CDMTRN_PrevMeterReading = CDMTRN_PrevMeterReading;
            this._CDMTRN_DisMeterReading = CDMTRN_DisMeterReading;
         
        }

        public Int64 CDMTRN_MeterNo
        {
            get { return _CDMTRN_MeterNo; }
            set { _CDMTRN_MeterNo = value; }
        }

        public decimal CDMTRN_PrevMeterReading
        {
            get { return _CDMTRN_PrevMeterReading; }
            set { _CDMTRN_PrevMeterReading = value; }
        }

        public decimal CDMTRN_DisMeterReading
        {
            get { return _CDMTRN_DisMeterReading; }
            set { _CDMTRN_DisMeterReading = value; }
        }

    }
    public class BillReqDetailListForEdit
    {


        private int _METTRN_ID;
        private long _METTRN_MeterNo;
        private decimal _METTRN_CurrentReading;
        private decimal _DSCTRN_ReqMeterReading;
        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public BillReqDetailListForEdit() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public BillReqDetailListForEdit(int METTRN_ID, long METTRN_MeterNo, decimal METTRN_CurrentReading, decimal DSCTRN_ReqMeterReading)
        {
            this._METTRN_ID = METTRN_ID;
            this._METTRN_MeterNo = METTRN_MeterNo;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
            this._DSCTRN_ReqMeterReading = DSCTRN_ReqMeterReading;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public int METTRN_ID
        {
            get { return _METTRN_ID; }
            set { _METTRN_ID = value; }
        }


        //public int DSCTRN_RequestID
        //{
        //    get { return _DSCTRN_RequestID; }
        //    set { _DSCTRN_RequestID = value; }
        //}

        //public int DSCTRN_ApplicationId
        //{
        //    get { return _DSCTRN_ApplicationId; }
        //    set { _DSCTRN_ApplicationId = value; }
        //}
      
        public long METTRN_MeterNo
        {
            get { return _METTRN_MeterNo; }
            set { _METTRN_MeterNo = value; }
        }

        public decimal METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }
        public decimal DSCTRN_ReqMeterReading
        {
            get { return _DSCTRN_ReqMeterReading; }
            set { _DSCTRN_ReqMeterReading = value; }
        }

    }
    
    public class BILDisConnReqForCustomer
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"            
        private int _APPMST_AppID;       
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _customerAddress;
        private string _CD_ControlType;
        private string _PLAMST_PlanName;
        private string _MaxinvoiceNo;
        private decimal _outstandingAmount;       
        #endregion

        /// <summary>
        /// Default constructor for PRDJobSheetHDRTRN class.
        /// </summary>
        public BILDisConnReqForCustomer() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILDisConnReqForCustomer(int APPMST_AppID, string APPMST_AppNo, string CustomerName, string customerAddress, string CD_ControlType, string PLAMST_PlanName, string MaxinvoiceNo, decimal outstandingAmount)
        {


            this._APPMST_AppID=APPMST_AppID;           
            this._APPMST_AppNo=APPMST_AppNo;
            this._CustomerName=CustomerName;
            this._customerAddress=customerAddress;
            this._CD_ControlType=CD_ControlType;
            this._PLAMST_PlanName=PLAMST_PlanName;
            this._MaxinvoiceNo =MaxinvoiceNo;
            this._outstandingAmount = outstandingAmount;          
        }


        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        public string customerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        public string MaxinvoiceNo
        {
            get { return _MaxinvoiceNo; }
            set { _MaxinvoiceNo = value; }
        }
        public decimal outstandingAmount
        {
            get { return _outstandingAmount; }
            set { _outstandingAmount = value; }
        }      

      
     
    }
    public class BILSurrenderReqForCustomer
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _CustomerName;
        private string _customerAddress;
        private string _CD_ControlType;
        private string _PLAMST_PlanName;
        private string _MaxinvoiceNo;
        private decimal _outstandingAmount;
        #endregion

        /// <summary>
        /// Default constructor for PRDJobSheetHDRTRN class.
        /// </summary>
        public BILSurrenderReqForCustomer() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILSurrenderReqForCustomer(int APPMST_AppID, string APPMST_AppNo, string CustomerName, string customerAddress, string CD_ControlType, string PLAMST_PlanName, string MaxinvoiceNo, decimal outstandingAmount)
        {


            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._CustomerName = CustomerName;
            this._customerAddress = customerAddress;
            this._CD_ControlType = CD_ControlType;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._MaxinvoiceNo = MaxinvoiceNo;
            this._outstandingAmount = outstandingAmount;
        }


        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        public string customerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        public string MaxinvoiceNo
        {
            get { return _MaxinvoiceNo; }
            set { _MaxinvoiceNo = value; }
        }
        public decimal outstandingAmount
        {
            get { return _outstandingAmount; }
            set { _outstandingAmount = value; }
        }



    }
    public class BILDisConnReqFormTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILDisConnReqFormTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILDisConnReqFormTRNMsg(int RetVal, string RetStr)
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
