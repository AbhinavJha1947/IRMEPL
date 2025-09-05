//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{

    
    public class ACCRefundHDRTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _REFHDR_RefundNo;
        private string _REFHDR_RefundRefNo;
        private string _REFHDR_Date;
        private int _REFHDR_CorporateID;
        private decimal _REFHDR_ApplicationID;
        private int _REFHDR_RefundType;
        private Int32 _REFHDR_PayMode;
        private string _REFHDR_ChequeNo;
        private string _REFHDR_ChequeDate;
        private decimal _REFHDR_ChequeAmount;
        private int _REFHDR_CreatedByUserID;
        private string _REFHDR_CreatedDateTime;
        private int _REFHDR_UpdatedByUserID;
        private string _REFHDR_UpdatedDateTime;
        private int _REFHDR_RowStatus;
        private long _REFHDR_RowVersion;
        private int _Bankid;
        private int _centercode;
        private Int64 _CHQDTL_MicrNo;
        private int _REFHDR_SMSFlag;
        private string _REFHDR_Remark;
        private int _REFHDR_PayStatus;
        #endregion

        /// <summary>
        /// Default constructor for ACCRefundHDRTRN class.
        /// </summary>
        public ACCRefundHDRTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCRefundHDRTRN(decimal REFHDR_RefundNo, string REFHDR_RefundRefNo, string REFHDR_Date, int REFHDR_CorporateID, decimal REFHDR_ApplicationID, int REFHDR_RefundType, Int32 REFHDR_PayMode, string REFHDR_ChequeNo, string REFHDR_ChequeDate, decimal REFHDR_ChequeAmount, int REFHDR_CreatedByUserID, string REFHDR_CreatedDateTime, int REFHDR_UpdatedByUserID, string REFHDR_UpdatedDateTime, int REFHDR_RowStatus, long REFHDR_RowVersion, int Bankid, int centercode, Int64 CHQDTL_MicrNo, int REFHDR_SMSFlag, string REFHDR_Remark, int REFHDR_PayStatus)
        {
            this._REFHDR_RefundNo = REFHDR_RefundNo;
            this._REFHDR_RefundRefNo = REFHDR_RefundRefNo;
            this._REFHDR_Date = REFHDR_Date;
            this._REFHDR_CorporateID = REFHDR_CorporateID;
            this._REFHDR_ApplicationID = REFHDR_ApplicationID;
            this._REFHDR_RefundType = REFHDR_RefundType;
            this._REFHDR_PayMode = REFHDR_PayMode;
            this._REFHDR_ChequeNo = REFHDR_ChequeNo;
            this._REFHDR_ChequeDate = REFHDR_ChequeDate;
            this._REFHDR_ChequeAmount = REFHDR_ChequeAmount;
            this._REFHDR_CreatedByUserID = REFHDR_CreatedByUserID;
            this._REFHDR_CreatedDateTime = REFHDR_CreatedDateTime;
            this._REFHDR_UpdatedByUserID = REFHDR_UpdatedByUserID;
            this._REFHDR_UpdatedDateTime = REFHDR_UpdatedDateTime;
            this._REFHDR_RowStatus = REFHDR_RowStatus;
            this._REFHDR_RowVersion = REFHDR_RowVersion;
            this._Bankid = Bankid;
            this._centercode = centercode;
            this._CHQDTL_MicrNo = CHQDTL_MicrNo;
            this._REFHDR_SMSFlag = REFHDR_SMSFlag;
            this._REFHDR_Remark = REFHDR_Remark;
            this._REFHDR_PayStatus = REFHDR_PayStatus;
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

        public decimal REFHDR_RefundNo
        {
            get { return _REFHDR_RefundNo; }
            set { _REFHDR_RefundNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFHDR_RefundRefNo
        {
            get { return _REFHDR_RefundRefNo; }
            set { _REFHDR_RefundRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFHDR_Date
        {
            get { return _REFHDR_Date; }
            set { _REFHDR_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFHDR_CorporateID
        {
            get { return _REFHDR_CorporateID; }
            set { _REFHDR_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFHDR_ApplicationID
        {
            get { return _REFHDR_ApplicationID; }
            set { _REFHDR_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFHDR_RefundType
        {
            get { return _REFHDR_RefundType; }
            set { _REFHDR_RefundType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int32 REFHDR_PayMode
        {
            get { return _REFHDR_PayMode; }
            set { _REFHDR_PayMode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFHDR_ChequeNo
        {
            get { return _REFHDR_ChequeNo; }
            set { _REFHDR_ChequeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFHDR_ChequeDate
        {
            get { return _REFHDR_ChequeDate; }
            set { _REFHDR_ChequeDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFHDR_ChequeAmount
        {
            get { return _REFHDR_ChequeAmount; }
            set { _REFHDR_ChequeAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFHDR_CreatedByUserID
        {
            get { return _REFHDR_CreatedByUserID; }
            set { _REFHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFHDR_CreatedDateTime
        {
            get { return _REFHDR_CreatedDateTime; }
            set { _REFHDR_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFHDR_UpdatedByUserID
        {
            get { return _REFHDR_UpdatedByUserID; }
            set { _REFHDR_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string REFHDR_UpdatedDateTime
        {
            get { return _REFHDR_UpdatedDateTime; }
            set { _REFHDR_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFHDR_RowStatus
        {
            get { return _REFHDR_RowStatus; }
            set { _REFHDR_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long REFHDR_RowVersion
        {
            get { return _REFHDR_RowVersion; }
            set { _REFHDR_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFHDR_SMSFlag
        {
            get { return _REFHDR_SMSFlag; }
            set { _REFHDR_SMSFlag = value; }
        }
        public string REFHDR_Remark
        {
            get { return _REFHDR_Remark; }
            set { _REFHDR_Remark = value; }
        }

        public int REFHDR_PayStatus
        {
            get { return _REFHDR_PayStatus; }
            set { _REFHDR_PayStatus = value; }
        }
    }

    public class ACCRefundHDRTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private decimal _REFHDR_RefundNo;
        private string _REFHDR_RefundRefNo;
        private string _REFHDR_Date;
        private string _REFHDR_RefundType;
        private string _REFHDR_PayMode;
        private decimal _REFHDR_ChequeAmount;
        private string _Appno;
        private string _APPMST_CustomerID;
        private string _Name;
        private string _Area;
        private string _REFHDR_ChequeNo;
        private decimal _Balance;
        private string _REFHDR_ChequeStatus;
        private string _REFHDR_RowStatus;
        private int _REFHDR_RefundId;
        private int _Count;
        private int _ChecqueStatus;
        #endregion
        public ACCRefundHDRTRNList() { }
        public ACCRefundHDRTRNList(decimal REFHDR_RefundNo, string REFHDR_RefundRefNo, string REFHDR_Date, string REFHDR_RefundType, string REFHDR_PayMode, decimal REFHDR_ChequeAmount, string appno, string APPMST_CustomerID, string name, string area, string REFHDR_ChequeNo, decimal balance, string REFHDR_ChequeStatus, string REFHDR_RowStatus, int REFHDR_RefundId, int Count)
        {
            this._REFHDR_RefundNo = REFHDR_RefundNo;
            this._REFHDR_RefundRefNo = REFHDR_RefundRefNo;
            this._REFHDR_Date = REFHDR_Date;
            this._REFHDR_RefundType = REFHDR_RefundType;
            this._REFHDR_PayMode = REFHDR_PayMode;
            this._REFHDR_ChequeAmount = REFHDR_ChequeAmount;
            this._Appno = appno;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._Name = name;
            this._Area = area;
            this._REFHDR_ChequeNo = REFHDR_ChequeNo;
            this._Balance = balance;
            this._REFHDR_ChequeStatus = REFHDR_ChequeStatus;
            this._REFHDR_RowStatus = REFHDR_RowStatus;
            this._REFHDR_RefundId = REFHDR_RefundId;
            this._Count = Count;
        }
        public ACCRefundHDRTRNList(int ChecqueStatus)
        {
            this._ChecqueStatus = ChecqueStatus;
        }

        public decimal REFHDR_RefundNo
        {
            get { return _REFHDR_RefundNo; }
            set { _REFHDR_RefundNo = value; }
        }
        public string REFHDR_RefundRefNo
        {
            get { return _REFHDR_RefundRefNo; }
            set { _REFHDR_RefundRefNo = value; }
        }
        public string REFHDR_Date
        {
            get { return _REFHDR_Date; }
            set { _REFHDR_Date = value; }
        }
        public string REFHDR_RefundType
        {
            get { return _REFHDR_RefundType; }
            set { _REFHDR_RefundType = value; }
        }
        public string REFHDR_PayMode
        {
            get { return _REFHDR_PayMode; }
            set { _REFHDR_PayMode = value; }
        }
        public decimal REFHDR_ChequeAmount
        {
            get { return _REFHDR_ChequeAmount; }
            set { _REFHDR_ChequeAmount = value; }
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
        public string REFHDR_ChequeNo
        {
            get { return _REFHDR_ChequeNo; }
            set { _REFHDR_ChequeNo = value; }
        }
        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        public string REFHDR_ChequeStatus
        {
            get { return _REFHDR_ChequeStatus; }
            set { _REFHDR_ChequeStatus = value; }
        }

        public string REFHDR_RowStatus
        {
            get { return _REFHDR_RowStatus; }
            set { _REFHDR_RowStatus = value; }
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
        public int REFHDR_RefundId
        {
            get { return _REFHDR_RefundId; }
            set { _REFHDR_RefundId = value; }
        }
    }


    public class ACCRefundHDRTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public ACCRefundHDRTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ACCRefundHDRTRNMsg(int RetVal, string RetStr)
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
    
    public class ACCRefundDTLTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _REFDTL_ID;
        private decimal _REFDTL_RefundNo;
        private int _REFDTL_RefId;
        private int _REFDTL_RefType;
        private int _REFDTL_HeadId;
        private decimal _REFDTL_Amount;
        private decimal _REFDTL_Balance;
        private Int64 _REFDTL_TransactionID;

        #endregion

        /// <summary>
        /// Default constructor for ACCRefundDTLTRN class.
        /// </summary>
        public ACCRefundDTLTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCRefundDTLTRN(int REFDTL_ID, decimal REFDTL_RefundNo, int REFDTL_RefId, int REFDTL_RefType, int REFDTL_HeadId, decimal REFDTL_Amount, decimal REFDTL_Balance, Int64 REFDTL_TransactionID)
        {
            this._REFDTL_ID = REFDTL_ID;
            this._REFDTL_RefundNo = REFDTL_RefundNo;
            this._REFDTL_RefId = REFDTL_RefId;
            this._REFDTL_RefType = REFDTL_RefType;
            this._REFDTL_HeadId = REFDTL_HeadId;
            this._REFDTL_Amount = REFDTL_Amount;
            this._REFDTL_Balance = REFDTL_Balance;
            this._REFDTL_TransactionID = REFDTL_TransactionID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFDTL_ID
        {
            get { return _REFDTL_ID; }
            set { _REFDTL_ID = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFDTL_RefundNo
        {
            get { return _REFDTL_RefundNo; }
            set { _REFDTL_RefundNo = value; }
        }

        public int REFDTL_RefId
        {
            get { return _REFDTL_RefId; }
            set { _REFDTL_RefId = value; }
        }

        public int REFDTL_RefType
        {
            get { return _REFDTL_RefType; }
            set { _REFDTL_RefType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int REFDTL_HeadId
        {
            get { return _REFDTL_HeadId; }
            set { _REFDTL_HeadId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFDTL_Amount
        {
            get { return _REFDTL_Amount; }
            set { _REFDTL_Amount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal REFDTL_Balance
        {
            get { return _REFDTL_Balance; }
            set { _REFDTL_Balance = value; }
        }

        public Int64 REFDTL_TransactionID
        {
            get { return _REFDTL_TransactionID; }
            set { _REFDTL_TransactionID = value; }
        }
    }

    public class ACCRefundDTLTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private string _INVHDR_InvoiceRefNo;
        private int _REFDTL_RefID;
        private int _REFDTL_RefType;
        private int _REFDTL_HeadId;
        private string _HeadName;
        private string _RefType;
        private decimal _REFDTL_Amount;
        private Int64 _REFDTL_TransactionID;

        #endregion
        public ACCRefundDTLTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public ACCRefundDTLTRNList(string INVHDR_InvoiceRefNo, int REFDTL_RefID, int REFDTL_RefType, int REFDTL_HeadId, string HeadName, decimal REFDTL_Amount, Int64 REFDTL_TransactionID, string RefType)
        {
            this._INVHDR_InvoiceRefNo = INVHDR_InvoiceRefNo;
            this._REFDTL_RefID = REFDTL_RefID;
            this._REFDTL_RefType = REFDTL_RefType;
            this._REFDTL_HeadId = REFDTL_HeadId;
            this._HeadName = HeadName;
            this._REFDTL_Amount = REFDTL_Amount;
            this._REFDTL_TransactionID = REFDTL_TransactionID;
            this._RefType = RefType;
        }
        public int REFDTL_HeadId
        {
            get { return _REFDTL_HeadId; }
            set { _REFDTL_HeadId = value; }
        }
        public int REFDTL_RefID
        {
            get { return _REFDTL_RefID; }
            set { _REFDTL_RefID = value; }
        }

        public int REFDTL_RefType
        {
            get { return _REFDTL_RefType; }
            set { _REFDTL_RefType = value; }
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
        public decimal REFDTL_Amount
        {
            get { return _REFDTL_Amount; }
            set { _REFDTL_Amount = value; }
        }

        public Int64 REFDTL_TransactionID
        {
            get { return _REFDTL_TransactionID; }
            set { _REFDTL_TransactionID = value; }
        }

        public string RefType
        {
            get { return _RefType; }
            set { _RefType = value; }
        }
    }
}

