//Business File.
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
using System.Text;

namespace Core.Entities.Core
{
    
    
    public class ACCReceiptHDRTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _RECHDR_ReceiptNo;
        private string _RECHDR_ReceiptRefNo;
        private string _RECHDR_Date;
        private int _RECHDR_CorporateID;
        private decimal _RECHDR_ApplicationID;
        private int _RECHDR_ReceiptType;
        private Int32 _RECHDR_PayMode;
        private string _RECHDR_ChequeNo;
        private string _RECHDR_ChequeDate;
        private decimal _RECHDR_ChequeAmount;
        private int _RECHDR_CreatedByUserID;
        private string _RECHDR_CreatedDateTime;
        private int _RECHDR_UpdatedByUserID;
        private string _RECHDR_UpdatedDateTime;
        private int _RECHDR_RowStatus;
        private long _RECHDR_RowVersion;
        private int _Bankid;
        private int _centercode;
        private Int64 _CHQDTL_MicrNo;
        private int _RECHDR_SMSFlag;
        private string _RECHDR_Remark;
        private int _RECHDR_PayStatus;
        private int _Editable;
        #endregion

        /// <summary>
        /// Default constructor for ACCReceiptHDRTRN class.
        /// </summary>
        public ACCReceiptHDRTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCReceiptHDRTRN(decimal RECHDR_ReceiptNo, string RECHDR_ReceiptRefNo, string RECHDR_Date, int RECHDR_CorporateID, decimal RECHDR_ApplicationID, int RECHDR_ReceiptType, Int32 RECHDR_PayMode, string RECHDR_ChequeNo, string RECHDR_ChequeDate, decimal RECHDR_ChequeAmount, int RECHDR_CreatedByUserID, string RECHDR_CreatedDateTime, int RECHDR_UpdatedByUserID, string RECHDR_UpdatedDateTime, int RECHDR_RowStatus, long RECHDR_RowVersion, int Bankid, int centercode, Int64 CHQDTL_MicrNo, int RECHDR_SMSFlag, string RECHDR_Remark, int RECHDR_PayStatus, int Editable)
        {
            this._RECHDR_ReceiptNo = RECHDR_ReceiptNo;
            this._RECHDR_ReceiptRefNo = RECHDR_ReceiptRefNo;
            this._RECHDR_Date = RECHDR_Date;
            this._RECHDR_CorporateID = RECHDR_CorporateID;
            this._RECHDR_ApplicationID = RECHDR_ApplicationID;
            this._RECHDR_ReceiptType = RECHDR_ReceiptType;
            this._RECHDR_PayMode = RECHDR_PayMode;
            this._RECHDR_ChequeNo = RECHDR_ChequeNo;
            this._RECHDR_ChequeDate = RECHDR_ChequeDate;
            this._RECHDR_ChequeAmount = RECHDR_ChequeAmount;
            this._RECHDR_CreatedByUserID = RECHDR_CreatedByUserID;
            this._RECHDR_CreatedDateTime = RECHDR_CreatedDateTime;
            this._RECHDR_UpdatedByUserID = RECHDR_UpdatedByUserID;
            this._RECHDR_UpdatedDateTime = RECHDR_UpdatedDateTime;
            this._RECHDR_RowStatus = RECHDR_RowStatus;
            this._RECHDR_RowVersion = RECHDR_RowVersion;
            this._Bankid = Bankid;
            this._centercode = centercode;
            this._CHQDTL_MicrNo = CHQDTL_MicrNo;
            this._RECHDR_SMSFlag = RECHDR_SMSFlag;
            this._RECHDR_Remark = RECHDR_Remark;
            this._RECHDR_PayStatus = RECHDR_PayStatus;
            this._Editable = Editable;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Bankid
        {
            get { return _Bankid; }
            set { _Bankid = value; }
        }
        public int centercode
        {
            get { return _centercode; }
            set { _centercode = value; }
        }
        public Int64 CHQDTL_MicrNo
        {
            get { return _CHQDTL_MicrNo; }
            set { _CHQDTL_MicrNo = value; }
        }

        public decimal RECHDR_ReceiptNo
        {
            get { return _RECHDR_ReceiptNo; }
            set { _RECHDR_ReceiptNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_ReceiptRefNo
        {
            get { return _RECHDR_ReceiptRefNo; }
            set { _RECHDR_ReceiptRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_Date
        {
            get { return _RECHDR_Date; }
            set { _RECHDR_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_CorporateID
        {
            get { return _RECHDR_CorporateID; }
            set { _RECHDR_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECHDR_ApplicationID
        {
            get { return _RECHDR_ApplicationID; }
            set { _RECHDR_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_ReceiptType
        {
            get { return _RECHDR_ReceiptType; }
            set { _RECHDR_ReceiptType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int32 RECHDR_PayMode
        {
            get { return _RECHDR_PayMode; }
            set { _RECHDR_PayMode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_ChequeNo
        {
            get { return _RECHDR_ChequeNo; }
            set { _RECHDR_ChequeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_ChequeDate
        {
            get { return _RECHDR_ChequeDate; }
            set { _RECHDR_ChequeDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECHDR_ChequeAmount
        {
            get { return _RECHDR_ChequeAmount; }
            set { _RECHDR_ChequeAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_CreatedByUserID
        {
            get { return _RECHDR_CreatedByUserID; }
            set { _RECHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_CreatedDateTime
        {
            get { return _RECHDR_CreatedDateTime; }
            set { _RECHDR_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_UpdatedByUserID
        {
            get { return _RECHDR_UpdatedByUserID; }
            set { _RECHDR_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_UpdatedDateTime
        {
            get { return _RECHDR_UpdatedDateTime; }
            set { _RECHDR_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_RowStatus
        {
            get { return _RECHDR_RowStatus; }
            set { _RECHDR_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long RECHDR_RowVersion
        {
            get { return _RECHDR_RowVersion; }
            set { _RECHDR_RowVersion = value; }
        }
        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_SMSFlag
        {
            get { return _RECHDR_SMSFlag; }
            set { _RECHDR_SMSFlag = value; }
        }
        public string RECHDR_Remark
        {
            get { return _RECHDR_Remark; }
            set { _RECHDR_Remark = value; }
        }

        public int RECHDR_PayStatus
        {
            get { return _RECHDR_PayStatus; }
            set { _RECHDR_PayStatus = value; }
        }

        public int Editable
        {
            get { return _Editable; }
            set { _Editable = value; }
        }
    }

    public class ACCReceiptHDRTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private decimal _RECHDR_ReceiptNo;
        private string _RECHDR_ReceiptRefNo;
        private string _RECHDR_Date;
        private string _RECHDR_ReceiptType;
        private string _RECHDR_PayMode;
        private decimal _RECHDR_ChequeAmount;
        private string _Appno;
        private string _APPMST_CustomerID;
        private string _Name;
        private string _Area;
        private string _RECHDR_ChequeNo;
        private decimal _Balance;
        private string _RECHDR_ChequeStatus;
        private string _RECHDR_RowStatus;
        private int _RECHDR_ReceiptId;
        private int _Count;
        private int _ChecqueStatus;
        #endregion
        public ACCReceiptHDRTRNList() { }
        public ACCReceiptHDRTRNList(decimal RECHDR_ReceiptNo, string RECHDR_ReceiptRefNo, string RECHDR_Date, string RECHDR_ReceiptType, string RECHDR_PayMode, decimal RECHDR_ChequeAmount, string appno, string APPMST_CustomerID, string name, string area, string RECHDR_ChequeNo, decimal balance, string RECHDR_ChequeStatus, string RECHDR_RowStatus, int RECHDR_ReceiptId, int Count)
        {
            this._RECHDR_ReceiptNo = RECHDR_ReceiptNo;
            this._RECHDR_ReceiptRefNo = RECHDR_ReceiptRefNo;
            this._RECHDR_Date = RECHDR_Date;
            this._RECHDR_ReceiptType = RECHDR_ReceiptType;
            this._RECHDR_PayMode = RECHDR_PayMode;
            this._RECHDR_ChequeAmount = RECHDR_ChequeAmount;
            this._Appno = appno;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._Name = name;
            this._Area = area;
            this. _RECHDR_ChequeNo=RECHDR_ChequeNo;
            this._Balance = balance;
            this._RECHDR_ChequeStatus = RECHDR_ChequeStatus;
            this._RECHDR_RowStatus = RECHDR_RowStatus;
            this._RECHDR_ReceiptId = RECHDR_ReceiptId;
            this._Count = Count;
        }
        public ACCReceiptHDRTRNList(int ChecqueStatus)
        {
            this._ChecqueStatus = ChecqueStatus;
        }

        public decimal RECHDR_ReceiptNo
        {
            get { return _RECHDR_ReceiptNo; }
            set { _RECHDR_ReceiptNo = value; }
        }
        public string RECHDR_ReceiptRefNo
        {
            get { return _RECHDR_ReceiptRefNo; }
            set { _RECHDR_ReceiptRefNo = value; }
        }
        public string RECHDR_Date
        {
            get { return _RECHDR_Date; }
            set { _RECHDR_Date = value; }
        }
        public string RECHDR_ReceiptType
        {
            get { return _RECHDR_ReceiptType; }
            set { _RECHDR_ReceiptType = value; }
        }
        public string RECHDR_PayMode
        {
            get { return _RECHDR_PayMode; }
            set { _RECHDR_PayMode = value; }
        }
        public decimal RECHDR_ChequeAmount
        {
            get { return _RECHDR_ChequeAmount; }
            set { _RECHDR_ChequeAmount = value; }
        }
        public string Appno
        {
            get { return _Appno; }
            set { _Appno = value; }
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
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }
        public string RECHDR_ChequeNo
        {
            get { return _RECHDR_ChequeNo; }
            set { _RECHDR_ChequeNo = value; }
        }
        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        public string RECHDR_ChequeStatus
        {
            get { return _RECHDR_ChequeStatus; }
            set { _RECHDR_ChequeStatus = value; }
        }

        public string RECHDR_RowStatus
        {
            get { return _RECHDR_RowStatus; }
            set { _RECHDR_RowStatus = value; }
        }
        
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public int ChecqueStatus
        {
            get { return _ChecqueStatus; }
            set { _ChecqueStatus = value; }
        }
        public int RECHDR_ReceiptId
        {
            get { return _RECHDR_ReceiptId; }
            set { _RECHDR_ReceiptId = value; }
        }
    }


    public class ACCReceiptHDRTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public ACCReceiptHDRTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ACCReceiptHDRTRNMsg(int RetVal, string RetStr)
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
    
    public class ACCReceiptDTLTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RECDTL_ID;
        private decimal _RECDTL_ReceiptNo;
        private int _RECDTL_RefId;
        private int _RECDTL_RefType;
        private int _RECDTL_HeadId;
        private decimal _RECDTL_Amount;
        private decimal _RECDTL_Balance;
        private Int64 _RECDTL_TransactionID;
        
        #endregion

        /// <summary>
        /// Default constructor for ACCReceiptDTLTRN class.
        /// </summary>
        public ACCReceiptDTLTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCReceiptDTLTRN(int RECDTL_ID, decimal RECDTL_ReceiptNo, int RECDTL_RefId, int RECDTL_RefType, int RECDTL_HeadId, decimal RECDTL_Amount, decimal RECDTL_Balance, Int64 RECDTL_TransactionID)
        {
            this._RECDTL_ID = RECDTL_ID;
            this._RECDTL_ReceiptNo = RECDTL_ReceiptNo;
            this._RECDTL_RefId = RECDTL_RefId;
            this._RECDTL_RefType = RECDTL_RefType;
            this._RECDTL_HeadId = RECDTL_HeadId;
            this._RECDTL_Amount = RECDTL_Amount;
            this._RECDTL_Balance = RECDTL_Balance;
            this._RECDTL_TransactionID = RECDTL_TransactionID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECDTL_ID
        {
            get { return _RECDTL_ID; }
            set { _RECDTL_ID = value; }
        }
        

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECDTL_ReceiptNo
        {
            get { return _RECDTL_ReceiptNo; }
            set { _RECDTL_ReceiptNo = value; }
        }
        
        public int RECDTL_RefId
        {
            get { return _RECDTL_RefId; }
            set { _RECDTL_RefId = value; }
        }

        public int RECDTL_RefType
        {
            get { return _RECDTL_RefType; }
            set { _RECDTL_RefType = value; }
        }        

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECDTL_HeadId
        {
            get { return _RECDTL_HeadId; }
            set { _RECDTL_HeadId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECDTL_Amount
        {
            get { return _RECDTL_Amount; }
            set { _RECDTL_Amount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECDTL_Balance
        {
            get { return _RECDTL_Balance; }
            set { _RECDTL_Balance = value; }
        }

        public Int64 RECDTL_TransactionID
        {
            get { return _RECDTL_TransactionID; }
            set { _RECDTL_TransactionID = value; }
        }
    }

    public class ACCReceiptDTLTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private string _INVHDR_InvoiceRefNo;
        private int _RECDTL_RefID;
        private int _RECDTL_RefType;        
        private int _RECDTL_HeadId;
        private string _HeadName;
        private decimal _RECDTL_Amount;
        private Int64 _RECDTL_TransactionID;

        #endregion
        public ACCReceiptDTLTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public ACCReceiptDTLTRNList(string INVHDR_InvoiceRefNo, int RECDTL_RefID, int RECDTL_RefType, int RECDTL_HeadId, string HeadName, decimal RECDTL_Amount, Int64 RECDTL_TransactionID)
        {
            this._INVHDR_InvoiceRefNo = INVHDR_InvoiceRefNo;
            this._RECDTL_RefID = RECDTL_RefID;
            this._RECDTL_RefType = RECDTL_RefType;
            this._RECDTL_HeadId = RECDTL_HeadId;
            this._HeadName = HeadName;
            this._RECDTL_Amount = RECDTL_Amount;
            this._RECDTL_TransactionID = RECDTL_TransactionID;
        }
        public int RECDTL_HeadId
        {
            get { return _RECDTL_HeadId; }
            set { _RECDTL_HeadId = value; }
        }
        public int RECDTL_RefID
        {
            get { return _RECDTL_RefID; }
            set { _RECDTL_RefID = value; }
        }

        public int RECDTL_RefType
        {
            get { return _RECDTL_RefType; }
            set { _RECDTL_RefType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string HeadName
        {
            get { return _HeadName; }
            set { _HeadName = value; }
        }

        public string INVHDR_InvoiceRefNo
        {
            get { return _INVHDR_InvoiceRefNo; }
            set { _INVHDR_InvoiceRefNo = value; }
        }
        public decimal RECDTL_Amount
        {
            get { return _RECDTL_Amount; }
            set { _RECDTL_Amount = value; }
        }

        public Int64 RECDTL_TransactionID
        {
            get { return _RECDTL_TransactionID; }
            set { _RECDTL_TransactionID = value; }
        }
    }

    
    public class TarrifFromPlan
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
        public TarrifFromPlan() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        /// 

        public TarrifFromPlan(decimal AmountDue)
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
    
    public class AmountDueToPaid
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        // private decimal _ApplicationId;
        //private int _CenterCode;
        private decimal _DueAmt;
        private int _TariffID;
        #endregion

        /// <summary>
        /// Default constructor for ACCReceiptDTLTRN class.
        /// </summary>
        public AmountDueToPaid() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        /// 

        public AmountDueToPaid(decimal DueAmt, int TariffID)
        {

            // this._ApplicationId = Applicationid;
            // this._CenterCode = centercode;
            this._DueAmt = DueAmt;
            this._TariffID = TariffID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public decimal DueAmt
        {
            get { return _DueAmt; }
            set { _DueAmt = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TariffID
        {
            get { return _TariffID; }
            set { _TariffID = value; }
        }

    }


}

