//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	ACCRefundTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	ACCRefundTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class ACCRefundTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _REFTRN_ID;
        private decimal _REFTRN_ApplicationId;
        private string _REFTRN_RefundDate;
        private decimal _REFTRN_PlanAmount;
        private decimal _REFTRN_Deposit;
        private decimal _REFTRN_AmountReceived;
        private decimal _REFTRN_Credit;
        private decimal _REFTRN_FinalRefund;
        private string _REFTRN_Remarks;
        private int _REFTRN_RefundType;
        private decimal _REFTRN_BillAccess;
        private int _REFTRN_PayMode;
        private string _REFTRN_ChequeNo;
        private string _REFTRN_ChequeDate;
        private decimal _REFTRN_ChequeAmount;
        private int _REFTRN_BankId;
        private decimal _REFTRN_ForfeitedAmount;
        private int _REFTRN_CreatedByUserID;
        private string _REFTRN_CreatedDateTime;
        private int _REFTRN_UpdatedByUserID;
        private string _REFTRN_UpdatedDateTime;
        private int _REFTRN_RowStatus;
        private long _REFTRN_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for ACCRefundTRN class.
        /// </summary>
        public ACCRefundTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCRefundTRN(int REFTRN_ID, decimal REFTRN_ApplicationId, string REFTRN_RefundDate, decimal REFTRN_PlanAmount, decimal REFTRN_Deposit, decimal REFTRN_AmountReceived, decimal REFTRN_Credit, decimal REFTRN_FinalRefund, string REFTRN_Remarks, int REFTRN_RefundType, decimal REFTRN_BillAccess, int REFTRN_PayMode, string REFTRN_ChequeNo, string REFTRN_ChequeDate, decimal REFTRN_ChequeAmount, int REFTRN_BankId, decimal REFTRN_ForfeitedAmount, int REFTRN_CreatedByUserID, string REFTRN_CreatedDateTime, int REFTRN_UpdatedByUserID, string REFTRN_UpdatedDateTime, int REFTRN_RowStatus, long REFTRN_RowVersion)
        {
            this._REFTRN_ID = REFTRN_ID;
            this._REFTRN_ApplicationId = REFTRN_ApplicationId;
            this._REFTRN_RefundDate = REFTRN_RefundDate;
            this._REFTRN_PlanAmount = REFTRN_PlanAmount;
            this._REFTRN_Deposit = REFTRN_Deposit;
            this._REFTRN_AmountReceived = REFTRN_AmountReceived;
            this._REFTRN_Credit = REFTRN_Credit;
            this._REFTRN_FinalRefund = REFTRN_FinalRefund;
            this._REFTRN_Remarks = REFTRN_Remarks;
            this._REFTRN_RefundType = REFTRN_RefundType;
            this._REFTRN_BillAccess = REFTRN_BillAccess;
            this._REFTRN_PayMode = REFTRN_PayMode;
            this._REFTRN_ChequeNo = REFTRN_ChequeNo;
            this._REFTRN_ChequeDate = REFTRN_ChequeDate;
            this._REFTRN_ChequeAmount = REFTRN_ChequeAmount;
            this._REFTRN_BankId = REFTRN_BankId;
            this._REFTRN_ForfeitedAmount = REFTRN_ForfeitedAmount;
            this._REFTRN_CreatedByUserID = REFTRN_CreatedByUserID;
            this._REFTRN_CreatedDateTime = REFTRN_CreatedDateTime;
            this._REFTRN_UpdatedByUserID = REFTRN_UpdatedByUserID;
            this._REFTRN_UpdatedDateTime = REFTRN_UpdatedDateTime;
            this._REFTRN_RowStatus = REFTRN_RowStatus;
            this._REFTRN_RowVersion = REFTRN_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_ID
        {
            get { return _REFTRN_ID; }
            set { _REFTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_ApplicationId
        {
            get { return _REFTRN_ApplicationId; }
            set { _REFTRN_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFTRN_RefundDate
        {
            get { return _REFTRN_RefundDate; }
            set { _REFTRN_RefundDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_PlanAmount
        {
            get { return _REFTRN_PlanAmount; }
            set { _REFTRN_PlanAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_Deposit
        {
            get { return _REFTRN_Deposit; }
            set { _REFTRN_Deposit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_AmountReceived
        {
            get { return _REFTRN_AmountReceived; }
            set { _REFTRN_AmountReceived = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_Credit
        {
            get { return _REFTRN_Credit; }
            set { _REFTRN_Credit = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_FinalRefund
        {
            get { return _REFTRN_FinalRefund; }
            set { _REFTRN_FinalRefund = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFTRN_Remarks
        {
            get { return _REFTRN_Remarks; }
            set { _REFTRN_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_RefundType
        {
            get { return _REFTRN_RefundType; }
            set { _REFTRN_RefundType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_BillAccess
        {
            get { return _REFTRN_BillAccess; }
            set { _REFTRN_BillAccess = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_PayMode
        {
            get { return _REFTRN_PayMode; }
            set { _REFTRN_PayMode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFTRN_ChequeNo
        {
            get { return _REFTRN_ChequeNo; }
            set { _REFTRN_ChequeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFTRN_ChequeDate
        {
            get { return _REFTRN_ChequeDate; }
            set { _REFTRN_ChequeDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_ChequeAmount
        {
            get { return _REFTRN_ChequeAmount; }
            set { _REFTRN_ChequeAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_BankId
        {
            get { return _REFTRN_BankId; }
            set { _REFTRN_BankId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFTRN_ForfeitedAmount
        {
            get { return _REFTRN_ForfeitedAmount; }
            set { _REFTRN_ForfeitedAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_CreatedByUserID
        {
            get { return _REFTRN_CreatedByUserID; }
            set { _REFTRN_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFTRN_CreatedDateTime
        {
            get { return _REFTRN_CreatedDateTime; }
            set { _REFTRN_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_UpdatedByUserID
        {
            get { return _REFTRN_UpdatedByUserID; }
            set { _REFTRN_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFTRN_UpdatedDateTime
        {
            get { return _REFTRN_UpdatedDateTime; }
            set { _REFTRN_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_RowStatus
        {
            get { return _REFTRN_RowStatus; }
            set { _REFTRN_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long REFTRN_RowVersion
        {
            get { return _REFTRN_RowVersion; }
            set { _REFTRN_RowVersion = value; }
        }

    }

    public class ACCRefundTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _REFTRN_ID;
        private string _Appmst_AppNo;
        private string _APPMST_CustomerID;
        private string _REFTRN_RefundDate;
        private string _REFTRN_RefundType;
        private string _REFTRN_Remarks;
        private decimal _REFTRN_ChequeAmount;
        private decimal _REFTRN_FinalRefund;
        private string _REFTRN_PayMode;
        private string _REFTRN_ChequeNo;
        private string _REFTRN_ChequeDate;
        private string _BANMST_BankName;
        private int _Count;
        #endregion
        public ACCRefundTRNList() { }
        public ACCRefundTRNList(int REFTRN_ID, string Appmst_AppNo, string APPMST_CustomerID, string REFTRN_RefundDate, string REFTRN_RefundType, string REFTRN_Remarks, decimal REFTRN_ChequeAmount, decimal REFTRN_FinalRefund, string REFTRN_PayMode, string REFTRN_ChequeNo, string REFTRN_ChequeDate, string BANMST_BankName, int Count)
        {

            this._REFTRN_ID = REFTRN_ID;
            this._Appmst_AppNo = Appmst_AppNo;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._REFTRN_RefundDate = REFTRN_RefundDate;
            this._REFTRN_RefundType = REFTRN_RefundType;
            this._REFTRN_Remarks = REFTRN_Remarks;
            this._REFTRN_ChequeAmount = REFTRN_ChequeAmount;
            this._REFTRN_FinalRefund = REFTRN_FinalRefund;
            this._REFTRN_PayMode = REFTRN_PayMode;
            this._REFTRN_ChequeNo = REFTRN_ChequeNo;
            this._REFTRN_ChequeDate = REFTRN_ChequeDate;
            this._BANMST_BankName = BANMST_BankName;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFTRN_ID
        {
            get { return _REFTRN_ID; }
            set { _REFTRN_ID = value; }
        }
        public string Appmst_AppNo
        {
            get { return _Appmst_AppNo; }
            set { _Appmst_AppNo = value; }
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        public string REFTRN_RefundDate
        {
            get { return _REFTRN_RefundDate; }
            set { _REFTRN_RefundDate = value; }
        }
        public string REFTRN_RefundType
        {
            get { return _REFTRN_RefundType; }
            set { _REFTRN_RefundType = value; }
        }
        public string REFTRN_Remarks
        {
            get { return _REFTRN_Remarks; }
            set { _REFTRN_Remarks = value; }
        }
        public decimal REFTRN_ChequeAmount
        {
            get { return _REFTRN_ChequeAmount; }
            set { _REFTRN_ChequeAmount = value; }
        }
        public decimal REFTRN_FinalRefund
        {
            get { return _REFTRN_FinalRefund; }
            set { _REFTRN_FinalRefund = value; }
        }
        public string REFTRN_PayMode
        {
            get { return _REFTRN_PayMode; }
            set { _REFTRN_PayMode = value; }
        }
        public string REFTRN_ChequeNo
        {
            get { return _REFTRN_ChequeNo; }
            set { _REFTRN_ChequeNo = value; }
        }
        public string REFTRN_ChequeDate
        {
            get { return _REFTRN_ChequeDate; }
            set { _REFTRN_ChequeDate = value; }
        }
        public string BANMST_BankName
        {
            get { return _BANMST_BankName; }
            set { _BANMST_BankName = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }


    public class ACCRefundTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public ACCRefundTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ACCRefundTRNMsg(int RetVal, string RetStr)
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
    
    public class RefundAmt
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        // private decimal _ApplicationId;
        //private int _CenterCode;
        private decimal _AmountDue;
        #endregion

        /// <summary>
        /// Default constructor for ACCReceiptDTLTRN class.
        /// </summary>
        public RefundAmt() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        /// 

        public RefundAmt(decimal AmountDue)
        {

            // this._ApplicationId = Applicationid;
            // this._CenterCode = centercode;
            this._AmountDue = AmountDue;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public decimal AmountDue
        {
            get { return _AmountDue; }
            set { _AmountDue = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>


    }

}
